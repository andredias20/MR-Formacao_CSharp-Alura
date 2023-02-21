using bytebank;

Console.WriteLine("Seja bem vindo ao Bytebank");
ContaCorrente contaAndre = new ContaCorrente();

contaAndre.titular = "André";
contaAndre.conta = "1010-X";
contaAndre.agencia = 15;
contaAndre.saldo = 1000.00;

Console.WriteLine(contaAndre);

//Console.WriteLine($"O saldo da conta do {contaAndre.titular} = R${contaAndre.saldo}");

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Souza";
//contaMaria.agencia = 17;
//contaMaria.conta = "1010-5";
//contaMaria.saldo = 350;

//Console.WriteLine($"O saldo da conta do {contaMaria.titular} = R${contaMaria.saldo}");

/*// Teste Deposito

contaAndre.Depositar(100);

Console.WriteLine($"O saldo da conta do {contaAndre.titular} Pos-Deposito = R${contaAndre.saldo}");
*/

/* // Teste Saque
 * if (contaAndre.Sacar(200))
{
    Console.WriteLine($"O saldo da conta do {contaAndre.titular} Pos-Saque = R${contaAndre.saldo}");
}
else {
    Console.WriteLine("Saldo insuficiente para saque! ");
}*/

/* // Teste de Transferencia
if (contaAndre.Transferir(100, contaMaria)) 
    Console.WriteLine("Transferencia realizada...");

Console.WriteLine($"O saldo da conta do {contaAndre.titular} = R${contaAndre.saldo}");
Console.WriteLine($"O saldo da conta do {contaMaria.titular} = R${contaMaria.saldo}");
*/

Console.ReadKey();