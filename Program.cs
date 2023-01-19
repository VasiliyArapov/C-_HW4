// 1 Задача
// Console.WriteLine("Input two numbers:");
// int num1 = int.Parse(Console.ReadLine()!);
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{num1} to the {num2} power equals {GetPower(num1, num2)}");

// 2 Задача
// Console.Write("Input a number: ");
// int numb = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"The summ of the digits in {numb} equals {GetDigitSum(numb)}");

// 3 Задача
// int[] arr = GetArr(8);
// Console.WriteLine($"[{String.Join(',', arr)}]");





// -------------Methods----------------

int GetPower(int a, int b)
{
    if(b == 0) return 1;
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res = res * a;
    }
    return res;
}

int GetDigitSum(int a)
{
    string strNum = a.ToString();
    int sum = 0;
    for (int i = 0; i < strNum.Length; i++)
    {
        string sn = Convert.ToString(strNum[i]);
        int num = Convert.ToInt32(sn);
        sum = sum + num;
    }
    return sum;
}

int[] GetArr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(10);
    }
    return arr;
}