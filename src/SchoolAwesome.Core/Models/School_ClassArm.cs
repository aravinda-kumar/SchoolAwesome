using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using Abp.Domain.Entities.Auditing;

namespace SchoolAwesome.Models
{
    public class School_ClassArm : FullAuditedEntity
    {
        public School_ClassArm()
        {
            // do nothing
        }

        //[ClassArmId] [int] IDENTITY(1,1) NOT NULL,
        //[ClassArmName] [varchar] (50) NOT NULL,
        [Required]
        [Display(Name = "Class Arm Name")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string ClassArmName { get; set; }
        //[ClassArmAlias] [varchar] (50) NOT NULL,
        [Required]
        [Display(Name = "Class Arm Alias")]
        [StringLength(50, ErrorMessage = "Maximum Length is 50")]
        public string ClassArmAlias { get; set; }
        //[ClassArmColor] [varchar] (50) NULL,
        [Required]
        [Display(Name = "Choose a Colour for this Class Arm")]
        public string ClassArmColour { get; set; }
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

        //[ClassId] [int] NOT NULL,
        public virtual School_Class SchoolClass { get; set; }

        //// TODO: Implement Teacher Entity so that the Teacher Navigation Property commented out below can be uncommented
        ////[TeacherId] [int] NOT NULL,
        //public virtual Teacher ClassArmTeacher { get; set; }
    }
}
