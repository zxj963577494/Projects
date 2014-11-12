using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    // 指定数据表
    [ActiveRecord("Post",Lazy=true)]
    public class Post : ActiveRecordBase<Post>
    {
        // 指定数据表中的主键
        [PrimaryKey(PrimaryKeyType.Identity, "Id")]
        public virtual int Id { get; set; }

        // 指定数据表中的列
        [Property("Subject")]
        public virtual string Subject { get; set; }

        [Property("Text")]
        public virtual string Text
        {
            get;
            set;
        }

        [Property("DateAdded")]
        public virtual DateTime DateAdded { get; set; }

        // 一对多
        // typeof(Comment)：对方的实体类，Table：对方表名，ColumnKey：对方表的外键，Lazy：延迟加载
        [HasMany(typeof(Comment), Table = "Comment", ColumnKey = "PostId",Lazy=true)]
        public virtual IList<Comment> Comments { get; set; }

        // 多对多
        [HasAndBelongsToMany(typeof(Category),Table="Category_Post",ColumnRef="Category_Id",ColumnKey="Post_Id",Lazy=true)]
        public virtual IList<Category> Categorys { get; set; }

        public static Post Find(int id)
        {
            return FindByPrimaryKey(id);
        }
    }
}
