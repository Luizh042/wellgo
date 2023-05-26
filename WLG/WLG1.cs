namespace WLG;
public class StringConcatenator 
{
    public static void Main(string[] args)
    {}
    public string Concatenar(string str1, string str2)
    {
        return str1 + str2;
    }
    public string Substituir(string str, string substring)
    {
        return str.Replace(substring, "LH");
    }
    public bool Comparar(string str3, string str4)
    {
        return str3 == str4;
    }
    public string ParaMaiusculas(string str5)
    {
        return str5.ToUpper();
    }
    public string ParaMinusculas(string str6)
    {
        return str6.ToLower();
    }
}

