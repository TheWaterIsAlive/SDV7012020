namespace GiftShopV2
{
    partial class frmMain
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
            this.btnGoToCharacters = new System.Windows.Forms.Button();
            this.btnGoToGifts = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToCharacters
            // 
            this.btnGoToCharacters.Location = new System.Drawing.Point(42, 22);
            this.btnGoToCharacters.Name = "btnGoToCharacters";
            this.btnGoToCharacters.Size = new System.Drawing.Size(154, 42);
            this.btnGoToCharacters.TabIndex = 0;
            this.btnGoToCharacters.Text = "Characters";
            this.btnGoToCharacters.UseVisualStyleBackColor = true;
            this.btnGoToCharacters.Click += new System.EventHandler(this.BtnGoToCharacters_Click);
            // 
            // btnGoToGifts
            // 
            this.btnGoToGifts.Location = new System.Drawing.Point(42, 70);
            this.btnGoToGifts.Name = "btnGoToGifts";
            this.btnGoToGifts.Size = new System.Drawing.Size(154, 42);
            this.btnGoToGifts.TabIndex = 1;
            this.btnGoToGifts.Text = "Gifts";
            this.btnGoToGifts.UseVisualStyleBackColor = true;
            this.btnGoToGifts.Click += new System.EventHandler(this.BtnGoToGifts_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Location = new System.Drawing.Point(42, 118);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(154, 42);
            this.btnMainExit.TabIndex = 2;
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.BtnMainExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 171);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnGoToGifts);
            this.Controls.Add(this.btnGoToCharacters);
            this.Name = "frmMain";
            this.Text = "GiftAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToCharacters;
        private System.Windows.Forms.Button btnGoToGifts;
        private System.Windows.Forms.Button btnMainExit;
    }
}