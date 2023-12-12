using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {

        private ValidacoesString _validacoes;

        public ValidacoesStringTestes()
        {

            _validacoes = new ValidacoesString();
            
        }

        [Fact]
        public void DeveContar3sCaracteresEmOlaRetornar3(){

                //Arrange

                string texto = "Ola";

                //Act

                int resultado = _validacoes.ContarCaracteres(texto);

                //Assert

                Assert.Equal(4,resultado);

        }
        
    }
}