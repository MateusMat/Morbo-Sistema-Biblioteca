using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// teste 123
namespace Forma_Alunos
{
    struct LivroEmprestado
    {
        public DateTime DataImprestimo { get; set; }
        public DateTime? DataRetorno { get; set; }
        public int ID { get; set; }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public int RA { get; set; }
        public List<LivroEmprestado> Livros_Emprestados = new List<LivroEmprestado>();


        public Aluno()
        {
            Nome = "";
            RA = -1;
            Livros_Emprestados.Clear();
        }

        public Aluno(string nome, int ra)
        {
            Nome = nome;
            RA = ra;
            Livros_Emprestados.Clear();
        }

        public void emprestarLivro(int livroEmprestadoID)
        {
            LivroEmprestado temp = new LivroEmprestado();
            temp.ID = livroEmprestadoID;
            temp.DataImprestimo = DateTime.Now;
            temp.DataRetorno = null;

            Livros_Emprestados.Insert(0, temp);
        }

        public override string ToString()
        {
            return Nome + ", " + RA.ToString();
        }
    }

}
