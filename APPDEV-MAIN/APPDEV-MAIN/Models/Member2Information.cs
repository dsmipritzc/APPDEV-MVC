namespace APPDEV_MAIN.Models
{
    public class Member2Information
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string FullName { get
            {
                return this.FirstName + " " + this.MiddleInitial + "." + " " + this.LastName;
            } 
        }
    }
}
