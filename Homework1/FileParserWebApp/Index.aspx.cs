using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Homework1;
namespace FileParserWebApp
{
    public partial class Index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.ServerVariables["REQUEST_METHOD"] == "POST")
            {
            String path = Context.Request.Form["path"];
            
            if (!string.IsNullOrEmpty(path))
            {
                Homework1.FileParser fp = new Homework1.FileParser();
                Homework1.myFile[] files = fp.getFile(path);
                this.content.InnerHtml = "";
                this.content.InnerHtml += "<p><strong><span style='float:left'>文件名</span>" + "<span style='float:center'>文件大小</span>"+"<span style='float:right'>创建时间</span></strong></p>";
                foreach (myFile f in files)
                {
                    if(f.getIsDir())
                        this.content.InnerHtml += "<p><strong><span style='float:left'><a href='#' onclick='submit("+f.getName()+")'>" + f.getName() + "</a></span>" + "<span style='float:right'>" + f.getCreateTime() + "</span></strong></p>";
                    else
                        this.content.InnerHtml += "<p><strong><span style='float:left'>" + f.getName() + "</span>" + "<span style='float:center'>"+ f.getSize() +"</span>"+ "<span style='float:right'>" + f.getCreateTime() + "</span></strong></p>";
                    this.content.InnerHtml += "<br />";
                }
            }
          
            }
        }

    }
}