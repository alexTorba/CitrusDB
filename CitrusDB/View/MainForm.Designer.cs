﻿using CitrusDB.View.Groups.AddGroup;
using CitrusDB.View.Students.AddStudent;
using CitrusDB.View.Students.EditStuden;

namespace CitrusDB.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(CitrusDB.View.MainForm));
            this.backlightPanel = new System.Windows.Forms.Panel();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rollUpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGroupAdd = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statisticBoard = new CitrusDB.View.Statistics.StatisticBoard();
            this.editGroupBoard = new CitrusDB.View.Groups.EditGroup.EditGroupBoard();
            this.editStudentBoard = new CitrusDB.View.Students.EditStuden.EditStudentBoard();
            this.addGroupBoard = new CitrusDB.View.Groups.AddGroup.AddGroupBoard();
            this.addStudentBoard = new CitrusDB.View.Students.AddStudent.AddStudentBoard();
            this.dataBoard = new CitrusDB.View.DataBoard.DataBoard();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboutUsBoard = new CitrusDB.View.AboutUs.AboutUsBoard();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.panelGroupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            this.backlightPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (145)))), ((int) (((byte) (34)))));
            this.backlightPanel.Location = new System.Drawing.Point(3, 145);
            this.backlightPanel.Name = "backlightPanel";
            this.backlightPanel.Size = new System.Drawing.Size(16, 51);
            this.backlightPanel.TabIndex = 3;
            this.buttonAboutUs.FlatAppearance.BorderSize = 0;
            this.buttonAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAboutUs.ForeColor = System.Drawing.Color.White;
            this.buttonAboutUs.Image = ((System.Drawing.Image) (resources.GetObject("buttonAboutUs.Image")));
            this.buttonAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutUs.Location = new System.Drawing.Point(3, 288);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Size = new System.Drawing.Size(163, 51);
            this.buttonAboutUs.TabIndex = 7;
            this.buttonAboutUs.Text = "      About us";
            this.buttonAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            this.buttonAboutUs.Click += new System.EventHandler(this.buttonAboutUs_Click);
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image) (resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(3, 231);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(163, 51);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "      Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Century Gothic", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Image = ((System.Drawing.Image) (resources.GetObject("buttonStatistics.Image")));
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.Location = new System.Drawing.Point(3, 174);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(163, 51);
            this.buttonStatistics.TabIndex = 5;
            this.buttonStatistics.Text = "      Statistics";
            this.buttonStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = ((System.Drawing.Image) (resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(163, 51);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Tag = "add";
            this.buttonAdd.Text = "      Add";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonData.ForeColor = System.Drawing.Color.White;
            this.buttonData.Image = ((System.Drawing.Image) (resources.GetObject("buttonData.Image")));
            this.buttonData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonData.Location = new System.Drawing.Point(3, 3);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(163, 51);
            this.buttonData.TabIndex = 3;
            this.buttonData.Text = "      Data";
            this.buttonData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (145)))),
                ((int) (((byte) (34)))));
            this.dragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragPanel.Controls.Add(this.buttonExit);
            this.dragPanel.Controls.Add(this.button1);
            this.dragPanel.Controls.Add(this.rollUpButton);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(188, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(917, 31);
            this.dragPanel.TabIndex = 1;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image) (resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(876, -2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(38, 31);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(800, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.rollUpButton.FlatAppearance.BorderSize = 0;
            this.rollUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollUpButton.Image = ((System.Drawing.Image) (resources.GetObject("rollUpButton.Image")));
            this.rollUpButton.Location = new System.Drawing.Point(838, -2);
            this.rollUpButton.Name = "rollUpButton";
            this.rollUpButton.Size = new System.Drawing.Size(38, 31);
            this.rollUpButton.TabIndex = 4;
            this.rollUpButton.UseVisualStyleBackColor = true;
            this.rollUpButton.Click += new System.EventHandler(this.rollUpButton_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "CitrusDB";
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.panelGroupAdd.Controls.Add(this.buttonAdd);
            this.panelGroupAdd.Controls.Add(this.pictureBox3);
            this.panelGroupAdd.Controls.Add(this.pictureBox2);
            this.panelGroupAdd.Controls.Add(this.buttonStudent);
            this.panelGroupAdd.Controls.Add(this.buttonGroup);
            this.panelGroupAdd.Location = new System.Drawing.Point(3, 60);
            this.panelGroupAdd.MaximumSize = new System.Drawing.Size(163, 154);
            this.panelGroupAdd.MinimumSize = new System.Drawing.Size(163, 51);
            this.panelGroupAdd.Name = "panelGroupAdd";
            this.panelGroupAdd.Size = new System.Drawing.Size(163, 51);
            this.panelGroupAdd.TabIndex = 3;
            this.panelGroupAdd.Tag = false;
            this.panelGroupAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGroupAdd_MouseClick);
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonStudent.ForeColor = System.Drawing.Color.White;
            this.buttonStudent.Image = ((System.Drawing.Image) (resources.GetObject("buttonStudent.Image")));
            this.buttonStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudent.Location = new System.Drawing.Point(31, 51);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(129, 51);
            this.buttonStudent.TabIndex = 5;
            this.buttonStudent.Text = "      Student";
            this.buttonStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            this.buttonGroup.FlatAppearance.BorderSize = 0;
            this.buttonGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonGroup.ForeColor = System.Drawing.Color.White;
            this.buttonGroup.Image = ((System.Drawing.Image) (resources.GetObject("buttonGroup.Image")));
            this.buttonGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroup.Location = new System.Drawing.Point(30, 102);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(130, 51);
            this.buttonGroup.TabIndex = 6;
            this.buttonGroup.Text = "      Group";
            this.buttonGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (31)))),
                ((int) (((byte) (31)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backlightPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 702);
            this.panel1.TabIndex = 8;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonData);
            this.flowLayoutPanel1.Controls.Add(this.panelGroupAdd);
            this.flowLayoutPanel1.Controls.Add(this.editPanel);
            this.flowLayoutPanel1.Controls.Add(this.buttonStatistics);
            this.flowLayoutPanel1.Controls.Add(this.buttonSettings);
            this.flowLayoutPanel1.Controls.Add(this.buttonAboutUs);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 144);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 557);
            this.flowLayoutPanel1.TabIndex = 9;
            this.editPanel.Controls.Add(this.editButton);
            this.editPanel.Controls.Add(this.pictureBox4);
            this.editPanel.Controls.Add(this.pictureBox5);
            this.editPanel.Controls.Add(this.editStudentButton);
            this.editPanel.Controls.Add(this.editGroupButton);
            this.editPanel.Location = new System.Drawing.Point(3, 117);
            this.editPanel.MaximumSize = new System.Drawing.Size(163, 154);
            this.editPanel.MinimumSize = new System.Drawing.Size(163, 51);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(163, 51);
            this.editPanel.TabIndex = 7;
            this.editPanel.Tag = false;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Image = ((System.Drawing.Image) (resources.GetObject("editButton.Image")));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(0, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(163, 51);
            this.editButton.TabIndex = 4;
            this.editButton.Tag = "";
            this.editButton.Text = "      Edit";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.pictureBox4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox5.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 17);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.editStudentButton.FlatAppearance.BorderSize = 0;
            this.editStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStudentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editStudentButton.ForeColor = System.Drawing.Color.White;
            this.editStudentButton.Image = ((System.Drawing.Image) (resources.GetObject("editStudentButton.Image")));
            this.editStudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editStudentButton.Location = new System.Drawing.Point(31, 51);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(129, 51);
            this.editStudentButton.TabIndex = 5;
            this.editStudentButton.Text = "      Student";
            this.editStudentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            this.editGroupButton.FlatAppearance.BorderSize = 0;
            this.editGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGroupButton.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editGroupButton.ForeColor = System.Drawing.Color.White;
            this.editGroupButton.Image = ((System.Drawing.Image) (resources.GetObject("editGroupButton.Image")));
            this.editGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editGroupButton.Location = new System.Drawing.Point(30, 102);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(130, 51);
            this.editGroupButton.TabIndex = 6;
            this.editGroupButton.Text = "      Group";
            this.editGroupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editGroupButton.UseVisualStyleBackColor = true;
            this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.dragPanel;
            this.dragControl.Vertical = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (34)))),
                ((int) (((byte) (34)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.statusTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(188, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 27);
            this.panel2.TabIndex = 14;
            this.statusTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))),
                ((int) (((byte) (34)))), ((int) (((byte) (34)))));
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.statusTextBox.ForeColor = System.Drawing.Color.White;
            this.statusTextBox.Location = new System.Drawing.Point(386, 5);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(518, 19);
            this.statusTextBox.TabIndex = 0;
            this.statusTextBox.Tag = "©All rights reserved";
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.statisticBoard.AutoSize = true;
            this.statisticBoard.CountOfGroup = "xx";
            this.statisticBoard.CountOfStudent = "xx";
            this.statisticBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticBoard.GroupsHistory = null;
            this.statisticBoard.Location = new System.Drawing.Point(188, 31);
            this.statisticBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticBoard.Name = "statisticBoard";
            this.statisticBoard.Size = new System.Drawing.Size(917, 644);
            this.statisticBoard.StudentsHistory = null;
            this.statisticBoard.TabIndex = 20;
            this.editGroupBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGroupBoard.Location = new System.Drawing.Point(188, 31);
            this.editGroupBoard.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.editGroupBoard.Name = "editGroupBoard";
            this.editGroupBoard.Size = new System.Drawing.Size(917, 644);
            this.editGroupBoard.TabIndex = 19;
            this.editStudentBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editStudentBoard.Location = new System.Drawing.Point(188, 31);
            this.editStudentBoard.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.editStudentBoard.Name = "editStudentBoard";
            this.editStudentBoard.Size = new System.Drawing.Size(917, 644);
            this.editStudentBoard.TabIndex = 18;
            this.addGroupBoard.CountOfAddedStudent = "0";
            this.addGroupBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGroupBoard.Location = new System.Drawing.Point(188, 31);
            this.addGroupBoard.Margin = new System.Windows.Forms.Padding(3, 32, 3, 32);
            this.addGroupBoard.Name = "addGroupBoard";
            this.addGroupBoard.Size = new System.Drawing.Size(917, 644);
            this.addGroupBoard.TabIndex = 17;
            this.addStudentBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentBoard.GroupId = 0;
            this.addStudentBoard.Location = new System.Drawing.Point(188, 31);
            this.addStudentBoard.Name = "addStudentBoard";
            this.addStudentBoard.ProgressBarValue = 0;
            this.addStudentBoard.Size = new System.Drawing.Size(917, 644);
            this.addStudentBoard.TabIndex = 16;
            this.dataBoard.BackColor = System.Drawing.SystemColors.Control;
            this.dataBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBoard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dataBoard.GetDataSource = null;
            this.dataBoard.Location = new System.Drawing.Point(188, 31);
            this.dataBoard.Margin = new System.Windows.Forms.Padding(4);
            this.dataBoard.Name = "dataBoard";
            this.dataBoard.SelectedEntity = CitrusDB.Model.Entity.SelectedEntity.Student;
            this.dataBoard.Size = new System.Drawing.Size(917, 644);
            this.dataBoard.TabIndex = 15;
            this.studentBindingSource.DataSource = typeof(CitrusDB.Model.Entity.Student);
            this.aboutUsBoard.AutoSize = true;
            this.aboutUsBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUsBoard.Location = new System.Drawing.Point(188, 31);
            this.aboutUsBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aboutUsBoard.Name = "aboutUsBoard";
            this.aboutUsBoard.Size = new System.Drawing.Size(917, 644);
            this.aboutUsBoard.TabIndex = 21;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1105, 702);
            this.Controls.Add(this.aboutUsBoard);
            this.Controls.Add(this.statisticBoard);
            this.Controls.Add(this.editGroupBoard);
            this.Controls.Add(this.editStudentBoard);
            this.Controls.Add(this.addGroupBoard);
            this.Controls.Add(this.addStudentBoard);
            this.Controls.Add(this.dataBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.panelGroupAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

