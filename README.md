# Faturamento Diário

Este projeto calcula o faturamento diário ao longo de um ano, considerando que o ano não é bissexto. Utiliza a classe `Random` para gerar valores aleatórios de faturamento.

## Funcionamento

1. **Feriados**: A lista de feriados no Brasil é considerada para excluir esses dias do cálculo.
2. **Fim de Semana**: Os sábados e domingos também são excluídos.
3. **Faturamento Aleatório**: Para cada dia útil, um valor de faturamento aleatório entre R$ 1000 e R$ 10000 é gerado.
4. **Estatísticas Anuais**:
   - Menor faturamento diário: {menorFaturamentoAnual.Item2:F2} no dia {menorFaturamentoAnual.Item1}
   - Média anual de faturamento em {ano}: {mediaFaturamentoAnual:F2}
   - Dias com faturamento acima da média anual: {DiasFaturamentoMaiorAnual}

## Clonar o Repositório:

- Certifique-se de ter instalado o .NET
- Abra o terminal ou prompt de comando.
- Navegue até o diretório onde deseja clonar o projeto.
- Execute o seguinte comando para clonar o repositório
```bash
git clone https://github.com/JoseLSousa/Teste-equipe-Fiscon.git
```
- Execute o comando para executar o programa
```bash
dotnet-run
```