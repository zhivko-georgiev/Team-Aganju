namespace YorubaMyths.Interfaces
{
    using YorubaMyths.GameObjects.Items;

    public interface IItem
    {
        ItemType ItemType { get; set; }

        int HealtPonints { get; set; }

        int DefensePoints { get; set; }
    }
}