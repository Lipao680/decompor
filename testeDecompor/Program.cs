using System;

namespace testeDecompor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] moedaReal = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5M, 0.1M, 0.05M, 0.01M };
            decimal[] valores = { 153647.00M, 2341.56M, 34567345.34M, 5239820.00M, 928374.00M, 34234.00M, 3.01M, 1234.56M, 888.99M, 327563.56M };
            decimal valor = 0;
            decimal diferenca = 0;
            foreach (var cValores in valores)
            {
                diferenca = cValores;
                valor = cValores;
                foreach (var cMoedaReal in moedaReal)
                {
                    while (valor <= cValores)
                    {
                        if (diferenca >= cMoedaReal)
                        {
                            var calc = (valor - valor % cMoedaReal) / cMoedaReal;
                            var valorMulti = calc * cMoedaReal;
                            var valorCalc = valor;
                            diferenca = valorCalc - valorMulti;
                            valor = diferenca != valorCalc ? diferenca : valor;
                            if (cMoedaReal > 0.5M)
                            {
                                Console.WriteLine("Valor {0}", cValores);
                                Console.WriteLine($"Quantidade de notas {calc} Real de: {cMoedaReal}");
                            }
                            else
                            {
                                Console.WriteLine("Valor {0}", cValores);
                                Console.WriteLine($"Quantidade de notas {calc} Moeda de: {cMoedaReal}");
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
}
