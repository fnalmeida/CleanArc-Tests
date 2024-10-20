using CleanArc_Tests.Domain.Alunos.Exceptions;
using CleanArc_Tests.Domain.Alunos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc_Tests.Domain.Alunos.Entities
{
    public class Aluno
    {
        public Aluno(string nome, DateOnly nascimento)
        {
            ID = Guid.NewGuid(); 
            Nome = nome;
            Nascimento = nascimento;
        }

        public Guid ID;
        public string Nome { get; private set; }
        public DateOnly Nascimento { get; private set; }

        public string VerificarAprovacao(Nota nota1, Nota nota2)
        {
            double somaDasNotas = (nota1.Valor + nota2.Valor) / 2;

            if (somaDasNotas < 3)
                throw new NaoAprovadoException();
            else if (somaDasNotas >= 3 & somaDasNotas < 7)
                throw new EmRecuperacaoException();
            else
                return "Aprovado";

        }
    }
}
