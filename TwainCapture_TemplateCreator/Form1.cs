using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace TwainCapture_TemplateCreator
{
    public partial class Form1 : Form
    {
        private int boxLocX = 0, boxLocY = 0, clickOffsetX = 0, clickOffsetY = 0;
        private Control grabbed;
        private bool isDragging = false;
        private bool b_isSettingSequence = false;
        private int seq_Index = 1;
        private bool seq_Set = false;
        string selectedExam = "";

        /// <summary>
        /// Initialization of the Form and controls.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            pbx_NewBotPA.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbx_NewLeftBW.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbx_NewRightBW.Image.RotateFlip(RotateFlipType.Rotate90FlipX);

            foreach (Control c in this.pan_Template.Controls)
            {
                c.MouseMove += new MouseEventHandler(pan_Template_MouseMove);
                c.MouseUp += new MouseEventHandler(pan_Template_MouseUp);
                c.MouseDown += new MouseEventHandler(pan_Template_MouseDown);
            }
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+ "\\Digital Doc\\TwainCapture\\Templates");
            foreach (string file in files) 
            {
                if(Path.GetFileName(file).Contains(".xml"))
                    cb_ExistingExams.Items.Add(Path.GetFileNameWithoutExtension(file));
                selectedExam = Path.GetFileName(file);
            }

        }

        /// <summary>
        /// Adds a new Bitewing Box to the Template Panel with the top facing =>>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_NewHorizBox_Click(object sender, EventArgs e)
        {
            pan_Template.Controls.Add(PicBox(new Size(90, 120), boxLocX, boxLocY, 90, true, true, true, "R"));
            boxLocX += 25;
        }

        /// <summary>
        /// Adds a new Bitewing box with the top facing <<=
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_NewRightBW_Click(object sender, EventArgs e)
        {
            pan_Template.Controls.Add(PicBox(new Size(90, 120), boxLocX, boxLocY, 90, true, false, false, "L"));
            boxLocX += 25;
            if (boxLocX >= pan_Template.Size.Width - 90)
            {
                boxLocX = 0;
                boxLocY += 130;
            }
        }

        /// <summary>
        /// Adds new Vertical PA with the top going UP ^
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_NewTopPA_Click(object sender, EventArgs e)
        {
            pan_Template.Controls.Add(PicBox(new Size(90, 120), boxLocX, boxLocY, 0, false, false, false, "U"));
            boxLocX += 25;
            if (boxLocX >= pan_Template.Size.Width - 90)
            {
                boxLocX = 0;
                boxLocY += 130;
            }
        }

        /// <summary>
        /// Adds a new inverted PA with the top pointed DOWN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_NewBotPA_Click(object sender, EventArgs e)
        {
            pan_Template.Controls.Add(PicBox(new Size(90, 120), boxLocX, boxLocY, 0, false, true, true, "D"));
            boxLocX += 25;
            if (boxLocX >= pan_Template.Size.Width - 90)
            {
                boxLocX = 0;
                boxLocY += 130;
            }
        }

        /// <summary>
        /// Clears all controls from the template panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            pan_Template.Controls.Clear();
            seq_Set = false;

        }

        /// <summary>
        /// Starts the trigger for the dragging action or creates a context menu for the selected control. Also allows the setting of the capture sequence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pan_Template_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            grabbed = sender as PictureBox;
            clickOffsetX = e.X;
            clickOffsetY = e.Y;
            Console.WriteLine(grabbed.TabIndex.ToString());
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add("Delete", RemoveControl);
                isDragging = false;

                contextMenu.Show(this, new Point(e.X + grabbed.Left - clickOffsetX, e.Y + grabbed.Top - clickOffsetY));
            }
            if (grabbed.Controls.Count == 0)
            {
                if (b_isSettingSequence && seq_Index <= pan_Template.Controls.Count && grabbed.TabIndex <= pan_Template.Controls.Count)
                {
                    grabbed.TabIndex = seq_Index;
                    seq_Index++;
                    Label lab = new Label();
                    lab.Size = new Size(20, 20);
                    grabbed.Controls.Add(lab);

                    lab.Text = grabbed.TabIndex.ToString();
                    lab.Visible = true;
                    lab.Dock = DockStyle.Top;
                    //lab.Location = new Point(grabbed.Location.X + 5, grabbed.Location.Y + 5);
                    lab.BringToFront();
                }
            }
        }

        /// <summary>
        /// Deletes the selected control from the Template Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveControl(object sender, EventArgs e)
        {
            pan_Template.Controls.Remove(grabbed);
        }

        /// <summary>
        /// Functionality for the drag process for the selected control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pan_Template_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && grabbed != null)
            {
                grabbed.Left = e.X + grabbed.Left - clickOffsetX;
                grabbed.Top = e.Y + grabbed.Top - clickOffsetY;
            }
        }

        /// <summary>
        /// Stops the dragging process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pan_Template_MouseUp(object sender, MouseEventArgs e)
        {
            grabbed.Location = SnapToGrid(grabbed.Left, grabbed.Top);
            isDragging = false;
        }

        /// <summary>
        /// Clears the text from the template name should the box be selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Enter(object sender, EventArgs e)
        {
            tb_TemplateName.Clear();
        }

        /// <summary>
        /// Sets the sequence of the acquisition.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetSequence_Click(object sender, EventArgs e)
        {
            //start mousedown event listerner for each contrl, on click set its sequence #.
            if (!b_isSettingSequence)
            {
                b_isSettingSequence = true;
                btn_SetSequence.Image = TwainCapture_TemplateCreator.Properties.Resources.setSeq_red25;
                btn_SetSequence.Text = "Save Capture Sequence";
                seq_Set = true;
            }
            else
            {
                b_isSettingSequence = false;
                btn_SetSequence.Image = TwainCapture_TemplateCreator.Properties.Resources.Sequence25;
                seq_Index = 1;
                btn_SetSequence.Text = "Set Capture Sequence";
            }
        }
        /// <summary>
        /// Clears Panel of all created Images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            btn_Clear_Click(sender, e);
        }




        /// <summary>
        /// Populate Panel with the exame selected in cb_ExistingExams.Text by parsing XML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string[] lines = { };
        private void btn_LoadMount_Click(object sender, EventArgs e)
        {
            if (cb_ExistingExams.SelectedValue == string.Empty || cb_ExistingExams.SelectedItem == null) 
            {
                if (DialogResult.OK == MessageBox.Show("Please Select an Exam to load.", "No Exam To Load", MessageBoxButtons.OK, MessageBoxIcon.Hand)) 
                {
                    return;
                }
            }
            pan_Template.Controls.Clear();
            tb_TemplateName.Text = cb_ExistingExams.Text;
            int rotation = 0;
            bool horz = false;
            string TemplatePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+@"\Digital Doc\TwainCapture\Templates\"+cb_ExistingExams.Text + ".xml";
            lines = File.ReadAllLines(TemplatePath);
            string direction = "";
            
            for(int i=0;i <= lines.Length-7;i++) 
            {
                
                if (lines[i].Contains("Image") && !lines[i].Contains("Count"))
                {
                    Console.WriteLine(lines[i]);
                    string xstr1 = lines[i + 3].Trim();
                    string xstr2 = string.Empty;
                    int xCoord = 0;
                    var matches = Regex.Matches(xstr1, @"\d+");
                    foreach (var match in matches)
                        xstr2 += match;
                    xCoord = int.Parse(xstr2);

                    string ystr1 = lines[i + 4].Trim();
                    string ystr2 = string.Empty;
                    int yCoord = 0;
                    var ymatches = Regex.Matches(ystr1, @"\d+");
                    foreach (var match in ymatches)
                        ystr2 += match;
                    yCoord = int.Parse(ystr2);

                    if (lines[i + 7].Contains("90")) {
                        rotation = 90;
                        horz = true;
                    }
                    else 
                    {
                        rotation = 0;
                        horz = false;
                        if (lines[i + 6].Contains("True"))
                            direction = "D";
                        else
                            direction = "U";
                    }
                    if (horz && lines[i + 5].Contains("True")&&lines[i+6].Contains("True"))
                    {
                        direction = "R";
                    }
                    else
                        direction = "L";

                    pan_Template.Controls.Add(PicBox(new Size(90, 120), xCoord, yCoord,rotation,horz, lines[i + 6].Contains("True"), lines[i + 5].Contains("True"),direction));
                    //(lines[i+1]);//SizeX
                    //(lines[i+2]);//SizeY
                    //(lines[i+3]);//PositionX
                    //(lines[i+4]);//PositionY
                    //(lines[i+5]);//Mirror
                    //(lines[i+6]);//Flip
                    //(lines[i+7]);//Rotation

                }
            }

        }

        /// <summary>
        /// Delete the source file for the exam, prompt user if sure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteExam_Click(object sender, EventArgs e)
        {
            if (cb_ExistingExams.SelectedValue == string.Empty || cb_ExistingExams.SelectedItem == null)
                if (DialogResult.OK == MessageBox.Show("Please Select an Exam to Delete.", "No Exam Selected", MessageBoxButtons.OK, MessageBoxIcon.Hand))
                    return;

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Delete "+cb_ExistingExams.Text+"?", "Exam Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)) 
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+@"\Digital Doc\TwainCapture\Templates\"+cb_ExistingExams.Text + ".xml");
                cb_ExistingExams.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// Copies Files from Template directory to the User selected directory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                string[] sourceDir = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Digital Doc\TwainCapture\Templates\");
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    foreach (string file in sourceDir) 
                    {
                        string fileName = Path.GetFileName(file);

                        if(Path.GetFileName(file).Contains(".xml"))
                            File.Copy(file, fbd.SelectedPath+"\\"+fileName, true);
                    }
                    System.Windows.Forms.MessageBox.Show("Exams Exported", "Success!");
                }
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                string destDir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Digital Doc\TwainCapture\Templates\";
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);

                        if (Path.GetFileName(file).Contains(".xml"))
                            File.Copy(file, destDir + "\\" + fileName, true);
                    }
                    System.Windows.Forms.MessageBox.Show("Exams Imported", "Success!");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Parses the current Template into an XML file for TwainCapture to read as an available template.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveTemplate_Click(object sender, EventArgs e)
        {
            if (pan_Template.Controls.Count == 0)
            {
                tb_TemplateName.Text = "";
            }
            if (tb_TemplateName.Text == "")
            {
                MessageBox.Show("Please Set a Template nameensure that there are Images present in the Layout.");
            }
            else
            {
                int imgCount = 0;
                foreach (Control c in pan_Template.Controls)
                    if (c is PictureBox)
                    {

                        if (!seq_Set)
                        {
                            MessageBox.Show("Please Set the Capture Sequence before saving.");
                            goto End;
                        }
                        imgCount++;
                    }

                //Tool is designed to be in the same directory as TwainCapture.
                string saveDir = Directory.GetCurrentDirectory();
                string saveFile = @"\" + tb_TemplateName.Text + ".xml";
                //init settings for xml formatting
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                settings.NewLineOnAttributes = true;
                //init writer object
                XmlWriter makexml = XmlWriter.Create(saveDir + saveFile, settings);
                makexml.WriteStartDocument();
                makexml.WriteStartElement("Exam");
                makexml.WriteAttributeString("ExamName", tb_TemplateName.Text);

                makexml.WriteAttributeString("ImageCount", imgCount.ToString());
                makexml.WriteStartElement("Layout");
                string[] imageSequence = new string[imgCount]; //add images into array and then sort them by Image#
                RadiographProperties[] dip = new RadiographProperties[imgCount];
                List<RadiographProperties> rap = new List<RadiographProperties>();
                int index = 0;
                foreach (Control c in pan_Template.Controls)
                    if (c is PictureBox)
                    {


                        string[] parseTag = c.Tag.ToString().Split('-');
                        if (parseTag[0] == "True")
                            parseTag[0] = "90";
                        else
                            parseTag[0] = "0";

                        RadiographProperties cur_image = new RadiographProperties(c.TabIndex, c.Width, c.Height, c.Location.X, c.Location.Y, parseTag[2], parseTag[1], parseTag[0]);
                        dip[index] = cur_image;
                        rap.Add(cur_image);
                        index++;


                    }
                //Sort the array by the sequence number
                List<RadiographProperties> SortedList = rap.OrderBy(o => o.GetSequenceNumber()).ToList();
                foreach (RadiographProperties radiograph in SortedList)
                {
                    makexml.WriteStartElement("Image" + radiograph.GetSequenceNumber());
                    makexml.WriteAttributeString("SizeX", radiograph.GetSizeX().ToString());
                    makexml.WriteAttributeString("SizeY", radiograph.GetSizeY().ToString());
                    makexml.WriteAttributeString("PositionX", radiograph.GetPositionX().ToString());
                    makexml.WriteAttributeString("PositionY", radiograph.GetPositionY().ToString());
                    makexml.WriteAttributeString("Mirror", radiograph.Mirrored().ToString());
                    makexml.WriteAttributeString("Flip", radiograph.Flipped().ToString());
                    makexml.WriteAttributeString("Rotation", radiograph.Rotated().ToString());
                    makexml.WriteEndElement();
                }

                makexml.WriteEndElement();
                makexml.WriteEndElement();
                makexml.WriteEndDocument();
                makexml.Close();
                MessageBox.Show("Template Saved Successfully.");

            End:
                ;
            }
        }

        /// <summary>
        /// Constructor for a picture box with predetermined size
        /// </summary>
        /// <param name="size"></param>
        /// <param name="coordX"></param>
        /// <param name="coordY"></param>
        /// <param name="rotation"></param>
        /// <param name="horz"></param>
        /// <param name="flipped"></param>
        /// <param name="mirror"></param>
        /// <returns></returns>
        private PictureBox PicBox(Size size, int coordX, int coordY, int rotation, bool horz, bool flipped, bool mirror, string direction)
        {
            Image img = TwainCapture_TemplateCreator.Properties.Resources.SensorOrient;
            PictureBox pb = new PictureBox();
            pb.Size = size;
            Point loc = SnapToGrid(coordX, coordY);
            pb.Location = loc;
            pb.BackColor = Color.Gray;
            pb.BorderStyle = BorderStyle.Fixed3D;
            if (rotation == 90)
            {
                pb.Size = new Size(size.Height, size.Width);
            }
            if (horz)
            {
                if (direction=="R")//pb.Image = SensorImage top pointing =>>
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pb.Image = img;
                }
                if(direction=="L") //pb.Image = SensorImage top pointing <<=
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipX);
                    pb.Image = img;
                }
            }
            else
            {
                if (mirror || flipped)
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pb.Image = img;
            }
            pb.MouseMove += new MouseEventHandler(pan_Template_MouseMove);
            pb.MouseUp += new MouseEventHandler(pan_Template_MouseUp);
            pb.MouseDown += new MouseEventHandler(pan_Template_MouseDown);

            pb.Tag = horz.ToString() + "-" + flipped.ToString() + "-" + mirror.ToString();
            //This allows tracking of these properties of the image.

            return pb;
        }

        /// <summary>
        /// Snaps the moved and created controls to the nearest multiple of 10. 0 inclusive.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Point SnapToGrid(int x, int y)
        {
            // Smaller multiple
            int a = (x / 10) * 10;
            int c = (y / 10) * 10;
            // Larger multiple
            int b = a + 10;
            int d = c + 10;
            // Return of closest of two
            int xCoord = (x - a > b - x) ? b : a;
            int yCoord = (y - c > d - y) ? d : c;

            return new Point(xCoord, yCoord);
        }

    }

}