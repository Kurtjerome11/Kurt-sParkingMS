namespace ParkingManagementModels
{
    public class User
    {
        public string plateNum;
        public string colorCar;
        public DateTime dateVerified;
        private DateTime dateCreated = DateTime.Now;
        public DateTime dateUpdated;
        public UserProfile profile;
        public int status;
        public string colorNum;
    }
}