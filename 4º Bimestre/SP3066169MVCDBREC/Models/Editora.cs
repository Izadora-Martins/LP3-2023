namespace SP3066169MVCDBREC.Models;

public class Editora
{
    public int IdEditora { get; set; }
    public string NomefantasiaEditora { get; set; }
    public string RazaoSocialEditora { get; set; }
    public string EnderecoEditora { get; set; }
    public string TelefoneEditora { get; set; }
    
    public Editora() { }
    public Editora(int ideditora, string nomefantasiaeditora, string razaosocialeditora, string enderecoeditora, string telefoneeditora)
    {
        IdEditora = ideditora;
        NomefantasiaEditora = nomefantasiaeditora;
        RazaoSocialEditora = razaosocialeditora;
        EnderecoEditora = enderecoeditora;
        TelefoneEditora = telefoneeditora;
    }
}