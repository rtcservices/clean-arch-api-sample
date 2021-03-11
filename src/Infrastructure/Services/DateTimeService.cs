using APIService.Application.Common.Interfaces;
using System;

namespace APIService.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
