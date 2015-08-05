using System;
using EstudosDDD.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests.Entities
{
    [TestClass]
    public sealed class PessoaTests
    {
        [TestMethod]
        public void QuandoEuCriarUmUsuario()
        {
            //arrange
            PessoaEntity pessoa = null;
            string login = "laerte";
            string senha = "123456";
            LoginEntity loginEntity = new LoginEntity(login,senha);
            string nome = "Laerte";
            string sobrenome = "Uliam";

            //act
            pessoa = new PessoaEntity(nome,sobrenome,DateTime.Now,loginEntity);

            Assert.IsNotNull(pessoa);
            Assert.IsFalse(string.IsNullOrWhiteSpace(pessoa.Nome));
            Assert.IsFalse(string.IsNullOrWhiteSpace(pessoa.SobreNome));
            Assert.IsFalse(pessoa.Login==null);
            Assert.AreEqual(pessoa.Nome,nome);
            Assert.AreEqual(pessoa.SobreNome,sobrenome);
            Assert.AreEqual(pessoa.CodigoLogin,1);
            
        }
    }
}
