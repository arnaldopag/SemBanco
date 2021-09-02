namespace sembanco.Models
{
    public  static class Banco
    {
        public static Conta newCliente { get; set; }
        static Banco()
        {
            newCliente = new Conta();
        }
       
    }
}