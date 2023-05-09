using Classes;

var futebol = new Futebol("Futebol", 0);
futebol.EfetuarTransacao(20, DateTime.Now, "bola");
futebol.EfetuarTransacao(50, DateTime.Now, "Chuteira");
futebol.ExecutarTransacaoFimdeMes();
Console.WriteLine(futebol.ObterHistoricodeConta());

var alimentacao = new Alimentacao("Alimentacao", 0);
alimentacao.EfetuarTransacao(20, DateTime.Now, "Café");
alimentacao.EfetuarTransacao(50, DateTime.Now, "Compra de Mantimentos");
alimentacao.ExecutarTransacaoFimdeMes();
Console.WriteLine(alimentacao.ObterHistoricodeConta());


var vestuario = new Vestuario("Vestuario", 0);
vestuario.EfetuarTransacao(100, DateTime.Now, "Agasalho");
vestuario.EfetuarTransacao(50, DateTime.Now, "Calça");
vestuario.EfetuarTransacao(250, DateTime.Now, "Terno");
vestuario.ExecutarTransacaoFimdeMes();
Console.WriteLine(vestuario.ObterHistoricodeConta());

var laser = new Laser("Laser", 0);
laser.EfetuarTransacao(200, DateTime.Now, "Cinema");
laser.ExecutarTransacaoFimdeMes();
Console.WriteLine(laser.ObterHistoricodeConta());



    
   
