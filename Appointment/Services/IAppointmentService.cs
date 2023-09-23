using Appointment.Models.ViewModels;

namespace Appointment.Services
{
    public interface IAppointmentService
    {
        public List<DoctorViewModel> GetDoctorList();
        public List<PatientViewModel> GetPatientList();
    }
}
