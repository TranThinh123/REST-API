using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuderDinner.Application.Commom.interfaces.authentication
{
    public interface IJwtTokenGennerator
    {
        string GenerateToken(Guid userId, string firstName, string lastName);
    }
}