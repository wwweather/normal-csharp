/* Условие задачи:

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

int Prompt (string message)
{
    System.Console.Write(message)
    system value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

static List<uint> UintToDigits(uint number) /* Диапазоны uint​. UInt8 — [0 : 255]; UInt16 — [0 : 65535]; UInt32 — [0 : 4294967295]; UInt64 — [0 : 18446744073709551615] */

{
    var digits = new List<uint>();
    while (number > 0)
    {
        digits.Add(number % 10);
        number /= 10;
    }
    return digits;
}

static bool IsPalindrom(uint number)
{
    var digitList = UintToDigits(number);
    for (int firstIndex = 0, lastIndex = digitList.Count - 1; firstIndex < lastIndex; ++firstIndex, --lastIndex)
    {
        if (digitList[firstIndex] != digitList[lastIndex]) return false;
    }
    return true;
}

int num = Prompt("Введите пятизначное число: ");
if (num < 100000 || num >= 10000)
{
    Console.WriteLine("Это не пятизначное число!");
    return;
}

 if (IsPalindrom(List(num)) == True)
    Console.WriteLine("Это число является палиндромом.");
 else
    Console.WriteLine("Это число не является палиндромом.");
    
break
