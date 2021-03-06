﻿using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Category : System.Web.UI.Page
    {
        public String PostContent = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTopCategory();
                LoadCategoryAndPost();
            }
        }


        private void LoadTopCategory()
        {
            repCategoryList.DataSource  = Model.Category.FindAllForTopCategory();
            repCategoryList.DataBind();
        }

        private void LoadCategoryAndPost()
        {
            int id =int.Parse(Request.QueryString["id"]);
            StringBuilder sb = new StringBuilder();
            using (new SessionScope())
            {
                Model.Category category = Model.Category.Find(id);
                IList<Model.Post> PostListForIndex = category.Posts;
                foreach (Model.Post post in PostListForIndex)
                {
                    sb.Append("<h3><a href=\"Post.aspx?id=" + post.Id + "\">" + post.Subject + "</a></h3>");
                    sb.Append("<figure><img src=\"images/ex03.png\"></figure>");
                    sb.Append("<ul><p><a href=\"Post.aspx?id=" + post.Id + "\">" + post.Text + "</a></p></ul>");
                    sb.Append("<div class=\"dateview\"><a title=\"/\" href=\"/\" target=\"_blank\" class=\"readmore\">阅读全文>></a><span>" + post.DateAdded.ToString("yyy-MM-dd") + "</span>");
                    sb.Append("<span><a href=\"Post.aspx?id=" + post.Id + "#Comment\">评论数：" + post.Comments.Count() + "</a></span>");
                    sb.Append("<span>标签：");
                    post.Categorys.ForEach(c => sb.Append("[<a href=\"Category.aspx?id=" + c.Id + "\">" + c.Title + "</a>]"));
                    sb.Append("</span></div>");
                }
                PostContent = sb.ToString();
            }
        }
    }
}