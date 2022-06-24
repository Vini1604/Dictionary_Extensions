using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dictionary_Extensions
{
    class GerenciadorFuncionarios
    {
        private IRegistro _tipoRegistro;
        private Dictionary<int, string> _funcionariosNomeDictionary = new Dictionary<int, string>();
        private Dictionary<int, DateTime> _funcionariosNascimentoDictionary = new Dictionary<int, DateTime>();

        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
        public GerenciadorFuncionarios()
        {

        }

        public GerenciadorFuncionarios(IRegistro tipoRegistro)
        {
            _tipoRegistro = tipoRegistro;
        }


        public void ImprimeFuncionarios()
        {
            Funcionarios = _tipoRegistro.ListarFuncionarios();


            Console.WriteLine();
            if (Funcionarios.Count == 0)
            {
                Console.WriteLine("Nao ha funcionarios a serem listados!!");
            }
            else
            {
                PopulaDictionary();
                Console.WriteLine();
                Console.WriteLine("Id ".PadRight(10) + " Nome ".PadRight(30) + " Data de Nascimento por extenso ".PadRight(30));
                foreach (KeyValuePair<int, string> nomeFuncionario in _funcionariosNomeDictionary)
                {
                    Console.WriteLine($"{nomeFuncionario.Key,-10} {nomeFuncionario.Value, -30} {_funcionariosNascimentoDictionary[nomeFuncionario.Key].MesEmExtensoPtBR(), -30}");
                }
            }

        }

        public void PopulaDictionary()
        {
            foreach (Funcionario funcionario in Funcionarios)
            {
                _funcionariosNomeDictionary.Add(funcionario.Id, funcionario.Nome);
                _funcionariosNascimentoDictionary.Add(funcionario.Id, funcionario.DataNascimento);
            }
        }
    }
}
