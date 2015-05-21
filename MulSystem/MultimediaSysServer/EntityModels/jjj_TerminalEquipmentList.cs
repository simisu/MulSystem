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
    
    public partial class jjj_TerminalEquipmentList
    {
        public jjj_TerminalEquipmentList()
        {
            this.jjj_TerminalEquipmentSerialCommand = new HashSet<jjj_TerminalEquipmentSerialCommand>();
            this.jjj_ProgramSendSerialList = new HashSet<jjj_ProgramSendSerialList>();
        }
    
        public int TerminalEquipmentID { get; set; }
        public string SessionId { get; set; }
        public Nullable<int> CurrentUserId { get; set; }
        public int TerminalEquipmentCategoryId { get; set; }
        public Nullable<int> TerminalStatus { get; set; }
        public string TerminalVersion { get; set; }
        public Nullable<int> IsRegister { get; set; }
        public string TerminalIP { get; set; }
        public string TerminalPlatform { get; set; }
        public string DeviceCode { get; set; }
        public string TerminalName { get; set; }
        public Nullable<int> Layer { get; set; }
        public Nullable<int> AdvanceDownNum { get; set; }
        public string MainServerIP { get; set; }
        public string MainServerPort { get; set; }
        public Nullable<System.TimeSpan> DownloadStartTime { get; set; }
        public Nullable<System.TimeSpan> DownloadEndTime { get; set; }
        public string addressProvinceCode { get; set; }
        public string addressCityCode { get; set; }
        public string addressAreaCode { get; set; }
        public string addressDetail { get; set; }
        public string JingDu { get; set; }
        public string WeiDu { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> IsSend { get; set; }
    
        public virtual jjj_TerminalEquipmentCategory jjj_TerminalEquipmentCategory { get; set; }
        public virtual jjj_users jjj_users { get; set; }
        public virtual ICollection<jjj_TerminalEquipmentSerialCommand> jjj_TerminalEquipmentSerialCommand { get; set; }
        public virtual ICollection<jjj_ProgramSendSerialList> jjj_ProgramSendSerialList { get; set; }
    }
}
