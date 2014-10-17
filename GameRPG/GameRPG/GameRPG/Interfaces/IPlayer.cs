namespace GameRPG.Interfaces
{
    public interface IPlayer
    {

        int MaxHealtPoints { get; set; }

        int DefensePoints { get; set; }

        int CurrentHealtPoints { get; set; }

        bool IsAlive { get; set; }
    }
}
