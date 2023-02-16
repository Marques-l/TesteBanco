using TesteBanco; 
Cliente CriarConta(){
  Cliente cliente = new Cliente(); 

  Console.WriteLine("Qual o nome do cliente?"); 
  cliente.Nome=Console.ReadLine(); 

  Console.WriteLine("Qual o CPF cliente?"); 
  cliente.CPF=Console.ReadLine();

  Console.WriteLine("Qual o email do cliente?"); 
  cliente.Email=Console.ReadLine();

  Console.WriteLine("Qual o telefone do cliente?"); 
  cliente.Telefone=Console.ReadLine();

  Console.WriteLine("Qual o endereço do cliente?"); 
  cliente.Endereco=Console.ReadLine();

  Console.WriteLine("Qual a data de nascimento do cliente?"); 
  cliente.DataNascimento=DateTime.Parse(Console.ReadLine());

  Console.WriteLine("Qual o número da conta do cliente?"); 
  cliente.NumeroConta=int.Parse(Console.ReadLine());

  Console.WriteLine("Qual o saldo do cliente?"); 
  cliente.Saldo=double.Parse(Console.ReadLine());
  return cliente; 
}
string opcao; 
do {
Console.WriteLine("Bem-vindo ao banco CODex, escolha uma opção"); 
Console.WriteLine("1- Criar conta"); 
Console.WriteLine("2- Adicionar transação"); 
Console.WriteLine("3-Consultar extrato"); 
Console.WriteLine("4-Sair"); 
opcao = Console.ReadLine(); 
if (opcao=="1") {
Cliente novoCliente = CriarConta(); }
} while (opcao !="3"); 
