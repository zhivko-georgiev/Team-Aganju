namespace GameRPG.Interfaces
{
    using GameRPG.GameObjects.Items;

    public interface IItem
    {

        ItemType ItemType { get; set; }

        int HealtPonint { get; set; }

        int DefensePoint { get; set; }
    }
}
