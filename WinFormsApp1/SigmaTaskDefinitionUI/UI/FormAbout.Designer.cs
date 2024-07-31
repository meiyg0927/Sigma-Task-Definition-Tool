namespace SigmaTaskDefinitionUI
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(240, 168);
            label1.Name = "label1";
            label1.Size = new Size(318, 42);
            label1.TabIndex = 1;
            label1.Text = "Sigma 任务定义工具";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑 Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(312, 228);
            label2.Name = "label2";
            label2.Size = new Size(169, 31);
            label2.TabIndex = 2;
            label2.Text = "Version 1.2.0.0";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            linkLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            linkLabel.Location = new Point(118, 401);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(580, 27);
            linkLabel.TabIndex = 3;
            linkLabel.TabStop = true;
            linkLabel.Text = "https://github.com/meiyg0927/Sigma-Task-Definition-Tool";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAbout";
            Text = "关于";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel;
    }
}