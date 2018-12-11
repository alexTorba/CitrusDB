namespace CitrusDB.View.Statistics
{
    partial class StatisticBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticBoard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.studentButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.deletedTodatValue = new System.Windows.Forms.Label();
            this.updatedTodayValue = new System.Windows.Forms.Label();
            this.addedTodayValue = new System.Windows.Forms.Label();
            this.deletedTodayLabel = new System.Windows.Forms.Label();
            this.updatedTodayLabel = new System.Windows.Forms.Label();
            this.addedTodayLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.generalGroupsValue = new System.Windows.Forms.Label();
            this.generalStudentsValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generalStudentsLabel = new System.Windows.Forms.Label();
            this.logPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logContainerPanel = new System.Windows.Forms.Panel();
            this.collapsedButton = new CitrusDB.View.UsersElements.CirclusButton();
            this.chartContainerPanel = new System.Windows.Forms.Panel();
            this.pictureBoxLoadingAnimation = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.logPanel.SuspendLayout();
            this.logContainerPanel.SuspendLayout();
            this.chartContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flowLayoutPanel1.Controls.Add(this.studentButton);
            this.flowLayoutPanel1.Controls.Add(this.groupButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(773, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 650);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.studentButton.FlatAppearance.BorderSize = 0;
            this.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentButton.ForeColor = System.Drawing.Color.White;
            this.studentButton.Location = new System.Drawing.Point(3, 3);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(152, 77);
            this.studentButton.TabIndex = 0;
            this.studentButton.Text = "Students";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.BackColor = System.Drawing.Color.Crimson;
            this.groupButton.FlatAppearance.BorderSize = 0;
            this.groupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupButton.ForeColor = System.Drawing.Color.White;
            this.groupButton.Location = new System.Drawing.Point(3, 86);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(152, 77);
            this.groupButton.TabIndex = 1;
            this.groupButton.Text = "Groups";
            this.groupButton.UseVisualStyleBackColor = false;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            this.chart.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chart.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 23);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(692, 442);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.White;
            this.optionsPanel.Controls.Add(this.bunifuSeparator3);
            this.optionsPanel.Controls.Add(this.bunifuSeparator2);
            this.optionsPanel.Controls.Add(this.deletedTodatValue);
            this.optionsPanel.Controls.Add(this.updatedTodayValue);
            this.optionsPanel.Controls.Add(this.addedTodayValue);
            this.optionsPanel.Controls.Add(this.deletedTodayLabel);
            this.optionsPanel.Controls.Add(this.updatedTodayLabel);
            this.optionsPanel.Controls.Add(this.addedTodayLabel);
            this.optionsPanel.Controls.Add(this.bunifuSeparator1);
            this.optionsPanel.Controls.Add(this.label2);
            this.optionsPanel.Controls.Add(this.generalGroupsValue);
            this.optionsPanel.Controls.Add(this.generalStudentsValue);
            this.optionsPanel.Controls.Add(this.label1);
            this.optionsPanel.Controls.Add(this.generalStudentsLabel);
            this.optionsPanel.Controls.Add(this.pictureBoxLoadingAnimation);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(773, 177);
            this.optionsPanel.TabIndex = 3;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(467, 0);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(1, 176);
            this.bunifuSeparator3.TabIndex = 13;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 174);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(773, 2);
            this.bunifuSeparator2.TabIndex = 12;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // deletedTodatValue
            // 
            this.deletedTodatValue.AutoSize = true;
            this.deletedTodatValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletedTodatValue.Location = new System.Drawing.Point(683, 119);
            this.deletedTodatValue.Name = "deletedTodatValue";
            this.deletedTodatValue.Size = new System.Drawing.Size(26, 21);
            this.deletedTodatValue.TabIndex = 11;
            this.deletedTodatValue.Text = "xx";
            // 
            // updatedTodayValue
            // 
            this.updatedTodayValue.AutoSize = true;
            this.updatedTodayValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatedTodayValue.Location = new System.Drawing.Point(683, 91);
            this.updatedTodayValue.Name = "updatedTodayValue";
            this.updatedTodayValue.Size = new System.Drawing.Size(26, 21);
            this.updatedTodayValue.TabIndex = 10;
            this.updatedTodayValue.Text = "xx";
            // 
            // addedTodayValue
            // 
            this.addedTodayValue.AutoSize = true;
            this.addedTodayValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addedTodayValue.Location = new System.Drawing.Point(683, 63);
            this.addedTodayValue.Name = "addedTodayValue";
            this.addedTodayValue.Size = new System.Drawing.Size(26, 21);
            this.addedTodayValue.TabIndex = 9;
            this.addedTodayValue.Text = "xx";
            // 
            // deletedTodayLabel
            // 
            this.deletedTodayLabel.AutoSize = true;
            this.deletedTodayLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletedTodayLabel.Location = new System.Drawing.Point(525, 119);
            this.deletedTodayLabel.Name = "deletedTodayLabel";
            this.deletedTodayLabel.Size = new System.Drawing.Size(73, 21);
            this.deletedTodayLabel.TabIndex = 8;
            this.deletedTodayLabel.Text = "Deleted";
            // 
            // updatedTodayLabel
            // 
            this.updatedTodayLabel.AutoSize = true;
            this.updatedTodayLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatedTodayLabel.Location = new System.Drawing.Point(525, 91);
            this.updatedTodayLabel.Name = "updatedTodayLabel";
            this.updatedTodayLabel.Size = new System.Drawing.Size(82, 21);
            this.updatedTodayLabel.TabIndex = 7;
            this.updatedTodayLabel.Text = "Updated";
            // 
            // addedTodayLabel
            // 
            this.addedTodayLabel.AutoSize = true;
            this.addedTodayLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addedTodayLabel.Location = new System.Drawing.Point(525, 63);
            this.addedTodayLabel.Name = "addedTodayLabel";
            this.addedTodayLabel.Size = new System.Drawing.Size(66, 21);
            this.addedTodayLabel.TabIndex = 6;
            this.addedTodayLabel.Text = "Added";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(519, 51);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(200, 1);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(585, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Today";
            // 
            // generalGroupsValue
            // 
            this.generalGroupsValue.AutoSize = true;
            this.generalGroupsValue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalGroupsValue.Location = new System.Drawing.Point(391, 102);
            this.generalGroupsValue.Name = "generalGroupsValue";
            this.generalGroupsValue.Size = new System.Drawing.Size(28, 22);
            this.generalGroupsValue.TabIndex = 3;
            this.generalGroupsValue.Text = "xx";
            // 
            // generalStudentsValue
            // 
            this.generalStudentsValue.AutoSize = true;
            this.generalStudentsValue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalStudentsValue.Location = new System.Drawing.Point(391, 47);
            this.generalStudentsValue.Name = "generalStudentsValue";
            this.generalStudentsValue.Size = new System.Drawing.Size(28, 22);
            this.generalStudentsValue.TabIndex = 2;
            this.generalStudentsValue.Text = "xx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Groups in general :";
            // 
            // generalStudentsLabel
            // 
            this.generalStudentsLabel.AutoSize = true;
            this.generalStudentsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalStudentsLabel.Location = new System.Drawing.Point(190, 47);
            this.generalStudentsLabel.Name = "generalStudentsLabel";
            this.generalStudentsLabel.Size = new System.Drawing.Size(195, 22);
            this.generalStudentsLabel.TabIndex = 0;
            this.generalStudentsLabel.Text = "Students in general :";
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logPanel.Controls.Add(this.textBox1);
            this.logPanel.Controls.Add(this.logTextBox);
            this.logPanel.Location = new System.Drawing.Point(23, -3);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(750, 473);
            this.logPanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(16, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 108);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "LOG";
            // 
            // logTextBox
            // 
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTextBox.Location = new System.Drawing.Point(45, 0);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(693, 470);
            this.logTextBox.TabIndex = 0;
            // 
            // logContainerPanel
            // 
            this.logContainerPanel.Controls.Add(this.collapsedButton);
            this.logContainerPanel.Controls.Add(this.logPanel);
            this.logContainerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logContainerPanel.Location = new System.Drawing.Point(704, 177);
            this.logContainerPanel.MaximumSize = new System.Drawing.Size(761, 470);
            this.logContainerPanel.MinimumSize = new System.Drawing.Size(69, 470);
            this.logContainerPanel.Name = "logContainerPanel";
            this.logContainerPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logContainerPanel.Size = new System.Drawing.Size(69, 470);
            this.logContainerPanel.TabIndex = 5;
            this.logContainerPanel.Tag = false;
            // 
            // collapsedButton
            // 
            this.collapsedButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.collapsedButton.FlatAppearance.BorderSize = 0;
            this.collapsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedButton.Image = global::CitrusDB.Properties.Resources.left;
            this.collapsedButton.Location = new System.Drawing.Point(0, 211);
            this.collapsedButton.Name = "collapsedButton";
            this.collapsedButton.Size = new System.Drawing.Size(34, 34);
            this.collapsedButton.TabIndex = 29;
            this.collapsedButton.UseVisualStyleBackColor = false;
            this.collapsedButton.Click += new System.EventHandler(this.collapsedButton_Click);
            // 
            // chartContainerPanel
            // 
            this.chartContainerPanel.Controls.Add(this.chart);
            this.chartContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartContainerPanel.Location = new System.Drawing.Point(0, 177);
            this.chartContainerPanel.Name = "chartContainerPanel";
            this.chartContainerPanel.Size = new System.Drawing.Size(704, 473);
            this.chartContainerPanel.TabIndex = 6;
            // 
            // pictureBoxLoadingAnimation
            // 
            this.pictureBoxLoadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingAnimation.Image")));
            this.pictureBoxLoadingAnimation.Location = new System.Drawing.Point(-22, -84);
            this.pictureBoxLoadingAnimation.Name = "pictureBoxLoadingAnimation";
            this.pictureBoxLoadingAnimation.Size = new System.Drawing.Size(229, 335);
            this.pictureBoxLoadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoadingAnimation.TabIndex = 14;
            this.pictureBoxLoadingAnimation.TabStop = false;
            // 
            // StatisticBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.chartContainerPanel);
            this.Controls.Add(this.logContainerPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StatisticBoard";
            this.Size = new System.Drawing.Size(928, 650);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.logContainerPanel.ResumeLayout(false);
            this.chartContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel logPanel;
        private UsersElements.CirclusButton collapsedButton;
        private System.Windows.Forms.Panel logContainerPanel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label generalGroupsValue;
        private System.Windows.Forms.Label generalStudentsValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label generalStudentsLabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deletedTodatValue;
        private System.Windows.Forms.Label updatedTodayValue;
        private System.Windows.Forms.Label addedTodayValue;
        private System.Windows.Forms.Label deletedTodayLabel;
        private System.Windows.Forms.Label updatedTodayLabel;
        private System.Windows.Forms.Label addedTodayLabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel chartContainerPanel;
        private System.Windows.Forms.PictureBox pictureBoxLoadingAnimation;
    }
}
