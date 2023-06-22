// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int opcion;



int a, b;

bool anda =false;




do
{
     


     do
     {
        
         Console.WriteLine("Ingrese el primero numero: ");

            anda = int.TryParse(Console.ReadLine(), out a);// convierte lo que escribo 
    
          Console.WriteLine("Ingrese el segundo numero: ");

            anda = int.TryParse(Console.ReadLine(), out b);

         Console.WriteLine("Elija una opcion: ");

        Console.WriteLine("1/ -Sumar-  2/ -Restar  3/-Multiplicar ");

     
     anda=int.TryParse(Console.ReadLine(), out opcion);



     } while (!anda);




    // Console.WriteLine("Ingrese el primero numero: ");


    // int a = Convert.ToInt32(Console.ReadLine());  // convierte lo que ingreso por teclado a entero?



    // // anda =int.TryParse(ingreso, out ingreso);

    //   Console.WriteLine("Ingrese el segundo numero: ");


    //  int b = Convert.ToInt32(Console.ReadLine());

    // // anda =int.TryParse(ingreso, out ingreso);

    // Console.WriteLine("Elija una opcion: ");

    //     Console.WriteLine("1/ -Sumar-  2/ -Restar  3/-Multiplicar ");

     
    //  opcion=Convert.ToInt32(Console.ReadLine());

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


/*calculadora 2*/

   
int x;
int  mcm, mcd, a2, b2, minimo;
int num1, num2;


bool bandera =false;

int a1, b1;

  

  while (!bandera)
  {
    
    Console.WriteLine("Ingrese un numero: ");
    bandera = int.TryParse(Console.ReadLine(), out x);
    

   

        Console.WriteLine("Valor absoluto: "+ Math.Abs(x));
        Console.WriteLine("Cuadrado: "+ Math.Pow(x, 2));
        Console.WriteLine("Raiz Cuadrada: "+ Math.Sqrt(x));
        Console.WriteLine("Seno: "+ Math.Sin(x));
        Console.WriteLine("Coseno: "+ Math.Cos(x));
        string astr = x.ToString();
        string[] textSplit = astr.Split(","); // le saca la coma
        Console.WriteLine("Parte entera: "+ textSplit[0]);
      Console.WriteLine("Ingrese dos numeros: ");


         Console.WriteLine("Primer numero: ");

  bandera = int.TryParse(Console.ReadLine(), out a1);

    // int a = Convert.ToInt32(Console.ReadLine());


     Console.WriteLine("Segundo numero: ");
  bandera = int.TryParse(Console.ReadLine(), out b1);

//    int  b = Convert.ToInt32(Console.ReadLine());

   
    
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






 