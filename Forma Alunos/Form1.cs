﻿using System;
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

namespace Forma_Alunos
{
    public partial class Sistema : Form
    {
        //Teste

        private List<Aluno> listaAlunos = new List<Aluno>();
        private List<Livros> listaLivros = new List<Livros>();

        public Sistema()
        {
            InitializeComponent();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            loadAlunos();
        }

        private void Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveAlunos();
        }

        private void saveAlunos()
        {
            StreamWriter sA = new StreamWriter("Alunos.txt");

            for (int i = 0; i < listaAlunos.Count; i++)
            {
                sA.WriteLine(listaAlunos[i]);
            }
            sA.Close();

            StreamWriter sL = new StreamWriter("Livros.txt");

            for (int i = 0; i < listaLivros.Count; i++)
            {
                sL.WriteLine(listaLivros[i]);
            }
            sL.Close();
        }

        private void loadAlunos()
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

            StreamReader lL = new StreamReader("Livros.txt");

            while (!lL.EndOfStream)
            {
                string temp = lL.ReadLine();
                Livros obj = new Livros(temp.Substring(0, temp.IndexOf(',')) , temp.Substring(temp.IndexOf(',') + 2, temp.IndexOf('-') - temp.IndexOf(',') - 3) , temp.Substring(temp.IndexOf('-') + 2));

                listaLivros.Add(obj);
            }
            updateDisplayLivros();
            lL.Close();
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

        }

        private void textName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCadastrarAlunos.PerformClick();
            }
        }

        private void textRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsDigit) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textRA_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCadastrarAlunos.PerformClick();
            }
        }



        //******************************//
        // Referente a Cadastrar Livros //
        //******************************//

        private void updateDisplayLivros()
        {
            displayLivros.Items.Clear();

            for (int i = 0; i < listaLivros.Count; i++)
            {
                displayLivros.Items.Add(listaLivros[i]);
            }
        }

        private void buttonCadastrarLivros_Click(object sender, EventArgs e)
        {
            if (textTitulo.Text.Count() > 0 && textAutor.Text.Count() > 0)
            {
                Livros obj = new Livros(textTitulo.Text, textAutor.Text, textID.Text);

                listaLivros.Add(obj);
                updateDisplayLivros();
            }
        }

        private void textTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetter) || e.KeyChar.ToString().All(char.IsSeparator) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCadastrarLivros.PerformClick();
            }
        }

        private void textAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetter) || e.KeyChar.ToString().All(char.IsSeparator) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textAutor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCadastrarLivros.PerformClick();
            }
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsDigit) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCadastrarLivros.PerformClick();
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
                }
            }
        }

        private void textPesquisaRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsDigit) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textPesquisaRA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisarAluno.PerformClick();
            }
        }

        private void textPesquisaNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetter) || e.KeyChar.ToString().All(char.IsSeparator) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textPesquisaNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisarAluno.PerformClick();
            }
        }

        //*****************//
        // Pesquisar Livro //
        //*****************//

        private void pesquisarLivro_Click(object sender, EventArgs e)
        {
            displayPesquisaLivro.Items.Clear();

            for (int i = 0; i < listaLivros.Count; i++)
            {
                if (listaLivros[i].Autor.Contains(textPesquisaAutor.Text) && listaLivros[i].Titulo.Contains(textPesquisaTitulo.Text))
                {
                    displayPesquisaLivro.Items.Add(listaLivros[i]);
                }
            }
        }

        private void textPesquisaAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetter) || e.KeyChar.ToString().All(char.IsSeparator) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textPesquisaAutor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pesquisarLivro.PerformClick();
            }
        }

        private void textPesquisaTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetter) || e.KeyChar.ToString().All(char.IsSeparator) || e.KeyChar.ToString().All(char.IsControl)))
            {
                e.Handled = true;
            }
        }

        private void textPesquisaTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pesquisarLivro.PerformClick();
            }
        }



        //*******************//


    }
}