
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


//using System.Linq.Expressions;

//int n = Convert.ToInt32(Console.ReadLine());
//List<List<int>> myList = new List<List<int>>();
//List<int> leftDiagonal = new();
//List<int> rightDiagonal = new();

//for (int i = 0; i < n; i++)
//{
//    myList.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(c => Convert.ToInt32(c)).ToList());
//}

//foreach (var item in myList)
//{
//    Console.WriteLine("************");
//    foreach (var item2 in item)
//    {
//        Console.WriteLine(item2);
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (j == i)
//            leftDiagonal.Add(myList[j][i]);
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    for (int j = myList.Count - 1; j >= 0; j--)
//    {
//        if (i == (n - 1 - j))
//            rightDiagonal.Add(myList[i][j]);
//    }
//}

//Console.WriteLine(Math.Abs(leftDiagonal.Sum() - rightDiagonal.Sum()));

//List<int> n = new() { 4, 4, 3, 1 };

//var largest = n.GroupBy(c => c).Select(c => new { CountValue = c.ToList().Count })
//    .OrderByDescending(c=> c.CountValue).FirstOrDefault();
//Console.WriteLine(largest.CountValue);


//int n = 0;
//List<int> tp = new();
//List<int> st = new();

//n = Convert.ToInt32(Console.ReadLine());
//string s = Console.ReadLine();
//string ss = Console.ReadLine();

//tp = s.Split(' ').ToList().Select(c=> Convert.ToInt32(c)).ToList();
//st = ss.Split(' ').ToList().Select(c=> Convert.ToInt32(c)).ToList();

//int carraySum = 0;
//int finalSum = 0;

//for(int i=0; i<n; i++)
//{
//    if(i == 0)
//    {
//        carraySum = tp[i];
//        finalSum = (tp[i] + st[i]) + 1;
//    }
//    else
//    {
//        finalSum = (tp[i] + carraySum + st[i])+1;
//        carraySum += tp[i];
//    }
//}


//Console.WriteLine(finalSum);

//Dictionary<string, int> outputs = new();
//Dictionary<string, int> tags = new();


//string value = Console.ReadLine();

//char startTag = '<';
//char endTag = '>';
//char closeBrc = '/';

//string tag = "";
//bool isClosingTag = false;

//for (int i = 0; i < value.Length; i++)
//{
//    if (value[i] == startTag)
//    {
//        tag = "";
//        tag += value[i];
//        //isClosingTag = false;
//    }
//    else if (value[i] == endTag)
//    {
//        tag += value[i];
//        if (tag.Contains("/"))
//        {
//            var tagValueToRemove = tags.FirstOrDefault(c => c.Key == tag.Replace("<", "").Replace(">", "").Replace("/", ""));
//            outputs.Add(tagValueToRemove.Key, tagValueToRemove.Value);
//        }

//        //isClosingTag = true;
//    }
//    else if (value[i] == closeBrc)
//    {
//        //isClosingTag = false;
//        tag += value[i];
//    }
//    else
//    {
//        if (!string.IsNullOrEmpty(tag))
//        {
//            //if (!isClosingTag)
//            //{
//            //    tag += value[i];
//            //}
//            if (!tag.EndsWith(">"))
//                tag += value[i];

//            //if (outputs.ContainsKey(tag.Replace("<", "").Replace(">", "").Replace("/", ""))
//            //    && isClosingTag && tag.Contains(">"))
//            //{
//            //    outputs[tag.Replace("<", "").Replace(">", "").Replace("/", "")] += 1;
//            //}

//            if(tag.EndsWith(">"))
//            {
//                AddValueToTag(tags, tag);
//            }

//        }
//    }


//}

//foreach (var key in outputs)
//{
//    if (key.Value > 0)
//        Console.WriteLine($"{key.Key}: {key.Value}");
//}


//static void AddValueToTag(Dictionary<string, int> tags, string tag)
//{
//    if (!tags.ContainsKey(tag.Replace("<", "").Replace(">", "").Replace("/", "")))
//    {

//    }

//    foreach (var key in tags)
//    {
//        tags[key.Key] += 1;
//    }
//}


////int T = int.Parse(Console.ReadLine()); // Number of test cases
////while (T-- > 0)
////{
////    var inputs = Console.ReadLine().Split();
////    int N = int.Parse(inputs[0]); // Length of string S
////    int K = int.Parse(inputs[1]); // Length of block

