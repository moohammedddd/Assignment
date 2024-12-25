namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            // System.Console.WriteLine("enter the number of matrix");
            // int.TryParse(Console.ReadLine(), out int  x);
            // int [,] Identical = new int [x,x];

            // for (int i = 0; i < Identical.GetLength(0); i++)
            // {
            //     for (int j = 0; j < Identical.GetLength(1); j++)
            //     {
            //         if (i == j)
            //         {
            //             Identical[i,j] = 1;
            //         }                      
            //              System.Console.Write(Identical[i,j]);  
            //     }

            //     System.Console.WriteLine("");
            // }

            #endregion

            #region  20- Write a program in C# Sharp to find the sum of all elements of the array
            // int result= 0 ;
            // int [] GetSum = {1,2,3,4,5,6};
            // for (int i = 0; i <GetSum.Length; i++)
            // {
            //     result += GetSum[i];
            // }
            // System.Console.WriteLine(result);
            #endregion

            #region 21  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            // int [] First = {1, 2, 3,4};
            // int [] Second = {5,6,7};
            // int [] Merged = new  int [First.Length + Second.Length]; 
            // Array.ConstrainedCopy(First, 0, Merged,0 ,First.Length);
            // Array.ConstrainedCopy(Second, 0, Merged, First.Length ,Second.Length);
            //     foreach (int i in Merged)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            #endregion

            #region 22  Write a program in C# Sharp to count the frequency of each element of an array.
            // int [] Number = {1,2,3,3,4,4,2,26,6,6,6,6,6};

            // for (int i = 0; i < Number.Length; i++)
            // {
            //     int count = 1;
            //   for (int j = i + 1; j < Number.Length; j++)
            //   {
            //     if (Number[i] == Number[j])
            //     {
            //         count++;
            //     }  
            //   }
            //      if (i == 0 || Number[i] != Number[i - 1])  // not understand 
            //         {
            //             Console.WriteLine($"{Number[i]} {count}");
            //         }
            //     }
            #endregion


            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array
            // first with max value 
            // int[] Degree = {1,0, 2,9, 3,4,8,1};
            // int maxValue = Degree[0];
            // for (int i = 0; i < Degree.Length; i++)
            // {
            //     if (maxValue < Degree[i])
            //     {
            //         maxValue = Degree[i];
            //     }
            // }
            //    System.Console.WriteLine(maxValue);

            // int MinValue = Degree[0];
            // for (int i = 0; i < Degree.Length; i++)
            // {
            //     if (Degree[0] > Degree[i])
            //     {
            //         MinValue = Degree[i];
            //     }
            // }
            //     System.Console.WriteLine(MinValue);
            #endregion

            #region 24 4- Write a program in C# Sharp to find the second largest element in an array
            // int[] Degree = {1, 2, 3,4,8,9,15,64,60};
            // int maxValue = Degree[0];
            // int secound = Degree[0];
            // for (int i= 1; i < Degree.Length; i++)
            // {
            //     if (maxValue < Degree[i])
            //     {
            //         maxValue = Degree[i];

            //     }
            // }
            // System.Console.WriteLine(maxValue);

            // for (int j = 0; j < Degree.Length; j++)
            // {
            //     if (secound < Degree[j] && Degree[j] < maxValue)
            //     {
            //         secound = Degree[j];
            //     }

            // }
            // System.Console.WriteLine(secound);





            #endregion


        }
    }
}
