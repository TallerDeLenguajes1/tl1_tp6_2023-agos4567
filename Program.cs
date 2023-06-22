// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Agos!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a : {0}",+a);

Console.WriteLine("Valor de b : {0}",+b);

float floatNum1=0;

bool anda =false;
string? numString="";

while (!anda)
{
    Console.WriteLine("Ingrese un numero valido: ");
    numString=Console.ReadLine();
    anda =float.TryParse(numString, out floatNum1);
   
    if (!anda)
    {
        Console.WriteLine(numString + "no es un numero valido:  ");
    }else{
        // Console.WriteLine(numString +  "si es un numero valido:  ");
    }

}


//para invertir el numero



int ReverseNumber(int number)
{
    int reversedNumber=0;
  while (number !=0)
  {
    int digit= number %10;
    reversedNumber=reversedNumber * 10 + digit;
    number /=10;
  }


  return reversedNumber;
}
int intNum= (int)floatNum1;

int NumIntv=ReverseNumber(intNum);

Console.WriteLine(  "Numero invertido: "  + NumIntv );