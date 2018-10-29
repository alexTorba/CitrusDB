using CitrusDB.View.UsersElements;

namespace CitrusDB.View.AddStudent
{
    partial class AddStudentBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentBoard));
            this.firstNameTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.firstNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lastNameTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.middleNameTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lastNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.middleNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.growsComboBox = new System.Windows.Forms.ComboBox();
            this.weightComboBox = new System.Windows.Forms.ComboBox();
            this.growsLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.weightLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateOfBirthLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.citizenshipTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.citizenshipLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.knowledgeOfLanguageLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.knowledgeOfLanguageTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.flowLayoutPanelAddBoard = new System.Windows.Forms.FlowLayoutPanel();
            this.swingPanel = new System.Windows.Forms.Panel();
            this.collapsedButton = new CitrusDB.View.UsersElements.CirclusButton();
            this.generateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.photo1Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.photo2Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBoxSecondPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirstPhoto = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchGroupTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelAddBoard.SuspendLayout();
            this.swingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstPhoto)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.firstNameTextbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextbox.Location = new System.Drawing.Point(28, 62);
            this.firstNameTextbox.Multiline = true;
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(148, 23);
            this.firstNameTextbox.TabIndex = 0;
            this.firstNameTextbox.Tag = "firstNameLabel";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(28, 39);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 22);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.lastNameTextbox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lastNameTextbox.Location = new System.Drawing.Point(207, 62);
            this.lastNameTextbox.Multiline = true;
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(148, 23);
            this.lastNameTextbox.TabIndex = 2;
            this.lastNameTextbox.Tag = "lastNameLabel";
            // 
            // middleNameTextbox
            // 
            this.middleNameTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.middleNameTextbox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.middleNameTextbox.Location = new System.Drawing.Point(28, 137);
            this.middleNameTextbox.Multiline = true;
            this.middleNameTextbox.Name = "middleNameTextbox";
            this.middleNameTextbox.Size = new System.Drawing.Size(148, 23);
            this.middleNameTextbox.TabIndex = 3;
            this.middleNameTextbox.Tag = "middleNameLabel";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lastNameLabel.Location = new System.Drawing.Point(207, 39);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(110, 22);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Tag = "";
            this.lastNameLabel.Text = "Last name:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.middleNameLabel.Location = new System.Drawing.Point(28, 114);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(135, 22);
            this.middleNameLabel.TabIndex = 5;
            this.middleNameLabel.Text = "Middle name:";
            // 
            // growsComboBox
            // 
            this.growsComboBox.DropDownHeight = 180;
            this.growsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.growsComboBox.FormattingEnabled = true;
            this.growsComboBox.IntegralHeight = false;
            this.growsComboBox.ItemHeight = 20;
            this.growsComboBox.Items.AddRange(new object[] {
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229"});
            this.growsComboBox.Location = new System.Drawing.Point(28, 216);
            this.growsComboBox.Name = "growsComboBox";
            this.growsComboBox.Size = new System.Drawing.Size(121, 28);
            this.growsComboBox.TabIndex = 9;
            this.growsComboBox.Tag = "growsLabel";
            // 
            // weightComboBox
            // 
            this.weightComboBox.DropDownHeight = 180;
            this.weightComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.weightComboBox.FormattingEnabled = true;
            this.weightComboBox.IntegralHeight = false;
            this.weightComboBox.Items.AddRange(new object[] {
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179"});
            this.weightComboBox.Location = new System.Drawing.Point(207, 216);
            this.weightComboBox.Name = "weightComboBox";
            this.weightComboBox.Size = new System.Drawing.Size(121, 28);
            this.weightComboBox.TabIndex = 10;
            this.weightComboBox.Tag = "weightLabel";
            // 
            // growsLabel
            // 
            this.growsLabel.AutoSize = true;
            this.growsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.growsLabel.Location = new System.Drawing.Point(28, 193);
            this.growsLabel.Name = "growsLabel";
            this.growsLabel.Size = new System.Drawing.Size(85, 22);
            this.growsLabel.TabIndex = 11;
            this.growsLabel.Text = "Growth:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.weightLabel.Location = new System.Drawing.Point(207, 193);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(79, 22);
            this.weightLabel.TabIndex = 12;
            this.weightLabel.Text = "Weight:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(42, 395);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(130, 22);
            this.dateOfBirthLabel.TabIndex = 14;
            this.dateOfBirthLabel.Text = "Date of birth:";
            // 
            // citizenshipTextbox
            // 
            this.citizenshipTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.citizenshipTextbox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.citizenshipTextbox.Location = new System.Drawing.Point(207, 137);
            this.citizenshipTextbox.Multiline = true;
            this.citizenshipTextbox.Name = "citizenshipTextbox";
            this.citizenshipTextbox.Size = new System.Drawing.Size(148, 23);
            this.citizenshipTextbox.TabIndex = 15;
            this.citizenshipTextbox.Tag = "citizenshipLabel";
            // 
            // citizenshipLabel
            // 
            this.citizenshipLabel.AutoSize = true;
            this.citizenshipLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.citizenshipLabel.Location = new System.Drawing.Point(207, 114);
            this.citizenshipLabel.Name = "citizenshipLabel";
            this.citizenshipLabel.Size = new System.Drawing.Size(110, 22);
            this.citizenshipLabel.TabIndex = 16;
            this.citizenshipLabel.Text = "Сitizenship:";
            // 
            // knowledgeOfLanguageLabel
            // 
            this.knowledgeOfLanguageLabel.AutoSize = true;
            this.knowledgeOfLanguageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.knowledgeOfLanguageLabel.Location = new System.Drawing.Point(28, 278);
            this.knowledgeOfLanguageLabel.Name = "knowledgeOfLanguageLabel";
            this.knowledgeOfLanguageLabel.Size = new System.Drawing.Size(119, 22);
            this.knowledgeOfLanguageLabel.TabIndex = 18;
            this.knowledgeOfLanguageLabel.Text = "Languages:";
            // 
            // knowledgeOfLanguageTextbox
            // 
            this.knowledgeOfLanguageTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.knowledgeOfLanguageTextbox.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.knowledgeOfLanguageTextbox.Location = new System.Drawing.Point(28, 301);
            this.knowledgeOfLanguageTextbox.Multiline = true;
            this.knowledgeOfLanguageTextbox.Name = "knowledgeOfLanguageTextbox";
            this.knowledgeOfLanguageTextbox.Size = new System.Drawing.Size(267, 47);
            this.knowledgeOfLanguageTextbox.TabIndex = 17;
            this.knowledgeOfLanguageTextbox.Tag = "knowledgeOfLanguageLabel";
            // 
            // flowLayoutPanelAddBoard
            // 
            this.flowLayoutPanelAddBoard.Controls.Add(this.swingPanel);
            this.flowLayoutPanelAddBoard.Controls.Add(this.saveButton);
            this.flowLayoutPanelAddBoard.Controls.Add(this.clearButton);
            this.flowLayoutPanelAddBoard.Location = new System.Drawing.Point(10, 524);
            this.flowLayoutPanelAddBoard.Name = "flowLayoutPanelAddBoard";
            this.flowLayoutPanelAddBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelAddBoard.Size = new System.Drawing.Size(359, 43);
            this.flowLayoutPanelAddBoard.TabIndex = 19;
            // 
            // swingPanel
            // 
            this.swingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.swingPanel.Controls.Add(this.collapsedButton);
            this.swingPanel.Controls.Add(this.generateButton);
            this.swingPanel.Location = new System.Drawing.Point(3, 3);
            this.swingPanel.MaximumSize = new System.Drawing.Size(154, 43);
            this.swingPanel.MinimumSize = new System.Drawing.Size(47, 43);
            this.swingPanel.Name = "swingPanel";
            this.swingPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.swingPanel.Size = new System.Drawing.Size(47, 43);
            this.swingPanel.TabIndex = 20;
            this.swingPanel.Tag = false;
            // 
            // collapsedButton
            // 
            this.collapsedButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.collapsedButton.FlatAppearance.BorderSize = 0;
            this.collapsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedButton.Image = global::CitrusDB.Properties.Resources.right;
            this.collapsedButton.Location = new System.Drawing.Point(6, 3);
            this.collapsedButton.Name = "collapsedButton";
            this.collapsedButton.Size = new System.Drawing.Size(35, 34);
            this.collapsedButton.TabIndex = 28;
            this.collapsedButton.UseVisualStyleBackColor = false;
            this.collapsedButton.Click += new System.EventHandler(this.swingButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.Firebrick;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(47, 0);
            this.generateButton.Name = "generateButton";
            this.generateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generateButton.Size = new System.Drawing.Size(107, 43);
            this.generateButton.TabIndex = 21;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(56, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 43);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Teal;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(151, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 43);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(191, 434);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.yearNumericUpDown.TabIndex = 20;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(46, 434);
            this.daysNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.daysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(41, 22);
            this.daysNumericUpDown.TabIndex = 21;
            this.daysNumericUpDown.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(120, 434);
            this.monthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(43, 22);
            this.monthNumericUpDown.TabIndex = 22;
            this.monthNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 436);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(19, 20);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "d";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(95, 436);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(22, 20);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "m";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(171, 434);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(17, 20);
            this.bunifuCustomLabel3.TabIndex = 25;
            this.bunifuCustomLabel3.Text = "y";
            // 
            // photo1Label
            // 
            this.photo1Label.AutoSize = true;
            this.photo1Label.Enabled = false;
            this.photo1Label.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.photo1Label.Location = new System.Drawing.Point(438, 305);
            this.photo1Label.Name = "photo1Label";
            this.photo1Label.Size = new System.Drawing.Size(70, 21);
            this.photo1Label.TabIndex = 26;
            this.photo1Label.Text = "photo1";
            // 
            // photo2Label
            // 
            this.photo2Label.AutoSize = true;
            this.photo2Label.Enabled = false;
            this.photo2Label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photo2Label.Location = new System.Drawing.Point(438, 100);
            this.photo2Label.Name = "photo2Label";
            this.photo2Label.Size = new System.Drawing.Size(70, 21);
            this.photo2Label.TabIndex = 27;
            this.photo2Label.Text = "photo2";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupsFlowPanel
            // 
            this.groupsFlowPanel.AutoScroll = true;
            this.groupsFlowPanel.BackColor = System.Drawing.Color.LightGray;
            this.groupsFlowPanel.Location = new System.Drawing.Point(594, 88);
            this.groupsFlowPanel.Name = "groupsFlowPanel";
            this.groupsFlowPanel.Size = new System.Drawing.Size(320, 505);
            this.groupsFlowPanel.TabIndex = 28;
            // 
            // progressBar
            // 
            this.progressBar.animated = true;
            this.progressBar.animationIterval = 1;
            this.progressBar.animationSpeed = 25;
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.progressBar.LabelVisible = true;
            this.progressBar.LineProgressThickness = 8;
            this.progressBar.LineThickness = 5;
            this.progressBar.Location = new System.Drawing.Point(395, 430);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(34)))));
            this.progressBar.Size = new System.Drawing.Size(134, 134);
            this.progressBar.TabIndex = 8;
            this.progressBar.Value = 0;
            this.progressBar.ProgressChanged += new System.EventHandler(this.progressBar_ProgressChanged);
            // 
            // pictureBoxSecondPhoto
            // 
            this.pictureBoxSecondPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSecondPhoto.Location = new System.Drawing.Point(392, 32);
            this.pictureBoxSecondPhoto.Name = "pictureBoxSecondPhoto";
            this.pictureBoxSecondPhoto.Size = new System.Drawing.Size(145, 158);
            this.pictureBoxSecondPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSecondPhoto.TabIndex = 7;
            this.pictureBoxSecondPhoto.TabStop = false;
            this.pictureBoxSecondPhoto.Click += new System.EventHandler(this.pictureBoxSecondPhoto_Click);
            // 
            // pictureBoxFirstPhoto
            // 
            this.pictureBoxFirstPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFirstPhoto.Location = new System.Drawing.Point(392, 233);
            this.pictureBoxFirstPhoto.Name = "pictureBoxFirstPhoto";
            this.pictureBoxFirstPhoto.Size = new System.Drawing.Size(145, 158);
            this.pictureBoxFirstPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFirstPhoto.TabIndex = 6;
            this.pictureBoxFirstPhoto.TabStop = false;
            this.pictureBoxFirstPhoto.Click += new System.EventHandler(this.pictureBoxFirstPhoto_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 15;
            this.bunifuSeparator1.Location = new System.Drawing.Point(579, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(15, 602);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(5, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 30);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Groups";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.LightGray;
            this.searchPanel.Controls.Add(this.searchGroupTextBox);
            this.searchPanel.Controls.Add(this.textBox1);
            this.searchPanel.Location = new System.Drawing.Point(594, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(320, 89);
            this.searchPanel.TabIndex = 31;
            // 
            // searchGroupTextBox
            // 
            this.searchGroupTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchGroupTextBox.Location = new System.Drawing.Point(6, 51);
            this.searchGroupTextBox.Multiline = true;
            this.searchGroupTextBox.Name = "searchGroupTextBox";
            this.searchGroupTextBox.Size = new System.Drawing.Size(205, 31);
            this.searchGroupTextBox.TabIndex = 31;
            this.searchGroupTextBox.Text = "Search..";
            // 
            // AddStudentBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupsFlowPanel);
            this.Controls.Add(this.photo2Label);
            this.Controls.Add(this.photo1Label);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.monthNumericUpDown);
            this.Controls.Add(this.daysNumericUpDown);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.flowLayoutPanelAddBoard);
            this.Controls.Add(this.knowledgeOfLanguageLabel);
            this.Controls.Add(this.knowledgeOfLanguageTextbox);
            this.Controls.Add(this.citizenshipLabel);
            this.Controls.Add(this.citizenshipTextbox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.growsLabel);
            this.Controls.Add(this.weightComboBox);
            this.Controls.Add(this.growsComboBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxSecondPhoto);
            this.Controls.Add(this.pictureBoxFirstPhoto);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Name = "AddStudentBoard";
            this.Size = new System.Drawing.Size(914, 593);
            this.Load += new System.EventHandler(this.AddStudentBoard_Load);
            this.flowLayoutPanelAddBoard.ResumeLayout(false);
            this.swingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstPhoto)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox firstNameTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel firstNameLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox lastNameTextbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox middleNameTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel lastNameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel middleNameLabel;
        private System.Windows.Forms.PictureBox pictureBoxFirstPhoto;
        private System.Windows.Forms.PictureBox pictureBoxSecondPhoto;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar;
        private System.Windows.Forms.ComboBox growsComboBox;
        private System.Windows.Forms.ComboBox weightComboBox;
        private Bunifu.Framework.UI.BunifuCustomLabel growsLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel weightLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel dateOfBirthLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox citizenshipTextbox;
        private Bunifu.Framework.UI.BunifuCustomLabel citizenshipLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel knowledgeOfLanguageLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox knowledgeOfLanguageTextbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddBoard;
        private System.Windows.Forms.Panel swingPanel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel photo1Label;
        private Bunifu.Framework.UI.BunifuCustomLabel photo2Label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private CirclusButton collapsedButton;
        private System.Windows.Forms.FlowLayoutPanel groupsFlowPanel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchGroupTextBox;
    }
}
