namespace Livros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gdvLivros = new System.Windows.Forms.DataGridView();
            this.grpLivros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtLanc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLivros)).BeginInit();
            this.grpLivros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdvLivros
            // 
            this.gdvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvLivros.Location = new System.Drawing.Point(29, 19);
            this.gdvLivros.Name = "gdvLivros";
            this.gdvLivros.Size = new System.Drawing.Size(387, 150);
            this.gdvLivros.TabIndex = 0;
            // 
            // grpLivros
            // 
            this.grpLivros.Controls.Add(this.gdvLivros);
            this.grpLivros.Location = new System.Drawing.Point(87, 27);
            this.grpLivros.Name = "grpLivros";
            this.grpLivros.Size = new System.Drawing.Size(443, 186);
            this.grpLivros.TabIndex = 1;
            this.grpLivros.TabStop = false;
            this.grpLivros.Text = "Livros Cadastrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(56, 246);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(250, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(12, 291);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(35, 13);
            this.Autor.TabIndex = 4;
            this.Autor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(53, 288);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(253, 20);
            this.txtAutor.TabIndex = 5;
            // 
            // txtLanc
            // 
            this.txtLanc.Location = new System.Drawing.Point(396, 246);
            this.txtLanc.Name = "txtLanc";
            this.txtLanc.Size = new System.Drawing.Size(100, 20);
            this.txtLanc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lançamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Editora:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(370, 288);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(100, 20);
            this.txtEditora.TabIndex = 9;
            // 
            // txtPag
            // 
            this.txtPag.Location = new System.Drawing.Point(67, 331);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(100, 20);
            this.txtPag.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Páginas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gênero: ";
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(370, 331);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(100, 20);
            this.txtGen.TabIndex = 13;
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(204, 366);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 14;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(315, 366);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(421, 366);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(581, 243);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(19, 20);
            this.txtCod.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 401);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPag);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLanc);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpLivros);
            this.Name = "Form1";
            this.Text = "Manutenção de Livros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvLivros)).EndInit();
            this.grpLivros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvLivros;
        private System.Windows.Forms.GroupBox grpLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtLanc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCod;
    }
}

