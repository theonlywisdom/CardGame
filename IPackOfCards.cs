﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public interface IPackOfCards : IReadOnlyCollection<ICard>
    {
        void Shuffle();

        ICard TakeCardFromTopOfPack();
    }

}
