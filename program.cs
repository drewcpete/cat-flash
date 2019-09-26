using System;
using System.Collections.Generic;
using System.Linq;
using CatGame;

namespace CatGame
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Game newGame = new Game(name);

            Inventory newInventory = new Inventory();
            HealthEvents newHealthEvents = new HealthEvents();

            Console.WriteLine("You awak from a slumber to a loud crash.  You look out your window and see a bright green shmear across the sky.");
            Console.WriteLine("You feel your anxiety rise with the unfamiliar glow from the sky.  You look around your filthy apartment looking for the only thing you know will give you some releif.");
            Console.WriteLine("After a quick search, you only notice your blood-stained sheetless mattress, your fridge thats mostly full of 90% empty dried condiments.  What you can't seem to find is your prized hairless cat, Fluffy, is nowhere to be seen.");
            SearchApartment(newInventory);

            LeaveApartment(newInventory, newHealthEvents);


        }

        public static void LeaveApartment(Inventory newInventory, HealthEvents newHealthEvents)
        {
            Console.WriteLine("You walk out onto the street.  The green glow illuminates the ground infront of you.  You hear a faint meow coming from the ally across the street.");
            Console.WriteLine("Your phone dings.  You pull it out to find a reminder for your friends birthday party at the park.");
            Console.WriteLine("Should you go to the park for a drink or investigate the ally?");
            string chooseSorP = Console.ReadLine();
            if (chooseSorP == "ally")
            {
                Console.WriteLine("You follow the meowing down the ally.  A homeless man asks you for a dollar.  You check your pockeets but don't have any money.  At the end of the ally there is the local subway stop.  You head down the stairs.");
                Console.WriteLine("You turn a corner at the bottom of the stairs when you hear a familiar voice.  Its the bum from the ally! He pulls out nun-chucks and asks for all your money.");
                if (newInventory.Knife == true)
                {
                    Console.WriteLine("You pull out the knife and slit his throat.");
                }
                else
                {
                    Console.WriteLine("The mugger attacks you, steals everything from you." + newHealthEvents.MuggerEvent());
                    newInventory.HaveWaterBottle = false;
                }


                Console.WriteLine("Now that the mugger is dealt with do you want to search or catch a train?");
                string searchORtrain = Console.ReadLine();
                if(searchORtrain == "search")
                {
                    Console.WriteLine("You notice a murder of rats gnawing on a soggy dog bone.  Do you want to grab it? y/n");
                    string bonegrab = Console.ReadLine();
                    if(bonegrab == "y")
                    {
                        if (!newInventory.DogBone)
                        {
                            newInventory.FindDogBone();
                            Console.WriteLine("the rats scurry away and you grab the soggy bone. your hand is gross now.");
                        }
                        else
                        {
                            
                        }
                    }
                }

            }
            else if (chooseSorP == "park")
            {
                Console.WriteLine("");
            }
        }
        public static void SearchApartment(Inventory newInventory)
        {
            Console.WriteLine("What would you like to do? search/leave");
            string response = Console.ReadLine();
            if (response == "search")
            {
                Console.WriteLine("Where would you like to search in the apartment?");
                string apartmentSearch = Console.ReadLine();
                if(apartmentSearch == "fridge")
                {
                    if(!newInventory.HaveWaterBottle)
                    {
                        Console.WriteLine("You found a water bottle! You can drink water to boost your health points.");
                        newInventory.GetWaterBottle();
                        SearchApartment(newInventory);
                    }
                    else
                    {
                        Console.WriteLine("You've already searched the fridge.");
                        SearchApartment(newInventory);
                    }
                }
                else if (apartmentSearch == "under bed")
                {
                    Console.WriteLine("Game over. You found Fluffy!");

                }
                else if (apartmentSearch == "bed")
                {
                    if(!newInventory.Knife)
                    {
                        Console.WriteLine("You find a knife in your bed? No wonder your sheetless mattress is blood-stained...");
                    newInventory.FindKnife();
                    SearchApartment(newInventory);
                    }
                }
                else
                {
                    Console.WriteLine("You don't find anything there.");
                    SearchApartment(newInventory);
                }

            }

        }
    }
}