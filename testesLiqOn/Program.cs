using System;
using System.Text.RegularExpressions;

class Program
{

    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int NumDig = int.Parse(Console.ReadLine());
        int i = 0;
        /// chamada do metodo
            recursive(NumDig, i);
    }
    static string GetNumeroPorExenso(int n)
    {
        string numero = string.Empty;
        string centena = string.Empty;
        string dezena = string.Empty;
        string unidade = string.Empty;
        string extenso = string.Empty;
        numero = $"{n}";
        numero = numero.PadLeft(3, '0');

        string zero = "000";
        if (numero == zero)
        {
            Console.Write("Zero");
        }

        if (numero[0] != '0')
        {

            switch (numero[0])
            {
                case '1':
                    centena = "one hundred";
                    break;
                default:
                    break;

            }

        }

        if (numero[1] == '1')
        {
            switch (numero.Substring(1))
            {
                case "10": dezena = "ten"; break;
                case "11": dezena = "eleven"; break;
                case "12": dezena = "twelve"; break;
                case "13": dezena = "thirteen"; break;
                case "14": dezena = "fourteen"; break;
                case "15": dezena = "fifteen"; break;
                case "16": dezena = "sixteen"; break;
                case "17": dezena = "seventeen"; break;
                case "18": dezena = "eighteen"; break;
                case "19": dezena = "nineteen"; break;
            }
        }
        else if (numero[1] != '0')
        {
            switch (numero[1])
            {
                case '2': dezena = "twenty"; break;
                case '3': dezena = "Thirty"; break;
                case '4': dezena = "fourty"; break;
                case '5': dezena = "fifty"; break;
                case '6': dezena = "sixty"; break;
                case '7': dezena = "seventy"; break;
                case '8': dezena = "eighty"; break;
                case '9': dezena = "Ninety"; break;
            }
        }

        if (numero[2] != '0' && numero[1] != '1')
        {
            switch (numero[2])
            {
                case '1': unidade = "one"; break;
                case '2': unidade = "two"; break;
                case '3': unidade = "three"; break;
                case '4': unidade = "four"; break;
                case '5': unidade = "five"; break;
                case '6': unidade = "six"; break;
                case '7': unidade = "seven"; break;
                case '8': unidade = "eight"; break;
                case '9': unidade = "nine"; break;
            }
        }
        if (centena == "one hundred") extenso = $"{centena}";
        else extenso = $"{dezena} {unidade}";
        return extenso.Trim();
    }
    /// obtem a quantidade caracteres na string
    static int getExtensoLenght(string s)
    {
        int x = s.Length;
        return x;
    }

    /// metodo recursivo para repetir a iteração
    static void recursive(int n, int i)
    {
        if(i <= 1000)
        {
            string s = GetNumeroPorExenso(n);
            int x = getExtensoLenght(s);
            i++;
            Console.Write(x);
            recursive(x, i);
        }else Console.Write("fim");
    }
}
    
