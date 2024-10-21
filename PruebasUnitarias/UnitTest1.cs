using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestión_Museo;

namespace PruebasUnitarias
{
    [TestClass]
    public class MuseoTests
    {
        [TestMethod]
        public void TestValidarUsuario_UsuarioValido()
        {

            var museo = new FrmLogin.Museo();


            bool esValido = museo.ValidarUsuario("DARIO BORJA GAMBOA", "202110395");


            Assert.IsTrue(esValido);  // El usuario y la contraseña son válidos
        }

        [TestMethod]
        public void TestValidarUsuario_UsuarioInvalido()
        {
            // Arrange
            var museo = new FrmLogin.Museo();

            // Act
            bool esValido = museo.ValidarUsuario("LO QUE SEA", "123456");

            // Assert
            Assert.IsFalse(esValido);  // El usuario no existe
        }

        [TestMethod]
        public void TestValidarUsuario_ContrasenaIncorrecta()
        {
            // Arrange
            var museo = new FrmLogin.Museo();

            // Act
            bool esValido = museo.ValidarUsuario("DARIO BORJA GAMBOA", "incorrecta");

            // Assert
            Assert.IsFalse(esValido);  // El usuario es válido, pero la contraseña es incorrecta
        }
        [TestMethod]

        public void TestGetValidarUsuario2()
        {
            var museo = new FrmLogin.Museo();


            bool esValido = museo.ValidarUsuario("SAMUEL BASTIDAS PAMPLONA", "202210320");


            Assert.IsTrue(esValido);  // El usuario y la contraseña son válidos
        }
        [TestMethod]
        public void TestValidarUsuario_ContrasenaIncorrecta2()
        {
            // Arrange
            var museo = new FrmLogin.Museo();

            // Act
            bool esValido = museo.ValidarUsuario("SAMUEL BASTIDAS PAMPLONA", "incorrecta");

            // Assert
            Assert.IsFalse(esValido);  // El usuario es válido, pero la contraseña es incorrecta
        }
        [TestMethod]
        public void TestValidarUsuario_UsuarioInvalido2()
        {
            // Arrange
            var museo = new FrmLogin.Museo();

            // Act
            bool esValido = museo.ValidarUsuario("LO QUE SEA", "123456");

            // Assert
            Assert.IsFalse(esValido);  // El usuario no existe
        }
        [TestMethod]

        public void TestGetValidarUsuario3()
        {
            var museo = new FrmLogin.Museo();


            bool esValido = museo.ValidarUsuario("TOMAS BETANCUR DELGADO", "202210279");


            Assert.IsTrue(esValido);  // El usuario y la contraseña son válidos
        }
        [TestMethod]
        public void TestValidarUsuario_ContrasenaIncorrecta3()
        {
            // Arrange
            var museo = new FrmLogin.Museo();

            // Act
            bool esValido = museo.ValidarUsuario("TOMAS BETANCUR DELGADO", "incorrecta");

            // Assert
            Assert.IsFalse(esValido);  // El usuario es válido, pero la contraseña es incorrecta
        }
        [TestMethod]
        public void TestValidarUsuario_UsuarioInvalido3()
        {
            // Arrange
            var museo = new FrmLogin.Museo();

            // Act
            bool esValido = museo.ValidarUsuario("LO QUE SEA", "123456");

            // Assert
            Assert.IsFalse(esValido);  // El usuario no existe
        }
    }
}
