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
            ID = new Guid(); 
            Nome = nome;
            if (nascimento < new DateOnly(2000, 01, 01))
                throw new VelhoDimaisException();
            else
            Nascimento = nascimento;
        }

        public Guid ID;
        public string Nome { get; private set; }
        public DateOnly Nascimento { get; private set; }

        public string VerificarAprovacao(Nota nota1, Nota nota2)
        {
            float somaDasNotas = nota1.Valor + nota2.Valor;

            if (somaDasNotas < 3)
                throw new NaoAprovadoException();
            else if (somaDasNotas >= 3 & somaDasNotas < 7)
                throw new EmRecuperacaoException();
            else
                return "Aluno aprovado";

        }
    }
}
