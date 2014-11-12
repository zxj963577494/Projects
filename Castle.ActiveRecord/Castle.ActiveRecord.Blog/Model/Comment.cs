using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    // 指定数据表
    [ActiveRecord("Comment",Lazy=true)]
    public class Comment : ActiveRecordBase<Comment>
    {
        // 指定数据表中的主键
        [PrimaryKey("Id")]
        public virtual int Id { get; set; }

        // 指定数据表中的列
        [Property("Author")]
        public virtual string Author { get; set; }

        [Property("Text")]
        public virtual string Text { get; set; }

        [Property("DateAdded")]
        public virtual DateTime DateAdded { get; set; }

        // 多对一，对应Post的的Comments属性
        [BelongsTo(Column = "PostId")]
        public virtual Post Post { get; set; }
    }
}
