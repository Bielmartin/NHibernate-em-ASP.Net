using Modelo;
using Modelo.Componentes;
using Modelo.Repositorios;

namespace ComponenteNegocio
{
    public class ComponenteNegocioUsuario : IComponenteNegocioUsuario
    {
        private IBancoContext _bancoContext;

        public ComponenteNegocioUsuario(IBancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Usuario? ListarPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            return _bancoContext.Usuario!.FirstOrDefault(x => x.Id == id);
        }

        public Usuario? Adicionar(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new InvalidOperationException("Houve um erro ao cadastrar o usuário!");
            }
            _bancoContext.Usuario!.Add(usuario);
            _bancoContext.SaveChanges();

            return usuario;
        }

        public List<Usuario>? BuscarTodos()
        { 
            // ! (define que o tipo não poderá ser nulo)
            return _bancoContext.Usuario!.ToList();
        }

        public Usuario? Atualizar(Usuario usuario)
        {
            Usuario? usuarioDB = ListarPorId(usuario.Id);

            if (usuarioDB == null)
            {
                throw new InvalidOperationException("Houve um erro na atualização do contato!");
            }

            usuarioDB.Nome = usuario.Nome;
            usuarioDB.CNPJ = usuario.CNPJ;

            _bancoContext.Usuario!.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public bool Apagar(int id)
        {
            Usuario? usuarioDB = ListarPorId(id);

            if (usuarioDB == null)
            {
                throw new InvalidOperationException("Houve um erro na hora de deletar o usuário!");
            }

            _bancoContext.Usuario!.Remove(usuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}