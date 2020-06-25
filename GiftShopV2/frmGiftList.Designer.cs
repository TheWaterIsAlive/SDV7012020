namespace GiftShopV2
{
    partial class frmGiftList
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
            this.lstGifts = new System.Windows.Forms.ListBox();
            this.btnDeleteGift = new System.Windows.Forms.Button();
            this.btnMakeAvailable = new System.Windows.Forms.Button();
            this.btnRemoveForCharacter = new System.Windows.Forms.Button();
            this.btnNewGift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGifts
            // 
            this.lstGifts.FormattingEnabled = true;
            this.lstGifts.ItemHeight = 16;
            this.lstGifts.Items.AddRange(new object[] {
            "Leonin Warrior with a Powerful Aura",
            "Impatient and Demanding",
            "Seeks Dangerous Excitement",
            "Not Leaving Without a Trophy",
            "Irresponsible"});
            this.lstGifts.Location = new System.Drawing.Point(12, 12);
            this.lstGifts.Name = "lstGifts";
            this.lstGifts.Size = new System.Drawing.Size(216, 244);
            this.lstGifts.TabIndex = 0;
            this.lstGifts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstGifts_MouseDoubleClick);
            // 
            // btnDeleteGift
            // 
            this.btnDeleteGift.Location = new System.Drawing.Point(12, 262);
            this.btnDeleteGift.Name = "btnDeleteGift";
            this.btnDeleteGift.Size = new System.Drawing.Size(216, 49);
            this.btnDeleteGift.TabIndex = 3;
            this.btnDeleteGift.Text = "Delete Gift";
            this.btnDeleteGift.UseVisualStyleBackColor = true;
            // 
            // btnMakeAvailable
            // 
            this.btnMakeAvailable.Location = new System.Drawing.Point(12, 317);
            this.btnMakeAvailable.Name = "btnMakeAvailable";
            this.btnMakeAvailable.Size = new System.Drawing.Size(216, 49);
            this.btnMakeAvailable.TabIndex = 4;
            this.btnMakeAvailable.Text = "Make Avilable";
            this.btnMakeAvailable.UseVisualStyleBackColor = true;
            // 
            // btnRemoveForCharacter
            // 
            this.btnRemoveForCharacter.Location = new System.Drawing.Point(12, 372);
            this.btnRemoveForCharacter.Name = "btnRemoveForCharacter";
            this.btnRemoveForCharacter.Size = new System.Drawing.Size(216, 49);
            this.btnRemoveForCharacter.TabIndex = 5;
            this.btnRemoveForCharacter.Text = "Remove For Character";
            this.btnRemoveForCharacter.UseVisualStyleBackColor = true;
            // 
            // btnNewGift
            // 
            this.btnNewGift.Location = new System.Drawing.Point(12, 427);
            this.btnNewGift.Name = "btnNewGift";
            this.btnNewGift.Size = new System.Drawing.Size(216, 49);
            this.btnNewGift.TabIndex = 6;
            this.btnNewGift.Text = "New Gift";
            this.btnNewGift.UseVisualStyleBackColor = true;
            // 
            // frmGiftList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 514);
            this.Controls.Add(this.btnNewGift);
            this.Controls.Add(this.btnRemoveForCharacter);
            this.Controls.Add(this.btnMakeAvailable);
            this.Controls.Add(this.btnDeleteGift);
            this.Controls.Add(this.lstGifts);
            this.Name = "frmGiftList";
            this.Text = "Gifts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGiftList_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGifts;
        private System.Windows.Forms.Button btnDeleteGift;
        private System.Windows.Forms.Button btnMakeAvailable;
        private System.Windows.Forms.Button btnRemoveForCharacter;
        private System.Windows.Forms.Button btnNewGift;
    }
}