using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
         
        }
        #region Exercise A
        /** Log messagesV1
          
        #
        operations = 1
        Growth = 0(1)
        Best = NA
        Worst = NA
        
        **/
       

        static void LongMessagesV1(string[] messages)
        {
            Console.WriteLine(messages[0]);
        }

        
        /** Log messagesV2
          
        #
        operations = 1+1 = 2
        Growth = 0(1)
        Best = NA
        Worst = NA
        
        **/
       

        static void LongMessagesV2(string[] messages)
        {
            if (messages.Length > 0)
                Console.WriteLine(messages[0]);
        }

       
        /** Log messagesV3
          
        #
        operations = 1+1+1 = 3
        Growth = 0(1)
        Best = NA
        Worst = NA
        
        **/
       

        static void LongMessagesV3(string[] messages)
        {
            if (messages.Length > 1)
                Console.WriteLine(messages[0]);
                Console.WriteLine(messages[1]);
        }

       
        /** Log PrintArrayV1
          
        #
        operations = i 
        Growth = 0(i)
        Best = NA
        Worst = NA
        
        **/
       
        static void PrintArrayV1(string[] names)
        {
           for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        /** Log PrintArrayV2
         
       #
       operations = i+1+1
       Growth = 0(i)
       Best = NA
       Worst = NA
       
       **/

        static void PrintArrayV2(string[] names)
        {

            Console.WriteLine("Header");
            for (int i = 0; i < names.Length; i++)
            {  
                Console.WriteLine(names[i]);
                
            }
            Console.WriteLine("Footer");
        }
        /** Log PrintArrayV3
        
      #
      operations = i^2+1+1
      Growth = 0(i)
      Best = NA
      Worst = NA
      
      **/

        static void PrintArrayV3(string[] names)
        {
            Console.WriteLine("Header");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
                Console.WriteLine(names[i].Length);

            }
            Console.WriteLine("Footer");
            /** Log PrintArrayV3
         
       #
       operations = i+j
       Growth = 0(i)
       Best = NA
       Worst = NA
       
       **/
            static void PrintReport(string[] names, int[] IDs)
            {
                for (int i = 0; i < names.Length; i++) 
                {
                    Console.WriteLine(names[i]); 
                }

                for (int j = 0; j < IDs.Length; j++) 
                {
                    Console.WriteLine(IDs[j]); 
                }
            }

            #endregion
            #region Exercise 2

            /** A PrintCoordinatesV1 
        *  # Operations = i
        *  Growth = O(i)
        *  Best: NA
        *  Worst: Na
        */

            static void PrintCoordinatesV1(int size)
            {
              for (int i = 0; i<size; i++)
                {
                    Console.WriteLine(i);
                }
            }


            /** ABPrintCoordinatesV2
        *  # Operations = i+1
        *  Growth = O(i)
        *  Best: NA
        *  Worst: Na
        */
            static void PrintCoordinatesV2(int size)
            {
                for (int i = 0; i < size; i++)
                {
                  

                    for (int n = 0; n < size; n++)
                    {
                        Console.WriteLine(i+""+n);
                    }
                    Console.Write("");
                }
            }


            /** ABPrintCoordinatesV3
        *  # Operations = i^2+1
        *  Growth = O(i)
        *  Best: NA
        *  Worst: Na
        */
            static void PrintCoordinatesV3(int size)
            {
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine(i);
                    }
                }



                for (int i = 0; i < size; i++)
                {
                   

                    for (int n = 0; n < size; n++)
                    {
                        Console.WriteLine(i + "," + n);
                    }
                    Console.Write("");
                }
            }
            /** ABPrintCoordinatesV4
      *  # Operations = i^3+1
      *  Growth = O(i)
      *  Best: NA
      *  Worst: Na
      */
               static void PrintCoordinatesV4(int size)
            {

                for (int i = 0; i < size; i++)
                {

                    for (int n = 0; n < size; n++)
                    {

                        for (int j = 0; j < size; j++)
                        {
                            Console.WriteLine(i + "," + n + ","+j);
                        }
                    }
                    Console.Write("");
                }
            }
         
            #endregion
        }
    }
}
