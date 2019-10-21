using System;
using System.Windows;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Forma_Alunos
{
	public partial class Principal : Form
	{
		private List<Aluno> listaAlunos = new List<Aluno> ();

		public Principal()
		{
			InitializeComponent ();
		}

		private void botao_cadastrarLivro_Click( object sender, EventArgs e )
		{
			cadastro_Livro.Show ();
			pesquisa_Livro.Hide ();
			cadastro_Usuario.Hide ();
			emprestar_Livro.Hide ();
			pesquisa_Usuario.Hide ();
			devolver_Livro.Hide ();
		}

		private void botao_cadastrarUsuario_Click( object sender, EventArgs e )
		{
			cadastro_Livro.Hide ();
			cadastro_Usuario.Show ();
			pesquisa_Livro.Hide ();
			emprestar_Livro.Hide ();
			pesquisa_Usuario.Hide ();
			devolver_Livro.Hide ();
		}

		private void botao_pesquisarLivro_Click( object sender, EventArgs e )
		{
			cadastro_Livro.Hide ();
			cadastro_Usuario.Hide ();
			pesquisa_Livro.Show ();
			emprestar_Livro.Hide ();
			pesquisa_Usuario.Hide ();
			devolver_Livro.Hide ();
		}

		private void botao_EmprestarLivro_Click( object sender, EventArgs e )
		{
			cadastro_Livro.Hide ();
			pesquisa_Livro.Hide ();
			cadastro_Usuario.Hide ();
			emprestar_Livro.Show ();
			pesquisa_Usuario.Hide ();
			devolver_Livro.Hide ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			cadastro_Livro.Hide ();
			pesquisa_Livro.Hide ();
			cadastro_Usuario.Hide ();
			emprestar_Livro.Hide ();
			pesquisa_Usuario.Show ();
			devolver_Livro.Hide ();
		}

		private void botao_DevolverLivro_Click( object sender, EventArgs e )
		{
			cadastro_Livro.Hide ();
			pesquisa_Livro.Hide ();
			cadastro_Usuario.Hide ();
			emprestar_Livro.Hide ();
			pesquisa_Usuario.Hide ();
			devolver_Livro.Show ();
		}
	}
}
