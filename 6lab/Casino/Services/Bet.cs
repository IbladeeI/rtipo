using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Services
{
    public class Bet
    {
        public int Amount { get; set; }//Ставка деньги
        public Symbol Symbol { get; set; }//Бубны пики и тд 

        public Bet(int amount, Symbol symbol)//Конструктор для создания экземпляра класса ставки число/масть
        {
            Amount = amount;
            Symbol = symbol;
        }
    }
}
