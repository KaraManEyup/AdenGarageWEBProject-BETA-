﻿public class UserWithRolesViewModel
{
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public List<string> Roles { get; set; } // Kullanıcının rolleri
}
