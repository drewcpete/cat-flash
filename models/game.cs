namespace CatGame
{
    public class Game 
    {
        public string PlayerName {get; set;}
   
        public int TurnCount {get; set;}
        public bool Dead {get; set;}
        public int MissTrain {get; set;}

        
        public Game(string name)
        {
            PlayerName = name;     
            TurnCount = 0;
            Dead = false;
            MissTrain = 2;
        }

        public void SetDeadTurn()
            {
                if(TurnCount > 10)
                {
                    Dead = true;
                }
            }
        
        public string ReturnDeadTurn()
            {
            if(Dead == true)
                {
                    return "You have died.";
                }
            else
                {
                    return "";
                }   
            }

        public void TurnUp()
        {
            TurnCount = TurnCount + 1;
        }

        public string MissTurnTrain()
        {
            TurnCount = TurnCount + MissTrain;
            return $"You have {TurnCount} turns.";
        }
    }
    public class Inventory
    {
        public bool Knife {get; set;}
        public bool DogBone {get; set;}
        public bool Watch {get; set;}
        public bool HaveWaterBottle {get; set;}

        public Inventory()
        {
            Knife = false;
            DogBone = false;
            Watch = false;
            HaveWaterBottle = false;

        }
        public void FindKnife()
        {
            Knife = true;
        }
        public void FindDogBone()
        {
            DogBone = true;
        }
        public void FindWatch()
        {
            Watch = true;
        }

        public void GetWaterBottle()
        {
            HaveWaterBottle = true;
        }

    }
    
    
    public class HealthEvents
    {

        public int Mugger {get; set;}
        public int PassOut {get; set;}
        public int DogChase {get; set;}
        public int WaterBottle {get; set;}
        public int Sandwich {get; set;}
        public int FlyKite {get; set;}
        public int HP {get; set;}
        public bool Dead{get; set;}

        public HealthEvents()
        {
            Mugger = 15;     
            PassOut = 20;
            DogChase = 10; 
            WaterBottle = 25;
            Sandwich = 5;
            FlyKite = 5;
            HP = 25;          
        } 
        public string MuggerEvent()
        {
            HP = HP - Mugger;
            return "Your health level is" + HP;
        }
        public string PassOutEvent()
        {
            HP = HP - PassOut;
            return $"Your health level is {HP}"; 
        }
        public string DogChaseEvent()
        {
            HP = HP - DogChase;
            return $"Your health level is {HP}";
        }
        public string DrinkWaterEvent()
        {
            HP = HP + 5;
            WaterBottle = WaterBottle - 5;
            return $"Your health level is {HP}";
        }
        public string EatSandwichEvent()
        {
            HP = HP + Sandwich;
            return $"Your health level is {HP}";
        }
        public string FlyKiteEvent()
        {
            HP = HP + FlyKite;
            return $"Your health level is {HP}";
        }

        public void SetDeadHP()
            {
                if(HP<=0)
                {
                    Dead = true;
                }
            }
        
        public string ReturnDeadHP()
            {
            if(Dead == true)
                {
                    return "You have died.";
                }
            else
                {
                    return "";
                }   
            }
    }
}