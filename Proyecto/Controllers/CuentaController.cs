using Proyecto.Data;
using Proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class CuentaController : Controller
    {
        private readonly AppDbContext _context;


        public CuentaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            else
            {
                return View(usuario);
            }
        }
    }
}