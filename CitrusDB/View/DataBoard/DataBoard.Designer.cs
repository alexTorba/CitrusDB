using CitrusDB.Model.Entity;
using CitrusDB.View.UsersElements;

namespace CitrusDB.View.DataBoard
{
    partial class DataBoard
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 =
                new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 =
                new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buttonTables = new System.Windows.Forms.Button();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.flowGroupOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTables = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonGroup = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.generPanelOptions = new System.Windows.Forms.Panel();
            this.collapsedButton = new CitrusDB.View.UsersElements.CirclusButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid)).BeginInit();
            this.panelGroup.SuspendLayout();
            this.flowGroupOptions.SuspendLayout();
            this.panelTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.flowPanelSearchSettings.SuspendLayout();
            this.panelWhere.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.generPanelOptions.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))),
                ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.DoubleBuffered = false;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.Location = new System.Drawing.Point(26, 49);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersWidth = 4;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(535, 580);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContextMenuStripNeeded +=
                new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(
                    this.dataGrid_CellContextMenuStripNeeded);
            this.dataGrid.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            this.dataGrid.ColumnHeaderMouseClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_ColumnHeaderMouseClick);
            // 
            // buttonTables
            // 
            this.buttonTables.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))),
                ((int) (((byte) (44)))), ((int) (((byte) (44)))));
            this.buttonTables.FlatAppearance.BorderSize = 0;
            this.buttonTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTables.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonTables.ForeColor = System.Drawing.Color.White;
            this.buttonTables.Location = new System.Drawing.Point(0, 0);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(228, 58);
            this.buttonTables.TabIndex = 0;
            this.buttonTables.Text = "Tables :";
            this.buttonTables.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonTables.UseVisualStyleBackColor = false;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // panelGroup
            // 
            this.panelGroup.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (31)))),
                ((int) (((byte) (31)))));
            this.panelGroup.Controls.Add(this.flowGroupOptions);
            this.panelGroup.Location = new System.Drawing.Point(33, 0);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(234, 649);
            this.panelGroup.TabIndex = 5;
            // 
            // flowGroupOptions
            // 
            this.flowGroupOptions.Controls.Add(this.panelTables);
            this.flowGroupOptions.Controls.Add(this.flowPanelSearchSettings);
            this.flowGroupOptions.Location = new System.Drawing.Point(3, 1);
            this.flowGroupOptions.Name = "flowGroupOptions";
            this.flowGroupOptions.Size = new System.Drawing.Size(231, 526);
            this.flowGroupOptions.TabIndex = 0;
            // 
            // panelTables
            // 
            this.panelTables.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.panelTables.Controls.Add(this.pictureBox2);
            this.panelTables.Controls.Add(this.pictureBox1);
            this.panelTables.Controls.Add(this.radioButtonGroup);
            this.panelTables.Controls.Add(this.buttonTables);
            this.panelTables.Controls.Add(this.radioButtonStudent);
            this.panelTables.Controls.Add(this.label2);
            this.panelTables.Controls.Add(this.label1);
            this.panelTables.Location = new System.Drawing.Point(3, 3);
            this.panelTables.MaximumSize = new System.Drawing.Size(228, 152);
            this.panelTables.MinimumSize = new System.Drawing.Size(228, 54);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(228, 54);
            this.panelTables.TabIndex = 6;
            this.panelTables.Tag = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CitrusDB.Properties.Resources.icons8_Sphere_15px;
            this.pictureBox2.Location = new System.Drawing.Point(35, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 17);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CitrusDB.Properties.Resources.icons8_Sphere_15px;
            this.pictureBox1.Location = new System.Drawing.Point(35, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 17);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.AutoSize = true;
            this.radioButtonGroup.Location = new System.Drawing.Point(197, 119);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(14, 13);
            this.radioButtonGroup.TabIndex = 9;
            this.radioButtonGroup.TabStop = true;
            this.radioButtonGroup.UseVisualStyleBackColor = true;
            this.radioButtonGroup.CheckedChanged += new System.EventHandler(this.radioButtonGroup_CheckedChanged);
            this.radioButtonGroup.MouseClick +=
                new System.Windows.Forms.MouseEventHandler(this.radioButtonGroup_MouseClick);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(197, 76);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStudent.TabIndex = 7;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            this.radioButtonStudent.MouseClick +=
                new System.Windows.Forms.MouseEventHandler(this.radioButtonStudent_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Groups :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Students :";
            // 
            // flowPanelSearchSettings
            // 
            this.flowPanelSearchSettings.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.flowPanelSearchSettings.Controls.Add(this.searchSettingsButton);
            this.flowPanelSearchSettings.Controls.Add(this.panelWhere);
            this.flowPanelSearchSettings.Controls.Add(this.panelOrderBy);
            this.flowPanelSearchSettings.Location = new System.Drawing.Point(3, 63);
            this.flowPanelSearchSettings.MaximumSize = new System.Drawing.Size(228, 329);
            this.flowPanelSearchSettings.MinimumSize = new System.Drawing.Size(228, 64);
            this.flowPanelSearchSettings.Name = "flowPanelSearchSettings";
            this.flowPanelSearchSettings.Size = new System.Drawing.Size(228, 64);
            this.flowPanelSearchSettings.TabIndex = 7;
            this.flowPanelSearchSettings.Tag = false;
            // 
            // searchSettingsButton
            // 
            this.searchSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))),
                ((int) (((byte) (44)))), ((int) (((byte) (44)))));
            this.searchSettingsButton.FlatAppearance.BorderSize = 0;
            this.searchSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchSettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter :";
            // 
            // buttonWhere
            // 
            this.buttonWhere.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.buttonWhere.FlatAppearance.BorderSize = 0;
            this.buttonWhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhere.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
            this.radioButtonDescen.Font = new System.Drawing.Font("Century Gothic", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
            this.radioButtonAscend.Font = new System.Drawing.Font("Century Gothic", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
            this.buttonOrderBy.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.buttonOrderBy.FlatAppearance.BorderSize = 0;
            this.buttonOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderBy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonOrderBy.ForeColor = System.Drawing.Color.White;
            this.buttonOrderBy.Location = new System.Drawing.Point(0, 0);
            this.buttonOrderBy.Name = "buttonOrderBy";
            this.buttonOrderBy.Size = new System.Drawing.Size(228, 58);
            this.buttonOrderBy.TabIndex = 2;
            this.buttonOrderBy.Text = "OrderBy";
            this.buttonOrderBy.UseVisualStyleBackColor = false;
            this.buttonOrderBy.Click += new System.EventHandler(this.buttonOrderBy_Click);
            // 
            // generPanelOptions
            // 
            this.generPanelOptions.Controls.Add(this.collapsedButton);
            this.generPanelOptions.Controls.Add(this.panelGroup);
            this.generPanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.generPanelOptions.Location = new System.Drawing.Point(622, 0);
            this.generPanelOptions.MaximumSize = new System.Drawing.Size(267, 0);
            this.generPanelOptions.MinimumSize = new System.Drawing.Size(49, 0);
            this.generPanelOptions.Name = "generPanelOptions";
            this.generPanelOptions.Size = new System.Drawing.Size(267, 530);
            this.generPanelOptions.TabIndex = 6;
            this.generPanelOptions.Tag = true;
            // 
            // collapsedButton
            // 
            this.collapsedButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.collapsedButton.FlatAppearance.BorderSize = 0;
            this.collapsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedButton.Image = global::CitrusDB.Properties.Resources.right;
            this.collapsedButton.Location = new System.Drawing.Point(6, 389);
            this.collapsedButton.Name = "collapsedButton";
            this.collapsedButton.Size = new System.Drawing.Size(43, 45);
            this.collapsedButton.TabIndex = 7;
            this.collapsedButton.UseVisualStyleBackColor = false;
            this.collapsedButton.Click += new System.EventHandler(this.collapsedData_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))),
                ((int) (((byte) (31)))), ((int) (((byte) (31)))));
            this.contextMenuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.infoToolStripMenuItem, this.changeToolStripMenuItem, this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(124, 70);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.searchTextBox.Location = new System.Drawing.Point(26, 15);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(171, 24);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.Text = "Search..";
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // DataBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.generPanelOptions);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Name = "DataBoard";
            this.Size = new System.Drawing.Size(889, 530);
            this.Load += new System.EventHandler(this.DataBoard_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.flowGroupOptions.ResumeLayout(false);
            this.panelTables.ResumeLayout(false);
            this.panelTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.flowPanelSearchSettings.ResumeLayout(false);
            this.panelWhere.ResumeLayout(false);
            this.panelWhere.PerformLayout();
            this.panelOrderBy.ResumeLayout(false);
            this.panelOrderBy.PerformLayout();
            this.generPanelOptions.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private System.Windows.Forms.Button buttonTables;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.FlowLayoutPanel flowGroupOptions;
        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.RadioButton radioButtonGroup;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel generPanelOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowPanelSearchSettings;
        private System.Windows.Forms.Button searchSettingsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelWhere;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonWhere;
        private System.Windows.Forms.Panel panelOrderBy;
        private System.Windows.Forms.RadioButton radioButtonDescen;
        private System.Windows.Forms.RadioButton radioButtonAscend;
        private System.Windows.Forms.Button buttonOrderBy;
        private CitrusDB.View.UsersElements.CirclusButton collapsedButton;
    }
}
