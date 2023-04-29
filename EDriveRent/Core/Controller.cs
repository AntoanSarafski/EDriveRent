using EDriveRent.Models.Contracts;
using EDriveRent.Models;
using EDriveRent.Repositories.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDriveRent.Core.Contracts;

namespace EDriveRent.Core
{
    public class Controller : IController
    {

        private readonly IRepository<IUser> users;
        private readonly IRepository<IVehicle> vehicles;
        private readonly IRepository<IRoute> routes;

        public Controller()
        {
            users = new UserRepository();
            vehicles = new VehicleRepository();
            routes = new RouteRepository();
        }



        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            if (users.FindById(drivingLicenseNumber) != null)
            {
                return string.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);
            }
            IUser user = new User(firstName, lastName, drivingLicenseNumber);

            users.AddModel(user);

            return string.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName, drivingLicenseNumber);
        }


        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            throw new NotImplementedException();
        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            throw new NotImplementedException();
        }


        public string RepairVehicles(int count)
        {
            throw new NotImplementedException();
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            throw new NotImplementedException();
        }

        public string UsersReport()
        {
            throw new NotImplementedException();
        }
    }
}
