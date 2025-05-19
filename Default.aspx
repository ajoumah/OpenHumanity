<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Onder1.Default" EnableViewState="false"%>

<%@ Register src="UserControls/ImageDisplayControl.ascx" tagname="ImageDisplayControl" tagprefix="uc1" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title></title>
    
    <link rel="stylesheet" href="Content/bootstrap2.min.css"/>

    <script src="Scripts/3.4.1/jquery.min.js"></script>
  
    <script src="Scripts/1.14.7/popper.min.js"></script>
  
    <script src="Scripts/4.3.1/bootstrap.min.js"></script>
    <!-- Bootstrap core CSS -->
   <link href="Content/bootstrap.min.css" rel="stylesheet"  />

    <!-- Default CSS -->
    <link href="Content/DefaultCss.css" rel="stylesheet"  />

    
    
    <link href="Content/carousel.css" rel="stylesheet" />
    <style>
        .MultiCarousel {
            float: left;
            overflow: hidden;
            padding: 15px;
            width: 100%;
            position: relative;
        }

            .MultiCarousel .MultiCarousel-inner {
                transition: 1s ease all;
                float: left;
            }

                .MultiCarousel .MultiCarousel-inner .item {
                    float: left;
                }

                    .MultiCarousel .MultiCarousel-inner .item > div {
                        text-align: center;
                        padding: 1px;
                        /*margin: 1px;*/
                        background: #f1f1f1;
                        color: #666;
                    }

            .MultiCarousel .leftLst, .MultiCarousel .rightLst {
                position: absolute;
                border-radius: 50%;
                top: calc(50% - 20px);
            }

            .MultiCarousel .leftLst {
                left: 0;
            }

            .MultiCarousel .rightLst {
                right: 0;
            }

                .MultiCarousel .leftLst.over, .MultiCarousel .rightLst.over {
                    pointer-events: none;
                    background: #ccc;
                }

              /*.img-circle {
                 border-radius: 100%;
                 background:red;
                 width:8vw;
                 height:8vw;
              }*/
        .circle2 {
            background: #e1e6ea;
               }



        .sticky.is-sticky {
            position: fixed;
            left: 0;
            right: 0;
            top: 0;
            z-index: 1000;
            width: 100%;
        }


        nav {
            /*background: #eaebec;*/
            min-height: 85px;
        }
    </style>
    <style>
        .hexagon {
            position: relative;
            width:18.75em; /*300px;*/
            height:10.825625em; /*173.21px;*/
            background-color: #e1e6ea;/*#64C7CC;*/
            margin:5.4125em 0; /*86.60px 0;*/
        }

            .hexagon:before,
            .hexagon:after {
                content: "";
                position: absolute;
                width: 0;
                border-left: 9.375em solid transparent;/*150px*/
                border-right:9.375em  solid transparent;/*150px*/
            }

            .hexagon:before {
                bottom: 100%;
                border-bottom:5.4125em  solid #e1e6ea;/*#64C7CC;*//*86.60px*/
            }

            .hexagon:after {
                top: 100%;
                width: 0;
                border-top:5.4125em  solid #e1e6ea;/*#64C7CC;*//*86.60px*/
            }
    </style>
    
