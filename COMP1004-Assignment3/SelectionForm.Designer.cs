namespace COMP1004_Assignment3
{
    partial class SelectionForm
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
            this.chooseMovieLabel = new System.Windows.Forms.Label();
            this.currentMoviesListBox = new System.Windows.Forms.ListBox();
            this.currentMoviesLabel = new System.Windows.Forms.Label();
            this.yourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.movieSelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.yourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieSelectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseMovieLabel
            // 
            this.chooseMovieLabel.AutoSize = true;
            this.chooseMovieLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseMovieLabel.Location = new System.Drawing.Point(13, 13);
            this.chooseMovieLabel.Name = "chooseMovieLabel";
            this.chooseMovieLabel.Size = new System.Drawing.Size(546, 24);
            this.chooseMovieLabel.TabIndex = 0;
            this.chooseMovieLabel.Text = "Choose a movie you wish to STREAM from the list below";
            // 
            // currentMoviesListBox
            // 
            this.currentMoviesListBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMoviesListBox.FormattingEnabled = true;
            this.currentMoviesListBox.ItemHeight = 22;
            this.currentMoviesListBox.Location = new System.Drawing.Point(17, 87);
            this.currentMoviesListBox.Name = "currentMoviesListBox";
            this.currentMoviesListBox.Size = new System.Drawing.Size(214, 334);
            this.currentMoviesListBox.Sorted = true;
            this.currentMoviesListBox.TabIndex = 1;
            // 
            // currentMoviesLabel
            // 
            this.currentMoviesLabel.AutoSize = true;
            this.currentMoviesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMoviesLabel.Location = new System.Drawing.Point(44, 60);
            this.currentMoviesLabel.Name = "currentMoviesLabel";
            this.currentMoviesLabel.Size = new System.Drawing.Size(155, 24);
            this.currentMoviesLabel.TabIndex = 2;
            this.currentMoviesLabel.Text = "Current Movies";
            // 
            // yourSelectionGroupBox
            // 
            this.yourSelectionGroupBox.Controls.Add(this.costLabel);
            this.yourSelectionGroupBox.Controls.Add(this.costTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.categoryTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.categoryLabel);
            this.yourSelectionGroupBox.Controls.Add(this.titleTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.titleLabel);
            this.yourSelectionGroupBox.Controls.Add(this.movieSelectionPictureBox);
            this.yourSelectionGroupBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSelectionGroupBox.Location = new System.Drawing.Point(250, 90);
            this.yourSelectionGroupBox.Name = "yourSelectionGroupBox";
            this.yourSelectionGroupBox.Size = new System.Drawing.Size(509, 211);
            this.yourSelectionGroupBox.TabIndex = 3;
            this.yourSelectionGroupBox.TabStop = false;
            this.yourSelectionGroupBox.Text = "Your Selection";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(176, 49);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(319, 27);
            this.titleTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(184, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 19);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // movieSelectionPictureBox
            // 
            this.movieSelectionPictureBox.Location = new System.Drawing.Point(21, 26);
            this.movieSelectionPictureBox.Name = "movieSelectionPictureBox";
            this.movieSelectionPictureBox.Size = new System.Drawing.Size(140, 170);
            this.movieSelectionPictureBox.TabIndex = 0;
            this.movieSelectionPictureBox.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(670, 383);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(89, 38);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(188, 102);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(81, 19);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(176, 125);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(187, 27);
            this.categoryTextBox.TabIndex = 4;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(385, 125);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(110, 27);
            this.costTextBox.TabIndex = 5;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(402, 102);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(46, 19);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = "Cost";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.yourSelectionGroupBox);
            this.Controls.Add(this.currentMoviesLabel);
            this.Controls.Add(this.currentMoviesListBox);
            this.Controls.Add(this.chooseMovieLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieBonanza";
            this.yourSelectionGroupBox.ResumeLayout(false);
            this.yourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieSelectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseMovieLabel;
        private System.Windows.Forms.ListBox currentMoviesListBox;
        private System.Windows.Forms.Label currentMoviesLabel;
        private System.Windows.Forms.GroupBox yourSelectionGroupBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox movieSelectionPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costTextBox;
    }
}

