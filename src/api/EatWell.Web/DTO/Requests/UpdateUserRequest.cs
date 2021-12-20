using EatWell.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.DTO.Requests
{
    public class UpdateUserRequest
    {
        public bool Status { get; set; }
        public UpdateUserRequest()
        {
                
        }
        public UpdateUserRequest(UserModel u)
        {
            Status = u.Status;
        }
    }
}
