<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="AddSingleProjectAdmin.aspx.cs" Inherits="Onder1.AddSingleProjectAdmin" %>
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
                             <asp:Label ID="Label1" runat="server" ForeColor="red" Font-Size="30" Text="اضافة مشروع"></asp:Label>
                         </p>
                     </div>   
                    <div class="col-xl-12 col-lg-12  col-md-12 col-sm-12 pull-right ">
                        <div class="card " style="border-radius: 14px 14px 0 0;">
                            
                            <div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 " >
                               <div class="item w-100" style="direction: rtl; float: right">
                                    <p class="col-12 align-content-end  text-right font-style-motto   float-right " style="direction: rtl;float:right">

                                        <asp:Label ID="TitleLabel" runat="server" Text="عنوان المشروع" Width="100%" class="col-12 align-content-end  text-right    float-right " Style="direction: rtl;float:right"></asp:Label>

                                    </p>
                                    <div class="item col-12 text-right " style="direction: rtl; float: right">
                                        <p class=" align-content-end  text-right font-style-motto   float-right " style="direction: rtl;float:right;font-size:25px">
                                        <asp:RequiredFieldValidator class="item col-12 " Display="Dynamic" Style="direction: rtl; float: right" runat="server" ID="reqName" ControlToValidate="TitleTextBox" ForeColor="Red" ErrorMessage="يجب ادخال عنوان المشروع!" />
                                     </p>
                                            </div>
                                </div>
                                <p class="col-12 align-content-end  text-right font-style-motto   float-right " style="direction:rtl">
                                    <asp:TextBox ID="TitleTextBox" runat="server" style="direction:rtl"  MaxLength="49"  Width="100%" ></asp:TextBox>
                                          
                                        
                                </p>

                            </div>
                           <asp:Label ID="Label5" runat="server" style="font-size:30px;direction:rtl;padding-right:30px;padding-bottom:20px" class="text-right" text="الصورة الرئيسية"></asp:Label>
                            <div class="w-100"  >
                                  <div>
                                 <asp:Image  runat="server" ID="ImageNews" CssClass="BorderSectorColor" class="bd-placeholder-img  pl-3 pr-3 mt-0" style="width:100%;height:412px;border-radius:10px"/>
                                 
                                </div>
                                <div class="item col-3 " style="direction:rtl;float:right">
                                <asp:RequiredFieldValidator ID="rfvFileupload" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator11" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload" Display="Dynamic"></asp:RegularExpressionValidator>
                                 <asp:FileUpload ID="fileupload" runat="server" class="col-12;" style="direction:rtl;float:right" />
                                    </div>
                            </div>
                            <%--<div class="w-100 mx-auto p-3  text-right ">
                                <p class="col-12 align-content-end  text-right " style="font-size:15px">
                                 <asp:Label ID="Label3" runat="server" text=" : بامكانك اضافة فيديو  "  style="font-size:20px;"></asp:Label>
                                <br />
                                  <asp:Label ID="Label2" runat="server" text="رابط الفيديو " style="font-size:20px;"></asp:Label>
                                     <br />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" class="col-12;text-right" runat="server" ErrorMessage="فقط مقاطع يوتيوب يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^((?:https?:)?\/\/)?((?:www|m)\.)?((?:youtube\.com|youtu.be))(\/(?:[\w\-]+\?v=|embed\/|v\/)?)([\w\-]+)(\S+)?$" ControlToValidate="TextBoxVideoUrl" Display="Dynamic"></asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator class="item col-12 " Display="Dynamic" Style="direction: rtl; float: right" runat="server" ID="RequiredFieldValidator2" ControlToValidate="TextBoxVideoUrl" ForeColor="Red" ErrorMessage="يجب اضافة رابط اليوتيوب!" />
                                    <asp:TextBox ID="TextBoxVideoUrl"  runat="server" Style="direction: rtl;"   TextMode="MultiLine" Width="100%" ></asp:TextBox>
                                    <asp:Label ID="Label4" runat="server" text="وصف الفيديو " style="font-size:20px;"></asp:Label>
                                    
                                    
                                    <asp:TextBox ID="TextBoxVideoDetails"  runat="server" Style="direction: rtl;"  minlength="<%#TextBoxVideoUrl.Text.Length %>"   Width="100%" ></asp:TextBox>
                                    
                                   
                                </p>
                                
                            </div>--%>
                            <div class=" text-right border-bottom" style="direction:rtl">
                                
                                
                                    <div class="  ">
                                        
                                        <p style="font-size:18px">
                                            
                                           
                                               
                                                
                                            <span class="glyphicon glyphicon-tags ml-1 mr-5 pt-2"> </span>
                                           <asp:Label ID="LabelBelongsTo" class="w-100 ml-1 mr-3 pt-2" runat="server" text="البرنامج الذي ينتمي له"></asp:Label>
                                           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="DropDownListProjects" InitialValue="0" runat="server" ErrorMessage="Please select city"></asp:RequiredFieldValidator>--%>
                                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="DropDownListProjects" InitialValue="0" runat="server" ErrorMessage="اختر من القائمة ! "></asp:RequiredFieldValidator>
                                            <asp:DropDownList ID="DropDownListProjects" class="w-100" style="direction:rtl" runat="server"></asp:DropDownList>
                                            
                                       </p>                                 
                                    </div>
                                
                            </div>
                            <div class="card-body  text-right border-bottom" style="direction:rtl">
                                <p class="col-12 font-Sector-paragraph text-right float-right" style="direction: rtl;">
                                     <asp:Label ID="Label7" runat="server" text="وصف المشروع"></asp:Label>
                                      <asp:RequiredFieldValidator runat="server" ForeColor="Red" id="RequiredFieldValidator2" controltovalidate="DetailsTextBox" errormessage="يجب ادخال وصف المشروع!" />
                                    <asp:TextBox ID="DetailsTextBox" runat="server" Style="direction: rtl;"   TextMode="MultiLine" Width="100%" Height="200"></asp:TextBox>
                                
                                </p>
                            </div>
                            <div class="card-body  text-right border-bottom" style="direction:rtl">
                                <p class="col-12 font-Sector-paragraph text-right float-right" style="direction: rtl;">
                                     <asp:Label ID="Label2" runat="server" text="عدد المستفيدين"></asp:Label>
                                      <asp:RequiredFieldValidator runat="server" ForeColor="Red" id="RequiredFieldValidator1" controltovalidate="BenefitNoTextBox" errormessage="يجب ادخال عدد المستفيدين!" />
                                      <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="BenefitNoTextBox" ErrorMessage="يجب أن تكون القيمة المدخلة رقم فقط" />
                                    <asp:TextBox ID="BenefitNoTextBox" runat="server" Style="direction: rtl;"    Width="100%" ></asp:TextBox>
                                
                                </p>
                            </div>
                           <div class="w-100 mx-auto p-3  text-right ">
                                <p class="col-12 align-content-end  text-right " style="font-size:15px">
                                 <asp:Label ID="Label3" runat="server" text=" : بامكانك اضافة ملاحظة  "  style="font-size:20px;"></asp:Label>
                                <br />
                                  <asp:Label ID="LabelNote" runat="server" text="ملاحظة " style="font-size:20px;"></asp:Label>
                                     <br />
                                    
                                    <%--<asp:RegularExpressionValidator ID="RegExp1" runat="server"
                                        ErrorMessage="يجب أن تكون الملاحظة أحرف وأرقام فقط"
                                        ControlToValidate="NotesTextBox"
                                        ValidationExpression="^[-\u0621-\u064A0-9-a-zA-Z0-9\s]$" />--%>
                                    <asp:TextBox ID="NotesTextBox"  runat="server" Style="direction: rtl;"   TextMode="MultiLine" Width="100%" Height="100" ></asp:TextBox>
                                    
                                    
                                   
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
          <asp:Button ID="CreateButton" class="btn btn-primary btn-lg" runat="server" Text="اضافة مشروع" Width="200" Height="40"  style="box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);font-family:Tajawal;font-size:20px;border-radius: 12px;" OnClick="CreateButton_Click"/>
                 </div>
      </div>
         <div class="row">
<span style="height:80px">

 </span>
    </div>
           
   </div>  
  
    
    </div>
    
     
</asp:Content>
