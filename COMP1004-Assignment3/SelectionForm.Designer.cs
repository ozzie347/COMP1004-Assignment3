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
            this.nextButton = new System.Windows.Forms.Button();
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
            this.currentMoviesListBox.FormattingEnabled = true;
            this.currentMoviesListBox.ItemHeight = 16;
            this.currentMoviesListBox.Location = new System.Drawing.Point(17, 87);
            this.currentMoviesListBox.Name = "currentMoviesListBox";
            this.currentMoviesListBox.Size = new System.Drawing.Size(204, 340);
            this.currentMoviesListBox.TabIndex = 1;
            // 
            // currentMoviesLabel
            // 
            this.currentMoviesLabel.AutoSize = true;
            this.currentMoviesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMoviesLabel.Location = new System.Drawing.Point(39, 60);
            this.currentMoviesLabel.Name = "currentMoviesLabel";
            this.currentMoviesLabel.Size = new System.Drawing.Size(155, 24);
            this.currentMoviesLabel.TabIndex = 2;
            this.currentMoviesLabel.Text = "Current Movies";
            // 
            // yourSelectionGroupBox
            // 
            this.yourSelectionGroupBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSelectionGroupBox.Location = new System.Drawing.Point(248, 90);
            this.yourSelectionGroupBox.Name = "yourSelectionGroupBox";
            this.yourSelectionGroupBox.Size = new System.Drawing.Size(509, 203);
            this.yourSelectionGroupBox.TabIndex = 3;
            this.yourSelectionGroupBox.TabStop = false;
            this.yourSelectionGroupBox.Text = "Your Selection";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(681, 403);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.yourSelectionGroupBox);
            this.Controls.Add(this.currentMoviesLabel);
            this.Controls.Add(this.currentMoviesListBox);
            this.Controls.Add(this.chooseMovieLabel);
            this.Name = "SelectionForm";
            this.Text = "MovieBonanza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseMovieLabel;
        private System.Windows.Forms.ListBox currentMoviesListBox;
        private System.Windows.Forms.Label currentMoviesLabel;
        private System.Windows.Forms.GroupBox yourSelectionGroupBox;
        private System.Windows.Forms.Button nextButton;
    }
}

