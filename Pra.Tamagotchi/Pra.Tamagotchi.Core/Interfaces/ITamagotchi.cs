using Pra.Tamagotchi.Core.Enums;

namespace Pra.Tamagotchi.Core.Interfaces
{
    public interface ITamagotchi
    {
        int Health { get; }
        int Size { get; }
        TamagotchiStatus Status { get; }
        void Grow();
    }
}
