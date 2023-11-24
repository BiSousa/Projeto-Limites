using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Limites
{
    class Program
    {
        static void Main(string[] args)
        {
            //declara as variáveis
            double valorx;
            double resultermos;
            double resultermosnum;
            double resultermosden;
            double result = 0;
            double resultnum = 0;
            double resultden = 0;
            char resposta;
            String[] termosnum = new string[3];
            String[] operacoesnum = new string[2];
            String[] termosden = new string[3];
            String[] operacoesden = new string[2];
            String[] termos = new string[3];
            String[] operacoes = new string[2];
            double[] resultados = new double[3];
            double[] resultadosnum = new double[3];
            double[] resultadosden = new double[3];
            double[] valores = new double[6];
            double[] resultadostestes = new double[6];
            double[] resnum = new double[6];
            double[] resden = new double[6];

            Console.Write("Sua equação possui divisão - (S) ou (N)? ");
            resposta = Convert.ToChar(Console.ReadLine().ToUpper());

            if (resposta == 'S') //se a equação tiver divisão
            {

                //pede os termos e os operadores do numerador e armazena 
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Informe o {i + 1} termo do numerador: ");
                    termosnum[i] = Console.ReadLine().ToUpper();

                    if (i != 2)
                    {
                        Console.Write($"Digite o {i + 1} operador do numerador: ");
                        operacoesnum[i] = Console.ReadLine();
                    }
                }

                //pede os termos e os operadores do denominador e armazena 
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Informe o {i + 1} termo do denominador: ");
                    termosden[i] = Console.ReadLine().ToUpper();

                    if (i != 2)
                    {
                        Console.Write($"Digite o {i + 1} operador do denominador: ");
                        operacoesden[i] = Console.ReadLine();
                    }
                }

                //pede o valor de x e armazena
                Console.Write("Insira o valor de X: ");
                valorx = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("-------------------------------");

                //calcula os termos do numerador e armazena
                for (int i = 0; i < 3; i++)
                {
                    String[] separadonum = termosnum[i].Split('X'); //separa os termos pelo x
                    if (separadonum.Length == 2) //se tiver 3 elementos no termo e tem duas partes
                    {
                        resultermosnum = Math.Pow(valorx, Int32.Parse(separadonum[1]));
                        resultermosnum = resultermosnum * Int32.Parse(separadonum[0]);
                    }
                    else if (termosnum[i][1] == 'X' && separadonum.Length != 2)//se tiver 2 elementos e o segundo for X 
                    {
                        resultermosnum = valorx * Int32.Parse(separadonum[0]);
                    }
                    else
                    {
                        resultermosnum = Double.Parse(termosnum[i]);
                    }

                    resultadosnum[i] = resultermosnum; //armazena o resultado do termo em um vetor na posição correspondente
                    Console.WriteLine($"O valor da expressão {i} é {resultadosnum[i]}");
                }

                //faz o cálculo do numerador da equação
                if (operacoesnum[0] == "+")
                {
                    resultnum = resultadosnum[0] + resultadosnum[1];
                }
                else
                {
                    resultnum = resultadosnum[0] - resultadosnum[1];
                }

                if (operacoesnum[1] == "+")
                {
                    resultnum = resultnum + resultadosnum[2];
                }
                else
                {
                    resultnum = resultnum - resultadosnum[2];
                }

                Console.WriteLine($"Resultado numerador: {resultnum}");

                //calcula os termos do denominador e armazena
                for (int i = 0; i < 3; i++)
                {
                    String[] separadoden = termosden[i].Split('X'); //separa os termos pelo x
                    if (separadoden.Length == 2) //se tiver 3 elementos no termo e tem duas partes
                    {
                        resultermosden = Math.Pow(valorx, Int32.Parse(separadoden[1]));
                        resultermosden = resultermosden * Int32.Parse(separadoden[0]);
                    }
                    else if (termosden[i][1] == 'X' && separadoden.Length != 2)//se tiver 2 elementos e o segundo for X 
                    {
                        resultermosden = valorx * Int32.Parse(separadoden[0]);
                    }
                    else
                    {
                        resultermosden = Double.Parse(termosnum[i]);
                    }

                    resultadosden[i] = resultermosden; //armazena o resultado do termo em um vetor na posição correspondente
                    Console.WriteLine($"O valor da expressão {i} é {resultadosden[i]}");
                }

                //faz o cálculo do denominador da equação
                if (operacoesden[0] == "+")
                {
                    resultden = resultadosden[0] + resultadosden[1];
                }
                else
                {
                    resultden = resultadosden[0] - resultadosden[1];
                }

                if (operacoesden[1] == "+")
                {
                    resultden = resultden + resultadosden[2];
                }
                else
                {
                    resultden = resultden - resultadosden[2];
                }

                Console.WriteLine($"Resultado denominador: {resultden}");

                Console.WriteLine("-------------------------------");

                if (resultden == 0)
                {
                    valores[0] = valorx + 0.1;
                    valores[1] = valorx + 0.01;
                    valores[2] = valorx + 0.001;
                    valores[3] = valorx - 0.1;
                    valores[4] = valorx - 0.01;
                    valores[5] = valorx - 0.001;

                    for (int h = 0; h < 6; h++)
                    {
                        //calcula os termos do numerador e armazena
                        for (int i = 0; i < 3; i++)
                        {
                            String[] separadonum = termosnum[i].Split('X'); //separa os termos pelo x
                            if (separadonum.Length == 2) //se tiver 3 elementos no termo e tem duas partes
                            {
                                resultermosnum = Math.Pow(valores[h], Int32.Parse(separadonum[1]));
                                resultermosnum = resultermosnum * Int32.Parse(separadonum[0]);
                            }
                            else if (termosnum[i][1] == 'X' && separadonum.Length != 2)//se tiver 2 elementos e o segundo for X 
                            {
                                resultermosnum = valores[i] * Int32.Parse(separadonum[0]);
                            }
                            else
                            {
                                resultermosnum = Double.Parse(termosnum[i]);
                            }

                            resultadosnum[i] = resultermosnum; //armazena o resultado do termo em um vetor na posição correspondente

                        }

                        //faz o cálculo do numerador da equação
                        if (operacoesnum[0] == "+")
                        {
                            resultnum = resultadosnum[0] + resultadosnum[1];
                        }
                        else
                        {
                            resultnum = resultadosnum[0] - resultadosnum[1];
                        }

                        if (operacoesnum[1] == "+")
                        {
                            resultnum = resultnum + resultadosnum[2];
                        }
                        else
                        {
                            resultnum = resultnum - resultadosnum[2];
                        }

                        resnum[h] = resultnum;

                        //calcula os termos do denominador e armazena
                        for (int i = 0; i < 3; i++)
                        {
                            String[] separadoden = termosden[i].Split('X'); //separa os termos pelo x
                            if (separadoden.Length == 2) //se tiver 3 elementos no termo e tem duas partes
                            {
                                resultermosden = Math.Pow(valores[h], Int32.Parse(separadoden[1]));
                                resultermosden = resultermosden * Int32.Parse(separadoden[0]);
                            }
                            else if (termosden[i][1] == 'X' && separadoden.Length != 2)//se tiver 2 elementos e o segundo for X 
                            {
                                resultermosden = valores[h] * Int32.Parse(separadoden[0]);
                            }
                            else
                            {
                                resultermosden = Double.Parse(termosnum[i]);
                            }

                            resultadosden[i] = resultermosden; //armazena o resultado do termo em um vetor na posição correspondente

                        }


                        //faz o cálculo do denominador da equação
                        if (operacoesden[0] == "+")
                        {
                            resultden = resultadosden[0] + resultadosden[1];
                        }
                        else
                        {
                            resultden = resultadosden[0] - resultadosden[1];
                        }

                        if (operacoesden[1] == "+")
                        {
                            resultden = resultden + resultadosden[2];
                        }
                        else
                        {
                            resultden = resultden - resultadosden[2];
                        }

                        resden[h] = resultden;

                        resultadostestes[h] = resnum[h] / resden[h];
                        Console.WriteLine($"Resultado {h + 1}: {resultadostestes[h]}");

                    }

                    if (resultadostestes[0] - resultadostestes[1] < 1 && resultadostestes[1] - resultadostestes[2] < 1 &&
                        resultadostestes[3] - resultadostestes[4] < 1 && resultadostestes[4] - resultadostestes[5] < 1)
                    {
                        Console.WriteLine("O limite é: " + Math.Round(resultadostestes[5], 2));
                    }
                    else
                    {
                        Console.WriteLine("Não há limite!");
                    }
                }

            }
            else //se a equação não tiver divisão
            {
                //pede os termos e os operadores do numerador e armazena 
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Informe o {i + 1} termo: ");
                    termos[i] = Console.ReadLine().ToUpper();

                    if (i != 2)
                    {
                        Console.Write($"Digite o {i + 1} operador: ");
                        operacoes[i] = Console.ReadLine();
                    }
                }

                //pede o valor de x e armazena
                Console.Write("Insira o valor de X: ");
                valorx = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("-------------------------------");

                //calcula os termos da equação e armazena
                for (int i = 0; i < 3; i++)
                {
                    String[] separado = termos[i].Split('X'); //separa os termos pelo x
                    if (separado.Length == 2) //se tiver 3 elementos no termo e tem duas partes
                    {
                        resultermos = Math.Pow(valorx, Int32.Parse(separado[1]));
                        resultermos = resultermos * Int32.Parse(separado[0]);
                    }
                    else if (termos[i][1] == 'X' && separado.Length != 2)//se tiver 2 elementos e o segundo for X 
                    {
                        resultermos = valorx * Int32.Parse(separado[0]);
                    }
                    else
                    {
                        resultermos = Double.Parse(termos[i]);
                    }

                    resultados[i] = resultermos; //armazena o resultado do termo em um vetor na posição correspondente
                    Console.WriteLine($"O valor do termo {i + 1} é {resultados[i]}");
                }

                //faz o cálculo da equação e devolve o limite
                if (operacoes[0] == "+")
                {
                    result = resultados[0] + resultados[1];
                }
                else
                {
                    result = resultados[0] - resultados[1];
                }

                if (operacoes[1] == "+")
                {
                    result = result + resultados[2];
                }
                else
                {
                    result = result - resultados[2];
                }

                Console.WriteLine($"O limite é: {result}");
            }





            Console.ReadKey();
        }
    }
}
