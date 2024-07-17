namespace ParkingManagementServices
{
    public class UserValidationServices
    {

        UserGetServices getservices = new UserGetServices();

        public bool CheckIfUserNameExists(string plateNum)
        {
            bool result = getservices.GetUser(plateNum) != null;
            return result;
        }

        public bool CheckIfUserExists(string plateNum, string colorCar)
        {
            bool result = getservices.GetUser(plateNum, colorCar) != null;
            return result;
        }

    }
}
