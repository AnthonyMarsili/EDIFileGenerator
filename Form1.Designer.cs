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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.AdviceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Copy = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ASNLabel
            // 
            this.ASNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ASNLabel.AutoSize = true;
            this.ASNLabel.Location = new System.Drawing.Point(262, 0);
            this.ASNLabel.Name = "ASNLabel";
            this.ASNLabel.Size = new System.Drawing.Size(36, 43);
            this.ASNLabel.TabIndex = 2;
            this.ASNLabel.Text = "ASN";
            this.ASNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputBox
            // 
            this.InputBox.AcceptsReturn = true;
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputBox.Location = new System.Drawing.Point(3, 46);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputBox.Size = new System.Drawing.Size(554, 458);
            this.InputBox.TabIndex = 1;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConvertButton.Location = new System.Drawing.Point(180, 510);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(199, 33);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // AdviceLabel
            // 
            this.AdviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AdviceLabel.AutoSize = true;
            this.AdviceLabel.Location = new System.Drawing.Point(845, 0);
            this.AdviceLabel.Name = "AdviceLabel";
            this.AdviceLabel.Size = new System.Drawing.Size(116, 43);
            this.AdviceLabel.TabIndex = 4;
            this.AdviceLabel.Text = "Receiving Advice";
            this.AdviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.Controls.Add(this.ConvertButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InputBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ASNLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdviceLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Copy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.OutputBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Clear, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 546);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Copy
            // 
            this.Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Copy.Location = new System.Drawing.Point(843, 509);
            this.Copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(120, 35);
            this.Copy.TabIndex = 5;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            // 
            // OutputBox
            // 
            this.OutputBox.AcceptsReturn = true;
            this.OutputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.Location = new System.Drawing.Point(625, 46);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputBox.Size = new System.Drawing.Size(556, 458);
            this.OutputBox.TabIndex = 3;
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
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(358, 569);
            this.Name = "Form1";
            this.Text = "EDI File Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ASNLabel;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label AdviceLabel;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button Clear;
    }
}

