using Microsoft.AspNetCore.Mvc;
using SP3066169MVCDBREC.Models;
namespace SP3066169MVCDBREC.Controllers;

public class LivroController : Controller
{
    private readonly MvcDBContext _context;

    public LivroController(MvcDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Livro);
    }

    public IActionResult Show(int idlivro)
    {
        Livro? livro = _context.Livro.Find(idlivro);

        if (livro == null)
        {
            return NotFound();
        }
        return View(livro);
    }
}