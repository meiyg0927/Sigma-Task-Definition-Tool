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
            groupBox1 = new GroupBox();
            checkBoxAuxCubeVisibled = new CheckBox();
            checkBoxModelInfoVisibled = new CheckBox();
            checkBoxAxisVisibled = new CheckBox();
            checkBoxModelAutoRotate = new CheckBox();
            pictureTip1 = new PictureBox();
            label4 = new Label();
            pictureBox = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxModelType
            // 
            comboBoxModelType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelType.FormattingEnabled = true;
            comboBoxModelType.Items.AddRange(new object[] { "Null", "Straight", "Half circle", "Full circle" });
            comboBoxModelType.Location = new Point(21, 65);
            comboBoxModelType.Name = "comboBoxModelType";
            comboBoxModelType.Size = new Size(485, 39);
            comboBoxModelType.TabIndex = 0;
            comboBoxModelType.SelectedIndexChanged += comboBoxModelType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 117);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 4;
            label2.Text = "模型描述";
            // 
            // richTextBoxModelName
            // 
            richTextBoxModelName.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxModelName.Location = new Point(21, 160);
            richTextBoxModelName.Name = "richTextBoxModelName";
            richTextBoxModelName.Size = new Size(485, 275);
            richTextBoxModelName.TabIndex = 5;
            richTextBoxModelName.Text = "";
            // 
            // buttonVirtualObjectOK
            // 
            buttonVirtualObjectOK.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonVirtualObjectOK.Location = new Point(1225, 998);
            buttonVirtualObjectOK.Name = "buttonVirtualObjectOK";
            buttonVirtualObjectOK.Size = new Size(340, 123);
            buttonVirtualObjectOK.TabIndex = 9;
            buttonVirtualObjectOK.Text = "确定";
            buttonVirtualObjectOK.UseVisualStyleBackColor = true;
            buttonVirtualObjectOK.Click += buttonVirtualObjectOK_Click;
            // 
            // buttonVirtualObjectCancel
            // 
            buttonVirtualObjectCancel.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonVirtualObjectCancel.Location = new Point(1011, 998);
            buttonVirtualObjectCancel.Name = "buttonVirtualObjectCancel";
            buttonVirtualObjectCancel.Size = new Size(205, 123);
            buttonVirtualObjectCancel.TabIndex = 10;
            buttonVirtualObjectCancel.Text = "取消";
            buttonVirtualObjectCancel.UseVisualStyleBackColor = true;
            buttonVirtualObjectCancel.Click += buttonVirtualObjectCancel_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(1011, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 972);
            panel1.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonKnownPose);
            groupBox3.Controls.Add(radioButtonUnknownPose);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(richTextBoxModelPoseDescription);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(12, 492);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(527, 464);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "空间位置";
            // 
            // radioButtonKnownPose
            // 
            radioButtonKnownPose.AutoSize = true;
            radioButtonKnownPose.Checked = true;
            radioButtonKnownPose.Location = new Point(26, 66);
            radioButtonKnownPose.Name = "radioButtonKnownPose";
            radioButtonKnownPose.Size = new Size(189, 35);
            radioButtonKnownPose.TabIndex = 13;
            radioButtonKnownPose.TabStop = true;
            radioButtonKnownPose.Text = "空间位置已知";
            radioButtonKnownPose.UseVisualStyleBackColor = true;
            radioButtonKnownPose.CheckedChanged += radioButtonKnownPose_CheckedChanged;
            // 
            // radioButtonUnknownPose
            // 
            radioButtonUnknownPose.AutoSize = true;
            radioButtonUnknownPose.Location = new Point(311, 66);
            radioButtonUnknownPose.Name = "radioButtonUnknownPose";
            radioButtonUnknownPose.Size = new Size(189, 35);
            radioButtonUnknownPose.TabIndex = 13;
            radioButtonUnknownPose.Text = "空间位置未知";
            radioButtonUnknownPose.UseVisualStyleBackColor = true;
            radioButtonUnknownPose.CheckedChanged += radioButtonUnknownPose_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 126);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 15;
            label3.Text = "位置描述";
            // 
            // richTextBoxModelPoseDescription
            // 
            richTextBoxModelPoseDescription.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxModelPoseDescription.Location = new Point(21, 169);
            richTextBoxModelPoseDescription.Name = "richTextBoxModelPoseDescription";
            richTextBoxModelPoseDescription.Size = new Size(483, 275);
            richTextBoxModelPoseDescription.TabIndex = 15;
            richTextBoxModelPoseDescription.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxModelName);
            groupBox2.Controls.Add(comboBoxModelType);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(12, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(527, 453);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "基本信息";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxAuxCubeVisibled);
            groupBox1.Controls.Add(checkBoxModelInfoVisibled);
            groupBox1.Controls.Add(checkBoxAxisVisibled);
            groupBox1.Controls.Add(checkBoxModelAutoRotate);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(964, 98);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "模型展示";
            // 
            // checkBoxAuxCubeVisibled
            // 
            checkBoxAuxCubeVisibled.AutoSize = true;
            checkBoxAuxCubeVisibled.Checked = true;
            checkBoxAuxCubeVisibled.CheckState = CheckState.Checked;
            checkBoxAuxCubeVisibled.Location = new Point(520, 47);
            checkBoxAuxCubeVisibled.Name = "checkBoxAuxCubeVisibled";
            checkBoxAuxCubeVisibled.Size = new Size(142, 35);
            checkBoxAuxCubeVisibled.TabIndex = 21;
            checkBoxAuxCubeVisibled.Text = "辅助方块";
            checkBoxAuxCubeVisibled.UseVisualStyleBackColor = true;
            checkBoxAuxCubeVisibled.CheckedChanged += checkBoxAuxCubeVisibled_CheckedChanged;
            // 
            // checkBoxModelInfoVisibled
            // 
            checkBoxModelInfoVisibled.AutoSize = true;
            checkBoxModelInfoVisibled.Location = new Point(790, 47);
            checkBoxModelInfoVisibled.Name = "checkBoxModelInfoVisibled";
            checkBoxModelInfoVisibled.Size = new Size(142, 35);
            checkBoxModelInfoVisibled.TabIndex = 22;
            checkBoxModelInfoVisibled.Text = "性能参数";
            checkBoxModelInfoVisibled.UseVisualStyleBackColor = true;
            checkBoxModelInfoVisibled.CheckedChanged += checkBoxModelInfoVisibled_CheckedChanged;
            // 
            // checkBoxAxisVisibled
            // 
            checkBoxAxisVisibled.AutoSize = true;
            checkBoxAxisVisibled.Location = new Point(256, 47);
            checkBoxAxisVisibled.Name = "checkBoxAxisVisibled";
            checkBoxAxisVisibled.Size = new Size(118, 35);
            checkBoxAxisVisibled.TabIndex = 20;
            checkBoxAxisVisibled.Text = "坐标轴";
            checkBoxAxisVisibled.UseVisualStyleBackColor = true;
            checkBoxAxisVisibled.CheckedChanged += checkBoxAxisVisibled_CheckedChanged;
            // 
            // checkBoxModelAutoRotate
            // 
            checkBoxModelAutoRotate.AutoSize = true;
            checkBoxModelAutoRotate.Location = new Point(6, 47);
            checkBoxModelAutoRotate.Name = "checkBoxModelAutoRotate";
            checkBoxModelAutoRotate.Size = new Size(142, 35);
            checkBoxModelAutoRotate.TabIndex = 19;
            checkBoxModelAutoRotate.Text = "自动旋转";
            checkBoxModelAutoRotate.UseVisualStyleBackColor = true;
            checkBoxModelAutoRotate.CheckedChanged += checkBoxModelAutoRotate_CheckedChanged;
            // 
            // pictureTip1
            // 
            pictureTip1.Image = Properties.Resources.Tips;
            pictureTip1.Location = new Point(12, 1140);
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
            label4.Location = new Point(140, 1140);
            label4.Name = "label4";
            label4.Size = new Size(590, 31);
            label4.TabIndex = 43;
            label4.Text = "基本信息处，在下拉列表框里选择一个模型，即可预览";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(21, 19);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(960, 960);
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
            panel2.Size = new Size(983, 972);
            panel2.TabIndex = 45;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(12, 998);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 123);
            panel3.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(140, 1184);
            label1.Name = "label1";
            label1.Size = new Size(1083, 31);
            label1.TabIndex = 47;
            label1.Text = "模型预览的操作方法：SHIFT+方向键可以移动模型；鼠标滚轮可以缩放模型；鼠标右键可以旋转模型";
            // 
            // FormVirtualObject
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 1236);
            Controls.Add(label1);
            Controls.Add(buttonVirtualObjectCancel);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(pictureTip1);
            Controls.Add(buttonVirtualObjectOK);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormVirtualObject";
            Text = "虚拟物体配置";
            FormClosing += FormVirtualObject_FormClosing;
            Load += FormVirtualObject_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private CheckBox checkBoxAxisVisibled;
        private CheckBox checkBoxModelAutoRotate;
        private CheckBox checkBoxAuxCubeVisibled;
        private CheckBox checkBoxModelInfoVisibled;
        private Panel panel3;
        private Label label1;
    }
}