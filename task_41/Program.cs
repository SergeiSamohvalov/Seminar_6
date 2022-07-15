
namespace Homework_6
{
    public class task_41
    //  Пользователь вводит с клавиатуры M чисел. Посчитайте,
    //  сколько чисел больше 0 ввёл пользователь.
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите желаемое колличество целых чисел(через пробел): ");
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int count = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0) count++;
                }

                Console.WriteLine($"Кол-во элементов больше 0 = {count}");
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
            }


        }
    }
}