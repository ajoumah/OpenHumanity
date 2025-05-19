<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Onder1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div>
                        last update :<%=DateTime.Now.ToLongTimeString() %>
                    </div>
                    <div>
                        <asp:Button ID="Button1" runat="server" Text="Update" />
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Text="we are here "></asp:TextBox>
        </div>
    </form>
</body>
</html>
