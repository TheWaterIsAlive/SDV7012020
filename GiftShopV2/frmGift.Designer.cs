namespace GiftShopV2
{
    partial class frmGift
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
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtGiftName = new System.Windows.Forms.TextBox();
            this.txtGiftDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiftEffect = new System.Windows.Forms.TextBox();
            this.chbAvailable = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gift Name";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(12, 424);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(97, 17);
            this.lblLastUpdate.TabIndex = 1;
            this.lblLastUpdate.Text = "Last Updated:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descritpion";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(288, 282);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(136, 49);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // txtGiftName
            // 
            this.txtGiftName.Location = new System.Drawing.Point(93, 28);
            this.txtGiftName.Name = "txtGiftName";
            this.txtGiftName.Size = new System.Drawing.Size(189, 22);
            this.txtGiftName.TabIndex = 4;
            // 
            // txtGiftDescription
            // 
            this.txtGiftDescription.Location = new System.Drawing.Point(15, 76);
            this.txtGiftDescription.Multiline = true;
            this.txtGiftDescription.Name = "txtGiftDescription";
            this.txtGiftDescription.Size = new System.Drawing.Size(368, 178);
            this.txtGiftDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Game Effect";
            // 
            // txtGiftEffect
            // 
            this.txtGiftEffect.Location = new System.Drawing.Point(408, 76);
            this.txtGiftEffect.Multiline = true;
            this.txtGiftEffect.Name = "txtGiftEffect";
            this.txtGiftEffect.Size = new System.Drawing.Size(368, 178);
            this.txtGiftEffect.TabIndex = 7;
            // 
            // chbAvailable
            // 
            this.chbAvailable.AutoSize = true;
            this.chbAvailable.Location = new System.Drawing.Point(297, 30);
            this.chbAvailable.Name = "chbAvailable";
            this.chbAvailable.Size = new System.Drawing.Size(87, 21);
            this.chbAvailable.TabIndex = 8;
            this.chbAvailable.Text = "Available";
            this.chbAvailable.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 49);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chbAvailable);
            this.Controls.Add(this.txtGiftEffect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiftDescription);
            this.Controls.Add(this.txtGiftName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.label1);
            this.Name = "frmGift";
            this.Text = "Gift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtGiftName;
        private System.Windows.Forms.TextBox txtGiftDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiftEffect;
        private System.Windows.Forms.CheckBox chbAvailable;
        private System.Windows.Forms.Button btnCancel;
    }
}