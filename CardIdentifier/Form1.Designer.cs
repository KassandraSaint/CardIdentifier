
namespace CardIdentifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.cardPic1 = new System.Windows.Forms.PictureBox();
            this.cardPic2 = new System.Windows.Forms.PictureBox();
            this.cardPic3 = new System.Windows.Forms.PictureBox();
            this.cardPic4 = new System.Windows.Forms.PictureBox();
            this.cardPic5 = new System.Windows.Forms.PictureBox();
            this.showCard = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a Card to See Its Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardPic1
            // 
            this.cardPic1.Image = global::CardIdentifier.Properties.Resources.joker;
            this.cardPic1.Location = new System.Drawing.Point(12, 113);
            this.cardPic1.Name = "cardPic1";
            this.cardPic1.Size = new System.Drawing.Size(307, 432);
            this.cardPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic1.TabIndex = 1;
            this.cardPic1.TabStop = false;
            this.cardPic1.Click += new System.EventHandler(this.cardPic1_Click);
            // 
            // cardPic2
            // 
            this.cardPic2.Image = global::CardIdentifier.Properties.Resources.queen;
            this.cardPic2.Location = new System.Drawing.Point(347, 113);
            this.cardPic2.Name = "cardPic2";
            this.cardPic2.Size = new System.Drawing.Size(307, 432);
            this.cardPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic2.TabIndex = 2;
            this.cardPic2.TabStop = false;
            this.cardPic2.Click += new System.EventHandler(this.cardPic2_Click);
            // 
            // cardPic3
            // 
            this.cardPic3.Image = global::CardIdentifier.Properties.Resources.ace;
            this.cardPic3.Location = new System.Drawing.Point(684, 113);
            this.cardPic3.Name = "cardPic3";
            this.cardPic3.Size = new System.Drawing.Size(307, 432);
            this.cardPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic3.TabIndex = 3;
            this.cardPic3.TabStop = false;
            this.cardPic3.Click += new System.EventHandler(this.cardPic3_Click);
            // 
            // cardPic4
            // 
            this.cardPic4.Image = global::CardIdentifier.Properties.Resources.junior;
            this.cardPic4.Location = new System.Drawing.Point(1021, 113);
            this.cardPic4.Name = "cardPic4";
            this.cardPic4.Size = new System.Drawing.Size(307, 432);
            this.cardPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic4.TabIndex = 4;
            this.cardPic4.TabStop = false;
            this.cardPic4.Click += new System.EventHandler(this.cardPic4_Click);
            // 
            // cardPic5
            // 
            this.cardPic5.Image = global::CardIdentifier.Properties.Resources.king;
            this.cardPic5.Location = new System.Drawing.Point(1355, 113);
            this.cardPic5.Name = "cardPic5";
            this.cardPic5.Size = new System.Drawing.Size(307, 432);
            this.cardPic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPic5.TabIndex = 5;
            this.cardPic5.TabStop = false;
            this.cardPic5.Click += new System.EventHandler(this.cardPic5_Click);
            // 
            // showCard
            // 
            this.showCard.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.showCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showCard.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCard.Location = new System.Drawing.Point(477, 564);
            this.showCard.Name = "showCard";
            this.showCard.Size = new System.Drawing.Size(706, 84);
            this.showCard.TabIndex = 6;
            this.showCard.Text = "\r\n";
            this.showCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(684, 668);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(307, 90);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1674, 779);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showCard);
            this.Controls.Add(this.cardPic5);
            this.Controls.Add(this.cardPic4);
            this.Controls.Add(this.cardPic3);
            this.Controls.Add(this.cardPic2);
            this.Controls.Add(this.cardPic1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CardIdentifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cardPic1;
        private System.Windows.Forms.PictureBox cardPic2;
        private System.Windows.Forms.PictureBox cardPic3;
        private System.Windows.Forms.PictureBox cardPic4;
        private System.Windows.Forms.PictureBox cardPic5;
        private System.Windows.Forms.Label showCard;
        private System.Windows.Forms.Button exitButton;
    }
}

