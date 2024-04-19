using System.Collections.Generic;

namespace BlackJackGameCS;

public class Player
{

    private int playerNum { get; set;  }
    private List<string> hand; 

    public Player(int playerNum)
    {
        this.playerNum = playerNum; 

    }


    public bool addCard(string card)
    {
        return true;
    }


    private int checkHandValue()
    {
        
        

        return 0;

    }
    
    
    
    
    

    
    
    
}