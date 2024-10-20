using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc_Tests.Domain.Alunos.ValueObjects
{
    public class Nota
    {
        public Nota(float valor) {
            Valor = valor;
        }

        [Required]
        public float Valor {  get; private set; }
    }
}
