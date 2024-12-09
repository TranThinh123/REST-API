using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuderDinner.Domain.Entities;

namespace BuderDinner.Application.Commom.interfaces.authentication
{
    public interface IJwtTokenGennerator
    {
        public string GenerateToken(User user);
    }
}