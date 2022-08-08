// Создание программы которая на вход принимает массив элементов,
// и выдает элементы длинна которых меньше либо равно 3х символов
namespace ZadachaKontrol
{
   class Zadachi
    {
         static void Main(string[] args)
        {
          Console.WriteLine("Доброго времени, сколько элементов будет в Вашем массиве? ");
          int m = Convert.ToInt32(Console.ReadLine());
          string[] massiv = new string[m];
          int n = 0;
          while (n<m)
           {
             Console.WriteLine($"Введите {n+1} элемент массива: ");
             massiv[n] = Console.ReadLine();
             n++;
           }
          Console.WriteLine();
          Console.WriteLine("Элементы массива где символов меньше либо равно 3: ");
          for (int i = 0; i < massiv.Length; i++)
           {
            if (massiv[i].Length <= 3)
            Console.Write(massiv[i] + "\t");
           }
          Console.ReadKey();
         }
     }  
}   