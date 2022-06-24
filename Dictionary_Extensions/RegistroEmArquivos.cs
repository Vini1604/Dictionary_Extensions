using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Dictionary_Extensions
{
    class RegistroEmArquivos : IRegistro
    {
        public string Arquivo { get; set; }
        private List<Funcionario> _funcionarios = new List<Funcionario>();

        public RegistroEmArquivos()
        {

        }

        public RegistroEmArquivos(string arquivo)
        {
            Arquivo = arquivo;
        }

        public List<Funcionario> ListarFuncionarios()
        {
            ExtrairFuncionarios();
            return _funcionarios;
        }

        private void ExtrairFuncionarios()
        {
            try
            {
                using (StreamReader listaFuncionarios = File.OpenText(Arquivo))
                {
                    listaFuncionarios.ReadLine();
                    while (!(listaFuncionarios.EndOfStream))
                    {
                        string[] registroFuncionario = listaFuncionarios.ReadLine().Split(";");
                        Funcionario funcionario = GerarFuncionario(registroFuncionario);
                        _funcionarios.Add(funcionario);
                    }
                }
            }
            catch (FormatException e)
            {

                Console.WriteLine();
                Console.WriteLine($"Nao e possivel ler o arquivo informado: {e.Message}");
            }
        }
        private Funcionario GerarFuncionario(string[] registroFuncionario)
        {
            int id = int.Parse(registroFuncionario[0]);
            string nome = registroFuncionario[1];
            DateTime dataNascimento = registroFuncionario[2].DataEmPtBR();
            decimal salario = decimal.Parse(registroFuncionario[3]);
            Funcionario funcionarioExistente = _funcionarios.Find(x => x.Id == id);

            if (funcionarioExistente != null)
            {
                throw new FormatException("Ha registros com mesmo ID");
            }
            else
            {
                return new Funcionario(id, nome, dataNascimento, salario);
            }
        }
    }
}
