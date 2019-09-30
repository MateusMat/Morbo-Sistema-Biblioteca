using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Forma_Alunos
{
    class MySQL_Conector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public MySQL_Conector()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "biblioteca";
            uid = "root";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void inserirLivro(string titulo, string autor, string editora, string edicao, string ano)
        {
            string query = "select biblioteca.inserir_Livro('" + titulo + "', '"
                            + autor + "', '" + editora + "', " + edicao + ", " + ano + ")";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        public List<Livros> Pesquisa_Livro(string busca, int tipo)
        {
            string comando = "SELECT livro.idLivro, livro.titulo, autor.nome as autorNome, editora.nome as editoraNome, livro.edicao, livro.ano FROM livro " +
							 "INNER JOIN autor ON (livro.idAutor = autor.idAutor) INNER JOIN editora ON (livro.idEditora = editora.idEditora) ";

            switch (tipo)
            {
                case 0:
                    comando +=	"WHERE livro.titulo LIKE '%" + busca + "%'";
					break;
				case 1:
					comando +=	"WHERE livro.idAutor IN (SELECT autor.idAutor FROM autor WHERE nome LIKE '%" + busca + "%')";
					break;
				case 2:
					comando += "WHERE livro.idEditora IN (SELECT editora.idEditora FROM editora WHERE nome LIKE '%" + busca + "%')";
					break;
				case 3:
					comando += "WHERE (livro.titulo LIKE '%" + busca + "%' OR livro.idAutor IN (SELECT autor.idAutor FROM autor WHERE nome LIKE '%" + busca + "%') OR livro.idEditora IN (SELECT editora.idEditora FROM editora WHERE nome LIKE '%" + busca + "%'))";
					break;
				default:
					return null;
            }
            
            //Create a list to store the result
            List<Livros> lista = new List<Livros> ();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(comando, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

				//MessageBox.Show (dataReader. .ToString());

                while (dataReader.Read())
                {
                    lista.Add(new Livros("" + dataReader["idLivro"], "" + dataReader["titulo"], "" + dataReader["autorNome"], "" + dataReader["editoraNome"], "" + dataReader["edicao"], "" + dataReader["ano"]));
                }

                    //close Data Reader
                    dataReader.Close();

                //close Connection
                this.CloseConnection();
            }

			return lista;
		}

        ////Count statement
        //public int Count()
        //{
        //}

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
