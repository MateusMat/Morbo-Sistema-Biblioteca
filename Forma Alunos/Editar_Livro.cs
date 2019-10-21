using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Alunos
{
	public partial class Editar_Livro : Form
	{
		private Livros Livro = null;
		private MySQL_Conector conector;
		private bool saved = false;

		public Editar_Livro(Livros livro)
		{
			Livro = livro;
			InitializeComponent ();
			conector = MySQL_Conector.Instance;

			ISBNtextBox.Text = Livro.ISBN;
			CodigoTextBox.Text = Livro.Codigo;
			TituloTextBox.Text = Livro.Titulo;
			AutorTextBox.Text = Livro.Autor;
			EditoraTextBox.Text = Livro.Editora;
			IdiomaTextBox.Text = Livro.Idioma;
			EdicaoTextBox.Text = Livro.Edicao;
			AnoTextBox.Text = Livro.Ano;
			DescricaoTextBox.Text = Livro.Descricao;
		}

		private void BotaoCancelar_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void Editar_Livro_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( saved == false && ((TituloTextBox.Text != Livro.Titulo) || (AutorTextBox.Text != Livro.Autor) || (EditoraTextBox.Text != Livro.Editora) || (IdiomaTextBox.Text != Livro.Idioma) || (EdicaoTextBox.Text != Livro.Edicao) || (AnoTextBox.Text != Livro.Ano) || (DescricaoTextBox.Text != Livro.Descricao) ))
			{
				if ( MessageBox.Show ("Você tem certea que deseja fechar essa Janela se salvar as modificações feitas?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes )
					e.Cancel = false;
				else
					e.Cancel = true;
			}
			else
				e.Cancel = false;
		}

		private void BotaoCadastrar_Click( object sender, EventArgs e )
		{
			if (( TituloTextBox.Text != Livro.Titulo ) || (IdiomaTextBox.Text != Livro.Idioma) || (EdicaoTextBox.Text != Livro.Edicao) || (AnoTextBox.Text != Livro.Ano) || (DescricaoTextBox.Text != Livro.Descricao) )
			{
				conector.editarLivro (Livro.ISBN, TituloTextBox.Text.ToLower (), IdiomaTextBox.Text.ToLower (), EdicaoTextBox.Text, AnoTextBox.Text, DescricaoTextBox.Text);

				saved = true;
				this.Close ();
			}
		}
	}
}