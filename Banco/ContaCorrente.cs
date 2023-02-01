using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ContaCorrente
{
    public int agencia = 0;
    public string conta = "";
    public string nome = "";
    public double saldo = 0.0;

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    
    public void Sacar(double  valor) 
    {
        this.saldo -= valor;
    }
}

   
