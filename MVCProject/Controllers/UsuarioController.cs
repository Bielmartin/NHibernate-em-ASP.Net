using ComponenteNegocio;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Modelo.Componentes;

namespace SiteDeCadastro.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IComponenteNegocioUsuario _usuarioComponente;

        public UsuarioController(IComponenteNegocioUsuario usuarioComponente)
        {
            _usuarioComponente = usuarioComponente;
        }

        public IActionResult Index()
        {
            List<Usuario>? usuarios = _usuarioComponente.BuscarTodos();

            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            Usuario? usuario = _usuarioComponente.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            Usuario? usuario = _usuarioComponente.ListarPorId(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id)
        {
            _usuarioComponente.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _usuarioComponente.Adicionar(usuario);
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _usuarioComponente.Atualizar(usuario);
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
