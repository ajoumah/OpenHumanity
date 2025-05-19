<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchBox.ascx.cs" Inherits="Onder1.UserControls.SearchBox" %>
<asp:Panel ID="searchPanel" runat="server" DefaultButton="goButton">
<table class="SearchBox">
<tr>
<td class="SearchBoxHead">ابحث</td>
</tr>
<tr>
<td class="SearchBoxContent">
<asp:TextBox ID="searchTextBox" Runat="server" Width="128px"
MaxLength="100" />
<asp:Button ID="goButton" Runat="server"
Text="ابحث" Width="36px" onclick="goButton_Click" /><br />
<asp:CheckBox ID="allWordsCheckBox" Runat="server"
Text="البحث في كل الكلمات" />
</td>
</tr>
</table>
</asp:Panel>