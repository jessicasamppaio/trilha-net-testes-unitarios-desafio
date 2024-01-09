using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //    Anotação by Jéssica: 
        //    A classe 'ListaContemDeterminadoNumero' possui dois testes diferentes um analisando se um numero 
        //    (9) consta na lista e o outro teste analisa se outro numero (10) não está presente na lista. 
        //    O teste é basicamente o mesmo o que difere é o  Assert que no primeiro caso deve retornar True 
        //    e no segundo caso deve retornar False.

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert

         Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act

        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Anotações by Jéssica:
        // no 'Arrange' passamos os valores que iremos verificar e em seguida colocamos 
        // o resultado que esperamos.

        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = 9;

        // No Act puxamos o método utilizado pelo nome da classe para verificar o resultado
        // do metodo (função) usado.

        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // No Assert comparamos o resultado que estamos esperando (nesse caso 9) com o resultado
        // do método executado para saber se está batendo com o resultado que desejamos.
        
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {

        // Nesse caso eu poderia colocar direto o -8 no lugar de 'resultadoEsperado' e 
        // não necessáriamente precisaria criar essa variavel, mas optei seguir o modelo dos
        // testes anteriores.

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = -8;

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        
        Assert.Equal(resultadoEsperado, resultado);
    }
}
