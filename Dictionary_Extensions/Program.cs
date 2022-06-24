using System;
using System.Globalization;
using System.IO;

namespace Dictionary_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo;
            Console.WriteLine("Digite o caminho completo do arquivo desejado: ");
            Console.WriteLine("OBS: A data deve estar em formato dd/MM/yyyy");
            arquivo = Console.ReadLine();
          

            GerenciadorFuncionarios gerenciador = new GerenciadorFuncionarios(new RegistroEmArquivos(arquivo));

            try
            {
                gerenciador.ImprimeFuncionarios();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine();
                Console.WriteLine($"Arquivo nao encontrado: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
