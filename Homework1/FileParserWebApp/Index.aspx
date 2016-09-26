<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FileParserWebApp.Index1" %>

<!DOCTYPE html>
<% 
    var filepath = "";
    if (Request.ServerVariables["REQUEST_METHOD"] == "POST")
        filepath = Context.Request.Form["path"]; 
    
%>>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>FileParser</title>

    <!-- Bootstrap -->
    <link href="css\toastr.min.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="http://cdn.bootcss.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="http://cdn.bootcss.com/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body background="Image/bg.jpg">
    <br />
    <br />
    <br />
    <div class="container">
        <div align="center">
            <h1 style="font-size: 50px"><span class="label label-default">File Management System</span></h1>
        </div>
        <br />
        <br />
        <div class="col-lg-2"></div>
        <div class="col-lg-8" align="center">
            <form method="post" id="submitform" class="input-group input-group-lg">
                <div>
                <input type="text" id="dirPath" name="path" class="form-control" placeholder="PATH" value="<%=filepath%>">
                 <br />
                    <br />
                   </div>
                <div class="radio">
                    <label>
                        <input type="radio" name="sortType" id="optionsRadios1" value="option1" checked>
                       Search by Default Sort  
                    </label>
                
                    <label>
                        <input type="radio" name="sortType" id="optionsRadios2" value="option2">
                        Search by Name Sort   
                    </label>
               
                    <label>
                        <input type="radio" name="sortType" id="optionsRadios3" value="option3">
                       Search by CreationTime Sort
                    </label>
                </div>
                <input class="btn btn-default" type="submit" value="SEARCH" />
            </form>
            <!-- /input-group -->
            <br />
            <br />
            <div class="panel panel-default">
                <div runat="server" class="panel-body" id="content">
                </div>
            </div>
        </div>
        <!-- /.col-lg-6 -->
        <div class="col-lg-2"></div>
    </div>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="http://cdn.bootcss.com/jquery/1.11.1/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="js/toastr.min.js"></script>
    <script>
        function searchSubDir(filename) {
            document.getElementById("dirPath").value += ("\\" + filename);
            document.getElementById("submitform").submit();
        }
        function refresh(filename) {
            $.ajax({
                type: "post",
                url: "index.aspx/deleteFile",
                //data: "{'filepath':'" + document.getElementById("dirPath").value+"\\"+filename + "'}",
                data: "{'filepath':'" + filepath + "'}",
                contentType: "application/json; charset=utf-8",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    if (data.d) {
                        toastr.success(filename + " has been removed into your Recycle Bin!", 1000);
                        document.getElementById("submitform").submit();
                    } else
                        toastr.error("There is an error,please check your file path.");
                },
                error: function (err) {
                    toastr.info("There is an error.The error code is " + err);
                }
            });
        }
        function deleteFile(filename) {
            toastr.options = {
                "closeButton": false,
                "debug": false,
                "positionClass": "toast-bottom-full-width",
                "showDuration": "300",
                "hideDuration": "1000",
                "timeOut": "5000",
                "extendedTimeOut": "1000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut"
            };
            filepath = document.getElementById("dirPath").value + "\\" + filename;
            filepath = filepath.replace(/\\/g, "/")
            $.ajax({
                type: "post",
                url: "index.aspx/deleteFile",
                //data: "{'filepath':'" + document.getElementById("dirPath").value+"\\"+filename + "'}",
                data: "{'filepath':'" + filepath + "'}",
                contentType: "application/json; charset=utf-8",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    if (data.d) {
                        toastr.success(filename + " has been removed into your Recycle Bin!");
                        setTimeout(function () {  //使用  setTimeout（）方法设定定时2000毫秒
                            window.location.reload();//页面刷新
                        }, 2000);
                    } else
                        toastr.error("There is an error,please check your file path.");
                },
                error: function (err) {
                    toastr.info("There is an error.The error code is " + err);
                }
            });
        }
    </script>
</body>
</html>
