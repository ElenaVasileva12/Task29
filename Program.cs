// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] array1)  //заполнение массива
{
    Random rn = new Random();  //чтобы в каждой итерации цикла не создавать цикл
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = rn.Next(101);  //2 так как последнее число не включено в диапазон
        Console.Write(array1[i] + ", ");
    }
}

void PrintArray(int[] arr)  //вывод массива
{ 
    Console.Write("-> [");
    for (int i = 0; i < arr.Length; i++)
    {
        
        Console.Write(arr[i]+ ", ");
        
    }
    Console.Write("]");

}

int[] array = new int[8];  //создание массива

FillArray(array); 
PrintArray(array);

