namespace Classes;
public class Vestuario : Gastos
{
      private readonly decimal _bonusVestuario = 50m;

    public Vestuario(string Cliente, decimal valorInicial, decimal bonusVestuario = 50) : base(Cliente, valorInicial)
   => _bonusVestuario = bonusVestuario;

    public override void ExecutarTransacaoFimdeMes()
    {
    decimal margem = (ValorAcumulado * 0.03m);
    EfetuarTransacao(margem, DateTime.Now, "Margem de Segurança para Vestuario");
    if (_bonusVestuario != 0)
    {
        EfetuarTransacao(-_bonusVestuario, DateTime.Now, "Bonus Vestuario");
    }
    }
}
