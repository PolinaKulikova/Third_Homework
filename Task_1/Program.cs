// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = number.преобразование в массив();

// int[] array = {1, 2, 8, 2, 1};
// int[] array = {2, 3, 4, 3, 2};

int[] array = {1, 4, 2, 1, 2};
if (array[0] == array[4] || array[1] == array[3])
{
    Console.WriteLine("Да");
} 

// else if ( array.Length>5 || array.Length < 5 )
// {
//    Console.WriteLine("В этом числе не 5 цифр"); 
// }

else
{
    Console.WriteLine("Нет");
}
