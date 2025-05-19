<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Onder1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
     
  <div class="container marketing bg-light">
  
    <!-- Three columns of text below the carousel -->
    <div class="row">
        <div class="mx-auto w-100 p-3  text-center " >
            <div class="col-lg-3">
                <img class="bd-placeholder-img"  width="55" height="62" src="images/learning.png" />
                <p class="font-style-sectors">التعليم</p>
                
                <p><a class="btn btn-secondary btn-sm" href="#" role="button">المزيد  &raquo;</a></p>
            </div>
            <div class="col-lg-3">
                <img class="bd-placeholder-img" width="55" height="62" src="images/eduction.png" />
                <p class="font-style-sectors">الثقافة</p>
                
                <p><a class="btn btn-secondary btn-sm" href="#" role="button">المزيد  &raquo;</a></p>
            </div>
            <div class="col-lg-3">
                <img class="bd-placeholder-img"  width="72" height="62" src="images/society.png" />
                <p class="font-style-sectors">التنمية المجتمعية</p>
                
                <p><a class="btn btn-secondary btn-sm" href="#" role="button">المزيد  &raquo;</a></p>
            </div>
            
            <div class="col-lg-3">
                <img class="bd-placeholder-img" width="55" height="62" src="images/sport.png" />
                <p class="font-style-sectors">الرياضة</p>
                
                <p><a class="btn btn-secondary btn-sm" href="#" role="button">المزيد &raquo; </a></p>
            </div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </div><!-- /.row -->


    <!-- START THE FEATURETTES -->

    <hr class="featurette-divider" />
      
    

    <hr class="featurette-divider" />
      <div class="container bg-faded bg-light">
          <p class="text-center font-style-news-header">معرض الصور</p>
          <div class="row">
          </div>



      </div>
    

    <hr class="featurette-divider" />

    <div class="container bg-faded bg-light">
          <p class="text-center font-style-news-header">معرض الفيديو والأخبار</p>
          <div class="row">
          </div>



      </div>

    <%--<hr class="featurette-divider" style="border-top: 1px solid black" />--%>

    <!-- /END THE FEATURETTES -->

  </div><!-- /.container -->
</asp:Content>
