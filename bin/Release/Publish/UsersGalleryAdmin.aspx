<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="UsersGalleryAdmin.aspx.cs" Inherits="Onder1.UsersGalleryAdmin" EnableViewState="false"  Theme="OnderShopDefault"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="App_Themes/OnderShop.css" >
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p class="p-5 text-center col-12 align-content-end  text-right font-style-motto" >
        
        <asp:Label ID="statusLabel" ForeColor="Red" Font-Size="20" BackColor="Yellow" class="w-100" runat="server" Text=""></asp:Label>
    </p>
   
    
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" style="overflow: auto;height: 600px; " class="p-5" >
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:GridView ID="grid" runat="server" AutoGenerateColumns="true" DataKeyNames="Id" dir="rtl" AllowPaging="true" OnPageIndexChanging="grid_PageIndexChanging"
            OnRowDeleting="grid_RowDeleting" >
             <Columns>
                 <asp:TemplateField HeaderText="اسم المستخدم">
                
                <EditItemTemplate>
                    <asp:TextBox ID="UserNameTextBox" runat="server"
                        Text='<%# Bind("UserName") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="الايميل">
                
                <EditItemTemplate>
                    <asp:TextBox ID="EmailTextBox" runat="server"
                        Text='<%# Bind("Email") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 
          <asp:HyperLinkField DataNavigateUrlFields="Id"
                DataNavigateUrlFormatString="UserAdmin.aspx?Id={0}"
                HeaderText="تعديل المستخدم" Text="تعديل" />
      
            <asp:TemplateField HeaderText="حذف المستخدم">
                <ItemTemplate>
                    <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/images/cross.png"
                        CommandName="Delete" OnClientClick="return confirm('هل تريد المستخدم؟');"
                        AlternateText="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
             
                 </Columns>
        </asp:GridView>
    
             
       </asp:Panel>
</asp:Content>
