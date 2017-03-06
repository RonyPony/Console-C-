using System;
public class Example
{
   public static void Main()
   {
     Console.WriteLine("Ingrese un numero");
     int numero = Convert.ToInt32(Console.ReadLine());
     //string enteroStr = Convert.ToString(numero);
     if (numero <= -1) {
       Console.WriteLine("El numero ingresado si es negativo");
     } else{Console.WriteLine("El numero ingresado no es negativo");}
}
}
