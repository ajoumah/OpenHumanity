<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Onder1.News" %>
<%@ Register src="UserControls/ImageDisplayControl.ascx" tagname="ImageDisplayControl" tagprefix="uc1" %>

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
    <!--New BootStrap CSS -->
    <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />--%>
   <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        .carousel-caption-below {
            position: relative;
            left: 0;
            top: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bg-faded bg-light">
     <div class="">
            <asp:Repeater ID="NewsRepeater" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound"  >
                <ItemTemplate >
                    <div class="col-xl-12 col-lg-12  col-md-12 col-sm-12 pull-right">
                        <div class="card " style="border-radius: 14px 14px 0 0;">
                            <%--<div class="pt-5 pr-4 text-right border-bottom font-news-paragraph-header" style="direction:rtl">
                               
                                <asp:Label ID="Label2" runat="server"  Text='<%#Eval("Title")%>'></asp:Label>
                            </div>--%>
                            <div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 ">
                                <p class="col-12 align-content-end  text-right font-style-motto  ">
                                    <asp:Label ID="TitleLabel" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
                                </p>
                                <div class="col-12 text-right border-bottom" style="direction:rtl">
                                 <%--<p> Ok icon:</p>--%>
                                <p class=" ">
                                    <div class="  ">
                                        <p style="font-size:18px">
                                        <span class="glyphicon glyphicon-dashboard ml-3 mr-0 pt-2"> </span>
                                        <asp:Label ID="Label1" class=" ml-1 mr-1 pt-2" runat="server"  Text = '<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                        <span class="glyphicon glyphicon-tags ml-1 mr-5 pt-2"> </span>
                                        <asp:Label ID="Label4" class=" ml-1 mr-3 pt-2" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                                        
                                                                
                                       </p>                                 
                                    </div>
                                </p>
                            </div>
                            </div>
                            <div class="w-100">
                                
                                 <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" class="bd-placeholder-img  pl-3 pr-3 mt-0" style="width:100%;height:412px;border-radius:10px"/>
                                 <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor bd-placeholder-img w-100 pl-3 pr-3 mt-0" style="width:100%;height:412px;border-radius:10px;display:none;border: none;"  allowfullscreen></iframe> 
                                
    
                            </div>
                            
                            <div class=" text-right border-bottom" style="direction:rtl">
                                 <%--<p> Ok icon:</p>--%>
                                <p >
                                    <div class="  ">
                                        <p style="font-size:18px">
                                        <%--<span class="glyphicon glyphicon-dashboard ml-3 mr-5 pt-2"> </span>
                                        <asp:Label ID="Label1" class=" ml-1 mr-1 pt-2" runat="server"  Text = '<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                        <span class="glyphicon glyphicon-tags ml-1 mr-5 pt-2"> </span>
                                        <asp:Label ID="Label4" class=" ml-1 mr-3 pt-2" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>--%>
                                        
                                        <a class="ml-2 mr-2 share-btn share-btn-branded share-btn-whatsApp pull-left" href="https://api.whatsapp.com/send?text=" title="مشاركة على الوتس أب"> <span><img src="images/WhatsApp37.png" /></span> </a>
                                        <a class="ml-2 mr-2 share-btn share-btn-branded share-btn-facebook pull-left" href="https://www.facebook.com/sharer/sharer.php?u=" title="مشاركة على الفيس بوك"><span><img src="images/facebook7.png" /></span></a>
                                        <a class="ml-2 mr-2 share-btn share-btn-branded share-btn-twitter pull-left"  href="https://twitter.com/share?url=" title="مشاركة على تويتر"><span><img src="images/twitter77.png" /> </span></a>
                                        <a class="ml-2 mr-2 share-btn share-btn-branded share-btn-telegram pull-left" href="https://telegram.me/share/url?url=" title="مشاركة على التلغرام"><span><img src="images/telegram7.png" /></span></a>
                                        <asp:Label ID="Label2" class=" ml-1 mr-3 pull-left loose SectorColor pt-2" style="direction:ltr" runat="server" Text=":   مشاركة      "></asp:Label>
                                                                     
                                       </p>                                 
                                    </div>
                                </p>
                            </div>
                            <div class="card-body  text-right border-bottom" style="direction:rtl">
                                
                                
                                <p class="col-12 font-Sector-paragraph text-right float-right" style="direction: rtl;">
                                     <asp:Label ID="Label3" Style="direction: rtl;" runat="server" Text='<%#Eval("Details1")%>' ></asp:Label>
                                     <%--<asp:Image ImageUrl='<%#Eval("Secondary")%>' runat="server" ID="Image1" CssClass="BorderSectorColor" class="bd-placeholder-img  pl-3 pr-3 m-4" style="width:33.33%;height:357px;border-radius:10px;float:left;margin-right:5%;margin-top:5%;margin-bottom:5%;"/>--%>
                                    <asp:Label ID="DescriptionLabel" Style="direction: rtl;" runat="server" Text='<%#Eval("Details2")%>' ></asp:Label>
                                       
                                    


                                </p>
                            </div>
                           
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
     </div>  
          
         
    <hr class="featurette-divider" />
   
        <div class="container bg-faded bg-light">
            <p class="text-center display-4 SectorColor">صور متعلقة بالخبر</p>
            <div class="row">
              <uc1:ImageDisplayControl ID="ImageDisplayControl1" runat="server" />
          </div>



        </div>
     
        <div class="container bg-faded bg-light mt-5">
          <p class="text-right display-4 SectorColor">: الكلمات المفتاحية</p>
          <div class="">
              
              <asp:Repeater ID="KeyWordRepeater" runat="server"   >
                <ItemTemplate >
                    <div class="pull-right" style="margin-right:2%;margin-left:2%;"">
                        
                            
                            <p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToSearch((Eval("Word").ToString()),false,"1")%>' style="color:white;direction:rtl;margin-right:10%;margin-left:10%;" role="button" ><%#Eval("Word")%></a></p>
                               
                            
                            
                            
                           
                            
                       
                    </div>
                           
                            
                            
                        
                </ItemTemplate>
            </asp:Repeater>
              
          </div>

 <hr class="featurette-divider" />

      </div>
     <div class="container bg-faded bg-light mt-5 mb-4">
          <p class="text-right display-4 SectorColor">: أخبار متعلقة</p>
          <div class="mt-5">
            <asp:Repeater ID="RepeaterRelatedNews" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound"  >
                <ItemTemplate >
                    <div class="col-xl-6 col-lg-12  col-md-12 col-sm-12 pull-right mt-5 mb-5" style="float:right;height:420px">
                        <div class=" " style="border-radius: 14px 14px 0 0;width:100%;float:right">
                            <div class="col-6" style="float:right;">
                                
                                 <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor"  height="311" style="border-radius: 14px;width:115%"/>
                                 <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor" height="311"  style="border-radius: 14px;display:none;width:115%" allowfullscreen></iframe> 
                                
    
                            </div>
                            <div class="col-6" style="float:right;">
                                 <div class="pb-3 pt-5 pr-4 text-right border-bottom font-news-paragraph-header" style="direction:rtl">
                               
                                <asp:Label ID="Label2" runat="server"  Text='<%#Eval("Title")%>'></asp:Label>
                                </div>
                                <div class=" text-right border-bottom" style="direction: rtl">
                                          <div class="pt-3 pb-3 border-right border-left  " style="display:flex">
                                              <div class=" mt-3 ml-4" style="display: inline-block;width:40%">
                                              <span class="d-flex justify-content-start glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="d-flex justify-content-start" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                               <div class="" style="display: inline-block;width:60%">
                                                  <span class="row border-bottom" style="margin-left:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0" ><%#Eval("Program" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0"><%#Eval("Project" )%> </span>
                                              </div>
                                               
                                             
                                          </div>
                                    </div>
                                <%--<div class=" text-right border-bottom" style="direction: rtl">

                                    <p>
                                        <div class="  ">
                                            <span class="glyphicon glyphicon-dashboard col-2"></span>
                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>

                                        </div>
                                    </p>
                                </div>--%>
                                 <div class="card-body  text-right border-bottom" style="direction:rtl">
                                  <p class=" ">
                                          <%#Eval("Details")%>
                                          <a class=" SectorColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>
                                <%--<asp:Label ID="Label3" runat="server" Text='<%#Eval("Details")%>'></asp:Label>--%>
                            </div>
                                 <%--<div class="card-body  text-right border-bottom" style="direction:rtl">
                                
                                <p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color:white" role="button">المزيد  &raquo;</a></p>
                            </div>--%>
                                <%--<div class="card-body  text-right border-bottom mb-5" style="direction: rtl">

                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                                </div>--%>
                          </div>
                        </div>
                    </div>
                    
                </ItemTemplate>
            </asp:Repeater>



      </div>
    </div>
        <hr class="featurette-divider" />
   </div>  
  
    
    <!-- /.container -->
  <!-- Footer -->

<!-- Footer -->
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
    <script>
        (function () {

            var shareButtons = document.querySelectorAll(".share-btn");
            var twitt = document.getElementsByClassName("share-btn-twitter");
            if (twitt) {
                [].forEach.call(twitt, function (button) {

                    button.addEventListener("click", function (event) {
                        this.href = 'https://twitter.com/share?url=';
                        event.preventDefault();
                    });
                });
            }
            var facebk = document.getElementsByClassName("share-btn-facebook");
            if (facebk) {
                [].forEach.call(facebk, function (button) {

                    button.addEventListener("click", function (event) {
                        this.href = 'https://www.facebook.com/sharer/sharer.php?u=';
                        event.preventDefault();
                    });
                });
            }
            var teleg = document.getElementsByClassName("share-btn-telegram");
            if (teleg) {
                [].forEach.call(teleg, function (button) {

                    button.addEventListener("click", function (event) {
                        this.href = 'https://telegram.me/share/url?url=';
                        event.preventDefault();
                    });
                });
            }
            var whatsA = document.getElementsByClassName("share-btn-whatsApp");
            if (whatsA) {
                [].forEach.call(whatsA, function (button) {

                    button.addEventListener("click", function (event) {
                        this.href = 'https://api.whatsapp.com/send?text=';
                        event.preventDefault();
                    });
                });
            }
            if (shareButtons) {
                [].forEach.call(shareButtons, function (button) {
                    button.addEventListener("click", function (event) {
                        var width = 650, height = 650;
                        //var url = 'https://www.bbc.com/arabic/art-and-culture-49936793';
                        var url = window.location.href;
                        this.href = this.href + url;

                        event.preventDefault();

                        window.open(this.href, 'Share Dialog', 'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,width=' + width + ',height=' + height + ',top=' + (screen.height / 2 - height / 2) + ',left=' + (screen.width / 2 - width / 2));
                    });
                });
            }

        })();
    </script>
</asp:Content>
