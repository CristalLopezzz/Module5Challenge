using System;

namespace DadJokesApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Array of dadJokes
            string[] dadJokes = new string [12];
            
            dadJokes[0] = "What has five toes and isn't your foot? My foot.";
            dadJokes[1] = "What's the best way to get the hospital after breaking your foot? With a tow truck.";
            dadJokes[2] = "What do you call it when a cow grows facial hair? A moo-stache.";
            dadJokes[3] = "There are only two things I don't eat for breakfast: Lunch and dinner.";
            dadJokes[4] = "How do you make a tissue dance? Put a little boogie in it.";
            dadJokes[5] = "Where do birds stay when they travel? Someplace cheep.";
            dadJokes[6] = "I told a bad chemistry joke once. I got no reaction.";
            dadJokes[7] = "How do mice floss their teeth? With string cheese.";
            dadJokes[8] = "When's the best time to call your dentist? Tooth-hurty.";
            dadJokes[9] = "Why shouldn't you tell jokes to a duck? Because they'll quack up.";
            dadJokes[10] = "Why did the rabbit go to the salon? It was having a bad hare day.";
            dadJokes[11] = "Why do ducks have feathers on their tales? To hide their butt-quacks.";

            //Creation of the random class
            Random rnd = new Random();

            //Variables that will display two random jokes for user
            int jokeOne = rnd.Next(0, 12);
            int jokeTwo = rnd.Next(0,12);

            //This will display it to the user 
            Console.WriteLine(dadJokes[jokeOne]);
            Console.WriteLine(dadJokes[jokeTwo]);

            //Question that will allow user to answer if they want another joke or not
            Console.Write("Would you like another dad joke? (yes/no): ");
            
            //Stores user's answer to define the next step
            String answer = Console.ReadLine();

            //While loop that will continue looping until the user types in anything else besides yes
            //answer.ToLower() intakes answers in all lowercase for easier understanding
            while (answer.ToLower() == "yes")
            {
                //Variable that will allow to give a random joke
                int jokeIndex = rnd.Next(0,12);
                Console.WriteLine(dadJokes[jokeIndex]); //Will display random joke
                //Quesiton for user to answer if they want another joke
                Console.Write("Would you like to hear another dad joke?(yes/no): ");
                answer = Console.ReadLine(); ////Stores user's answer to define the next step
            }
            //If user does not input yes it will print the following message and end the program
            Console.WriteLine("Thank you for visiting our program!");

        } //end public main 
          
    } //end class

} //end namespace

//I tried figuring out how to print the jokes without them repeating themselves, but I couldn't figure it out.
//I know it wasn't a requirement for this challenge, but I wanted to give it a try (didn't succeed though).