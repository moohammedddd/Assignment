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



        }
    }
}
