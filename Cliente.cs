using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBanco
{
    public class Cliente
    {
        public string  Nome { get; set; }
        public string  CPF { get; set; }
        public string  Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
        public List<Transacao> Extrato { get; set; } 
        public Cliente()
        {
            Extrato = new List<Transacao>(); 
        }
        public Cliente(string nome, string telefone, string endereco, DateTime datanascimento, int numero, string cpf, string email) : this()
        {
            Nome = nome; 
            Telefone = telefone; 
            Endereco = endereco; 
            DataNascimento = datanascimento; 
            NumeroConta = numero; 
            CPF = cpf; 
            Email = email; 
        }
        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays/365.25));} set{} }

        public string ResumoCliente(){
           return $"{Nome} {CPF} {Email}"; 
        }
        public bool EhMaior(){
        
        return Idade >=18; 
        }
        }
    }
