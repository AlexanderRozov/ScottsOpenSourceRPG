﻿using System;

namespace Engine.Entities
{
    public class HealingPotion : Potion
    {
        private readonly int _amountToHeal;

        internal HealingPotion(Guid id, string name, string namePlural, int amountToHeal)
            : base(id, name, namePlural)
        {
            _amountToHeal = amountToHeal;
        }
    }
}
