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
    
    public partial class Knitwears_Plan_General
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Knitwears_Plan_General()
        {
            this.Knitwears_Plan_Main = new HashSet<Knitwears_Plan_Main>();
        }
    
        public int Knitwears_Plan_General_id { get; set; }
        public string Knitwears_Plan_General_Nomenclature { get; set; }
        public string Knitwears_Plan_General_Date { get; set; }
        public string Knitwears_Plan_General_Volume { get; set; }
        public string Knitwears_Plan_General_Note { get; set; }
        public string Knitwears_Plan_General_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Knitwears_Plan_Main> Knitwears_Plan_Main { get; set; }
    }
}
