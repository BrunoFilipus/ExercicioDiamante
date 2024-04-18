namespace ExercícioDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TamanhoDiamante = 0;
            
            while (TamanhoDiamante % 2 == 0)
            {
                Console.Write("Entre com o tamanho do diamante (deve ser um valor ímpar): ");
                TamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            }

            int MeioDiamante = TamanhoDiamante / 2;
            Console.WriteLine();

            for (int i = 0; i < MeioDiamante; i++)
            {
                for (int j = 0; j < TamanhoDiamante; j++)
                {
                    ValidarCorpoDiamante(MeioDiamante, i, j);
                }
                Console.WriteLine();
            }
            
            for (int i = MeioDiamante - 1; i >= 0; i--)
            {
                for (int j = 0; j < TamanhoDiamante; j++)
                {
                    ValidarCorpoDiamante(MeioDiamante, i, j);
                }
                Console.WriteLine();
            }
        }
        private static void ValidarCorpoDiamante(int MeioDiamante, int i, int j)
        {
            if (j >= MeioDiamante - i && j <= MeioDiamante + i)
            {
                Console.Write("x");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}
