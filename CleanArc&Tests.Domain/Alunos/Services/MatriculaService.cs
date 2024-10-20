using CleanArc_Tests.Domain.Alunos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc_Tests.Domain.Alunos.Services
{
    public class MatriculaService
    {

        public Matricula MatricularAluno(Aluno aluno, Disciplina disciplina)
        {
            return new Matricula(aluno, disciplina);    
        }
    }
}
