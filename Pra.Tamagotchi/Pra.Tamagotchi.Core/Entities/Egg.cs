using System;

using Pra.Tamagotchi.Core.Interfaces;
using Pra.Tamagotchi.Core.Enums;
using System.Text;

namespace Pra.Tamagotchi.Core.Entities
{
    public class Egg : Tamagotchi, IHatchable
    {
        
        public override void Grow()
        {
            Size++;
        }

        public Chick Hatch()
        {
            TamagotchiStatus chickStatus;
            if (Size < 3)
            {
                throw new InvalidOperationException("Ei is niet groot genoeg om uit te broeden");
            }
            else if( Size < 6)
            {
                //int index = random.Next(2);
                chickStatus = (TamagotchiStatus)random.Next(2);
            }
            else
            {
                chickStatus = TamagotchiStatus.Healthy;
            }
            return new Chick(chickStatus);
        }

        public override string ToString()
        {
            StringBuilder eggBuilder = new StringBuilder();
            
            eggBuilder.AppendLine($"Ei +{eggBuilder.Append('*', Size)}");

            return eggBuilder.ToString();

        }
    }
}
