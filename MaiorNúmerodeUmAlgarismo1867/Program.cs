class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int n;
        int nDig;
        int.TryParse(Console.ReadLine(),out n);
        Console.Write("Digite outro número: ");
        int m;
        int mDig;
        int.TryParse(Console.ReadLine(), out m);
        int PrimMaior = 0;

        void GetSomaAlgarismos(int n, int m)
        {
            int nSoma = 0;
            int mSoma = 0;
            while (n > 0)
            {
                nDig = n % 10;///ultimo digito
                nSoma += nDig;///soma os ultimos algarimos cada vez que um deles é retirado do numero inteiro
                n = n / 10;   ///divisão para recuperar os digitos restantes do número
            }
            while (m > 0)
            {
                mDig = m % 10;///ultimo digito
                mSoma += mDig;///soma os ultimos algarimos cada vez que um deles é retirado do numero inteiro
                m = m / 10;   ///divisão para recuperar os digitos restantes do número
            }
            ///verifica se é necessario outra soma de algarismos
            if (nSoma >= 10 || mSoma >= 10) { GetSomaAlgarismos(nSoma, mSoma); }
            ///confere em qual grupo o resultado se encaixa //para o caso onde não há retorno o caso é igual a 3
            if (nSoma > mSoma) { PrimMaior = 1; }
            else if (nSoma < mSoma) { PrimMaior = 2; }
            else if (nSoma == mSoma) { PrimMaior = 0; }
            else { PrimMaior = 3; }

            if (PrimMaior == 3) { Console.WriteLine($""); }
            else { Console.WriteLine($"{PrimMaior}"); }
            return;
        }
        ///chamada do metodo
        GetSomaAlgarismos(n, m);
    }
    
}