﻿//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array1 = new string[10] {"2546", "3455", "HEL", "L", "O", "WO", "RL", "D", "12648", "66655"};
string[] array2 = new string[array1.Length];
void Create(string[] array1, string[] array2)
{
int count = 0;
for(int i = 0; i < array1.Length; i++)





 {
  if(array1[i].Length <= 3)
    {
    array2[count] = array1[i];
    count++;
    }
 }
}




void Show(string[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]}.");
}
Console.WriteLine();
}

Create(array1, array2);
Show(array2);