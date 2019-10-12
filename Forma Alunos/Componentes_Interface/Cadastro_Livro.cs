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
				TituloTextBox.Enabled = true;
				AutorTextBox.Enabled = true;
				EditoraTextBox.Enabled = true;
				EdicaoTextBox.Enabled = true;
				IdiomaTextBox.Enabled = true;
				AnoTextBox.Enabled = true;
				AssuntoTextBox.Enabled = true;
				DescricaoTextBox.Enabled = true;
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
		}
	}
}
