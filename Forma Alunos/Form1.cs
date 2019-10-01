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
    public partial class Sistema : Form
    {
        private MySQL_Conector conector = new MySQL_Conector();

        private List<Aluno> listaAlunos = new List<Aluno>();

        private List<Livros> listaLivroSQL = null;

        public Sistema()
        {
            InitializeComponent();
			modoPesquisaSQL.SelectedIndex = 0;
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            loadDados();
        }

        private void Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveDados();
        }

        private void saveDados()
        {
            StreamWriter sA = new StreamWriter("Alunos.txt");

            for (int i = 0; i < listaAlunos.Count; i++)
            {
                sA.WriteLine(listaAlunos[i]);
            }
            sA.Close();
        }

        private void loadDados()
        {
            StreamReader lA = new StreamReader("Alunos.txt");

            while (!lA.EndOfStream)
            {
                string temp = lA.ReadLine();
                Aluno obj = new Aluno(temp.Substring(0, temp.IndexOf(',')), Int32.Parse(temp.Substring(temp.IndexOf(',') + 2)));

                listaAlunos.Add(obj);
            }
            updateDisplayAlunos();
            lA.Close();
        }



        //******************************//
        // Referente a Cadastrar Alunos //
        //******************************//

        private void updateDisplayAlunos()
        {
            displayAlunos.Items.Clear();

            for (int i = 0; i < listaAlunos.Count; i++)
            {
                displayAlunos.Items.Add(listaAlunos[i]);
            }
        }

        private void buttonCadastrarAlunos_Click(object sender, EventArgs e)
        {
            // impede dois alunos com o mesmo RA
            int tempRA = Int32.Parse(textRA.Text);

            for (int i = 0; i < listaAlunos.Count; i++)
            {
                if (listaAlunos[i].RA == tempRA)
                {
                    MessageBox.Show("O RA " + tempRA + " já está cadastrado", "Erro ao realizar o cadastro", MessageBoxButtons.OKCancel);
                    return;
                }
            }
            // cadastra o novo aluno
            if (textName.Text.Count() > 0 && textRA.Text.Count() > 0)
            {
                Aluno obj = new Aluno(textName.Text, Int32.Parse(textRA.Text));

                listaAlunos.Add(obj);
                updateDisplayAlunos();
            }
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetter) || e.KeyChar.ToString().All(char.IsSeparator) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                buttonCadastrarAlunos.PerformClick();
                e.Handled = true;
            }

        }

        private void textRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsDigit) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                buttonCadastrarAlunos.PerformClick();
                e.Handled = true;
            }
        }

        private void DeletarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    if (listaAlunos[i].ToString() == displayAlunos.SelectedItem.ToString())
                    {
                        if (DialogResult.OK == MessageBox.Show("Tem certeza que quer deletar entrada:\nNome: " + listaAlunos[i].Nome + "\nRA: " + listaAlunos[i].RA.ToString(), "Confirmação de deleção", MessageBoxButtons.OKCancel))
                        {
                            listaAlunos.RemoveAt(i);
                            updateDisplayAlunos();
                        }
                        break;
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Selecione um elemento para remover", "Erro ao remover", MessageBoxButtons.OK);
            }
        }


        //*****************//
        // Pesquisar Aluno //
        //*****************//

        private void pesquisarAluno_Click(object sender, EventArgs e)
        {
            displayPesquisaAluno.Items.Clear();

            if (textPesquisaRA.Text.Count() > 0)
            {
                int tempRA = Int32.Parse(textPesquisaRA.Text);

                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    if (listaAlunos[i].RA == tempRA)
                    {
                        displayPesquisaAluno.Items.Add(listaAlunos[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    if (listaAlunos[i].Nome.Contains(textPesquisaNome.Text))
                    {
                        displayPesquisaAluno.Items.Add(listaAlunos[i]);
                    }
                }
            }
        }

        private void displayPesquisaAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxNomeAlunoSelecionado.Items.Clear();
            boxRaAlunoSelecionado.Items.Clear();



            for (int i = 0; i < listaAlunos.Count; i++)
            {
                if (listaAlunos[i].ToString() == displayPesquisaAluno.SelectedItem.ToString())
                {
                    boxNomeAlunoSelecionado.Items.Add(listaAlunos[i].Nome);
                    boxRaAlunoSelecionado.Items.Add(listaAlunos[i].RA);
                    break;
                }
            }
        }

        private void textPesquisaRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsDigit) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                pesquisarAluno.PerformClick();
                e.Handled = true;
            }
        }

        private void textPesquisaNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetter) || e.KeyChar.ToString().All(char.IsSeparator) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                pesquisarAluno.PerformClick();
                e.Handled = true;
            }
        }


        //*********************//
        //      Livro SQL      //
        //*********************//

        private void botaoCadastrarSQL_Click(object sender, EventArgs e)
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
            Display_LivrosSQL.Items.Clear();

            if(listaLivroSQL != null)
            {
                for (int i = 0; i < listaLivroSQL.Count(); i++)
                    Display_LivrosSQL.Items.Add(listaLivroSQL[i].ToString());
            }
        }

        private void botaoPesquisarSQL_Click(object sender, EventArgs e)
        {
			

            listaLivroSQL = conector.Pesquisa_Livro(pesquisaLivroSQL.Text.ToLower(), modoPesquisaSQL.SelectedIndex);
            updateDislay_LivrosSQL();
        }
	}
}
