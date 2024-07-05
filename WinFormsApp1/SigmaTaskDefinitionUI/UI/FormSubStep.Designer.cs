namespace SigmaTaskDefinitionUI
{
    partial class FormSubStep
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
            buttonSubStepOK = new Button();
            buttonSubStepCancel = new Button();
            label7 = new Label();
            richTextSubStepDescription = new RichTextBox();
            SuspendLayout();
            // 
            // buttonSubStepOK
            // 
            buttonSubStepOK.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSubStepOK.Location = new Point(916, 103);
            buttonSubStepOK.Name = "buttonSubStepOK";
            buttonSubStepOK.Size = new Size(271, 198);
            buttonSubStepOK.TabIndex = 8;
            buttonSubStepOK.Text = "确定";
            buttonSubStepOK.UseVisualStyleBackColor = true;
            buttonSubStepOK.Click += buttonSubStepOK_Click;
            // 
            // buttonSubStepCancel
            // 
            buttonSubStepCancel.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSubStepCancel.Location = new Point(916, 359);
            buttonSubStepCancel.Name = "buttonSubStepCancel";
            buttonSubStepCancel.Size = new Size(271, 198);
            buttonSubStepCancel.TabIndex = 9;
            buttonSubStepCancel.Text = "取消";
            buttonSubStepCancel.UseVisualStyleBackColor = true;
            buttonSubStepCancel.Click += buttonSubStepCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 58);
            label7.Name = "label7";
            label7.Size = new Size(134, 31);
            label7.TabIndex = 24;
            label7.Text = "子任务描述";
            // 
            // richTextSubStepDescription
            // 
            richTextSubStepDescription.Location = new Point(38, 103);
            richTextSubStepDescription.Name = "richTextSubStepDescription";
            richTextSubStepDescription.Size = new Size(344, 454);
            richTextSubStepDescription.TabIndex = 23;
            richTextSubStepDescription.Text = "";
            // 
            // FormSubStep
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 665);
            Controls.Add(label7);
            Controls.Add(richTextSubStepDescription);
            Controls.Add(buttonSubStepCancel);
            Controls.Add(buttonSubStepOK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSubStep";
            Text = "子任务配置";
            Load += this.FormSubStep_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubStepOK;
        private Button buttonSubStepCancel;
        private Label label7;
        private RichTextBox richTextSubStepDescription;
    }
}