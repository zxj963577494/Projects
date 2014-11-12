using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    // 指定数据表
    [ActiveRecord("Category",Lazy=true)]
    public class Category : ActiveRecordBase<Category>
    {
        // 指定数据表中的主键
        [PrimaryKey("Id")]
        public virtual int Id { get; set; }

        // 指定数据表中的列
        [Property("Title")]
        public virtual string Title { get; set; }

        [Property("Description")]
        public virtual string Description { get; set; }

        [Property("DateAdded")]
        public virtual DateTime DateAdded { get; set; }

        [Property("Type")]
        public virtual int Type { get; set; }

        // 多对多
        // typeof(Post):对方表的实体类，Table:关联中间表，ColumnRef:关联中间表中与对方实体相关的列，ColumnKey：关联中间表中与本实体相关的列，Lazy：延迟加载，通过本实体获取对方实体信息时，才会去数据库查询
        [HasAndBelongsToMany(typeof(Post),Table = "Category_Post", ColumnRef = "Post_Id", ColumnKey = "Category_Id",Lazy=true)]
        public virtual IList<Post> Posts { get; set; }


        public static IList<Category> FindAllForTopCategory()
        {
            SimpleQuery<Category> query = new SimpleQuery<Category>(@" from Category c where c.Type=1");
            return query.Execute();
        }

        public static Category Find(int id)
        {
            return FindByPrimaryKey(id);
        }
    }

}
