﻿namespace CitrusDB.View.Students.StudentsView.StudentInfo
{
    partial class StudentInfoForm
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
            this.timer?.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dateOfBirthLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateOfBirthValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.heightLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.heightValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.weightValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.weightLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.citizenshipLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.knowledgeOfLanguageLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.citizenshipValue = new System.Windows.Forms.TextBox();
            this.knowledgeOfLanguageValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.middleNameValue = new System.Windows.Forms.TextBox();
            this.closeButton = new CitrusDB.View.UsersElements.CirclusButton();
            ((System.ComponentModel.ISupportInitialize) (this.photoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.Location = new System.Drawing.Point(28, 20);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(115, 136);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (145)))), ((int) (((byte) (34)))));
            this.bunifuSeparator1.LineThickness = 9;
            this.bunifuSeparator1.Location = new System.Drawing.Point(355, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(7, 445);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bunifuSeparator2.LineThickness = 23;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-1, -2);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(15, 447);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
                ((int) (((byte) (145)))), ((int) (((byte) (34)))));
            this.bunifuSeparator3.LineThickness = 10;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-1, 0);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(362, 8);
            this.bunifuSeparator3.TabIndex = 7;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bunifuSeparator4.LineThickness = 20;
            this.bunifuSeparator4.Location = new System.Drawing.Point(-1, 433);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(362, 15);
            this.bunifuSeparator4.TabIndex = 8;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(72, 187);
            this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(104, 20);
            this.dateOfBirthLabel.TabIndex = 12;
            this.dateOfBirthLabel.Text = "Date of birth:";
            // 
            // dateOfBirthValue
            // 
            this.dateOfBirthValue.AutoSize = true;
            this.dateOfBirthValue.Font = new System.Drawing.Font("Century Gothic", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dateOfBirthValue.Location = new System.Drawing.Point(191, 187);
            this.dateOfBirthValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirthValue.Name = "dateOfBirthValue";
            this.dateOfBirthValue.Size = new System.Drawing.Size(83, 19);
            this.dateOfBirthValue.TabIndex = 13;
            this.dateOfBirthValue.Text = "dateValue";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.heightLabel.Location = new System.Drawing.Point(56, 224);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(60, 20);
            this.heightLabel.TabIndex = 14;
            this.heightLabel.Text = "Height:";
            // 
            // heightValue
            // 
            this.heightValue.AutoSize = true;
            this.heightValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.heightValue.Location = new System.Drawing.Point(127, 225);
            this.heightValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(36, 19);
            this.heightValue.TabIndex = 15;
            this.heightValue.Text = "hhh";
            // 
            // weightValue
            // 
            this.weightValue.AutoSize = true;
            this.weightValue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.weightValue.Location = new System.Drawing.Point(269, 224);
            this.weightValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightValue.Name = "weightValue";
            this.weightValue.Size = new System.Drawing.Size(45, 19);
            this.weightValue.TabIndex = 17;
            this.weightValue.Text = "www";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.weightLabel.Location = new System.Drawing.Point(195, 224);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(65, 20);
            this.weightLabel.TabIndex = 16;
            this.weightLabel.Text = "Weight:";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.citizenshipLabel.Location = new System.Drawing.Point(30, 288);
            this.citizenshipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(89, 20);
            this.citizenshipLabel.TabIndex = 18;
            this.citizenshipLabel.Text = "Сitizenship:";
            // 
            // knowledgeOfLanguageLabel
            // 
            this.knowledgeOfLanguageLabel.AutoSize = true;
            this.knowledgeOfLanguageLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.knowledgeOfLanguageLabel.Location = new System.Drawing.Point(30, 328);
            this.knowledgeOfLanguageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.knowledgeOfLanguageLabel.Name = "knowledgeOfLanguageLabel";
            this.knowledgeOfLanguageLabel.Size = new System.Drawing.Size(88, 20);
            this.knowledgeOfLanguageLabel.TabIndex = 20;
            this.knowledgeOfLanguageLabel.Text = "Language:";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.groupLabel.Location = new System.Drawing.Point(93, 20);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(60, 20);
            this.groupLabel.TabIndex = 22;
            this.groupLabel.Text = "Group:";
            // 
            // groupValue
            // 
            this.groupValue.AutoSize = true;
            this.groupValue.Font = new System.Drawing.Font("Century Gothic", 10.2F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))),
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupValue.Location = new System.Drawing.Point(166, 22);
            this.groupValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupValue.Name = "groupValue";
            this.groupValue.Size = new System.Drawing.Size(73, 17);
            this.groupValue.TabIndex = 23;
            this.groupValue.Text = "groupLink";
            this.groupValue.Click += new System.EventHandler(this.groupValue_Click);
            this.groupValue.MouseEnter += new System.EventHandler(this.groupValue_MouseEnter);
            this.groupValue.MouseLeave += new System.EventHandler(this.groupValue_MouseLeave);
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (105)))),
                ((int) (((byte) (105)))), ((int) (((byte) (105)))));
            this.bunifuSeparator6.LineThickness = 2;
            this.bunifuSeparator6.Location = new System.Drawing.Point(28, 258);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(314, 13);
            this.bunifuSeparator6.TabIndex = 25;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // citizenshipValue
            // 
            this.citizenshipValue.BackColor = System.Drawing.Color.GhostWhite;
            this.citizenshipValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.citizenshipValue.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.citizenshipValue.Location = new System.Drawing.Point(131, 288);
            this.citizenshipValue.Margin = new System.Windows.Forms.Padding(2);
            this.citizenshipValue.Multiline = true;
            this.citizenshipValue.Name = "citizenshipValue";
            this.citizenshipValue.Size = new System.Drawing.Size(211, 21);
            this.citizenshipValue.TabIndex = 26;
            this.citizenshipValue.Text = "citizenship";
            this.citizenshipValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knowledgeOfLanguageValue
            // 
            this.knowledgeOfLanguageValue.BackColor = System.Drawing.Color.GhostWhite;
            this.knowledgeOfLanguageValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.knowledgeOfLanguageValue.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.knowledgeOfLanguageValue.Location = new System.Drawing.Point(133, 328);
            this.knowledgeOfLanguageValue.Margin = new System.Windows.Forms.Padding(2);
            this.knowledgeOfLanguageValue.Multiline = true;
            this.knowledgeOfLanguageValue.Name = "knowledgeOfLanguageValue";
            this.knowledgeOfLanguageValue.Size = new System.Drawing.Size(209, 21);
            this.knowledgeOfLanguageValue.TabIndex = 27;
            this.knowledgeOfLanguageValue.Text = "knowledge of language";
            this.knowledgeOfLanguageValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupLabel);
            this.groupBox1.Controls.Add(this.groupValue);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 378);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(341, 58);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (105)))),
                ((int) (((byte) (105)))), ((int) (((byte) (105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(156, 66);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(188, 2);
            this.bunifuSeparator5.TabIndex = 31;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (105)))),
                ((int) (((byte) (105)))), ((int) (((byte) (105)))));
            this.bunifuSeparator7.LineThickness = 1;
            this.bunifuSeparator7.Location = new System.Drawing.Point(156, 103);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(188, 2);
            this.bunifuSeparator7.TabIndex = 32;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (105)))),
                ((int) (((byte) (105)))), ((int) (((byte) (105)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(156, 141);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(188, 2);
            this.bunifuSeparator8.TabIndex = 33;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this;
            this.dragControl.Vertical = true;
            // 
            // firstNameValue
            // 
            this.firstNameValue.BackColor = System.Drawing.Color.GhostWhite;
            this.firstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.firstNameValue.Location = new System.Drawing.Point(156, 43);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameValue.Multiline = true;
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.ReadOnly = true;
            this.firstNameValue.Size = new System.Drawing.Size(185, 23);
            this.firstNameValue.TabIndex = 36;
            this.firstNameValue.Text = "FirstName";
            this.firstNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameValue
            // 
            this.lastNameValue.BackColor = System.Drawing.Color.GhostWhite;
            this.lastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lastNameValue.Location = new System.Drawing.Point(156, 78);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameValue.Multiline = true;
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.ReadOnly = true;
            this.lastNameValue.Size = new System.Drawing.Size(185, 23);
            this.lastNameValue.TabIndex = 37;
            this.lastNameValue.Text = "LastName";
            this.lastNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // middleNameValue
            // 
            this.middleNameValue.BackColor = System.Drawing.Color.GhostWhite;
            this.middleNameValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleNameValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.middleNameValue.Location = new System.Drawing.Point(156, 118);
            this.middleNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.middleNameValue.Multiline = true;
            this.middleNameValue.Name = "middleNameValue";
            this.middleNameValue.ReadOnly = true;
            this.middleNameValue.Size = new System.Drawing.Size(185, 23);
            this.middleNameValue.TabIndex = 38;
            this.middleNameValue.Text = "MiddleNamepp";
            this.middleNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image) (resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(316, 10);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 32);
            this.closeButton.TabIndex = 35;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(362, 447);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.middleNameValue);
            this.Controls.Add(this.bunifuSeparator8);
            this.Controls.Add(this.bunifuSeparator7);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.knowledgeOfLanguageValue);
            this.Controls.Add(this.citizenshipValue);
            this.Controls.Add(this.bunifuSeparator6);
            this.Controls.Add(this.knowledgeOfLanguageLabel);
            this.Controls.Add(this.citizenshipLabel);
            this.Controls.Add(this.weightValue);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.dateOfBirthValue);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInfoForm";
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.photoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox photoPictureBox;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuCustomLabel dateOfBirthLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel dateOfBirthValue;
        private Bunifu.Framework.UI.BunifuCustomLabel heightLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel heightValue;
        private Bunifu.Framework.UI.BunifuCustomLabel weightValue;
        private Bunifu.Framework.UI.BunifuCustomLabel weightLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel citizenshipLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel knowledgeOfLanguageLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel groupLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel groupValue;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private System.Windows.Forms.TextBox citizenshipValue;
        private System.Windows.Forms.TextBox knowledgeOfLanguageValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.TextBox middleNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.TextBox firstNameValue;
        private CitrusDB.View.UsersElements.CirclusButton closeButton;
    }
}