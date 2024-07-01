namespace SigmaTaskDefinitionUI
{
    partial class FormOutput
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
            richTextBox = new RichTextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Font = new Font("Arial", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox.Location = new Point(39, 41);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(1246, 1002);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "Hello";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSave.Location = new Point(1312, 221);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(271, 198);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "保存";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonCancel.Location = new Point(1312, 651);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(271, 198);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "取消";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormOutput
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 1080);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(richTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormOutput";
            Text = "预览 & 输出";
            Load += FormOutput_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
        private Button buttonSave;
        private Button buttonCancel;
    }
}