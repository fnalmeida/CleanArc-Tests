using Bogus;
using CleanArc_Tests.Domain.Alunos.Entities;
using CleanArc_Tests.Domain.Alunos.Exceptions;
using CleanArc_Tests.Domain.Alunos.ValueObjects;
using Moq;

namespace CleanArc_Tests.Test
{
    public class AlunoTests
    {
        [Fact]
        public void Verifica_Aluno_Aprovado_Com_NotaMaxima()
        {
            var  alunoFake = new Faker<Aluno>();
            alunoFake.CustomInstantiator(fake => new Aluno(fake.Person.FullName, DateOnly.FromDateTime(fake.Person.DateOfBirth)));
            var aluno = alunoFake.Generate();

            var nota1 = new Faker<Nota>().CustomInstantiator( x => new Nota(10)).Generate();
            var nota2 = new Faker<Nota>().CustomInstantiator(x => new Nota(10)).Generate();

            Assert.Equal("Aprovado", aluno.VerificarAprovacao(nota1, nota2));
        }

        [Fact]
        public void Verifica_Aluno_Aprovado_Na_Media()
        {
            var alunoFake = new Faker<Aluno>();
            alunoFake.CustomInstantiator(fake => new Aluno(fake.Person.FullName, DateOnly.FromDateTime(fake.Person.DateOfBirth)));
            var aluno = alunoFake.Generate();

            var nota1 = new Faker<Nota>().CustomInstantiator(x => new Nota(7)).Generate();
            var nota2 = new Faker<Nota>().CustomInstantiator(x => new Nota(7)).Generate();

            Assert.Equal("Aprovado", aluno.VerificarAprovacao(nota1, nota2));
        }

        [Fact]
        public void Verifica_Aluno_EmRecuperacao()
        {
            var alunoFake = new Faker<Aluno>();
            alunoFake.CustomInstantiator(fake => new Aluno(fake.Person.FullName, DateOnly.FromDateTime(fake.Person.DateOfBirth)));
            var aluno = alunoFake.Generate();

            var nota1 = new Faker<Nota>().CustomInstantiator(x => new Nota(6)).Generate();
            var nota2 = new Faker<Nota>().CustomInstantiator(x => new Nota(7)).Generate();

            Assert.Throws<EmRecuperacaoException>( () => aluno.VerificarAprovacao(nota1, nota2));
        }

        [Fact]
        public void Verifica_Aluno_EmRecuperacao_NoLimite_Inferior()
        {
            var alunoFake = new Faker<Aluno>();
            alunoFake.CustomInstantiator(fake => new Aluno(fake.Person.FullName, DateOnly.FromDateTime(fake.Person.DateOfBirth)));
            var aluno = alunoFake.Generate();

            var nota1 = new Faker<Nota>().CustomInstantiator(x => new Nota(3)).Generate();
            var nota2 = new Faker<Nota>().CustomInstantiator(x => new Nota(3)).Generate();

            Assert.Throws<EmRecuperacaoException>(() => aluno.VerificarAprovacao(nota1, nota2));
        }
        
        [Fact]
        public void Verifica_Aluno_EmRecuperacao_NaoAprovado()
        {
            var alunoFake = new Faker<Aluno>();
            alunoFake.CustomInstantiator(fake => new Aluno(fake.Person.FullName, DateOnly.FromDateTime(fake.Person.DateOfBirth)));
            var aluno = alunoFake.Generate();

            var n1 = new Mock<Nota>(2.9);
            var n2 = new Mock<Nota>(3);

            Assert.Throws<NaoAprovadoException>(() => aluno.VerificarAprovacao(n1.Object, n2.Object));
        }

    }
}