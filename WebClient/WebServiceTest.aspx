<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceTest.aspx.cs" Inherits="WebClient.WebServiceTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Submit" runat="server" Text="Button" OnClick="btn_Submit_Click" />
    
    </div>
    </form>
</body>
</html>
