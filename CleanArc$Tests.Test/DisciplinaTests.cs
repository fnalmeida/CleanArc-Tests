using CleanArc_Tests.Domain.Alunos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc_Tests.Test
{
    public class DisciplinaTests
    {
        [Fact]
        public void Criar_NovaDisciplina()
        {
            var disciplina = new Disciplina("Matematica");
            Assert.NotNull(disciplina);
        }
    }
}
