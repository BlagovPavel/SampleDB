namespace sampledb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Works_on
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ProjectNumber { get; set; }

        [StringLength(15)]
        public string Job { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EnterDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Project Project { get; set; }
    }
}
