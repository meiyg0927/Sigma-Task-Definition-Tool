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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubStep));
            buttonSubStepOK = new Button();
            buttonSubStepCancel = new Button();
            buttonEditVirtualObject = new Button();
            buttonRemoveVirtualObject = new Button();
            buttonAddVirtualObject = new Button();
            tabControlSubStep = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            pictureTip1 = new PictureBox();
            richTextSubStepDescription = new RichTextBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            buttonSubStepMoveDown = new Button();
            buttonSubStepMoveUp = new Button();
            listBoxVO = new ListBox();
            tabControlSubStep.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSubStepOK
            // 
            buttonSubStepOK.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSubStepOK.Location = new Point(927, 66);
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
            buttonSubStepCancel.Location = new Point(927, 383);
            buttonSubStepCancel.Name = "buttonSubStepCancel";
            buttonSubStepCancel.Size = new Size(271, 198);
            buttonSubStepCancel.TabIndex = 9;
            buttonSubStepCancel.Text = "取消";
            buttonSubStepCancel.UseVisualStyleBackColor = true;
            buttonSubStepCancel.Click += buttonSubStepCancel_Click;
            // 
            // buttonEditVirtualObject
            // 
            buttonEditVirtualObject.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonEditVirtualObject.Location = new Point(542, 364);
            buttonEditVirtualObject.Name = "buttonEditVirtualObject";
            buttonEditVirtualObject.Size = new Size(251, 107);
            buttonEditVirtualObject.TabIndex = 39;
            buttonEditVirtualObject.Text = "编辑";
            buttonEditVirtualObject.UseVisualStyleBackColor = true;
            buttonEditVirtualObject.Click += buttonEditVirtualObject_Click;
            // 
            // buttonRemoveVirtualObject
            // 
            buttonRemoveVirtualObject.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonRemoveVirtualObject.Location = new Point(542, 218);
            buttonRemoveVirtualObject.Name = "buttonRemoveVirtualObject";
            buttonRemoveVirtualObject.Size = new Size(251, 107);
            buttonRemoveVirtualObject.TabIndex = 38;
            buttonRemoveVirtualObject.Text = "删除";
            buttonRemoveVirtualObject.UseVisualStyleBackColor = true;
            buttonRemoveVirtualObject.Click += buttonRemoveVirtualObject_Click;
            // 
            // buttonAddVirtualObject
            // 
            buttonAddVirtualObject.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonAddVirtualObject.Location = new Point(542, 64);
            buttonAddVirtualObject.Name = "buttonAddVirtualObject";
            buttonAddVirtualObject.Size = new Size(251, 107);
            buttonAddVirtualObject.TabIndex = 37;
            buttonAddVirtualObject.Text = "新建";
            buttonAddVirtualObject.UseVisualStyleBackColor = true;
            buttonAddVirtualObject.Click += buttonAddVirtualObject_Click;
            // 
            // tabControlSubStep
            // 
            tabControlSubStep.Appearance = TabAppearance.FlatButtons;
            tabControlSubStep.Controls.Add(tabPage1);
            tabControlSubStep.Controls.Add(tabPage2);
            tabControlSubStep.Location = new Point(47, 21);
            tabControlSubStep.Name = "tabControlSubStep";
            tabControlSubStep.SelectedIndex = 0;
            tabControlSubStep.Size = new Size(847, 568);
            tabControlSubStep.TabIndex = 40;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pictureTip1);
            tabPage1.Controls.Add(richTextSubStepDescription);
            tabPage1.Location = new Point(4, 43);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 521);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "子任务描述";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(161, 422);
            label2.Name = "label2";
            label2.Size = new Size(230, 31);
            label2.TabIndex = 42;
            label2.Text = "上方输入子任务描述";
            // 
            // pictureTip1
            // 
            pictureTip1.Image = Properties.Resources.Tips;
            pictureTip1.Location = new Point(31, 409);
            pictureTip1.Name = "pictureTip1";
            pictureTip1.Size = new Size(93, 75);
            pictureTip1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTip1.TabIndex = 41;
            pictureTip1.TabStop = false;
            // 
            // richTextSubStepDescription
            // 
            richTextSubStepDescription.Location = new Point(31, 29);
            richTextSubStepDescription.Name = "richTextSubStepDescription";
            richTextSubStepDescription.Size = new Size(768, 318);
            richTextSubStepDescription.TabIndex = 23;
            richTextSubStepDescription.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(buttonSubStepMoveDown);
            tabPage2.Controls.Add(buttonSubStepMoveUp);
            tabPage2.Controls.Add(buttonRemoveVirtualObject);
            tabPage2.Controls.Add(listBoxVO);
            tabPage2.Controls.Add(buttonAddVirtualObject);
            tabPage2.Controls.Add(buttonEditVirtualObject);
            tabPage2.Location = new Point(4, 43);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(839, 521);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "虚拟物体设置";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 45;
            label1.Text = "虚拟物体列表";
            // 
            // buttonSubStepMoveDown
            // 
            buttonSubStepMoveDown.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSubStepMoveDown.Location = new Point(398, 299);
            buttonSubStepMoveDown.Name = "buttonSubStepMoveDown";
            buttonSubStepMoveDown.Size = new Size(68, 63);
            buttonSubStepMoveDown.TabIndex = 44;
            buttonSubStepMoveDown.Text = "▼";
            buttonSubStepMoveDown.UseVisualStyleBackColor = true;
            buttonSubStepMoveDown.Click += buttonSubStepMoveDown_Click;
            // 
            // buttonSubStepMoveUp
            // 
            buttonSubStepMoveUp.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonSubStepMoveUp.Location = new Point(398, 169);
            buttonSubStepMoveUp.Name = "buttonSubStepMoveUp";
            buttonSubStepMoveUp.Size = new Size(68, 68);
            buttonSubStepMoveUp.TabIndex = 43;
            buttonSubStepMoveUp.Text = "▲";
            buttonSubStepMoveUp.UseVisualStyleBackColor = true;
            buttonSubStepMoveUp.Click += buttonSubStepMoveUp_Click;
            // 
            // listBoxVO
            // 
            listBoxVO.FormattingEnabled = true;
            listBoxVO.Location = new Point(29, 64);
            listBoxVO.Name = "listBoxVO";
            listBoxVO.Size = new Size(363, 407);
            listBoxVO.TabIndex = 42;
            // 
            // FormSubStep
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 626);
            Controls.Add(tabControlSubStep);
            Controls.Add(buttonSubStepCancel);
            Controls.Add(buttonSubStepOK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormSubStep";
            Text = "子任务配置";
            Load += FormSubStep_Load;
            tabControlSubStep.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTip1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSubStepOK;
        private Button buttonSubStepCancel;
        private Button buttonRemoveVirtualObject;
        private Button buttonEditVirtualObject;
        private Button buttonAddVirtualObject;
        private TabControl tabControlSubStep;
        private TabPage tabPage1;
        private RichTextBox richTextSubStepDescription;
        private TabPage tabPage2;
        private Button buttonSubStepMoveDown;
        private Button buttonSubStepMoveUp;
        private ListBox listBoxVO;
        private Label label1;
        private PictureBox pictureTip1;
        private Label label2;
    }
}