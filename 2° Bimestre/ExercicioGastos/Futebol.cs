namespace Classes;
public class Futebol: Gastos
{
     public Futebol(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margemSeguranca = (ValorAcumulado * 0.01m);
        EfetuarTransacao(margemSeguranca, DateTime.Now, "Margem de Segurança para Futebol");
    }
}
