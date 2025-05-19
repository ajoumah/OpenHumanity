<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="VideoGalleryAdmin.aspx.cs" Inherits="Onder1.VideoGalleryAdmin" EnableViewState="false"  Theme="OnderShopDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="App_Themes/OnderShop.css" >
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p class="p-5 text-center col-12 align-content-end  text-right font-style-motto" >
        
        <asp:Label ID="statusLabel" ForeColor="Red" Font-Size="20" BackColor="Yellow" class="w-100" runat="server" Text=""></asp:Label>
    </p>
   
    
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" style="overflow: auto;height: 600px; " class="p-5" >
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:GridView ID="grid" runat="server" AutoGenerateColumns="true" DataKeyNames="VideoID" dir="rtl" AllowPaging="true" OnPageIndexChanging="grid_PageIndexChanging"
            OnRowDeleting="grid_RowDeleting" >
             <Columns>
                 <asp:TemplateField HeaderText="رقم الفيديو">
                
                <EditItemTemplate>
                    <asp:TextBox ID="VideoIDTextBox" runat="server"
                        Text='<%# Bind("VideoID") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="VideoIDLabel" runat="server" Text='<%# Eval("VideoID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="رقم المشروع">
                
                <EditItemTemplate>
                    <asp:TextBox ID="ProjectIDTextBox" runat="server"
                        Text='<%# Bind("ProjectID") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="ProjectIDLabel" runat="server" Text='<%# Eval("ProjectID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="اسم المشروع"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="ProjectTitleTextBox" runat="server"
                        Text='<%# Eval("BelongsTo") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="BelongsToLabel" runat="server" Text='<%# Eval("BelongsTo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="عنوان الفيديو"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="TitleTextBox" runat="server"
                        Text='<%# Eval("Title") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="التاريخ"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="DateTextBox" runat="server"
                        Text='<%# Eval("Date") %>' Height="70px" TextMode="MultiLine"  DataFormatString = "{0:dd/MM/yyyy}"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    
                 <asp:Label ID="Label4" runat="server"   Text=' <%# Convert.ToDateTime(Eval("Date")).ToString("yyyy/MM/dd") %>'></asp:Label>
                    
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="الفيديو">
                
                <EditItemTemplate>
                    <%--<asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="ImageNewsEdit" height="200" style="border-radius: 14px;"/>--%>
                   <%--<asp:Image ImageUrl='<%#Bind("SectorImage")%>' runat="server" ID="ImageNewsEdit" height="200" style="border-radius: 14px;"/>--%>
                   <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server"  height="200"  style="border-radius: 14px;" allowfullscreen></iframe> 
                   
                </EditItemTemplate>
                <ItemTemplate>
                    <%--<asp:Image ImageUrl='<%#Bind("SectorImage")%>' runat="server" ID="ImageNews" height="200" style="border-radius: 14px;"/>--%>
                    <%--<asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="ImageNews" height="200" style="border-radius: 14px;"/>--%>
                    <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server"  height="200"  style="border-radius: 14px;" allowfullscreen></iframe> 
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:HyperLinkField DataNavigateUrlFields="VideoID"
                DataNavigateUrlFormatString="SingleVideoShow.aspx?VideoID={0}"
                HeaderText="رابط الفيديو" Text="الرابط" />
          <asp:HyperLinkField DataNavigateUrlFields="VideoID"
                DataNavigateUrlFormatString="SingleVideoAdmin.aspx?VideoID={0}"
                HeaderText="تعديل الفيديو" Text="تعديل" />
      
            <asp:TemplateField HeaderText="حذف الفيديو">
                <ItemTemplate>
                    <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/images/cross.png"
                        CommandName="Delete" OnClientClick="return confirm('هل تريد حذف الفيديو?');"
                        AlternateText="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
                 </Columns>
        </asp:GridView>
    <%--<asp:GridView ID="grid" runat="server" DataKeyNames="ImageID" Width="100%" dir="rtl"
        AutoGenerateColumns="False" 
         
       >
        <HeaderStyle CssClass="GridHeader" />
        <RowStyle CssClass="GridRow" />
        <AlternatingRowStyle CssClass="GridAlternateRow" />
        <SelectedRowStyle CssClass="GridSelectedRow" />
        <Columns>
            <asp:TemplateField HeaderText="رقم المشروع"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="ProjectIDTextBox" runat="server"
                        Text='<%# Bind("ProjectID") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProjectID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="اسم المشروع"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="ProjectTitleTextBox" runat="server"
                        Text='<%# Eval("BelongsTo") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("BelongsTo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="عنوان الصورة"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="TitleTextBox" runat="server"
                        Text='<%# Eval("Title") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="التاريخ"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="DateTextBox" runat="server"
                        Text='<%# Eval("Date") %>' Height="70px" TextMode="MultiLine"  DataFormatString = "{0:dd/MM/yyyy}"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    
                 <asp:Label ID="Label4" runat="server"   Text=' <%# Convert.ToDateTime(Eval("Date")).ToString("yyyy/MM/dd") %>'></asp:Label>
                    
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="الصورة"
                >
                <EditItemTemplate>
                    <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="ImageNewsEdit" height="200" style="border-radius: 14px;"/>
                    <asp:FileUpload ID="fileupload" runat="server" />
                   
                </EditItemTemplate>
                <ItemTemplate>
                    
                    <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="ImageNews" height="200" style="border-radius: 14px;"/>
                </ItemTemplate>
            </asp:TemplateField>

            
            <%--<asp:HyperLinkField DataNavigateUrlFields="NewsID"
                DataNavigateUrlFormatString="News.aspx?NewsID={0}"
                HeaderText="رابط الخبر" Text="الرابط" />--%>
           <%-- <asp:HyperLinkField DataNavigateUrlFields="ImageID"
                DataNavigateUrlFormatString="SingleNewsAdmin.aspx?ImageID={0}"
                HeaderText="تعديل الخبر" Text="تعديل" />
      
            <asp:TemplateField HeaderText="حذف الخبر">
                <ItemTemplate>
                    <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/images/cross.png"
                        CommandName="Delete" OnClientClick="return confirm('هل تريد حذف الخبر?');"
                        AlternateText="Delete" />
                </ItemTemplate>
            </asp:TemplateField>--%>
       <%-- </Columns>
    </asp:GridView>--%>
             
       </asp:Panel>
</asp:Content>
