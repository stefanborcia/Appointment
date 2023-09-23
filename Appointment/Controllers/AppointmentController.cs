using Appointment.Services;
using Microsoft.AspNetCore.Mvc;

namespace Appointment.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult Index()
        {
            _appointmentService.GetDoctorList();
            return View();
        }
    }
}
