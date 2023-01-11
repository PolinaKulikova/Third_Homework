// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());

// int number = 3;
// int number = 5;

int count = 1;

while (count <= number)
{
   Console.WriteLine(count*count*count);
   count = count + 1;
      
}



