using System;
public class Example
{
   public static void Main()
   {
     Console.WriteLine("Ingrese un numero");
     int numero = Convert.ToInt32(Console.ReadLine());
     string enteroStr = Convert.ToString(numero);
     if (enteroStr.Length.Equals(3)) {
       Console.WriteLine("El numero ingresado si tiene tres digitos");
     } else{Console.WriteLine("El numero ingresado no tiene tres digitos");}
}
}
