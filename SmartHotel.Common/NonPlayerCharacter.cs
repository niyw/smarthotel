using System;

namespace SmartHotel.Common
{
    public class NonPlayerCharacter
    {
        public int Health { get; set; }
        public void TakeDamage(int damage)
        {
            Health = 100 - damage;
            if (Health < 1)
                Health = 1;
        }

    }
}
