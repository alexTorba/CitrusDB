namespace CitrusDB.View.Groups.EditGroup
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
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
            this.panel1.SuspendLayout();
            this.panelAddGroupSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // optionFlowPanel
            // 
            this.optionFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.optionFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionFlowPanel.Controls.Add(this.panel1);
            this.optionFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.optionFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.optionFlowPanel.Name = "optionFlowPanel";
            this.optionFlowPanel.Size = new System.Drawing.Size(241, 644);
            this.optionFlowPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 71);
            this.panel1.TabIndex = 1;
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
            this.searchTextBox.Size = new System.Drawing.Size(191, 23);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "Search..";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // panelAddGroupSpace
            // 
            this.panelAddGroupSpace.BackColor = System.Drawing.SystemColors.Control;
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
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
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
            this.photoLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.countOfStudentsLabel.Location = new System.Drawing.Point(178, 67);
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
            this.addedStudentFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.addedStudentFlowPanel.Location = new System.Drawing.Point(13, 170);
            this.addedStudentFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addedStudentFlowPanel.Name = "addedStudentFlowPanel";
            this.addedStudentFlowPanel.Size = new System.Drawing.Size(276, 397);
            this.addedStudentFlowPanel.TabIndex = 4;
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
            this.nameGroupTextBox.Size = new System.Drawing.Size(125, 22);
            this.nameGroupTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.currentStudentsFlowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.Name = "EditGroupBoardSecond";
            this.Size = new System.Drawing.Size(925, 644);
            this.Load += new System.EventHandler(this.EditGroupBoardSecond_Load);
            this.optionFlowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAddGroupSpace.ResumeLayout(false);
            this.panelAddGroupSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
