<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="NewsAdmin.aspx.cs" Inherits="Onder1.NewsAdmin" EnableViewState="false"  Theme="OnderShopDefault"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="App_Themes/OnderShop.css" >
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="p-5" >
    <p class="p-5 text-center col-12 align-content-end  text-right font-style-motto" >
        
        <asp:Label ID="statusLabel" ForeColor="Red" Font-Size="20" BackColor="Yellow" class="w-100" runat="server" Text=""></asp:Label>
    </p>
    <%--<div id="grdCharges" runat="server" style=" overflow-x: auto; ">--%>
    
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" style="overflow: auto;height: 600px; " class="p-5" >
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <%-- <div style="width:100%;  overflow:scroll;" class="p-5" >--%>
    <%--<div style="overflow:visible;scrollbar-3dlight-color:blue">--%>
    <asp:GridView ID="grid" runat="server" DataKeyNames="NewsID" Width="100%" dir="rtl" AllowPaging="true" OnPageIndexChanging="grid_PageIndexChanging"
        AutoGenerateColumns="False" 
         
        OnRowDeleting="grid_RowDeleting">
        <HeaderStyle CssClass="GridHeader" />
        <RowStyle CssClass="GridRow" />
        <AlternatingRowStyle CssClass="GridAlternateRow" />
        <SelectedRowStyle CssClass="GridSelectedRow" />
        <Columns>
            <asp:TemplateField HeaderText="رقم المشروع"
                SortExpression="Project">
                <EditItemTemplate>
                    <asp:TextBox ID="ProjectIDTextBox" runat="server"
                        Text='<%# Bind("ProjectID") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProjectID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="عنوان الخبر"
                SortExpression="Title">
                <EditItemTemplate>
                    <asp:TextBox ID="TitleTextBox" runat="server"
                        Text='<%# Bind("Title") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="التفاصيل"
                SortExpression="Details">
                <EditItemTemplate>
                    <asp:TextBox ID="DetailsTextBox" runat="server"
                        Text='<%# Bind("Details") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Details") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="التاريخ"
                SortExpression="Date">
                <EditItemTemplate>
                    <asp:TextBox ID="DateTextBox" runat="server"
                        Text='<%# Bind("Date") %>' Height="70px" TextMode="MultiLine"  DataFormatString = "{0:dd/MM/yyyy}"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <%--<asp:Label ID="Label4" runat="server" DataFormatString = "{0:dd/MM/yyyy}" style="direction:rtl" Text='<%# Bind("Date") %>'></asp:Label>--%>
                 <asp:Label ID="Label4" runat="server"   Text=' <%# Convert.ToDateTime(Eval("Date")).ToString("yyyy/MM/dd") %>'></asp:Label>
                    
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="الصورة"
                SortExpression="Image">
                <EditItemTemplate>
                    <asp:Image ImageUrl='<%#Bind("NewsImage")%>' runat="server" ID="ImageNewsEdit" height="200" style="border-radius: 14px;"/>
                    <asp:FileUpload ID="fileupload" runat="server" />
                   
                </EditItemTemplate>
                <ItemTemplate>
                    <%--<asp:Label ID="Label4" runat="server" Text='<%# Bind("Date") %>'></asp:Label>--%>
                    <asp:Image ImageUrl='<%#Bind("NewsImage")%>' runat="server" ID="ImageNews" height="200" style="border-radius: 14px;"/>
                </ItemTemplate>
            </asp:TemplateField>

            
            <asp:HyperLinkField DataNavigateUrlFields="NewsID"
                DataNavigateUrlFormatString="News.aspx?NewsID={0}"
                HeaderText="رابط الخبر" Text="الرابط" />
            <asp:HyperLinkField DataNavigateUrlFields="NewsID"
                DataNavigateUrlFormatString="SingleNewsAdmin.aspx?NewsID={0}"
                HeaderText="تعديل الخبر" Text="تعديل" />
      <%--<asp:ButtonField CommandName="Delete" Text="حذف" HeaderText="حذف الخبر"  />--%>
            <asp:TemplateField HeaderText="حذف الخبر">
                <ItemTemplate>
                    <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/images/cross.png"
                        CommandName="Delete" OnClientClick="return confirm('هل تريد حذف الخبر?');"
                        AlternateText="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
             
       </asp:Panel>
       
    <%-- </div>--%>
    <%--<p>Create a new department:</p>
    <p>Name:</p>
    <asp:TextBox ID="newName" runat="server" Width="400px" />
    <p>Description:</p>
    <asp:TextBox ID="newDescription" runat="server" Width="400px" Height="70px" TextMode="MultiLine" />
    <p>
        <asp:Button ID="createDepartment" Text="Create Department" runat="server"
            OnClick="createDepartment_Click" />
    </p>--%>
  
    
</asp:Content>
