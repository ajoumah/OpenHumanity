<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="ProjectsGalleryAmin.aspx.cs" Inherits="Onder1.ProjectsGalleryAmin" EnableViewState="false"  Theme="OnderShopDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="App_Themes/OnderShop.css" >
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="p-5 text-center col-12 align-content-end  text-right font-style-motto" >
        
        <asp:Label ID="statusLabel" ForeColor="Red" Font-Size="20" BackColor="Yellow" class="w-100" runat="server" Text=""></asp:Label>
    </p>
   
    
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" style="overflow: auto;height: 600px; " class="p-5" >
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:GridView ID="grid" runat="server" AutoGenerateColumns="true" DataKeyNames="ProjectID" dir="rtl" AllowPaging="true" OnPageIndexChanging="grid_PageIndexChanging"
            OnRowDeleting="grid_RowDeleting" >
             <Columns>
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
                        Text='<%# Eval("Name") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="ProjectTitleLabel" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="اسم البرنامج"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="ProgramTitleTextBox" runat="server"
                        Text='<%# Eval("BelongsTo") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="BelongsToLabel" runat="server" Text='<%# Eval("BelongsTo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="وصف المشروع"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="DescriptionTextBox" runat="server"
                        Text='<%# Eval("Description") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <%--<asp:TemplateField HeaderText="التاريخ"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="DateTextBox" runat="server"
                        Text='<%# Eval("Date") %>' Height="70px" TextMode="MultiLine"  DataFormatString = "{0:dd/MM/yyyy}"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    
                 <asp:Label ID="Label4" runat="server"   Text=' <%# Convert.ToDateTime(Eval("Date")).ToString("yyyy/MM/dd") %>'></asp:Label>
                    
                </ItemTemplate>
            </asp:TemplateField>--%>
                 <asp:TemplateField HeaderText="صورة المشروع">
                
                <EditItemTemplate>
                    <asp:Image ImageUrl='<%#Bind("Image")%>' runat="server" ID="ImageNewsEdit" height="200" style="border-radius: 14px;"/>
                   
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ImageUrl='<%#Bind("Image")%>' runat="server" ID="ImageNews" height="200" style="border-radius: 14px;"/> 
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="عدد المستفيدين">
                
                <EditItemTemplate>
                    <asp:TextBox ID="BenefitNoTextBox" runat="server"
                        Text='<%# Bind("BenefitNo") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="BenefitNoLabel" runat="server" Text='<%# Eval("BenefitNo") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="ملاحظات"
                >
                <EditItemTemplate>
                    <asp:TextBox ID="NotesTextBox" runat="server"
                        Text='<%# Eval("Notes") %>' Height="70px" TextMode="MultiLine"
                        Width="400px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="NotesLabel" runat="server" Text='<%# Eval("Notes") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                 <asp:HyperLinkField DataNavigateUrlFields="ProjectID"
                DataNavigateUrlFormatString="Project.aspx?ProjectID={0}"
                HeaderText="رابط المشروع" Text="الرابط" />
          <asp:HyperLinkField DataNavigateUrlFields="ProjectID"
                DataNavigateUrlFormatString="SingleProjectAdmin.aspx?ProjectID={0}"
                HeaderText="تعديل المشروع" Text="تعديل" />
      
            <asp:TemplateField HeaderText="حذف المشروع">
                <ItemTemplate>
                    <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/images/cross.png"
                        CommandName="Delete" OnClientClick="return confirm('هل تريد حذف المشروع؟ سوف يتم حذف كل الأخبار والصور والفيديوهات المرتبطة؟');"
                        AlternateText="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
                 </Columns>
        </asp:GridView>
    
             
       </asp:Panel>
</asp:Content>
