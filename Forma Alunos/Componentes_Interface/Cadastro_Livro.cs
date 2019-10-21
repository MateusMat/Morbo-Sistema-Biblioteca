using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Alunos
{
	public partial class Cadastro_Livro : UserControl
	{
		private MySQL_Conector conector;

		public Cadastro_Livro()
		{
			InitializeComponent ();
			conector = MySQL_Conector.Instance;
		}

		private void Cadastro_Livro_Load( object sender, EventArgs e )
		{

		}

		private void label5_Click( object sender, EventArgs e )
		{

		}

		private void AssuntoTextBox_Enter( object sender, EventArgs e )
		{
			if ( AssuntoTextBox.Text == "Assuntos devem ser separados por ponto e virgula." )
			{
				AssuntoTextBox.Text = "";
				AssuntoTextBox.ForeColor = Color.Black;
			}
		}

		private void AssuntoTextBox_Leave( object sender, EventArgs e )
		{
			if ( AssuntoTextBox.Text == "")
			{
				AssuntoTextBox.Text = "Assuntos devem ser separados por ponto e virgula.";
				AssuntoTextBox.ForeColor = Color.Gray;
			}
		}


		private void ISBNtextBox_TextChanged( object sender, EventArgs e )
		{
			if(ISBNtextBox.Text.Length == 10 || ISBNtextBox.Text.Length == 13 )
			{
				Livros livroTemp = conector.Pesquisa_unico_Livro (ISBNtextBox.Text, 0);

				if(livroTemp == null)
				{
					QuantidadeTextBox.Enabled = true;
					TituloTextBox.Enabled = true;
					AutorTextBox.Enabled = true;
					EditoraTextBox.Enabled = true;
					EdicaoTextBox.Enabled = true;
					IdiomaTextBox.Enabled = true;
					AnoTextBox.Enabled = true;
					DescricaoTextBox.Enabled = true;
				}
				else
				{
					QuantidadeTextBox.Text = livroTemp.Numero_Exemplares.ToString();
					TituloTextBox.Text = livroTemp.Titulo ;
					AutorTextBox.Text = livroTemp.Autor ;
					EditoraTextBox.Text = livroTemp.Editora ;
					EdicaoTextBox.Text = livroTemp.Edicao ;
					IdiomaTextBox.Text = livroTemp.Idioma ;
					AnoTextBox.Text = livroTemp.Ano ;
					DescricaoTextBox.Text = livroTemp.Descricao ;
				}
				AssuntoTextBox.Enabled = true;
			}
			else
			{
				QuantidadeTextBox.Enabled = false;
				TituloTextBox.Enabled = false;
				AutorTextBox.Enabled = false;
				EditoraTextBox.Enabled = false;
				EdicaoTextBox.Enabled = false;
				IdiomaTextBox.Enabled = false;
				AnoTextBox.Enabled = false;
				AssuntoTextBox.Enabled = false;
				DescricaoTextBox.Enabled = false;

				QuantidadeTextBox.Text = "";
				TituloTextBox.Text = "";
				AutorTextBox.Text = "";
				EditoraTextBox.Text = "";
				EdicaoTextBox.Text = "";
				IdiomaTextBox.Text = "";
				AnoTextBox.Text = "";
				DescricaoTextBox.Text = "";
			}

			string temp = "";
			for ( int i = 0; i < ISBNtextBox.Text.Length; i++ )
			{
				if ( char.IsDigit (ISBNtextBox.Text[i]) )
				{
					temp += ISBNtextBox.Text[i];
				}
			}
			ISBNtextBox.Text = temp;

			if ( ISBNtextBox.Text.Length > 13 )
			{
				ISBNtextBox.Text = ISBNtextBox.Text.Substring (0, 13);
			}

			ISBNtextBox.Select (13, 0);
		}

		private void onlyNum_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( !(e.KeyChar.ToString ().All (char.IsDigit) || e.KeyChar.ToString ().All (char.IsControl)) )
			{
				e.Handled = true;
			}
		}

		private void ISBNtextBox_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( (!char.IsDigit (e.KeyChar) || char.IsControl(e.KeyChar)) || ISBNtextBox.Text.Length == 13 )
			{
				e.Handled = true;
			}
		}

		private void BotaoCadastrar_Click( object sender, EventArgs e )
		{
			int quantia = Int32.Parse (QuantidadeTextBox.Text);

			string codigo = conector.inserirLivroNovo (ISBNtextBox.Text, TituloTextBox.Text.ToLower(), AutorTextBox.Text.ToLower(), EditoraTextBox.Text.ToLower (), IdiomaTextBox.Text.ToLower (), EdicaoTextBox.Text, AnoTextBox.Text, DescricaoTextBox.Text);

			if (quantia > 1)
			{
				conector.inserirLivroExistente (ISBNtextBox.Text, codigo, quantia - 1);
			}

			string mensagem = "Código dos livros cadastrados:\n";

			for (int i = 1; i <= quantia; i++)
			{
				mensagem += codigo + "" + i.ToString ("D3") + "\n";
			}

			mensagem += "\n Desejá imprimir Códigos de Barras?";

			MessageBox.Show (mensagem, "Imprimir Códigos de Barras", MessageBoxButtons.YesNo);
		}
	}
}
