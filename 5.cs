using System;
public class Example
{
   public static void Main()
   {
     Console.WriteLine("Ingrese un numero de dos digitos");
     int numero = Convert.ToInt32(Console.ReadLine());
     string enteroStr = Convert.ToString(numero);
if (enteroStr.Length!=2) {
  Console.WriteLine("El numero debe contener solo dos digitos");
}else{
  string primero = enteroStr.Substring(enteroStr.Length -2, 1);
  string segundo = enteroStr.Substring(enteroStr.Length -1, 1);

  int primerValor = Convert.ToInt32(primero);
  int segundoValor = Convert.ToInt32(segundo);
if((primerValor % 2) == 0 && (segundoValor % 2) == 0)
    Console.WriteLine("Ambos digitos son pares");
else
    Console.WriteLine("No son pares ambos digitos");

}
}
}
