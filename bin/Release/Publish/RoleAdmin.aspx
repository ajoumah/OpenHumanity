<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="RoleAdmin.aspx.cs" Inherits="Onder1.RoleAdmin"    Theme="OnderShopDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="App_Themes/OnderShop.css" >
    <link href="content/SectorCss.css" rel="stylesheet"  />
    <link rel="stylesheet" href="content/bootstrap.min.css">
    <!--<link rel="stylesheet" href="Content/bootstrap2.min.css" />-->

    <script src="Scripts/3.4.1/jquery.min.js"></script>

    <script src="Scripts/1.14.7/popper.min.js"></script>

    <script src="Scripts/4.3.1/bootstrap.min.js"></script>
    <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <%-- here links for Image show --%>
      
    <%--  --%>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js" type="text/javascript"></script>
    <link href="https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css" rel="stylesheet" type="text/css" />
    
   
        <style>
            .uiLibrary {font-size:30px;}
            body {
                font-family: Tajawal !important;
                color: #404041 !important;
            }
            label {
                font-size: 2rem !important;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bg-faded bg-light">
     <div class="m-5">
        
               <%-- <p class="p-2 text-center">
                    BackColor="Yellow" class="w-100"
             <asp:Label ID="statusLabel" runat="server" ForeColor="Green" Font-Size="30" Text=""></asp:Label>
         </p>--%>
         <p class="p-5 text-center col-12 align-content-end  text-right font-style-motto">

             <asp:Label ID="statusLabel" ForeColor="Red" Font-Size="30" BackColor="Yellow" class="w-100" runat="server" Text=""></asp:Label>
         </p>
                     <div >
                         <p class="p-2 text-center">
                             <asp:Label ID="Label1" runat="server" ForeColor="red" Font-Size="30" Text="تعديل مجموعة :" style="direction:rtl"></asp:Label>
                             <asp:Label ID="RoleNameLabel" runat="server" style="font-size:30px;width:100%;direction:rtl;" class="" ></asp:Label>
                         </p>
                     </div>   
                    <div class="col-xl-12 col-lg-12  col-md-12 col-sm-12 pull-right ">
                        <div class="card " style="border-radius: 14px 14px 0 0;">
                            
                            
                           
                            
                            
                            <div class=" text-right border-bottom" style="direction:rtl">
                             
                                    
                                 <asp:Panel ID="Panel1" runat="server" ScrollBars="Both" style="overflow: auto;height: auto; " class="p-5" >
                                      <asp:Label ID="Label5" runat="server" style="font-size:30px;width:100%;direction:rtl;" class="text-right" text="أسماء المستخدمين المشتركين  : "></asp:Label>
                            <asp:Label ID="LabelUserName" runat="server" style="font-size:30px;width:100%;direction:rtl;" class="text-right" ></asp:Label>
                                 <asp:GridView ID="grid" AllowPaging="true" OnPageIndexChanging="grid_PageIndexChanging" runat="server" AutoGenerateColumns="false" DataKeyNames="Id" dir="rtl"  
                                     Font-Size="20" >
                                    
                                
                                      <Columns>
                                          <asp:TemplateField HeaderText=" الأعضاء في المجموعة">

                                              <EditItemTemplate>
                                                  <asp:TextBox ID="UserNameTextBox" runat="server"
                                                      Text='<%# Bind("UserName") %>' Height="70px" TextMode="MultiLine"
                                                      Width="400px"></asp:TextBox>
                                              </EditItemTemplate>
                                              <ItemTemplate>
                                                  <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                                              </ItemTemplate>
                                              
                                          </asp:TemplateField>
                                           
                                          </Columns>
                                           
                                 </asp:GridView>
                            <asp:Label ID="Label3" runat="server" Text="لازالة مستخدم من المجموعة ازل الأشارة بجانبه :" ForeColor="Red" style="font-size:30px;width:100%;direction:rtl;" class="text-right" ></asp:Label>

                                     <asp:CheckBoxList ID="CheckBoxListUser"  cssClass="checkBoxList" runat="server" DataTextField="projectName" class="checkBx"
                                                DataValueField="projectId"  RepeatLayout="OrderedList" Font-Size="20" Width="600px" EnableViewState="true" >
                                               
                                            </asp:CheckBoxList>
                                      <asp:Label ID="Label2" runat="server" class="mt-5 mb-3 text-right" style="font-size:30px;width:100%;direction:rtl;"  text="أسماء المستخدمين غير المشتركين : "></asp:Label>
                                     <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="false" DataKeyNames="Id" dir="rtl" AllowPaging="true" EnableViewState="false"
                                     Font-Size="20">
                                      <Columns>
                                          <asp:TemplateField HeaderText=" الأعضاء غير المشتركين في المجموعة">
                                              <ItemTemplate>
                                                  <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                                              </ItemTemplate>
                                          </asp:TemplateField>
                                          
                                          </Columns>
                                  </asp:GridView>
                            <asp:Label ID="Label4" runat="server" Text="لاضافة مستخدم الى المجموعة ضع اشارة بجانبه :" ForeColor="Red" style="font-size:30px;width:100%;direction:rtl;" class="text-right" ></asp:Label>

                                     <asp:CheckBoxList ID="CheckBoxListToJoin" cssClass="checkBoxList" runat="server" DataTextField="projectName" class="checkBx"
                                                DataValueField="projectId" AutoPostBack="false" RepeatLayout="OrderedList" Font-Size="20" Width="600px" >
                                               
                                            </asp:CheckBoxList>

                                            
                                     </asp:Panel>

                                <div class="row">
                                    <%--<div class="col-4 text-right p-3 mr-5 ml-5 mt-5">
                                        <asp:Button ID="DisableButton" class="btn btn-danger pr-3 pl-3" runat="server" Text="تعطيل المستخدم" Width="200" Height="40" Style="box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19); font-family: Tajawal; font-size: 20px; border-radius: 12px;" OnClick="DisableButton_Click"  />
                                    </div>--%>
                                    <%--<div class="col-12 text-right p-3 m-5">
                                         <div class="p-1 m-1 mb-5 mr-3 text-right " >
                                        <asp:TextBox runat="server" class="" ID="Password"  placeholder="كلمة المرور الجديدة" style="font-size:20px;width:300px;height:40px;direction: rtl" />
                                         </div>
                                        <asp:Button ID="ActivateButton"  class="btn btn-success col-12" runat="server" Text="تفعيل المستخدم وكلمة مرور جديدة"  Height="40" Style="box-shadow: 0 15px 30px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19); font-family: Tajawal; font-size: 20px; border-radius: 12px;width:auto " OnClick="ActivateButton_Click"   />
                                   
                                         </div>--%>
                                </div>
                            </div>
                            
                           
                           
                        </div>
                
        
        
     </div>  
          
         
    <hr class="featurette-divider" />
   
        
     
        
    <div class="row">
 <span style="height:80px">

 </span>
        
    </div>
         <div class="row ">
             <div class="col text-center">
          <asp:Button ID="UpadateButton" class="btn btn-primary btn-lg" runat="server" Text="تعديل" Width="200" Height="40"  style="box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);font-family:Tajawal;font-size:20px;border-radius: 12px;" OnClick="UpadateButton_Click"/>
                 </div>
      </div>
         <div class="row">
<span style="height:80px">

 </span>
    </div>
           
   </div>  
  
    
    </div>
</asp:Content>
