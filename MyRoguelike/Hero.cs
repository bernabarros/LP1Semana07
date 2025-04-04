using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;
        public string Name{get;}
        public int XP
        {
            get
            {
                return xp;
            }
            set
            {
                if(value > 0)
                {
                    xp += value;
                }
            }
        }
        public int Level
        {
            get
            {
                return 1 + xp / 1000;
            }
        }
        public float Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;

                if(health < 0)
                {
                    health = 0;
                }
                else if(health > MaxHealth)
                {
                    health = MaxHealth;
                }
            }
        }
        public float MaxHealth
        {
            get
            {
                return (float)100 + (Level-1)*20;
            }
        }
    public Hero(string name)
    {
        Name = name;
        xp = 0;
        Health = MaxHealth;
    }

        public void TakeDamage(float damage)
        {
            health -= damage;
            xp += (int)damage /20;
        }

    }
}