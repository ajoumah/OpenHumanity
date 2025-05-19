<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="Programs.aspx.cs" Inherits="Onder1.Programs" EnableViewState="false"%>
<%@ Register src="UserControls/NewsControl.ascx" tagname="NewsControl" tagprefix="uc1" %>

<%@ Register src="UserControls/ImageDisplayControl.ascx" tagname="ImageDisplayControl" tagprefix="uc3" %>
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
         .breadcrumb {
                
                display: inline-block;
                /*box-shadow: 0 0 15px 1px rgba(0, 0, 0, 0.35);*/
                overflow: hidden;
                border-radius: 5px;
                
                counter-reset: flag;
            }

                .breadcrumb a {
                    text-decoration: none;
                    outline: none;
                    display: block;
                    float: right;
                    /*font-size: 1vw;*//*15px;*/
                    line-height: 36px;
                    color: white !important;
                    font-size:1.1vw;
                    padding: 0 30px 0 10px;
                    /*background:#3b5998 ;*//*#333;*/
                    background: linear-gradient(#3b5998, #3b5900);
                    position: relative;
                }
                    
                    .breadcrumb a:first-child {
                        padding-right:10px ;/*46px;*/
                        border-radius: 5px 0 0 5px;
                        font-size:1.4vw;
                    }

                        .breadcrumb a:first-child:before {
                            left: 14px;
                        }

                    .breadcrumb a:last-child {
                        border-radius: 15px 5px 5px 15px;
                        /*padding-right: 20px;*/
                        padding-left:20px;
                        font-size:1.2vw;
                    }

                    
                    .breadcrumb a.active, .breadcrumb a:hover {
                        background: #111;
                        background: linear-gradient(#333, #111);
                    }

                        .breadcrumb a.active:after, .breadcrumb a:hover:after {
                           /* background: #222;*/
                            /*background: linear-gradient(145deg, #333, #222);*/
                             /*filter: brightness(60%);*/
                              
                        }

                   
                    .breadcrumb a:after {
                        content: '';
                        position: absolute;
                        top: 0;
                        left: -18px; 
                        width: 36px;
                        height: 36px;
                        
                        transform: scale(0.707) rotate(225deg);
                        
                        z-index: 1;
                        
                        /*background: #555;
                        background: linear-gradient(135deg, #777, #333);*/
                        /*background: linear-gradient(135deg, #777, #333);*/
                        box-shadow: 2px -2px 0 2px rgba(0, 0, 0, 0.4), 3px -3px 0 2px rgba(255, 255, 255, 0.1);
                        
                        border-radius: 0 5px 0 50px;
                    }
                   
                    .breadcrumb a:last-child:after {
                       content: '';
                        position: absolute;
                        top: 0;
                        left: -18px; 
                        width:36px;
                        height: 36px;
                        
                        transform: scale(0.707) rotate(225deg);
                        
                        z-index: 1;
                        
                        /*background: #555;
                        background: linear-gradient(135deg, #777, #333);*/
                        
                        box-shadow: 2px -2px 0 2px rgba(0, 0, 0, 0), 3px -3px 0 2px rgba(255, 255, 255, 0.1);
                        
                        border-radius: 0 5px 0 50px;
                    }

                    .flat a, .flat a:after {
               /*background:#3b5998;*/ /*#333333;*/
                color: #eee;
                transition: all 0.7s;
            }
            .flat a, .flat a:after {
                /*background:#3b5998;*/ /*#333333;*/
                color: #eee;
                transition: all 0.7s;
                
            }
                .flat a:before {
                    background: #111;
                    box-shadow: 0 0 0 1px #00c;
                }

                .flat a:hover, .flat a.active,
                .flat a:hover:after, .flat a.active:after {
                   text-decoration: underline;
                   /*font-size:x-large;*/
                }
       
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       

   <div class="container bg-faded bg-light">
       
           <div class="row  mt-4 mb-5 mr-0 ml-0 pr-0">
            <div class="row col-xl-3 col-lg-3  col-md-12 col-sm-12 m-0">
                <span class="col-12 benifit-style-font success text-center ">
                    <asp:Label class="round_Top pl-4 pr-4  SectorBackgoundColor" runat="server" ID="benifitLabel" Style="color: white">مستفيد </asp:Label>

                </span>
                <p class="col-12 count benifit-style-font text-center " id="numberOfStudent">

                    <asp:Label class="align-content-center benifit-style-font2 CounTUp SectorColor" ID="benifitNoLabel" runat="server" Text=""></asp:Label>
                </p>
            </div>

            <div class="row col-xl-9 col-lg-9  col-md-12 col-sm-12  breadcrumb flat" id="rowSector" runat="server">


                <a href='<%# Onder1.Class1.ToSector(details.SectorID.ToString())%>' runat="server" class="pr-5 pl-5 SectorBackgoundColor " style="max-width: 50%;" id="SectorNameLink1">
                    <asp:Label ID="SectorNameLabel" runat="server"></asp:Label></a>
                <a href='<%# Onder1.Class1.ToProgram(details.ProgramID.ToString())%>' style="max-width: 50%;" runat="server" class="pr-5 pl-5 btn-lg SectorBackgoundColor " id="SectorNameLink2">
                    <asp:Label ID="ProgramNameLabel" runat="server"></asp:Label></a>
                


            </div>

        </div>
           <div class="row mt-5">
           <div class="w-75">
                <img class="bd-placeholder-img w-100"   src="images/learning1.png" />
                
                
                
            </div>
            <div class="w-25 mx-auto  mt-5 text-center">
               
                <asp:Image  runat="server" id="LogoImage"  width="108" height="120" />
                
                
            </div>
       </div>
           <div class="row mt-5 ">
           <div class="col-12">
              <p class="text-right float-right font-Sector-header d-flex flex-row-reverse col-12">
               <asp:Label ID="SectorNameParagraphLabel" runat="server"   ></asp:Label>
                  </p>
           </div>
           <div class="col-12">
               <span class="col-2 "></span>
               <p class="col-11 font-Sector-paragraph text-right float-right" style="direction:rtl">
                   <asp:Label ID="DescriptionLabel" style="direction:rtl" runat="server"   ></asp:Label>
                   

               </p>

           </div>
               
       </div>
         
    <hr class="featurette-divider" />
    
    
  </div>
     
  <div class="container marketing bg-light">
  
    <!-- Three columns of text below the carousel -->
    <!-- /.row -->


    <!-- START THE FEATURETTES -->

   
     
      

   
      <div class="container bg-faded bg-light">
          <p class="text-right display-4 SectorColor">المشاريع</p>
          <div class="row  pt-5">
              <div id="myCarousel" class="carousel slide mySlidesOfProjects  col-xl-12 col-lg-12  col-md-12 col-sm-12 pl-0 pr-0" style="background-color:#ffffff" data-ride="carousel">
                

                <!-- Wrapper for slides -->
                <div class="carousel-inner pl-0 pr-0" style="border-radius:14px;background-color:#f8f9fa!important">
                    <asp:Repeater ID="rptProjects" runat="server"  >
                        <ItemTemplate>
                            <div class=' item <%# GetClass(Container.ItemIndex) %> mySlidesOfProjects ' style="border-radius:14px;background-color:#f8f9fa!important">
                                <img src='<%# Eval("Image") %>' alt="Los Angeles" style="width: 100%;height:379px;border-radius:14px;" />
                                <div class="carousel-caption d-sm-block SectorBackgoundColor mx-auto w-25  mb-0 text-center pt-2" style="top:340px;height:5%;padding:0;border-radius:14px" >
                                    <asp:Label ID="Label4" runat="server"  Text='<%#  Convert.ToString(Container.ItemIndex+1)+"   /  "+ GlobeRows %>'></asp:Label>
                                    
                                   
                                </div>
                                
                                <div class=" d-sm-block  text-right mx-auto w-75 pt-3 mb-5 pb-3 pr-4" style="height:auto;background-color: #d9d9d9;border-radius:0 0 14px 14px" >
                                    
                                    <h3 class="font-programs-paragraph-header-Culture SectorColor">
                                       <asp:Label ID="Label5" runat="server"  Text='<%#Eval("Name")%>'></asp:Label>

                                    </h3>
                                    <p class="font-projects-paragraph">
                                       <asp:Label ID="Label6" runat="server" Text='<%#Eval("Description")%>' ></asp:Label>
                                    </p>
                                    <div class="text-center pl-4">
                                        <p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToProject((Eval("ProjectID").ToString()))%>' style="color: white; direction: rtl;" role="button">المزيد  &raquo;</a></p>
                                    </div>
                                </div>
                                <div class=" card-body pr-0 text-right border-bottom">

                                    
                                </div>
                            </div>
                              
                                    
                        </ItemTemplate>
                    </asp:Repeater>


                </div>

                <!-- Left and right controls -->
                <a class="left carousel-control pt-5 mySlidesOfProjects" style="height:375px;border-radius:14px;" href="#myCarousel" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left " ></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control pt-5 mySlidesOfProjects" style="height:375px;border-radius:14px;" href="#myCarousel" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right "  ></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
          </div>



      </div>
    

    <hr class="featurette-divider" />

   <%-- <div class="container bg-faded bg-light">
          <p class="text-right display-4 SectorColor">
              
              <asp:LinkButton class="text-right display-4 SectorColor" ID="LinkButtonNews"  runat="server"  >الأخبار</asp:LinkButton>

          </p>
          <div class="row pull-right">
              <uc1:NewsControl class="row pull-right" ID="NewsControl1" runat="server" />
          </div>



      </div>--%>

    <%--<hr class="featurette-divider" />


      <div class="container bg-faded bg-light">
          <p class="text-right display-4 SectorColor">
              
              <asp:LinkButton class="text-right display-4 SectorColor" ID="LinkButtonImageGallery"  runat="server"  >معرض الصور</asp:LinkButton>

          </p>
          <div class="row">
              
              <uc3:ImageDisplayControl ID="ImageDisplayControl1" runat="server" />
              
          </div>



      </div>--%>

    <%--<hr class="featurette-divider" />

      <div class="container bg-faded bg-light">
          <p class="text-right display-4 SectorColor">
              
              <asp:LinkButton class="text-right display-4 SectorColor" ID="LinkButtonVideoGallery"  runat="server"  >معرض الفيديو</asp:LinkButton>

          </p>
          <div class="row  pt-5">
              <div id="myCarouselVideo" class="carousel slide mySlidesOfProjects  col-xl-12 col-lg-12  col-md-12 col-sm-12 pl-0 pr-0" style="background-color:#ffffff" data-ride="carousel">
                

                
                <div class="carousel-inner pl-0 pr-0" style="border-radius:14px;background-color:#f8f9fa!important">
                    <asp:Repeater ID="VideoRepeater" runat="server"  >
                        <ItemTemplate>
                            <div class=' item <%# GetClass(Container.ItemIndex) %> mySlidesOfProjects ' style="border-radius:14px;background-color:#f8f9fa!important">
                                
                                <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>'  runat="server" style="width: 100%;height:379px;border-radius:14px;" allowfullscreen></iframe>

                                <div class="carousel-caption d-sm-block SectorBackgoundColor mx-auto w-25  mb-0 text-center pt-2" style="top:340px;height:5%;padding:0;border-radius:14px" >
                                    <asp:Label ID="Label7" runat="server"  Text='<%#  Convert.ToString(Container.ItemIndex+1)+"   /  "+ GlobeVideoRows %>'></asp:Label>
                                    
                                   
                                </div>
                                
                                <div class=" d-sm-block  text-right mx-auto w-75 pt-5 mb-5 mt-0 pb-3 pr-4" style="height:auto;background-color: #d9d9d9;border-radius:0 0 14px 14px;" >
                                    
                                    <h3 class="font-programs-paragraph-header-Culture SectorColor mt-0">
                                       <asp:Label ID="Label8" runat="server"  Text='<%#Eval("Title")%>'></asp:Label>
                                       
                                    </h3>
                                    <p class="font-projects-paragraph">
                                       <asp:Label ID="Label9" runat="server" Text='<%#Eval("Details")%>' ></asp:Label>
                                       
                                    </p>
                                    
                                </div>
                                
                            </div>
                              
                                    
                        </ItemTemplate>
                    </asp:Repeater>


                </div>

               
                <a class="left carousel-control pt-5 mySlidesOfProjects" style="height:375px;border-radius:14px;" href="#myCarouselVideo" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left " ></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control pt-5 mySlidesOfProjects" style="height:375px;border-radius:14px;" href="#myCarouselVideo" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right "  ></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
          </div>



      </div>

    <hr class="featurette-divider" />--%>
   

  </div><!-- /.container -->
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
  
</asp:Content>
