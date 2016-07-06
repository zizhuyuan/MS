<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WcfTest.aspx.cs" Inherits="WebClient.WcfTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="测试WCF服务" OnClick="btnSubmit_Click" />
    
    </div>
    </form>
</body>
</html>
