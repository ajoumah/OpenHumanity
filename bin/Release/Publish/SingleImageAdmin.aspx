<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="SingleImageAdmin.aspx.cs" Inherits="Onder1.SingleImageAdmin" %>
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
        
               <%-- <p class="p-2 text-center">
                    BackColor="Yellow" class="w-100"
             <asp:Label ID="statusLabel" runat="server" ForeColor="Green" Font-Size="30" Text=""></asp:Label>
         </p>--%>
         <p class="p-5 text-center col-12 align-content-end  text-right font-style-motto">

             <asp:Label ID="statusLabel" ForeColor="Red" Font-Size="30" BackColor="Yellow" class="w-100" runat="server" Text=""></asp:Label>
         </p>
                     <div >
                         <p class="p-2 text-center">
                             <asp:Label ID="Label1" runat="server" ForeColor="red" Font-Size="30" Text="تعديل الصورة"></asp:Label>
                         </p>
                     </div>   
                    <div class="col-xl-12 col-lg-12  col-md-12 col-sm-12 pull-right ">
                        <div class="card " style="border-radius: 14px 14px 0 0;">
                            
                            <div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 ">
                                <p class="col-12 align-content-end  text-right font-style-motto  ">
                                    <asp:Label ID="TitleLabel" runat="server" text="عنوان الصورة"></asp:Label>
                                    <asp:RequiredFieldValidator class="item col-12 " Display="Dynamic" Style="direction: rtl; float: right" runat="server" ID="reqName" ControlToValidate="TitleTextBox" ForeColor="Red" ErrorMessage="يجب ادخال عنوان الصورة!" />
                                    <asp:TextBox ID="TitleTextBox" runat="server" style="direction:rtl" TextMode="MultiLine" MaxLength="49"  Width="100%"></asp:TextBox>
                                        
                                        
                                </p>

                            </div>
                            <asp:Label ID="Label5" runat="server" style="font-size:30px;width:100%;direction:rtl;" class="text-right" text="الصورة "></asp:Label>
                            <div class="w-100">
                                  
                                 <asp:Image  runat="server" ID="ImageNews" CssClass="BorderSectorColor" class="bd-placeholder-img  pl-3 pr-3 mt-0" style="width:100%;height:412px;border-radius:10px"/>
                                 <%--<iframe id="VideoFrame"  runat="server" class="BorderSectorColor bd-placeholder-img w-100 pl-3 pr-3 mt-0" style="width:100%;height:412px;border-radius:10px;display:none;border: none;"  allowfullscreen></iframe> --%>
                                 <div class="item col-3 " style="direction:rtl;float:right">
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload" Display="Dynamic"></asp:RegularExpressionValidator>
                                 <asp:FileUpload ID="fileupload" runat="server"  />
                                     </div>
                            </div>
                            
                            <div class=" text-right border-bottom" style="direction:rtl">
                             
                                    <div class="  ">
                                        
                                        <p style="font-size:18px">
                                            <asp:Label ID="Label6" runat="server" text="التاريخ"  class="w-100 ml-3 mr-3 pt-2"></asp:Label>
                                        <span class="glyphicon glyphicon-dashboard ml-5 mr-3 pt-2"> </span>
                                             
                                           <asp:Label ID="LabelDate" class=" ml-5 mr-5 pt-2 pr-5" runat="server" DataFormatString = "{0:dd/MM/yyyy}" style="direction:ltr" ></asp:Label>
                                            <asp:TextBox ID="datepicker" class=" ml-5 mr-5 pt-2" runat="server" DataFormatString = "{0:dd/MM/yyyy}" data-date-format="dd-mm-yyyy" style="font-size:30px;width:250px;" ClientIDMode="static "></asp:TextBox>
                                            <script>
                                                //$('#datepicker').datepicker({
                                                //    uiLibrary: 'bootstrap4',
                                                   
                                                //});
                                              
                                                $('#datepicker').datepicker({ format: 'dd mm yyyy' });
                                            </script>
                                           
                                               
                                                
                                            <span class="glyphicon glyphicon-tags ml-1 mr-5 pt-2"> </span>
                                           <asp:Label ID="LabelBelongsTo" class="w-100 ml-1 mr-3 pt-2" runat="server" ></asp:Label>
                                            <asp:DropDownList ID="DropDownListProjects" class="w-100" style="direction:rtl" runat="server"></asp:DropDownList>
                                                               
                                       </p>                                 
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
     <script>
    $('.CounTUp').each(function () {
        $(this).prop('Counter', 0).animate({
            Counter: $(this).text()
        }, {
            duration: 3000,
            easing: 'swing',
            step: function (now) {
                $(this).text(Math.ceil(now));
            }
        });
    });
    </script>
    
</asp:Content>
