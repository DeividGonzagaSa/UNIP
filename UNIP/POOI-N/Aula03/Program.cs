//objeto

using Financeiro;

do
{
  Console.WriteLine("Bem vindo ao sistema para gerenciamento de clientes: ");
  Console.WriteLine("Selecione uma das opções abaixo: ");
  Console.WriteLine("Para criar conta tecle 1. ");
  Console.WriteLine("Para realizar um deposito tecle 2. ");
  Console.WriteLine("Para fazer um saque tecle 3. ");
  Console.WriteLine("Consultar saldo tecle 4. ");
  Console.WriteLine("Para sair tecle 0. ");

  int opcao = Convert.ToInt32(Console.ReadLine());
  ContaBancaria conta = new();
  switch (opcao)
  {
    case 1:


      Console.WriteLine("Digite o nome do titular da conta: ");
      conta.Titular = Console.ReadLine();
      Console.WriteLine("Digite o número da agência: ");
      conta.Agencia = Console.ReadLine();
      Console.WriteLine("Digite o número da conta: ");
      conta.Numero = Console.ReadLine();
      conta.EstaAtiva = true;
      conta.Banco = 12121;

      Console.WriteLine("O titular desta conta é:" + conta.Titular);
      Console.WriteLine("O numero da conta é:" + conta.Numero);
      Console.WriteLine("A agencia é:" + conta.Agencia);
      Console.WriteLine("O numero da banco é:" + conta.Banco);
      Console.WriteLine("O saldo disponivel é de:" + conta.Saldo);
      break;

    case 2:
      Console.WriteLine("Digite o valor do depósito: ");
      double deposito = Convert.ToDouble(Console.ReadLine());

      conta.Depositar((float)deposito);

      Console.WriteLine("O novo saldo em conta é: " + conta.Saldo);
      break;
    case 3:
      Console.WriteLine("Quanto deseja sacar?: ");

      double saque = Convert.ToDouble(Console.ReadLine());
      if ((float)saque >= conta.Saldo)
      {
        Console.WriteLine("Saldo insuficiente!");

      }
      else
      {
        conta.sacar((float)saque);

        Console.WriteLine("O novo saldo em conta é: " + conta.Saldo);

      }

      conta.sacar((float)saque);

      Console.WriteLine("O novo saldo em conta é: " + conta.Saldo);
      break;

    case 4:
      Console.WriteLine("O saldo em conta é: " + conta.Saldo);
      break;
    default:
      Console.WriteLine("Selecione uma opção valida");
      break;
  }
} while()




