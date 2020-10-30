namespace Core.Entities
{
    public class Owner : BaseEntity
    {
        public string FullName { get; set; }
        public string Profile { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}

