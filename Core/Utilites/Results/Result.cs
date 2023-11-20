using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Results
{
    public class Result : IResult
    {
        //getter is readonly but it can be set in constructor
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
