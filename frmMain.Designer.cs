namespace TextToSpeech
{
    partial class frmMain
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
            this.Save = new System.Windows.Forms.Button();
            this.cboSelectVoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.Resume = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Speak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(650, 508);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 37);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cboSelectVoice
            // 
            this.cboSelectVoice.FormattingEnabled = true;
            this.cboSelectVoice.Location = new System.Drawing.Point(150, 40);
            this.cboSelectVoice.Name = "cboSelectVoice";
            this.cboSelectVoice.Size = new System.Drawing.Size(163, 28);
            this.cboSelectVoice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Voice:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 97);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(738, 406);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            // 
            // Resume
            // 
            this.Resume.Location = new System.Drawing.Point(544, 508);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(99, 37);
            this.Resume.TabIndex = 4;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(440, 508);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(99, 37);
            this.Pause.TabIndex = 5;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Speak
            // 
            this.Speak.Location = new System.Drawing.Point(334, 508);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(99, 37);
            this.Speak.TabIndex = 6;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = true;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 565);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSelectVoice);
            this.Controls.Add(this.Save);
            this.Name = "frmMain";
            this.Text = "Text To Speech";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox cboSelectVoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Speak;
    }
}

