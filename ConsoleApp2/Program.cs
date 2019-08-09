using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class CombatCard
    {
        static void Main(string[] args)
        {
            private string name;
            private int attackPoints;
            private bool hero;
            private string type;
            private string effect;

            public string Name { get => name; set => name = value; }
            public int AttackPoints { get => attackPoints; set => attackPoints = value; }
            public bool Hero { get => hero; set => hero = value; }
            public string Type { get => type; set => type = value; }
            public string Effect { get => effect; set => effect = value; }
        }
    }

    public class SpecialCard
    {
        static void Main(string[] args)
        {
            private string name;
            private string type;
            private string buffType;
            private string effect;

            public string Name { get => name; set => name = value; }
            public string Type { get => type; set => type = value; }
            public string BuffType { get => buffType; set => buffType = value; }
            public string Effect { get => effect; set => effect = value; }
        }
    }

    public class Player
    {
        static void Main(string[] args)
        {
            private int lifePoints;
            private int attackPoints;
            private Deck deck;
            private Hand hand;
            private Board board;
            private SpecialCard captain;

            public int LifePoints { get => lifePoints; set => lifePoints = value; }
            public int AttackPoints { get => attackPoints; set => attackPoints = value; }
            public Deck DECK { get => deck; set => deck = value; }
            public Hand HAND { get => hand; set => hand = value; }
            public Board BOARD { get => board; set => board = value; }
            public SpecialCard Specialcard { get => captain; set => captain = value; }

            public void DrawCard()
            {

            }
    
            public void PlayCard(int cardId)
            {

            }

            public void ChangeCard(int cardId)
            {

            }

            public void FirstHand()
            {

            }

            public void ChooseCaptainCard(SpecialCard captainCard)
            {

            }
        }
    }

    public class Board
    {
        static void Main(string[] args)
        {







        }





    }

    public class Game
    {
        static void Main(string[] args)
        {







        }





    }

    public class Deck
    {
        static void Main(string[] args)
        {







       }





    }

    public class Hand
    {
        static void Main(string[] args)
        {







        }





    }
}
