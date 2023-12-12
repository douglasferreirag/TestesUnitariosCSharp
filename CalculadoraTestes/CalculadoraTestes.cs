using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private CalculadoraImpementacao _calc;

    public CalculadoraTestes(){

         _calc = new CalculadoraImpementacao();   

    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {

        //Arrange - prepara o cenário

        int num1 = 5;

        int num2 = 10;

        //Act - ação


        int resultado = _calc.Somar(num1,num2);

        //Assert - validação

        Assert.Equal(15,resultado);

        



    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {

        //Arrange - prepara o cenário

        int num1 = 10;

        int num2 = 10;

        //Act - ação


        int resultado = _calc.Somar(num1,num2);

        //Assert - validação

        Assert.Equal(20,resultado);

        



    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro(){

        //Arrange

        int num1 = 4;

        // Act

        bool resultado = _calc.EhPar(num1);

        //Arrange

        Assert.True(resultado);

    }

    [Theory] //executar o teste mais de uma vez. Conjunto de testes para ser executados.
    [InlineData(2)] // Passar parâmetros, e para cada é um teste diferente.
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero){

        //Arrange



        // Act

        bool resultado = _calc.EhPar(numero);

        //Arrange

        Assert.True(resultado);

    }

}