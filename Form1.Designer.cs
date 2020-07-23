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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ASNLabel = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.AdviceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(601, 506);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(84, 29);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.AcceptsReturn = true;
            this.InputBox.Location = new System.Drawing.Point(34, 40);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputBox.Size = new System.Drawing.Size(600, 444);
            this.InputBox.TabIndex = 1;
            // 
            // ASNLabel
            // 
            this.ASNLabel.AutoSize = true;
            this.ASNLabel.Location = new System.Drawing.Point(296, 9);
            this.ASNLabel.Name = "ASNLabel";
            this.ASNLabel.Size = new System.Drawing.Size(42, 20);
            this.ASNLabel.TabIndex = 2;
            this.ASNLabel.Text = "ASN";
            // 
            // OutputBox
            // 
            this.OutputBox.AcceptsReturn = true;
            this.OutputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputBox.Location = new System.Drawing.Point(650, 40);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputBox.Size = new System.Drawing.Size(600, 444);
            this.OutputBox.TabIndex = 3;
            // 
            // AdviceLabel
            // 
            this.AdviceLabel.AutoSize = true;
            this.AdviceLabel.Location = new System.Drawing.Point(891, 9);
            this.AdviceLabel.Name = "AdviceLabel";
            this.AdviceLabel.Size = new System.Drawing.Size(129, 20);
            this.AdviceLabel.TabIndex = 4;
            this.AdviceLabel.Text = "Receiving Advice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 562);
            this.Controls.Add(this.AdviceLabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ASNLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ConvertButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label ASNLabel;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label AdviceLabel;
    }
}

