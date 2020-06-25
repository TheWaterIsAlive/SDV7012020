namespace GiftShopV2
{
    partial class frmCharacterGifts
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lstCharacterGifts = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveGift = new System.Windows.Forms.Button();
            this.txtPlayerAvailable = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbFinalised = new System.Windows.Forms.CheckBox();
            this.lblCharacterID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CharacterID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Character Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Date";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(132, 40);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(181, 22);
            this.txtCharacterName.TabIndex = 5;
            this.txtCharacterName.Text = "Corin";
            // 
            // lstCharacterGifts
            // 
            this.lstCharacterGifts.FormattingEnabled = true;
            this.lstCharacterGifts.ItemHeight = 16;
            this.lstCharacterGifts.Items.AddRange(new object[] {
            "Leonin Warrior with a Powerful Aura",
            "Impatient and Demanding",
            "Seeks Dangerous Excitement",
            "Not Leaving Without a Trophy",
            "Irresponsible"});
            this.lstCharacterGifts.Location = new System.Drawing.Point(349, 40);
            this.lstCharacterGifts.Name = "lstCharacterGifts";
            this.lstCharacterGifts.Size = new System.Drawing.Size(215, 260);
            this.lstCharacterGifts.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(102, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnRemoveGift
            // 
            this.btnRemoveGift.Location = new System.Drawing.Point(395, 306);
            this.btnRemoveGift.Name = "btnRemoveGift";
            this.btnRemoveGift.Size = new System.Drawing.Size(121, 34);
            this.btnRemoveGift.TabIndex = 9;
            this.btnRemoveGift.Text = "Remove Gift";
            this.btnRemoveGift.UseVisualStyleBackColor = true;
            // 
            // txtPlayerAvailable
            // 
            this.txtPlayerAvailable.Location = new System.Drawing.Point(132, 103);
            this.txtPlayerAvailable.Name = "txtPlayerAvailable";
            this.txtPlayerAvailable.Size = new System.Drawing.Size(181, 22);
            this.txtPlayerAvailable.TabIndex = 10;
            this.txtPlayerAvailable.Text = "10/5/20";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(132, 73);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(181, 22);
            this.txtPlayerName.TabIndex = 11;
            this.txtPlayerName.Text = "Howl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gifts";
            // 
            // chbFinalised
            // 
            this.chbFinalised.AutoSize = true;
            this.chbFinalised.Checked = true;
            this.chbFinalised.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFinalised.Location = new System.Drawing.Point(102, 143);
            this.chbFinalised.Name = "chbFinalised";
            this.chbFinalised.Size = new System.Drawing.Size(86, 21);
            this.chbFinalised.TabIndex = 13;
            this.chbFinalised.Text = "Finalised";
            this.chbFinalised.UseVisualStyleBackColor = true;
            // 
            // lblCharacterID
            // 
            this.lblCharacterID.AutoSize = true;
            this.lblCharacterID.Location = new System.Drawing.Point(102, 9);
            this.lblCharacterID.Name = "lblCharacterID";
            this.lblCharacterID.Size = new System.Drawing.Size(16, 17);
            this.lblCharacterID.TabIndex = 14;
            this.lblCharacterID.Text = "0";
            // 
            // frmCharacterGifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 370);
            this.Controls.Add(this.lblCharacterID);
            this.Controls.Add(this.chbFinalised);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.txtPlayerAvailable);
            this.Controls.Add(this.btnRemoveGift);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstCharacterGifts);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCharacterGifts";
            this.Text = "frmCharacterGifts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCharacterGifts_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.ListBox lstCharacterGifts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveGift;
        private System.Windows.Forms.TextBox txtPlayerAvailable;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbFinalised;
        private System.Windows.Forms.Label lblCharacterID;
    }
}