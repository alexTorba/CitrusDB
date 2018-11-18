using CitrusDB.Model.Entity;
using CitrusDB.View.AddGroup;
using CitrusDB.View.AddStudent;
using CitrusDB.View.DataBoard;

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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backlightPanel = new System.Windows.Forms.Panel();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.editPanel = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.editStudentBoardFirst1 = new CitrusDB.View.EditStuden.editStudentBoardFirst();
            this.addGroupBoard = new CitrusDB.View.AddGroup.AddGroupBoard();
            this.dataBoard = new CitrusDB.View.DataBoard.DataBoard();
            this.addStudentBoard = new CitrusDB.View.AddStudent.AddStudentBoard();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGroupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backlightPanel
            // 
            this.backlightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(34)))));
            this.backlightPanel.Location = new System.Drawing.Point(3, 135);
            this.backlightPanel.Name = "backlightPanel";
            this.backlightPanel.Size = new System.Drawing.Size(16, 51);
            this.backlightPanel.TabIndex = 3;
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.FlatAppearance.BorderSize = 0;
            this.buttonAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAboutUs.ForeColor = System.Drawing.Color.White;
            this.buttonAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("buttonAboutUs.Image")));
            this.buttonAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutUs.Location = new System.Drawing.Point(3, 288);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Size = new System.Drawing.Size(163, 51);
            this.buttonAboutUs.TabIndex = 7;
            this.buttonAboutUs.Text = "      About us";
            this.buttonAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            this.buttonAboutUs.Click += new System.EventHandler(this.buttonAboutUs_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(3, 231);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(163, 51);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "      Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatistics.Image")));
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.Location = new System.Drawing.Point(3, 174);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(163, 51);
            this.buttonStatistics.TabIndex = 5;
            this.buttonStatistics.Text = "      Statistics";
            this.buttonStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
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
            // 
            // buttonData
            // 
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonData.ForeColor = System.Drawing.Color.White;
            this.buttonData.Image = ((System.Drawing.Image)(resources.GetObject("buttonData.Image")));
            this.buttonData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonData.Location = new System.Drawing.Point(3, 3);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(163, 51);
            this.buttonData.TabIndex = 3;
            this.buttonData.Text = "      Data";
            this.buttonData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(34)))));
            this.dragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragPanel.Controls.Add(this.buttonExit);
            this.dragPanel.Controls.Add(this.button1);
            this.dragPanel.Controls.Add(this.button2);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(188, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(917, 31);
            this.dragPanel.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(876, -2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(38, 31);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(800, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(838, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 31);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "CitrusDB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelGroupAdd
            // 
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
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // buttonStudent
            // 
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudent.ForeColor = System.Drawing.Color.White;
            this.buttonStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonStudent.Image")));
            this.buttonStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudent.Location = new System.Drawing.Point(31, 51);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(129, 51);
            this.buttonStudent.TabIndex = 5;
            this.buttonStudent.Text = "      Student";
            this.buttonStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.FlatAppearance.BorderSize = 0;
            this.buttonGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroup.ForeColor = System.Drawing.Color.White;
            this.buttonGroup.Image = ((System.Drawing.Image)(resources.GetObject("buttonGroup.Image")));
            this.buttonGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroup.Location = new System.Drawing.Point(30, 102);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(130, 51);
            this.buttonGroup.TabIndex = 6;
            this.buttonGroup.Text = "      Group";
            this.buttonGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backlightPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 629);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowLayoutPanel1.Controls.Add(this.buttonData);
            this.flowLayoutPanel1.Controls.Add(this.panelGroupAdd);
            this.flowLayoutPanel1.Controls.Add(this.editPanel);
            this.flowLayoutPanel1.Controls.Add(this.buttonStatistics);
            this.flowLayoutPanel1.Controls.Add(this.buttonSettings);
            this.flowLayoutPanel1.Controls.Add(this.buttonAboutUs);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 484);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.dragPanel;
            this.dragControl.Vertical = true;
            // 
            // editPanel
            // 
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
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
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
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 17);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // editStudentButton
            // 
            this.editStudentButton.FlatAppearance.BorderSize = 0;
            this.editStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStudentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editStudentButton.ForeColor = System.Drawing.Color.White;
            this.editStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("editStudentButton.Image")));
            this.editStudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editStudentButton.Location = new System.Drawing.Point(31, 51);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(129, 51);
            this.editStudentButton.TabIndex = 5;
            this.editStudentButton.Text = "      Student";
            this.editStudentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // editGroupButton
            // 
            this.editGroupButton.FlatAppearance.BorderSize = 0;
            this.editGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGroupButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editGroupButton.ForeColor = System.Drawing.Color.White;
            this.editGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("editGroupButton.Image")));
            this.editGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editGroupButton.Location = new System.Drawing.Point(30, 102);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(130, 51);
            this.editGroupButton.TabIndex = 6;
            this.editGroupButton.Text = "      Group";
            this.editGroupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editGroupButton.UseVisualStyleBackColor = true;
            // 
            // editStudentBoardFirst1
            // 
            this.editStudentBoardFirst1.Location = new System.Drawing.Point(188, 31);
            this.editStudentBoardFirst1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.editStudentBoardFirst1.Name = "editStudentBoardFirst1";
            this.editStudentBoardFirst1.Size = new System.Drawing.Size(915, 598);
            this.editStudentBoardFirst1.TabIndex = 13;
            // 
            // addGroupBoard
            // 
            this.addGroupBoard.CountOfAddedStudent = "0";
            this.addGroupBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGroupBoard.Location = new System.Drawing.Point(188, 31);
            this.addGroupBoard.Margin = new System.Windows.Forms.Padding(3, 1007, 3, 1007);
            this.addGroupBoard.Name = "addGroupBoard";
            this.addGroupBoard.Size = new System.Drawing.Size(917, 598);
            this.addGroupBoard.TabIndex = 12;
            // 
            // dataBoard
            // 
            this.dataBoard.BackColor = System.Drawing.SystemColors.Control;
            this.dataBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBoard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBoard.GetDataSource = null;
            this.dataBoard.Location = new System.Drawing.Point(188, 31);
            this.dataBoard.Margin = new System.Windows.Forms.Padding(4);
            this.dataBoard.Name = "dataBoard";
            this.dataBoard.Size = new System.Drawing.Size(917, 598);
            this.dataBoard.TabIndex = 11;
            // 
            // addStudentBoard
            // 
            this.addStudentBoard.DateOfBirth = "1.1.1960";
            this.addStudentBoard.Location = new System.Drawing.Point(188, 31);
            this.addStudentBoard.Name = "addStudentBoard";
            this.addStudentBoard.ProgressBarValue = 0;
            this.addStudentBoard.Size = new System.Drawing.Size(917, 598);
            this.addStudentBoard.TabIndex = 10;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(CitrusDB.Model.Entity.Student);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1105, 629);
            this.Controls.Add(this.editStudentBoardFirst1);
            this.Controls.Add(this.addGroupBoard);
            this.Controls.Add(this.dataBoard);
            this.Controls.Add(this.addStudentBoard);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGroupAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Panel backlightPanel;
        private System.Windows.Forms.Button buttonAboutUs;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelGroupAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        public AddStudentBoard addStudentBoard;
        public CitrusDB.View.DataBoard.DataBoard dataBoard;
        public AddGroupBoard addGroupBoard;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button editGroupButton;
        private EditStuden.editStudentBoardFirst editStudentBoardFirst1;
    }
}

