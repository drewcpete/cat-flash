namespace CatGame
{
    public class Game 
    {
        public string PlayerName {get; set;}
        public int hp {get; set;}
        public int TurnCount {get; set;}
        public bool Dead {get; set;}
        
        public Game(string name)
        {
            PlayerName = name;
            hp = 25;
            TurnCount = 0;
            Dead = false;
        }
        
        
        
    }
    public class Inventory
    {
        public string Knife {get; set;}
        public string Sandwich {get; set;}
        public string DogBone {get; set;}
    }
}
