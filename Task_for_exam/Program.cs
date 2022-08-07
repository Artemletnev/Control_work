// The Task
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Solution without using methods

string[] standartArray = { "3213", "22222", "W", "=3", "543" };
int lengthFinishArray = 0;


for (int i = 0; i < standartArray.Length; i++)
{
    if (standartArray[i].Length < 4)
    {
        lengthFinishArray++;
    }
}
string[] finishArray = new string[lengthFinishArray];

int count = 0;
for (int i = 0; i < standartArray.Length; i++)
{
    if (standartArray[i].Length < 4)
    {
        finishArray[count] = standartArray[i];
        count++;
    }
}

Console.WriteLine($"[{String.Join("; ", finishArray)}]");