</head>
 <body>
    <form id="form1" runat="server">
        <header>
            <div class="container">
                
                <a class="navbar-brand mt-2" >
                    <img src="images/NewLogo.png" class="img-fluid " style="max-width: 100%;" alt="" />
                </a>
                <a class="navbar-brand mt-4 ml-0 pull-right">
                    <p class="font-style" style="text-align: right">
                        منظمة الروَّاد للتعاون و التنمية
                    <br />
                       
                        ISO 26000 : 2010
                        
                    
                
                    </p>
                    
                </a>
                <div class="d-flex flex-row-reverse pull-right col-12 justify-content-start mt-3" style="padding:0">
                        <ul class="d-flex flex-row-reverse list-inline pull-left mt-0 col-12 mr-auto  " style="text-align: right; direction: rtl;">
                            
                            <li class="list-inline-item" style="font-size:12px">
                                <a class="social-icon text-xs-center" target="_blank" href="#">
                                    <%--<img src="images/turkeyFlag.png" />--%>
                                    <span>Türkçe</span>
                                </a>

                            </li>

                            <li class="list-inline-item" style="font-size:12px">
                                <a class="social-icon text-xs-center" target="_blank" href="#">
                                    <%--<img src="images/UkFlag2.png" />--%>
                                    <span>English</span>
                                </a>

                            </li>
                            <li class="list-inline-item " style="font-size:12px;float:right;padding:0;margin:0;text-align:right">
                                <a class="social-icon text-xs-right" target="_blank" href="#" style="float:right;padding:0;margin:0;text-align:right">

                                    <%-- <img src="images/arabFlag.png" />--%>
                                    <span class="">عربي</span>

                                </a>

                            </li>
                        </ul>
                    </div>
  
  

            </div>
            <div class="container">
                
            </div>
        </header>
 <%--<nav class="navbar navbar-expand-lg bg-light justify-content-center">--%>
   <nav class="navbar navbar-expand-lg bg-light justify-content-center top-navbar" data-toggle="sticky-onscroll">                 
                   <div class="container"> 
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link" href="Default.aspx">الرئيسية</a>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="AboutUS.aspx" id="navbarDropdownMenuLink1"  aria-haspopup="true" aria-expanded="false">من نحن
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                
                                <a class="dropdown-item" href="AboutUS.aspx">الرؤية</a>
                                <a class="dropdown-item" href="AboutUS.aspx">الرسالة</a>
                                <a class="dropdown-item" href="AboutUS.aspx">القيم</a>
                               <a class="dropdown-item" href="AboutUS.aspx">الأهداف</a>
                                <a class="dropdown-item" href="AboutUS.aspx">ميثاق الشرف</a>
                            </div>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="Where-We-Work.aspx" id="navbarDropdownMenuLink2"  aria-haspopup="true" aria-expanded="false">أين نعمل
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                <a class="dropdown-item" href="Where-We-Work.aspx">سوريا</a>
                                <a class="dropdown-item" href="Where-We-Work.aspx">تركيا</a>
                                <a class="dropdown-item" href="Where-We-Work.aspx">لبنان</a>
                               
                            </div>
                        </li>
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="Default.aspx#whatWeWork" id="navbarDropdownMenuLink3"  aria-haspopup="true" aria-expanded="false">ماذا نعمل
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                <asp:LinkButton class="dropdown-item" ID="DropDownLearning"  runat="server" >قطاع التعليم </asp:LinkButton>
                                <asp:LinkButton class="dropdown-item" ID="DropDownCulture"  runat="server" >قطاع الثقافة </asp:LinkButton>
                                <asp:LinkButton class="dropdown-item" ID="DropDownSociety"  runat="server" >قطاع التنمية المجتمعية </asp:LinkButton>
                                <asp:LinkButton class="dropdown-item" ID="DropDownSport"  runat="server" >قطاع الرياضة </asp:LinkButton>
                                
                            </div>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">تقارير</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="ContactUs.aspx">اتصل بنا</a>
                        </li>
                    </ul>
                       </div>
                </nav>
<main role="main">
    
  <div class="container ">
  <div id="myCarousel" class="carousel slide" data-ride="carousel">
    <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
        <li data-target="#myCarousel" data-slide-to="3"></li>
        <li data-target="#myCarousel" data-slide-to="4"></li>
        <li data-target="#myCarousel" data-slide-to="5"></li>
    </ol>
    <div class="carousel-inner">
        <div class="carousel-item active">
            <img src="images/slider1.jpg" class="bd-placeholder-img" />

        </div>
        <div class="carousel-item">
            <img src="images/slider2.jpg" class="bd-placeholder-img" />

        </div>
        <div class="carousel-item">
            <img src="images/slider3.jpg" class="bd-placeholder-img" />

        </div>
        <div class="carousel-item">
            <img src="images/slider4.jpg" class="bd-placeholder-img" />

        </div>
        <div class="carousel-item">
            <img src="images/slider5.jpg" class="bd-placeholder-img" />

        </div>
        <div class="carousel-item">
            <img src="images/slider6.jpg" class="bd-placeholder-img" />

        </div>
    </div>
    <a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
      <span class="carousel-control-prev-icon" aria-hidden="true"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
      <span class="carousel-control-next-icon" aria-hidden="true"></span>
      <span class="sr-only">Next</span>
    </a>
  </div>
  </div>
  
         
    


   <div class="container bg-faded bg-light">
    <p class="text-center" id="slogan">نعمل معاً ... نرقى معاً</p>
    <div class="row">

        <div class="mx-auto w-75 p-3  text-center " id="middle">
           
            <p class="font-style-paragraph2">
                منظمة الروَّاد للتعاون والتنمية
                <br />
            </p>
            <p>
                منظمة إنسانية تنموية مسجلة في تركيا برقم 27-021-035
                <br />
                <br />
                يتركز عملها على خدمة الإنسانية عامة والمجتمع السوري خاصة
                <br />
                من خلال المساهمة في تلبية الاحتياجات الأساسية للعيش بكرامة
                <br />
                وتعزيز التعاون والشراكات وبناء القدرات وتمكين المرأة والشباب واليافعين كما تعمل على إطلاق البرامج والمشاريع الإنسانية والتنموية ودعمها وتنفيذها على الأراضي التركية والسورية في العديد من القطاعات أهمها التعليم والثقافة والتنمية المجتمعية والرياضة كما تلتزم المنظمة بالمبادئ العامة للعمل الإنساني وحقوق الإنسان واحترام الفئات المستهدفة وتعزيز قيم العمل الجماعي والتشاركي والتطوعي



            </p>
            <span id="whatWeWork"></span>
        </div>
        <div class="icon-bar  " >
                <a href="https://www.facebook.com/pcdhumanitarian/" ><img src='images/facebook.png' alt="facebook of Onder" class="gray-style" style="width:22px;height:22px"/></a>
                <a href="https://twitter.com/pcdhumanitarian" ><img src='images/twitter.png' alt="twitter of Onder" class="gray-style" style="width:22px;height:22px"/></a>
                <a href="https://www.youtube.com/channel/UCV1knLQAouEJZ2l7OpQVCEQ/featured" ><img id="youtubeimg" src='images/youtube.png' alt="youtube of Onder" class="gray-style" style="width:22px;height:22px" /></a>
                <a href="https://www.instagram.com/pcdhumanitarian9" ><img src='images/instagram.png' alt="instagram of Onder" class="gray-style" style="width:22px;height:22px"/></a>
            </div>
    </div>
    <hr />
    
    
  </div>
     
  <div class="container marketing bg-light" >
