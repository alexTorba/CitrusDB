namespace CitrusDB.View.AddGroup
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            this.currentStudentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelAddGroupSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
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
            this.panelAddGroupSpace.Name = "panelAddGroupSpace";
            this.panelAddGroupSpace.Size = new System.Drawing.Size(312, 644);
            this.panelAddGroupSpace.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Teal;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(164, 578);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 43);
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
            this.saveButton.Location = new System.Drawing.Point(41, 578);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 43);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Enabled = false;
            this.photoLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.Location = new System.Drawing.Point(59, 74);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(51, 19);
            this.photoLabel.TabIndex = 1;
            this.photoLabel.Text = "photo";
            // 
            // countOfStudentsLabel
            // 
            this.countOfStudentsLabel.AutoSize = true;
            this.countOfStudentsLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.countOfStudentsLabel.Location = new System.Drawing.Point(225, 82);
            this.countOfStudentsLabel.Name = "countOfStudentsLabel";
            this.countOfStudentsLabel.Size = new System.Drawing.Size(0, 21);
            this.countOfStudentsLabel.TabIndex = 6;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.Location = new System.Drawing.Point(14, 15);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(140, 144);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.photoPictureBox_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(161, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Count:";
            // 
            // addedStudentFlowPanel
            // 
            this.addedStudentFlowPanel.AutoScroll = true;
            this.addedStudentFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.addedStudentFlowPanel.Location = new System.Drawing.Point(3, 205);
            this.addedStudentFlowPanel.Name = "addedStudentFlowPanel";
            this.addedStudentFlowPanel.Size = new System.Drawing.Size(309, 347);
            this.addedStudentFlowPanel.TabIndex = 4;
            this.addedStudentFlowPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.addedStudentFlowPanel_ControlAdded);
            this.addedStudentFlowPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.addedStudentFlowPanel_ControlRemoved);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(8, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Students:";
            // 
            // nameGroupTextBox
            // 
            this.nameGroupTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.nameGroupTextBox.Location = new System.Drawing.Point(165, 44);
            this.nameGroupTextBox.Multiline = true;
            this.nameGroupTextBox.Name = "nameGroupTextBox";
            this.nameGroupTextBox.Size = new System.Drawing.Size(137, 22);
            this.nameGroupTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(161, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of group:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.searchTextBox.Location = new System.Drawing.Point(332, 9);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(188, 22);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Tag = "";
            this.searchTextBox.Text = "Search..";
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // optionFlowPanel
            // 
            this.optionFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.optionFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionFlowPanel.Location = new System.Drawing.Point(774, 0);
            this.optionFlowPanel.Name = "optionFlowPanel";
            this.optionFlowPanel.Size = new System.Drawing.Size(277, 644);
            this.optionFlowPanel.TabIndex = 4;
            // 
            // currentStudentFlowPanel
            // 
            this.currentStudentFlowPanel.AutoScroll = true;
            this.currentStudentFlowPanel.Location = new System.Drawing.Point(328, 39);
            this.currentStudentFlowPanel.Name = "currentStudentFlowPanel";
            this.currentStudentFlowPanel.Size = new System.Drawing.Size(440, 605);
            this.currentStudentFlowPanel.TabIndex = 6;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(313, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 644);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // AddGroupBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.currentStudentFlowPanel);
            this.Controls.Add(this.optionFlowPanel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panelAddGroupSpace);
            this.Name = "AddGroupBoard";
            this.Size = new System.Drawing.Size(1051, 644);
            this.Load += new System.EventHandler(this.AddGroupBoard_Load);
            this.panelAddGroupSpace.ResumeLayout(false);
            this.panelAddGroupSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
