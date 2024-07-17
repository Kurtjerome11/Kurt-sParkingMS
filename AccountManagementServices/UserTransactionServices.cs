using ParkingManagementData;
using ParkingManagementModels;

namespace ParkingManagementServices
{
    public class UserTransactionServices
    {
        UserValidationServices validationServices = new UserValidationServices();
        UserData userData = new UserData();

        public bool CreateUser(User user)
        {
            bool result = validationServices.CheckIfUserNameExists(user.plateNum);


            if (result)
            {
                userData.AddUser(user);
            }

            return result;
        }

        public bool CreateUser(string plateNum, string colorCar)
        {
            User user = new User { plateNum = plateNum, colorCar = colorCar };

            return CreateUser(user);
        }

        public bool UpdateUser(User user)
        {
            bool result = validationServices.CheckIfUserNameExists(user.plateNum);

            if (result)
            {
                userData.UpdateUser(user);
            }

            return result;
        }

        public bool UpdateUser(string plateNum, string colorCar)
        {
            User user = new User { plateNum = plateNum, colorCar = colorCar };

            return UpdateUser(user);
        }

        public bool DeleteUser(User user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.plateNum))
            {
                result = userData.DeleteUser(user) > 0;
            }

            return result;
        }

        public bool DeleteUser(string plateNum, string colorCar)
        {
            User user = new User { plateNum = plateNum, colorCar = colorCar };

            return UpdateUser(user);
        }
    }
}
