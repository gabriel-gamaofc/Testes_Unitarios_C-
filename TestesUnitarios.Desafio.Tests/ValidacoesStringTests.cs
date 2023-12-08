using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //Implementado

        // Arrange
        string texto = "Matrix";//mudei de var para string
        int resultadoEsperado = 6;//mudei de var para int

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        string texto = "Esse é um texto qualquer";//mudei de var para string
        string textoProcurado = "qualquer";//mudei de var para string

        //Implementado
        // Act
         bool resultado =_validacoes.ContemCaractere(texto, textoProcurado);//mudei de var para bool

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        string texto = "Esse é um texto qualquer";//mudei de var para string
        string textoProcurado = "teste";//mudei de var para string

        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);//mudei de var para bool

        // Assert
        //implementado
        Assert.False(resultado);
    }

    //implementado
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //Implementado

        // Arrange
        string texto = "Começo, meio e fim do texto procurado";//mudei de var para string
        string textoProcurado = "procurado";//mudei de var para string

        // Act
        bool resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);//mudei de var para bool

        // Assert
        Assert.True(resultado);
    }
}
