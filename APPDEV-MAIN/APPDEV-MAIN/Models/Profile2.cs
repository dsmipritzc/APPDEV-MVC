namespace APPDEV_MAIN.Models
{
    public class Profile2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


        public string FullName { get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
