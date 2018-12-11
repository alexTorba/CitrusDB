﻿namespace CitrusDB.View.Students.EditStuden
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
            this.collapsedButton = new CitrusDB.View.UsersElements.CirclusButton();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.flowGroupOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unityPanel = new System.Windows.Forms.Panel();
            this.studentFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelSearchSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.searchSettingsButton = new System.Windows.Forms.Button();
            this.panelWhere = new System.Windows.Forms.Panel();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonWhere = new System.Windows.Forms.Button();
            this.panelOrderBy = new System.Windows.Forms.Panel();
            this.radioButtonDescen = new System.Windows.Forms.RadioButton();
            this.radioButtonAscend = new System.Windows.Forms.RadioButton();
            this.buttonOrderBy = new System.Windows.Forms.Button();
            this.generPanelOptions.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.flowGroupOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.unityPanel.SuspendLayout();
            this.flowPanelSearchSettings.SuspendLayout();
            this.panelWhere.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
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
            // collapsedButton
            // 
            this.collapsedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.collapsedButton.FlatAppearance.BorderSize = 0;
            this.collapsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedButton.Image = global::CitrusDB.Properties.Resources.right;
            this.collapsedButton.Location = new System.Drawing.Point(5, 317);
            this.collapsedButton.Margin = new System.Windows.Forms.Padding(4);
            this.collapsedButton.Name = "collapsedButton";
            this.collapsedButton.Size = new System.Drawing.Size(43, 45);
            this.collapsedButton.TabIndex = 7;
            this.collapsedButton.UseVisualStyleBackColor = false;
            this.collapsedButton.Click += new System.EventHandler(this.collapsedButton_Click);
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
            this.flowGroupOptions.Controls.Add(this.flowPanelSearchSettings);
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
            this.panel1.Size = new System.Drawing.Size(240, 76);
            this.panel1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.searchTextBox.Location = new System.Drawing.Point(25, 32);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(191, 23);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
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
            // flowPanelSearchSettings
            // 
            this.flowPanelSearchSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowPanelSearchSettings.Controls.Add(this.searchSettingsButton);
            this.flowPanelSearchSettings.Controls.Add(this.panelWhere);
            this.flowPanelSearchSettings.Controls.Add(this.panelOrderBy);
            this.flowPanelSearchSettings.Location = new System.Drawing.Point(3, 85);
            this.flowPanelSearchSettings.MaximumSize = new System.Drawing.Size(228, 329);
            this.flowPanelSearchSettings.MinimumSize = new System.Drawing.Size(228, 64);
            this.flowPanelSearchSettings.Name = "flowPanelSearchSettings";
            this.flowPanelSearchSettings.Size = new System.Drawing.Size(228, 64);
            this.flowPanelSearchSettings.TabIndex = 8;
            this.flowPanelSearchSettings.Tag = false;
            // 
            // searchSettingsButton
            // 
            this.searchSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.searchSettingsButton.FlatAppearance.BorderSize = 0;
            this.searchSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchSettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.panelWhere.Controls.Add(this.comboBoxFilters);
            this.panelWhere.Controls.Add(this.label3);
            this.panelWhere.Controls.Add(this.buttonWhere);
            this.panelWhere.Location = new System.Drawing.Point(3, 67);
            this.panelWhere.MaximumSize = new System.Drawing.Size(225, 119);
            this.panelWhere.MinimumSize = new System.Drawing.Size(228, 58);
            this.panelWhere.Name = "panelWhere";
            this.panelWhere.Size = new System.Drawing.Size(228, 58);
            this.panelWhere.TabIndex = 2;
            this.panelWhere.Tag = false;
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(68, 77);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(146, 24);
            this.comboBoxFilters.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter :";
            // 
            // buttonWhere
            // 
            this.buttonWhere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonWhere.FlatAppearance.BorderSize = 0;
            this.buttonWhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.panelOrderBy.Controls.Add(this.radioButtonDescen);
            this.panelOrderBy.Controls.Add(this.radioButtonAscend);
            this.panelOrderBy.Controls.Add(this.buttonOrderBy);
            this.panelOrderBy.Location = new System.Drawing.Point(3, 131);
            this.panelOrderBy.MaximumSize = new System.Drawing.Size(228, 136);
            this.panelOrderBy.MinimumSize = new System.Drawing.Size(228, 58);
            this.panelOrderBy.Name = "panelOrderBy";
            this.panelOrderBy.Size = new System.Drawing.Size(228, 58);
            this.panelOrderBy.TabIndex = 3;
            this.panelOrderBy.Tag = false;
            // 
            // radioButtonDescen
            // 
            this.radioButtonDescen.AutoSize = true;
            this.radioButtonDescen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDescen.ForeColor = System.Drawing.Color.White;
            this.radioButtonDescen.Location = new System.Drawing.Point(32, 101);
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
            this.radioButtonAscend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAscend.ForeColor = System.Drawing.Color.White;
            this.radioButtonAscend.Location = new System.Drawing.Point(40, 69);
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
            this.buttonOrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOrderBy.FlatAppearance.BorderSize = 0;
            this.buttonOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderBy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrderBy.ForeColor = System.Drawing.Color.White;
            this.buttonOrderBy.Location = new System.Drawing.Point(0, 0);
            this.buttonOrderBy.Name = "buttonOrderBy";
            this.buttonOrderBy.Size = new System.Drawing.Size(228, 58);
            this.buttonOrderBy.TabIndex = 2;
            this.buttonOrderBy.Text = "OrderBy";
            this.buttonOrderBy.UseVisualStyleBackColor = false;
            this.buttonOrderBy.Click += new System.EventHandler(this.buttonOrderBy_Click);
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
            this.flowPanelSearchSettings.ResumeLayout(false);
            this.panelWhere.ResumeLayout(false);
            this.panelWhere.PerformLayout();
            this.panelOrderBy.ResumeLayout(false);
            this.panelOrderBy.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowPanelSearchSettings;
        private System.Windows.Forms.Button searchSettingsButton;
        private System.Windows.Forms.Panel panelWhere;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonWhere;
        private System.Windows.Forms.Panel panelOrderBy;
        private System.Windows.Forms.RadioButton radioButtonDescen;
        private System.Windows.Forms.RadioButton radioButtonAscend;
        private System.Windows.Forms.Button buttonOrderBy;
    }
}
