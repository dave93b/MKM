//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RiskSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubLevel
    {
        public SubLevel()
        {
            this.Elements = new HashSet<Element>();
        }
    
        public int SubLevelId { get; set; }
        public int LevelId { get; set; }
        public string SubLevelName { get; set; }
    
        public virtual ICollection<Element> Elements { get; set; }
        public virtual MainLevel MainLevel { get; set; }
    }
}
