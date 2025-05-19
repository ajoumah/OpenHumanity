<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pager.ascx.cs" Inherits="Onder1.UserControls.Pager" %>
<p>
صفحة 
<asp:Label ID="currentPageLabel" runat="server" />
من
<asp:Label ID="howManyPagesLabel" runat="server" />
|

<asp:HyperLink ID="previousLink" Runat="server">السابق</asp:HyperLink>

<asp:Repeater ID="pagesRepeater" runat="server">
  <ItemTemplate>
    <asp:HyperLink ID="hyperlink" runat="server" Text='<%# Eval("Page")  %>' NavigateUrl='<%# Eval("Url") %>' />
  </ItemTemplate>
</asp:Repeater>

<asp:HyperLink ID="nextLink" Runat="server">التالي</asp:HyperLink>
</p>