<div class="row " >
     <div class="mx-auto w-100 p-3   " style="" >
      <div class="col-lg-3 ">
          <div class="hexagon mx-auto   ">

              <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5   " style="height: 12em; width: 12em">


                 <p class="">

                    <asp:LinkButton class="" ID="LinkButtonLearning" runat="server" OnClick="LinkButtonLearning_Click">
                       <img class="bd-placeholder-img   "  width="55" height="62" src="images/learning.png" />
                       <p class="font-style-sectors">التعليم</p>

                    </asp:LinkButton>

                </p>

              </div>

          </div>
      </div>
      <div class="col-lg-3">
          <div class="hexagon mx-auto">
               <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5  img-circle circle2 " style="height: 12em; width: 12em">
              <p>
                  <asp:LinkButton class="" ID="LinkButtonCulture" runat="server">
                        <img class="bd-placeholder-img" width="55" height="62" src="images/eduction.png" />
                <p class="font-style-sectors">الثقافة</p>
                  </asp:LinkButton>
              </p>
           </div>
          </div>
      </div>
      <div class="col-lg-3">
          <div class="hexagon mx-auto">
            <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5  img-circle circle2 " style="height: 12em; width: 12em">
              <p>
                    <asp:LinkButton class="" ID="LinkButtonSociety" runat="server">
                        <img class="bd-placeholder-img"  width="72" height="50" src="images/society.png" />
                <p class="font-style-sectors">التنمية المجتمعية</p>
                    </asp:LinkButton>

                </p>
          </div>  
          </div>
      </div>
      <div class="col-lg-3">
          <div class="hexagon mx-auto">
           <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5  img-circle circle2 " style="height: 12em; width: 12em">
              <p>
                    <asp:LinkButton class="" ID="LinkButtonSport" runat="server">
                        <img class="bd-placeholder-img" width="55" height="62" src="images/sport.png" />
                <p class="font-style-sectors">الرياضة</p>
                    </asp:LinkButton>

                </p>
       </div>
          </div>
      </div>
     </div>
 </div>
    <!-- Three columns of text below the carousel -->
    <%--<div class="row">
       
        <div class="mx-auto w-100 p-3  text-center " >
            <div class="col-lg-3 ">
            <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5  img-circle circle2 " style="height:12em;width:12em" >
                
               
                <p class="">

                    <asp:LinkButton class="" ID="LinkButtonLearning" runat="server" OnClick="LinkButtonLearning_Click">
                       <img class="bd-placeholder-img   "  width="55" height="62" src="images/learning.png" />
                       <p class="font-style-sectors">التعليم</p>

                    </asp:LinkButton>

                </p>
                   
            </div>
                </div> 
            <div class="col-lg-3">
                <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5  img-circle circle2 " style="height:12em;width:12em" >
                <p>
                    <asp:LinkButton class="" ID="LinkButtonCulture" runat="server">
                        <img class="bd-placeholder-img" width="55" height="62" src="images/eduction.png" />
                <p class="font-style-sectors">الثقافة</p>
                    </asp:LinkButton>
                </p>
                    </div>
            </div>
            <div class="col-lg-3">
                <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5  img-circle circle2 " style="height:12em;width:12em" >
                <p>
                    <asp:LinkButton class="" ID="LinkButtonSociety" runat="server">
                        <img class="bd-placeholder-img"  width="72" height="62" src="images/society.png" />
                <p class="font-style-sectors">التنمية المجتمعية</p>
                    </asp:LinkButton>

                </p>
                    </div>
            </div>
            
            <div class="col-lg-3">
                <div class="mx-auto    text-center pl-5 pr-5 ml-5 pt-5  img-circle circle2 " style="height:12em;width:12em" >
                
               <p>
                    <asp:LinkButton class="" ID="LinkButtonSport" runat="server">
                        <img class="bd-placeholder-img" width="55" height="62" src="images/sport.png" />
                <p class="font-style-sectors">الرياضة</p>
                    </asp:LinkButton>

                </p>
                    </div>
            </div>
           
        </div>
    </div>--%>
      <!-- /.row -->


    <!-- START THE FEATURETTES -->

    <hr class="featurette-divider" />
      <div class="container bg-faded bg-light">
          <p class="text-center font-style-news-header">
             
               <asp:LinkButton class="text-right display-4 SectorColor" ID="LinkButtonNews"  runat="server"  > آخر الأخبار</asp:LinkButton>
          </p>
          

          <div class="row">
             
                  <asp:Repeater ID="SportNewsRepeater" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound">
                      <ItemTemplate>
                          <div class="col-xl-3 col-lg-12  col-md-12 col-sm-12 pull-right">
                              <div class="card " style="border-radius: 14px 14px 0 0;">
                                  <div class="">

                                      <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" Width="100%" Height="181" Style="border-radius: 14px;" />
                                      <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor" width="100%" height="181" style="border-radius: 14px; display: none;" allowfullscreen></iframe>


                                  </div>
                                  <div class="pt-2 pr-4 text-right border-bottom font-news-paragraph-header" style="direction: rtl">

                                      <asp:Label ID="Label2" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
                                  </div>
                                  <div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="border-right border-left  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:40%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="" style="display: inline-block;width:60%">
                                                  <span class="row border-bottom" style="margin-left:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0" ><%#Eval("Program" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="border-right border-left  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:40%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="" style="display: inline-block;width:60%">
                                                  <span class="row border-bottom" style="" ><%#Eval("Sector" )%> </span>
                                                  <span class="row border-bottom " style="" ><%#Eval("Program" )%> </span>
                                                  <span class="row border-bottom " style=""><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>--%>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                        <div class="  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:35%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="border-right border-left" style="display: inline-block;width:65%">
                                                  <span class="col-12 border-bottom" style="padding-left:0;padding-right:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0" ><%#Eval("Program" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>--%>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label3" runat="server" Text='<%#Eval("Details")%>'></asp:Label>
                                  </div>--%>
                                  <div class="card-body  text-right border-bottom" style="direction: rtl; display: flex">
                                      <p class=" ">
                                          <%#Eval("Details")%>
                                          <a class=" SectorColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>
                                      <%--<p class=" ">
                                          <%#Eval("Details")%>
                                          <a class="btn more-news btn-xs SectorBackgoundColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white; display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>--%>
                                  </div>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white" role="button">المزيد  &raquo;</a></p>
                                  </div>--%>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label4" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                                  </div>--%>
                              </div>
                          </div>
                      </ItemTemplate>
                  </asp:Repeater>
             
              
                  <asp:Repeater ID="SocietyNewsRepeater" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound">
                      <ItemTemplate>
                          <div class="col-xl-3 col-lg-12  col-md-12 col-sm-12 pull-right">
                              <div class="card " style="border-radius: 14px 14px 0 0;">
                                  <div class="">

                                      <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" Width="100%" Height="181" Style="border-radius: 14px;" />
                                      <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor" width="100%" height="181" style="border-radius: 14px; display: none;" allowfullscreen></iframe>


                                  </div>
                                  <div class="pt-2 pr-4 text-right border-bottom font-news-paragraph-header" style="direction: rtl">

                                      <asp:Label ID="Label2" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
                                  </div>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">--%>
                                      <%--<p> Ok icon:</p>--%>
                                      <%--<p>
                                          <div class="  ">
                                              <span class="glyphicon glyphicon-dashboard col-2"></span>
                                              <asp:Label ID="Label1" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                              <%--<span class=" col-1">00963522545 </span>--%>
                                          <%--</div>
                                      </p>
                                  </div>--%>
                                  <div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="border-right border-left  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:40%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="" style="display: inline-block;width:60%">
                                                  <span class="row border-bottom" style="margin-left:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0" ><%#Eval("Program" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:35%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="border-right border-left" style="display: inline-block;width:65%">
                                                  <span class="col-12 border-bottom" style="padding-left:0;padding-right:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0" ><%#Eval("Program" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>--%>
                                  <div class="card-body  text-right border-bottom" style="direction: rtl; display: flex">
                                      <p class=" ">
                                          <%#Eval("Details")%>
                                          <a class=" SectorColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>
                                      <%--<p class=" ">
                                          <%#Eval("Details")%>
                                          <a class="btn more-news btn-xs SectorBackgoundColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white; display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>--%>
                                  </div>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label3" runat="server" Text='<%#Eval("Details")%>'></asp:Label>
                                  </div>--%>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white" role="button">المزيد  &raquo;</a></p>
                                  </div>--%>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label4" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                                  </div>--%>
                              </div>
                          </div>
                      </ItemTemplate>
                  </asp:Repeater>
             
                  <asp:Repeater ID="CultureNewsRepeater" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound">
                      <ItemTemplate>
                          <div class="col-xl-3 col-lg-12  col-md-12 col-sm-12 pull-right">
                              <div class="card " style="border-radius: 14px 14px 0 0;">
                                  <div class="">

                                      <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" Width="100%" Height="181" Style="border-radius: 14px;" />
                                      <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor" Width="100%" height="181" style="border-radius: 14px; display: none;" allowfullscreen></iframe>


                                  </div>
                                  <div class="pt-2 pr-4 text-right border-bottom font-news-paragraph-header" style="direction: rtl">

                                      <asp:Label ID="Label2" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
                                  </div>
                                  <div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="border-right border-left  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:40%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="" style="display: inline-block;width:60%">
                                                  <span class="row border-bottom" style="margin-left:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0" ><%#Eval("Program" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="border-right border-left  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:35%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="" style="display: inline-block;width:65%">
                                                  <span class="col-12 border-bottom" style="padding-left:0;padding-right:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0" ><%#Eval("Program" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>--%>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      <p>
                                          <div class="  ">
                                              <span class="glyphicon glyphicon-dashboard col-2"></span>
                                              <asp:Label ID="Label1" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                             
                                          </div>
                                      </p>
                                  </div>--%>
                                  <div class="card-body  text-right border-bottom" style="direction: rtl; display: flex">
                                      <p class=" ">
                                          <%#Eval("Details")%>
                                          <a class=" SectorColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>
                                      <%--<p class=" ">
                                          <%#Eval("Details")%>
                                          <a class="btn more-news btn-xs SectorBackgoundColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white; display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>--%>
                                  </div>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label3" runat="server" Text='<%#Eval("Details")%>'></asp:Label>
                                  </div>--%>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white" role="button">المزيد  &raquo;</a></p>
                                  </div>--%>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label4" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                                  </div>--%>
                              </div>
                          </div>
                      </ItemTemplate>
                  </asp:Repeater>
              
                  <asp:Repeater ID="LearningNewsRepeater" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound">
                      <ItemTemplate>
                          <div class="col-xl-3 col-lg-12  col-md-12 col-sm-12 pull-right">
                              <div class="card " style="border-radius: 14px 14px 0 0;">
                                  <div class="">

                                      <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" Width="100%" Height="181" Style="border-radius: 14px;" />
                                      <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor" width="100%" height="181" style="border-radius: 14px; display: none;" allowfullscreen></iframe>


                                  </div>
                                  <div class="pt-2 pr-4 text-right border-bottom font-news-paragraph-header" style="direction: rtl">

                                      <asp:Label ID="Label2" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
                                  </div>
                                  <div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="border-right border-left  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:40%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="" style="display: inline-block;width:60%">
                                                  <span class="row border-bottom " style="margin-left:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0" ><%#Eval("Program" )%> </span>
                                                  <span class="row border-bottom " style="margin-left:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="  " style="display:flex">
                                               <div class=" mt-3" style="display: inline-block;width:35%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="border-right border-left" style="display: inline-block;width:65%">
                                                  <span class="col-12 border-bottom" style="padding-left:0;padding-right:0" ><%#Eval("Sector" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0" ><%#Eval("Program" )%> </span>
                                                  <span class="col-12 border-bottom " style="padding-left:0;padding-right:0"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>--%>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      <p>
                                          <div class="col-12  " style="display:flex">
                                               <div class="" style="display: inline-block;width:100%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label1" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                                   <div class="" style="display: inline-block;">
                                                  <span class="col-12 border-bottom"><%#Eval("Sector" )%> </span>
                                                  <span class="col-12 border-bottom "><%#Eval("Program" )%> </span>
                                                  <span class="col-12 border-bottom "><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      </p>
                                  </div>--%>
                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      
                                          <div class="  " style="display:flex">
                                               <div class="mt-3" style="display: inline-block;width:100%">
                                              <span class="glyphicon glyphicon-dashboard col-12" style="display: inline-block;"></span>
                                              <asp:Label ID="Label3" class="" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>' style="display: inline-block;"></asp:Label>
                                              </div>
                                              <div class="" style="display: inline-block;">
                                                  <span class="col-12 border-bottom" style="width:100%"><%#Eval("Sector" )%> </span>
                                                  <span class="col-12 border-bottom " style="width:100%"><%#Eval("Program" )%> </span>
                                                  <span class="col-12 border-bottom " style="width:100%"><%#Eval("Project" )%> </span>
                                              </div>
                                          </div>
                                      
                                  </div>--%>

                                  <%--<div class=" text-right border-bottom" style="direction: rtl">
                                     
                                      <p>
                                          <div class="  ">
                                              <span class="glyphicon glyphicon-dashboard col-2"></span>
                                              <asp:Label ID="Label1" runat="server" Text='<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                             
                                          </div>
                                      </p>
                                  </div>--%>
                                  <div class="card-body  text-right border-bottom" style="direction: rtl; display: flex">
                                      <p class=" ">
                                          <%#Eval("Details")%>
                                          <a class=" SectorColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>
                                      <%--<p class=" ">
                                          <%#Eval("Details")%>
                                          <a class="btn more-news btn-xs SectorBackgoundColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white; display: inline-block;" role="button">المزيد  &raquo;</a>

                                      </p>--%>
                                  </div>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label3" runat="server" Text='<%#Eval("Details")%>'></asp:Label>
                                  </div>--%>
                                  <%--<div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color: white" role="button">المزيد  &raquo;</a></p>
                                  </div>--%>
                                 <%-- <div class="card-body  text-right border-bottom" style="direction: rtl">

                                      <asp:Label ID="Label4" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                                  </div>--%>
                              </div>
                          </div>
                      </ItemTemplate>
                  </asp:Repeater>
             
        </div>
          

      </div>
    

    <hr class="featurette-divider" />
      <div class="container bg-faded bg-light">
          <p class="text-center font-style-news-header">
             
               <asp:LinkButton class="text-right display-4 SectorColor" ID="LinkButtonImageGallery"  runat="server"  >معرض الصور</asp:LinkButton>
          </p>
          <div class="row">
              <uc1:ImageDisplayControl ID="ImageDisplayControl1" runat="server" />
          </div>



      </div>
    

    <hr class="featurette-divider" />

    <div class="container bg-faded bg-light">
          <p class="text-center font-style-news-header">
             
               <asp:LinkButton class="text-right display-4 SectorColor" ID="LinkButtonVideoGallery"  runat="server"  >معرض الفيديو</asp:LinkButton>
          </p>
          
         <div class="container" ID="ContainerVideo1" runat="server" >
    <asp:Panel ID="Panel1" runat="server" CssClass="BorderSectorColor" style="height: 165px;border-radius: 10px;">
        <%--<div class="row" style="border-radius: 10px;border:2px solid black" >--%>
            <div class="MultiCarousel" data-items="1,3,5,6" data-slide="1" id="MultiCarousel" data-interval="1000" style="border-radius: 10px;padding:5px"  >
                <div class="MultiCarousel-inner" style="height: 150px;border-radius: 10px;"  >
                    
                    <asp:Repeater ID="VideoRepeater" runat="server"   >
                <ItemTemplate >
                    <div class="item col-2" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                             <%--<img src="images/1.png" style="width:100%;height: 100%"  />--%>
                             <%--<asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" style="width:100%;height: 100%" />--%>
                             <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server"   style="width: 100%;height: 100%;border:2px solid #ff9102" allowfullscreen></iframe>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
                </div>
                <button class="btn  leftLst  SectorBackgoundColor" runat="server" onclick="return false;" ><</button>
                <button class="btn  rightLst SectorBackgoundColor"  onclick="return false;">></button>
            </div>
            
        <%--</div>--%>
      </asp:Panel>  
    </div>
    




      </div>

    <hr class="featurette-divider" />

    <!-- /END THE FEATURETTES -->

  </div><!-- /.container -->
  <!-- Footer -->
