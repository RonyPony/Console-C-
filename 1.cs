using System;
public class Example
{
   public static void Main()
   {
     Console.WriteLine("Ingrese un numero");
     int numero = Convert.ToInt32(Console.ReadLine());
     string enteroStr = Convert.ToString(numero);
     string ultimoDigito = enteroStr.Substring(enteroStr.Length -1, 1);
  //   Console.WriteLine(ultimoDigito);
     if (ultimoDigito == "4") {
       Console.WriteLine("El numero ingresado si termina en cuatro");
     } else{Console.WriteLine("El numero ingresado no termina en cuatro");}
}
}
