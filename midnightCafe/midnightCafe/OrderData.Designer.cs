namespace midnightCafe
{
    partial class OrderData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemNameLabel = new Label();
            itemPriceLabel = new Label();
            SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemNameLabel.Location = new Point(24, 5);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(65, 21);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "CHOCO";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemPriceLabel.ForeColor = Color.MediumSeaGreen;
            itemPriceLabel.Location = new Point(293, 5);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(65, 21);
            itemPriceLabel.TabIndex = 1;
            itemPriceLabel.Text = "CHOCO";
            // 
            // OrderData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(itemPriceLabel);
            Controls.Add(itemNameLabel);
            Name = "OrderData";
            Size = new Size(388, 26);
            Load += OrderData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemNameLabel;
        private Label itemPriceLabel;
    }
}
