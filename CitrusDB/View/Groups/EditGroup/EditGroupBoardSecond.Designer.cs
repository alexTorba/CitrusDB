﻿namespace CitrusDB.View.Groups.EditGroup
{
    partial class EditGroupBoardSecond
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
            this.optionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchingPanel = new System.Windows.Forms.Panel();
            this.orderByButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.flowPanelSearchSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.searchSettingsButton = new System.Windows.Forms.Button();
            this.panelWhere = new System.Windows.Forms.Panel();
            this.comboBoxWhere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonWhere = new System.Windows.Forms.Button();
            this.panelOrderBy = new System.Windows.Forms.Panel();
            this.bunifuSeparatorOrderBy = new Bunifu.Framework.UI.BunifuSeparator();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonDescen = new System.Windows.Forms.RadioButton();
            this.radioButtonAscend = new System.Windows.Forms.RadioButton();
            this.buttonOrderBy = new System.Windows.Forms.Button();
            this.panelAddGroupSpace = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.photoLabel = new System.Windows.Forms.Label();
            this.countOfStudentsLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addedStudentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nameGroupTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentStudentsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.optionFlowPanel.SuspendLayout();
            this.searchingPanel.SuspendLayout();
            this.flowPanelSearchSettings.SuspendLayout();
            this.panelWhere.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.panelAddGroupSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // optionFlowPanel
            // 
            this.optionFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.optionFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionFlowPanel.Controls.Add(this.searchingPanel);
            this.optionFlowPanel.Controls.Add(this.flowPanelSearchSettings);
            this.optionFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.optionFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.optionFlowPanel.Name = "optionFlowPanel";
            this.optionFlowPanel.Size = new System.Drawing.Size(241, 644);
            this.optionFlowPanel.TabIndex = 5;
            // 
            // searchingPanel
            // 
            this.searchingPanel.Controls.Add(this.orderByButton);
            this.searchingPanel.Controls.Add(this.label1);
            this.searchingPanel.Controls.Add(this.searchTextBox);
            this.searchingPanel.Location = new System.Drawing.Point(3, 3);
            this.searchingPanel.Name = "searchingPanel";
            this.searchingPanel.Size = new System.Drawing.Size(237, 109);
            this.searchingPanel.TabIndex = 1;
            // 
            // orderByButton
            // 
            this.orderByButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.orderByButton.FlatAppearance.BorderSize = 0;
            this.orderByButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderByButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.orderByButton.ForeColor = System.Drawing.Color.White;
            this.orderByButton.Location = new System.Drawing.Point(21, 72);
            this.orderByButton.Margin = new System.Windows.Forms.Padding(2);
            this.orderByButton.Name = "orderByButton";
            this.orderByButton.Size = new System.Drawing.Size(192, 24);
            this.orderByButton.TabIndex = 25;
            this.orderByButton.Text = "OrderBy";
            this.orderByButton.UseVisualStyleBackColor = false;
            this.orderByButton.Click += new System.EventHandler(this.orderByButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.searchTextBox.Location = new System.Drawing.Point(22, 32);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(191, 24);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TabStop = false;
            this.searchTextBox.Text = "Search..";
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // flowPanelSearchSettings
            // 
            this.flowPanelSearchSettings.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.flowPanelSearchSettings.Controls.Add(this.searchSettingsButton);
            this.flowPanelSearchSettings.Controls.Add(this.panelWhere);
            this.flowPanelSearchSettings.Controls.Add(this.panelOrderBy);
            this.flowPanelSearchSettings.Location = new System.Drawing.Point(3, 118);
            this.flowPanelSearchSettings.MaximumSize = new System.Drawing.Size(228, 400);
            this.flowPanelSearchSettings.MinimumSize = new System.Drawing.Size(228, 64);
            this.flowPanelSearchSettings.Name = "flowPanelSearchSettings";
            this.flowPanelSearchSettings.Size = new System.Drawing.Size(228, 64);
            this.flowPanelSearchSettings.TabIndex = 9;
            this.flowPanelSearchSettings.Tag = false;
            // 
            // searchSettingsButton
            // 
            this.searchSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))),
                ((int) (((byte) (44)))), ((int) (((byte) (44)))));
            this.searchSettingsButton.FlatAppearance.BorderSize = 0;
            this.searchSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchSettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.searchSettingsButton.ForeColor = System.Drawing.Color.White;
            this.searchSettingsButton.Location = new System.Drawing.Point(3, 3);
            this.searchSettingsButton.Name = "searchSettingsButton";
            this.searchSettingsButton.Size = new System.Drawing.Size(228, 58);
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
            this.panelWhere.Controls.Add(this.label5);
            this.panelWhere.Controls.Add(this.buttonWhere);
            this.panelWhere.Location = new System.Drawing.Point(3, 67);
            this.panelWhere.MaximumSize = new System.Drawing.Size(225, 119);
            this.panelWhere.MinimumSize = new System.Drawing.Size(228, 58);
            this.panelWhere.Name = "panelWhere";
            this.panelWhere.Size = new System.Drawing.Size(228, 58);
            this.panelWhere.TabIndex = 2;
            this.panelWhere.Tag = false;
            // 
            // comboBoxWhere
            // 
            this.comboBoxWhere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxWhere.FormattingEnabled = true;
            this.comboBoxWhere.Location = new System.Drawing.Point(64, 77);
            this.comboBoxWhere.Name = "comboBoxWhere";
            this.comboBoxWhere.Size = new System.Drawing.Size(146, 24);
            this.comboBoxWhere.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Filter :";
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
            this.buttonWhere.Size = new System.Drawing.Size(228, 58);
            this.buttonWhere.TabIndex = 2;
            this.buttonWhere.Text = "Where";
            this.buttonWhere.UseVisualStyleBackColor = false;
            this.buttonWhere.Click += new System.EventHandler(this.buttonWhere_Click);
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.BackColor = System.Drawing.Color.DimGray;
            this.panelOrderBy.Controls.Add(this.bunifuSeparatorOrderBy);
            this.panelOrderBy.Controls.Add(this.comboBoxOrderBy);
            this.panelOrderBy.Controls.Add(this.label6);
            this.panelOrderBy.Controls.Add(this.radioButtonDescen);
            this.panelOrderBy.Controls.Add(this.radioButtonAscend);
            this.panelOrderBy.Controls.Add(this.buttonOrderBy);
            this.panelOrderBy.Location = new System.Drawing.Point(3, 131);
            this.panelOrderBy.MaximumSize = new System.Drawing.Size(228, 196);
            this.panelOrderBy.MinimumSize = new System.Drawing.Size(228, 58);
            this.panelOrderBy.Name = "panelOrderBy";
            this.panelOrderBy.Size = new System.Drawing.Size(228, 58);
            this.panelOrderBy.TabIndex = 3;
            this.panelOrderBy.Tag = false;
            // 
            // bunifuSeparatorOrderBy
            // 
            this.bunifuSeparatorOrderBy.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparatorOrderBy.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.bunifuSeparatorOrderBy.LineThickness = 1;
            this.bunifuSeparatorOrderBy.Location = new System.Drawing.Point(0, 118);
            this.bunifuSeparatorOrderBy.Name = "bunifuSeparatorOrderBy";
            this.bunifuSeparatorOrderBy.Size = new System.Drawing.Size(228, 1);
            this.bunifuSeparatorOrderBy.TabIndex = 10;
            this.bunifuSeparatorOrderBy.Transparency = 255;
            this.bunifuSeparatorOrderBy.Vertical = false;
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Location = new System.Drawing.Point(65, 77);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(132, 24);
            this.comboBoxOrderBy.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Filter :";
            // 
            // radioButtonDescen
            // 
            this.radioButtonDescen.AutoSize = true;
            this.radioButtonDescen.Font = new System.Drawing.Font("Century Gothic", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.radioButtonDescen.ForeColor = System.Drawing.Color.White;
            this.radioButtonDescen.Location = new System.Drawing.Point(32, 163);
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
            this.radioButtonAscend.Location = new System.Drawing.Point(40, 131);
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
            this.buttonOrderBy.Size = new System.Drawing.Size(228, 58);
            this.buttonOrderBy.TabIndex = 2;
            this.buttonOrderBy.Text = "OrderBy";
            this.buttonOrderBy.UseVisualStyleBackColor = false;
            this.buttonOrderBy.Click += new System.EventHandler(this.buttonOrderBy_Click);
            // 
            // panelAddGroupSpace
            // 
            this.panelAddGroupSpace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAddGroupSpace.Controls.Add(this.bunifuSeparator1);
            this.panelAddGroupSpace.Controls.Add(this.cancelButton);
            this.panelAddGroupSpace.Controls.Add(this.acceptButton);
            this.panelAddGroupSpace.Controls.Add(this.photoLabel);
            this.panelAddGroupSpace.Controls.Add(this.countOfStudentsLabel);
            this.panelAddGroupSpace.Controls.Add(this.photoPictureBox);
            this.panelAddGroupSpace.Controls.Add(this.label4);
            this.panelAddGroupSpace.Controls.Add(this.addedStudentFlowPanel);
            this.panelAddGroupSpace.Controls.Add(this.label3);
            this.panelAddGroupSpace.Controls.Add(this.nameGroupTextBox);
            this.panelAddGroupSpace.Controls.Add(this.label2);
            this.panelAddGroupSpace.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddGroupSpace.Location = new System.Drawing.Point(472, 0);
            this.panelAddGroupSpace.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddGroupSpace.Name = "panelAddGroupSpace";
            this.panelAddGroupSpace.Size = new System.Drawing.Size(453, 644);
            this.panelAddGroupSpace.TabIndex = 6;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (45)))),
                ((int) (((byte) (45)))), ((int) (((byte) (45)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(3, 644);
            this.bunifuSeparator1.TabIndex = 26;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Teal;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(147, 587);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 37);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Firebrick;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.acceptButton.ForeColor = System.Drawing.Color.White;
            this.acceptButton.Location = new System.Drawing.Point(32, 587);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(97, 37);
            this.acceptButton.TabIndex = 24;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Enabled = false;
            this.photoLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.photoLabel.Location = new System.Drawing.Point(187, 59);
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
            this.countOfStudentsLabel.Location = new System.Drawing.Point(78, 63);
            this.countOfStudentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countOfStudentsLabel.Name = "countOfStudentsLabel";
            this.countOfStudentsLabel.Size = new System.Drawing.Size(0, 19);
            this.countOfStudentsLabel.TabIndex = 6;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.Location = new System.Drawing.Point(154, 12);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(106, 117);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(18, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Count:";
            // 
            // addedStudentFlowPanel
            // 
            this.addedStudentFlowPanel.AutoScroll = true;
            this.addedStudentFlowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addedStudentFlowPanel.Location = new System.Drawing.Point(13, 170);
            this.addedStudentFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addedStudentFlowPanel.Name = "addedStudentFlowPanel";
            this.addedStudentFlowPanel.Size = new System.Drawing.Size(276, 397);
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
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Students:";
            // 
            // nameGroupTextBox
            // 
            this.nameGroupTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.nameGroupTextBox.Location = new System.Drawing.Point(20, 33);
            this.nameGroupTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameGroupTextBox.Multiline = true;
            this.nameGroupTextBox.Name = "nameGroupTextBox";
            this.nameGroupTextBox.Size = new System.Drawing.Size(125, 23);
            this.nameGroupTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of group:";
            // 
            // currentStudentsFlowPanel
            // 
            this.currentStudentsFlowPanel.AutoScroll = true;
            this.currentStudentsFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.currentStudentsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentStudentsFlowPanel.Location = new System.Drawing.Point(241, 0);
            this.currentStudentsFlowPanel.Name = "currentStudentsFlowPanel";
            this.currentStudentsFlowPanel.Size = new System.Drawing.Size(231, 644);
            this.currentStudentsFlowPanel.TabIndex = 9;
            // 
            // EditGroupBoardSecond
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.currentStudentsFlowPanel);
            this.Controls.Add(this.panelAddGroupSpace);
            this.Controls.Add(this.optionFlowPanel);
            this.Enabled = false;
            this.Name = "EditGroupBoardSecond";
            this.Size = new System.Drawing.Size(925, 644);
            this.Load += new System.EventHandler(this.EditGroupBoardSecond_Load);
            this.optionFlowPanel.ResumeLayout(false);
            this.searchingPanel.ResumeLayout(false);
            this.searchingPanel.PerformLayout();
            this.flowPanelSearchSettings.ResumeLayout(false);
            this.panelWhere.ResumeLayout(false);
            this.panelWhere.PerformLayout();
            this.panelOrderBy.ResumeLayout(false);
            this.panelOrderBy.PerformLayout();
            this.panelAddGroupSpace.ResumeLayout(false);
            this.panelAddGroupSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel optionFlowPanel;
        private System.Windows.Forms.Panel panelAddGroupSpace;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.Label countOfStudentsLabel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel addedStudentFlowPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameGroupTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel currentStudentsFlowPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel searchingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelSearchSettings;
        private System.Windows.Forms.Button searchSettingsButton;
        private System.Windows.Forms.Panel panelWhere;
        private System.Windows.Forms.ComboBox comboBoxWhere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonWhere;
        private System.Windows.Forms.Panel panelOrderBy;
        private System.Windows.Forms.RadioButton radioButtonDescen;
        private System.Windows.Forms.RadioButton radioButtonAscend;
        private System.Windows.Forms.Button buttonOrderBy;
        private System.Windows.Forms.Button orderByButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparatorOrderBy;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Label label6;
    }
}
