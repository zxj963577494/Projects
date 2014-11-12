<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Post.aspx.cs" Inherits="Web.Post" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>响应式个人博客模板</title>
    <meta name="keywords" content="个人博客,个人博客模板,响应式,响应式博客模板" />
    <meta name="description" content="杨青个人博客，是一个站在web前端设计之路的女程序员个人网站，提供个人博客模板免费资源下载的个人原创网站。" />
    <meta name="viewport" content="width=device-width, minimum-scale=1.0, maximum-scale=1.0">
    <link href="css/base.css" rel="stylesheet">
    <!--[if lt IE 9]>
    <script src="js/modernizr.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <header>
                <h1 id="logo"><a href="Default.aspx">
                    <img src="images/logo.jpg" width="260" height="60" alt="杨青个人博客"></a></h1>
                <nav>
                    <ul>
                        <li id="active"><a href="Default.aspx">网站首页</a></li>
                        <asp:Repeater runat="server" ID="repCategoryList">
                        <ItemTemplate>
                            <li><a href="Category.aspx?id=<%#Eval("Id")%>"><%#Eval("Title")%></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                    </ul>
                </nav>
            </header>
            <div class="banner">
                <div class="headerPic"><a href="/"><span>杨青个人博客</span></a></div>
                <div class="websiteDescription">
                    <h2>渡人如渡己，渡已，亦是渡</h2>
                    <p>当我们被误解时，会花很多时间去辩白。 但没有用，没人愿意听，大家习惯按自己的所闻、理解做出判别，每个人其实都很固执。与其努力且痛苦的试图扭转别人的评判，不如默默承受，给大家多一点时间和空间去了解。而我们省下辩解的功夫，去实现自身更久远的人生价值。其实，渡人如渡己，渡已，亦是渡人。</p>
                </div>
            </div>
            <div class="mainContent">
                <h2 class="title_tj">
                    <p>文章<span>详情</span></p>
                </h2>
                <div class="bloglist">
                    <h3>
                        <asp:Literal ID="ltlTitle" Text="" runat="server" /></h3>
                    <div class="dateview">
                        <a title="/" href="/" target="_blank" class="readmore"></a><span>
                            <asp:Literal ID="ltlDate" Text="" runat="server" /></span><span>评论数：<asp:Literal ID="ltlCommentCount" Text="" runat="server" /></span><span>标签：<asp:Literal ID="ltlCategory" Text="" runat="server" /></span>
                    </div>
                    <div class="content">
                        <asp:Label ID="lblContent" Text="" runat="server" />
                    </div>
                </div>
                <hr />
                <div id="comment" class="comment">
                    <asp:Repeater runat="server" ID="repComment">
                        <ItemTemplate>
                            <div class="clearfix pinglun-box pinglun-box-set" id="g_pid477600">
                                <div class="user-img">
                                    <img src="http://tp1.sinaimg.cn/2038693451/50/0/1" width="50" height="50"></a>
                        <div class="wz-author"></div>
                                </div>
                                <div class="pinglun-box-text">
                                    <a class="name hx-card" userid="0" href="http://weibo.com/u/2038693451" target="_blank" title="<%#Eval("Author") %>"><%#Eval("Author") %></a><span class="signature" title=""></span>

                                    <div class="view-info"><%#Eval("Text") %></div>
                                </div>
                                <div class="clearfix view-func">
                                    <time class="pull-left s-time">2小时前</time>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <hr />
                <div class="comments">
                    <h3>
                        <p id="respond">发布评论</p>
                    </h3>
                </div>
                <div id="commentform" class="commentform">
                    <div class="hide-input">
                        <p>
                            <label for="author">称呼: </label>
                            <asp:TextBox runat="server" ClientIDMode="Static" ID="txtAuthor" />
                        </p>
                    </div>
                    <p>
                        <asp:TextBox runat="server" ClientIDMode="Static" ID="txtConetent" TextMode="MultiLine" Rows="10" />
                    </p>
                    <p>
                        <asp:Button Text="点击发布" runat="server" ClientIDMode="Static" ID="submit" OnClick="submit_Click" />
                        <br>
                    </p>
                </div>
            </div>
            <div class="sidebar">
                <div class="news">
                    <h3>
                        <p>最新<span>文章</span></p>
                    </h3>
                    <ul class="rank">
                        <li><a href="/" title="Column 三栏布局 个人网站模板" target="_blank">Column 三栏布局 个人网站模板</a></li>
                        <li><a href="/" title="with love for you 个人网站模板" target="_blank">with love for you 个人网站模板</a></li>
                        <li><a href="/" title="免费收录网站搜索引擎登录口大全" target="_blank">免费收录网站搜索引擎登录口大全</a></li>
                        <li><a href="/" title="做网站到底需要什么?" target="_blank">做网站到底需要什么?</a></li>
                        <li><a href="/" title="企业做网站具体流程步骤" target="_blank">企业做网站具体流程步骤</a></li>
                        <li><a href="/" title="建站流程篇——教你如何快速学会做网站" target="_blank">建站流程篇——教你如何快速学会做网站</a></li>
                        <li><a href="/" title="box-shadow 阴影右下脚折边效果" target="_blank">box-shadow 阴影右下脚折边效果</a></li>
                        <li><a href="/" title="打雷时室内、户外应该需要注意什么" target="_blank">打雷时室内、户外应该需要注意什么</a></li>
                    </ul>
                    <h3 class="ph">
                        <p>点击<span>排行</span></p>
                    </h3>
                    <ul class="paih">
                        <li><a href="/" title="Column 三栏布局 个人网站模板" target="_blank">Column 三栏布局 个人网站模板</a></li>
                        <li><a href="/" title="withlove for you 个人网站模板" target="_blank">with love for you 个人网站模板</a></li>
                        <li><a href="/" title="免费收录网站搜索引擎登录口大全" target="_blank">免费收录网站搜索引擎登录口大全</a></li>
                        <li><a href="/" title="做网站到底需要什么?" target="_blank">做网站到底需要什么?</a></li>
                        <li><a href="/" title="企业做网站具体流程步骤" target="_blank">企业做网站具体流程步骤</a></li>
                    </ul>
                    <h3 class="links">
                        <p>友情<span>链接</span></p>
                    </h3>
                    <ul class="website">
                        <li><a href="/">个人博客</a></li>
                        <li><a href="/">谢泽文个人博客</a></li>
                        <li><a href="/">3DST技术网</a></li>
                        <li><a href="/">思衡网络</a></li>
                    </ul>
                    <div class="guanzhu">扫描二维码关注<span>杨青博客</span>官方微信账号</div>
                    <a href="/" class="weixin">
                        <img src="images/weixin.jpg"></a>
                </div>
            </div>
            <div class="clearfloat"></div>
            <footer>
                <ul>
                    Designed by
                <a href="/" title="杨青个人博客">DanceSmile</a>
                </ul>
            </footer>
        </div>
    </form>
</body>
</html>