<footer class="page-footer font-small unique-color-dark">

  
    
  

  <!-- Footer Links -->
  <div class="container text-center text-md-left mt-5">

    <!-- Grid row -->
    <div class="row mt-3 p-5" id="footer-Wrapper">
        <div class="col mt-5 pull-right">

        
            <p class="mx-auto  p-3   text-left font-style-sectors" >اتصل بنا</p>
        <hr class="mx-auto  col-8 pull-left  text-left links-hr "  />
        <div class="w-100" id="contact-wrap">
        <p class="font-style-CallNumber">
          <i class="fas fa-home mr-3 "><img src="images/call.png" /></i>009  534 121 11 85</p>
        <p class="font-style-CallNumber">
          <i class="fas fa-envelope mr-3"><img src="images/call.png" /></i>009  534 121 11 85</p>
        <p class="font-style-CallNumber">
          <i class="fas fa-phone mr-3"><img src="images/envelope1.png" /></i> info@pcd-humanitarian.com</p>
        </div>

      </div>
      <!-- Grid column -->
      <div class="col mt-5 pull-right" >

        
          <div class="row  col" >
          <a class="" id="logo-footer">
                    <img src="images/onderFooter.png"  width="100%" height="100%" alt="Onder Organization" />
                </a>
              </div>
          <div class="row col">
          <ul class="list-unstyled list-inline text-center w-100">
              <li class="list-inline-item col-2">
                  <a class="" target="_self" href="#">
                      <img src="images/facebook.png"  class="gray-style" width="22" height="22"/>
                  </a>
              </li>
              <li class="list-inline-item col-2">
                  <a class="" target="_self" href="#">
                      <img src="images/twitter.png" class="gray-style" width="22" height="22" />
                  </a>
              </li>
              <li class="list-inline-item col-2">
                  <a class="" target="_self" href="#">
                      <img src="images/youtube.png" class="gray-style" width="22" height="16" />
                  </a>
              </li>
              <li class="list-inline-item col-2">
                  <a class="" target="_self" href="#">
                      <img src="images/instagram.png"  class="gray-style" width="22" height="22" />
                  </a>
              </li>
              
          </ul>
              </div>
    <!-- Social buttons -->
      </div>
      
      <div class="col mt-5 ">

        <!-- Links -->
        <p class="mx-auto  p-3   text-right font-style-sectors" >خريطة الموقع</p>
        <hr class="mx-auto  col-8 pull-right  text-right links-hr "  />
        <%-- mx-auto w-75 p-3  text-center--%>
          <%--mx-auto links-hr mx-auto w-75 p-3 mr-2--%>
        <div class="col-12">
            <!-- method 1 - sizing classes -->
            <div class="list-group d-flex flex-row flex-wrap ">
                <a href="AboutUS.aspx" class="list-group-item w-50 list-group-item-action">
                من نحن
              </a>
                <a href="Default.aspx" class="list-group-item w-50 list-group-item-action">
                الرئيسية
              </a>
                <a href="#alerts" class="list-group-item w-50 list-group-item-action">
               ماذا نعمل
              </a>
                <a href="Where-We-Work.aspx" class="list-group-item w-50 list-group-item-action">
                أين نعمل
              </a>
                <a href="ContactUS.aspx" class="list-group-item w-50 list-group-item-action">
                اتصل بنا
              </a>
                <a href="#alerts" class="list-group-item w-50 list-group-item-action">
                تقارير
              </a>
                
               
            </div>
        </div>
          
       
      </div>
      

    </div>
   

  </div>
  <!-- Footer Links -->

  <!-- Copyright -->
  <div class="footer-copyright text-center py-3">
      <p class="text-center">&copy; <%: DateTime.Now.Year %> - All rights reserved by Önder Organization</p>
  </div>
  <!-- Copyright -->

