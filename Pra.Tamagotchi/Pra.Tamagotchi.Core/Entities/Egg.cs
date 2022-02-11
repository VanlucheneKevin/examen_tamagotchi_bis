using System;

using Pra.Tamagotchi.Core.Interfaces;
using Pra.Tamagotchi.Core.Enums;
using System.Text;

namespace Pra.Tamagotchi.Core.Entities
{
    public class Egg : Tamagotchi, IHatchable
    {
        public Egg() : base()
        {

        }
        public override void Grow()
        {
            Size++;
        }

        public Chick Hatch()
        {
            Chick chick = new Chick(Status);
            if (Size < 3)
            {
                throw new InvalidOperationException("Ei is niet groot genoeg om uit te broeden");
            }
            else if( Size >= 3 && Size < 6)
            {
                Status = random.Next(2) == 0 ? TamagotchiStatus.Healthy : TamagotchiStatus.Sick;
            }
            else
            {
                Status = TamagotchiStatus.Healthy;
            }
            return chick ;
        }

        public override string ToString()
        {
            StringBuilder eggBuilder = new StringBuilder();
            
            eggBuilder.AppendLine($"Ei +{eggBuilder.Append('*', Size)}");

            return eggBuilder.ToString();

        }
    }
}
