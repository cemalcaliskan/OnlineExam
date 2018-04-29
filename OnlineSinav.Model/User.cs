using OnlineSinav.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSinav.Model
{
    public class User : IEntity
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserRoleID { get; set; }
        public bool IsActive { get; set; }
        public Guid ActivationCode { get; set; }

        public virtual UserRole UserRole { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        public ICollection<UserExam> UserExams { get; set; }
    }
}
