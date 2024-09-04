
#region patterns
// Problem Statement: Given an integer N, print the following pattern.
/*
             * * *
             * * *
             * * *
 */

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}


//Problem Statement: Given an integer N, print the following pattern : 

/* 

*
* *
* * *
* * * *
* * * * *
 
*/

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for(int i = 0; i < n; i++)
//{
//    for(int j = 0; j<=i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}



// Pattern - 3: Right-Angled Number Pyramid

/* 

1
1 2 
1 2 3
 
*/

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write((j + 1) + " ");
//    }
//    Console.WriteLine();
//}




// Pattern - 4: Right-Angled Number Pyramid - II

/* 

1
2 2
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
 
*/

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}


// Pattern-5: Inverted Right Pyramid

/* 

* * * * * *
* * * * * 
* * * * 
* * * 
* * 
* 
 
*/

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = n; i > 0; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}


//for (int i = 1; i <= n; i++)
//{
//    for (int j = i; j <= n; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}



// Pattern - 6: Inverted Numbered Right Pyramid

/* 

Input Format: N = 6
Result:
1 2 3 4 5 6
1 2 3 4 5
1 2 3 4
1 2 3
1 2 
1
 
*/

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = n; i > 0; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}



// Pattern - 7: Star Pyramid

/* 

Input Format: N = 3
Result: 
  *  
 *** 
*****
 
Input Format: N = 6
Result:
     *     
    ***    
   *****   
  *******  
 ********* 
***********
*/

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    for (int k = 1; k <= n - i; k++)
//    {
//        Console.Write(" ");
//    }

//    for (int j = 1; j <= (i + (i - 1)); j++)
//    {
//        Console.Write("*");
//    }

//    for (int k = 1; k <= n - i; k++)
//    {
//        Console.Write(" ");
//    }

//    Console.WriteLine();
//}



// Pattern - 8: Inverted Star Pyramid

/* 

Input Format: N = 3
Result: 
*****  
 ***
  *   
  
Input Format: N = 6
Result:     
***********
 *********
  *******
   ***** 
    ***    
     *
     
***********
 *********
  *******
   *****
    ***
     *
*/

//Console.Write("Please enter the value of N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = n; i > 0; i--)
//{
//    for (int k = 1; k <= n - i; k++)
//    {
//        Console.Write(" ");
//    }

//    for (int j = 1; j <= (i + (i - 1)); j++)
//    {
//        Console.Write("*");
//    }

//    for (int k = 1; k <= n - i; k++)
//    {
//        Console.Write(" ");
//    }

//    Console.WriteLine();
//}

#endregion


using System.Linq.Expressions;

int n = Convert.ToInt32(Console.ReadLine());
List<List<int>> myList = new List<List<int>>();
List<int> leftDiagonal = new();
List<int> rightDiagonal = new();

for (int i = 0; i < n; i++)
{
    myList.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(c => Convert.ToInt32(c)).ToList());
}

//foreach (var item in myList)
//{
//    Console.WriteLine("************");
//    foreach (var item2 in item)
//    {
//        Console.WriteLine(item2);
//    }
//}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j == i)
            leftDiagonal.Add(myList[j][i]);
    }
}

for (int i = 0; i<n; i++)
{
    for (int j = myList.Count - 1; j >= 0; j--)
    {
        if (j == i)
            rightDiagonal.Add(myList[i][j]);
    }
}

Console.WriteLine($"Diagonal Difference: {Math.Abs(leftDiagonal.Sum() - rightDiagonal.Sum())}");