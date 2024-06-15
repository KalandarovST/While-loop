using System;

string userInput;
do
{
    Console.WriteLine("Karra jadval");
    int firstSon;
    int secondSon;
    string firstNum = Console.ReadLine();
    string secondNum = Console.ReadLine();
    firstSon = Convert.ToInt32(firstNum);
    secondSon = Convert.ToInt32(secondNum);
    while (firstSon is 1 or 20);
    {
        int multiplayer = 1;
        while(multiplayer <= 9)
        {
            Console.Write($"{firstSon} x {multiplayer} = {firstSon * multiplayer}; ");
            multiplayer++;
           
        }
        while(secondSon is 1 or 20);
         {
            Console.Write($"{secondSon} x {multiplayer} = {secondSon * multiplayer}; ");
            multiplayer++;
         }

       Console.WriteLine($" {firstSon} ning jadvali");
        firstSon++;
        Console.WriteLine($" {secondSon} ning jadvali");
        secondSon++;

    }
    Console.WriteLine("Do you want continue? (y -> n)");
    userInput = Console.ReadLine();
}
while(userInput == "y");