using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library {
    public class Hand : IEnumerable{
        private  List<Card> hand = new List<Card>();

        public  Hand() {
            hand = new List<Card>();
        }

        public Hand(List<Card> cards) {
            hand = new List<Card>();
            hand = cards;
        }

        public  int GetCount() {
            int count = 0;
            count = hand.Count;
            return count;
        }

        public  Card GetCard(int index) {
            Card card;
            card = hand[index];
            return card;
        }

        public  void Add(Card card) {
            hand.Add(card);
        }

        public bool Contains(Card card) {
            return hand.Contains(card);
        }

        public bool Remove(Card card) {
            return hand.Remove(card);
            }

        public void RemoveAt(int index) {
            hand.RemoveAt(index);
        }

        public void Sort() {
            hand.Sort();
        }











        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }

    }
}
