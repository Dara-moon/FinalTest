
Console.Write($"Введите через запятую массив строк:");

string inputLine = Console.ReadLine();        //считываем строку с консоли
string[] A = inputLine.Split(",");          //создаём массив строк из исходной строки через функцию Split
string[] B = filterArray (A, 3);            //создаём результирующий массив
DisplayArray (B);

string[] filterArray (string[] inArray, int n) //функция возвращает массив значения элементов которого <= n
{
    string[] tempArray = new string[inArray.Length];    //создаём временный массив равный по размеру исходному
    int k = 0;                                          //переменная для хранения количество элементов массива соответсвующих условию <= n 

    for (int i = 0; i < inArray.Length; i++)            //цикл прохода по исходному массиву
    {
        if (inArray[i].Length <= n)                     //проверка на условие
        {
            tempArray[k] = inArray[i];                  //копирование отобраных элементов во временный массив
            k++;                                        
        }
    }

    string[] outArray = new string[k];                  //создание итогового массива требуемого размера
    for (int i = 0; i < outArray.Length; i++)           //цикл копирования элементов временного массива в итоговый массив
    {
        outArray[i] = tempArray[i];
    }
    return outArray;                                    //возврат итогового массива
}

void DisplayArray(string[] displayArray)                //вывод элементов массива через ","
{
    for (int i = 0; i < displayArray.Length; i++)
    {
        Console.Write(displayArray[i]);
        Console.Write(",");
    }
}
