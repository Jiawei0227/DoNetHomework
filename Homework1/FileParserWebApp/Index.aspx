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
            <h1 style="font-size:50px"><span class="label label-default">FileParser</span></h1>
        </div>
        <br />
        <br />
        <div class="col-lg-2"></div>
        <div class="col-lg-8" align="center">
            <form method="post" class="input-group input-group-lg">
                <input type="text" name="path" class="form-control" placeholder="PATH" value="<%=filepath%>">
                <span class="input-group-btn">
                    <input class="btn btn-default" type="submit" value="SEARCH" />
                </span>
            </form><!-- /input-group -->
            <br />
            <br />
            <div class="panel panel-default">
                <div runat="server" class="panel-body" id="content">
                    
                </div>
               </div>
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-2"></div>
    </div>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="http://cdn.bootcss.com/jquery/1.11.1/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script>
    
    </script>
</body>
</html>
