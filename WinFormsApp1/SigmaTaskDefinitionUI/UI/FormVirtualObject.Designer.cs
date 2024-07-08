namespace SigmaTaskDefinitionUI.UI
{
    partial class FormVirtualObject
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
            comboBoxModelType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            richTextBoxModelName = new RichTextBox();
            pictureBox1 = new PictureBox();
            buttonVirtualObjectOK = new Button();
            buttonVirtualObjectCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxModelType
            // 
            comboBoxModelType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelType.FormattingEnabled = true;
            comboBoxModelType.Items.AddRange(new object[] { "Null", "Straight", "Half circle", "Full circle" });
            comboBoxModelType.Location = new Point(30, 120);
            comboBoxModelType.Name = "comboBoxModelType";
            comboBoxModelType.Size = new Size(294, 39);
            comboBoxModelType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 67);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 3;
            label1.Text = "模型类型";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 212);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 4;
            label2.Text = "模型描述";
            // 
            // richTextBoxModelName
            // 
            richTextBoxModelName.Location = new Point(30, 263);
            richTextBoxModelName.Name = "richTextBoxModelName";
            richTextBoxModelName.Size = new Size(302, 192);
            richTextBoxModelName.TabIndex = 5;
            richTextBoxModelName.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(410, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 335);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonVirtualObjectOK
            // 
            buttonVirtualObjectOK.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonVirtualObjectOK.Location = new Point(30, 494);
            buttonVirtualObjectOK.Name = "buttonVirtualObjectOK";
            buttonVirtualObjectOK.Size = new Size(302, 70);
            buttonVirtualObjectOK.TabIndex = 9;
            buttonVirtualObjectOK.Text = "确定";
            buttonVirtualObjectOK.UseVisualStyleBackColor = true;
            buttonVirtualObjectOK.Click += buttonVirtualObjectOK_Click;
            // 
            // buttonVirtualObjectCancel
            // 
            buttonVirtualObjectCancel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonVirtualObjectCancel.Location = new Point(410, 494);
            buttonVirtualObjectCancel.Name = "buttonVirtualObjectCancel";
            buttonVirtualObjectCancel.Size = new Size(302, 70);
            buttonVirtualObjectCancel.TabIndex = 10;
            buttonVirtualObjectCancel.Text = "取消";
            buttonVirtualObjectCancel.UseVisualStyleBackColor = true;
            buttonVirtualObjectCancel.Click += buttonVirtualObjectCancel_Click;
            // 
            // FormVirtualObject
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 597);
            Controls.Add(buttonVirtualObjectCancel);
            Controls.Add(buttonVirtualObjectOK);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBoxModelName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxModelType);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormVirtualObject";
            Text = "FormVirtualObject";
            Load += FormVirtualObject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxModelType;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxModelName;
        private PictureBox pictureBox1;
        private Button buttonVirtualObjectOK;
        private Button buttonVirtualObjectCancel;
    }
}