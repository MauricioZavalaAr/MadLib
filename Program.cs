// Your name: Mauricio Zavala
// Date Revised: This is the last day you saved. 11 of august, 2022
// Exercise or Lab name: MiniChallenge 5
// Brief Description of what you did. 
// Story, with 10 different variables and a loop. 
 // You can add multiple dates with description.
// Person who Peer Reviewed your assignment: Patrick De Leon

// You will be creating your own unique mad lib generator in a console project.
// Your console application needs to have the following:

// Have 10 fields to enter before you generate the story. These fields can be whatever you want them to be.

// Once you enter in all the pieces, you need to output the story with what was entered.

// The important thing with this application is to have fun with the story. Make sure you look online for examples.
// El elfo (nombre), vivia en una (lugar random), no sabía que instrumento tocar, estaba entre (instrumento1) e (instrumento2), despues de decidirse por (instrumento1) decidió entrar a clases con el Maestro (nombre2); 
// album1 (palabra random1); cancion1 (palandra random2), 
// Race from Lord of the rings:
// An {race} with the name of {name1}, who lived in {random1}, he wanted to plau {instrument1} or {instrument2}, at the end he decided to play {instrument2},
// for this he decided to get a new teacher called the Master {name2}. After {number1} years of training de decided to get his first son called {random2} from his first album called {random3}



bool playAgain = true;
string race;
string name1;
string name2;
string random1;
string random2;
string random3;
string random4;
string instrument1;
string instrument2;
string number1;

string userAnswer;

while(playAgain == true)
{
Console.WriteLine("Enter a lord of the rings race:");
race = Console.ReadLine();

Console.WriteLine("Enter a random name1:");
name1 = Console.ReadLine();

Console.WriteLine("Enter a random name2:");
name2 = Console.ReadLine();

Console.WriteLine("Enter a random word1:");
random1 = Console.ReadLine();

Console.WriteLine("Enter a random word2:");
random2 = Console.ReadLine();

Console.WriteLine("Enter a random word3:");
random3 = Console.ReadLine();

Console.WriteLine("Enter a random word4:");
random4 = Console.ReadLine();

Console.WriteLine("Enter a random instrument1");
instrument1 = Console.ReadLine();

Console.WriteLine("Enter a random instrument2");
instrument2 = Console.ReadLine();

Console.WriteLine("Enter a random number");
number1 = Console.ReadLine();

Console.WriteLine($"A {race} with the name of {name1}, who lived in {random1}, he wanted to play {instrument1} or {instrument2}, at the end he decided to play {instrument2}, for this he decided to get a new teacher called the Master {name2}. After {number1} years of training he decided to get his first song called {random2} from his first album called {random3}. He made his debut live on the mythical {random4} stadium. People says he has future, they expect the best.");

Console.WriteLine("Do you want to play again? Type Y if Yes or N if No");

userAnswer = Console.ReadLine().ToUpper();

if(userAnswer=="Y")
{
    playAgain = true;
}
else
{
    playAgain = false;
}
}
