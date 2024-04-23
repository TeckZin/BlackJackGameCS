using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackGameCS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Game Launch");

            List<Player> playerList = new List<Player>();

            int totalNumPlayers = 3;

            for (int playerNum = 0; playerNum <= totalNumPlayers; playerNum++)
            {

                Player player = new Player(playerNum);
                playerList.Add(player);

            }

            Deck deck = new Deck(1);
            deck.generatePlayersCard(playerList);


            foreach (Player player in playerList)
            {
                foreach (Card card in player.hand)
                {
                    Console.WriteLine(card.visual);
                }
                
            }
        }
    }
}