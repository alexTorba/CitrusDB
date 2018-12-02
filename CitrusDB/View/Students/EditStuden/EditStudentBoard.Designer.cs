namespace CitrusDB.View.Students.EditStuden
{
    partial class EditStudentBoard
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
            this.editStudentSecondContainerPanel = new System.Windows.Forms.Panel();
            this.editStudentBoardSecond = new CitrusDB.View.Students.EditStuden.EditStudentBoardSecond();
            this.editStudentBoardFirst = new CitrusDB.View.Students.EditStuden.EditStudentBoardFirst();
            this.editStudentSecondContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editStudentSecondContainerPanel
            // 
            this.editStudentSecondContainerPanel.Controls.Add(this.editStudentBoardSecond);
            this.editStudentSecondContainerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.editStudentSecondContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.editStudentSecondContainerPanel.MaximumSize = new System.Drawing.Size(914, 644);
            this.editStudentSecondContainerPanel.Name = "editStudentSecondContainerPanel";
            this.editStudentSecondContainerPanel.Size = new System.Drawing.Size(0, 644);
            this.editStudentSecondContainerPanel.TabIndex = 0;
            this.editStudentSecondContainerPanel.Tag = false;
            // 
            // editStudentBoardSecond
            // 
            this.editStudentBoardSecond.AutoSize = true;
            this.editStudentBoardSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editStudentBoardSecond.GroupId = 0;
            this.editStudentBoardSecond.Location = new System.Drawing.Point(0, 0);
            this.editStudentBoardSecond.MinimumSize = new System.Drawing.Size(914, 644);
            this.editStudentBoardSecond.Name = "editStudentBoardSecond";
            this.editStudentBoardSecond.ProgressBarValue = 0;
            this.editStudentBoardSecond.Size = new System.Drawing.Size(914, 644);
            this.editStudentBoardSecond.TabIndex = 0;
            // 
            // editStudentBoardFirst
            // 
            this.editStudentBoardFirst.AutoSize = true;
            this.editStudentBoardFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editStudentBoardFirst.EditStudent = null;
            this.editStudentBoardFirst.Location = new System.Drawing.Point(0, 0);
            this.editStudentBoardFirst.Name = "editStudentBoardFirst";
            this.editStudentBoardFirst.Size = new System.Drawing.Size(914, 644);
            this.editStudentBoardFirst.TabIndex = 1;
            // 
            // EditStudentBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editStudentBoardFirst);
            this.Controls.Add(this.editStudentSecondContainerPanel);
            this.Name = "EditStudentBoard";
            this.Size = new System.Drawing.Size(914, 644);
            this.editStudentSecondContainerPanel.ResumeLayout(false);
            this.editStudentSecondContainerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel editStudentSecondContainerPanel;
        public EditStudentBoardSecond editStudentBoardSecond;
        public EditStudentBoardFirst editStudentBoardFirst;
    }
}
