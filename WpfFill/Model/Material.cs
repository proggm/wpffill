//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfFill.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        public int ID { get; set; }
        public string NameMaterial { get; set; }
        public int IDMaterial { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Quantity1 { get; set; }
        public int Minimum { get; set; }
        public decimal cost { get; set; }
    
        public virtual IDMaterial IDMaterial1 { get; set; }
    }
}
