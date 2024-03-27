//////////////////////////////////////atividade 1////////////////////////////////////////
namespace ATV4_CJ3022358
{

    internal class Program
    {
        static void Main(string[] args)
        {



            float n1, n2, op;

            Console.WriteLine("digite um numero de n1 ; ");
            n1 = float.Parse(Console.ReadLine());


            Console.WriteLine("digite um numero de n2 ; ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("digite um numero das operação : 1 - multiplicação. 2 - divisão, 3 - soma  4 - subitração ");
            op = float.Parse(Console.ReadLine());


            switch (op)
            {


                case 1:
                    Console.WriteLine("multiplicação  = {0} ", n1 * n2);


                    break;

                case 2:
                    Console.WriteLine("Divisão = {0}", n1 / n2);
                    break;
                case 3:
                    Console.WriteLine(" soma {0} ", n1 + n2);
                    break;
                case 4:
                    Console.WriteLine("subitração {0} ", n1 - n2);
                    break;

                default:

                    Console.WriteLine("opcão ivalida  ");
                    break;





                    {
                        Console.WriteLine("Digite um número de 1 a 7 para representar o dia da semana:");
                        int numeroDia = int.Parse(Console.ReadLine());

                        string diaSemana;

                        switch (numeroDia)
                        {
                            case 1:
                                diaSemana = "Domingo";
                                break;
                            case 2:
                                diaSemana = "Segunda-feira";
                                break;
                            case 3:
                                diaSemana = "Terça-feira";
                                break;
                            case 4:
                                diaSemana = "Quarta-feira";
                                break;
                            case 5:
                                diaSemana = "Quinta-feira";
                                break;
                            case 6:
                                diaSemana = "Sexta-feira";
                                break;
                            case 7:
                                diaSemana = "Sábado";
                                break;
                            default:
                                diaSemana = "Número inválido";
                                break;


                                Console.WriteLine("O número " + numeroDia + " representa o dia da semana: " + diaSemana);








                                int mes;
                                Console.WriteLine("escreva um mês ");
                                mes = int.Parse(Console.ReadLine());


                                switch (mes)
                                {


                                    case 1:
                                        Console.WriteLine(" janeiro  = 31 dias  ");


                                        break;

                                    case 2:
                                        Console.WriteLine("fevereiro = 29 dias ");
                                        break;
                                    case 3:
                                        Console.WriteLine(" março = 31 dias  ");
                                        break;
                                    case 4:
                                        Console.WriteLine("abril  = 30 dias ");
                                        break;

                                    case 5:

                                        Console.WriteLine(" maio  = 31 dias ");
                                        break;

                                    case 6:
                                        Console.WriteLine(" junho  =   30 dias ");
                                        break;

                                    case 7:
                                        Console.WriteLine(" julho =  31 dias ");
                                        break;

                                    case 8:
                                        Console.WriteLine(" agosto = 31 dias");
                                        break;

                                    case 9:
                                        Console.WriteLine("setembro =  30 dias ");
                                        break;

                                    case 10:
                                        Console.WriteLine(" outubro = 31 dias ");
                                        break;

                                    case 11:
                                        Console.WriteLine(" novembro = 30 dias  ");
                                        break;

                                    case 12:
                                        Console.WriteLine(" desembro = 31 dias  ");
                                        break;








                                        Console.WriteLine("Informe o valor total da compra:");
                                        double valorTotal = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Selecione a forma de pagamento (1 - Dinheiro, 2 - PIX, 3 - Débito, 4 - Cartão de Crédito):");
                                        int formaPagamento = int.Parse(Console.ReadLine());

                                        double valorFinal;

                                        switch (formaPagamento)
                                        {
                                            case 1:
                                                valorFinal = valorTotal * 0.85;
                                                break;
                                            case 2:
                                                valorFinal = valorTotal * 0.9;
                                                break;
                                            case 3:
                                                valorFinal = valorTotal * 1.05;
                                                break;
                                            case 4:
                                                valorFinal = valorTotal * 1.1;
                                                break;
                                            default:
                                                Console.WriteLine("Forma de pagamento inválida!");
                                                return;
                                        }

                                        Console.WriteLine("Valor final a ser pago: R$ " + valorFinal.ToString("F2"));






                                        Console.WriteLine("Digite o salário atual do funcionário:");
                                        double salarioAtual = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o código do cargo do funcionário (101, 102, 103, 204, 206, 301, 302):");
                                        int codigoCargo = int.Parse(Console.ReadLine());

                                        double percentualAumento;

                                        switch (codigoCargo)
                                        {
                                            case 101:
                                                percentualAumento = 7.5;
                                                break;
                                            case 102:
                                                percentualAumento = 9.7;
                                                break;
                                            case 103:
                                                percentualAumento = 11.7;
                                                break;
                                            case 204:
                                                percentualAumento = 8.9;
                                                break;
                                            case 206:
                                                percentualAumento = 13.24;
                                                break;
                                            case 301:
                                                percentualAumento = 10.4;
                                                break;
                                            case 302:
                                                percentualAumento = 14.6;
                                                break;
                                            default:
                                                percentualAumento = 43.5;
                                                break;
                                        }

                                        double novoSalario = salarioAtual + (salarioAtual * (percentualAumento / 100));
                                        double diferenca = novoSalario - salarioAtual;

                                        Console.WriteLine("Salário antigo: R$ " + salarioAtual.ToString("F2"));
                                        Console.WriteLine("Novo salário: R$ " + novoSalario.ToString("F2"));
                                        Console.WriteLine("Diferença: R$ " + diferenca.ToString("F2"));


                                        Console.WriteLine("Digite o salário mensal do trabalhador:");
                                        double salario = double.Parse(Console.ReadLine());

                                        double imposto;

                                        if (salario <= 1903.98)
                                        {
                                            imposto = 0;
                                        }
                                        else if (salario <= 2826.65)
                                        {
                                            imposto = salario * 0.075;
                                        }
                                        else if (salario <= 3751.05)
                                        {
                                            imposto = salario * 0.15;
                                        }
                                        else if (salario <= 4664.68)
                                        {
                                            imposto = salario * 0.225;
                                        }
                                        else
                                        {
                                            imposto = salario * 0.275;
                                        }

                                        double salarioLiquido = salario - imposto;

                                        Console.WriteLine("Imposto a ser recolhido: R$ " + imposto.ToString("F2"));
                                        Console.WriteLine("Salário líquido: R$ " + salarioLiquido.ToString("F2"));
                                }
                        }






                    }
            }
        }

    }
      }
    







