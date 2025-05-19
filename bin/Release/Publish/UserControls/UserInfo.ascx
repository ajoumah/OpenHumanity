<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.ascx.cs" Inherits="Onder1.UserControls.UserInfo" %>
<table cellspacing="0" border="0" width="200px">
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            <tr>
                <td class="UserInfoHead" style="direction:rtl">أهلا وسهلا!</td>
            </tr>
            <tr>
                <td class="UserInfoContent" style="direction:rtl">أنت غير مسجل.
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                </td>
            </tr>
        </AnonymousTemplate>
        <LoggedInTemplate>
            <tr>
                <td class="UserInfoHead">
                     <asp:LoginName ID="LoginName2" runat="Server"></asp:LoginName>
                </td>
            </tr>
            <tr>
                <td class="UserInfoContent">
                   

                    <br />
                    <i class="fa fa-sign-out">
                    <asp:LoginStatus ID="LoginStatus2" runat="server" onloggedout="SignOut" />
                    </i>
                </td>
            </tr>
            
            
        </LoggedInTemplate>
        <RoleGroups>
            <asp:RoleGroup Roles="Editor">
                <ContentTemplate>
                    <tr>
                        <td class="UserInfoHead">
                            <asp:LoginName ID="LoginName2" runat="server" FormatString=" <b>{0}</b>!" />
                        </td>
                    </tr>
                    <tr>
                        <td class="UserInfoContent">
                            <asp:LoginStatus ID="LoginStatus2" runat="server"  onloggedout="SignOut"/>
                            <br />
                            <a href="/">OnderShop</a>
                            <br />
                            <a href="AddSingleNewsAdmin.aspx">اضافة خبر</a>
                        </td>
                    </tr>
                </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="Admin">
                <ContentTemplate>
                    <tr>
                        <td class="UserInfoHead">
                            <asp:LoginName ID="LoginName2" runat="server" FormatString=" <b>{0}</b>!" />
                        </td>
                    </tr>
                    <tr>
                        <td class="UserInfoContent">
                            <asp:LoginStatus ID="LoginStatus2" runat="server"  onloggedout="SignOut"/>
                            <br />
                            <a href="/">OnderShop</a>
                            <br />
                            <a href="AddSingleProjectAdmin.aspx">اضافة مشروع</a>
                        </td>
                    </tr>
                </ContentTemplate>
            </asp:RoleGroup>
        </RoleGroups>
    </asp:LoginView>
</table>
