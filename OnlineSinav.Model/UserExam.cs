using OnlineSinav.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSinav.Model
{
    public class UserExam : IEntity
    {
        public int UserID { get; set; }
        public int ExamID { get; set; }

        [Range(0, 100)]
        public int Score { get; set; }
        public int Duration { get; set; }
        public bool IsActive { get; set; }

        public virtual User User { get; set; }
        public virtual Exam Exam { get; set; }

    }
}
