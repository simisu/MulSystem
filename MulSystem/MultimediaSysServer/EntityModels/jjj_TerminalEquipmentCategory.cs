//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultimediaSysServer.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class jjj_TerminalEquipmentCategory
    {
        public jjj_TerminalEquipmentCategory()
        {
            this.jjj_TerminalEquipmentList = new HashSet<jjj_TerminalEquipmentList>();
        }
    
        public int TerminalEquipmentCategoryId { get; set; }
        public string TerminalEquipmentCategoryName { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> Layer { get; set; }
    
        public virtual ICollection<jjj_TerminalEquipmentList> jjj_TerminalEquipmentList { get; set; }
    }
}
