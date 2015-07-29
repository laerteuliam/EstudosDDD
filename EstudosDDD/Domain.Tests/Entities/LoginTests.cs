using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosDDD.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.Tests.Entities
{
    [TestClass]
    public sealed class LoginTests
    {
        [TestMethod]
        public void QuandoEuCriarUmLogin()
        {
            //arrange
            LoginEntity loginEntity = null;
            //act
            string login = "laerte";
            string senha = "la2611";
            loginEntity = new LoginEntity(login,senha);
            //assert
            Assert.IsNotNull(loginEntity);
            Assert.IsFalse(string.IsNullOrWhiteSpace(loginEntity.Login));
            Assert.IsFalse(string.IsNullOrWhiteSpace(loginEntity.Senha));
            Assert.AreEqual(loginEntity.Login,login);
            Assert.AreEqual(loginEntity.Senha,senha);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmLoginSenhaDeveTerNoMinimo6Caracteres()
        {
            //Arrange
            string senha = "ABCDE";
            string login = "laerte";
            
            //Act
            LoginEntity loginEntity = new LoginEntity(login,senha);

            //Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarLoginDeveTerNoMinimo3Caracteres()
        {
            //arrange
            string login = "AB";
            string senha = "123456";

            //act
            LoginEntity loginEntity = new LoginEntity(login,senha);
        }
    }
}