</footer>
<!-- Footer -->

  
</main>

    </form>
     <script src="Scripts/2.2.0/jquery-2.2.0.min.js" type="text/javascript"></script>  
    <script type="text/javascript">
        $(document).on('ready', function () {
            var itemsMainDiv = ('.MultiCarousel');
            var itemsDiv = ('.MultiCarousel-inner');
            var itemWidth = "";

            $('.leftLst, .rightLst').click(function () {
                var condition = $(this).hasClass("leftLst");
                if (condition)
                    click(0, this);
                else
                    click(1, this)
            });

            ResCarouselSize();




            $(document).resize(function () {
                ResCarouselSize();
            });

            //this function define the size of the items
            function ResCarouselSize() {
                var incno = 0;
                var dataItems = ("data-items");
                var itemClass = ('.item');
                var id = 0;
                var btnParentSb = '';
                var itemsSplit = '';
                var sampwidth = $(itemsMainDiv).width();
                var bodyWidth = $('body').width();
                $(itemsDiv).each(function () {
                    id = id + 1;
                    var itemNumbers = $(this).find(itemClass).length;
                    btnParentSb = $(this).parent().attr(dataItems);
                    itemsSplit = btnParentSb.split(',');
                    $(this).parent().attr("id", "MultiCarousel" + id);



                    if (bodyWidth >= 992) {
                        incno = itemsSplit[2];
                        itemWidth = sampwidth / incno;
                    }
                    else if (bodyWidth >= 768) {
                        incno = itemsSplit[1];
                        itemWidth = sampwidth / incno;
                    }
                    else {
                        incno = itemsSplit[0];
                        itemWidth = sampwidth / incno;
                    }
                    $(this).css({ 'transform': 'translateX(0px)', 'width': itemWidth * itemNumbers });
                    $(this).find(itemClass).each(function () {
                        $(this).outerWidth(itemWidth);
                    });

                    $(".leftLst").addClass("over");
                    $(".rightLst").removeClass("over");

                });
            }


            //this function used to move the items
            function ResCarousel(e, el, s) {
                var leftBtn = ('.leftLst');
                var rightBtn = ('.rightLst');
                var translateXval = '';
                var divStyle = $(el + ' ' + itemsDiv).css('transform');
                var values = divStyle.match(/-?[\d\.]+/g);
                var xds = Math.abs(values[4]);
                if (e == 0) {
                    translateXval = parseInt(xds) - parseInt(itemWidth * s);
                    $(el + ' ' + rightBtn).removeClass("over");

                    if (translateXval <= itemWidth / 2) {
                        translateXval = 0;
                        $(el + ' ' + leftBtn).addClass("over");
                    }
                }
                else if (e == 1) {
                    var itemsCondition = $(el).find(itemsDiv).width() - $(el).width();
                    translateXval = parseInt(xds) + parseInt(itemWidth * s);
                    $(el + ' ' + leftBtn).removeClass("over");

                    if (translateXval >= itemsCondition - itemWidth / 2) {
                        translateXval = itemsCondition;
                        $(el + ' ' + rightBtn).addClass("over");
                    }
                }
                $(el + ' ' + itemsDiv).css('transform', 'translateX(' + -translateXval + 'px)');
            }

            //It is used to get some elements from btn
            function click(ell, ee) {
                var Parent = "#" + $(ee).parent().attr("id");
                var slide = $(Parent).attr("data-slide");
                ResCarousel(ell, Parent, slide);
            }

        });
    </script>
     <script>


         // Sticky navbar
         // =========================
         $(document).ready(function () {
             // Custom function which toggles between sticky class (is-sticky)
             var stickyToggle = function (sticky, stickyWrapper, scrollElement) {
                 var stickyHeight = sticky.outerHeight();
                 var stickyTop = stickyWrapper.offset().top;
                 if (scrollElement.scrollTop() >= stickyTop) {
                     stickyWrapper.height(stickyHeight);
                     sticky.addClass("is-sticky");
                 }
                 else {
                     sticky.removeClass("is-sticky");
                     stickyWrapper.height('auto');
                 }
             };

             // Find all data-toggle="sticky-onscroll" elements
             $('[data-toggle="sticky-onscroll"]').each(function () {
                 var sticky = $(this);
                 var stickyWrapper = $('<div>').addClass('sticky-wrapper'); // insert hidden element to maintain actual top offset on page
                 sticky.before(stickyWrapper);
                 sticky.addClass('sticky');

                 // Scroll & resize events
                 $(window).on('scroll.sticky-onscroll resize.sticky-onscroll', function () {
                     stickyToggle(sticky, stickyWrapper, $(this));
                 });

                 // On page load
                 stickyToggle(sticky, stickyWrapper, $(window));
             });
         });
     </script>
    <%--<script src="Scripts/jquery-3.3.1.slim.min.js" ></script>--%>
      <%--<script>window.jQuery || document.write('<script src="/docs/4.3/assets/js/vendor/jquery-slim.min.js"><\/script>')</script><script src="/docs/4.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-xrRywqdh3PHs8keKZN+8zzc5TX0GRTLCcmivcbNJWm2rs5C8PRhcEn3czEjhAO9o" crossorigin="anonymous"></script>--%>
    
</body>
</html>
