using System;

public class example{

  public static void Main()
  {
    Console.WriteLine("Inserte un numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    int num = 0;
  do {
    Console.WriteLine(num);
    num = num+1;
  } while (num<=numero);
    /*
    int entero = Convert.ToInt32(Console.ReadLine());
    string enteroStr = Convert.ToString(entero);
    string primero = enteroStr.Substring(enteroStr.Length -4, 1);
    string segundo = enteroStr.Substring(enteroStr.Length -3, 1);
    string tercero = enteroStr.Substring(enteroStr.Length -2, 1);
    string cuarto = enteroStr.Substring(enteroStr.Length -1, 1);
    int A = Convert.ToInt32(primero);
    int B = Convert.ToInt32(segundo);
    int C = Convert.ToInt32(tercero);
    int D = Convert.ToInt32(cuarto);
    Console.WriteLine((A+B+C+D));
    */
  }
}
