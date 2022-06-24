using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Extensions
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; private set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, DateTime dataNascimento, decimal salario)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Salario = salario;
        }
    }
}
