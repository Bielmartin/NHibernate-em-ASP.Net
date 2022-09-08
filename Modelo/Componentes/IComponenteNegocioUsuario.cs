namespace Modelo.Componentes
{
    public interface IComponenteNegocioUsuario
    {
        Usuario? ListarPorId(int id);
        List<Usuario>? BuscarTodos();
        Usuario? Adicionar(Usuario usuario);
        Usuario? Atualizar(Usuario usuario);
        bool Apagar(int id);
    }
}
