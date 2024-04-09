using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorTest
{
    [TestClass]
    public class GeneratePasswordTest
    {
        [TestMethod]
        // Verifica se a Senha tem uma determinada quantidade de caracteres.
        public void GenerateTest()
        {
            string senha = Generator.GeneratePassword(32);

            Assert.AreEqual(senha.Length, 32);
        }
    }
}
