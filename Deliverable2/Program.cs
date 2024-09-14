// See https://aka.ms/new-console-template for more information
/*
 Prompt the user to enter the name
Prompt the user yes/no for challenge
Generate random number and assign for head/tail
prompot the user for head/tail
compare the value and increment the score if it matches, repeat it for five times.
display the score*/

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE! \nWhat is your Name?");
String name = Console.ReadLine();
Console.WriteLine("Welcome " + name + " Do you want to do the COIN FLIP CHALLENGE? Yes/No");

String yn = Console.ReadLine();
String option = "";
int score = 0;

if (yn.Trim().ToLower() == "no")
{
    Console.WriteLine("You are a coward " + name);
}
else if (yn.Trim().ToLower() == "yes")
{
    int i = 0;
    while (i < 5)
    {
        Random rnd = new Random();
        int rndno = rnd.Next(0, 2);

        if (rndno == 0) { option = "heads"; }
        else if (rndno == 1) { option = "tails"; }

        Console.WriteLine("Heads or Tails ?");
        String userOpt = Console.ReadLine();
        if (userOpt.Trim().ToLower() == option)
        {
            Console.WriteLine("Correct!");
            score += 1;
        }
        else { Console.WriteLine("Wrong!"); }
        i++;
    }
    Console.WriteLine("Thank you "+name+ ". You got a score of "+score);
}