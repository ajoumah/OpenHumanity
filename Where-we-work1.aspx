<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="Where-we-work1.aspx.cs" Inherits="Onder1.Where_we_work" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>من نحن</title>
    <link href="content/style.css" rel="stylesheet" type="text/css" />
    <script src="jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="background-NewMap">
        
        <div class="allcontent-NewMap">



            <section class="topSection-NewMap">


                <div class="container-SingleNews">
                    <div id="syria-map">
                        <h1 class="font-style-motto-About-Us">سوريا</h1>
                        <hr class="new4-About-Us" />
                        <p class="font-news-paragraph-About-Us">
                            وتأتي هذه الدورة لمساعدة السيدات السوريات في مدينة ادلب على توفير بعض المال لسد احتياجاتهن .حيث قامت المشرفات على الدورة بتدريب السيدات وعددهن ستة عشر سيدة على مكنات الخياطة . ومخرز الصوف . فيما كانت مخرجات الدورة تفصيل وخياطة فستان وقميص وتنورة وبنطلون . اضافة لبعض الأشغال الصوفية
                        </p>
                        <object id="Start-Of-Turkey" type="image/svg+xml" data="images/SyriaV.svg" class="obj-svg"></object>
                    </div>
                    <div class="icon-bar">
                        <a href="https://www.facebook.com/pcdhumanitarian/" class="facebook"><img src='images/facebook.png' alt="facebook of Onder" /></a>
                        <a href="https://twitter.com/pcdhumanitarian" class="facebook"><img src='images/twitter.png' alt="twitter of Onder" /></a>
                        <a href="https://www.youtube.com/channel/UCV1knLQAouEJZ2l7OpQVCEQ/featured" class="facebook"><img id="youtubeimg" src='images/youtube.png' alt="youtube of Onder" /></a>
                        <a href="https://www.instagram.com/pcdhumanitarian9" class="facebook"><img src='images/instagram.png' alt="instagram of Onder" /></a>
                    </div>
                    <div class="Header-image">
                        <div id="turkey-map">
                            <h1 class="font-style-motto-About-Us">تركيا</h1>
                            <hr class="new4-About-Us" />
                            <p class="font-news-paragraph-About-Us">
                                وتأتي هذه الدورة لمساعدة السيدات السوريات في مدينة ادلب على توفير بعض المال لسد احتياجاتهن .حيث قامت المشرفات على الدورة بتدريب السيدات وعددهن ستة عشر سيدة على مكنات الخياطة . ومخرز الصوف . فيما كانت مخرجات الدورة تفصيل وخياطة فستان وقميص وتنورة وبنطلون . اضافة لبعض الأشغال الصوفية
                            </p>

                            <object id="Start-Of-Lebanon" type="image/svg+xml" data="images/turkey.svg" class="obj-svg-turkey"></object>
                        </div>

                        <div class="content-Of-SingleNews">
                            <div id="lebanon-map">
                                <h1 class="font-style-motto-About-Us">لبنان</h1>
                                <hr class="new4-About-Us" />
                                <p class="font-news-paragraph-About-Us">
                                    وتأتي هذه الدورة لمساعدة السيدات السوريات في مدينة ادلب على توفير بعض المال لسد احتياجاتهن .حيث قامت المشرفات على الدورة بتدريب السيدات وعددهن ستة عشر سيدة على مكنات الخياطة . ومخرز الصوف . فيما كانت مخرجات الدورة تفصيل وخياطة فستان وقميص وتنورة وبنطلون . اضافة لبعض الأشغال الصوفية
                                </p>
                                <object id="svg-object-Lebanon" type="image/svg+xml" data="images/lebanon.svg" class="obj-svg-lebanon"></object>
                            </div>
                        </div>

                    </div>
                    
                </div>

            </section>


        </div>

    </div>

    <script>
        window.onscroll = function () { myFunction() };

        var navbar = document.getElementById("header");
        var sticky = navbar.offsetTop;

        function myFunction() {
            if (window.pageYOffset >= sticky) {
                navbar.classList.add("sticky")
            } else {
                navbar.classList.remove("sticky");
            }
        }
    </script>
</asp:Content>
