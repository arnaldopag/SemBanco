using System;

namespace sembanco.Models
{
    public class Cliente
    {
        private int id_cliente { get; set; }
        private string nome { get; set; }
        private string email { get; set; }
        private string fone { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private string cpf { get; set; }
        private string rg { get; set; }
        private double salario { get; set; }
        private DateTime dataNascimento { get; set; }
        private int numeroConta { get; set; }
        private int agencia { get; set; }
        private double saldo { get; set; }
        private double valorDeposito { get; set; }
        private double valorSaque { get; set; }

        public int NumeroConta
        {
            get => numeroConta;
            set => numeroConta = value;
        }
        public int Agencia
        {
            get => agencia;
            set => agencia = value;
        }
        public double Saldo
        {
            get => saldo;
            set => saldo = value;
        }
        public double ValorDeposito
        {
            get => valorDeposito;
            set => valorDeposito = value;
        }
        public double ValorSaque
        {
            get => valorSaque;
            set => valorSaque = value;
        }


        public int Id_cliente
        {
            get => id_cliente;
            set => this.id_cliente = value;
        }
        public string Nome
        {
            get => nome;
            set => this.nome = value;
        }
        public string Email
        {
            get => email;
            set => this.email = value;
        }
        public string Fone
        {
            get => fone;
            set => this.fone = value;
        }
        public string Login
        {
            get => login;
            set => this.login = value;
        }
        public string Senha
        {
            get => senha;
            set => this.senha = value;
        }
        public string Cpf
        {
            get => cpf;
            set => this.cpf = value;
        }
        public string Rg
        {
            get => rg;
            set => this.rg = value;
        }
        public double Salario
        {
            get => salario;
            set => this.salario = value;
        }
        public DateTime DataNascimento
        {
            get => dataNascimento;
            set => this.dataNascimento = value;
        }
    }
}