////    string S = Console.ReadLine(); // The binary string

////    // Use a hash set to store all substrings of length K in S
////    HashSet<string> substrings = new HashSet<string>();
////    for (int i = 0; i <= N - K; i++)
////    {
////        substrings.Add(S.Substring(i, K));
////    }

////    // Try all possible binary strings of length K (from "000...0" to "111...1")
////    bool found = false;
////    for (int i = 0; i < (1 << K); i++) // There are 2^K possible binary strings
////    {
////        char[] candidate = new char[K];
////        for (int j = 0; j < K; j++)
////        {
////            candidate[j] = ((i >> (K - j - 1)) & 1) == 0 ? '0' : '1';
////        }
////        string candidateStr = new string(candidate);

////        // If this candidate is not in the set of substrings, it's our answer
////        if (!substrings.Contains(candidateStr))
////        {
////            Console.WriteLine(candidateStr);
////            found = true;
////            break;
////        }
////    }

////    // If no such string is found, print -1
////    if (!found)
////    {
////        Console.WriteLine("-1");
////    }
////}




// reverse string

//string givenString = Console.ReadLine();

//string outputString = "";

//for(int i= givenString.Length - 1; i>=0; i--)
//{
//    outputString += givenString[i];
//}

//Console.WriteLine(outputString);


// number replacing

//for(int i = 1; i<= 100; i++)
//{
//    if(i% 3 == 0 && i%5 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if(i%3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    } 
//    else if(i%5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}



// string plaindrome checker
//string givenString = Console.ReadLine();
//string reverseString = "";

//for(int i = givenString.Length - 1; i >= 0; i--)
//{
//    reverseString += givenString[i];
//}

//if(reverseString == givenString)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}


//// max num and min num from an array
//int[] a = new int[5] { 3, 4, 1, 10, 7 };

//int max = a[0];
//int min = a[0];
//for(int i = 0; i < a.Length; i++)
//{
//    if (a[i] > max)
//    {
//        max = a[i];
//    }

//    if (a[i] < min)
//    {
//        min = a[i];
//    }
//}

//Console.WriteLine($"Max: {max}, min: {min}");


// array target sum meetups
//int[] a = new int[4] { 2, 7, 11, 15 };
//int target = 26;

//for (int i = 0; i < a.Length; i++)
//{
//    for (int j = i + 1; j < a.Length; j++)
//    {
//        if (a[i] + a[j] == target)
//        {
//            Console.WriteLine($"{a[i]} + {a[j]} == {target}, array lengths are respectedly: {i}, {j}");
//        }
//    }
//}


//// factorials value
//Console.Write("Enter a value of n: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int factorial = GetFactorial(n);
////for (int i = n; i >= 1; i--)
////{
////    factorial *= i;
////}

//Console.WriteLine($"Factorial of {n} = {factorial}");

//static int GetFactorial(int n)
//{
//    if (n == 0)
//        return 1;

//    return n * GetFactorial(n - 1);
//}


// prime number checker
//int n = Convert.ToInt32(Console.ReadLine());
//bool isPrime = IsPrime(n);
////for (int i = 2; i < n; i++)
////{
////    if(n % i == 0)
////    {
////        isPrime = false;
////        break;
////    }
////    else
////    {
////        isPrime = true;
////    }
////}

//Console.WriteLine($"Is Price: {isPrime}");

//static bool IsPrime(int n)
//{
//    if (n <= 1)
//        return false;
//    if (n <= 3)
//        return true;

//    if (n % 2 == 0 || n % 3 == 0)
//        return false;

//    for (int i = 5; i * i <= n; i += 6)
//    {
//        if (n % i == 0 || n % (i + 2) == 0)
//            return false;
//    }

//    return true;
//}


// count vowels and consonants
//string s = Console.ReadLine();
//char[] v = { 'a', 'e', 'i', 'o', 'u' };

//int totalVowels = 0;
//for (int i = 0; i < s.Length; i++)
//{
//    if (v.Contains(s[i]))
//    {
//        totalVowels++;
//    }
//}

//Console.WriteLine($"Total characters: {s.Length}, vowels: {totalVowels}, consonants: {s.Length - totalVowels}");



//// binary search algorithm
//int[] a = { 1, 3, 5, 7, 9, 11, 22, 95 };    // array must be sorted
//Console.WriteLine("Enter the search value: ");
//int target = Convert.ToInt32(Console.ReadLine());

