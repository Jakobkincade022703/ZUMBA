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
       



        // Weekly attendance (2D array)

       int[,] wAttendance = 
            
       {
            {8,10,14,22}, //monday
            {11,15,17,18}, //tuesday
            {12,12,18,20}, // wensday
            {9,14,13,13}, //thursday 
            {10,12,17,22}, //Friday
            {12,11,9,15} //saturday 
       };

        // Daily attendance (1D array)

        int[] dAttendance = { };  //Populated (Done)

        // Daily revenue (1D array)

        int[] dRevenue = { };

        // Weekly time-slot attendance (1D array)

        // Weekly time-slot revenue (1D array)

        // Methods
        static void Main(string[] args)
        {
            // Create and initialize a Zumba class instance
             Zumba z = new Zumba();
            foreach (int i in z.GetPerDayRevenue())
                Console.WriteLine(i);
          

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
           
            for ( int  week = 0; week < wAttendance.GetLength(0); week++)
            {
                for (int day = 0; day < wAttendance.GetLength(1); day++)
                {
                    dAttendance[week] += wAttendance[week, day];
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
        */
        public int[] GetPerDayRevenue()
        {
            int sessionCost = 4;
          
            int size = wAttendance.GetLength(0);
            dAttendance = new int[size];

            for (int week = 0; week < wAttendance.GetLength(0); week++)
            {
                for (int day = 0; day < wAttendance.GetLength(1); day++)
                {
                    dAttendance[week] += wAttendance[week, day] * sessionCost;
                }

            }
            return dAttendance ;
        }
        public void Display()
        {


        }
    }

}           
        

