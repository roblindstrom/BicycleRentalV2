using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Domain.Contracts.Testing
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }
    }
}
