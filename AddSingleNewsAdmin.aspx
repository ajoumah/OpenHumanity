<%@ Page Title="" Language="C#" MasterPageFile="~/Administrator.Master" AutoEventWireup="true" CodeBehind="AddSingleNewsAdmin.aspx.cs" Inherits="Onder1.AddSingleNewsAdmin" %>
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
                             <asp:Label ID="Label1" runat="server" ForeColor="red" Font-Size="30" Text="اضافة خبر"></asp:Label>
                         </p>
                     </div>   
                    <div class="col-xl-12 col-lg-12  col-md-12 col-sm-12 pull-right ">
                        <div class="card " style="border-radius: 14px 14px 0 0;">
                            
                            <div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 " >
                               <div class="item w-100" style="direction: rtl; float: right">
                                    <p class="col-12 align-content-end  text-right font-style-motto   float-right " style="direction: rtl;float:right">

                                        <asp:Label ID="TitleLabel" runat="server" Text="عنوان الخبر" Width="100%" class="col-12 align-content-end  text-right    float-right " Style="direction: rtl;float:right"></asp:Label>

                                    </p>
                                    <div class="item col-12 text-right " style="direction: rtl; float: right">
                                        <p class=" align-content-end  text-right font-style-motto   float-right " style="direction: rtl;float:right;font-size:25px">
                                        <asp:RequiredFieldValidator class="item col-12 " Display="Dynamic" Style="direction: rtl; float: right" runat="server" ID="reqName" ControlToValidate="TitleTextBox" ForeColor="Red" ErrorMessage="يجب ادخال عنوان الخبر!" />
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
                                 <iframe id="VideoFrame"  runat="server" class="BorderSectorColor bd-placeholder-img w-100 pl-3 pr-3 mt-0" style="width:100%;height:412px;border-radius:10px;display:none;border: none;"  allowfullscreen></iframe> 
                                </div>
                                <div class="item col-3 " style="direction:rtl;float:right">
                                <asp:RequiredFieldValidator ID="rfvFileupload" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload" Display="Dynamic"></asp:RegularExpressionValidator>
                                 <asp:FileUpload ID="fileupload" runat="server" class="col-12;" style="direction:rtl;float:right" />
                                    </div>
                            </div>
                            <div class="w-100 mx-auto p-3  text-right ">
                                <p class="col-12 align-content-end  text-right " style="font-size:15px">
                                 <asp:Label ID="Label3" runat="server" text=" : بامكانك اضافة فيديو  "  style="font-size:20px;"></asp:Label>
                                <br />
                                  <asp:Label ID="Label2" runat="server" text="رابط الفيديو " style="font-size:20px;"></asp:Label>
                                     <br />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator12" class="col-12;text-right" runat="server" ErrorMessage="فقط مقاطع يوتيوب يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^((?:https?:)?\/\/)?((?:www|m)\.)?((?:youtube\.com|youtu.be))(\/(?:[\w\-]+\?v=|embed\/|v\/)?)([\w\-]+)(\S+)?$" ControlToValidate="TextBoxVideoUrl" Display="Dynamic"></asp:RegularExpressionValidator>
                                    <asp:TextBox ID="TextBoxVideoUrl"  runat="server" Style="direction: rtl;"   TextMode="MultiLine" Width="100%" ></asp:TextBox>
                                    <asp:Label ID="Label4" runat="server" text="وصف الفيديو " style="font-size:20px;"></asp:Label>
                                    
                                    
                                    <asp:TextBox ID="TextBoxVideoTitle"  runat="server" Style="direction: rtl;"  minlength="<%#TextBoxVideoUrl.Text.Length %>" MaxLength="49"  Width="100%" ></asp:TextBox>
                                    
                                   
                                </p>
                                
                            </div>
                            <div class=" text-right border-bottom" style="direction:rtl">
                                
                                
                                    <div class="  ">
                                        
                                        <p style="font-size:18px">
                                            <asp:Label ID="Label6" runat="server" text="التاريخ"  class="w-100 ml-3 mr-3 pt-2"></asp:Label>
                                        <span class="glyphicon glyphicon-dashboard ml-5 mr-3 pt-2"> </span>
                                             
                                           <asp:Label ID="LabelDate" class=" ml-5 mr-5 pt-2 pr-5" runat="server" DataFormatString = "{0:dd/MM/yyyy}" style="direction:ltr" ></asp:Label>
                                            <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" ForeColor="Red" controltovalidate="datepicker" errormessage="يجب ادخال تاريخ الخبر!" />
                                            <asp:TextBox ID="datepicker" class=" ml-5 mr-5 pt-2" runat="server" DataFormatString = "{0:dd/MM/yyyy}" data-date-format="dd-mm-yyyy" style="font-size:30px;width:250px;" ClientIDMode="static "></asp:TextBox>
                                            
                                            <script>
                                                //$('#datepicker').datepicker({
                                                //    uiLibrary: 'bootstrap4',
                                                   
                                                //});
                                              
                                                $('#datepicker').datepicker({ format: 'dd mm yyyy' });
                                            </script>
                                           
                                               
                                                
                                            <span class="glyphicon glyphicon-tags ml-1 mr-5 pt-2"> </span>
                                           <asp:Label ID="LabelBelongsTo" class="w-100 ml-1 mr-3 pt-2" runat="server" ></asp:Label>
                                           <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="DropDownListProjects" InitialValue="0" runat="server" ErrorMessage="Please select city"></asp:RequiredFieldValidator>--%>
                                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="DropDownListProjects" InitialValue="0" runat="server" ErrorMessage="اختر من القائمة ! "></asp:RequiredFieldValidator>
                                            <asp:DropDownList ID="DropDownListProjects" class="w-100" style="direction:rtl" runat="server"></asp:DropDownList>
                                            
                                       </p>                                 
                                    </div>
                                
                            </div>
                            <div class="card-body  text-right border-bottom" style="direction:rtl">
                                
                                
                                <p class="col-12 font-Sector-paragraph text-right float-right" style="direction: rtl;">
                                     <asp:Label ID="Label7" runat="server" text="تفاصيل الخبر"></asp:Label>
                                      <asp:RequiredFieldValidator runat="server" ForeColor="Red" id="RequiredFieldValidator2" controltovalidate="DetailsTextBox" errormessage="يجب ادخال تفاصيل الخبر!" />
                                    <asp:TextBox ID="DetailsTextBox" runat="server" Style="direction: rtl;"   TextMode="MultiLine" Width="100%" Height="700"></asp:TextBox>
                                    
                                     
                                    
                                       
                                    


                                </p>
                            </div>
                           
                           
                        </div>
                
        
        
     </div>  
          
        
    <hr class="featurette-divider" />
   
        <div class="container bg-faded bg-light">
            <p class="text-center display-4 SectorColor">صور متعلقة بالخبر</p>
            <div class="row">
              
          </div>
            <div class="row" >
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                             
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image0" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload0"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload0" Display="Dynamic"></asp:RegularExpressionValidator>      
                    <asp:FileUpload ID="fileupload0" runat="server"  style="direction:rtl;float:right"/>
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                            
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image1" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload1"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload1" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload1" runat="server" style="direction:rtl;float:right" />
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                           
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image2" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload2"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload2" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload2" runat="server" style="direction:rtl;float:right" />
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                             
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image3" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload3"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload3" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload3" runat="server" style="direction:rtl;float:right" />
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                             
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image4" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload4"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload4" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload4" runat="server" style="direction:rtl;float:right" />
                    </div>
            </div>
            <div class="row">
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                            
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image5" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload5"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload5" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload5" runat="server"  style="direction:rtl;float:right"/>
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                             
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image6" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload6"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload6" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload6" runat="server"  style="direction:rtl;float:right"/>
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                            
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image7" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload7"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload7" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload7" runat="server" style="direction:rtl;float:right" />
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                            
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image8" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload8"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload8" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload8" runat="server"  style="direction:rtl;float:right"/>
                    </div>
                <div class="item col-2  m-4" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                           
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="Image9" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
                        </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" class="col-12;text-right" runat="server" Display="Dynamic" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ErrorMessage="يجب اختيار صورة !" ControlToValidate="fileupload9"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" class="col-12;text-right" runat="server" ErrorMessage="فقط صور يجب اختيارها!" ForeColor="Red" Font-Size="15" style="direction:rtl;float:right" ValidationExpression="^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.png|.bmp|.gif|.GIF|.jpg|.JPG|.jpeg|.JPEG)$" ControlToValidate="fileupload9" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:FileUpload ID="fileupload9" runat="server"  style="direction:rtl;float:right"/>
                    </div>
            </div>

        </div>
     
        <div class="container bg-faded bg-light mt-5">
          <p class="text-right display-4 SectorColor">: الكلمات المفتاحية</p>
          
            
           <div class=" "  >

               <div class="col-12 pull-right " >
                              
                          <p class=" ml-2 font-Sector-paragraph text-right " style="direction: rtl;">
                              
                              <asp:RequiredFieldValidator runat="server" ForeColor="Red" id="RequiredFieldValidator15" controltovalidate="TextBoxKeyword0" errormessage="يجب ادخال كلمة مفتاحية واحدة على الأقل!"  Display="Dynamic"/>

                          </p>
                        </div>
                          <div class="col-2 pull-right m-1" >
                          <p class=" ml-2 font-Sector-paragraph text-right " style="direction: rtl;">
                              <a class="btn more-news btn-sm SectorBackgoundColor font-Sector-paragraph text-right"  style="color:white;direction:rtl;font-size:20px;"  >
                                  
                                  <asp:TextBox ID="TextBoxKeyword0" runat="server" MaxLength="49" ></asp:TextBox>
                             </a>

                          </p>
                        </div>
                       <div class="col-2 pull-right m-1" >
                          <p class=" font-Sector-paragraph text-right " style="direction: rtl;">
                              <a class="btn more-news btn-sm SectorBackgoundColor"  style="color:white;direction:rtl;font-size:20px;"  >
                                  <asp:TextBox ID="TextBoxKeyword1" runat="server" MaxLength="49" ></asp:TextBox>
                             </a>

                          </p>
                        </div>
                     <div class="col-2 pull-right m-1" >
                          <p class=" font-Sector-paragraph text-right " style="direction: rtl;">
                              <a class="btn more-news btn-sm SectorBackgoundColor"  style="color:white;direction:rtl;font-size:20px;"  >
                                  <asp:TextBox ID="TextBoxKeyword2" runat="server" MaxLength="49" ></asp:TextBox>
                             </a>

                          </p>
                        </div>
               <div class="col-2 pull-right m-1" >
                          <p class=" font-Sector-paragraph text-right " style="direction: rtl;">
                              <a class="btn more-news btn-sm SectorBackgoundColor"  style="color:white;direction:rtl;font-size:20px;"  >
                                  <asp:TextBox ID="TextBoxKeyword3" runat="server" MaxLength="49"></asp:TextBox>
                             </a>

                          </p>
                        </div>
               <div class="col-2 pull-right m-1" >
                          <p class=" font-Sector-paragraph text-right" style="direction: rtl;">
                              <a class="btn more-news btn-sm SectorBackgoundColor"  style="color:white;direction:rtl;font-size:20px;"  >
                                  <asp:TextBox ID="TextBoxKeyword4" runat="server" MaxLength="49" ></asp:TextBox>
                             </a>

                          </p>
                        </div>
                      
           </div>
 <hr class="featurette-divider" />

      </div>
    <div class="row">
 <span style="height:80px">

 </span>
        
    </div>
         <div class="row ">
             <div class="col text-center">
          <asp:Button ID="CreateButton" class="btn btn-primary btn-lg" runat="server" Text="انشاء خبر" Width="200" Height="40"  style="box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);font-family:Tajawal;font-size:20px;border-radius: 12px;" OnClick="CreateButton_Click"/>
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
    
    
    <%--<script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>--%>
  
</asp:Content>
