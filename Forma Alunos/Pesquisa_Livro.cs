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
	public partial class Pesquisa_Livro : UserControl
	{
		private List<Livros> listaLivroSQL = null;
		private MySQL_Conector conector;

		public Pesquisa_Livro()
		{
			InitializeComponent ();
			modoPesquisaSQL.SelectedIndex = 0;
			conector = MySQL_Conector.Instance;
		}

		private void botaoBuscar_Click( object sender, EventArgs e )
		{
			listaLivroSQL = conector.Pesquisa_Livro (buscaTextBox.Text.ToLower (), modoPesquisaSQL.SelectedIndex);
			update_dislayLivros ();
		}

		private void update_dislayLivros()
		{
			displayLivros.Items.Clear ();

			if ( listaLivroSQL != null )
			{
				for ( int i = 0; i < listaLivroSQL.Count; i++ )
					displayLivros.Items.Add (listaLivroSQL[i].ToString ());
			}
		}

		private void botaoEditar_Click( object sender, EventArgs e )
		{
			//Editar_Livro (listaLivroSQL[displayLivros.SelectedIndex]);
		}
	}
}
