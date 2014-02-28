
using System;

namespace Practica1
{
	class Precios
	{
		
		public static void Main(string[] args)
		{
			
		double valor1,valor2,valor3;
		double iva=1.16;
		double total;
			
		Console.WriteLine("Bienvenido al programa para aumentar el iva ");
		Console.WriteLine();
		
		Console.Write("Ingresa el primer valor  :");
	    float precio1=float.Parse (Console.ReadLine ());
	    valor1=precio1*iva;
	    
	    Console.WriteLine("El costo del primer producto es :"+precio1);
		
	    Console.WriteLine("El precio con iva del primer producto es :"+valor1);
	    
	    Console.WriteLine("\n\n");
	  
	    
	    Console.Write("Ingresa el segundo valor  :");
	    float precio2=float.Parse (Console.ReadLine ());
	    valor2=precio2*iva;
	    
	    Console.WriteLine("El costo del segundo producto es :"+precio2);
	    Console.WriteLine("El precio con iva del segundo producto es :"+valor2);
	    
	    
	    Console.WriteLine("\n\n");
	    
	    Console.Write("Ingresa el tercer valor  :");
	    float precio3=float.Parse (Console.ReadLine ());
	    valor3=precio3*iva;
	    
	    Console.WriteLine("El costo del tercer producto es :"+precio3);
	    Console.WriteLine("El precio con iva del segundo producto es :"+valor3);
	    
	    Console.WriteLine("\n");
	    total=valor1+valor2+valor3;
	    Console.WriteLine("El total de los productos es  :"+total);
	    
	    
	    
		
	    Console.ReadKey(true);
		}
		
		
	}
}


