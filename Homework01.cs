using static Shares;

public class Homework01
{
    //задача 1
    // реализовать перемешивание массива
    public static void Ex001Main()
    {
        int count = Input("Введите размер массива ");
        int[] numbers = CreateArray(count);
        Print1(numbers);
        FillByUser(numbers);
        Print1(numbers);
        // Mix
        Print1(numbers);
    }
}