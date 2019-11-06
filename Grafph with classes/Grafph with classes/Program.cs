using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Grafph_with_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
         

            using (TextReader tr = File.OpenText(@"C:\Users\elev\AppData\Local\Temp\~vsABC2.txt"))
            {
                int n = int.Parse(tr.ReadLine());
                int[,] a = new int[3,3];
           for(int i = 1; i <= n; i++) { 
                    for(int j=1;j<=n;j++)
                
                    a[i,j]=int.Parse(tr.ReadLine());
                }
                for (int i = 1; i <= n; i++) {
                    for (int j = 1; j <= n; j++)
                        Console.WriteLine(a[i,j]+" ");
                    Console.WriteLine();
                }
            }
           

                    Console.ReadKey();
 }
    }
}
