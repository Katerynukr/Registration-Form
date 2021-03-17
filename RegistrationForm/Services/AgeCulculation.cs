using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Services
{
    public class AgeCulculation
    {
        public int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (birthDate.Year * 100 + birthDate.Month) * 100 + birthDate.Day;

            return (a - b) / 10000;
        }
    }
}
