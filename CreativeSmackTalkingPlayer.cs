using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunt = new List<string>
        {
            {"Loser"},
            {"You're trash"},
            {"Cut off your hands, they aren't helping you anyway"},
            {"Ew, you're smelly too?"},
            {"Imagine being this bad"},
            {"You're a disappointment to yo mama"}
        };
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            var random = new Random();
            int randomIndex = random.Next(Taunt.Count);

            Console.WriteLine($"{Name} rolls a {myRoll} and says {Taunt[randomIndex]}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}