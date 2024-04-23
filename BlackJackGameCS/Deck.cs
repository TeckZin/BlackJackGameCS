using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace BlackJackGameCS;

public class Deck
{

   private List<string> suits;
   private List<string> ranks;
   private List<int> values;

   private List<Card> deck; 
   
   public Deck(int amountDeck)
   {
      
      
      this.ranks = new List<string>();
      this.suits = new List<string>();
      this.values = new List<int>();
      this.deck = new List<Card>();
      this.suits.Add("S");
      this.suits.Add("H");
      this.suits.Add("C");
      this.suits.Add("D");
      for (int j = 0; j < amountDeck; j++)
      {
            
         for (int i = 1; i <= 13; i++)
         {
         

            if (i >= 11)
            {
               this.ranks.Add(i.ToString());
               this.values.Add(i);
            } else
            {
               this.values.Add(10);
            
               switch (i)
               {
                  case 11:
                     this.ranks.Add("J");
                     break;
                  case 12:
                     this.ranks.Add("Q");
                     break;
                  case 13:
                     this.ranks.Add("K");
                     break;
                  default:
                     this.ranks.Add(Convert.ToString(i));
                     break;
               }
            
            }
         
         
         
         
         
         }
      }
      Console.WriteLine("suits: " + suits.Count);
      Console.WriteLine("ranks: " + ranks.Count);
      Console.WriteLine("values: " + values.Count);
      foreach (string suit in suits) {
         for (int i = 0; i < 13; i++)
         {
            int value = this.values[i]; 
            string rank = this.ranks[i];
            Card card;
            if (i >= 10)
            {
               
               card = new Card(suit, rank, 10);
            }
            else
            {
               
               card = new Card(suit, rank, value);
            }
            this.deck.Add(card);
            // Console.WriteLine(deck.Count());
            

         }
      }
      
      shuffleDeck();
     // Console.WriteLine(this.deck); 
   }


   public void generatePlayersCard(List<Player> players)
   {
       
       Console.WriteLine(deck.Count);
      int idx = 0;
      for (int i = 0; i < 2; i++)
      {
         
         foreach (Player player in players)
         {
             
            if (idx >= 54)
            {
               break;
            } 
            Card card = deck[0];
            player.addCard(card);
            deck.RemoveAt(0);
            idx++;
         }
         
         
         
      }
      
      
   }

   public void shuffleDeck()
   {
      Random rand = new Random();


      for (int i = deck.Count() - 1; i > 1; i--)
      {
         int randNum = rand.Next(i + 1);
         Card card = deck[randNum];
         deck[randNum] = deck[i];
         deck[i] = card;
      }


   }
    
    
    
    
   
   
   
   
   // foo
   // foo
   // foo
   // foo
   // foo
   
   // data[0]= "foo"l;
   // data[2]= "Baz"l;
   // data[1]= "Bar"l;
   // data[3]= "Buzz"l;
               
   //dat[0];
   
   //data[0] = "foo";
   //data[1] = "bar";
   //data[2] = "baz";
   //data[3] = "buzz";
   
   
   
   // foo
   // foo
   // foo
   // foo
   // foo
   
}