namespace DND5eAPI.Models.Extra
{
    public class ToolAction
    {
        public string Name { get; set; }
        public string Attribute { get; set; }
        public int DC { get; set; }

        public ToolAction(string name, string attribute, int dc)
        {
            Name = name;
            if (Attributes.Exists(attribute) == false)
            {
                throw new ArgumentException("Attribute does not exist");
            }
            if (dc < 0)
            {
                throw new ArgumentException("DC must be greater than or equal to 0");
            }
            Attribute = attribute;
            DC = dc;
        }
    }
}
