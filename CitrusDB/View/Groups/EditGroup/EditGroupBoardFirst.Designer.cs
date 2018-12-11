namespace CitrusDB.View.Groups.EditGroup
{
    partial class EditGroupBoardFirst
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
            this.optionalPanel = new System.Windows.Forms.Panel();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.searchGroupTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.optionalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionalPanel
            // 
            this.optionalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.optionalPanel.Controls.Add(this.editGroupButton);
            this.optionalPanel.Controls.Add(this.searchGroupTextBox);
            this.optionalPanel.Controls.Add(this.label1);
            this.optionalPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.optionalPanel.Location = new System.Drawing.Point(632, 0);
            this.optionalPanel.Name = "optionalPanel";
            this.optionalPanel.Size = new System.Drawing.Size(296, 644);
            this.optionalPanel.TabIndex = 0;
            // 
            // editGroupButton
            // 
            this.editGroupButton.BackColor = System.Drawing.Color.Teal;
            this.editGroupButton.FlatAppearance.BorderSize = 0;
            this.editGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGroupButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.editGroupButton.ForeColor = System.Drawing.Color.White;
            this.editGroupButton.Location = new System.Drawing.Point(69, 574);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(162, 39);
            this.editGroupButton.TabIndex = 23;
            this.editGroupButton.Text = "Edit";
            this.editGroupButton.UseVisualStyleBackColor = false;
            this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
            // 
            // searchGroupTextBox
            // 
            this.searchGroupTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.searchGroupTextBox.Location = new System.Drawing.Point(51, 43);
            this.searchGroupTextBox.Multiline = true;
            this.searchGroupTextBox.Name = "searchGroupTextBox";
            this.searchGroupTextBox.Size = new System.Drawing.Size(191, 24);
            this.searchGroupTextBox.TabIndex = 1;
            this.searchGroupTextBox.TextChanged += new System.EventHandler(this.searchGroupTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // groupFlowPanel
            // 
            this.groupFlowPanel.AutoScroll = true;
            this.groupFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.groupFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.groupFlowPanel.Name = "groupFlowPanel";
            this.groupFlowPanel.Size = new System.Drawing.Size(632, 644);
            this.groupFlowPanel.TabIndex = 1;
            // 
            // EditGroupBoardFirst
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupFlowPanel);
            this.Controls.Add(this.optionalPanel);
            this.Name = "EditGroupBoardFirst";
            this.Size = new System.Drawing.Size(928, 644);
            this.Load += new System.EventHandler(this.EditGroupBoardFirst_Load);
            this.optionalPanel.ResumeLayout(false);
            this.optionalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionalPanel;
        private System.Windows.Forms.TextBox searchGroupTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel groupFlowPanel;
        private System.Windows.Forms.Button editGroupButton;
    }
}
