//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(string strArray)
{
    string[] nums = strArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int CountPositive(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if(el > 0) count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] numArray = GetArray(input);
int count = CountPositive(numArray);
Console.WriteLine($"{count} чисел больше нуля");