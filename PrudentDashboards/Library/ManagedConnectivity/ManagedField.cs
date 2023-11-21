namespace Library.ManagedConnectivity
{
    public class ManagedField
    {
        public string Name { get; set; }
        public Type Type { get; set; }

        public ManagedField(string name, Type type)
        {
            Name = name;
            Type = type;
        }
    }
}
