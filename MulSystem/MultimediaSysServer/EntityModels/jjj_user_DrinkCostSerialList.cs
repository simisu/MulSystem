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
    
    public partial class jjj_user_DrinkCostSerialList
    {
        public int ID { get; set; }
        public string SerialNumber { get; set; }
        public string IcCardNo { get; set; }
        public Nullable<System.DateTime> CostTime { get; set; }
        public string DeviceCode { get; set; }
        public Nullable<decimal> CostFee { get; set; }
        public Nullable<decimal> RunningWaterLitre { get; set; }
        public Nullable<decimal> CurrentUserBalance { get; set; }
    }
}
