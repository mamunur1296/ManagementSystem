﻿using MediatR;
using Project.Application.Models;

namespace Project.Application.Features.UserFeatures.Commands
{
    public class CreateUserCommand : IRequest<UserModels>
    {

        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public string DeactiveBy { get; set; }
        public string TIN { get; set; }
        public bool? IsBlocked { get; set; }
    }
}
