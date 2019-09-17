using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_Alunos
{
    class Livros
    {
        public string Titulo { set; get; }
        public string Autor { set; get; }
        public string    ID { set; get; }

        public Livros()
        {
            Titulo = "";
            Autor = "";
            ID = "";
        }

        public Livros(string titulo, string autor, string id)
        {
            Titulo = titulo;
            Autor = autor;
            ID = id;
        }

        public override string ToString()
        {
            return Titulo + ", " + Autor + " - " + ID;
        }
    }
}
