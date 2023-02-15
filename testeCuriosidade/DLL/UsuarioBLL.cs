using Models;
using DAL;

namespace DLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
           

            if (_usuario.CPF.Length != 14)
            {
                throw new Exception("CPF Incorreto 000.000.000-00.");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
        }

        public void Alterar(Usuario _usuario)
        {

        }
    }
}