using System.Collections.Generic;
using System.Linq;

namespace BlackJackGameCS;

public class Player
{

    private int playerNum { get; set;  }
    private List<Card> hand { get; set;  }


    private List<int> totalPosssiblities;

    public Player(int playerNum)
    {
        
        this.playerNum = playerNum;
        this.totalPosssiblities = new List<int>();
        this.totalPosssiblities.Append(0);


    }


    public bool addCard(Card card)
    {
        var enumerable = this.hand.Append(card);
        if (enumerable != null)
        {
            return true;
            
        }

        return false; 
    }


    private int checkHandValue()
    {

        return 0;

    }
    
    
    
    
    

    
    
    
}