using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Services
{
    public class Symbol
    {
        public enum SymbolType// Перечисление мастей
        {
            Crown, Anchor, Heart, Spade, Club, Diamond
        }
        public SymbolType Value { get; private set; }// Конструкт для значений символа 

        public Symbol(SymbolType value)// Значение символа
        {
            Value = value;
        }
    }
}
