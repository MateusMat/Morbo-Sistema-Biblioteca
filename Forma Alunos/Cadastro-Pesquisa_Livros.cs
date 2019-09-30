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
	public partial class UserControl1 : UserControl
	{
		private MySQL_Conector conector = new MySQL_Conector ();

		private List<Livros> listaLivroSQL = null;

		public UserControl1()
		{
			InitializeComponent ();
			modoPesquisaSQL.SelectedIndex = 0;
		}

		private void botaoCadastrarSQL_Click( object sender, EventArgs e )
		{
			if ( DialogResult.OK == MessageBox.Show ("Tem certeza que quer cadastrar o Livro:\nTítulo: " + tituloSQL.Text +
														"\nAutor: " + autorSQL.Text +
														"\nEditora: " + editoraSQL.Text +
														"\nEdição: " + edicaoSQL.Text +
														"\nAno: " + anoSQL.Text, "Confirmar dados do Livro", MessageBoxButtons.OKCancel) )
			{
				conector.inserirLivro (tituloSQL.Text.ToLower (), autorSQL.Text.ToLower (), editoraSQL.Text.ToLower (), edicaoSQL.Text.ToLower (), anoSQL.Text.ToLower ());
				tituloSQL.Clear ();
				autorSQL.Clear ();
				editoraSQL.Clear ();
				edicaoSQL.Clear ();
				anoSQL.Clear ();
			}
		}

		private void updateDislay_LivrosSQL()
		{
			Display_LivrosSQL.Items.Clear ();

			if ( listaLivroSQL != null )
			{
				for ( int i = 0; i < listaLivroSQL.Count (); i++ )
					Display_LivrosSQL.Items.Add (listaLivroSQL[i].ToString ());
			}
		}

		private void botaoPesquisarSQL_Click( object sender, EventArgs e )
		{


			listaLivroSQL = conector.Pesquisa_Livro (pesquisaLivroSQL.Text.ToLower (), modoPesquisaSQL.SelectedIndex);
			updateDislay_LivrosSQL ();
		}

		private void onlyAlpha_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( !(e.KeyChar.ToString ().All (char.IsLetter) || e.KeyChar.ToString ().All (char.IsSeparator) || e.KeyChar.ToString ().All (char.IsControl)) )
			{
				e.Handled = true;
			}

			else if ( e.KeyChar == (char) Keys.Enter )
			{
				if ( sender.Equals (pesquisaLivroSQL) )
					botaoPesquisarSQL.PerformClick ();
				else
					botaoCadastrarSQL.PerformClick ();
				e.Handled = true;
			}
		}
		private void onlyNum_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( !(e.KeyChar.ToString ().All (char.IsDigit) || e.KeyChar.ToString ().All (char.IsControl)) )
			{
				e.Handled = true;
			}
			else if ( e.KeyChar == (char) Keys.Enter )
			{
				if ( sender.Equals (pesquisaLivroSQL) )
					botaoPesquisarSQL.PerformClick ();
				else
					botaoCadastrarSQL.PerformClick ();
				e.Handled = true;
			}
		}
	}
}
