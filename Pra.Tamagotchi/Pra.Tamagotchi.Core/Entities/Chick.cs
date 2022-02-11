using System;
using Pra.Tamagotchi.Core.Interfaces;
using Pra.Tamagotchi.Core.Enums;

namespace Pra.Tamagotchi.Core.Entities
{
    public class Chick : Tamagotchi, IFeedable
    {
        private int amountOfFood = 0;
        public Chick(TamagotchiStatus status) : base()
        {
            Status = status;
        }
        public void Feed()
        {
           if (amountOfFood == 0)
            {
                throw new InvalidOperationException("Je tamagotchi is overleden, kan geen acties meer uitvoeren");
            }
            else
            {
            amountOfFood++;
            }
        }

        public override void Grow()
        {
            if (Status == TamagotchiStatus.Died || amountOfFood == 0)
            {
                throw new InvalidOperationException("Je tamagotchi is overleden, kan geen acties meer uitvoeren");
            }
            else if (Status == TamagotchiStatus.Sick)
            {
                Health -= 50;
            }
            else if (Status == TamagotchiStatus.Healthy)
            {
                Size++;
                amountOfFood--;
            }

        }

        public override string ToString()
        {
            return $"Kuiken [{Status}] -- Health = {Health} -- Size = {Size} (food: {amountOfFood})";
        }
    }
}
