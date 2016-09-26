/*9/23/2016
 * 
 * 
 * 
 * 
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
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
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
                    case 3:
                        /****************************************************************************************************************************/
                        /*************************************                 DICTIONARY MENU              *****************************************/
                        /****************************************************************************************************************************/
                        /****************************************************************************************************************************/
                        while (menuchoice != 7)
                        {
                            //Declare variables
                            string sUserResponse; 
                            int iUserResponse;
                            int iCount = 0;
                            int iCounter = 0;
                            
                
                         
                        
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
                                    //Prompt user for them to enter in a string and record the response
                                    Console.WriteLine("\nPlease enter a string");
                                    sUserResponse = Console.ReadLine();
                
                                    //Add the response to the myDictionary object along with a value
                                    myDictionary.Add(sUserResponse, iCount++);
                                    break;
                                case 2:
                                    //Clear all of the contents of the dictionary
                                    myDictionary.Clear();
                
                                    //Load up each dictionary item up to 2000
                                    for (iCount = 0; iCount <= 2000; iCount++)
                                    {
                                        myDictionary.Add("New Entry " + iCount, iCount);
                                    }
                
                                    //Reset the iCount back to 0 
                                    iCount = 0;
                                    break;
                                case 3:
                                    //Display the contents of the dictionary
                                    Console.WriteLine("\nThis is the contents of the Dictionary");
                
                                    foreach (KeyValuePair<string, int> entry in myDictionary)
                                    {
                                        Console.WriteLine(entry.Key.PadRight(20, ' ') + entry.Value);
                                    }
                                    Console.WriteLine();
                                    break;
                                case 4:
                                    //Prompt for user input of what they want to delete from the dictionary
                                    Console.WriteLine("\nWhat would you like to Delete from the Dictionary? \nHere is the List: \n");
                
                                    //Display the dictionary so they can see their options
                                    foreach (KeyValuePair<string, int> entry in myDictionary)
                                    {
                                        Console.WriteLine(entry.Key);
                                    }
                
                                    //Record the user response and then delete the request item from the Dictionary
                                    Console.WriteLine();
                                    sUserResponse = Console.ReadLine();
                
                                    myDictionary.Remove(sUserResponse);

                                    break;
                                case 5:
                                    //Clear the whole dictionary
                                    myDictionary.Clear();
                                    break;
                                case 6:
                                    //Prompt the user for what string they want to look for.
                                    Console.WriteLine("\nPlease enter the string you are searching for: ");
                                    sUserResponse = Console.ReadLine();
                
                                    //Display the results of the search
                                    if (myDictionary.ContainsKey(sUserResponse))
                                    {
                                        Console.WriteLine("\nYou found " + sUserResponse + "! Here is the value: " + myDictionary[sUserResponse] + "\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nString not found!");
                                    }
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

