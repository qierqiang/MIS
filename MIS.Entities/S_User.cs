//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MIS.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_User : MarshalByRefObject, MIS.Core.ViewModels.IModel
    {
        public int FID { get; set; }
        public string FFullName { get; set; }
        public string FUserName { get; set; }
        public string FPassword { get; set; }
        public Nullable<bool> FDisabled { get; set; }
        public Nullable<int> FRoleID { get; set; }
        public Nullable<int> FDepartmentID { get; set; }
    }
}
