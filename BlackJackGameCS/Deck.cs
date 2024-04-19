using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BlackJackGameCS;

public class Deck
{

   private List<string> suits;
   private List<string> ranks;
   private List<int> values;

   private List<Card> deck; 
   
   public Deck()
   {
      this.ranks = new List<string>();
      this.suits = new List<string>();
      this.values = new List<int>();
      this.deck = new List<Card>();
      this.suits.Append("S");
      this.suits.Append("H");
      this.suits.Append("C");
      this.suits.Append("D");
      for (int i = 1; i <= 13; i++)
      {
         if (i >= 11)
         {
            this.values.Append(10);
         }
         else
         {
            this.values.Append(i);
         }

         switch (i)
         {
            case 11:
               this.ranks.Append("J");
               break;
            case 12:
               this.ranks.Append("Q");
               break;
            case 13:
               this.ranks.Append("K");
               break;
            default:
               this.ranks.Append(Convert.ToString(i));
               break;
         }
               
            

      }


      foreach (string suit in suits)
      {

         for (int i = 0; i < 13; i++)
         {
            int value = this.values[i];
            string rank = this.ranks[i];

            Card card = new Card(suit, rank, value);
            this.deck.Append(card);
            

         }
      }
      
      
     Console.WriteLine(this.deck); 
     

   } 
    
    
    
    
    

}