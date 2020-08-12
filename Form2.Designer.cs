namespace EDIFileGenerator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreatePOButton = new System.Windows.Forms.Button();
            this.POOutputLabel = new System.Windows.Forms.Label();
            this.POOutputBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.ITDneeded = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.ITDpercentPicker = new System.Windows.Forms.NumericUpDown();
            this.ITDpercentLabel = new System.Windows.Forms.Label();
            this.headerSAClabel = new System.Windows.Forms.Label();
            this.OriginatorBox = new System.Windows.Forms.ComboBox();
            this.InitialsLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InitialsTextBox = new System.Windows.Forms.TextBox();
            this.TaxTypesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.zeroPercent = new System.Windows.Forms.CheckBox();
            this.sevenPercent = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NumItemsDrop = new System.Windows.Forms.ComboBox();
            this.CurrencyTable = new System.Windows.Forms.TableLayoutPanel();
            this.SGDRadioBtn = new System.Windows.Forms.RadioButton();
            this.USDRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.headerAllowanceRadio = new System.Windows.Forms.RadioButton();
            this.HeaderChargeRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.headerSACdropdown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.SACNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.headerSACcodeDrop = new System.Windows.Forms.ComboBox();
            this.DeliveryDateLabel = new System.Windows.Forms.Label();
            this.NumLinesLabel = new System.Windows.Forms.Label();
            this.ITDlabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.POOptionsLabel = new System.Windows.Forms.Label();
            this.POCopy = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ITDpercentPicker)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.CurrencyTable.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SACNumberPicker)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.Controls.Add(this.CreatePOButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.POOutputLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.POOutputBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Clear, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.POCopy, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 682);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // CreatePOButton
            // 
            this.CreatePOButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CreatePOButton.Location = new System.Drawing.Point(203, 637);
            this.CreatePOButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreatePOButton.Name = "CreatePOButton";
            this.CreatePOButton.Size = new System.Drawing.Size(224, 41);
            this.CreatePOButton.TabIndex = 0;
            this.CreatePOButton.Text = "Create PO";
            this.CreatePOButton.UseVisualStyleBackColor = true;
            this.CreatePOButton.Click += new System.EventHandler(this.CreatePOButton_Click);
            // 
            // POOutputLabel
            // 
            this.POOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.POOutputLabel.AutoSize = true;
            this.POOutputLabel.Location = new System.Drawing.Point(974, 0);
            this.POOutputLabel.Name = "POOutputLabel";
            this.POOutputLabel.Size = new System.Drawing.Size(84, 54);
            this.POOutputLabel.TabIndex = 4;
            this.POOutputLabel.Text = "PO Output";
            this.POOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // POOutputBox
            // 
            this.POOutputBox.AcceptsReturn = true;
            this.POOutputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.POOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POOutputBox.Location = new System.Drawing.Point(703, 58);
            this.POOutputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.POOutputBox.Multiline = true;
            this.POOutputBox.Name = "POOutputBox";
            this.POOutputBox.ReadOnly = true;
            this.POOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.POOutputBox.Size = new System.Drawing.Size(626, 571);
            this.POOutputBox.TabIndex = 3;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(633, 637);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(64, 41);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel10, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.headerSAClabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.OriginatorBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.InitialsLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CurrencyLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.InitialsTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TaxTypesLabel, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.NumItemsDrop, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.CurrencyTable, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.DeliveryDateLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.NumLinesLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.ITDlabel, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 575);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.ITDneeded, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(314, 286);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(306, 67);
            this.tableLayoutPanel10.TabIndex = 17;
            // 
            // ITDneeded
            // 
            this.ITDneeded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ITDneeded.AutoSize = true;
            this.ITDneeded.Location = new System.Drawing.Point(28, 4);
            this.ITDneeded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ITDneeded.Name = "ITDneeded";
            this.ITDneeded.Size = new System.Drawing.Size(96, 59);
            this.ITDneeded.TabIndex = 0;
            this.ITDneeded.Text = "Include?";
            this.ITDneeded.UseVisualStyleBackColor = true;
            this.ITDneeded.CheckedChanged += new System.EventHandler(this.ITDneeded_CheckedChanged);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4898F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.5102F));
            this.tableLayoutPanel11.Controls.Add(this.ITDpercentPicker, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.ITDpercentLabel, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(156, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(147, 61);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // ITDpercentPicker
            // 
            this.ITDpercentPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ITDpercentPicker.DecimalPlaces = 2;
            this.ITDpercentPicker.Enabled = false;
            this.ITDpercentPicker.Location = new System.Drawing.Point(39, 17);
            this.ITDpercentPicker.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ITDpercentPicker.Name = "ITDpercentPicker";
            this.ITDpercentPicker.Size = new System.Drawing.Size(105, 26);
            this.ITDpercentPicker.TabIndex = 1;
            this.ITDpercentPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ITDpercentLabel
            // 
            this.ITDpercentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ITDpercentLabel.AutoSize = true;
            this.ITDpercentLabel.Location = new System.Drawing.Point(6, 0);
            this.ITDpercentLabel.Name = "ITDpercentLabel";
            this.ITDpercentLabel.Size = new System.Drawing.Size(23, 61);
            this.ITDpercentLabel.TabIndex = 2;
            this.ITDpercentLabel.Text = "%";
            this.ITDpercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerSAClabel
            // 
            this.headerSAClabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.headerSAClabel.AutoSize = true;
            this.headerSAClabel.Location = new System.Drawing.Point(104, 213);
            this.headerSAClabel.Name = "headerSAClabel";
            this.headerSAClabel.Size = new System.Drawing.Size(103, 71);
            this.headerSAClabel.TabIndex = 14;
            this.headerSAClabel.Text = "Header SAC:";
            this.headerSAClabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OriginatorBox
            // 
            this.OriginatorBox.AllowDrop = true;
            this.OriginatorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OriginatorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginatorBox.FormattingEnabled = true;
            this.OriginatorBox.Items.AddRange(new object[] {
            "Makino",
            "Pet Valu"});
            this.OriginatorBox.Location = new System.Drawing.Point(314, 21);
            this.OriginatorBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OriginatorBox.Name = "OriginatorBox";
            this.OriginatorBox.Size = new System.Drawing.Size(306, 28);
            this.OriginatorBox.TabIndex = 0;
            this.OriginatorBox.SelectedIndexChanged += new System.EventHandler(this.OriginatorBox_SelectedIndexChanged);
            // 
            // InitialsLabel
            // 
            this.InitialsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InitialsLabel.AutoSize = true;
            this.InitialsLabel.Location = new System.Drawing.Point(126, 71);
            this.InitialsLabel.Name = "InitialsLabel";
            this.InitialsLabel.Size = new System.Drawing.Size(58, 71);
            this.InitialsLabel.TabIndex = 0;
            this.InitialsLabel.Text = "Initials:";
            this.InitialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(117, 142);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(76, 71);
            this.CurrencyLabel.TabIndex = 1;
            this.CurrencyLabel.Text = "Currency:";
            this.CurrencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 71);
            this.label1.TabIndex = 13;
            this.label1.Text = "PO Originator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitialsTextBox
            // 
            this.InitialsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InitialsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialsTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.InitialsTextBox.Location = new System.Drawing.Point(314, 93);
            this.InitialsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InitialsTextBox.Name = "InitialsTextBox";
            this.InitialsTextBox.Size = new System.Drawing.Size(306, 26);
            this.InitialsTextBox.TabIndex = 6;
            this.InitialsTextBox.Text = "E.G. TST";
            this.InitialsTextBox.Click += new System.EventHandler(this.InitialsTextBox_Click);
            // 
            // TaxTypesLabel
            // 
            this.TaxTypesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TaxTypesLabel.AutoSize = true;
            this.TaxTypesLabel.Location = new System.Drawing.Point(113, 497);
            this.TaxTypesLabel.Name = "TaxTypesLabel";
            this.TaxTypesLabel.Size = new System.Drawing.Size(84, 78);
            this.TaxTypesLabel.TabIndex = 3;
            this.TaxTypesLabel.Text = "Tax Types:";
            this.TaxTypesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.zeroPercent, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.sevenPercent, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(314, 499);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(306, 74);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // zeroPercent
            // 
            this.zeroPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.zeroPercent.AutoSize = true;
            this.zeroPercent.Location = new System.Drawing.Point(47, 4);
            this.zeroPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zeroPercent.Name = "zeroPercent";
            this.zeroPercent.Size = new System.Drawing.Size(58, 66);
            this.zeroPercent.TabIndex = 0;
            this.zeroPercent.Text = "0%";
            this.zeroPercent.UseVisualStyleBackColor = true;
            // 
            // sevenPercent
            // 
            this.sevenPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sevenPercent.AutoSize = true;
            this.sevenPercent.Location = new System.Drawing.Point(200, 4);
            this.sevenPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sevenPercent.Name = "sevenPercent";
            this.sevenPercent.Size = new System.Drawing.Size(58, 66);
            this.sevenPercent.TabIndex = 1;
            this.sevenPercent.Text = "7%";
            this.sevenPercent.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.DeliveryDatePicker, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(314, 428);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(306, 67);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // DeliveryDatePicker
            // 
            this.DeliveryDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryDatePicker.Location = new System.Drawing.Point(3, 20);
            this.DeliveryDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliveryDatePicker.Name = "DeliveryDatePicker";
            this.DeliveryDatePicker.Size = new System.Drawing.Size(300, 26);
            this.DeliveryDatePicker.TabIndex = 7;
            // 
            // NumItemsDrop
            // 
            this.NumItemsDrop.AllowDrop = true;
            this.NumItemsDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumItemsDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.NumItemsDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumItemsDrop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NumItemsDrop.FormattingEnabled = true;
            this.NumItemsDrop.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20",
            "30",
            "50",
            "100",
            "125"});
            this.NumItemsDrop.Location = new System.Drawing.Point(314, 376);
            this.NumItemsDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumItemsDrop.Name = "NumItemsDrop";
            this.NumItemsDrop.Size = new System.Drawing.Size(306, 28);
            this.NumItemsDrop.TabIndex = 11;
            // 
            // CurrencyTable
            // 
            this.CurrencyTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyTable.ColumnCount = 2;
            this.CurrencyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrencyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrencyTable.Controls.Add(this.SGDRadioBtn, 1, 0);
            this.CurrencyTable.Controls.Add(this.USDRadio, 0, 0);
            this.CurrencyTable.Location = new System.Drawing.Point(314, 144);
            this.CurrencyTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyTable.Name = "CurrencyTable";
            this.CurrencyTable.RowCount = 1;
            this.CurrencyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrencyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.CurrencyTable.Size = new System.Drawing.Size(306, 67);
            this.CurrencyTable.TabIndex = 9;
            // 
            // SGDRadioBtn
            // 
            this.SGDRadioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SGDRadioBtn.AutoSize = true;
            this.SGDRadioBtn.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SGDRadioBtn.Location = new System.Drawing.Point(156, 11);
            this.SGDRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SGDRadioBtn.Name = "SGDRadioBtn";
            this.SGDRadioBtn.Size = new System.Drawing.Size(147, 44);
            this.SGDRadioBtn.TabIndex = 9;
            this.SGDRadioBtn.Text = "SGD";
            this.SGDRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SGDRadioBtn.UseVisualStyleBackColor = true;
            // 
            // USDRadio
            // 
            this.USDRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.USDRadio.AutoSize = true;
            this.USDRadio.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.USDRadio.Checked = true;
            this.USDRadio.Location = new System.Drawing.Point(3, 11);
            this.USDRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.USDRadio.Name = "USDRadio";
            this.USDRadio.Size = new System.Drawing.Size(147, 44);
            this.USDRadio.TabIndex = 8;
            this.USDRadio.TabStop = true;
            this.USDRadio.Text = "USD";
            this.USDRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.USDRadio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(314, 216);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(306, 65);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.headerAllowanceRadio, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.HeaderChargeRadio, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(113, 59);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // headerAllowanceRadio
            // 
            this.headerAllowanceRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerAllowanceRadio.AutoSize = true;
            this.headerAllowanceRadio.Location = new System.Drawing.Point(3, 3);
            this.headerAllowanceRadio.Name = "headerAllowanceRadio";
            this.headerAllowanceRadio.Size = new System.Drawing.Size(107, 23);
            this.headerAllowanceRadio.TabIndex = 4;
            this.headerAllowanceRadio.TabStop = true;
            this.headerAllowanceRadio.Text = "Allowance";
            this.headerAllowanceRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerAllowanceRadio.UseVisualStyleBackColor = true;
            // 
            // HeaderChargeRadio
            // 
            this.HeaderChargeRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderChargeRadio.AutoSize = true;
            this.HeaderChargeRadio.Location = new System.Drawing.Point(3, 32);
            this.HeaderChargeRadio.Name = "HeaderChargeRadio";
            this.HeaderChargeRadio.Size = new System.Drawing.Size(107, 24);
            this.HeaderChargeRadio.TabIndex = 5;
            this.HeaderChargeRadio.TabStop = true;
            this.HeaderChargeRadio.Text = "Charge";
            this.HeaderChargeRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderChargeRadio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.48619F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.51381F));
            this.tableLayoutPanel8.Controls.Add(this.headerSACdropdown, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(122, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(181, 59);
            this.tableLayoutPanel8.TabIndex = 17;
            // 
            // headerSACdropdown
            // 
            this.headerSACdropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headerSACdropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headerSACdropdown.FormattingEnabled = true;
            this.headerSACdropdown.Items.AddRange(new object[] {
            "Amount",
            "Percent"});
            this.headerSACdropdown.Location = new System.Drawing.Point(3, 15);
            this.headerSACdropdown.Name = "headerSACdropdown";
            this.headerSACdropdown.Size = new System.Drawing.Size(89, 28);
            this.headerSACdropdown.TabIndex = 11;
            this.headerSACdropdown.SelectedIndexChanged += new System.EventHandler(this.headerSACdropdown_SelectedIndexChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.SACNumberPicker, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.headerSACcodeDrop, 0, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(98, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(80, 53);
            this.tableLayoutPanel9.TabIndex = 11;
            // 
            // SACNumberPicker
            // 
            this.SACNumberPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SACNumberPicker.DecimalPlaces = 2;
            this.SACNumberPicker.Location = new System.Drawing.Point(3, 3);
            this.SACNumberPicker.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SACNumberPicker.Name = "SACNumberPicker";
            this.SACNumberPicker.Size = new System.Drawing.Size(74, 26);
            this.SACNumberPicker.TabIndex = 0;
            this.SACNumberPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headerSACcodeDrop
            // 
            this.headerSACcodeDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headerSACcodeDrop.DropDownWidth = 350;
            this.headerSACcodeDrop.FormattingEnabled = true;
            this.headerSACcodeDrop.Items.AddRange(new object[] {
            "C000 Defective Allowance",
            "C310 Discount",
            "D240 Freight",
            "F340 Pick/Up",
            "F640 Preparation of U.S. Export Documentation",
            "F800 Promotional Allowance",
            "H010 Special Buy",
            "I170 Trade Discount"});
            this.headerSACcodeDrop.Location = new System.Drawing.Point(3, 29);
            this.headerSACcodeDrop.Name = "headerSACcodeDrop";
            this.headerSACcodeDrop.Size = new System.Drawing.Size(74, 28);
            this.headerSACcodeDrop.TabIndex = 1;
            // 
            // DeliveryDateLabel
            // 
            this.DeliveryDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DeliveryDateLabel.AutoSize = true;
            this.DeliveryDateLabel.Location = new System.Drawing.Point(102, 426);
            this.DeliveryDateLabel.Name = "DeliveryDateLabel";
            this.DeliveryDateLabel.Size = new System.Drawing.Size(107, 71);
            this.DeliveryDateLabel.TabIndex = 5;
            this.DeliveryDateLabel.Text = "Delivery Date:";
            this.DeliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumLinesLabel
            // 
            this.NumLinesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NumLinesLabel.AutoSize = true;
            this.NumLinesLabel.Location = new System.Drawing.Point(95, 355);
            this.NumLinesLabel.Name = "NumLinesLabel";
            this.NumLinesLabel.Size = new System.Drawing.Size(120, 71);
            this.NumLinesLabel.TabIndex = 2;
            this.NumLinesLabel.Text = "Numer of Lines:";
            this.NumLinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ITDlabel
            // 
            this.ITDlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ITDlabel.AutoSize = true;
            this.ITDlabel.Location = new System.Drawing.Point(99, 284);
            this.ITDlabel.Name = "ITDlabel";
            this.ITDlabel.Size = new System.Drawing.Size(112, 71);
            this.ITDlabel.TabIndex = 16;
            this.ITDlabel.Text = "ITD (Discount)";
            this.ITDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel5.Controls.Add(this.BackToMenu, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.POOptionsLabel, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(624, 50);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // BackToMenu
            // 
            this.BackToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BackToMenu.Location = new System.Drawing.Point(3, 2);
            this.BackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(75, 46);
            this.BackToMenu.TabIndex = 8;
            this.BackToMenu.Text = "< Menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // POOptionsLabel
            // 
            this.POOptionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.POOptionsLabel.AutoSize = true;
            this.POOptionsLabel.Location = new System.Drawing.Point(313, 0);
            this.POOptionsLabel.Name = "POOptionsLabel";
            this.POOptionsLabel.Size = new System.Drawing.Size(90, 50);
            this.POOptionsLabel.TabIndex = 2;
            this.POOptionsLabel.Text = "PO Options";
            this.POOptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // POCopy
            // 
            this.POCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.POCopy.Location = new System.Drawing.Point(948, 635);
            this.POCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.POCopy.Name = "POCopy";
            this.POCopy.Size = new System.Drawing.Size(135, 45);
            this.POCopy.TabIndex = 10;
            this.POCopy.Text = "Copy";
            this.POCopy.UseVisualStyleBackColor = true;
            this.POCopy.Click += new System.EventHandler(this.POCopy_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PO Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ITDpercentPicker)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.CurrencyTable.ResumeLayout(false);
            this.CurrencyTable.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SACNumberPicker)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreatePOButton;
        private System.Windows.Forms.Label POOptionsLabel;
        private System.Windows.Forms.Label POOutputLabel;
        private System.Windows.Forms.TextBox POOutputBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Button POCopy;
        private System.Windows.Forms.NumericUpDown SACNumberPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label headerSAClabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox zeroPercent;
        private System.Windows.Forms.CheckBox sevenPercent;
        private System.Windows.Forms.ComboBox OriginatorBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker DeliveryDatePicker;
        private System.Windows.Forms.Label InitialsLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TaxTypesLabel;
        private System.Windows.Forms.ComboBox NumItemsDrop;
        private System.Windows.Forms.TableLayoutPanel CurrencyTable;
        private System.Windows.Forms.RadioButton SGDRadioBtn;
        private System.Windows.Forms.RadioButton USDRadio;
        private System.Windows.Forms.TextBox InitialsTextBox;
        private System.Windows.Forms.Label DeliveryDateLabel;
        private System.Windows.Forms.Label NumLinesLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.RadioButton headerAllowanceRadio;
        private System.Windows.Forms.RadioButton HeaderChargeRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox headerSACdropdown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ComboBox headerSACcodeDrop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.CheckBox ITDneeded;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.NumericUpDown ITDpercentPicker;
        private System.Windows.Forms.Label ITDpercentLabel;
        private System.Windows.Forms.Label ITDlabel;
    }
}