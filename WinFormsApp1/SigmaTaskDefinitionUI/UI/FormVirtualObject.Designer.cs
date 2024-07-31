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
            label2 = new Label();
            richTextBoxModelName = new RichTextBox();
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
            pictureBox = new PictureBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxModelType
            // 
            comboBoxModelType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelType.FormattingEnabled = true;
            comboBoxModelType.Items.AddRange(new object[] { "Null", "Straight", "Half circle", "Full circle" });
            comboBoxModelType.Location = new Point(24, 65);
            comboBoxModelType.Name = "comboBoxModelType";
            comboBoxModelType.Size = new Size(361, 39);
            comboBoxModelType.TabIndex = 0;
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
            // buttonVirtualObjectOK
            // 
            buttonVirtualObjectOK.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonVirtualObjectOK.Location = new Point(1067, 35);
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
            buttonVirtualObjectCancel.Location = new Point(1067, 383);
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
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonVirtualObjectCancel);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(buttonVirtualObjectOK);
            panel1.Location = new Point(558, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1362, 512);
            panel1.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonKnownPose);
            groupBox3.Controls.Add(radioButtonUnknownPose);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(richTextBoxModelPoseDescription);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(632, 19);
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
            groupBox2.Controls.Add(comboBoxModelType);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(198, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 480);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "模型信息";
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
            // pictureBox
            // 
            pictureBox.Location = new Point(21, 19);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(500, 500);
            pictureBox.TabIndex = 44;
            pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 512);
            panel2.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(8, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 480);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "模型展示";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(11, 325);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(118, 35);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "坐标轴";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 120);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(142, 35);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "自动旋转";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormVirtualObject
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1932, 629);
            Controls.Add(label4);
            Controls.Add(pictureTip1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormVirtualObject";
            Text = "虚拟物体配置";
            Load += FormVirtualObject_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxModelType;
        private Label label2;
        private RichTextBox richTextBoxModelName;
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
        private PictureBox pictureBox;
        private Panel panel2;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}