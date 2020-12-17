using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; set; }

        Value Value { get; set; }
    }
}
