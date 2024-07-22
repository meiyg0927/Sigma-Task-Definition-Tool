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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVirtualObject));
            comboBoxModelType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            richTextBoxModelName = new RichTextBox();
            pictureBox1 = new PictureBox();
            buttonVirtualObjectOK = new Button();
            buttonVirtualObjectCancel = new Button();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            radioButtonKnownPose = new RadioButton();
            radioButtonUnknownPose = new RadioButton();
            label3 = new Label();
            richTextBoxModelPoseDescription = new RichTextBox();
            groupBox2 = new GroupBox();
            pictureTip1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxModelType
            // 
            comboBoxModelType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelType.FormattingEnabled = true;
            comboBoxModelType.Items.AddRange(new object[] { "Null", "Straight", "Half circle", "Full circle" });
            comboBoxModelType.Location = new Point(161, 65);
            comboBoxModelType.Name = "comboBoxModelType";
            comboBoxModelType.Size = new Size(224, 39);
            comboBoxModelType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 73);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 3;
            label1.Text = "模型类型";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 147);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 4;
            label2.Text = "模型描述";
            // 
            // richTextBoxModelName
            // 
            richTextBoxModelName.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxModelName.Location = new Point(24, 190);
            richTextBoxModelName.Name = "richTextBoxModelName";
            richTextBoxModelName.Size = new Size(361, 275);
            richTextBoxModelName.TabIndex = 5;
            richTextBoxModelName.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(19, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 480);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonVirtualObjectOK
            // 
            buttonVirtualObjectOK.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonVirtualObjectOK.Location = new Point(1399, 26);
            buttonVirtualObjectOK.Name = "buttonVirtualObjectOK";
            buttonVirtualObjectOK.Size = new Size(269, 171);
            buttonVirtualObjectOK.TabIndex = 9;
            buttonVirtualObjectOK.Text = "确定";
            buttonVirtualObjectOK.UseVisualStyleBackColor = true;
            buttonVirtualObjectOK.Click += buttonVirtualObjectOK_Click;
            // 
            // buttonVirtualObjectCancel
            // 
            buttonVirtualObjectCancel.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonVirtualObjectCancel.Location = new Point(1399, 398);
            buttonVirtualObjectCancel.Name = "buttonVirtualObjectCancel";
            buttonVirtualObjectCancel.Size = new Size(269, 101);
            buttonVirtualObjectCancel.TabIndex = 10;
            buttonVirtualObjectCancel.Text = "取消";
            buttonVirtualObjectCancel.UseVisualStyleBackColor = true;
            buttonVirtualObjectCancel.Click += buttonVirtualObjectCancel_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonVirtualObjectCancel);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(buttonVirtualObjectOK);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1689, 521);
            panel1.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonKnownPose);
            groupBox3.Controls.Add(radioButtonUnknownPose);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(richTextBoxModelPoseDescription);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(961, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(410, 480);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "空间位置";
            // 
            // radioButtonKnownPose
            // 
            radioButtonKnownPose.AutoSize = true;
            radioButtonKnownPose.Checked = true;
            radioButtonKnownPose.Location = new Point(38, 65);
            radioButtonKnownPose.Name = "radioButtonKnownPose";
            radioButtonKnownPose.Size = new Size(141, 35);
            radioButtonKnownPose.TabIndex = 13;
            radioButtonKnownPose.TabStop = true;
            radioButtonKnownPose.Text = "已知位置";
            radioButtonKnownPose.UseVisualStyleBackColor = true;
            radioButtonKnownPose.CheckedChanged += radioButtonKnownPose_CheckedChanged;
            // 
            // radioButtonUnknownPose
            // 
            radioButtonUnknownPose.AutoSize = true;
            radioButtonUnknownPose.Location = new Point(237, 66);
            radioButtonUnknownPose.Name = "radioButtonUnknownPose";
            radioButtonUnknownPose.Size = new Size(141, 35);
            radioButtonUnknownPose.TabIndex = 13;
            radioButtonUnknownPose.Text = "未知位置";
            radioButtonUnknownPose.UseVisualStyleBackColor = true;
            radioButtonUnknownPose.CheckedChanged += radioButtonUnknownPose_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 147);
            label3.Name = "label3";
            label3.Size = new Size(158, 31);
            label3.TabIndex = 15;
            label3.Text = "模型位置描述";
            // 
            // richTextBoxModelPoseDescription
            // 
            richTextBoxModelPoseDescription.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxModelPoseDescription.Location = new Point(26, 190);
            richTextBoxModelPoseDescription.Name = "richTextBoxModelPoseDescription";
            richTextBoxModelPoseDescription.Size = new Size(361, 275);
            richTextBoxModelPoseDescription.TabIndex = 15;
            richTextBoxModelPoseDescription.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxModelName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxModelType);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(523, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 480);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "基本信息";
            // 
            // pictureTip1
            // 
            pictureTip1.Image = Properties.Resources.Tips;
            pictureTip1.Location = new Point(12, 542);
            pictureTip1.Name = "pictureTip1";
            pictureTip1.Size = new Size(93, 75);
            pictureTip1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTip1.TabIndex = 42;
            pictureTip1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(159, 562);
            label4.Name = "label4";
            label4.Size = new Size(590, 31);
            label4.TabIndex = 43;
            label4.Text = "上方输入模型（虚拟物体）的相关信息，并可预览模型";
            // 
            // FormVirtualObject
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 629);
            Controls.Add(label4);
            Controls.Add(pictureTip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormVirtualObject";
            Text = "虚拟物体配置";
            Load += FormVirtualObject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).EndInit();
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
        private Panel panel1;
        private RadioButton radioButtonUnknownPose;
        private RadioButton radioButtonKnownPose;
        private RichTextBox richTextBoxModelPoseDescription;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureTip1;
        private Label label4;
    }
}