namespace WebApiFetchSample.Entity
{
    public class person
    {
        public int personId { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime StarDate { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"{FirstName} ,{LastName}";
        }
    }
}
