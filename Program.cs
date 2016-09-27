﻿/*********************************************************
 * 9/26/2016
 * Section 2, Group 6 
 * Ashton Murray, Kat Healy, Parker Brown, Jolene Hammond
 * 
 * Data Structures Group Assignment
 * 
 * Program that gives user options to create a stack, a
 * queue, and a dictionary. Choosing any of the options will 
 * bring the user to another menu where they can add items 
 * individually, add a huge list of items, display the items,
 * delete specific items, clear all of the items, search for
 * an item, or return to the main menu.
 *********************************************************/
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
            //Construction of the stack, queue, and dictionary.
            Stack<string> stkMyStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
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
                Console.WriteLine();
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
                            Console.WriteLine();
                            Console.WriteLine("STACK MENU");
                            Console.WriteLine("Please enter the number that you want to do:");
                            Console.WriteLine("1. Add one item to Stack");
                            Console.WriteLine("2. Add Huge List of Items to Stack");
                            Console.WriteLine("3. Display Stack");
                            Console.WriteLine("4. Delete from Stack");
                            Console.WriteLine("5. Clear Stack");
                            Console.WriteLine("6. Search Stack");
                            Console.WriteLine("7. Return to Main Menu");
                            Console.WriteLine();
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
                                    Console.WriteLine("Please enter a number between 1-7");
                                }

                            }
                            switch (menuchoice)
                            {
                                case 1:
                                    //Adding one item to stack
                                    Console.WriteLine("Please add one item: ");
                                    string sMyString = Console.ReadLine();
                                    stkMyStack.Push(sMyString);
                                    break;
                                case 2:
                                    //Adding Huge List of Items
                                    for (int i = 0; i < 2000; i++)
                                    {
                                        string sNewEntry = ("New Entry " + i);
                                        stkMyStack.Push(sNewEntry);
                                    }
                                    break;
                                case 3:
                                    //Display stack
                                    try
                                    {
                                        foreach (string value in stkMyStack)
                                        {
                                            Console.WriteLine(value);
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Your stack is empty. Please enter a valid entry into the stack.", e);
                                    }
                                    break;
                                case 4:
                                    //Delete something from the stack
                                    Stack<string> stkDelStack = new Stack<string>();
                                    Console.WriteLine("Please enter which item you would like to delete: ");
                                    string sItem = Console.ReadLine();
                                    try
                                    {
                                        while (sItem != stkMyStack.Peek())
                                        {
                                            stkDelStack.Push(stkMyStack.Pop());
                                        }
                                        stkMyStack.Pop();
                                        for (int iCounter = 0; iCounter <= stkDelStack.Count(); iCounter++)
                                        {
                                            stkMyStack.Push(stkDelStack.Pop());
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Please enter a valid item from the stack to delete.");
                                    }
                                    break;
                                case 5:
                                    //Clear the whole stack
                                    stkMyStack.Clear();
                                    break;
                                case 6:
                                    //Search the queue
                                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                                    Console.WriteLine("Please enter an item you would like to search for: ");
                                    string sSearch = Console.ReadLine();
                                    sw.Start();
                                    for (int i = 0; i < stkMyStack.Count(); i++)
                                    {
                                        if (stkMyStack.ElementAt(i).Equals(sSearch))
                                        {
                                            Console.WriteLine(stkMyStack.ElementAt(i));
                                            sw.Stop();
                                            Console.WriteLine("It took " + sw.Elapsed + " seconds to complete this search.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("We could not find that item.");
                                        }

                                    }

                                    break;
                                case 7:
                                    //Go back to Main Menu
                                    Console.WriteLine();
                                    break;

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
                            Console.WriteLine();
                            Console.WriteLine("QUEUE MENU");
                            Console.WriteLine("Please enter the number that you want to do:");
                            Console.WriteLine("1. Add one item to Queue");
                            Console.WriteLine("2. Add Huge List of Items to Queue");
                            Console.WriteLine("3. Display Queue");
                            Console.WriteLine("4. Delete from Queue");
                            Console.WriteLine("5. Clear Queue");
                            Console.WriteLine("6. Search Queue");
                            Console.WriteLine("7. Return to Main Menu");
                            Console.WriteLine();
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
                                    Console.WriteLine("Please enter a number between 1-7");
                                }

                            }
                            switch (menuchoice)
                            {
                                case 1:
                                    //Add one item to Queue
                                    Console.WriteLine("Please add one item: ");
                                    string iInput = Console.ReadLine();
                                    myQueue.Enqueue(iInput);
                                    break;
                                case 2:
                                    //Add Huge List of Items to Queue
                                    myQueue.Clear();
                                    int iCount = 1;
                                    while (iCount <= 2000)
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
                                    string deleteWord = Console.ReadLine();
                                    int iQueueDelete = 0;
                                    while (myQueue.Contains(deleteWord) != true)
                                    {
                                        Console.WriteLine("Invalid Entry");
                                        Console.WriteLine("Please enter something that's actually in your queue.");
                                        deleteWord = Console.ReadLine();
                                    }
                                    iQueueDelete = myQueue.ToArray().ToList().IndexOf(deleteWord) + 1;
                                    //Create temporary queue for the items that won't be deleted.
                                    Queue<string> listOfWhatWontBeDeletedFromQueue = new Queue<string>();
                                    int iListCount = 1;
                                    while (iListCount < iQueueDelete)
                                    {

                                        listOfWhatWontBeDeletedFromQueue.Enqueue(myQueue.Dequeue());
                                        iListCount++;
                                    }
                                    myQueue.Dequeue();
                                    //continue to dequeue the rest of myQueue in order to preserve queue order.
                                    while (myQueue.Count() > 0)
                                    {
                                        listOfWhatWontBeDeletedFromQueue.Enqueue(myQueue.Dequeue());

                                    }
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
                                        Console.WriteLine("Yes, the queue had that. It was item #" + (myQueue.ToArray().ToList().IndexOf(iQueueSearch) + 1) + ".");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No, the queue didn't have that.");
                                    }

                                    Console.WriteLine("It took " + sw.ElapsedMilliseconds + " milliseconds to figure that out.");
                                    break;
                                case 7:
                                    //Return to Main Menu
                                    Console.WriteLine();
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
                            //Declare variables
                            string sUserResponse;
                            int iUserResponse;
                            int iCount = 0;
                            int iCounter = 0;

                            menuchoice = 0;
                            Console.WriteLine();
                            Console.WriteLine("DICTIONARY MENU");
                            Console.WriteLine("Please enter the number that you want to do:");
                            Console.WriteLine("1. Add one item to Dictionary");
                            Console.WriteLine("2. Add Huge List of Items to Dictionary");
                            Console.WriteLine("3. Display Dictionary");
                            Console.WriteLine("4. Delete from Dictionary");
                            Console.WriteLine("5. Clear Dictionary");
                            Console.WriteLine("6. Search Dictionary");
                            Console.WriteLine("7. Return to Main Menu");
                            Console.WriteLine();
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
                                    Console.WriteLine("Please enter a number between 1-7");
                                }

                            }
                            switch (menuchoice)
                            {
                                case 1:
                                    //Prompt user for them to enter in a string and record the response
                                    Console.WriteLine("\nPlease enter a string");
                                    sUserResponse = Console.ReadLine();

                                    //Add the response to the myDictionary object along with a value
                                    try
                                    {
                                        myDictionary.Add(sUserResponse, iCount++);
                                    }
                                    catch 
                                    {
                                        Console.WriteLine("That word is already in the dictionary. Try again.");
                                    }
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
                                    try
                                    {
                                        myDictionary.Remove(sUserResponse);
                                    }
                                    catch 
                                    {
                                        Console.WriteLine("That word is not in the dictionary. Please try again.");
                                    }
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
                                    Console.WriteLine("Going back to Main Menu.");
                                    Console.WriteLine();
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