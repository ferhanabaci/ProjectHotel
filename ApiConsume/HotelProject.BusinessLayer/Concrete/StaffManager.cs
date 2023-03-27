using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffService _staffService;

        public StaffManager(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public void TDelete(Staff t)
        {
            _staffService.TDelete(t);
        }

        public Staff TGetByID(int id)
        {
            return _staffService.TGetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffService.TGetList();
        }

        public void TInsert(Staff t)
        {
            _staffService.TInsert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffService.TUpdate(t);
        }
    }
}
