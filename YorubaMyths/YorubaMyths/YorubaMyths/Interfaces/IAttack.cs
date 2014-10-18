namespace YorubaMyths.Interfaces
{
    public interface IAttack
    {
        int AttackPoints { get; set; }

        int Range { get; set; }

        double AutoAttackSpeed { get; set; }
    }
}