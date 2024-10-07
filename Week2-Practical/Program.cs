/*
 * Practical 2
 * Information: Methods demo
 * Version 1
 * Author Dr James Connolly
 * Date: September
 */

//calling the main method which contains all the other methods
Main();

void PrintMenu()
{
    //Displays menu of text with options of saying hello in different languages
    Console.WriteLine("Please enter a valid option from below\n1. Hello in French?\n2. Hello in Spanish?\n3. Hello in German?\n4. Hello in Italian?\n0. Exit application");
}

int GetOption()
{
    //initialising option variable
    int option = 0;
    //try catch statement to handle errors
    try
    {
        //assigns whatever the user enters to the option variable
        option = Convert.ToInt32(Console.ReadLine());
       
    }
    //if the user's input is outside of the expected range
    catch (IndexOutOfRangeException exI)
    {
        Console.WriteLine(exI.Message);
       
    } 
    //handles any other possible errors
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    //returns the user's input
    return option;
}

string GetMessage(int option)
{
    //initialise string variable
    string lang = "";
    //switch case to determine string based on user's input from the GetOption method
    switch (option)
    {
        case 1:
            lang = "Goodbye";
            break;
        case 2:
            lang = "Bonjour";
            break;
        case 3:
            lang = "Ola";
            break;
        case 4:
            lang = "Ciao";
            break;
        case 0:
            Console.ReadKey();
            break;
        //the default will be carried out if none of the other options are selected
        default:
            Console.WriteLine("Invalid option, please select 0-4");
            break;
    }
    //returns the string selected in the switch case
    return lang;
    
       
}
void Main()
{
    //initialise option variable
    int option = 0;
    //do while loop to carry out a block of code until a condition is met
    do
    {
        //PrintMenu method will display the menu with the various language options
        PrintMenu();
        //the option variable will be set to the user's input using the GetOption method
        option = GetOption();
        //The GetMessage method is used to retrieve the correct language statement, it uses the option variable to decide which language to use and is then written to the console.
        Console.WriteLine(GetMessage(option));
    }
    //while determines when the loop will stop, which is when the option variable is 0
    while (option != 0);
}