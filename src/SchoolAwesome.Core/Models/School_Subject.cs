using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace SchoolAwesome.Models
{
    public class School_Subject : FullAuditedEntity
    {
        public School_Subject()
        {
            SubjectClasses = new HashSet<School_Class>();
        }
        //[SubjectId] [int] IDENTITY(1,1) NOT NULL,
        //[SubjectName] [nvarchar] (50) NOT NULL,
        [Required]
        [Display(Name = "Subject Name")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string SubjectName { get; set; }
        //[ShortName] [nvarchar] (50) NOT NULL
        [Required]
        [Display(Name = "Subject Alias")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string SubjectAlias { get; set; }
        //[Remarks] [varchar](50) NULL,
        [Display(Name = "Expansion Tag 1")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string ExpansionTag1 { get; set; }
        //[Remark2] [varchar](50) NULL,
        [Display(Name = "Expansion Tag 2")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string ExpansionTag2 { get; set; }
        //[Remark3] [varchar](50) NULL
        [Display(Name = "Expansion Tag 3")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string ExpansionTag3 { get; set; }

        // child entities (navigation properties) for the classes that offer this subject
        public ICollection<School_Class> SubjectClasses { get; set; }
    }
}
