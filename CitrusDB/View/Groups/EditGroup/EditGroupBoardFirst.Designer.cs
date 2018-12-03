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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.editButton = new System.Windows.Forms.Button();
            this.optionalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionalPanel
            // 
            this.optionalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.optionalPanel.Controls.Add(this.editButton);
            this.optionalPanel.Controls.Add(this.textBox1);
            this.optionalPanel.Controls.Add(this.label1);
            this.optionalPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.optionalPanel.Location = new System.Drawing.Point(605, 0);
            this.optionalPanel.Name = "optionalPanel";
            this.optionalPanel.Size = new System.Drawing.Size(323, 644);
            this.optionalPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // groupFlowPanel
            // 
            this.groupFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.groupFlowPanel.Name = "groupFlowPanel";
            this.groupFlowPanel.Size = new System.Drawing.Size(605, 644);
            this.groupFlowPanel.TabIndex = 1;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Teal;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(84, 574);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(162, 39);
            this.editButton.TabIndex = 23;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // EditGroupBoardFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel groupFlowPanel;
        private System.Windows.Forms.Button editButton;
    }
}
