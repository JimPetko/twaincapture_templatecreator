
using System.Drawing;

namespace TwainCapture_TemplateCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pan_Tools = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tb_TemplateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_Sequence = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbx_SetSequence = new System.Windows.Forms.PictureBox();
            this.pbx_ClearImg = new System.Windows.Forms.PictureBox();
            this.pbx_NewBotPA = new System.Windows.Forms.PictureBox();
            this.pbx_NewTopPA = new System.Windows.Forms.PictureBox();
            this.pbx_NewRightBW = new System.Windows.Forms.PictureBox();
            this.pbx_NewLeftBW = new System.Windows.Forms.PictureBox();
            this.pan_Template = new System.Windows.Forms.Panel();
            this.pan_Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_SetSequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ClearImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewBotPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewTopPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewRightBW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewLeftBW)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Tools
            // 
            this.pan_Tools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_Tools.Controls.Add(this.pbx_NewBotPA);
            this.pan_Tools.Controls.Add(this.pbx_NewTopPA);
            this.pan_Tools.Controls.Add(this.splitter1);
            this.pan_Tools.Controls.Add(this.pbx_NewRightBW);
            this.pan_Tools.Controls.Add(this.pbx_NewLeftBW);
            this.pan_Tools.Location = new System.Drawing.Point(1022, 44);
            this.pan_Tools.Name = "pan_Tools";
            this.pan_Tools.Size = new System.Drawing.Size(147, 148);
            this.pan_Tools.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 144);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // tb_TemplateName
            // 
            this.tb_TemplateName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tb_TemplateName.Location = new System.Drawing.Point(1026, 8);
            this.tb_TemplateName.Name = "tb_TemplateName";
            this.tb_TemplateName.Size = new System.Drawing.Size(124, 22);
            this.tb_TemplateName.TabIndex = 3;
            this.tb_TemplateName.Text = "TemplateName";
            this.tb_TemplateName.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(1026, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Image";
            // 
            // lab_Sequence
            // 
            this.lab_Sequence.AutoSize = true;
            this.lab_Sequence.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sequence.Location = new System.Drawing.Point(1069, 211);
            this.lab_Sequence.Name = "lab_Sequence";
            this.lab_Sequence.Size = new System.Drawing.Size(99, 17);
            this.lab_Sequence.TabIndex = 14;
            this.lab_Sequence.Text = " - Set Sequence";
            this.lab_Sequence.Click += new System.EventHandler(this.btn_SetSequence_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1068, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = " - Clear All";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TwainCapture_TemplateCreator.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(1152, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btn_SaveTemplate_Click);
            // 
            // pbx_SetSequence
            // 
            this.pbx_SetSequence.Image = global::TwainCapture_TemplateCreator.Properties.Resources.Sequence;
            this.pbx_SetSequence.Location = new System.Drawing.Point(1029, 206);
            this.pbx_SetSequence.Name = "pbx_SetSequence";
            this.pbx_SetSequence.Size = new System.Drawing.Size(36, 31);
            this.pbx_SetSequence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_SetSequence.TabIndex = 12;
            this.pbx_SetSequence.TabStop = false;
            this.pbx_SetSequence.Click += new System.EventHandler(this.btn_SetSequence_Click);
            // 
            // pbx_ClearImg
            // 
            this.pbx_ClearImg.Image = global::TwainCapture_TemplateCreator.Properties.Resources.ClearImg;
            this.pbx_ClearImg.Location = new System.Drawing.Point(1029, 270);
            this.pbx_ClearImg.Name = "pbx_ClearImg";
            this.pbx_ClearImg.Size = new System.Drawing.Size(36, 31);
            this.pbx_ClearImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_ClearImg.TabIndex = 11;
            this.pbx_ClearImg.TabStop = false;
            this.pbx_ClearImg.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pbx_NewBotPA
            // 
            this.pbx_NewBotPA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbx_NewBotPA.Image = global::TwainCapture_TemplateCreator.Properties.Resources.SensorOrient;
            this.pbx_NewBotPA.Location = new System.Drawing.Point(92, 78);
            this.pbx_NewBotPA.Name = "pbx_NewBotPA";
            this.pbx_NewBotPA.Size = new System.Drawing.Size(45, 60);
            this.pbx_NewBotPA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_NewBotPA.TabIndex = 8;
            this.pbx_NewBotPA.TabStop = false;
            this.pbx_NewBotPA.Click += new System.EventHandler(this.pbx_NewBotPA_Click);
            // 
            // pbx_NewTopPA
            // 
            this.pbx_NewTopPA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbx_NewTopPA.Image = global::TwainCapture_TemplateCreator.Properties.Resources.SensorOrient;
            this.pbx_NewTopPA.Location = new System.Drawing.Point(24, 78);
            this.pbx_NewTopPA.Name = "pbx_NewTopPA";
            this.pbx_NewTopPA.Size = new System.Drawing.Size(45, 60);
            this.pbx_NewTopPA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_NewTopPA.TabIndex = 7;
            this.pbx_NewTopPA.TabStop = false;
            this.pbx_NewTopPA.Click += new System.EventHandler(this.pbx_NewTopPA_Click);
            // 
            // pbx_NewRightBW
            // 
            this.pbx_NewRightBW.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbx_NewRightBW.Image = global::TwainCapture_TemplateCreator.Properties.Resources.SensorOrient;
            this.pbx_NewRightBW.Location = new System.Drawing.Point(19, 3);
            this.pbx_NewRightBW.Name = "pbx_NewRightBW";
            this.pbx_NewRightBW.Size = new System.Drawing.Size(60, 45);
            this.pbx_NewRightBW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_NewRightBW.TabIndex = 1;
            this.pbx_NewRightBW.TabStop = false;
            this.pbx_NewRightBW.Click += new System.EventHandler(this.pbx_NewRightBW_Click);
            // 
            // pbx_NewLeftBW
            // 
            this.pbx_NewLeftBW.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbx_NewLeftBW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx_NewLeftBW.Image = global::TwainCapture_TemplateCreator.Properties.Resources.SensorOrient;
            this.pbx_NewLeftBW.Location = new System.Drawing.Point(85, 3);
            this.pbx_NewLeftBW.Name = "pbx_NewLeftBW";
            this.pbx_NewLeftBW.Size = new System.Drawing.Size(60, 45);
            this.pbx_NewLeftBW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_NewLeftBW.TabIndex = 0;
            this.pbx_NewLeftBW.TabStop = false;
            this.pbx_NewLeftBW.Click += new System.EventHandler(this.pbx_NewHorizBox_Click);
            // 
            // pan_Template
            // 
            this.pan_Template.BackColor = System.Drawing.Color.Gray;
            this.pan_Template.BackgroundImage = global::TwainCapture_TemplateCreator.Properties.Resources.gridB;
            this.pan_Template.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_Template.Location = new System.Drawing.Point(2, 3);
            this.pan_Template.Name = "pan_Template";
            this.pan_Template.Size = new System.Drawing.Size(1020, 670);
            this.pan_Template.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 677);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Sequence);
            this.Controls.Add(this.pbx_SetSequence);
            this.Controls.Add(this.pbx_ClearImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_Tools);
            this.Controls.Add(this.pan_Template);
            this.Controls.Add(this.tb_TemplateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Digital Doc X-Ray Template Creation Tool";
            this.pan_Tools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_SetSequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ClearImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewBotPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewTopPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewRightBW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_NewLeftBW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_Template;
        private System.Windows.Forms.Panel pan_Tools;
        private System.Windows.Forms.PictureBox pbx_NewRightBW;
        private System.Windows.Forms.PictureBox pbx_NewLeftBW;
        private System.Windows.Forms.TextBox tb_TemplateName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pbx_NewBotPA;
        private System.Windows.Forms.PictureBox pbx_NewTopPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx_ClearImg;
        private System.Windows.Forms.PictureBox pbx_SetSequence;
        private System.Windows.Forms.Label lab_Sequence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

