using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuderDinner.Application.Commom.interfaces.Services
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}