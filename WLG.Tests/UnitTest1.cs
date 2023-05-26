namespace WLG.Tests;
public class StringConcatenatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Concatenar_ShouldConcatenateStrings()
    {
        string str1 = "Callof";
        string str2 = "Duty";
        string expected = "CallofDuty";
        StringConcatenator concatenator = new StringConcatenator();

        string result = concatenator.Concatenar(str1, str2);

        Assert.AreEqual(expected, result);
    }
    //public static void Main(string[] args)
    //{
    //var TestClass = new StringConcatenatorTests();
    //TestClass.Concatenar_ShouldConcatenateStrings();
    //}
    [Test]
    public void Substituir_DeveSubstituirOcorrenciasDaSubstring()
    {
        string str = "Olá, mundo";
        string substring = "mundo";
        string expected = "Olá, LH";
        StringConcatenator substituir = new StringConcatenator();

        string result = substituir.Substituir(str, substring);

        Assert.AreEqual(expected, result);
    }
    [Test]
    public void Substituir_DeveManterStringOriginalQuandoSubstringNaoEncontrada()
    {
        string str = "Olá, mundo";
        string substring = "LH";
        string expected = "Olá, mundo";
        StringConcatenator substituir = new StringConcatenator();

        string result = substituir.Substituir(str, substring);

        Assert.AreEqual(expected, result);
    }
    [Test]
    public void Comparar_DeveRetornarTrueQuandoStringsIguais()
    {
        string str3 = "Luiz";
        string str4 = "Luiz";
        StringConcatenator comparar = new StringConcatenator();

        bool result = comparar.Comparar(str3, str4);

        Assert.IsTrue(result);
    }
    [Test]
    public void Comparar_DeveRetornarFalseQuandoStringsDiferentes()
    {
        string str3 = "Luiz";
        string str4 = "Henrique";
        StringConcatenator comparar = new StringConcatenator();

        bool result = comparar.Comparar(str3, str4);

        Assert.IsFalse(result);

    }
    [Test]
    public void TesteParaMaiusculas()
    {
        string str5 = "cdz";
        string ResultadoEsperado = "CDZ";
        StringConcatenator maiusculas = new StringConcatenator();

        string resultadoObitido = maiusculas.ParaMaiusculas(str5);

        Assert.AreEqual(ResultadoEsperado, resultadoObitido);
    }
    [Test]
    public void TesteParaMinusculas()
    {
        string str6 = "CDZ";
        string ResultadoEsperado = "cdz";
        StringConcatenator minusculas = new StringConcatenator();

        string resultadoObitido = minusculas.ParaMinusculas(str6);

        Assert.AreEqual(ResultadoEsperado, resultadoObitido);
    }

}