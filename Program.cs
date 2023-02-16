using TesteBanco; 
string opcao;
List<Cliente> clientes = new List<Cliente>();  

do {
Console.WriteLine("Bem-vindo ao banco CODex, escolha uma opção"); 
Console.WriteLine("1- Criar conta"); 
Console.WriteLine("2- Adicionar transação"); 
Console.WriteLine("3-Consultar extrato"); 
Console.WriteLine("4-Sair");
Console.WriteLine("5-Exibir clientes"); 
opcao = Console.ReadLine(); 
if (opcao=="1") { 
CriarConta(); 
}
if (opcao =="5"){
  ExibirClientes(); 
}
} while (opcao !="3"); 

Console.WriteLine("Tecle Enter para continuar"); 
Console.ReadLine(); 

void ExibirClientes() {
  Console.WriteLine("Nome------------------CPF-------------------Email"); 
  for(int i = 0; i<clientes.Count; i++) 
  {
    Console.WriteLine(clientes[i].ResumoCliente()); 
  }
}

void CriarConta(){
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

  if(!cliente.EhMaior()){
    Console.WriteLine("Não é possível abrir a conta, requerente é menor de idade"); 
    return;
  }
  Console.WriteLine ($"A idade do cliente é {cliente.Idade}"); 
  Console.WriteLine("Qual o número da conta do cliente?"); 
  cliente.NumeroConta=int.Parse(Console.ReadLine());

  Console.WriteLine("Qual o saldo do cliente?"); 
  cliente.Saldo=double.Parse(Console.ReadLine());

   clientes.Add(cliente); ; 
}

