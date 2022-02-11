using System;
using Pra.Tamagotchi.Core.Enums;
using Pra.Tamagotchi.Core.Interfaces;

namespace Pra.Tamagotchi.Core.Entities
{
    public abstract class Tamagotchi : ITamagotchi
    {
        protected static Random random = new Random();
        private int health;
        private int size;

        public int Health
        {
            get { return health; }
            protected set 
            {
                if (value < 0)
                {
                    value = 0;
                } 
                
                health = value; 
            }
        }

        public int Size
        {
            get { return size; }
            protected set 
            {
                /*if (value < value)
                {
                    value = value;
                }*/
                    size = value; 
            }
        }


        public TamagotchiStatus Status { get; protected set; } = TamagotchiStatus.Healthy;

        public Tamagotchi() 
        {
            Health = 100;
            Size = 1;
            
            if (Health == 0)
            {
                Status = TamagotchiStatus.Died;
            }

        }

        public abstract void Grow();
       
    }
}
