//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Knitwear
{
    using System;
    using System.Collections.Generic;
    
    public partial class Knitwears_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Knitwears_Order()
        {
            this.Knitwears_Main = new HashSet<Knitwears_Main>();
        }
    
        public int Knitwears_Order_id { get; set; }
        public string Knitwears_Order_Name { get; set; }
        public string Knitwears_Order_Vendor_Code { get; set; }
        public string Knitwears_Order_Weight { get; set; }
        public string Knitwears_Order_Number_Boxes { get; set; }
        public string Knitwears_Order_Date { get; set; }
        public string Knitwears_Order_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Knitwears_Main> Knitwears_Main { get; set; }
    }
}
