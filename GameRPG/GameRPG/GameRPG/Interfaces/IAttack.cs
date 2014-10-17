namespace GameRPG.Interfaces
{
    public interface IAttack
    {
        int AttackPoints { get; set; }

        int Range { get; set; }

        double AutoAttackSped { get; set; }
    }
}
