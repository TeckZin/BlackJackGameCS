using System.Collections.Generic;
using System.Linq;

namespace BlackJackGameCS;

public class Player
{

    public int playerNum { get; set;  }
    public List<Card> hand { get; set;  }


    private List<int> totalPosssiblities;

    public Player(int playerNum)
    {
        
        this.playerNum = playerNum;
        this.totalPosssiblities = new List<int>();
        this.totalPosssiblities.Add(0);
        this.hand = new List<Card>();


    }


    public void addCard(Card card)
    {
        this.hand.Add(card);
    }


    private void checkHandValue()
    {
        

        List<int> newTotalPosssiblities = new List<int>();
        foreach (Card card in hand)
        {
            if (newTotalPosssiblities.Count == 0)
            {
                newTotalPosssiblities.Add(card.value);
            }
            else
            {
                if (card.value != 1)
                {
                    for (int i = 0; i < newTotalPosssiblities.Count; i++)
                    {
                        int x = newTotalPosssiblities[i];
                        newTotalPosssiblities[i] = x + card.value;
                        
                    } 
                }
                else
                {
                    
                    for (int i = 0; i < newTotalPosssiblities.Count; i++)
                    {
                        int x = newTotalPosssiblities[i];
                        newTotalPosssiblities[i] = x + card.value;
                        newTotalPosssiblities.Add(card.value + 11);

                    }                                            
                }
            }
        }

        totalPosssiblities = newTotalPosssiblities;
    }
    
    
    
    
    

    
    
    
}