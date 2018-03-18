using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Abp.Domain.Entities.Auditing;

namespace SchoolAwesome.Models
{
    public class School_Class : FullAuditedEntity
    {
        public School_Class()
        {
            ClassArms = new HashSet<School_ClassArm>();
            //ClassSubjects = new HashSet<School_Subject>();
        }

        //[ClassId] [int] IDENTITY(1,1) NOT NULL,
        //[ClassName] [varchar](50) NOT NULL,
        [Required]
        [Display(Name = "Class Name")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string ClassName { get; set;  }
        //[ClassAlias] [varchar](50) NOT NULL,
        [Required]
        [Display(Name = "Class Alias")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string ClassAlias { get; set; }
        //[ListingOrder] [int] NULL,
        [Display(Name = "Listing Order")]
        public int? ListingOrder { get; set;  }
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

        // child entities (navigation properties) for the arms of this class
        public ICollection<School_ClassArm> ClassArms { get; set; }
        //public ICollection<School_Subject> ClassSubjects { get; set; }
    }
}
