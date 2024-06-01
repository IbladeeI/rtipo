using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Casino.Services.Symbol;

namespace Casino.Services
{
    public class Die
    {
        private static Random random = new Random();//Для рандома
        public Symbol Symbol { get; private set; }

        public void Roll()//Рол мастей кубиков
        {
            SymbolType[] symbols = new[] { SymbolType.Crown, SymbolType.Anchor, SymbolType.Heart, SymbolType.Spade, SymbolType.Club, SymbolType.Diamond };//Передача типов
            Symbol = new Symbol(symbols[random.Next(symbols.Length)]);//Рол из этих типов
        }
    }
}
