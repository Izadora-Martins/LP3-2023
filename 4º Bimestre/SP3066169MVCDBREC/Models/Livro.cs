namespace SP3066169MVCDBREC.Models;

public class Livro
{
    public int IdLivro { get; set; }
    public string ISBNLivro { get; set; }
    public string TituloLivro { get; set; }
    public string PrecoLivro { get; set; }
    public string CategoriaLivro { get; set; }
    public int IdEditora { get; set; }
    
    public Livro() { }
    public Livro(int idlivro, string isbnlivro, string titulolivro, string precolivro, string categorialivro, int ideditora)
    {
        IdLivro = idlivro;
        ISBNLivro = isbnlivro;
        TituloLivro = titulolivro;
        PrecoLivro = precolivro;
        CategoriaLivro = categorialivro;
        IdEditora = ideditora;
    }
}