/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Введите ряд чисел, разделенных запятой, без пробелов : ");
string seriesOfNumbers = Console.ReadLine();
seriesOfNumbers = seriesOfNumbers + ",";   

int[] ArrayOfNumbers(string seriesOfNumbers)
{ 
  int[] arrayOfNumbers = new int[1];    
  int j =0;
  for (int i = 0; i < seriesOfNumbers.Length; i++)
  {
    string seriesNew1 = string.Empty;
    while (seriesOfNumbers[i] != ',' && i < seriesOfNumbers.Length){
      seriesNew1 += seriesOfNumbers[i];
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
    if (i < seriesOfNumbers.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayOfNumbers;
}
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 
int[] arrayOfNumbers =  ArrayOfNumbers(seriesOfNumbers);
PrintArry(arrayOfNumbers);
