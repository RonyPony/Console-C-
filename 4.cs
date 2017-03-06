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
  int num1 = Convert.ToInt32(primero);
  int num2 = Convert.ToInt32(segundo);
  Console.WriteLine("La suma del primer digito y el sgundo es: "+(num1+num2));
}
}
}
