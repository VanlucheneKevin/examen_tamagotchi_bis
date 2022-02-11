using Pra.Tamagotchi.Core.Entities;
using Pra.Tamagotchi.Core.Interfaces;
using System.Collections.Generic;

namespace Pra.Tamagotchi.Core.Services
{
    public class TamagotchiCollection
    {
        public List<ITamagotchi> Tamagotchis { get; }

        public TamagotchiCollection()
        {
            Tamagotchis = new List<ITamagotchi>();
            for (int i = 0; i < 3; i++)
            {

            Tamagotchis.Add(new Egg());
            }
        }

        public void AddEggs()
        {
           
                Egg newEgg = new Egg();
                Tamagotchis.Add(newEgg);
            
        }

        public void Hatch(Egg egg)
        {
            
            for (int i = 0; i < Tamagotchis.Count; i++)
            {
                Tamagotchis.RemoveAt(i);
                Tamagotchis.Insert(i, egg.Hatch());
            }
        }
    }
}
