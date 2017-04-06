using Livros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livros
{
    public partial class Form1 : Form
    {
        private LivrosEntities db = new LivrosEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void lerLivros()
        {
            
            IEnumerable<Livro> lista = from p in db.Livro select p;
            grpLivros.Text = "Livros Cadastrados: " + lista.Count();
            gdvLivros.DataSource = lista.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lerLivros();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            
            Livro l = new Livro();
            l.Autor = txtAutor.Text;
            l.Editora = txtEditora.Text;
            l.Titulo = txtTitulo.Text;
            l.Lancamento = txtLanc.Text;
            l.Genero = txtGen.Text;
            l.CodLivro = Convert.ToInt32(txtCod.Text);
            l.DataCadastro = DateTime.Now;
            l.Pag = Convert.ToInt32(txtPag.Text);
            db.Livro.Add(l);
            db.SaveChanges();
           
        }
    }
}
