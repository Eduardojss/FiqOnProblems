using System.Collections.Generic;
class teste
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Escreva a quantidade de palarvras que deseja para o acronimo: ");
        int.TryParse(Console.ReadLine(), out n);
        List<string> linhas = new();
        bool encontrou = false;
        List<string> lista = new();
        string acronimo = "";
        List<string> listAcronimos = new();
        /// iteração para adicionar a lista cada palavra
        for (int i = 0; i < n; i++)
        {
            string linha = Console.ReadLine();
            linhas.Add(linha);
        }
        /// adiciona a saida do metodo em uma lista de strings
        /// função de repetição para chamar o metodo que retem a primeira letra da string
        listAcronimos.Add(makeAcronym(linhas));

        /// metodo que retira o primeiro char da string se ele não for vazio
        string makeAcronym(List<string> str)
        {
            foreach (string s in linhas)
            {
                string result = "";
                for (int i = 0; i < str.Count; i++)
                {
                    if (i == 0 && s[i].ToString() != " ")
                    {
                        result += s[i];
                        continue;
                    }

                    if (s[i - 1].ToString() == " " && s[i].ToString() != " ")
                    {
                        result += s[i];
                    }
                }
                acronimo += result;
            }
            return acronimo;
        }

        ///metodo para verificar se existe alguma palavra na lista que seja igual ao acronimo
        void VerAcroInWords()
        {
            if (lista.Any(s => s == acronimo))
            {
                Console.WriteLine("Y");
            }
            else { Console.WriteLine("N"); }
        }
        ///chamada do metodo de verificação
        VerAcroInWords();


    }
}