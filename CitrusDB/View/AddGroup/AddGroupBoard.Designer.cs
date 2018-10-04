namespace CitrusDB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAddGroupSpace = new System.Windows.Forms.Panel();
            this.addedStudentsDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentStudentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelAddGroupSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedStudentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddGroupSpace
            // 
            this.panelAddGroupSpace.Controls.Add(this.addedStudentsDataGrid);
            this.panelAddGroupSpace.Controls.Add(this.label1);
            this.panelAddGroupSpace.Controls.Add(this.pictureBox1);
            this.panelAddGroupSpace.Controls.Add(this.label3);
            this.panelAddGroupSpace.Controls.Add(this.textBox1);
            this.panelAddGroupSpace.Controls.Add(this.label2);
            this.panelAddGroupSpace.Location = new System.Drawing.Point(0, 0);
            this.panelAddGroupSpace.Name = "panelAddGroupSpace";
            this.panelAddGroupSpace.Size = new System.Drawing.Size(292, 598);
            this.panelAddGroupSpace.TabIndex = 0;
            // 
            // addedStudentsDataGrid
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addedStudentsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.addedStudentsDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.addedStudentsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addedStudentsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addedStudentsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.addedStudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedStudentsDataGrid.DoubleBuffered = true;
            this.addedStudentsDataGrid.EnableHeadersVisualStyles = false;
            this.addedStudentsDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.addedStudentsDataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.addedStudentsDataGrid.Location = new System.Drawing.Point(0, 186);
            this.addedStudentsDataGrid.Name = "addedStudentsDataGrid";
            this.addedStudentsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.addedStudentsDataGrid.RowTemplate.Height = 24;
            this.addedStudentsDataGrid.Size = new System.Drawing.Size(292, 409);
            this.addedStudentsDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(148, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 144);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Students:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of group:";
            // 
            // currentStudentFlowPanel
            // 
            this.currentStudentFlowPanel.AutoScroll = true;
            this.currentStudentFlowPanel.Location = new System.Drawing.Point(307, 0);
            this.currentStudentFlowPanel.Name = "currentStudentFlowPanel";
            this.currentStudentFlowPanel.Size = new System.Drawing.Size(421, 598);
            this.currentStudentFlowPanel.TabIndex = 1;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(294, -4);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(17, 598);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // AddGroupBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.currentStudentFlowPanel);
            this.Controls.Add(this.panelAddGroupSpace);
            this.Name = "AddGroupBoard";
            this.Size = new System.Drawing.Size(917, 598);
            this.Load += new System.EventHandler(this.AddGroupBoard_Load);
            this.panelAddGroupSpace.ResumeLayout(false);
            this.panelAddGroupSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedStudentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddGroupSpace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel currentStudentFlowPanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid addedStudentsDataGrid;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}
