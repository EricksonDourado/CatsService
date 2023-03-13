namespace CatsService.Controllers
{
    partial class FrmBuscarRacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarRacas));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblTemperamento = new System.Windows.Forms.Label();
            this.LblOrigem = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.PicImagem = new System.Windows.Forms.PictureBox();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.btnIncluirFavoritos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(61, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(762, 68);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encontre sua raça favorita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raça do Gato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Origem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descrição";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(531, 167);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Selecione uma Raça";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblTemperamento
            // 
            this.LblTemperamento.AutoSize = true;
            this.LblTemperamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemperamento.Location = new System.Drawing.Point(531, 203);
            this.LblTemperamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTemperamento.MaximumSize = new System.Drawing.Size(250, 0);
            this.LblTemperamento.Name = "LblTemperamento";
            this.LblTemperamento.Size = new System.Drawing.Size(151, 13);
            this.LblTemperamento.TabIndex = 7;
            this.LblTemperamento.Text = "Resultado Temperamento";
            // 
            // LblOrigem
            // 
            this.LblOrigem.AutoSize = true;
            this.LblOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrigem.Location = new System.Drawing.Point(534, 242);
            this.LblOrigem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOrigem.Name = "LblOrigem";
            this.LblOrigem.Size = new System.Drawing.Size(107, 13);
            this.LblOrigem.TabIndex = 8;
            this.LblOrigem.Text = "Resultado Origem";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricao.Location = new System.Drawing.Point(533, 268);
            this.LblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescricao.MaximumSize = new System.Drawing.Size(250, 0);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(125, 13);
            this.LblDescricao.TabIndex = 9;
            this.LblDescricao.Text = "Resultado Descrição";
            // 
            // PicImagem
            // 
            this.PicImagem.Location = new System.Drawing.Point(40, 136);
            this.PicImagem.Name = "PicImagem";
            this.PicImagem.Size = new System.Drawing.Size(343, 266);
            this.PicImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImagem.TabIndex = 10;
            this.PicImagem.TabStop = false;
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtualizarLista.Location = new System.Drawing.Point(531, 137);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(103, 24);
            this.btnAtualizarLista.TabIndex = 11;
            this.btnAtualizarLista.Text = "Atualizar Lista";
            this.btnAtualizarLista.UseVisualStyleBackColor = false;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnIncluirFavoritos
            // 
            this.btnIncluirFavoritos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIncluirFavoritos.Location = new System.Drawing.Point(655, 137);
            this.btnIncluirFavoritos.Name = "btnIncluirFavoritos";
            this.btnIncluirFavoritos.Size = new System.Drawing.Size(110, 24);
            this.btnIncluirFavoritos.TabIndex = 12;
            this.btnIncluirFavoritos.Text = "Incluir Favoritos";
            this.btnIncluirFavoritos.UseVisualStyleBackColor = false;
            this.btnIncluirFavoritos.Click += new System.EventHandler(this.btnIncluirFavoritos_Click);
            // 
            // FrmBuscarRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.btnIncluirFavoritos);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.PicImagem);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblOrigem);
            this.Controls.Add(this.LblTemperamento);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBuscarRacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças";
            this.Load += new System.EventHandler(this.FrmBuscarRacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblTemperamento;
        private System.Windows.Forms.Label LblOrigem;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.PictureBox PicImagem;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Button btnIncluirFavoritos;
    }
}