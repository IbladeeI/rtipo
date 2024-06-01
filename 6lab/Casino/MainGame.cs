using Casino.Services;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class MainGame : MaterialForm
    {
        Game game;
        public MainGame(Game game)//Конструктор для инициализации игры
        {
            InitializeComponent();
            this.game = game;
            updateUIBalance();
        }


        private void updateUIBalance()//Обновление баланса игрока
        {
            balance.Text = this.game.player.Balance.ToString();
        }

        private void updateUIBet(Button btn)//Пометка выбранной масти для ставки
        {
            if (btn.BackColor == Color.Red)
            {
                // Устанавливаем цвет кнопки в стандартный цвет по умолчанию
                btn.BackColor = SystemColors.Control;
            }
            else
            {
                // Устанавливаем цвет кнопки в красный
                btn.BackColor = Color.Red;
            }

        }

        private void updateUIDieRool()//Апдейт зароленых результатов раунда
        {
            die1.Text = updateStringRoll(game.dice[0].Symbol.Value.ToString());
            die2.Text = updateStringRoll(game.dice[1].Symbol.Value.ToString());
            die3.Text = updateStringRoll(game.dice[2].Symbol.Value.ToString());
        }
        private string updateStringRoll( string str)//Замена результатов с текста на смайл
        {
            if (str == "Crown")
            {
                return "👑";
            }
            if (str == "Anchor")
            {
                return "⚓";
            }
            if (str == "Heart")
            {
                return "♥️";
            }
            if (str == "Spade")
            {
                return "♠️";
            }
            if (str == "Club")
            {
                return "♣️";
            }
            return "♦️";
        }


        private void Crown_Click(object sender, EventArgs e)//Для клика по выбранной масти
        {
            bool check = errorValueAmountBet();//Провека поля ставки
            if (!check)
            {
                return;
            }
            game.player.setSuit(new Symbol(Symbol.SymbolType.Crown));//Создание выбранного исхода
            Bet bet = new Bet(int.Parse(payBox.Text), game.player.Symbol);//Создание ставки деньги и масть
            bool isSave = game.saveBet(bet);//сейв ставки
            if (!isSave) error();
            else
                updateUIBet(Crown);//Апдейт масти

        }


        private void Anchor_Click(object sender, EventArgs e)
        {
            bool check = errorValueAmountBet();
            if (!check)
            {
                return;
            }
            game.player.setSuit(new Symbol(Symbol.SymbolType.Anchor));
            Bet bet = new Bet(int.Parse(payBox.Text), game.player.Symbol);
            bool isSave = game.saveBet(bet);
            if (!isSave) error();
            else
                updateUIBet(Anchor);

        }

        private void Heart_Click(object sender, EventArgs e)
        {
            bool check = errorValueAmountBet();
            if (!check)
            {
                return;
            }
            game.player.setSuit(new Symbol(Symbol.SymbolType.Heart));
            Bet bet = new Bet(int.Parse(payBox.Text), game.player.Symbol);
            bool isSave = game.saveBet(bet);
            if (!isSave) error();
            else updateUIBet(Heart);
        }

        private void Spade_Click(object sender, EventArgs e)
        {
            bool check = errorValueAmountBet();
            if (!check)
            {
                return;
            }
            game.player.setSuit(new Symbol(Symbol.SymbolType.Spade));
            Bet bet = new Bet(int.Parse(payBox.Text), game.player.Symbol);
            bool isSave = game.saveBet(bet);
            if (!isSave) error();
            else updateUIBet(Spade);
        }

        private void Club_Click(object sender, EventArgs e)
        {
            bool check = errorValueAmountBet();
            if (!check)
            {
                return;
            }
            game.player.setSuit(new Symbol(Symbol.SymbolType.Club));
            Bet bet = new Bet(int.Parse(payBox.Text), game.player.Symbol);
            bool isSave = game.saveBet(bet);
            if (!isSave) error();
            else updateUIBet(Club);
        }

        private void Diamond_Click(object sender, EventArgs e)
        {
            bool check = errorValueAmountBet();
            if (!check)
            {
                return;
            }
            game.player.setSuit(new Symbol(Symbol.SymbolType.Diamond));
            Bet bet = new Bet(int.Parse(payBox.Text), game.player.Symbol);
            bool isSave = game.saveBet(bet);
            if (!isSave) error();
            else updateUIBet(Diamond);
        }

        private void button1_Click(object sender, EventArgs e)//Нажал на кнопку играть
        {
            bool isStart = this.game.StartGame();
            if (isStart)
            {
                updateUIDieRool();
                updateUIBalance();
                Crown.BackColor = SystemColors.Control;//Апдейт баланса и то что выпала + перекраска кнопок в дефолт
                Anchor.BackColor = SystemColors.Control;
                Heart.BackColor = SystemColors.Control;
                Spade.BackColor = SystemColors.Control;
                Club.BackColor = SystemColors.Control;
                Diamond.BackColor = SystemColors.Control;
            }
            else
            {
                errorBets();
            }
            
        }

        public void error(){
            const string message =
        "Не хватает баланса";
            const string caption = "Ошибка ставки";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
        }

        public void errorBets()
        {
            const string message =
        "Выберите хотя бы одну масть";
            const string caption = "Ошибка ставки";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
        }

        public bool errorValueAmountBet()
        {
            try
            {
                if(int.Parse(payBox.Text) < 1)
                {
                    throw new Exception();
                }
                return true;
            } catch {
                const string message = "Ставка введена не верно или не введена";
                const string caption = "Ошибка ставки";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)//Сброс ставки
        {
            game.player.removeSuits();//Сброс мастей
            game.removeBets();//Сброс ставки
            Crown.BackColor = SystemColors.Control;
            Anchor.BackColor = SystemColors.Control;
            Heart.BackColor = SystemColors.Control;
            Spade.BackColor = SystemColors.Control;
            Club.BackColor = SystemColors.Control;
            Diamond.BackColor = SystemColors.Control;


            payBox.Text = "";//Замена на пустое значение
            const string message =
        "Ставки сброшены";
            const string caption = "Ставка";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }

        private void die1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void balance_Click(object sender, EventArgs e)
        {

        }
    }
}
