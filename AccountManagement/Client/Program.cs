using ParkingManagementData;
using ParkingManagementModels;
using System;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {
                {
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                    Console.WriteLine("|Kurt's Parking Management System|");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                    Console.WriteLine("What's good in the hood?");
                    Console.WriteLine("1.Car wants to Park");
                    Console.WriteLine("2.Car wants to go Out");
                    Console.WriteLine("3.Color and PlateNumber of the Cars that Parked");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - ");


                    Console.WriteLine("Enter the number of your choice:");
                    string number = Console.ReadLine();

                    if (number == "1")
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("What is the plateNumber?");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        string plateNum = Console.ReadLine();


                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("What is the color of the Car?");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        string colorCar = Console.ReadLine();
                        SqlDbData.AddUser(plateNum, colorCar);

                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("Okay Cool! Heres the parking ticket!");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");

                    }

                    else if (number == "2")
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("What is the plateNumber?");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        string plateNum = Console.ReadLine();
                        SqlDbData.DeleteUser(plateNum);

                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("Okay Cool! The Data of that Car is Deleted!");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                    }
                    else if (number == "3")
                    {
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                        Console.WriteLine("Okay, heres the plate number and the color of the car that parked:");
                        Console.WriteLine("");
                        GetUsers();
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
                    }

                else
                {
                    Console.WriteLine("ERROR");
                }


            }
        }

        //for Adding
        // SqlDbData.AddUser("testing", "testing123!");


        //for Updating
        // SqlDbData.UpdateUser("kurt", "Kurt2024!");


        //for Deleting
        //SqlDbData.DeleteUser("kurt");


            // UserGetServices getServices = new UserGetServices();

            //  var users = getServices.GetUsersByStatus(1);

            //  foreach (var item in users)
            //{
            //  Console.WriteLine(item.plateNum);
            //Console.WriteLine(item.password);
            //}

        }

        public static void GetUsers()
        {
            List<User> usersFromDB = SqlDbData.GetUsers();

            foreach (var item in usersFromDB)
            {
                Console.WriteLine(item.plateNum);
                Console.WriteLine(item.colorCar);
            }
        }
    }
}