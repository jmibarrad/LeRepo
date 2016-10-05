using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.IServices;
using DAL.Entities;
using DAL.Repository;

namespace BusinessLogic.Services
{
    public class EmployeeTypeService : IEmployeeTypeService
    {
        private readonly IRepository<EmployeeType> _employeeTypeRepository;
        public EmployeeTypeService(IRepository<EmployeeType> employeeTypeRepository)
        {
            _employeeTypeRepository = employeeTypeRepository;
        }

        public IEnumerable<EmployeeType> ListEmployeeTypes()
        {
            return _employeeTypeRepository.Get();
        }
    }
}
