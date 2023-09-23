using Appointment.Models;
using Appointment.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Appointment.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<DoctorViewModel> GetDoctorList()
        {
           // retrieve all the users which are doctors from DoctorViewModel
           var doctors = (from user in _db.Users
               join userRoles in _db.UserRoles on user.Id equals userRoles.UserId
               join roles in _db.Roles.Where(d => d.Name == Helper.Helper.Doctor) on userRoles.RoleId equals roles.Id
                          select new DoctorViewModel
                          {
                              Id = user.Id,
                              Name = user.Name,
                          }).ToList();
           return doctors;
        }

        public List<PatientViewModel> GetPatientList()
        {
            throw new NotImplementedException();
        }
    }
}
