using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc_Tests.Domain.Alunos.Entities
{
    public class Disciplina
    {
        public Disciplina(string nome) {
        
            Nome = nome;    

        }

        public Guid Id { get;  private set; }
        public string Nome { get; private set; }


    }
}
