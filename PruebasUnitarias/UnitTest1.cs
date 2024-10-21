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
            var museo = new FrmLogin.Museo();// se especifica que vamos a usar y a trabajar en FrmLogin que es donde estan los procesos, tambien use la variable "var" porque vamos usar tanto numeros como cadenas de texto
            bool esValido = museo.ValidarUsuario("DARIO BORJA GAMBOA", "202110395");//a qui simplemente usamos la bandera que puse en codigo del form para confirmar si es un usuario valido y lo valido con la información

            Assert.IsTrue(esValido);// y aqui ya simplemente da si es valido o no 
        }

        [TestMethod]
        public void TestValidarUsuario_UsuarioInvalido()
        {
            var museo = new FrmLogin.Museo();
            bool esValido = museo.ValidarUsuario("LO QUE SEA", "123456");// es la validadación por si es otro usuario
            Assert.IsFalse(esValido);  // ya aqui informa que el usuario no esta en el diccionario para que el proceso en el codigo de form si funciona
        }

        [TestMethod]
        public void TestValidarUsuario_ContrasenaIncorrecta()
        {
            
            var museo = new FrmLogin.Museo();
            bool esValido = museo.ValidarUsuario("DARIO BORJA GAMBOA", "incorrecta");// es la validadación por si es otro usuario
            Assert.IsFalse(esValido);  // ya aqui informa que el usuario no esta en el diccionario para que el proceso en el codigo de form si funciona
        }
        [TestMethod]
// luego se repite el proceso en los demás usuarios para testear que con todos funciones bien
        public void TestGetValidarUsuario2()
        {
            var museo = new FrmLogin.Museo();


            bool esValido = museo.ValidarUsuario("SAMUEL BASTIDAS PAMPLONA", "202210320");


            Assert.IsTrue(esValido);  
        }
        [TestMethod]
        public void TestValidarUsuario_ContrasenaIncorrecta2()
        {
           
            var museo = new FrmLogin.Museo();

        
            bool esValido = museo.ValidarUsuario("SAMUEL BASTIDAS PAMPLONA", "incorrecta");

            
            Assert.IsFalse(esValido);  
        }
        [TestMethod]
        public void TestValidarUsuario_UsuarioInvalido2()
        {
         
            var museo = new FrmLogin.Museo();

          
            bool esValido = museo.ValidarUsuario("LO QUE SEA", "123456");

           
            Assert.IsFalse(esValido); 
        }
        [TestMethod]

        public void TestGetValidarUsuario3()
        {
            var museo = new FrmLogin.Museo();


            bool esValido = museo.ValidarUsuario("TOMAS BETANCUR DELGADO", "202210279");


            Assert.IsTrue(esValido);
        }
        [TestMethod]
        public void TestValidarUsuario_ContrasenaIncorrecta3()
        {
          
            var museo = new FrmLogin.Museo();

          
            bool esValido = museo.ValidarUsuario("TOMAS BETANCUR DELGADO", "incorrecta");

            
            Assert.IsFalse(esValido); 
        }
        [TestMethod]
        public void TestValidarUsuario_UsuarioInvalido3()
        {
          
            var museo = new FrmLogin.Museo();

           
            bool esValido = museo.ValidarUsuario("LO QUE SEA", "123456");

          
            Assert.IsFalse(esValido);  
        }
    }
}
