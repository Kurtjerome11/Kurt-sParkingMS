using Microsoft.AspNetCore.Mvc;
using ParkingManagementData;
using ParkingManagementModels;
using ParkingManagementServices;

namespace ParkingAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {
        UserGetServices _userGetServices;
        UserTransactionServices _userTransactionServices;

        public UserController()
        {
            _userGetServices = new UserGetServices();
            _userTransactionServices = new UserTransactionServices();
        }

        [HttpGet]
        [Route("displayparkedcars")]
        public IEnumerable<ParkingAPI.User> GetUsers()
        {
            var activeusers = _userGetServices.GetUsersByStatus(1);

            List<ParkingAPI.User> users = new List<User>();

            foreach (var item in activeusers)
            {
                users.Add(new ParkingAPI.User { plateNum = item.plateNum, colorCar = item.colorCar, status = item.status });
            }

            return users;
        }

        [HttpPost]
        [Route("carsthatwillpark")]
        public JsonResult AddUser(User request)
        {
            var result = _userTransactionServices.CreateUser(request.plateNum, request.colorCar);

            return new JsonResult(result);
        }

        [HttpPatch]
        [Route("notincludedinmyparkingsystem")]
        public JsonResult UpdateUser(User request)
        {
            var result = _userTransactionServices.UpdateUser(request.plateNum, request.colorCar);

            return new JsonResult(result);
        }

        [HttpDelete]
        [Route("carsthatwillgo")]
        public JsonResult DeleteUser(User request)
        {
            var result = _userTransactionServices.DeleteUser(request.plateNum, request.colorCar);

            return new JsonResult(result);
        }


    }
}
