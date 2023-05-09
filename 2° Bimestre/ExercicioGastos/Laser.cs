namespace Classes;
public class Laser : Gastos
{
   public Laser(string nome, decimal valorInicial) : base(nome, valorInicial)
    {
    }
    public override void ExecutarTransacaoFimdeMes()
    {
        decimal margemSeguranca = (ValorAcumulado * 0.02m);
        EfetuarTransacao(margemSeguranca, DateTime.Now, "Margem de Segurança para lazer");
    }
    
}
