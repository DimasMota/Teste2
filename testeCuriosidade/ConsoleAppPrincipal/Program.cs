using DLL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            try
            {
                
                Usuario usuario = new Usuario();
                usuario.Nome = "Dimas Martins Mota";
                usuario.CPF = "111.111.111-11";
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBLL.Inserir(usuario);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Tem algo errado se vira", ex.Message);
            }
          
        }
    }
}