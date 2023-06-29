***Задача***: 

*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

***Решение***: 

1. В условиях задачи чётко не обозначено, откуда взять изначальные данные для массива строк.
Будем считать, что их должен ввести пользователь.
Пусть он же задаст размерность массива.
Для этого напишем следующий код:

```
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
```
2. Теперь размер массива определён как **n**.
Пропишем код для обработки пользовательского ввода содержимого строк:
```
int i = 0;
while (i < array.Length)
{
    Console.WriteLine($"Введите {i + 1}ю строку: ");    
    array[i] = Console.ReadLine(); 
    i++;   
}
```
Т.к. нумерация элементов массива начинается с нуля, мы просим пользователя ввести **i+1*****ю*** строку. 

Реализация будет выглядеть примерно так.
![Пользовательский ввод](p1.jpeg)

Перейдём к написанию алгоритма для решения основной задачи.

3. Я позволил себе небольшое допущение и предположил, что в случае, если 

