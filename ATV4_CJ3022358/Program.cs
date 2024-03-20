namespace ATV4_CJ3022358
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            float n1, n2, op;

            Console.WriteLine("digitw um numero de n1 ; ");
            n1 = float.Parse(Console.ReadLine());


            Console.WriteLine("digitw um numero de n2 ; ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("digitw um numero das operação : 1 - multiplicação. 2 - divisão, 3 - soma  4 - subitração ");
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
            }
        }
    }
}
