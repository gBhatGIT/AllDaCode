using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Diagnostics;
using System.Threading;
using UtilityLibrary;
//using utilitystuff;

namespace Textfiletimestable
{
    class Program
    {

        static void Main(string[] args)
        {
            //title set
            string title = "Text file times table";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            Console.WriteLine("");

            //program start
            Console.Clear();

            int  dimens = 0;


            
            GetValue(out dimens, "Enter the dimension: ", 2, 512);
           
            int boi , rows, cols;
            
            boi = dimens;
            rows = boi;
            cols = boi;
        
            Console.WriteLine("# of Rows: {0} \n# of columns: {1}\n\n", cols, rows);
            for (int i = 1; i <= rows; i++) {

                Console.Write("{0}  ", i);

                


            }
            for (int j = 2; j <= cols; j++)
            {

                Console.WriteLine("\n{0}  ", j);

            }





            Utilities.Staller();
        }//end main

        //GetVal int with min and max range checks 
        public static void GetValue(out int iTest, String item, int min, int max)
        {
            Boolean b;
            do
            {
                Console.Write(item);
                b = int.TryParse(Console.ReadLine(), out iTest);
                if (b)
                {
                    if (iTest < min)
                    {
                        Console.WriteLine("The value is too low");
                        b = false;
                    }
                    else if (iTest > max)
                    {
                        Console.WriteLine("The value is too high");
                        b = false;
                    }
                    else
                    {
                        Console.WriteLine("Nice!");
                    }
                }
                if (!b)
                    Console.WriteLine("\nYou have entered an invalid number, please try again.\n");
            } while (b == false);
        }
    }//end program
}
