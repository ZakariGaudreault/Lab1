using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bread");
        }
        #region Exercise A
        /** Log messagesV1
          
        #
        operations = 1
        Growth = 0(1)
        Best = NA
        Worst = NA
        
        **/
        #endregion

        static void LongMessagesV1(string[] messages)
        {
            Console.WriteLine(messages[0]);
        }

        #region Exercise B
        /** Log messagesV1
          
        #
        operations = 1+1 = 2
        Growth = 0(1)
        Best = NA
        Worst = NA
        
        **/
        #endregion

        static void LongMessagesV2(string[] messages)
        {
            if (messages.Length > 0)
                Console.WriteLine(messages[0]);
        }

        #region Exercise C
        /** Log messagesV1
          
        #
        operations = 1+1+1 = 3
        Growth = 0(1)
        Best = NA
        Worst = NA
        
        **/
        #endregion

        static void LongMessagesV3(string[] messages)
        {
            if (messages.Length > 1)
                Console.WriteLine(messages[0]);
                Console.WriteLine(messages[1]);
        }

        #region Exercise D
        /** Log PrintArrayV1
          
        #
        operations = i 
        Growth = 0(i)
        Best = NA
        Worst = NA
        
        **/
        #endregion
        static void PrintArrayV1(string[] names)
        {
           for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        #region Exercise E
        /** Log PrintArrayV1
          
        #
        operations = i+1+1
        Growth = 0(i)
        Best = NA
        Worst = NA
        
        **/
        #endregion
        static void PrintArrayV2(string[] names)
        {

            Console.WriteLine("Header");
            for (int i = 0; i < names.Length; i++)
            {  
                Console.WriteLine(names[i]);
                
            }
            Console.WriteLine("Footer");
        }
        #region Exercise F
        /** Log PrintArrayV1
          
        #
        operations = i^2+1+1
        Growth = 0(i)
        Best = NA
        Worst = NA
        
        **/
        #endregion
        static void PrintArrayV3(string[] names)
        {
            Console.WriteLine("Header");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
                Console.WriteLine(names[i].Length);

            }
            Console.WriteLine("Footer");
            #region Exercise F

            /** G. PrintReport
        *  # Operations = i + j
        *  Growth = O(n)
        *  Best: NA
        *  Worst: Na
        */
            #endregion
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


            /** A PrintCoordinatesV1 
        *  # Operations = i
        *  Growth = O(i)
        *  Best: NA
        *  Worst: Na
        */
            static void PrintCoordinatesV2(int size)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(i);
                }
            }
            
            #endregion
        }
    }
}
