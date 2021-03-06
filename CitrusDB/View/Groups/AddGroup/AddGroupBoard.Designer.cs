﻿namespace CitrusDB.View.Groups.AddGroup
{
    partial class AddGroupBoard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAddGroupSpace = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.photoLabel = new System.Windows.Forms.Label();
            this.countOfStudentsLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addedStudentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nameGroupTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.optionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchingPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.orderByButton = new System.Windows.Forms.Button();
            this.flowPanelSearchSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.searchSettingsButton = new System.Windows.Forms.Button();
            this.panelWhere = new System.Windows.Forms.Panel();
            this.comboBoxWhere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWhere = new System.Windows.Forms.Button();
            this.panelOrderBy = new System.Windows.Forms.Panel();
            this.bunifuSeparatorOrderBy = new Bunifu.Framework.UI.BunifuSeparator();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonDescen = new System.Windows.Forms.RadioButton();
            this.radioButtonAscend = new System.Windows.Forms.RadioButton();
            this.buttonOrderBy = new System.Windows.Forms.Button();
            this.currentStudentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelAddGroupSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.photoPictureBox)).BeginInit();
            this.optionFlowPanel.SuspendLayout();
            this.searchingPanel.SuspendLayout();
            this.flowPanelSearchSettings.SuspendLayout();
            this.panelWhere.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddGroupSpace
            // 
            this.panelAddGroupSpace.BackColor = System.Drawing.SystemColors.Control;
            this.panelAddGroupSpace.Controls.Add(this.clearButton);
            this.panelAddGroupSpace.Controls.Add(this.saveButton);
            this.panelAddGroupSpace.Controls.Add(this.photoLabel);
            this.panelAddGroupSpace.Controls.Add(this.countOfStudentsLabel);
            this.panelAddGroupSpace.Controls.Add(this.photoPictureBox);
            this.panelAddGroupSpace.Controls.Add(this.label4);
            this.panelAddGroupSpace.Controls.Add(this.addedStudentFlowPanel);
            this.panelAddGroupSpace.Controls.Add(this.label3);
            this.panelAddGroupSpace.Controls.Add(this.nameGroupTextBox);
            this.panelAddGroupSpace.Controls.Add(this.label2);
            this.panelAddGroupSpace.Location = new System.Drawing.Point(0, 0);
            this.panelAddGroupSpace.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddGroupSpace.Name = "panelAddGroupSpace";
            this.panelAddGroupSpace.Size = new System.Drawing.Size(273, 603);
            this.panelAddGroupSpace.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Teal;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(143, 542);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 40);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(36, 542);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 40);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Enabled = false;
            this.photoLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.photoLabel.Location = new System.Drawing.Point(51, 69);
            this.photoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(41, 16);
            this.photoLabel.TabIndex = 1;
            this.photoLabel.Text = "photo";
            // 
            // countOfStudentsLabel
            // 
            this.countOfStudentsLabel.AutoSize = true;
            this.countOfStudentsLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.countOfStudentsLabel.Location = new System.Drawing.Point(197, 77);
            this.countOfStudentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countOfStudentsLabel.Name = "countOfStudentsLabel";
            this.countOfStudentsLabel.Size = new System.Drawing.Size(0, 19);
            this.countOfStudentsLabel.TabIndex = 6;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.Location = new System.Drawing.Point(12, 14);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(123, 135);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.MouseClick +=
                new System.Windows.Forms.MouseEventHandler(this.photoPictureBox_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(141, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Count:";
            // 
            // addedStudentFlowPanel
            // 
            this.addedStudentFlowPanel.AutoScroll = true;
            this.addedStudentFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.addedStudentFlowPanel.Location = new System.Drawing.Point(2, 193);
            this.addedStudentFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addedStudentFlowPanel.Name = "addedStudentFlowPanel";
            this.addedStudentFlowPanel.Size = new System.Drawing.Size(271, 325);
            this.addedStudentFlowPanel.TabIndex = 4;
            this.addedStudentFlowPanel.ControlAdded +=
                new System.Windows.Forms.ControlEventHandler(this.addedStudentFlowPanel_ControlAdded);
            this.addedStudentFlowPanel.ControlRemoved +=
                new System.Windows.Forms.ControlEventHandler(this.addedStudentFlowPanel_ControlRemoved);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(7, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Students:";
            // 
            // nameGroupTextBox
            // 
            this.nameGroupTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.nameGroupTextBox.Location = new System.Drawing.Point(145, 42);
            this.nameGroupTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameGroupTextBox.Multiline = true;
            this.nameGroupTextBox.Name = "nameGroupTextBox";
            this.nameGroupTextBox.Size = new System.Drawing.Size(121, 21);
            this.nameGroupTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(141, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of group:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.searchTextBox.Location = new System.Drawing.Point(20, 40);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(188, 27);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Tag = "";
            this.searchTextBox.Text = "Search..";
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // optionFlowPanel
            // 
            this.optionFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.optionFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionFlowPanel.Controls.Add(this.searchingPanel);
            this.optionFlowPanel.Controls.Add(this.flowPanelSearchSettings);
            this.optionFlowPanel.Location = new System.Drawing.Point(677, 0);
            this.optionFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.optionFlowPanel.Name = "optionFlowPanel";
            this.optionFlowPanel.Size = new System.Drawing.Size(242, 604);
            this.optionFlowPanel.TabIndex = 4;
            // 
            // searchingPanel
            // 
            this.searchingPanel.Controls.Add(this.label6);
            this.searchingPanel.Controls.Add(this.orderByButton);
            this.searchingPanel.Controls.Add(this.searchTextBox);
            this.searchingPanel.Location = new System.Drawing.Point(3, 3);
            this.searchingPanel.Name = "searchingPanel";
            this.searchingPanel.Size = new System.Drawing.Size(233, 126);
            this.searchingPanel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Search";
            // 
            // orderByButton
            // 
            this.orderByButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.orderByButton.FlatAppearance.BorderSize = 0;
            this.orderByButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderByButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.orderByButton.ForeColor = System.Drawing.Color.White;
            this.orderByButton.Location = new System.Drawing.Point(20, 88);
            this.orderByButton.Margin = new System.Windows.Forms.Padding(2);
            this.orderByButton.Name = "orderByButton";
            this.orderByButton.Size = new System.Drawing.Size(189, 28);
            this.orderByButton.TabIndex = 24;
            this.orderByButton.Text = "OrderBy";
            this.orderByButton.UseVisualStyleBackColor = false;
            this.orderByButton.Click += new System.EventHandler(this.orderByButton_Click);
            // 
            // flowPanelSearchSettings
            // 
            this.flowPanelSearchSettings.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.flowPanelSearchSettings.Controls.Add(this.searchSettingsButton);
            this.flowPanelSearchSettings.Controls.Add(this.panelWhere);
            this.flowPanelSearchSettings.Controls.Add(this.panelOrderBy);
            this.flowPanelSearchSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanelSearchSettings.Location = new System.Drawing.Point(3, 135);
            this.flowPanelSearchSettings.MaximumSize = new System.Drawing.Size(234, 406);
            this.flowPanelSearchSettings.MinimumSize = new System.Drawing.Size(234, 55);
            this.flowPanelSearchSettings.Name = "flowPanelSearchSettings";
            this.flowPanelSearchSettings.Size = new System.Drawing.Size(234, 55);
            this.flowPanelSearchSettings.TabIndex = 8;
            this.flowPanelSearchSettings.Tag = false;
            // 
            // searchSettingsButton
            // 
            this.searchSettingsButton.AutoSize = true;
            this.searchSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))),
                ((int) (((byte) (44)))), ((int) (((byte) (44)))));
            this.searchSettingsButton.FlatAppearance.BorderSize = 0;
            this.searchSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchSettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.searchSettingsButton.ForeColor = System.Drawing.Color.White;
            this.searchSettingsButton.Location = new System.Drawing.Point(3, 3);
            this.searchSettingsButton.Name = "searchSettingsButton";
            this.searchSettingsButton.Size = new System.Drawing.Size(234, 55);
            this.searchSettingsButton.TabIndex = 1;
            this.searchSettingsButton.Text = "Search settings :";
            this.searchSettingsButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchSettingsButton.UseVisualStyleBackColor = false;
            this.searchSettingsButton.Click += new System.EventHandler(this.searchSettingsButton_Click);
            // 
            // panelWhere
            // 
            this.panelWhere.BackColor = System.Drawing.Color.DimGray;
            this.panelWhere.Controls.Add(this.comboBoxWhere);
            this.panelWhere.Controls.Add(this.label1);
            this.panelWhere.Controls.Add(this.buttonWhere);
            this.panelWhere.Location = new System.Drawing.Point(3, 64);
            this.panelWhere.MaximumSize = new System.Drawing.Size(266, 120);
            this.panelWhere.MinimumSize = new System.Drawing.Size(266, 55);
            this.panelWhere.Name = "panelWhere";
            this.panelWhere.Size = new System.Drawing.Size(266, 55);
            this.panelWhere.TabIndex = 2;
            this.panelWhere.Tag = false;
            // 
            // comboBoxWhere
            // 
            this.comboBoxWhere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.comboBoxWhere.FormattingEnabled = true;
            this.comboBoxWhere.Location = new System.Drawing.Point(66, 76);
            this.comboBoxWhere.Name = "comboBoxWhere";
            this.comboBoxWhere.Size = new System.Drawing.Size(153, 24);
            this.comboBoxWhere.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter :";
            // 
            // buttonWhere
            // 
            this.buttonWhere.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.buttonWhere.FlatAppearance.BorderSize = 0;
            this.buttonWhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonWhere.ForeColor = System.Drawing.Color.White;
            this.buttonWhere.Location = new System.Drawing.Point(0, 0);
            this.buttonWhere.Name = "buttonWhere";
            this.buttonWhere.Size = new System.Drawing.Size(266, 55);
            this.buttonWhere.TabIndex = 2;
            this.buttonWhere.Text = "                     Where";
            this.buttonWhere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWhere.UseVisualStyleBackColor = false;
            this.buttonWhere.Click += new System.EventHandler(this.buttonWhere_Click);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.BackColor = System.Drawing.Color.DimGray;
            this.panelOrderBy.Controls.Add(this.bunifuSeparatorOrderBy);
            this.panelOrderBy.Controls.Add(this.comboBoxOrderBy);
            this.panelOrderBy.Controls.Add(this.label5);
            this.panelOrderBy.Controls.Add(this.radioButtonDescen);
            this.panelOrderBy.Controls.Add(this.radioButtonAscend);
            this.panelOrderBy.Controls.Add(this.buttonOrderBy);
            this.panelOrderBy.Location = new System.Drawing.Point(3, 125);
            this.panelOrderBy.MaximumSize = new System.Drawing.Size(266, 198);
            this.panelOrderBy.MinimumSize = new System.Drawing.Size(266, 55);
            this.panelOrderBy.Name = "panelOrderBy";
            this.panelOrderBy.Size = new System.Drawing.Size(266, 55);
            this.panelOrderBy.TabIndex = 3;
            this.panelOrderBy.Tag = false;
            // 
            // bunifuSeparatorOrderBy
            // 
            this.bunifuSeparatorOrderBy.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparatorOrderBy.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.bunifuSeparatorOrderBy.LineThickness = 1;
            this.bunifuSeparatorOrderBy.Location = new System.Drawing.Point(0, 122);
            this.bunifuSeparatorOrderBy.Name = "bunifuSeparatorOrderBy";
            this.bunifuSeparatorOrderBy.Size = new System.Drawing.Size(266, 1);
            this.bunifuSeparatorOrderBy.TabIndex = 7;
            this.bunifuSeparatorOrderBy.Transparency = 255;
            this.bunifuSeparatorOrderBy.Vertical = false;
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Location = new System.Drawing.Point(66, 76);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(153, 24);
            this.comboBoxOrderBy.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filter :";
            // 
            // radioButtonDescen
            // 
            this.radioButtonDescen.AutoSize = true;
            this.radioButtonDescen.Font = new System.Drawing.Font("Century Gothic", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.radioButtonDescen.ForeColor = System.Drawing.Color.White;
            this.radioButtonDescen.Location = new System.Drawing.Point(33, 166);
            this.radioButtonDescen.Name = "radioButtonDescen";
            this.radioButtonDescen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonDescen.Size = new System.Drawing.Size(101, 21);
            this.radioButtonDescen.TabIndex = 4;
            this.radioButtonDescen.TabStop = true;
            this.radioButtonDescen.Text = "descending";
            this.radioButtonDescen.UseVisualStyleBackColor = true;
            // 
            // radioButtonAscend
            // 
            this.radioButtonAscend.AutoSize = true;
            this.radioButtonAscend.Font = new System.Drawing.Font("Century Gothic", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.radioButtonAscend.ForeColor = System.Drawing.Color.White;
            this.radioButtonAscend.Location = new System.Drawing.Point(42, 135);
            this.radioButtonAscend.Name = "radioButtonAscend";
            this.radioButtonAscend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonAscend.Size = new System.Drawing.Size(93, 21);
            this.radioButtonAscend.TabIndex = 3;
            this.radioButtonAscend.TabStop = true;
            this.radioButtonAscend.Text = "ascending";
            this.radioButtonAscend.UseVisualStyleBackColor = true;
            // 
            // buttonOrderBy
            // 
            this.buttonOrderBy.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.buttonOrderBy.FlatAppearance.BorderSize = 0;
            this.buttonOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderBy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonOrderBy.ForeColor = System.Drawing.Color.White;
            this.buttonOrderBy.Location = new System.Drawing.Point(0, 0);
            this.buttonOrderBy.Name = "buttonOrderBy";
            this.buttonOrderBy.Size = new System.Drawing.Size(266, 55);
            this.buttonOrderBy.TabIndex = 2;
            this.buttonOrderBy.Text = "                     OrderBy";
            this.buttonOrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderBy.UseVisualStyleBackColor = false;
            this.buttonOrderBy.Click += new System.EventHandler(this.buttonOrderBy_Click);
            // 
            // currentStudentFlowPanel
            // 
            this.currentStudentFlowPanel.AutoScroll = true;
            this.currentStudentFlowPanel.Location = new System.Drawing.Point(287, 2);
            this.currentStudentFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.currentStudentFlowPanel.Name = "currentStudentFlowPanel";
            this.currentStudentFlowPanel.Size = new System.Drawing.Size(385, 602);
            this.currentStudentFlowPanel.TabIndex = 6;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (45)))),
                ((int) (((byte) (45)))), ((int) (((byte) (45)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(274, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(9, 603);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // AddGroupBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.currentStudentFlowPanel);
            this.Controls.Add(this.optionFlowPanel);
            this.Controls.Add(this.panelAddGroupSpace);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddGroupBoard";
            this.Size = new System.Drawing.Size(919, 603);
            this.Load += new System.EventHandler(this.AddGroupBoard_Load);
            this.panelAddGroupSpace.ResumeLayout(false);
            this.panelAddGroupSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.photoPictureBox)).EndInit();
            this.optionFlowPanel.ResumeLayout(false);
            this.searchingPanel.ResumeLayout(false);
            this.searchingPanel.PerformLayout();
            this.flowPanelSearchSettings.ResumeLayout(false);
            this.flowPanelSearchSettings.PerformLayout();
            this.panelWhere.ResumeLayout(false);
            this.panelWhere.PerformLayout();
            this.panelOrderBy.ResumeLayout(false);
            this.panelOrderBy.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelAddGroupSpace;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameGroupTextBox;
        private System.Windows.Forms.FlowLayoutPanel addedStudentFlowPanel;
        private System.Windows.Forms.Label countOfStudentsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel optionFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel currentStudentFlowPanel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelSearchSettings;
        private System.Windows.Forms.Button searchSettingsButton;
        private System.Windows.Forms.Panel panelWhere;
        private System.Windows.Forms.ComboBox comboBoxWhere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWhere;
        private System.Windows.Forms.Panel panelOrderBy;
        private System.Windows.Forms.RadioButton radioButtonDescen;
        private System.Windows.Forms.RadioButton radioButtonAscend;
        private System.Windows.Forms.Button buttonOrderBy;
        private System.Windows.Forms.Button orderByButton;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparatorOrderBy;
        private System.Windows.Forms.Panel searchingPanel;
        private System.Windows.Forms.Label label6;
    }
}
