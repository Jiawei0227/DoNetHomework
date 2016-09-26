using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
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
                Homework1.myFile[] files = null;
                switch (Context.Request.Form["sortType"].ToString())
                {
                    case "option1":
                        files = fp.getFile(path);
                        break;
                    case "option2":
                        files = fp.getFilebyName(path);
                        break;
                    case "option3":
                        files = fp.getFilebyCreationtime(path);
                        break;
                }
                
                this.content.InnerHtml = "";
                this.content.InnerHtml += "<p><strong><span style='float:left'>FILENAME</span>" + "<span style='float:center'>SIZE</span>"+"<span style='float:right'>CREATION TIME  DELETE</span></strong></p>";
                foreach (myFile f in files)
                {
                    if(f.getIsDir())
                        this.content.InnerHtml += "<p><strong><span style='float:left'><a href='javascript:searchSubDir(\"" + f.getName() + "\")';>" + f.getName() + "</a></span>" + "<span style='float:right'>" + f.getCreateTime() + "</span></strong></p>";
                    else
                        this.content.InnerHtml += "<p><strong><span style='float:left'>" + f.getName() + "</span>" + "<span style='float:center'>" + f.getSize() + "</span>" + "<span style='float:right'>" + f.getCreateTime() + "<a href='javascript:deleteFile(\"" + f.getName() + "\")'; style='color:red';>DELETE</a></span></strong></p>";
                    this.content.InnerHtml += "<br />";
                }
            }


            }
            else
            {
                this.content.InnerHtml = "<p><strong>Please enter the file path.</strong></p>";
            }
        }
        [WebMethod]
        public static bool deleteFile(String filepath)
        {
            Homework1.FileParser fp = new Homework1.FileParser();

            return fp.deleteFile(filepath); ;
        }
       
    }
}