
namespace projeto_cadastro
{
    partial class frm_Confirm
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
            this.Lbl_Cdd = new System.Windows.Forms.Label();
            this.Lbl_resu2 = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Cdd
            // 
            this.Lbl_Cdd.AutoSize = true;
            this.Lbl_Cdd.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cdd.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Cdd.Location = new System.Drawing.Point(25, 35);
            this.Lbl_Cdd.Name = "Lbl_Cdd";
            this.Lbl_Cdd.Size = new System.Drawing.Size(352, 34);
            this.Lbl_Cdd.TabIndex = 7;
            this.Lbl_Cdd.Text = "Confimarção dos dados";
            this.Lbl_Cdd.Click += new System.EventHandler(this.Lbl_Cdd_Click);
            // 
            // Lbl_resu2
            // 
            this.Lbl_resu2.AutoSize = true;
            this.Lbl_resu2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_resu2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_resu2.ForeColor = System.Drawing.Color.White;
            this.Lbl_resu2.Location = new System.Drawing.Point(25, 69);
            this.Lbl_resu2.Name = "Lbl_resu2";
            this.Lbl_resu2.Size = new System.Drawing.Size(113, 24);
            this.Lbl_resu2.TabIndex = 6;
            this.Lbl_resu2.Text = "Resultado";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Voltar.Location = new System.Drawing.Point(896, 1);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Voltar.TabIndex = 8;
            this.Btn_Voltar.Text = "voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ok.Location = new System.Drawing.Point(12, 445);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(53, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // frm_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 641);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_Cdd);
            this.Controls.Add(this.Lbl_resu2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "frm_Confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmção";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Confirm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Cdd;
        private System.Windows.Forms.Button Btn_Voltar;
        public System.Windows.Forms.Label Lbl_resu2;
        private System.Windows.Forms.Button btn_ok;
    }
}