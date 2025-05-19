<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="AddRoleAdmin.aspx.cs" Inherits="Onder1.AddRoleAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bg-faded bg-light">
     <div class="m-5">
        
         <p class="p-5 text-center col-12 align-content-end  text-right font-style-motto">

             <asp:Label ID="statusLabel" ForeColor="Red" Font-Size="30" BackColor="Yellow" class="w-100" runat="server" Text=""></asp:Label>
         </p>
                
                     <div >
                         <p class="p-2 text-center">
                             <asp:Label ID="Label1" runat="server" ForeColor="red" Font-Size="30" Text="انشاء مجموعة"></asp:Label>
                         </p>
                     </div>   
                    <div class="col-xl-12 col-lg-12  col-md-12 col-sm-12 pull-right ">
                        <div class="card " style="border-radius: 14px 14px 0 0;">
                            
                            <div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 " >
                               <div class="item w-100" style="direction: rtl; float: right">
                                    <p class="col-12 align-content-end  text-right font-style-motto   float-right " style="direction: rtl;float:right">

                                        <asp:Label ID="TitleLabel" runat="server" Text="اسم المجموعة" Width="100%" class="col-12 align-content-end  text-right    float-right " Style="direction: rtl;float:right"></asp:Label>

                                    </p>
                                    <div class="item col-12 text-right " style="direction: rtl; float: right">
                                        <p class=" align-content-end  text-right font-style-motto   float-right " style="direction: rtl;float:right;font-size:25px">
                                        <asp:RequiredFieldValidator class="item col-12 " Display="Dynamic" Style="direction: rtl; float: right" runat="server" ID="reqName" ControlToValidate="TitleTextBox" ForeColor="Red" ErrorMessage="يجب ادخال اسم المجموعة!" />
                                     </p>
                                            </div>
                                </div>
                                <p class="col-12 align-content-end  text-right font-style-motto   float-right " style="direction:rtl">
                                    <asp:TextBox ID="TitleTextBox" runat="server" style="direction:rtl"  MaxLength="49"  Width="100%" ></asp:TextBox>
                                          
                                        
                                </p>

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
          <asp:Button ID="CreateButton" class="btn btn-primary btn-lg" runat="server" Text="انشاء مجموعة" Width="200" Height="40"  style="box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);font-family:Tajawal;font-size:20px;border-radius: 12px;" OnClick="CreateButton_Click"/>
                 </div>
      </div>
         <div class="row">
<span style="height:80px">

 </span>
    </div>
           
   </div>  
  
    
    </div>
</asp:Content>
