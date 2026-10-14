namespace APPDEV_MAIN.Models
{
    public class Member1
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        
        public string FullName { get 
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
