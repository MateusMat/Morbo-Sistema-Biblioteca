using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Alunos.Componentes_Interface
{

	public partial class Pesquisa_Usuario : UserControl
	{
		private List<Aluno> listaAlunos = null;
		private MySQL_Conector conector;

		public Pesquisa_Usuario()
		{
			InitializeComponent ();
			modoPesquisa.SelectedIndex = 0;
			conector = MySQL_Conector.Instance;
		}

		private void update_dislayAlunos()
		{
			displayAlunos.Items.Clear ();

			if ( listaAlunos != null )
			{
				for ( int i = 0; i < listaAlunos.Count; i++ )
					displayAlunos.Items.Add (listaAlunos[i].ToString ());
			}
		}

		private void botaoBuscar_Click( object sender, EventArgs e )
		{
			listaAlunos = conector.Pesquisa_Aluno (buscaTextBox.Text.ToLower (), modoPesquisa.SelectedIndex);
			update_dislayAlunos ();
		}

		private void displayAlunos_DoubleClick( object sender, EventArgs e )
		{
			Dados_Aluno janela = new Dados_Aluno (listaAlunos[displayAlunos.SelectedIndex]);
			janela.Show ();
		}
	}
}
