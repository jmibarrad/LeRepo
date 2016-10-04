﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BusinessLogic.IServices
{
    public interface IEmployeeTypeService
    {
        IEnumerable<EmployeeType> ListEmployeeTypes();
    }
}
