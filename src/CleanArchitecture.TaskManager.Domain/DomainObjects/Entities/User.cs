using CleanArchitecture.TaskManager.Common.Utils.Validators;
using CleanArchitecture.TaskManager.Domain.DomainObjects.Entities;
using CleanArchitecture.TaskManager.Domain.DomainObjects.Enums;
using CleanArchitecture.TaskManager.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Domain.Entities
{
    public class User : Entity
    {

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public UserType Role { get; private set; }


        public User(string name, UserType role)
        {
            Name = name;
            Role = role;
        }

        protected override void Validate()
        {
            ObjectValidator<User>.CreateValidator()
                .RuleFor<DomainException>(this, x => !string.IsNullOrEmpty(x.Name), "Name can't be empty")
                .Validate();

        }

        public void SetPassword(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).{8,}$");
            if (!regex.IsMatch(password))
                throw new DomainException("Password is not strong enough!");

            Password = password;
        }

        public void BlurPassword()
        {
            this.Password = "*********";
        }

        public void SetEmail(string email)
        {
            var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!regex.IsMatch(email))
                throw new DomainException("Email is invalid!");
            Email = email;
        }


        public bool IsActive => !this.DeletedAt.HasValue;
        public void InactivateUser()
        {
            this.DeletedAt = DateTime.Now;
        }


        public bool IsManager => this.Role == UserType.Manager;
        public bool IsAdmin => this.Role == UserType.Admin;
        public bool IsTeamMeber => this.Role == UserType.TeamMember;


    }
}
