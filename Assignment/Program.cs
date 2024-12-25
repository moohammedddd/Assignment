namespace Assignment
{
    internal class Program
    {
        static void PrintShape(int value)

        {
            int sum = 0;
            System.Console.WriteLine("enter the number");
            while (value > 0)
            {
                sum += value % 10;
                value /= 10;
            }
            System.Console.WriteLine(sum);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

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

            #region 25-. Consider an Array of Integer values with size N, having values as in this Example



            //  int [] Marks = new int [5];
            //   for (int x = 0; x < Marks.Length; x++)
            //         {
            //             System.Console.WriteLine($"enter the data {x+1}");
            //             Marks[x] = int.Parse(Console.ReadLine()); // push the data int array 

            //         }       

            //     foreach (int  item in Marks)
            //     {
            //         System.Console.WriteLine(item);
            //     }   
            //    // int [] Marks = {1,2,8,3,5,1,18,5,5,8,2};
            //     int [] Distance = new int [Marks.Length];
            //     int repeted = Marks[0];
            //     for (int i = 0; i < Marks.Length; i++)
            //     {
            //         for (int j = i+1; j < Marks.Length; j++)
            //         {
            //                 if (Marks[j] == Marks[i])
            //             {
            //                     repeted = Marks[j];
            //                     int dis = j - i;
            //                     Distance[i] = dis;   
            //             }

            //         }


            //     }
            //     int LongDistance = Distance[0];
            //     for (int i = 0; i < Distance.Length; i++)
            //     {
            //         if (LongDistance < Distance[i])
            //         {
            //             LongDistance = Distance[i];
            //         }
            //     }

            //     System.Console.WriteLine($" The Bigist Distance is  {LongDistance}");
            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words.
            //  string [,] Marks = new string[2, 1] ;
            //   for (int i = 0; i < Marks.GetLength(0); i++)
            //   { 
            //     for (int j = 0; j < Marks.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine($"enter the data of {i+1}");
            //         Marks[i,j] = Console.ReadLine() ;
            //     }


            //   }

            //     System.Console.WriteLine("your data is");
            //   for (int l = Marks.GetLength(0)-1; l>= 0; l--)
            //      {
            //          for (int m = 0; m < Marks.GetLength(1); m++)
            //          {
            //         System.Console.Write(Marks[l,m]);
            //         }
            //         System.Console.WriteLine("");
            //     }
            #endregion


            #region 27 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.


            //  string [,] Marks02 = new string[2, 2];
            //   string [,] Marks = new string[2, 2] ;
            //   for (int i = 0; i < Marks.GetLength(0); i++)
            //   { 
            //     for (int j = 0; j < Marks.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine($"enter the data of {i+1}");
            //         Marks[i,j] = Console.ReadLine() ;
            //     }
            //     }

            //        for (int l = 0; l < Marks02.GetLength(0);l++)
            //      {
            //          for (int m = 0; m < Marks02.GetLength(1); m++)
            //          {
            //                 Marks02[l,m] = Marks[l,m];
            //         }
            //   }

            //     System.Console.WriteLine("the copied data is ");
            //   for (int k = 0; k < Marks02.GetLength(0); k++)
            //   {
            //     for (int p = 0; p < Marks02.GetLength(1); p++)
            //     {
            //         System.Console.WriteLine(Marks02[k,p]);
            //     }
            //   }
            #endregion

            #region 28 Write a Program to Print One Dimensional Array in Reverse Order
            // int [] Reverse = {1, 2, 3,5};
            // for (int i = Reverse.Length-1; i >= 0; i--)
            // {
            //     System.Console.WriteLine(Reverse[i]);
            // }
            #endregion


            // FUNCTIONS 
            #region 01 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example                
            /*  in value type parmaters it divided two type
              01 by value 
              02 by reference
              in passing by value i pass the copy of data not the address of data 
              simple example 
              ------------------------------------
              if i have value in main function int 5 = 5 ; int y = 10;
              in function tha i passed the value to change the value of x and y to be 10 ,30
              it will be changed but in the function not in main function becused i passed the copy of data 
              when i change the value of data it be changed in function not in main function 
              ---------------------------------------------------------
              but in reference type if i passed the reference to function that have access to main value of reference 
              if i changed the value of x , y to be 20 ,30
              it will be changed in function and main function because i passed the address not copy of data 

             */





            #endregion


            #region 02 	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //  PrintShape(155);
            #endregion


            #region 03  Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .
            // System.Console.WriteLine(IsPrime(5));
            #endregion

        }
    }
}
