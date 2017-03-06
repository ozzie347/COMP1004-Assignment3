namespace COMP1004_Assignment3
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.yourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.streamButton = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.addDVDCheckBox = new System.Windows.Forms.CheckBox();
            this.dvdLabel = new System.Windows.Forms.Label();
            this.dvdTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.movieSelectedGroupBox.SuspendLayout();
            this.yourOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(782, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.streamToolStripMenuItem.Text = "Stream";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.streamButton_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // movieSelectedGroupBox
            // 
            this.movieSelectedGroupBox.Controls.Add(this.posterPictureBox);
            this.movieSelectedGroupBox.Controls.Add(this.categoryTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.categoryLabel);
            this.movieSelectedGroupBox.Controls.Add(this.titleTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.titleLabel);
            this.movieSelectedGroupBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieSelectedGroupBox.Location = new System.Drawing.Point(13, 32);
            this.movieSelectedGroupBox.Name = "movieSelectedGroupBox";
            this.movieSelectedGroupBox.Size = new System.Drawing.Size(326, 409);
            this.movieSelectedGroupBox.TabIndex = 1;
            this.movieSelectedGroupBox.TabStop = false;
            this.movieSelectedGroupBox.Text = "Movie Selected";
            // 
            // yourOrderGroupBox
            // 
            this.yourOrderGroupBox.Controls.Add(this.grandTotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.salesTaxTextBox);
            this.yourOrderGroupBox.Controls.Add(this.subtotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.costTextBox);
            this.yourOrderGroupBox.Controls.Add(this.dvdTextBox);
            this.yourOrderGroupBox.Controls.Add(this.dvdLabel);
            this.yourOrderGroupBox.Controls.Add(this.addDVDCheckBox);
            this.yourOrderGroupBox.Controls.Add(this.grandTotalLabel);
            this.yourOrderGroupBox.Controls.Add(this.salesTaxLabel);
            this.yourOrderGroupBox.Controls.Add(this.subtotalLabel);
            this.yourOrderGroupBox.Controls.Add(this.costLabel);
            this.yourOrderGroupBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourOrderGroupBox.Location = new System.Drawing.Point(346, 32);
            this.yourOrderGroupBox.Name = "yourOrderGroupBox";
            this.yourOrderGroupBox.Size = new System.Drawing.Size(436, 330);
            this.yourOrderGroupBox.TabIndex = 2;
            this.yourOrderGroupBox.TabStop = false;
            this.yourOrderGroupBox.Text = "Your Order";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(346, 406);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 35);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(574, 406);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 35);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // streamButton
            // 
            this.streamButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamButton.Location = new System.Drawing.Point(680, 406);
            this.streamButton.Name = "streamButton";
            this.streamButton.Size = new System.Drawing.Size(90, 35);
            this.streamButton.TabIndex = 5;
            this.streamButton.Text = "Stream";
            this.streamButton.UseVisualStyleBackColor = true;
            this.streamButton.Click += new System.EventHandler(this.streamButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(128, 59);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(54, 24);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "Cost";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(93, 138);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(89, 24);
            this.subtotalLabel.TabIndex = 1;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxLabel.Location = new System.Drawing.Point(81, 178);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(101, 24);
            this.salesTaxLabel.TabIndex = 2;
            this.salesTaxLabel.Text = "Sales Tax";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLabel.Location = new System.Drawing.Point(60, 219);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(122, 24);
            this.grandTotalLabel.TabIndex = 3;
            this.grandTotalLabel.Text = "Grand Total";
            // 
            // addDVDCheckBox
            // 
            this.addDVDCheckBox.AutoSize = true;
            this.addDVDCheckBox.Location = new System.Drawing.Point(6, 286);
            this.addDVDCheckBox.Name = "addDVDCheckBox";
            this.addDVDCheckBox.Size = new System.Drawing.Size(361, 23);
            this.addDVDCheckBox.TabIndex = 4;
            this.addDVDCheckBox.Text = "Order the DVD (Adds $10.00 to your total)";
            this.addDVDCheckBox.UseVisualStyleBackColor = true;
            // 
            // dvdLabel
            // 
            this.dvdLabel.AutoSize = true;
            this.dvdLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvdLabel.Location = new System.Drawing.Point(131, 98);
            this.dvdLabel.Name = "dvdLabel";
            this.dvdLabel.Size = new System.Drawing.Size(51, 24);
            this.dvdLabel.TabIndex = 5;
            this.dvdLabel.Text = "DVD";
            this.dvdLabel.Visible = false;
            // 
            // dvdTextBox
            // 
            this.dvdTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvdTextBox.Location = new System.Drawing.Point(188, 95);
            this.dvdTextBox.Name = "dvdTextBox";
            this.dvdTextBox.ReadOnly = true;
            this.dvdTextBox.Size = new System.Drawing.Size(100, 30);
            this.dvdTextBox.TabIndex = 6;
            this.dvdTextBox.Visible = false;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(188, 56);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(100, 30);
            this.costTextBox.TabIndex = 7;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalTextBox.Location = new System.Drawing.Point(188, 135);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 30);
            this.subtotalTextBox.TabIndex = 8;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxTextBox.Location = new System.Drawing.Point(188, 175);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 30);
            this.salesTaxTextBox.TabIndex = 9;
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalTextBox.Location = new System.Drawing.Point(188, 216);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.ReadOnly = true;
            this.grandTotalTextBox.Size = new System.Drawing.Size(100, 30);
            this.grandTotalTextBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(6, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 19);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(6, 50);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(314, 27);
            this.titleTextBox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(6, 95);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(81, 19);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(6, 117);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(314, 27);
            this.categoryTextBox.TabIndex = 3;
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.Location = new System.Drawing.Point(7, 151);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(313, 252);
            this.posterPictureBox.TabIndex = 4;
            this.posterPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.ControlBox = false;
            this.Controls.Add(this.streamButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.yourOrderGroupBox);
            this.Controls.Add(this.movieSelectedGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.movieSelectedGroupBox.ResumeLayout(false);
            this.movieSelectedGroupBox.PerformLayout();
            this.yourOrderGroupBox.ResumeLayout(false);
            this.yourOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox movieSelectedGroupBox;
        private System.Windows.Forms.GroupBox yourOrderGroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button streamButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.CheckBox addDVDCheckBox;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Label dvdLabel;
        private System.Windows.Forms.TextBox dvdTextBox;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.PictureBox posterPictureBox;
    }
}