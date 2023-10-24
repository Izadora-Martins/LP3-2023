using Microsoft.AspNetCore.Mvc;
using SP3066169MVCDBREC.Models;
namespace SP3066169MVCDBREC.Controllers;

public class EditoraController : Controller
{
    private readonly MvcDBContext _context;

    public EditoraController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Editora);
    }

    public IActionResult Show(int ideditora)
    {
        Editora? editora = _context.Editora.Find(ideditora);

        if (editora == null)
        {
            return NotFound();
        }
        return View(editora);
    }
}