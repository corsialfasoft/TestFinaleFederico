using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3 {
	class Program {
		static void Main(string[] args) {
					
					int[] array3 = new int[25];
					



					int[] array1 = {5,38,1,2,27,52,7, 12 , 4 ,23,53};
					Console.WriteLine("Prima lista non ordinata :");
					foreach(var uno in array1){
					Console.WriteLine("{0} ", uno);
					
					}
					Bubble(array1);
					Console.WriteLine("Prima lista ordinata :");
					foreach(var uno in array1){
					Console.WriteLine("{0} ", uno);
					}

					int[] array2 = {9,8,7,6,5,23,56,78,32,1234,535,22,12,16};
					Console.WriteLine("Seconda lista non ordinata :");
					foreach(var uno in array2){
					Console.WriteLine("{0} ", uno);
					 
					}
					Bubble(array2);
					Console.WriteLine("Seconda lista ordinata :");
					foreach(var uno in array2){
					Console.WriteLine("{0} ", uno);
					
					}



					 Array.Copy(array1, 0, array3, 0, 11);
					 Array.Copy(array2, 0, array3, 11, 14);
					 Bubble(array3);
					Console.WriteLine("Somma liste:");
					foreach(var uno in array3){
					Console.WriteLine("{0} ", uno);
					
					}

						


					


		
		}


		
		public static int[] Bubble(int[] ArrayBubble){
		
			int temp = 0;
			for (int i = 0; i < ArrayBubble.Length; i++)
					{
						for (int j = 0; j < ArrayBubble.Length - 1; j++)
						{
							if (ArrayBubble[j] > ArrayBubble[j + 1])
							{
								temp = ArrayBubble[j + 1];
								ArrayBubble[j + 1] = ArrayBubble[j];
								ArrayBubble[j] = temp;
							}       
						}   
						  
					}
		
		return ArrayBubble;
		}		
	}
}




		


