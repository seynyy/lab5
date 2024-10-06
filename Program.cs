using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab5
{
    class Program
    {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;

            //task1
            {
                int[,] matrix = new int[9,9];
                Random random= new Random();

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        matrix[i,j] = random.Next(0, 100);
                        Console.Write($"{matrix[i,j],2} ");
                    }
                    Console.Write("\n");
                }

                Console.WriteLine("--------------------------");

                int minValue = 100;
                int row = 0;    
                int column = 0;

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        if (matrix[i, j] <= minValue){
                            minValue = matrix[i, j];
                            row = i;
                            column = j;
                        }
                    }
                }

                for (int i = 0; i < matrix.GetLength(0); i++) {
                    for (int j = 0; j < matrix.GetLength(1); j++) {
                        if (row != i && column != j)
                            Console.Write($"{matrix[i,j],2} ");
                    }
                    if (row != i) 
                        Console.Write("\n");
                }

                Console.WriteLine("--------------------------");
            }

            //task2 : 0 - парне число
            {
                int[] array = new int[20];
                Random random= new Random();
                
                for (int i = 0; i < array.Length; i++) {
                    array[i] = random.Next(0, 20);
                    Console.Write(array[i] + " ");
                }

                for(int i = 0; i < array.Length; i++) {
                    for (int j = i + 2; j < array.Length; j+=2) {
                        if ((i % 2 == 0 && array[i] > array[j]) || (i % 2 != 0 && array[i] < array[j])){
                            (array[j], array[i]) = (array[i], array[j]);
                        }
                    }
                }

                Console.WriteLine("\n--------------------------");

                for (int i = 0; i < array.Length; i++) {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}