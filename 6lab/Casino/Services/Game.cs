using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Services
{
    public class Game
    {
        public Die[] dice;//3 Кубика без значений
        public User player;//Юзер
        public List<Bet> bets = new List<Bet>();//Список ставок

        public Game(User player)//При создании игры создает три пустых кубика для дальнейшего заполнения
        {
            this.player = player;
            dice = new Die[3];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        public bool StartGame()//Запуск раунд ролит 3 масти в кубиках, высчитывает вин/луз, стирает ставку
        {
            if (this.bets.Count <= 0) return false;
            RollDice();
            checkPayout(this.bets.ToArray());
            removeBets();
            return true;
        }

        public void RollDice()//Ролит значения для 3 кубиков
        {
            Symbol[] result = new Symbol[dice.Length];//Создает массив мастей для 3 кубиков
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();//Ролит значение для кубиков
                result[i] = dice[i].Symbol;//Передает в результ
            }
        }

        public int checkPayout(Bet[] bets)//
        {
            int totalPayout = 0;//расчитанная ставка в зависимости от вин/луз
            int allBetsAmount = 0;//для минуса поставленных денег
            foreach (Bet bet in bets)//проходимся по ставкам
            {
                int matches = dice.Count(d => d.Symbol.Value == bet.Symbol.Value);//нахождение совпадение между заролиными и ставкой
                allBetsAmount -= bet.Amount;//минусует деньги со ставки
                totalPayout += matches * bet.Amount;//умножает деньги со ставки на кол-во совпадений
            }
            int result = (player.Balance + allBetsAmount) + totalPayout;//высчет баланса
            this.updateBalance(result);//апдейт баланса
            return totalPayout;
        }

        public bool saveBet(Bet bet)//Сейв ставки
        {
            int totalBetsAmount = bets.Sum((el) => el.Amount) + bet.Amount;//Проверка могу ли поставить ставку
            if (totalBetsAmount > this.player.Balance)
                return false;
            if (bets.Any(s => s != null && s.Symbol.Value.ToString() == bet.Symbol.Value.ToString()))//Убирает повторяющуюся ставку (мб пользователь нажал 2 раза на одну и ту )
            {
                bets.Where(s => s.Symbol.Value.ToString() == bet.Symbol.Value.ToString());
                return true;
            }
            else
            {
                bets.Add(bet);//Добавление ставки
                return true;
            }
        }

        public void updateBalance(int balance)
        {
            player.Balance = balance;
        }

        public void removeBets()
        {
            this.bets.Clear();
        }
    }
}
