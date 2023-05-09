namespace Classes;
public class Alimentacao : Gastos
{
 public Alimentacao(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margemSeguranca = (ValorAcumulado * 0.01m);
        EfetuarTransacao(margemSeguranca, DateTime.Now, "Margem de Segurança para Educação");
    }
    
}
