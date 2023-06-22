// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string? cadena;

Console.WriteLine("Ingrese una cadena");

cadena=Console.ReadLine();

Console.WriteLine("La cadena ingresada es:" + cadena);

int largo= cadena.Length;

Console.WriteLine("La longitud de la cadena es:" + largo);

string? cadena2 , cadena3;
Console.WriteLine("Ingrese una segunda cadena");

cadena2=Console.ReadLine();

cadena= cadena + cadena2;

Console.WriteLine("cadenas concatenadas:" + cadena);



foreach (char c  in cadena)
{
   Console.WriteLine("Mostrado");
  Console.WriteLine(c);
}



string? buscado;

Console.WriteLine("Ingrese la palabra a buscar: ");
buscado=Console.ReadLine();


if (cadena.Contains(buscado))
{
  Console.WriteLine("La palabra encontrada es:" + cadena);
}else
{
   Console.WriteLine("NO encontro la palabra: ");
}

 Console.WriteLine("");
string? may , min;
int contMin=0;
int contMay=0;







for(int contador =0; contador< cadena.Length; contador++){
if (char.IsLower(cadena, contador))
{  
  
  contMin++;
}

if (char.IsUpper(cadena, contador))
{  
  
  contMay++;
}



}

if (contMin>0)
{
  may=cadena.ToUpper();
   Console.WriteLine("La palabra convertida a mayusculas es:" + may);
} if (contMay>0)
{
   min=cadena.ToLower();
   Console.WriteLine("La palabra convertida a minisculas es:" + min);
}











/***********************************************************************/


double x;
int  mcm, mcd, a2, b2, minimo;
int num1, num2;


bool anda =false;

int a1, b1;


  

  while (!anda)
  {
    
    Console.WriteLine("Ingrese un numero: ");
    anda = double.TryParse(Console.ReadLine(), out x);// convierte lo que escribo en float
    

   

        Console.WriteLine($"Valor absoluto de {x} :  {Math.Abs(x).ToString()}");
        Console.WriteLine($"Cuadrado de {x} : {Math.Pow(x, 2).ToString()}");
        Console.WriteLine($"Raiz Cuadrada de {x}:  {Math.Sqrt(x).ToString()}");
        Console.WriteLine($"Seno de {x}:  {Math.Sin(x).ToString()}");
        Console.WriteLine($"Coseno de {x}:  {Math.Cos(x).ToString()}");
        string astr = x.ToString();
        string[] textSplit = astr.Split(","); // le saca la coma
        Console.WriteLine("Parte entera: "+ textSplit[0]);
        Console.WriteLine($"Parte entera de {x}: + {Math.Round(x).ToString()}");
      Console.WriteLine("Ingrese dos numeros: ");


         Console.WriteLine("Primer numero: ");


anda=int.TryParse(Console.ReadLine(), out a1);

     Console.WriteLine("Segundo numero: ");

anda =int.TryParse(Console.ReadLine(), out b1);
   
    
   mcd=0;

  a2=a1;
  b2=b1;


   num1=Math.Max(a2,b2);
   num2=Math.Min(a2,b2);


     do
     {
        mcd=num2;
        num2=num1%num2;
        num1=mcd;
     } while (num2!=0);

    Console.WriteLine("El maximo es: "+ mcd);

  
    minimo=Math.Min(a1,b1);
    mcm=0;



    





    for (int i = 1; i <= minimo; i++)
    {
        if (a1%i==0 && b1%i==0)
        {
            mcd=i;

        mcm=(a1*b1)/mcd;
        
     }
}  

  Console.WriteLine("El minimo es: "+ mcm);

  Console.ReadKey(true);

        
 } 







