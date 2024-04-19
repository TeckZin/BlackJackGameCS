using System.Dynamic;

namespace BlackJackGameCS;

public class Card
{
    public string suit { get; }
    public string rank { get;  }
    public int value { get;  }
    private string consoleLog; 
    
    
    public Card(string suit, string rank, int value)
    {
       this.suit = suit;
       this.rank = rank;
       this.value = value;




    }









}