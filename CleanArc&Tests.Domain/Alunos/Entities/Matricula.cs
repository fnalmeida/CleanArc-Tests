using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc_Tests.Domain.Alunos.Entities
{
    public class Matricula
    {
        public Matricula(Aluno aluno, Disciplina disciplina) {

            Id = new Guid();
            Aluno = aluno;
            Disciplina = disciplina;
            DataMatricula = DateTime.Now;
        
        }

        public Guid Id { get; set; }
        public Aluno Aluno { get; private set; }
        public Disciplina Disciplina { get; private set; }
        public DateTime DataMatricula { get; private set; }
    }
}
