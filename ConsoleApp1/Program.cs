using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bread");
        }
        #region Exercise 1
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

        #region Exercise 2
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

        #region Exercise 3
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

        #region Exercise 4
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
        #region Exercise 5
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
        #region Exercise 6
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
        }
    }
}
