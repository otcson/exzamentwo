//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exzamentwo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public int Provider { get; set; }
        public string Price { get; set; }
        public int UnitMeas { get; set; }
    
        public virtual Providers Providers { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
