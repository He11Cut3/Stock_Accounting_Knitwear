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
    
    public partial class Knitwears_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Knitwears_Product()
        {
            this.Knitwears_Main = new HashSet<Knitwears_Main>();
        }
    
        public int Knitwears_Product_id { get; set; }
        public string Knitwears_Product_Name { get; set; }
        public string Knitwears_Product_Weight { get; set; }
        public string Knitwears_Product_Sample { get; set; }
        public string Knitwears_Product_Description { get; set; }
        public string Knitwears_Product_Date { get; set; }
        public string Knitwears_Product_Status { get; set; }

        public string Name
        {
            get
            {
                return "Наименование: " + this.Knitwears_Product_Name;
            }
        }
        public string Weight
        {
            get
            {
                return "Вес (кг/л): " + this.Knitwears_Product_Weight;
            }
        }
        public string Description
        {
            get
            {
                return "Описание: " + this.Knitwears_Product_Description;
            }
        }
        public string Boxes
        {
            get
            {
                return "Эталонный образец: " + this.Knitwears_Product_Sample;
            }
        }
        public string Date
        {
            get
            {
                return "Дата выхода с карантина: " + this.Knitwears_Product_Date;
            }
        }
        public string Status
        {
            get
            {
                return "Статус: " + this.Knitwears_Product_Status;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Knitwears_Main> Knitwears_Main { get; set; }
    }
}