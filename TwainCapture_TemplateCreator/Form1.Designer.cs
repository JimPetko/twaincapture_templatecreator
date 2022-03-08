
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
            this.cb_ExistingExams = new System.Windows.Forms.ComboBox();
            this.btn_LoadExam = new System.Windows.Forms.Button();
            this.btn_DeleteExam = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SetSequence = new System.Windows.Forms.Button();
            this.btn_ClearPanel = new System.Windows.Forms.Button();
            this.btn_SaveExam = new System.Windows.Forms.Button();
            this.pbx_NewBotPA = new System.Windows.Forms.PictureBox();
            this.pbx_NewTopPA = new System.Windows.Forms.PictureBox();
            this.pbx_NewRightBW = new System.Windows.Forms.PictureBox();
            this.pbx_NewLeftBW = new System.Windows.Forms.PictureBox();
            this.pan_Template = new System.Windows.Forms.Panel();
            this.pan_Tools.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pan_Tools.Location = new System.Drawing.Point(1022, 16);
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
            this.tb_TemplateName.Location = new System.Drawing.Point(0, 12);
            this.tb_TemplateName.Name = "tb_TemplateName";
            this.tb_TemplateName.Size = new System.Drawing.Size(143, 22);
            this.tb_TemplateName.TabIndex = 3;
            this.tb_TemplateName.Text = "TemplateName";
            this.tb_TemplateName.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(1026, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Image";
            // 
            // cb_ExistingExams
            // 
            this.cb_ExistingExams.FormattingEnabled = true;
            this.cb_ExistingExams.Location = new System.Drawing.Point(1029, 539);
            this.cb_ExistingExams.Name = "cb_ExistingExams";
            this.cb_ExistingExams.Size = new System.Drawing.Size(150, 21);
            this.cb_ExistingExams.TabIndex = 17;
            // 
            // btn_LoadExam
            // 
            this.btn_LoadExam.Location = new System.Drawing.Point(1029, 566);
            this.btn_LoadExam.Name = "btn_LoadExam";
            this.btn_LoadExam.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadExam.TabIndex = 18;
            this.btn_LoadExam.Text = "Edit Exam";
            this.btn_LoadExam.UseVisualStyleBackColor = true;
            this.btn_LoadExam.Click += new System.EventHandler(this.btn_LoadMount_Click);
            // 
            // btn_DeleteExam
            // 
            this.btn_DeleteExam.Location = new System.Drawing.Point(1029, 595);
            this.btn_DeleteExam.Name = "btn_DeleteExam";
            this.btn_DeleteExam.Size = new System.Drawing.Size(85, 23);
            this.btn_DeleteExam.TabIndex = 19;
            this.btn_DeleteExam.Text = "Delete Exam";
            this.btn_DeleteExam.UseVisualStyleBackColor = true;
            this.btn_DeleteExam.Click += new System.EventHandler(this.btn_DeleteExam_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(1116, 642);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(53, 23);
            this.btn_Export.TabIndex = 20;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(1057, 642);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(53, 23);
            this.btn_Import.TabIndex = 21;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(1029, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Save Exam";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_SaveExam);
            this.panel1.Controls.Add(this.tb_TemplateName);
            this.panel1.Location = new System.Drawing.Point(1024, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 110);
            this.panel1.TabIndex = 23;
            // 
            // btn_SetSequence
            // 
            this.btn_SetSequence.Image = global::TwainCapture_TemplateCreator.Properties.Resources.Sequence25;
            this.btn_SetSequence.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SetSequence.Location = new System.Drawing.Point(1029, 181);
            this.btn_SetSequence.Name = "btn_SetSequence";
            this.btn_SetSequence.Size = new System.Drawing.Size(165, 27);
            this.btn_SetSequence.TabIndex = 25;
            this.btn_SetSequence.Text = "Set Capture Sequence";
            this.btn_SetSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SetSequence.UseVisualStyleBackColor = true;
            this.btn_SetSequence.Click += new System.EventHandler(this.btn_SetSequence_Click);
            // 
            // btn_ClearPanel
            // 
            this.btn_ClearPanel.Image = global::TwainCapture_TemplateCreator.Properties.Resources.ClearImg25;
            this.btn_ClearPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ClearPanel.Location = new System.Drawing.Point(1029, 370);
            this.btn_ClearPanel.Name = "btn_ClearPanel";
            this.btn_ClearPanel.Size = new System.Drawing.Size(79, 27);
            this.btn_ClearPanel.TabIndex = 24;
            this.btn_ClearPanel.Text = "Clear All";
            this.btn_ClearPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ClearPanel.UseVisualStyleBackColor = true;
            this.btn_ClearPanel.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_SaveExam
            // 
            this.btn_SaveExam.Image = global::TwainCapture_TemplateCreator.Properties.Resources.save25;
            this.btn_SaveExam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveExam.Location = new System.Drawing.Point(68, 40);
            this.btn_SaveExam.Name = "btn_SaveExam";
            this.btn_SaveExam.Size = new System.Drawing.Size(74, 27);
            this.btn_SaveExam.TabIndex = 17;
            this.btn_SaveExam.Text = "Save";
            this.btn_SaveExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveExam.UseVisualStyleBackColor = true;
            this.btn_SaveExam.Click += new System.EventHandler(this.btn_SaveTemplate_Click);
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
            this.ClientSize = new System.Drawing.Size(1205, 677);
            this.Controls.Add(this.btn_SetSequence);
            this.Controls.Add(this.btn_ClearPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_DeleteExam);
            this.Controls.Add(this.btn_LoadExam);
            this.Controls.Add(this.cb_ExistingExams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_Tools);
            this.Controls.Add(this.pan_Template);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Digital Doc X-Ray Template Creation Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pan_Tools.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cb_ExistingExams;
        private System.Windows.Forms.Button btn_LoadExam;
        private System.Windows.Forms.Button btn_DeleteExam;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SaveExam;
        private System.Windows.Forms.Button btn_ClearPanel;
        private System.Windows.Forms.Button btn_SetSequence;
    }
}

