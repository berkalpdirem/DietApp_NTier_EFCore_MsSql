﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.BL.Services
{
    public interface IUserFoodService
    {
        List<string> GetUserFoods(int id);
    }
}
