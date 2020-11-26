﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class Dao
    {
        public static CarDao Car = new CarDao();

        public static CarTypeDao CarType = new CarTypeDao();

        //public static RentDao Rent = new RentDao();

        public static UserDao User = new UserDao();

        //public static AdminDao Admin = new AdminDao();
    }
}
