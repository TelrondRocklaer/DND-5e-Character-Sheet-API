namespace DND5eAPI.Models.Extra
{
    public class SpellSlotDataNode(int level, int maxAvailable, int used = 0)
    {
        public int Level { get; set; } = level < 10 ? level : throw new ArgumentException("Max level spell slot is 9");
        public int MaxAvailable { get; set; } = maxAvailable < 5 ? maxAvailable : throw new ArgumentException("Max number of available spell slots of a single level is 4");
        public int Used { get; set; } = used <= maxAvailable ? used : throw new ArgumentException("Number of used spellslots higher than max number of spellslots");
    }
}
