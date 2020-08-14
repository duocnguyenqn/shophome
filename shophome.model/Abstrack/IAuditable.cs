using System;

namespace shophome.model.Abstrack
{
    public interface IAuditable
    {
        DateTime? CreadatedDate { set; get; }
        string CreadatedBy { set; get; }
        DateTime? UpdatedData { set; get; }
        string Updatedby { set; get; }
        string MataKeyword { set; get; }
        string MataDescription { set; get; }
        bool Status { set; get; }
    }
}