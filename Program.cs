using TesteBanco; 
string opcao;
List<Cliente> clientes = new List<Cliente>();  
clientes.Add(new Cliente("larissa", "1", "rua", new DateTime(2002,5,15), 1, "0", "meuemail")); 
clientes.Add(new Cliente("lucas", "2", "casa", new DateTime(1992,5,15), 2, "1", "doismail")); 
clientes.Add(new Cliente("carlos", "3", "rua", new DateTime(1993,5,15), 3, "2", "tresemail")); 
clientes.Add(new Cliente("erico", "4", "rua", new DateTime(1994,5,15), 4, "3", "ddddemail")); 
do {
Console.WriteLine("Bem-vindo ao banco CODex, escolha a opção desejada"); 
Console.WriteLine("1- Criar conta"); 
Console.WriteLine("2- Adicionar transação"); 
Console.WriteLine("3-Consultar extrato"); 
Console.WriteLine("4-Sair");
Console.WriteLine("5-Exibir clientes"); 
opcao = Console.ReadLine(); 
if (opcao=="1") { 
CriarConta(); 
}
else if (opcao =="5"){
  ExibirClientes(); 
}
else if (opcao =="2"){
  AdicionarTransacao(); 
}
} while (opcao !="3"); 

Console.WriteLine("Tecle Enter para continuar"); 
Console.ReadLine(); 

void AdicionarTransacao(){
Console.WriteLine("Qual a conta"); 
int numeroConta = int.Parse(Console.ReadLine()); 

Cliente contaCliente=null;  
foreach (var cliente in clientes) {
  if (cliente.NumeroConta == numeroConta) {
   contaCliente = cliente; 
    break; 
  }
  if(contaCliente== null) {
    Console.WriteLine("Conta não cadastrada, cadastre primeiro"); 
    return ; 
  }
}
Console.WriteLine("Qual o valor da transação?"); 
double valor = double.Parse(Console.ReadLine()); 
Transacao transacao = new Transacao(); 
transacao.Hora = DateTime.Now; 
transacao.Valor = valor; 
contaCliente.Extrato.Add(transacao); 
}

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

