using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2 {
	class Program {
			static void Main(string[] args)  { 
           
					Console.WriteLine("Inserisci la frase da analizzare");
					String Testo = Console.ReadLine();
	        	    Char delimitatore = ' ';
			        String[] sottostringhe = Testo.Split(delimitatore);
			  foreach (string sottostringa in sottostringhe) {
				
				 Console.WriteLine(sottostringa);
				 int Trovata = 0;
				 int Totale = 0;
					if (sottostringa != "") {

					  for (int i = 0; i < Testo.Length; i++) {
						Trovata = Testo.IndexOf(sottostringa, i);
					    if (Trovata >= 0) {
						   Totale++;
						   i = Trovata;
						}
						else 
                         break;
						}
					    }
					else
					return;

				Console.WriteLine("{0}La parola '{1}' è stata trovata {2} volte.{0}",
                    Environment.NewLine, sottostringa, Totale);
				
			}	 
				 
    }
}
} 
		
							


	

