//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _20._11WPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelComment
    {
        public int Id { get; set; }
        public Nullable<int> HotelId { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
