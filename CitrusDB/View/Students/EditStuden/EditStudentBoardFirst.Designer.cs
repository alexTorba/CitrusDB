namespace CitrusDB.View.Students.EditStuden
{
    partial class EditStudentBoardFirst
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
            this.generPanelOptions = new System.Windows.Forms.Panel();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.flowGroupOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unityPanel = new System.Windows.Forms.Panel();
            this.studentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.collapsedButton = new CitrusDB.View.UsersElements.CirclusButton();
            this.generPanelOptions.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.flowGroupOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.unityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generPanelOptions
            // 
            this.generPanelOptions.Controls.Add(this.collapsedButton);
            this.generPanelOptions.Controls.Add(this.panelGroup);
            this.generPanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.generPanelOptions.Location = new System.Drawing.Point(646, 0);
            this.generPanelOptions.Margin = new System.Windows.Forms.Padding(4);
            this.generPanelOptions.MaximumSize = new System.Drawing.Size(282, 644);
            this.generPanelOptions.MinimumSize = new System.Drawing.Size(70, 644);
            this.generPanelOptions.Name = "generPanelOptions";
            this.generPanelOptions.Size = new System.Drawing.Size(282, 644);
            this.generPanelOptions.TabIndex = 7;
            this.generPanelOptions.Tag = true;
            // 
            // panelGroup
            // 
            this.panelGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelGroup.Controls.Add(this.flowGroupOptions);
            this.panelGroup.Location = new System.Drawing.Point(28, 0);
            this.panelGroup.Margin = new System.Windows.Forms.Padding(4);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(263, 644);
            this.panelGroup.TabIndex = 5;
            // 
            // flowGroupOptions
            // 
            this.flowGroupOptions.Controls.Add(this.panel1);
            this.flowGroupOptions.Location = new System.Drawing.Point(0, 8);
            this.flowGroupOptions.Margin = new System.Windows.Forms.Padding(4);
            this.flowGroupOptions.Name = "flowGroupOptions";
            this.flowGroupOptions.Size = new System.Drawing.Size(259, 562);
            this.flowGroupOptions.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 100);
            this.panel1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(31, 32);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(176, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // unityPanel
            // 
            this.unityPanel.Controls.Add(this.studentFlowLayoutPanel);
            this.unityPanel.Controls.Add(this.generPanelOptions);
            this.unityPanel.Location = new System.Drawing.Point(0, 0);
            this.unityPanel.Name = "unityPanel";
            this.unityPanel.Size = new System.Drawing.Size(928, 644);
            this.unityPanel.TabIndex = 8;
            // 
            // studentFlowLayoutPanel
            // 
            this.studentFlowLayoutPanel.AutoScroll = true;
            this.studentFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.studentFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.studentFlowLayoutPanel.MaximumSize = new System.Drawing.Size(856, 644);
            this.studentFlowLayoutPanel.MinimumSize = new System.Drawing.Size(639, 644);
            this.studentFlowLayoutPanel.Name = "studentFlowLayoutPanel";
            this.studentFlowLayoutPanel.Size = new System.Drawing.Size(639, 644);
            this.studentFlowLayoutPanel.TabIndex = 8;
            // 
            // collapsedButton
            // 
            this.collapsedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.collapsedButton.FlatAppearance.BorderSize = 0;
            this.collapsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedButton.Image = global::CitrusDB.Properties.Resources.left;
            this.collapsedButton.Location = new System.Drawing.Point(5, 317);
            this.collapsedButton.Margin = new System.Windows.Forms.Padding(4);
            this.collapsedButton.Name = "collapsedButton";
            this.collapsedButton.Size = new System.Drawing.Size(43, 45);
            this.collapsedButton.TabIndex = 7;
            this.collapsedButton.UseVisualStyleBackColor = false;
            this.collapsedButton.Click += new System.EventHandler(this.collapsedButton_Click);
            // 
            // EditStudentBoardFirst
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.unityPanel);
            this.Name = "EditStudentBoardFirst";
            this.Size = new System.Drawing.Size(914, 644);
            this.Load += new System.EventHandler(this.editStudentBoardFirst_Load);
            this.generPanelOptions.ResumeLayout(false);
            this.panelGroup.ResumeLayout(false);
            this.flowGroupOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.unityPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel generPanelOptions;
        private UsersElements.CirclusButton collapsedButton;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.FlowLayoutPanel flowGroupOptions;
        private System.Windows.Forms.Panel unityPanel;
        private System.Windows.Forms.FlowLayoutPanel studentFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
    }
}
