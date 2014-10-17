namespace GameRPG.Interfaces
{
    public interface ICastable
    {
        int SpellRange { get; set; }

        int SpellPower { get; set; }

        int Mana { get; set; }
    }
}
