using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Casino.Services
{
    public class User
    {
        public int Balance { get; set; }
        public Symbol Symbol;

        public User(int initialBalance)//Привязка баланса к игроку
        {
            Balance = initialBalance;
        }

        public bool PlaceBet(Bet bet)//Создание ставки
        {
            if (Balance >= bet.Amount)
            {
                Balance -= bet.Amount;
                return true;
            }
            return false;
        }

        public void setSuit(Symbol symbol)//Для выбора масти и создания ставки
        {
            Symbol = symbol;
        }

        public void removeSuits()//Сброс выбранной масти
        {
            Symbol = null;
        }

    }
}
