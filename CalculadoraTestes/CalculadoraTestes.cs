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

}