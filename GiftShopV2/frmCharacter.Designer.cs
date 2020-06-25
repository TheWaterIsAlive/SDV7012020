namespace GiftShopV2
{
    partial class frmCharacter
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
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCharacters
            // 
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.ItemHeight = 16;
            this.lstCharacters.Location = new System.Drawing.Point(33, 67);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(224, 196);
            this.lstCharacters.TabIndex = 0;
            this.lstCharacters.DoubleClick += new System.EventHandler(this.LstCharacters_DoubleClick);
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Location = new System.Drawing.Point(33, 269);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(224, 56);
            this.btnDeleteCharacter.TabIndex = 1;
            this.btnDeleteCharacter.Text = "Delete";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chracters";
            // 
            // frmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteCharacter);
            this.Controls.Add(this.lstCharacters);
            this.Name = "frmCharacter";
            this.Text = "Character";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCharacter_FormClosing);
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.Button btnDeleteCharacter;
        private System.Windows.Forms.Label label1;
    }
}