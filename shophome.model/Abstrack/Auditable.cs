using System;
using System.ComponentModel.DataAnnotations;

namespace shophome.model.Abstrack
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreadatedDate { set; get; }

        [MaxLength(256)]
        public string CreadatedBy { set; get; }

        public DateTime? UpdatedData { set; get; }

        [MaxLength(256)]
        public string Updatedby { set; get; }

        [MaxLength(256)]
        public string MataKeyword { set; get; }

        [MaxLength(256)]
        public string MataDescription { set; get; }

        public bool Status { set; get; }
    }
}