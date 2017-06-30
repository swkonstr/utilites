namespace NameSpace_1
{
    partial class MainForm1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.buttonRandomCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelRandom = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBoxNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            this.labelPasswordLenght = new System.Windows.Forms.Label();
            this.numericUpDownPassLenght = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxPass = new System.Windows.Forms.CheckedListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMetric = new System.Windows.Forms.ComboBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.labelTimer1 = new System.Windows.Forms.Label();
            this.ButtionTimer_1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassLenght)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.блокнотToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertDateToolStripMenuItem,
            this.InsertTimeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.блокнотToolStripMenuItem.Text = "Options";
            // 
            // InsertDateToolStripMenuItem
            // 
            this.InsertDateToolStripMenuItem.Name = "InsertDateToolStripMenuItem";
            this.InsertDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.InsertDateToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.InsertDateToolStripMenuItem.Text = "Вставить дату";
            this.InsertDateToolStripMenuItem.Click += new System.EventHandler(this.InsertDateToolStripMenuItem_Click);
            // 
            // InsertTimeToolStripMenuItem
            // 
            this.InsertTimeToolStripMenuItem.Name = "InsertTimeToolStripMenuItem";
            this.InsertTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.InsertTimeToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.InsertTimeToolStripMenuItem.Text = "Вставить время";
            this.InsertTimeToolStripMenuItem.Click += new System.EventHandler(this.InsertTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 307);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelCount);
            this.tabPage1.Controls.Add(this.buttonReset);
            this.tabPage1.Controls.Add(this.buttonMinus);
            this.tabPage1.Controls.Add(this.buttonPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(526, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Counter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(56, 97);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "0";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(151, 92);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(59, 123);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(59, 62);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxRandom);
            this.tabPage2.Controls.Add(this.buttonRandomCopy);
            this.tabPage2.Controls.Add(this.buttonClear);
            this.tabPage2.Controls.Add(this.textBoxRandom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.labelRandom);
            this.tabPage2.Controls.Add(this.buttonRandom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(32, 186);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(106, 17);
            this.checkBoxRandom.TabIndex = 9;
            this.checkBoxRandom.Text = "без повторений";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            // 
            // buttonRandomCopy
            // 
            this.buttonRandomCopy.Location = new System.Drawing.Point(32, 145);
            this.buttonRandomCopy.Name = "buttonRandomCopy";
            this.buttonRandomCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomCopy.TabIndex = 8;
            this.buttonRandomCopy.Text = "Копировать";
            this.buttonRandomCopy.UseVisualStyleBackColor = true;
            this.buttonRandomCopy.Click += new System.EventHandler(this.buttonRandomCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(32, 106);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(151, 95);
            this.textBoxRandom.Multiline = true;
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRandom.Size = new System.Drawing.Size(77, 108);
            this.textBoxRandom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "От";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(62, 69);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(62, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(158, 71);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(13, 13);
            this.labelRandom.TabIndex = 1;
            this.labelRandom.Text = "0";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(131, 18);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(97, 23);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Генерировать";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBoxNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(526, 281);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notepad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxNotepad
            // 
            this.richTextBoxNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNotepad.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxNotepad.Name = "richTextBoxNotepad";
            this.richTextBoxNotepad.Size = new System.Drawing.Size(520, 275);
            this.richTextBoxNotepad.TabIndex = 0;
            this.richTextBoxNotepad.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxPass);
            this.tabPage4.Controls.Add(this.buttonGeneratePassword);
            this.tabPage4.Controls.Add(this.labelPasswordLenght);
            this.tabPage4.Controls.Add(this.numericUpDownPassLenght);
            this.tabPage4.Controls.Add(this.checkedListBoxPass);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(526, 281);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pass";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(11, 139);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(257, 20);
            this.textBoxPass.TabIndex = 4;
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.Location = new System.Drawing.Point(67, 103);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(118, 23);
            this.buttonGeneratePassword.TabIndex = 3;
            this.buttonGeneratePassword.Text = "Создать пароль";
            this.buttonGeneratePassword.UseVisualStyleBackColor = true;
            this.buttonGeneratePassword.Click += new System.EventHandler(this.buttonGeneratePassword_Click);
            // 
            // labelPasswordLenght
            // 
            this.labelPasswordLenght.AutoSize = true;
            this.labelPasswordLenght.Location = new System.Drawing.Point(8, 79);
            this.labelPasswordLenght.Name = "labelPasswordLenght";
            this.labelPasswordLenght.Size = new System.Drawing.Size(79, 13);
            this.labelPasswordLenght.TabIndex = 2;
            this.labelPasswordLenght.Text = "Длина пароля";
            // 
            // numericUpDownPassLenght
            // 
            this.numericUpDownPassLenght.Location = new System.Drawing.Point(148, 77);
            this.numericUpDownPassLenght.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPassLenght.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownPassLenght.Name = "numericUpDownPassLenght";
            this.numericUpDownPassLenght.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPassLenght.TabIndex = 1;
            this.numericUpDownPassLenght.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // checkedListBoxPass
            // 
            this.checkedListBoxPass.CheckOnClick = true;
            this.checkedListBoxPass.FormattingEnabled = true;
            this.checkedListBoxPass.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы"});
            this.checkedListBoxPass.Location = new System.Drawing.Point(9, 7);
            this.checkedListBoxPass.Name = "checkedListBoxPass";
            this.checkedListBoxPass.Size = new System.Drawing.Size(259, 64);
            this.checkedListBoxPass.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.comboBoxMetric);
            this.tabPage5.Controls.Add(this.buttonSwap);
            this.tabPage5.Controls.Add(this.textBoxTo);
            this.tabPage5.Controls.Add(this.textBoxFrom);
            this.tabPage5.Controls.Add(this.buttonConvert);
            this.tabPage5.Controls.Add(this.comboBoxTo);
            this.tabPage5.Controls.Add(this.comboBoxFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(526, 281);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Convert";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Simple offline desktop application";
            // 
            // comboBoxMetric
            // 
            this.comboBoxMetric.FormattingEnabled = true;
            this.comboBoxMetric.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.comboBoxMetric.Location = new System.Drawing.Point(229, 36);
            this.comboBoxMetric.Name = "comboBoxMetric";
            this.comboBoxMetric.Size = new System.Drawing.Size(86, 21);
            this.comboBoxMetric.TabIndex = 6;
            this.comboBoxMetric.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetric_SelectedIndexChanged);
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(230, 78);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(86, 23);
            this.buttonSwap.TabIndex = 5;
            this.buttonSwap.Text = "<->";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(340, 132);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ReadOnly = true;
            this.textBoxTo.Size = new System.Drawing.Size(96, 20);
            this.textBoxTo.TabIndex = 4;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(113, 132);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(93, 20);
            this.textBoxFrom.TabIndex = 3;
            this.textBoxFrom.Text = "1";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(229, 130);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(86, 22);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.comboBoxTo.Location = new System.Drawing.Point(341, 80);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(96, 21);
            this.comboBoxTo.TabIndex = 1;
            this.comboBoxTo.Text = "mm";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.comboBoxFrom.Location = new System.Drawing.Point(114, 80);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(94, 21);
            this.comboBoxFrom.TabIndex = 0;
            this.comboBoxFrom.Text = "mm";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.labelTimer1);
            this.tabPage6.Controls.Add(this.ButtionTimer_1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(526, 281);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Timer";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // labelTimer1
            // 
            this.labelTimer1.AutoSize = true;
            this.labelTimer1.Location = new System.Drawing.Point(23, 24);
            this.labelTimer1.Name = "labelTimer1";
            this.labelTimer1.Size = new System.Drawing.Size(35, 13);
            this.labelTimer1.TabIndex = 1;
            this.labelTimer1.Text = "label1";
            // 
            // ButtionTimer_1
            // 
            this.ButtionTimer_1.Location = new System.Drawing.Point(200, 43);
            this.ButtionTimer_1.Name = "ButtionTimer_1";
            this.ButtionTimer_1.Size = new System.Drawing.Size(75, 23);
            this.ButtionTimer_1.TabIndex = 0;
            this.ButtionTimer_1.Text = "TestTimer";
            this.ButtionTimer_1.UseVisualStyleBackColor = true;
            this.ButtionTimer_1.Click += new System.EventHandler(this.ButtionTimer_1_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(526, 281);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Canvas";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 331);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm1";
            this.Text = "MyUtilites";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassLenght)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRandomCopy;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertTimeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBoxNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonGeneratePassword;
        private System.Windows.Forms.Label labelPasswordLenght;
        private System.Windows.Forms.NumericUpDown numericUpDownPassLenght;
        private System.Windows.Forms.CheckedListBox checkedListBoxPass;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.ComboBox comboBoxMetric;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label labelTimer1;
        private System.Windows.Forms.Button ButtionTimer_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage7;
    }
}

