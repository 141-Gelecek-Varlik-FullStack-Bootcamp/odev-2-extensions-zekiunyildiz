using TwoWeek.Enums;
using System;

namespace TwoWeek.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | 
        AttributeTargets.Constructor | 
        AttributeTargets.Method, AllowMultiple = true)]
    public class RoleAccessAttribute : Attribute
    {
        public UserRole UserRole { get; set; }

        public RoleAccessAttribute(UserRole role)
        {
            UserRole = role;
        }

    }
}