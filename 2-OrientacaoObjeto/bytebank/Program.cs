using bytebank;

Console.WriteLine("Seja bem vindo ao Bytebank");
ContaCorrente contaAndre = new ContaCorrente();

contaAndre.titular = "André";
contaAndre.conta = "1010-X";
contaAndre.agencia = 15;
contaAndre.saldo = 100.00;

Console.WriteLine($"O saldo da conta do {contaAndre.titular} = R${contaAndre.saldo}");

contaAndre.Depositar(100);

Console.WriteLine($"O saldo da conta do {contaAndre.titular} pos Deposito = R${contaAndre.saldo}");

if (contaAndre.Sacar(200))
{
    Console.WriteLine($"O saldo da conta do {contaAndre.titular} pos Saque = R${contaAndre.saldo}");

}
else {
    Console.WriteLine("Saldo insuficiente para saque! ");
}

Console.ReadKey();