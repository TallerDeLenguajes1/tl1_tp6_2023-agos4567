See https://aka.ms/new-console-template for more information
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

Console.WriteLine("Hello, World!");

int opcion;

do
{
    




    Console.WriteLine("Ingrese el primer numero: ");


    int a = Convert.ToInt32(Console.ReadLine());  // convierte lo que ingreso por teclado a entero?


      Console.WriteLine("Ingrese el segundo numero: ");


     int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Elija una opcion: ");

        Console.WriteLine("1/ -Sumar-  2/ -Restar  3/-Multiplicar ");

     
     opcion=Convert.ToInt32(Console.ReadLine());

           switch (opcion)
    {
        case 1: 
            Console.WriteLine(a+b);
            break;
        case 2: 
            Console.WriteLine(a-b);
            break;
        case 3: 
            Console.WriteLine(a*b);
            break;
        case 4: 
            if(b == 0){
                Console.WriteLine("No es posible dividir en 0.");
            }else{
                Console.WriteLine(a/b);
            }
            break;
        default:

        Console.WriteLine("Opcion invalida.");
        Console.ReadLine();
        break;

      
    }



  Console.WriteLine("Desea realizar otra operacion (1.SI / 0.NO):");
    opcion = Convert.ToInt32(Console.ReadLine());  // convierte lo que ingreso por teclado a entero lo guarda en opcion para analiza si sale del do while o sigue preguntando?



} while (opcion !=0);





     
















