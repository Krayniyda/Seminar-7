Console.Clear();
        
Console.WriteLine("Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.");

        FillArray();
       
        void FillArray()
        {
            Console.WriteLine("Введите размер двумерного массива m x n: ");
            Console.Write("количество строк" + "\t" + "m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("количество столбцов" + "\t" + "n = ");
            int n = Convert.ToInt32(Console.ReadLine()); 

            double[,] array = new double[m, n];
            Random random = new Random();
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Math.Round((random.NextDouble() * 200 - 100), 2);
                    Console.Write("{0, 10}", (array[i, j]).ToString("0.00"));
                }
            Console.WriteLine();
            }
        }




    