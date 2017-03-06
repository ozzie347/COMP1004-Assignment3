namespace COMP1004_Assignment3
{
    partial class StreamForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.billedLabel = new System.Windows.Forms.Label();
            this.billedAmountLabel = new System.Windows.Forms.Label();
            this.yourMovieLabel = new System.Windows.Forms.Label();
            this.selectedMovieLabel = new System.Windows.Forms.Label();
            this.willBeginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(201, 214);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.AutoSize = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.Location = new System.Drawing.Point(50, 42);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(320, 19);
            this.thankYouLabel.TabIndex = 1;
            this.thankYouLabel.Text = "Thank you for choosing MovieBonanza!";
            // 
            // billedLabel
            // 
            this.billedLabel.AutoSize = true;
            this.billedLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billedLabel.Location = new System.Drawing.Point(81, 83);
            this.billedLabel.Name = "billedLabel";
            this.billedLabel.Size = new System.Drawing.Size(230, 22);
            this.billedLabel.TabIndex = 2;
            this.billedLabel.Text = "Your credit card has been billed for";
            // 
            // billedAmountLabel
            // 
            this.billedAmountLabel.AutoSize = true;
            this.billedAmountLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billedAmountLabel.Location = new System.Drawing.Point(308, 83);
            this.billedAmountLabel.Name = "billedAmountLabel";
            this.billedAmountLabel.Size = new System.Drawing.Size(0, 22);
            this.billedAmountLabel.TabIndex = 3;
            // 
            // yourMovieLabel
            // 
            this.yourMovieLabel.AutoSize = true;
            this.yourMovieLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourMovieLabel.Location = new System.Drawing.Point(81, 124);
            this.yourMovieLabel.Name = "yourMovieLabel";
            this.yourMovieLabel.Size = new System.Drawing.Size(143, 22);
            this.yourMovieLabel.TabIndex = 4;
            this.yourMovieLabel.Text = "Your selected movie,";
            // 
            // selectedMovieLabel
            // 
            this.selectedMovieLabel.AutoSize = true;
            this.selectedMovieLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMovieLabel.Location = new System.Drawing.Point(224, 124);
            this.selectedMovieLabel.Name = "selectedMovieLabel";
            this.selectedMovieLabel.Size = new System.Drawing.Size(0, 22);
            this.selectedMovieLabel.TabIndex = 5;
            // 
            // willBeginLabel
            // 
            this.willBeginLabel.AutoSize = true;
            this.willBeginLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.willBeginLabel.Location = new System.Drawing.Point(81, 146);
            this.willBeginLabel.Name = "willBeginLabel";
            this.willBeginLabel.Size = new System.Drawing.Size(184, 22);
            this.willBeginLabel.TabIndex = 6;
            this.willBeginLabel.Text = "will begin in about a minute.";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.ControlBox = false;
            this.Controls.Add(this.selectedMovieLabel);
            this.Controls.Add(this.yourMovieLabel);
            this.Controls.Add(this.willBeginLabel);
            this.Controls.Add(this.billedAmountLabel);
            this.Controls.Add(this.billedLabel);
            this.Controls.Add(this.thankYouLabel);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieBonanza";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label thankYouLabel;
        private System.Windows.Forms.Label billedLabel;
        private System.Windows.Forms.Label billedAmountLabel;
        private System.Windows.Forms.Label yourMovieLabel;
        private System.Windows.Forms.Label selectedMovieLabel;
        private System.Windows.Forms.Label willBeginLabel;
    }
}