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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.HoldRadioYes = new System.Windows.Forms.RadioButton();
            this.HoldRadioNo = new System.Windows.Forms.RadioButton();
            this.InitialsLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.HoldLinesLabel = new System.Windows.Forms.Label();
            this.TaxTypesLabel = new System.Windows.Forms.Label();
            this.DeliveryDateLabel = new System.Windows.Forms.Label();
            this.NumLinesLabel = new System.Windows.Forms.Label();
            this.CurrencyTable = new System.Windows.Forms.TableLayoutPanel();
            this.SGDRadioBtn = new System.Windows.Forms.RadioButton();
            this.USDRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RadioTax7 = new System.Windows.Forms.RadioButton();
            this.TaxRadio0 = new System.Windows.Forms.RadioButton();
            this.DeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.InitialsTextBox = new System.Windows.Forms.TextBox();
            this.NumItemsDrop = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.POOptionsLabel = new System.Windows.Forms.Label();
            this.POCopy = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.CurrencyTable.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 546);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // CreatePOButton
            // 
            this.CreatePOButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CreatePOButton.Location = new System.Drawing.Point(180, 510);
            this.CreatePOButton.Name = "CreatePOButton";
            this.CreatePOButton.Size = new System.Drawing.Size(199, 33);
            this.CreatePOButton.TabIndex = 0;
            this.CreatePOButton.Text = "Create PO";
            this.CreatePOButton.UseVisualStyleBackColor = true;
            this.CreatePOButton.Click += new System.EventHandler(this.CreatePOButton_Click);
            // 
            // POOutputLabel
            // 
            this.POOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.POOutputLabel.AutoSize = true;
            this.POOutputLabel.Location = new System.Drawing.Point(865, 0);
            this.POOutputLabel.Name = "POOutputLabel";
            this.POOutputLabel.Size = new System.Drawing.Size(75, 43);
            this.POOutputLabel.TabIndex = 4;
            this.POOutputLabel.Text = "PO Output";
            this.POOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // POOutputBox
            // 
            this.POOutputBox.AcceptsReturn = true;
            this.POOutputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.POOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POOutputBox.Location = new System.Drawing.Point(625, 46);
            this.POOutputBox.Multiline = true;
            this.POOutputBox.Name = "POOutputBox";
            this.POOutputBox.ReadOnly = true;
            this.POOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.POOutputBox.Size = new System.Drawing.Size(556, 458);
            this.POOutputBox.TabIndex = 3;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(563, 510);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(56, 33);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.InitialsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CurrencyLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.HoldLinesLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.TaxTypesLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.DeliveryDateLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.NumLinesLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CurrencyTable, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.DeliveryDatePicker, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.InitialsTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NumItemsDrop, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 460);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.HoldRadioYes, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.HoldRadioNo, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(280, 382);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(271, 76);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // HoldRadioYes
            // 
            this.HoldRadioYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HoldRadioYes.AutoSize = true;
            this.HoldRadioYes.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HoldRadioYes.Location = new System.Drawing.Point(138, 19);
            this.HoldRadioYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HoldRadioYes.Name = "HoldRadioYes";
            this.HoldRadioYes.Size = new System.Drawing.Size(130, 37);
            this.HoldRadioYes.TabIndex = 9;
            this.HoldRadioYes.Text = "Yes";
            this.HoldRadioYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HoldRadioYes.UseVisualStyleBackColor = true;
            // 
            // HoldRadioNo
            // 
            this.HoldRadioNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HoldRadioNo.AutoSize = true;
            this.HoldRadioNo.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HoldRadioNo.Checked = true;
            this.HoldRadioNo.Location = new System.Drawing.Point(3, 19);
            this.HoldRadioNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HoldRadioNo.Name = "HoldRadioNo";
            this.HoldRadioNo.Size = new System.Drawing.Size(129, 37);
            this.HoldRadioNo.TabIndex = 8;
            this.HoldRadioNo.TabStop = true;
            this.HoldRadioNo.Text = "No";
            this.HoldRadioNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HoldRadioNo.UseVisualStyleBackColor = true;
            // 
            // InitialsLabel
            // 
            this.InitialsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InitialsLabel.AutoSize = true;
            this.InitialsLabel.Location = new System.Drawing.Point(113, 0);
            this.InitialsLabel.Name = "InitialsLabel";
            this.InitialsLabel.Size = new System.Drawing.Size(51, 76);
            this.InitialsLabel.TabIndex = 0;
            this.InitialsLabel.Text = "Initials:";
            this.InitialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(104, 76);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(69, 76);
            this.CurrencyLabel.TabIndex = 1;
            this.CurrencyLabel.Text = "Currency:";
            this.CurrencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoldLinesLabel
            // 
            this.HoldLinesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HoldLinesLabel.AutoSize = true;
            this.HoldLinesLabel.Location = new System.Drawing.Point(74, 380);
            this.HoldLinesLabel.Name = "HoldLinesLabel";
            this.HoldLinesLabel.Size = new System.Drawing.Size(128, 80);
            this.HoldLinesLabel.TabIndex = 4;
            this.HoldLinesLabel.Text = "Include Hold Lines:";
            this.HoldLinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxTypesLabel
            // 
            this.TaxTypesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TaxTypesLabel.AutoSize = true;
            this.TaxTypesLabel.Location = new System.Drawing.Point(99, 304);
            this.TaxTypesLabel.Name = "TaxTypesLabel";
            this.TaxTypesLabel.Size = new System.Drawing.Size(78, 76);
            this.TaxTypesLabel.TabIndex = 3;
            this.TaxTypesLabel.Text = "Tax Types:";
            this.TaxTypesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeliveryDateLabel
            // 
            this.DeliveryDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DeliveryDateLabel.AutoSize = true;
            this.DeliveryDateLabel.Location = new System.Drawing.Point(90, 228);
            this.DeliveryDateLabel.Name = "DeliveryDateLabel";
            this.DeliveryDateLabel.Size = new System.Drawing.Size(97, 76);
            this.DeliveryDateLabel.TabIndex = 5;
            this.DeliveryDateLabel.Text = "Delivery Date:";
            this.DeliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumLinesLabel
            // 
            this.NumLinesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NumLinesLabel.AutoSize = true;
            this.NumLinesLabel.Location = new System.Drawing.Point(84, 152);
            this.NumLinesLabel.Name = "NumLinesLabel";
            this.NumLinesLabel.Size = new System.Drawing.Size(108, 76);
            this.NumLinesLabel.TabIndex = 2;
            this.NumLinesLabel.Text = "Numer of Lines:";
            this.NumLinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CurrencyTable.Location = new System.Drawing.Point(280, 78);
            this.CurrencyTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrencyTable.Name = "CurrencyTable";
            this.CurrencyTable.RowCount = 1;
            this.CurrencyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrencyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.CurrencyTable.Size = new System.Drawing.Size(271, 72);
            this.CurrencyTable.TabIndex = 9;
            // 
            // SGDRadioBtn
            // 
            this.SGDRadioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SGDRadioBtn.AutoSize = true;
            this.SGDRadioBtn.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SGDRadioBtn.Location = new System.Drawing.Point(138, 17);
            this.SGDRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SGDRadioBtn.Name = "SGDRadioBtn";
            this.SGDRadioBtn.Size = new System.Drawing.Size(130, 37);
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
            this.USDRadio.Location = new System.Drawing.Point(3, 17);
            this.USDRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.USDRadio.Name = "USDRadio";
            this.USDRadio.Size = new System.Drawing.Size(129, 37);
            this.USDRadio.TabIndex = 8;
            this.USDRadio.TabStop = true;
            this.USDRadio.Text = "USD";
            this.USDRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.USDRadio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RadioTax7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TaxRadio0, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(280, 306);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(271, 72);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // RadioTax7
            // 
            this.RadioTax7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioTax7.AutoSize = true;
            this.RadioTax7.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RadioTax7.Location = new System.Drawing.Point(138, 17);
            this.RadioTax7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioTax7.Name = "RadioTax7";
            this.RadioTax7.Size = new System.Drawing.Size(130, 37);
            this.RadioTax7.TabIndex = 9;
            this.RadioTax7.TabStop = true;
            this.RadioTax7.Text = "7%";
            this.RadioTax7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioTax7.UseVisualStyleBackColor = true;
            // 
            // TaxRadio0
            // 
            this.TaxRadio0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxRadio0.AutoSize = true;
            this.TaxRadio0.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TaxRadio0.Checked = true;
            this.TaxRadio0.Location = new System.Drawing.Point(3, 17);
            this.TaxRadio0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaxRadio0.Name = "TaxRadio0";
            this.TaxRadio0.Size = new System.Drawing.Size(129, 37);
            this.TaxRadio0.TabIndex = 8;
            this.TaxRadio0.TabStop = true;
            this.TaxRadio0.Text = "0%";
            this.TaxRadio0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TaxRadio0.UseVisualStyleBackColor = true;
            // 
            // DeliveryDatePicker
            // 
            this.DeliveryDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryDatePicker.Location = new System.Drawing.Point(280, 255);
            this.DeliveryDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliveryDatePicker.Name = "DeliveryDatePicker";
            this.DeliveryDatePicker.Size = new System.Drawing.Size(271, 22);
            this.DeliveryDatePicker.TabIndex = 7;
            // 
            // InitialsTextBox
            // 
            this.InitialsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InitialsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialsTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.InitialsTextBox.Location = new System.Drawing.Point(280, 26);
            this.InitialsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InitialsTextBox.Name = "InitialsTextBox";
            this.InitialsTextBox.Size = new System.Drawing.Size(271, 23);
            this.InitialsTextBox.TabIndex = 6;
            this.InitialsTextBox.Text = "E.G. AM";
            this.InitialsTextBox.Click += new System.EventHandler(this.InitialsTextBox_Click);
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
            this.NumItemsDrop.Location = new System.Drawing.Point(280, 177);
            this.NumItemsDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumItemsDrop.Name = "NumItemsDrop";
            this.NumItemsDrop.Size = new System.Drawing.Size(271, 24);
            this.NumItemsDrop.TabIndex = 11;
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(554, 39);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // BackToMenu
            // 
            this.BackToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BackToMenu.Location = new System.Drawing.Point(3, 2);
            this.BackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(67, 35);
            this.BackToMenu.TabIndex = 8;
            this.BackToMenu.Text = "< Menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // POOptionsLabel
            // 
            this.POOptionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.POOptionsLabel.AutoSize = true;
            this.POOptionsLabel.Location = new System.Drawing.Point(278, 0);
            this.POOptionsLabel.Name = "POOptionsLabel";
            this.POOptionsLabel.Size = new System.Drawing.Size(81, 39);
            this.POOptionsLabel.TabIndex = 2;
            this.POOptionsLabel.Text = "PO Options";
            this.POOptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // POCopy
            // 
            this.POCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.POCopy.Location = new System.Drawing.Point(843, 509);
            this.POCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.POCopy.Name = "POCopy";
            this.POCopy.Size = new System.Drawing.Size(120, 35);
            this.POCopy.TabIndex = 10;
            this.POCopy.Text = "Copy";
            this.POCopy.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PO Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.CurrencyTable.ResumeLayout(false);
            this.CurrencyTable.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label InitialsLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label HoldLinesLabel;
        private System.Windows.Forms.Label TaxTypesLabel;
        private System.Windows.Forms.Label DeliveryDateLabel;
        private System.Windows.Forms.Label NumLinesLabel;
        private System.Windows.Forms.TableLayoutPanel CurrencyTable;
        private System.Windows.Forms.RadioButton SGDRadioBtn;
        private System.Windows.Forms.RadioButton USDRadio;
        private System.Windows.Forms.DateTimePicker DeliveryDatePicker;
        private System.Windows.Forms.TextBox InitialsTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton RadioTax7;
        private System.Windows.Forms.RadioButton TaxRadio0;
        private System.Windows.Forms.ComboBox NumItemsDrop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton HoldRadioYes;
        private System.Windows.Forms.RadioButton HoldRadioNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Button POCopy;
    }
}