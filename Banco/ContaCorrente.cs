using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;


    public class ContaCorrente
{
    public int agencia = 0;
    public string conta = "";
    public string nome = "";
    public double saldo = 0.0;
    public double ValorTransferencia = 0.0;

    public void Depositar(double valor)
    {
        this.saldo += valor;
        
    }
    
    public bool Sacar(double valor) // bool verifica se verdadeiro ou falso
    {
        if (this.saldo >= valor) // verifica
        {
            this.saldo -= valor;
            return true; // verdadeiro
        }
        else
        {
            Console.WriteLine("saldo insuficiente para realizar o saque.");
            return false; //falso
        }

                 
       
    }
    public bool Transferir (double valor,ContaCorrente Destino)
    {
        if (this.saldo >= valor)
        {
            ValorTransferencia = valor;
            this.saldo -= valor;
            Destino.saldo= valor;
            return true;
            
        }
        else 
        {
            Console.WriteLine("Transferência não foi realizado");
            return false;
        }
    }
}


   
