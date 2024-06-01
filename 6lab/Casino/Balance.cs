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
    public partial class Balance : MaterialForm
    {
        Game game;

        public Balance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Чек баланса
        {
            try
            {
                int balance = int.Parse(textBox1.Text);
                if (balance < 10) {
                    throw new Exception("error");
                }
                Game game = new Game(new User(balance));//Создание игры
                this.Hide();
                Form main = new MainGame(game);//Передача игровой формы
                main.Show();

            }
            catch (Exception ex) {//Ошибка
                const string message =
        "Баланс должен быть в числовом формате не менее 10";
                const string caption = "Ошибка баланса";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
