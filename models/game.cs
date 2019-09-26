namespace CatGame
{
    public class Game 
    {
        public string PlayerName {get; set;}
        public int HP {get; set;}
        public int TurnCount {get; set;}
        public bool Dead {get; set;}
        
        public Game(string name)
        {
            PlayerName = name;
            HP = 25;
            TurnCount = 0;
            Dead = false;
        }

        public void SetDead()
            {
                if(HP <= 0 || TurnCount > 10)
                {
                    Dead = true;
                }
            }
        
        public string ReturnDead()
            {
            if(Dead == true)
                {
                    return "You have died.";
                }
            else
                {
                    return "You are still livin'";
                }   
            }

        public int TurnUp()
        {
            TurnCount = TurnCount + 1;
            return TurnCount;
        }
    }
    public class Inventory
    {
        public bool Knife {get; set;}
        public bool DogBone {get; set;}
        public bool Watch {get; set;}

        public Inventory()
        {
            Knife = false;
            DogBone = false;
            Watch = false;
        }

    }
    
    public class Bonuses
    {
        public int WaterBottle {get; set;}
        public int Sandwich {get; set;}
        public int FlyKite {get; set;}

        public Bonuses()
        {
            WaterBottle = 5;
            Sandwich = 5;
            FlyKite = 5;
        }

    }
    public class Events
    {
        public int Mugger {get; set;}
        public int MissTrain {get; set;}
        public int PassOut {get; set;}
        public int DogChase {get; set;}

        public Events()
        {
            Mugger = 15;
            MissTrain = 2;
            PassOut = 20;
            DogChase = 10; 
        } 
    }
}