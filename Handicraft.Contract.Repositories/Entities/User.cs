using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Entities
{
    public class User : IdentityUser
    {
        public User()
        {

        }
        [Key]
        [StringLength(50)]
        public override string? Id { get; set; }
        [Required]
        public string? Fullname { get; set; }
        public string? Image { get; set; }
        public string? InternalCode { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }
    }
}