//int left = 0;
//int right = a.Length - 1;
//int mid = 0;
//int? index = default;

//while (left <= right)
//{
//    mid = (left + right) / 2;
//    if (target == a[mid])
//    {
//        index = mid;
//        break;
//    }
//    else if (target > a[mid])
//    {
//        left = mid + 1;
//    }
//    else
//    {
//        right = mid - 1;
//    }
//}

//if (index != null)
//{
//    Console.WriteLine($"Found at {index}");
//}
//else
//{
//    Console.WriteLine("Not found!");
//}


// book price with page problem
//int n = 0, x = 0;
//int[] h = new int[n];
//int[] s = new int[n];
//Dictionary<string, int> sum = new Dictionary<string, int>();
//var bookAndTotalPrice = Console.ReadLine().Split().Select(int.Parse).ToArray();

//n = bookAndTotalPrice.FirstOrDefault();
//x = bookAndTotalPrice.LastOrDefault();

//h = Console.ReadLine().Split().Select(int.Parse).ToArray();
//s = Console.ReadLine().Split().Select(int.Parse).ToArray();

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (i != j)
//        {
//            sum.Add($"{i},{j}", h[i] + h[j]);
//        }
//    }
//}

//int result = 0;
//var items = Array.ConvertAll(sum.Where(c => c.Value <= x).OrderByDescending(c => c.Value).FirstOrDefault().Key.Split(","), int.Parse);
//foreach (var item in items)
//{
//    result += s[item];
//}

//Console.WriteLine(resul11t);


//int n = Convert.ToInt32(Console.ReadLine());
//int missingNum = 0;
//var allNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
//allNums = allNums.OrderBy(c => c).ToArray();

//for (int i = 0; i < n; i++)
//{
//    if (i < allNums.Length)
//    {
//        if ((i + 1) != allNums[i])
//        {
//            missingNum = i + 1;
//            break;
//        }
//    }
//    else
//    {
//        missingNum = i + 1;
//        break;
//    }
//}

//Console.WriteLine(missingNum);


//using System.Numerics;

//const long modValue = 10000000007;
//int n = Convert.ToInt32(Console.ReadLine());

//BigInteger r = BigInteger.ModPow(2, n, modValue);
//Console.WriteLine(r);




//int n = Convert.ToInt32(Console.ReadLine());
//var allNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int m = allNums[0];
//int c = allNums[0];

//for (int i = 1; i < n; i++)
//{
//    int r = c + allNums[i];
//    c = Math.Max(allNums[i], r);
//    m = Math.Max(m, c);
//}

//Console.WriteLine(m);




int n = Convert.ToInt32(Console.ReadLine());
List<int> first = new List<int>();
List<int> second = new List<int>();
int totalSum = 0;
int halfSum = 0;
int currentSum = 0;
for (int i = 1; i <= n; i++)
{
    totalSum += i;
}

if (totalSum % 2 == 0)
{
    Console.WriteLine("YES");
    halfSum = totalSum / 2;

    for (int j = n; j>0; j--)
    {
        if (currentSum + j <= halfSum)
        {
            first.Add(j);
            currentSum += j;
        }
        else
        {
            second.Add(j);
        }
    }

    Console.WriteLine(first.Count);
    Console.WriteLine(string.Join(" ", first));
    Console.WriteLine(second.Count);
    Console.WriteLine(string.Join(" ", second));
}
else
{
    Console.WriteLine("NO");
}



//int n = int.Parse(Console.ReadLine());

//// Calculate the total sum of the first n natural numbers
//int totalSum = n * (n + 1) / 2;

//// Check if the total sum is odd
//if (totalSum % 2 != 0)
//{
//    Console.WriteLine("NO");
//}
//else
//{
//    Console.WriteLine("YES");
//    List<int> set1 = new List<int>();
//    List<int> set2 = new List<int>();
//    int targetSum = totalSum / 2;
//    int currentSum = 0;

//    // Traverse the numbers from n to 1
//    for (int i = n; i > 0; i--)
//    {
//        if (currentSum + i <= targetSum)
//        {
//            set1.Add(i);
//            currentSum += i;
//        }
//        else
//        {
//            set2.Add(i);
//        }
//    }

//    // Print the results
//    Console.WriteLine(set1.Count);
//    Console.WriteLine(string.Join(" ", set1));
//    Console.WriteLine(set2.Count);
//    Console.WriteLine(string.Join(" ", set2));
//}