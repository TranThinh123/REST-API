using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuderDinner.Application.Commom.interfaces.Services;

namespace BuderDinner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
