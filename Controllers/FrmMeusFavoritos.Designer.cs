namespace CatsService.Controllers
{
    partial class FrmMeusFavoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeusFavoritos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFavoritos = new System.Windows.Forms.ListBox();
            this.BtnExluirFavorito = new System.Windows.Forms.Button();
            this.pictImagem = new System.Windows.Forms.PictureBox();
            this.LblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meus Favoritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aqui você encontra a lista de gatinhos favoritos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(745, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "_________________________________________________________________________________" +
    "__________________________________________";
            // 
            // lbFavoritos
            // 
            this.lbFavoritos.FormattingEnabled = true;
            this.lbFavoritos.Location = new System.Drawing.Point(461, 159);
            this.lbFavoritos.MultiColumn = true;
            this.lbFavoritos.Name = "lbFavoritos";
            this.lbFavoritos.Size = new System.Drawing.Size(241, 147);
            this.lbFavoritos.TabIndex = 3;
            this.lbFavoritos.SelectedIndexChanged += new System.EventHandler(this.lbFavoritos_SelectedIndexChanged);
            // 
            // BtnExluirFavorito
            // 
            this.BtnExluirFavorito.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnExluirFavorito.Location = new System.Drawing.Point(590, 322);
            this.BtnExluirFavorito.Name = "BtnExluirFavorito";
            this.BtnExluirFavorito.Size = new System.Drawing.Size(112, 33);
            this.BtnExluirFavorito.TabIndex = 4;
            this.BtnExluirFavorito.Text = "Excluir Favorito";
            this.BtnExluirFavorito.UseVisualStyleBackColor = false;
            this.BtnExluirFavorito.Click += new System.EventHandler(this.BtnExluirFavorito_Click);
            // 
            // pictImagem
            // 
            this.pictImagem.Location = new System.Drawing.Point(93, 148);
            this.pictImagem.Name = "pictImagem";
            this.pictImagem.Size = new System.Drawing.Size(334, 207);
            this.pictImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictImagem.TabIndex = 11;
            this.pictImagem.TabStop = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(370, 170);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(0, 13);
            this.LblName.TabIndex = 12;
            // 
            // FrmMeusFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.pictImagem);
            this.Controls.Add(this.BtnExluirFavorito);
            this.Controls.Add(this.lbFavoritos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMeusFavoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus Favoritos";
            this.Load += new System.EventHandler(this.FrmMeusFavoritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbFavoritos;
        private System.Windows.Forms.Button BtnExluirFavorito;
        private System.Windows.Forms.PictureBox pictImagem;
        private System.Windows.Forms.Label LblName;
    }
}