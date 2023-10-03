namespace CoinFlip
{
    partial class coinFlipGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coinFlipGame));
            this.coinImage = new System.Windows.Forms.PictureBox();
            this.flipButton = new System.Windows.Forms.Button();
            this.headsLabel = new System.Windows.Forms.Label();
            this.tailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinImage)).BeginInit();
            this.SuspendLayout();
            // 
            // coinImage
            // 
            this.coinImage.Image = ((System.Drawing.Image)(resources.GetObject("coinImage.Image")));
            this.coinImage.Location = new System.Drawing.Point(236, 27);
            this.coinImage.Name = "coinImage";
            this.coinImage.Size = new System.Drawing.Size(269, 289);
            this.coinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinImage.TabIndex = 0;
            this.coinImage.TabStop = false;
            // 
            // flipButton
            // 
            this.flipButton.BackColor = System.Drawing.Color.Yellow;
            this.flipButton.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flipButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.flipButton.Location = new System.Drawing.Point(236, 366);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(269, 57);
            this.flipButton.TabIndex = 1;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = false;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // headsLabel
            // 
            this.headsLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.headsLabel.Location = new System.Drawing.Point(231, 319);
            this.headsLabel.Name = "headsLabel";
            this.headsLabel.Size = new System.Drawing.Size(147, 23);
            this.headsLabel.TabIndex = 2;
            this.headsLabel.Text = "Heads:";
            this.headsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tailsLabel
            // 
            this.tailsLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tailsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.tailsLabel.Location = new System.Drawing.Point(358, 319);
            this.tailsLabel.Name = "tailsLabel";
            this.tailsLabel.Size = new System.Drawing.Size(147, 23);
            this.tailsLabel.TabIndex = 3;
            this.tailsLabel.Text = "Tails:";
            this.tailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coinFlipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tailsLabel);
            this.Controls.Add(this.headsLabel);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.coinImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "coinFlipGame";
            this.Text = "CoinFlip Game";
            ((System.ComponentModel.ISupportInitialize)(this.coinImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox coinImage;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Label headsLabel;
        private System.Windows.Forms.Label tailsLabel;
    }
}

