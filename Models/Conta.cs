using System.Collections.Generic;

namespace sembanco.Models
{
    public class Conta
    {
        private static List<Cliente> listaCliente = new List<Cliente>();
        private static List<Candidato> listaCandidatos = new List<Candidato>();
        public static List<Contato> listaContatos = new List<Contato>();
        public void cadastroCliente(Cliente novoCliente)
        {
            listaCliente.Add(novoCliente);
        }

        public List<Cliente> mostrar()
        {
            return listaCliente;
        }
        public double Sacar(Cliente setSaldo,double valorSaque)
        {
            if (valorSaque > setSaldo.Saldo){
                return -1;
            }
            double saldoFinal = setSaldo.Saldo - valorSaque;
            return saldoFinal;
        }
        
        public double Depositar(Cliente setSaldo, double valorDeposito)
        {
            return  setSaldo.Saldo + valorDeposito;
        }

        public void cadastroCandidato(Candidato trabalhador)
        {
            listaCandidatos.Add(trabalhador);
        }
        public void cadastroContato(Contato novoContato)
        {
            listaContatos.Add(novoContato);
        }
    }
}