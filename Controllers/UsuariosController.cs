using Microsoft.AspNetCore.Mvc;

namespace HolaMundo.Controllers{
    public class UsuariosController:Controller{
        public IActionResult Index(){
            return View();
        }
    }
}