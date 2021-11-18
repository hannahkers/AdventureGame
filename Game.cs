using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    public class Game
    {
        public Player CurrentPlayer;
        public Player currentPlayer = new Player();
        public string Title { get; set; }

        public List<Location> Locations { get; set; } = new List<Location>();

        //get player name
        public void NameCharacter()
        {
            //ask player for name and save it
            WriteLine("What would you like your character's name to be?");
            CurrentPlayer = new Player();
            CurrentPlayer.Name = ReadLine();

            if (CurrentPlayer.Name == "")
            {
                WriteLine("Please enter a name if you wish to start your adventure.");
                NameCharacter();
            }
            else
            {
                WriteLine($"Welcome to Nortar {CurrentPlayer.Name}! \nPress enter to begin your adventure!");
            }
            ReadKey();
            Clear();
        }

        //print out game title and overview
        public void StartGame()
        {
            //            //print out game title and overview
            //            Title = "The Legend of Nortar";
            string title = @"
                
                ░░░░░░░░▌░░░░░░░▐
                ░░░░█░░▄▌░░░░▌░░░█░░░▄▄
                ░░░░▐▄░▌░░░░▐▄▌░░░▀▄█▄
                ░░░░░▐█░░░░░░░▌░▄█▀░░░▀█
                ░░░▌░░▐░░░░░▄▀▀▀░░░░░░░░
                ░░░▐░░░▀▄░█▀▄▄▄▄░░░░░░░░
                ▌░░█▄░░░▐▄█░░░░▌▀▄░░░░░░ 
/__ __\/ \ /|/  __/  / \   /  __//  __//  __// \  /|/  _ \  /  _ \/    /  / \  /|/  _ \/  __\/__ __\/  _ \/  __\
  / \  | |_|||  \    | |   |  \  | |  _|  \  | |\ ||| | \|  | / \||  __\  | |\ ||| / \||  \/|  / \  | / \||  \/|
  | |  | | |||  /_   | |_/\|  /_ | |_//|  /_ | | \||| |_/|  | \_/|| |     | | \||| \_/||    /  | |  | |-|||    /
  \_/  \_/ \|\____\  \____/\____\\____\\____\\_/  \|\____/  \____/\_/     \_/  \|\____/\_/\_\  \_/  \_/ \|\_/\_\
                                                                                                                       
               █░░░▐░░░██░░░░░█░░▄░█▀░░
               ▐░░░█░░░▐█░░░░░░░░▌▀░░░░
               ░▌░░▌░░░▐█▄░░░░▄▄█▄▄▄░░░
               ▄▄▀▄█░░░░██░▄█▀░█▄▄░▐▄▄░
               ░░░░▀█▄░▄███░░░░░░░░░░░░
               ░░░░░░█████░░░░░░░░░░░░░
               ░░░░░░░▐███░░░░░░░░░░░░░
               ░░░░░░░▐███░░░░░░░░░░░░░
               ░░░░░░░▐████░░░░░░░░░░░░
               ░░▒▒▒▒▒█████▒▒░░░░░░░░░░
               ▒▒▒▒▒▒▄██████▒▒▒▒▒▒▒▒▒▒▒
               ▒▒▄▄▄█▀▒█▀▐▀▀██▄▄▄▒▒▒▒▒▒
               █▀▐▒█▒▒▒▌▒▒▐▒▒▒▒▒▌▀▀▄▒▒▒
                            ";
            WriteLine(title);
            WriteLine("Press enter to continue...");
            ReadKey();
            Clear();
            WriteLine("Welcome Traveler!");
            NameCharacter();

            Setup();

            ViewMainMenu();

        }
        public void ViewMainMenu()
        {
            string[] options = new string[] { "Start Game", "View Locations", "View Inventory", "Exit" };

            int choice = Utility.ShowUserOptionsAndGetAValidResponse("What would you like to do?", options);

            Console.Clear();

            switch (choice)
            {
                case 0: 
                    PlayGame();
                    break;
                case 1:
                    ViewLocations();
                    break;
                case 2:
                    ViewInventory();
                    break;
                case 3:
                    //Exit
                    WriteLine("Thank you for playing");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    //if a number other than 1-4 is entered, ask the player to enter a number in that range
                    //wait for them to press enter, then call the menu again
                    WriteLine("Please enter a number 1-4.");
                    WriteLine("Press enter to continue...");
                    ReadLine();
                    ViewMainMenu();
                    break;
            }

         
        }
        public void PlayGame()
        {
            storyFirst();
            storySecond();
            storyThird();
            enterTownWell();
            enterForest();
            enterLake();
            enterNortar();
        }
        //beginning of the story
        public void storyFirst()
        {
            WriteLine("You awake to the sound of loud whispers. Your mother is talking to someone, but who could it be?");
            ReadKey();
            WriteLine("You quietly make your way to the top of the stairs to listen, but all voices have stopped.\nYou hear your mother heading for the stairs and you run back to bed.\nMoments later, she enters your room and starts to speak.");
            ReadKey();
            Clear();
        }
        //introduced to legend of nortar
        public void storySecond()
        {
            string playerAnswerOne = "";
            WriteLine("'I know you heard me talking, your Uncle Kit just left. His child, your cousin, Emily is very sick.\nShe needs medicine made from a special flower, Tulic, to heal her, it was last seen in Nortar.\nDo you remember the story of Nortar?'");
            WriteLine("Please enter 'Yes' or 'No'.");
            playerAnswerOne = ReadLine();
            playerAnswerOne = playerAnswerOne.ToUpper();
            if (playerAnswerOne == "NO")
            {
                WriteLine("'Let me tell you.\nMany years ago, the path to Nortar was flooded and lost. No one has seen the land in a hundred years.\nKit and I began creatin a map when we were younger but never had the chance to finish it.'");
                ReadKey();
                Clear();
                WriteLine("After she finishes the story, your mother looks at you in desperation.\n'Please, " + CurrentPlayer.Name + ", finish the map.\nFind a Tulic flower and save Emily!'");

            }
            else if (playerAnswerOne == "YES" || playerAnswerOne == "")
            {
                WriteLine("'Let me remind you again.\nMany years ago, the path to Nortar was flooded and lost. No one has seen the land in a hundred years.\nKit and I began creatin a map when we were younger but never had the chance to finish it.'");
                ReadKey();
                Clear();
                WriteLine("After she finishes the story, your mother looks at you in desperation.\n'Please, " + CurrentPlayer.Name + ", finish the map.\nFind a Tulic flower and save Emily!'");

            }
            else
            {
                WriteLine("'Do you remember? Yes or No?'");
                storySecond();
            }
            Clear();
        }
        
        //start your journey
        public void storyThird()
        {
            Clear();
            Item oneMap = new Item()
            {
                Name = "Map Piece 1",
                Description = "The bottom right corner of a map."
            };
            Item bag = new Item()
            {
                Name = "A bag",
                Description = "An old leather bag to carry your things in."
            };
            WriteLine($"You nod your head and agree to help. 'Thank you! Here is the map that I started and \nsomething to keep you organized.'\nYour mom hands you a bag and a piece of paper and you head out the door.");
            CurrentPlayer.Inventory.Add(bag);
            CurrentPlayer.Inventory.Add(oneMap);
            WriteLine($"Awesome! You now have a {bag.Name} and {oneMap.Name}!");
            ReadKey();
            Clear();
        }
        public void enterTownWell()
        {
            Item twoMap = new Item()
            {
                Name = "Map Piece 2",
                Description = "The bottom left corner of a map."
            };
            Clear();
            WriteLine("You approach the well in the middle of town and you see your Uncle Kit.");
            ReadKey();
            WriteLine($"He looks at you and says, '{CurrentPlayer.Name}! Have you decided to help? Yes? Aha! Thank you!");
            ReadKey();
            WriteLine("He hands you a piece of paper and says,");
            ReadKey();
            WriteLine("'Here is my half of the map your mother and I started. Head to the forest to discover more!");
            CurrentPlayer.Inventory.Add(twoMap);
            WriteLine($"Awesome! You now have {twoMap.Name}!");
            ReadKey();

        }

        public void enterForest()
        {
            Item threeMap = new Item()
            {
                Name = "Map Piece 3",
                Description = "The top right corner of a map."
            };
            Clear();
            WriteLine("You hesitantly enter the dark forest your mother had always warned you about.");
            ReadKey();
            string input = "";
            WriteLine("You put your hand in front of your face, you can barely see a few inches in front of you.\nYou need to find something to light the way and fast.\nYou feel around in your bag for something to help.\nAs soon as you're about to give up, a tiny creature appears in front of you.");
            ReadKey();
            WriteLine("'Hello there traveler! I'm Fayette, a tree fairy!\nYou look like you could use some help. I can give you one thing to help you.\nYou can choose A) a jacket or B) a torch");
            ReadKey();
            WriteLine("Which will you choose? A or B?");
            input = ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                WriteLine("You've chosen a jacket! Fayette hands it to you and you put it on.\nAs you walk down the path you put your hands in the jacket pocket and pull out a small knife.\nYou place it into your bag and keep walking.");
                ReadKey();
                WriteLine("You reach a clearing in the woods and see a picnic basket.\nIt is wrapped in rope.");
                WriteLine("You remember the knife you found and retrieve it from your bag.\nYou use it to cute the rope and open the box. Inside is a loaf of bread!\nYou take a bite and feel more energetic than before.");
                ReadKey();

            }
            if (input == "B")
            {
                WriteLine("You've chosen a torch! Fayette hands you the firey stick and you head down the path.");
                ReadKey();
                WriteLine("You reach a clearing in the woods and see a picnic basket.\nIt is wrapped in rope.");
                WriteLine("Too bad you don't have anything to cut the rope, there might have been food inside.");
                ReadKey();

            }
            //else
            //{
            //    WriteLine("Please choose A or B...");
            //    enterForest();
            //}
            WriteLine("You reach the edge of the forest and you see a body of water. You decide to head towards it.\nOn your way you see a large tree with white bark, there's something pinned to it.\nYou take a closer look and see another piece of the map!\nYou unpin the paper from the tree and stick it in your bag.");
            CurrentPlayer.Inventory.Add(threeMap);
            WriteLine($"Awesome! You now have {threeMap.Name}!");
            ReadKey();
        }

        public void enterLake()
        {
            Item fourMap = new Item()
            {
                Name = "Map Piece 4",
                Description = "The top left corner of a map."
            };
            Clear();
            string input = "";
            WriteLine("You make your way to the body of water and see a group of fishermen.\nThey look nice enough so you approach them. A man with a white beard steps up and says,\n'Well, well, well, who do we have here?'\nYou begin to panic and start looking for an escape. The old man stops you and says,\n'Calm down! We're all friendly here! My name is Captain Mike!\nWhere are you headed? We can give you a ride across the water.'");
            WriteLine("Please answer yes or no");
            input = ReadLine();
            input = input.ToUpper();
            if (input == "YES")
            {
                WriteLine("You've accepted the boat ride! The captain helps you on his boat and you set sail with his crew.\nHe tells you he is heading to Nortar and you can barely contain your joy!\nHe takes you to the shore and you can see the flowery fields ahead!");
                ReadKey();

            }
            if (input == "NO")
            {
                WriteLine("You don't trust the Captian and his crew, so you take off around the lakeshore.\nIt will add some time to your journey, but better safe than sorry.");
                WriteLine("After some time you see flowery fields in the distance and you know you've almost made it!");
                ReadKey();
            }
            //else
            //{
            //    WriteLine("Please choose yes or no...");
            //    enterLake();
            //}
            WriteLine("As you make your way towards Nortar, you see something shiny on the ground.\nYou pick it up and see it's a gold seal on an envelope.\nYou open it up and find the final piece of the map! Now you can make it the rest of the way!");
            CurrentPlayer.Inventory.Add(fourMap);
            WriteLine($"Awesome! You now have {fourMap.Name}!");
            ReadKey();
        }
        public void enterNortar()
        {
            Clear();
            WriteLine("You run towards the colorful display of wild flowers and look for the purple Tulic flower.\nAfter searching through acres of flowers you see a purple glow.\nYou practically float to it and recognize it to be the Tulic Flower.\nYou carefully pick it and place it in your bag.");
            ReadKey();
            WriteLine("You run back to the dock and hope to catch Captian Mike, you want to return home as soon as possible.");
            ReadKey();
            WriteLine("To your luck he's still there and agrees to help you return home to help your cousin.\nHe even knows a shortcut around the forest.");
            ReadKey();
            WriteLine($"You race to your Uncle Kit's house and present him the flower. He beems with delight.\n'You've done it! Thank you {CurrentPlayer.Name}! I will never be able to repay you!'\nYou smile as he goes to help Emily.");
            ReadKey();
            EndGame();

        }
        public void EndGame()
        {
            //end of game text
            Clear();
            WriteLine($"Congradulations! You have reached the end! You successfully saved your cousin\nand explored the land of Nortar!");
            WriteLine("Press Enter to return to the main menu.");
            
            ReadKey();
            Clear();
            ViewMainMenu();
        }

        public void ViewLocations()
        {
            //this code was created in class
            Clear();

            List<string> locationNameAndDescriptions = new List<string>();
            foreach (var location in Locations)
            {
                locationNameAndDescriptions.Add($"{location.Name}: {location.Description}");
            }

            locationNameAndDescriptions.Add("Go back to main menu");

            int choice = Utility.ShowUserOptionsAndGetAValidResponse("Here are the locations, have you visited them all?", locationNameAndDescriptions);
            if (choice == Locations.Count)
            {
                //Time to go back
                ViewMainMenu();
            }
            
        }

        public void ViewInventory()
        {
            Console.Clear();
            if (CurrentPlayer.Inventory.Count > 0)
            {
                foreach (var item in CurrentPlayer.Inventory)
                {
                    WriteLine($"{item.Name}:{item.Description}");
                }
            }
            else
            {
                WriteLine("Your inventory is empty");
            }

            Utility.DelayUser();
            ViewMainMenu();
        }
        public void Setup()
        {

            Item oneMap = new Item()
            {
                Name = "Map Piece 1",
                Description = "The bottom right corner of a map."
            };
            Item twoMap = new Item()
            {
                Name = "Map Piece 2",
                Description = "The bottom left corner of a map."
            };
            Item threeMap = new Item()
            {
                Name = "Map Piece 3",
                Description = "The top right corner of a map."
            };
            Item fourMap = new Item()
            {
                Name = "Map Piece 4",
                Description = "The top left corner of a map."
            };
            Item tulicFlower = new Item()
            {
                Name = "Tulic Flower",
                Description = "A beautiful, purple flower with magical healing properties."
            };
            Item torch = new Item()
            {
                Name = "Torch",
                Description = "A firey stick that lights the way."
            };
            Item bag = new Item()
            {
                Name = "A bag",
                Description = "An old leather bag to carry your things in."
            };

            Location townWell = new Location()
            {
                Name = "The Wishing Well",
                Description = "Right outside of your home. A familiar location, a great place to start.",
                Items = {oneMap},
                RequiredItems = {bag}
            };
            Locations.Add(townWell);

            Location forest = new Location()
            {
                Name = "The Haunted Forest",
                Description = "A dark and dense forest, you have always been warned not to travel too deep.",
                Items = {torch, twoMap},
                RequiredItems = {bag}
            };
            Locations.Add(forest);

            Location lake = new Location()
            {
                Name = "The Lake of Mander",
                Description = "A vast body of water with viscious waves.",
                Items = { fourMap },
                RequiredItems = {oneMap,twoMap,threeMap}
            };
            Locations.Add(lake);

            Location nortar = new Location()
            {
                Name = "Nortar",
                Description = "A beautiful village with cobblestone streets and fields of flowers surrounding it.",
                Items = {tulicFlower},
                RequiredItems = {oneMap, twoMap, threeMap, fourMap}
            };
            Locations.Add(nortar);
        }
    }
}
