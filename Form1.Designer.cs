namespace EDIFileGenerator
{
    partial class Form1
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
            this.ASNLabel = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.AdviceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Copy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ASNLabel
            // 
            this.ASNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ASNLabel.AutoSize = true;
            this.ASNLabel.Location = new System.Drawing.Point(312, 0);
            this.ASNLabel.Name = "ASNLabel";
            this.ASNLabel.Size = new System.Drawing.Size(42, 54);
            this.ASNLabel.TabIndex = 2;
            this.ASNLabel.Text = "ASN";
            this.ASNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ASNLabel.Click += new System.EventHandler(this.ASNLabel_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.AcceptsReturn = true;
            this.OutputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.Location = new System.Drawing.Point(669, 58);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputBox.Size = new System.Drawing.Size(660, 572);
            this.OutputBox.TabIndex = 3;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // InputBox
            // 
            this.InputBox.AcceptsReturn = true;
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputBox.Location = new System.Drawing.Point(3, 58);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputBox.Size = new System.Drawing.Size(660, 572);
            this.InputBox.TabIndex = 1;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConvertButton.Location = new System.Drawing.Point(221, 638);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(224, 41);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // AdviceLabel
            // 
            this.AdviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AdviceLabel.AutoSize = true;
            this.AdviceLabel.Location = new System.Drawing.Point(934, 0);
            this.AdviceLabel.Name = "AdviceLabel";
            this.AdviceLabel.Size = new System.Drawing.Size(129, 54);
            this.AdviceLabel.TabIndex = 4;
            this.AdviceLabel.Text = "Receiving Advice";
            this.AdviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdviceLabel.Click += new System.EventHandler(this.AdviceLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ConvertButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InputBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OutputBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ASNLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdviceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Copy, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 683);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Copy
            // 
            this.Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Copy.Location = new System.Drawing.Point(931, 637);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(136, 43);
            this.Copy.TabIndex = 5;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1340, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(400, 700);
            this.Name = "Form1";
            this.Text = "EDI File Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ASNLabel;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label AdviceLabel;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button button1;
    }
}

