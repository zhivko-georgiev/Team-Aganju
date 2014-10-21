namespace YorubaMyths.Interfaces
{
    public interface IPlayer
    {
        int MaxHealthPoints { get; set; }

        int DefensePoints { get; set; }

        int AttackPoints { get; set; }

        int CurrentHealthPoints { get; set; }

        bool IsAlive { get; set; }
    }
}