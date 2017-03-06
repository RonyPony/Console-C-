using System;

public class Example{

  public static void Main(){
    Console.WriteLine("ingrese un numero de tres digitos");
    int numero = Convert.ToInt32(Console.ReadLine());
    string numeroStr = Convert.ToString(numero);
    if (numeroStr.Length.Equals(3)) {
      //Console.WriteLine("Tien etres");
      string primerDigito = numeroStr.Substring(numeroStr.Length -3,1);
      string segundoDigito = numeroStr.Substring(numeroStr.Length -2,1);
      string tercerDigito = numeroStr.Substring(numeroStr.Length -1,1);
      int dig1 = Convert.ToInt32(primerDigito);
      int dig2 = Convert.ToInt32(segundoDigito);
      int dig3 = Convert.ToInt32(tercerDigito);

      Console.WriteLine("Primer digito: "+primerDigito);
      Console.WriteLine("Segundo digito: "+segundoDigito);
      Console.WriteLine("Tercer digito: "+tercerDigito);
      int enteros= 1;
      Console.WriteLine("Los enteros comprendidos entre 1 y el primer digito son ");

      do
      {
          Console.WriteLine(enteros);
          enteros = enteros+1;

      } while (enteros <= dig1);
      Console.ReadKey();

      int enteros2 = 1;
      Console.WriteLine("Los enteros comprendidos entre 1 y el segundo digito son ");
      do
      {
          Console.WriteLine(enteros2);
          enteros2 = enteros2+1;
      } while (enteros2 <= dig2);
      Console.ReadKey();

      int enteros3 = 1;
      Console.WriteLine("Los enteros comprendidos entre 1 y el tercer digito son ");
      do
      {
          Console.WriteLine(enteros3);
          enteros3 = enteros3+1;
      } while (enteros3 <= dig3);
      Console.ReadKey();

    }else{Console.WriteLine("El numero ingresado no contiene tres digitos");}
  }
}
