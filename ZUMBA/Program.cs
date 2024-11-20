/* Name: jakob kincade
 * Section: CS258-00x
 * Date: 11/15/2024
 * Program description: 
 */
using System;
using System.Diagnostics.CodeAnalysis;

namespace CS258
{
    class Zumba
    {
        // Data
        int sessionCost = 4;



        // Weekly attendance (2D array)

       int[,] wAttendance = 
            
       {
            {8,10,14,22},
            {11,15,17,18},
            {12,12,18,20},
            {9,14,13,13},
            {10,12,17,22},
            {12,11,9,15}
       };

        // Daily attendance (1D array)

        int[] dAttendance = { };

        // Daily revenue (1D array)

        int[] dRevenue = { };

        // Weekly time-slot attendance (1D array)

        // Weekly time-slot revenue (1D array)

        // Methods
        static void Main(string[] args)
        {
            // Create and initialize a Zumba class instance
            Zumba z = new Zumba();

            

            // The do-while loop
            // Textbook@P357
            
            do
            {
                string userResponse;
                Console.WriteLine("To display attendance and revenue info please press Y");
                userResponse = Console.ReadLine();
                // Ask user if to show the attendance/income)
                if (userResponse ==  "y" || userResponse == "Y")
                {
                    

                }
                else if(userResponse == "N" || userResponse == "n" )
                {


                }


                // Ask user if to continue the program

                // To continue or break a loop
                // Textbook@P368: break statement, Example 6-18
                // Textbook@P369: continue statement
            }
            while (true);
            
        }
        /*
        public int GetWeeklyAttendance()
        {
            
        }

        public int[] GetPerSlotAttendance()
        {

        }
        */

        public int[] GetPerDayAttendance()
        {
          int size = wAttendance.GetLength(0);
          dAttendance = new int[size];
           
            for ( int r = 0; r < wAttendance.GetLength(0); r++)
            {
                for (int e = 0; e < wAttendance.GetLength(1); e++)
                {
                    dAttendance[r] += wAttendance[r, e];
                }
            }
         return dAttendance;
        }
        /*
        public int GetWeeklyRevenue()
        {
         
        }
        
       public int[] GetPerSlotRevenue()
        {

        }

        public int[] GetPerDayRevenue()
        {

        }

        public void Display()
        {
       */

        }
    }

