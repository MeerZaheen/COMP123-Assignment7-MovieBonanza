namespace Movie_Bonanza
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel2 = new System.Windows.Forms.Label();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.BuyCheckBox = new System.Windows.Forms.CheckBox();
            this.AdditionalCostLabel = new System.Windows.Forms.Label();
            this.AdditionalCostTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.YourOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(517, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(352, 510);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(76, 35);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(352, 322);
            this.StreamButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(76, 35);
            this.StreamButton.TabIndex = 2;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(268, 510);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(76, 35);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.MoviePictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryLabel2);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel2);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(20, 57);
            this.MovieSelectedGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(232, 488);
            this.MovieSelectedGroupBox.TabIndex = 4;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(15, 167);
            this.MoviePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(192, 305);
            this.MoviePictureBox.TabIndex = 4;
            this.MoviePictureBox.TabStop = false;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(14, 122);
            this.CategoryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(192, 26);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(15, 57);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(192, 26);
            this.TitleTextBox.TabIndex = 2;
            // 
            // CategoryLabel2
            // 
            this.CategoryLabel2.AutoSize = true;
            this.CategoryLabel2.Location = new System.Drawing.Point(10, 97);
            this.CategoryLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel2.Name = "CategoryLabel2";
            this.CategoryLabel2.Size = new System.Drawing.Size(73, 20);
            this.CategoryLabel2.TabIndex = 1;
            this.CategoryLabel2.Text = "Category";
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Location = new System.Drawing.Point(10, 31);
            this.TitleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel2.TabIndex = 0;
            this.TitleLabel2.Text = "Title";
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.BuyCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.AdditionalCostLabel);
            this.YourOrderGroupBox.Controls.Add(this.AdditionalCostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.YourOrderGroupBox.Controls.Add(this.CostTextBox);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel2);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(270, 57);
            this.YourOrderGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YourOrderGroupBox.Size = new System.Drawing.Size(232, 240);
            this.YourOrderGroupBox.TabIndex = 5;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // BuyCheckBox
            // 
            this.BuyCheckBox.AutoSize = true;
            this.BuyCheckBox.Location = new System.Drawing.Point(12, 197);
            this.BuyCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyCheckBox.Name = "BuyCheckBox";
            this.BuyCheckBox.Size = new System.Drawing.Size(146, 44);
            this.BuyCheckBox.TabIndex = 15;
            this.BuyCheckBox.Text = "Order the DVD \r\n(Additional $10)";
            this.BuyCheckBox.UseVisualStyleBackColor = true;
            this.BuyCheckBox.Click += new System.EventHandler(this.OrderForm_Load);
            // 
            // AdditionalCostLabel
            // 
            this.AdditionalCostLabel.AutoSize = true;
            this.AdditionalCostLabel.Location = new System.Drawing.Point(8, 63);
            this.AdditionalCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdditionalCostLabel.Name = "AdditionalCostLabel";
            this.AdditionalCostLabel.Size = new System.Drawing.Size(116, 20);
            this.AdditionalCostLabel.TabIndex = 14;
            this.AdditionalCostLabel.Text = "Additional Cost";
            this.AdditionalCostLabel.Visible = false;
            // 
            // AdditionalCostTextBox
            // 
            this.AdditionalCostTextBox.Location = new System.Drawing.Point(147, 60);
            this.AdditionalCostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdditionalCostTextBox.Name = "AdditionalCostTextBox";
            this.AdditionalCostTextBox.ReadOnly = true;
            this.AdditionalCostTextBox.Size = new System.Drawing.Size(61, 26);
            this.AdditionalCostTextBox.TabIndex = 13;
            this.AdditionalCostTextBox.Visible = false;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(8, 167);
            this.GrandTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(93, 20);
            this.GrandTotalLabel.TabIndex = 12;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(8, 128);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(120, 20);
            this.SalesTaxLabel.TabIndex = 11;
            this.SalesTaxLabel.Text = "Sales Tax(13%)";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(8, 94);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(73, 20);
            this.SubTotalLabel.TabIndex = 10;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(147, 161);
            this.GrandTotalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(61, 26);
            this.GrandTotalTextBox.TabIndex = 9;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(147, 125);
            this.SalesTaxTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(61, 26);
            this.SalesTaxTextBox.TabIndex = 8;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(147, 91);
            this.SubTotalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(61, 26);
            this.SubTotalTextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(147, 28);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(61, 26);
            this.CostTextBox.TabIndex = 6;
            // 
            // CostLabel2
            // 
            this.CostLabel2.AutoSize = true;
            this.CostLabel2.Location = new System.Drawing.Point(8, 31);
            this.CostLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel2.Name = "CostLabel2";
            this.CostLabel2.Size = new System.Drawing.Size(42, 20);
            this.CostLabel2.TabIndex = 5;
            this.CostLabel2.Text = "Cost";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 563);
            this.ControlBox = false;
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.Label CategoryLabel2;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label CostLabel2;
        private System.Windows.Forms.Label AdditionalCostLabel;
        public System.Windows.Forms.TextBox CategoryTextBox;
        public System.Windows.Forms.TextBox TitleTextBox;
        public System.Windows.Forms.PictureBox MoviePictureBox;
        public System.Windows.Forms.TextBox GrandTotalTextBox;
        public System.Windows.Forms.TextBox SalesTaxTextBox;
        public System.Windows.Forms.TextBox SubTotalTextBox;
        public System.Windows.Forms.TextBox CostTextBox;
        public System.Windows.Forms.TextBox AdditionalCostTextBox;
        private System.Windows.Forms.CheckBox BuyCheckBox;
    }
}