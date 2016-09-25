/*9/23/2016
 * 
 * 
 * 
 * this is a comment
 * another comment
 * 
 * Ashton Murray, Kat Healy, Parker Brown, Jolene Hammond
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = true;
            int menuchoice = 0;
            /****************************************************************************************************************************/
            /****************************************************************************************************************************/
            /*************************************                 MAIN MENU                *********************************************/
            /****************************************************************************************************************************/
            /****************************************************************************************************************************/
            /****************************************************************************************************************************/
            while (menuchoice != 4)
            {

                Console.WriteLine("MENU");
                Console.WriteLine("Please enter the number that you want to do:");
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dicitonary");
                Console.WriteLine("4. Exit");
                error = true;
                while (error == true)
                {
                    try
                    {
                        menuchoice = int.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Entry");
                        Console.WriteLine("Please enter a number between 1-4");
                    }

                }
                switch (menuchoice)
                {

                    case 1:
                        /****************************************************************************************************************************/
                        /*************************************                 STACK MENU              *********************************************/
                        /****************************************************************************************************************************/
                        /****************************************************************************************************************************/
                   
                        while (menuchoice != 7)
                        {
                            menuchoice = 0;
                            Console.WriteLine("STACK MENU");
                            Console.WriteLine("Please enter the number that you want to do:");
                            Console.WriteLine("1. Add one item to Stack");
                            Console.WriteLine("2. Add Huge List of Items to Stack");
                            Console.WriteLine("3. Display Stack");
                            Console.WriteLine("4. Delete from Stack");
                            Console.WriteLine("5. Clear Stack");
                            Console.WriteLine("6. Search Stack");
                            Console.WriteLine("7. Return to Main Menu");
                            error = true;
                            while (error == true)
                            {
                                try
                                {
                                    menuchoice = int.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid Entry");
                                    Console.WriteLine("Please enter a number between 1-4");
                                }

                            }
                            switch (menuchoice)
                            {
                                case 1:
                                    Console.WriteLine("Adding one item......");
                                    break;
                                case 2:
                                    Console.WriteLine("Adding Huge List of Items......");
                                    break;
                                case 3:
                                    Console.WriteLine("Display........");
                                    break;
                                case 4:
                                    Console.WriteLine("Delete.........");
                                    break;
                                case 5:
                                    Console.WriteLine("Clear........");
                                    break;
                                case 6:
                                    Console.WriteLine("Search........");
                                    break;
                                case 7:
                                    Console.WriteLine("Going back to Main Menu.......");
                                    break;  //go to main menu
                                default:
                                    Console.WriteLine("Sorry, invalid selection");
                                    break;
                            }
                        }
                        break;
                    /****************************************************************************************************************************/
                    /*************************************                 QUEUE MENU              *********************************************/
                    /****************************************************************************************************************************/
                    /****************************************************************************************************************************/
                    case 2:
                        while (menuchoice != 7)
                        {
                            menuchoice = 0;
                            Console.WriteLine("QUEUE MENU");
                            Console.WriteLine("Please enter the number that you want to do:");
                            Console.WriteLine("1. Add one item to Queue");
                            Console.WriteLine("2. Add Huge List of Items to Queue");
                            Console.WriteLine("3. Display Queue");
                            Console.WriteLine("4. Delete from Queue");
                            Console.WriteLine("5. Clear Queue");
                            Console.WriteLine("6. Search Queue");
                            Console.WriteLine("7. Return to Main Menu");
                            error = true;
                            while (error == true)
                            {
                                try
                                {
                                    menuchoice = int.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid Entry");
                                    Console.WriteLine("Please enter a number between 1-4");
                                }

                            }
                            switch (menuchoice)
                            {
                                case 1:
                                    //Add one item to Queue
                                    Console.WriteLine("Enter a name or something.");
                                    string iInput = Console.ReadLine();
                                    myQueue.Enqueue(iInput);
                                    break;
                                case 2:
                                    //Add Huge List of Items to Queue
                                    myQueue.Clear();
                                    int iCount = 0;
                                    while (iCount < 2000)
                                    {
                                        myQueue.Enqueue("New Entry " + iCount);
                                        iCount++;
                                    }
                                    break;
                                case 3:
                                    //Display Queue
                                    foreach (string value in myQueue)
                                    {
                                        Console.WriteLine(value);
                                    }
                                    break;
                                case 4:
                                    //Delete from Queue
                                    Console.WriteLine("Which queue item do you want to delete?");
                                    int iQueueDelete = 0;
                                    try
                                    {
                                        iQueueDelete = int.Parse(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Invalid Entry");
                                        Console.WriteLine("Please enter a number from your queue.");
                                    }
                                    List<string> listOfWhatWontBeDeletedFromQueue = new List<string>();
                                    int iListCount = 1;
                                    while (iListCount < iQueueDelete)
                                    {
                                        listOfWhatWontBeDeletedFromQueue.Add(myQueue.Dequeue());
                                        iListCount++;
                                    }
                                    myQueue.Dequeue();
                                    foreach (string value in listOfWhatWontBeDeletedFromQueue)
                                    {
                                        myQueue.Enqueue(value);
                                    }
                                    break;
                                case 5:
                                    //Clear Queue
                                    myQueue.Clear();
                                    break;
                                case 6:
                                    //Search Queue
                                    Console.WriteLine("What item would you like to see if the queue contains?");
                                    string iQueueSearch = Console.ReadLine();
                                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                                    sw.Start();
                                    if (myQueue.Contains(iQueueSearch))
                                    {
                                        Console.WriteLine("Yes, the queue had that.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No, the queue didn't have that.");
                                    }
                                    sw.Start();
                                    Console.WriteLine("It took " + sw.ElapsedMilliseconds + " milliseconds to figure that out.");
                                    break;
                                case 7:
                                    //Return to Main Menu
                                    break;
                                default:
                                    Console.WriteLine("Sorry, invalid selection");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        /****************************************************************************************************************************/
                        /*************************************                 DICTIONARY MENU              *****************************************/
                        /****************************************************************************************************************************/
                        /****************************************************************************************************************************/
                        while (menuchoice != 7)
                        {
                            menuchoice = 0;
                            Console.WriteLine("DICTIONARY MENU");
                            Console.WriteLine("Please enter the number that you want to do:");
                            Console.WriteLine("1. Add one item to Dictionary");
                            Console.WriteLine("2. Add Huge List of Items to Dictionary");
                            Console.WriteLine("3. Display Dictionary");
                            Console.WriteLine("4. Delete from Dictionary");
                            Console.WriteLine("5. Clear Dictionary");
                            Console.WriteLine("6. Search Dictionary");
                            Console.WriteLine("7. Return to Main Menu");
                            error = true;
                            while (error == true)
                            {
                                try
                                {
                                    menuchoice = int.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid Entry");
                                    Console.WriteLine("Please enter a number between 1-4");
                                }

                            }
                            switch (menuchoice)
                            {
                                case 1:
                                    Console.WriteLine("Adding one item......");
                                    break;
                                case 2:
                                    Console.WriteLine("Adding Huge List of Items......");
                                    break;
                                case 3:
                                    Console.WriteLine("Display........");
                                    break;
                                case 4:
                                    Console.WriteLine("Delete.........");
                                    break;
                                case 5:
                                    Console.WriteLine("Clear........");
                                    break;
                                case 6:
                                    Console.WriteLine("Search........");
                                    break;
                                case 7:
                                    Console.WriteLine("Going back to Main Menu.......");
                                    break;  //go to main menu
                                default:
                                    Console.WriteLine("Sorry, invalid selection");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        break;  //end
                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }         
                        
                }
            }
        }
    }
