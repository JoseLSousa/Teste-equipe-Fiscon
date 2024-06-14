using System;

namespace FaturamentoDiario
{
    //Considerando que o ano não é bissexto e utilizando a classe random para gerar os faturamento diário de forma aleatória
    // Caso queira saber mais acesse meu repositório : https://github.com/JoseLSousa/Teste-equipe-Fiscon
    class Program
    {
        static void Main()
        {
            List<Tuple<string, int>> faturamentoDiario = new List<Tuple<string, int>>();
            int ano = 2023; // Ano não bissexto
            Random random = new Random();
            // Lista de feriados no brasil
            List<DateTime> feriados = new List<DateTime>
        {
            new DateTime(ano, 1, 1),   // Ano Novo
            new DateTime(ano, 4, 21),  // Tiradentes
            new DateTime(ano, 5, 1),   // Dia do Trabalho
            new DateTime(ano, 9, 7),   // Independência do Brasil
            new DateTime(ano, 10, 12), // Nossa Senhora Aparecida
            new DateTime(ano, 11, 2),  // Finados
            new DateTime(ano, 11, 15), // Proclamação da República
            new DateTime(ano, 12, 25)  // Natal
        };

            // Iterar sobre todos os dias do ano
            for (DateTime date = new DateTime(ano, 1, 1); date.Year == ano; date = date.AddDays(1))
            {
                // Verificar se é final de semana
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                // Verificar se é feriado
                if (feriados.Contains(date))
                {
                    continue;
                }
                int faturamento = random.Next(1000, 10001);
                // Adicionar à lista de faturamento diário
                faturamentoDiario.Add(Tuple.Create(date.ToString("yyyy-MM-dd"), faturamento));
            }
            int somaFaturamentoAnual = faturamentoDiario.Sum(item => item.Item2);
            int numeroDeDias = faturamentoDiario.Count;
            double mediaFaturamentoAnual = somaFaturamentoAnual / numeroDeDias;
            var menorFaturamentoAnual = faturamentoDiario.OrderBy(valor => valor.Item2).First();
            int DiasFaturamentoMaiorAnual = 0;

            foreach (var valor in faturamentoDiario)
            {
                if (valor.Item2 > mediaFaturamentoAnual)
                {
                    DiasFaturamentoMaiorAnual += 1;
                }
            }
            Console.WriteLine($"O menor faturamento é {menorFaturamentoAnual.Item2:F2} no dia {menorFaturamentoAnual.Item1}");
            Console.WriteLine($"A Média do faturamento do ano de {ano} é de {mediaFaturamentoAnual:F2}");
            Console.WriteLine($"Houve {DiasFaturamentoMaiorAnual} dias em que o Faturamento foi maior a média Anual");
        }
    }
}