namespace Common.Interfaces
{
    public interface IPerson
    {
        public int SSN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }

        public void BookingCustomer() { }

    }
}

