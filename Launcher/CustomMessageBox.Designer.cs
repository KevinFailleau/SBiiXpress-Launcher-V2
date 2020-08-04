namespace Launcher
{
    partial class CustomMessageBox
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
            this.Btn_Oui = new System.Windows.Forms.Button();
            this.Btn_Non = new System.Windows.Forms.Button();
            this.Texte = new System.Windows.Forms.Label();
            this.Cb_NePlusDemander = new System.Windows.Forms.CheckBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Oui
            // 
            this.Btn_Oui.Location = new System.Drawing.Point(174, 92);
            this.Btn_Oui.Name = "Btn_Oui";
            this.Btn_Oui.Size = new System.Drawing.Size(75, 23);
            this.Btn_Oui.TabIndex = 0;
            this.Btn_Oui.Text = "Oui";
            this.Btn_Oui.UseVisualStyleBackColor = true;
            this.Btn_Oui.Click += new System.EventHandler(this.Btn_Oui_Click);
            // 
            // Btn_Non
            // 
            this.Btn_Non.Location = new System.Drawing.Point(287, 92);
            this.Btn_Non.Name = "Btn_Non";
            this.Btn_Non.Size = new System.Drawing.Size(75, 23);
            this.Btn_Non.TabIndex = 1;
            this.Btn_Non.Text = "Non";
            this.Btn_Non.UseVisualStyleBackColor = true;
            this.Btn_Non.Click += new System.EventHandler(this.Btn_Non_Click);
            // 
            // Texte
            // 
            this.Texte.AutoSize = true;
            this.Texte.Location = new System.Drawing.Point(72, 40);
            this.Texte.Name = "Texte";
            this.Texte.Size = new System.Drawing.Size(34, 13);
            this.Texte.TabIndex = 2;
            this.Texte.Text = "Texte";
            // 
            // Cb_NePlusDemander
            // 
            this.Cb_NePlusDemander.AutoSize = true;
            this.Cb_NePlusDemander.Location = new System.Drawing.Point(12, 98);
            this.Cb_NePlusDemander.Name = "Cb_NePlusDemander";
            this.Cb_NePlusDemander.Size = new System.Drawing.Size(129, 17);
            this.Cb_NePlusDemander.TabIndex = 3;
            this.Cb_NePlusDemander.Text = "Ne plus me demander";
            this.Cb_NePlusDemander.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(27, 29);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(39, 34);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 130);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Cb_NePlusDemander);
            this.Controls.Add(this.Texte);
            this.Controls.Add(this.Btn_Non);
            this.Controls.Add(this.Btn_Oui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.Text = "Question";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomMessageBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Oui;
        private System.Windows.Forms.Button Btn_Non;
        private System.Windows.Forms.Label Texte;
        private System.Windows.Forms.CheckBox Cb_NePlusDemander;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}