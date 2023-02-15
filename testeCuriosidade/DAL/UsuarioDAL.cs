using Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Usuario(Nome, CPF)" +
                                  "VALUES (@nome,@cpf)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@nome", _usuario.Nome);
                
                cmd.Parameters.AddWithValue("@cpf_Usuario", _usuario.CPF);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }


        }

        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
        }
        public void Alterar(Usuario _usuario)
        {

        }

        public void Excluir(int _id)
        {

        }
    }
    
}
