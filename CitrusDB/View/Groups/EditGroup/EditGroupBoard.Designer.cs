namespace CitrusDB.View.Groups.EditGroup
{
    partial class EditGroupBoard
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
            this.editGroupBoardFirst = new CitrusDB.View.Groups.EditGroup.EditGroupBoardFirst();
            this.panelEditGroupBoardSecond = new System.Windows.Forms.Panel();
            this.editGroupBoardSecond = new CitrusDB.View.Groups.EditGroup.EditGroupBoardSecond();
            this.panelEditGroupBoardSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // editGroupBoardFirst
            // 
            this.editGroupBoardFirst.AutoSize = true;
            this.editGroupBoardFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGroupBoardFirst.Location = new System.Drawing.Point(0, 0);
            this.editGroupBoardFirst.Name = "editGroupBoardFirst";
            this.editGroupBoardFirst.Size = new System.Drawing.Size(928, 644);
            this.editGroupBoardFirst.TabIndex = 0;
            // 
            // panelEditGroupBoardSecond
            // 
            this.panelEditGroupBoardSecond.Controls.Add(this.editGroupBoardSecond);
            this.panelEditGroupBoardSecond.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEditGroupBoardSecond.Location = new System.Drawing.Point(0, 0);
            this.panelEditGroupBoardSecond.MaximumSize = new System.Drawing.Size(925, 644);
            this.panelEditGroupBoardSecond.Name = "panelEditGroupBoardSecond";
            this.panelEditGroupBoardSecond.Size = new System.Drawing.Size(0, 644);
            this.panelEditGroupBoardSecond.TabIndex = 1;
            this.panelEditGroupBoardSecond.Tag = false;
            // 
            // editGroupBoardSecond
            // 
            this.editGroupBoardSecond.AutoSize = true;
            this.editGroupBoardSecond.CountOfAddedStudent = "";
            this.editGroupBoardSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGroupBoardSecond.Location = new System.Drawing.Point(0, 0);
            this.editGroupBoardSecond.Name = "editGroupBoardSecond";
            this.editGroupBoardSecond.Size = new System.Drawing.Size(0, 644);
            this.editGroupBoardSecond.TabIndex = 0;
            // 
            // EditGroupBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditGroupBoardSecond);
            this.Controls.Add(this.editGroupBoardFirst);
            this.Name = "EditGroupBoard";
            this.Size = new System.Drawing.Size(928, 644);
            this.panelEditGroupBoardSecond.ResumeLayout(false);
            this.panelEditGroupBoardSecond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public EditGroupBoardFirst editGroupBoardFirst;
        private System.Windows.Forms.Panel panelEditGroupBoardSecond;
        public EditGroupBoardSecond editGroupBoardSecond;
    }
}
