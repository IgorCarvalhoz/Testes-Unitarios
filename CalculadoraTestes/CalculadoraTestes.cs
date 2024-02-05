using Services.Calculadora;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImplementada _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementada();
    }
    [Fact]
    public void TesteSoma()
    {
        //Deve somar 5 com 10 e retornar 15
        //Assert
        int numero1 = 5;
        int numero2 = 10;
        //Act
        int resultado = _calc.Somar(numero1, numero2);
        //Assert
        Assert.Equal(15, resultado); 

    }
}