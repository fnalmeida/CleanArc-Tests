using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc_Tests.Domain.Alunos.Entities
{
    public class Disciplina
    {
        public Disciplina(string nome) {
        
            Id = Guid.NewGuid();
            if (!String.IsNullOrEmpty(nome))
                Nome = nome;
            else
                throw new ArgumentException("Nome is null");

        }

        public Guid Id { get;  private set; }
        
        public string Nome { get; private set; }


    }
}
