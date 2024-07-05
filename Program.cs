namespace CadastroPessoa
{
    class Program
    {
        static void Main()
        {
            UsuarioLogin dadosTelaPrincipal = new UsuarioLogin();
            dadosTelaPrincipal.TelaDeLogin();
            dadosTelaPrincipal.CadastroLogin();
            
            Console.ReadLine();
        }
    }
}
