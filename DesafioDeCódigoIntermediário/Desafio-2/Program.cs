using System;
/*
Desafio
A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a 
tabela abaixo:

Salário	Percentual de Reajuste
0 - 400.00          15%
400.01 - 800.00     12%
800.01 - 1200.00    10%
1200.01 - 2000.00   7%
Acima de 2000.00    4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de 
reajuste ganho e o índice reajustado, em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, 
com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o 
percentual de reajuste ganho.
*/

Console.WriteLine("Informe o salário do funcionário, ex: 600.00: ");

double salario = Convert.ToDouble(Console.ReadLine());
double novoSalario = 0.0;
double reajuste = 0.0;
double percentual = 0.0;
bool continuar = true;

while (continuar)
{
    if (salario <= 0.0)
    {
        break;
    
    } else if(salario > 0.00 && salario <= 400.00) 
    {
        percentual = 15.0 / 100;
        reajuste = percentual * salario;
        novoSalario = reajuste + salario;
    
    } else if (salario > 400.00 && salario <= 800.00)
    {
        percentual = 12.0 / 100;
        reajuste = percentual * salario;
        novoSalario = salario + reajuste;
    
    } else if (salario > 800.00 && salario < 1200.00)
    {
        percentual = 10.0 / 100;
        reajuste = percentual * salario;
        novoSalario = salario + reajuste;
    
    } else if (salario > 1200.00 && salario <= 2000.00)
    {
        percentual = 7.0 / 100;
        reajuste = salario * percentual;
        novoSalario = salario + reajuste;

    }
    else
    {
        percentual = 4.0 / 100;
        reajuste = salario * percentual;
        novoSalario = salario + reajuste;
    }
    
    Console.WriteLine("Novo salário {0:0.00}", novoSalario);
    Console.WriteLine("Valor ganho de reajuste {0:0.00}", reajuste);
    Console.WriteLine("Percentual de reajuste ganho: {0}%", percentual * 100);

    break;
}