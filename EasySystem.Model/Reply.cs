//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasySystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reply()
        {
            this.Reply1 = new HashSet<Reply>();
        }
    
        public int id { get; set; }
        public System.DateTime time { get; set; }
        public string text { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<int> commentid { get; set; }
        public Nullable<int> toreplyid { get; set; }
    
        public virtual Comment Comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reply> Reply1 { get; set; }
        public virtual Reply Reply2 { get; set; }
        public virtual User User { get; set; }
    }
}
