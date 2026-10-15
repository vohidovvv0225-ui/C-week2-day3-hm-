// // int EvenCount(int n)
// // {
// //     int cnt = 0;

// //     for (int i = n; i > 0; i /= 10)
// //     {
// //         if (i % 10 % 2 == 0)
// //         {
// //             cnt++;
// //         }
// //     }

// //     return cnt;
// // }

// // int OddCount(int n)
// // {
// //     int cnt = 0;

// //     for (int i = n; i > 0; i /= 10)
// //     {
// //         if (i % 10 % 2 != 0)
// //         {
// //             cnt++;
// //         }
// //     }

// //     return cnt;
// // }

// // int ZeroCount(int n)
// // {
// //     int cnt = 0;

// //     for (int i = n; i > 0; i /= 10)
// //     {
// //         if (i % 10 == 0)
// //         {
// //             cnt++;
// //         }
// //     }

// //     return cnt;
// // }

// // int DigitCount(int n)
// // {
// //     int cnt = 0;

// //     if (n == 0)
// //         return 1;

// //     for (int i = n; i > 0; i /= 10)
// //     {
// //         cnt++;
// //     }

// //     return cnt;
// // }

// // int MinDigit(int n)
// // {
// //     if (n == 0)
// //         return 0;

// //     int min = 9;

// //     for (int i = n; i > 0; i /= 10)
// //     {
// //         min = Math.Min(min, i % 10);
// //     }

// //     return min;
// // }

// // int MaxDigit(int n)
// // {
// //     int max = 0;

// //     for (int i = n; i > 0; i /= 10)
// //     {
// //         max = Math.Max(max, i % 10);
// //     }

// //     return max;
// // }

// // int SumDigit(int n)
// // {
// //     int sum = 0;

// //     for (int i = n; i > 0; i /= 10)
// //     {
// //         sum += i % 10;
// //     }

// //     return sum;
// // }

// // int n = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Even: " + EvenCount(n));
// // Console.WriteLine("Odd: " + OddCount(n));
// // Console.WriteLine("Zero: " + ZeroCount(n));
// // Console.WriteLine("Digits: " + DigitCount(n));
// // Console.WriteLine("Min: " + MinDigit(n));
// // Console.WriteLine("Max: " + MaxDigit(n));
// // Console.WriteLine("Sum: " + SumDigit(n));

// // tski2
// // char CheckGrade(int grade)
// // {
// //     if (grade >= 90 && grade <= 100)
// //     {
// //         return 'A';
// //     }
// //     else if (grade >= 80)
// //     {
// //         return 'B';
// //     }
// //     else if (grade >= 70)
// //     {
// //         return 'C';
// //     }
// //     else if (grade >= 60)
// //     {
// //         return 'D';
// //     }
// //     else
// //     {
// //         return 'F';
// //     }
// // }

// // int grade = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(CheckGrade(grade));

// taski 3

// int n = Convert.ToInt32(Console.ReadLine());

// int positive = 0;
// int sss = 0;
// int s2 = 0;
// int cnt = 0;
// int odd = 0;
// int max = int.MinValue;
// int min = int.MaxValue;
// int sum = 0;

// for (int i = 0; i < n; i++)
// {
//     int a = Convert.ToInt32(Console.ReadLine());

//     if (a > 0)
//         positive++;
//     else if (a < 0)
//         sss++;
//     else
//         s2++;

//     if (a % 2 == 0)
//         cnt++;
//     else
//         odd++;

//     if (a > max)
//         max = a;

//     if (a < min)
//         min = a;

//     int num = Math.Abs(a);

//     for (; num > 0; num /= 10)
//     {
//         sum += num % 10;
//     }
// }

// Console.WriteLine("Negative = " + sss);
// Console.WriteLine("Positive = " + positive);
// Console.WriteLine("Zeros = " + s2);
// Console.WriteLine("Even = " + cnt);
// Console.WriteLine("Odd = " + odd);
// Console.WriteLine("Max = " + max);
// Console.WriteLine("Min = " + min);
// Console.WriteLine("Sum of Digits = " + sum);

// taski 5
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < n; i++)
// {
//     bool found = false;

//     for (int j = 0; j < i; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             found = true;
//             break;
//         }
//     }

//     if (found)
//     {
//         continue;
//     }

//     for (int j = i + 1; j < n; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             Console.Write(arr[i] + " ");
//             break;
//         }
//     }
// }

// taski 7


// Console.Write("From=");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("To=");
// int y = Convert.ToInt32(Console.ReadLine());

// for (int i = x; i <= y; i++)
// {


//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}x{j}= {i * j}");
//     }
// }


// taski 9

// int Power(int number, int exponent)
// {
//     if (exponent == 0)
//     {
//         return 1;
//     }

//     return number * Power(number, exponent - 1);
// }

// Console.Write("Input the base value : ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the exponent : ");
// int exponent = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"The value of {number} to the power of {exponent} is : {Power(number, exponent)}");

// taski 10

int Fibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }

    if (n == 1)
    {
        return 1;
    }

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.Write("Input number of terms for the Fibonacci series : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"The Fibonacci series of {n} terms is : ");

for (int i = 0; i < n; i++)
{
    Console.Write(Fibonacci(i) + " ");
}


