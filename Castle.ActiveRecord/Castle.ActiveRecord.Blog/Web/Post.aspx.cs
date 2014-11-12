using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTopCategory();
                ShowPostAndComment();
            }
        }

        private void LoadTopCategory()
        {
            repCategoryList.DataSource = Model.Category.FindAllForTopCategory();
            repCategoryList.DataBind();
        }

        private void ShowPostAndComment()
        {
            int id = int.Parse(Request.QueryString["id"]);
            using (new SessionScope())
            {
                Model.Post post = Model.Post.Find(id);
                ltlTitle.Text = post.Subject;
                lblContent.Text = post.Text;
                ltlDate.Text = post.DateAdded.ToString("yyyy-MM-dd");
                ltlCommentCount.Text = post.Comments.Count.ToString();
                StringBuilder sb = new StringBuilder();
                post.Categorys.ForEach(category => sb.Append("[<a href=\"Category.aspx?id=" + category.Id + "\">" + category.Title + "</a>]"));
                ltlCategory.Text = sb.ToString();

                repComment.DataSource = post.Comments;
                repComment.DataBind();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Model.Post post = Model.Post.Find(id);
            Model.Comment comment = new Model.Comment()
            {
                Author = txtAuthor.Text.Trim(),
                Text = txtConetent.Text.Trim(),
                DateAdded = DateTime.Now,               
            };
            comment.Post = post;
            comment.Create();
            Response.Redirect(Request.Url.PathAndQuery);
        }
    }
}