namespace CleanArchitecture.TaskManager.Application.DTOs
{
    public class UserDTO
    {
        public string Name { get;  set; }

        public string Email { get;  set; }

        public string Password { get;  set; }

        public UserType Role { get;  set; }
    }

    public enum UserType
    {
        Admin,
        Manager,
        TeamMember
    }
}
