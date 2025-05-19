<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="AboutUS2.aspx.cs" Inherits="Onder1.AboutUS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>من نحن</title>
    <link href="content/style.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
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
     <div id="background-About-Us">
        
        
        <div id="allcontent">
            <section id="topSection">
                <div id="motto-topSection">
                    <h1 class="font-style-motto-About-Us" id="startOfLetter">نعمل معاً ... نرقى معاً</h1>
                    <hr class="new4-About-Us" />
                </div>
                <div id="vision-div">
                    <div class="forImage">
                        <h1 class="font-style-image-About-Us">تسجيل المنظمة في تركيا</h1>
                        <img src="images/issue.png" alt="sport" />

                    </div>
                    <div class="vision-div-p1">
                        <h1 class="font-news-paragraph-header-About-Us">الرؤية</h1>
                        <p class="font-news-paragraph-About-Us" id="beforLetter">
                            أن نكـــون منظمـــة إنســـانية رائـــدة في خدمـــة المجتمـــع والتخفيف مـــن آلامه
                            وتعزيـــز آمالـــه الإنســـانية والحضارية
                        </p>

                    </div>

                    <div class="vision-div-p1" id="letter-About-Us">
                        <h1 class="font-news-paragraph-header-About-Us" style="margin-bottom:15px">الرسالة</h1>
                        <p class="font-news-paragraph-About-Us" id="beforBehavior"  style="margin-top:15px">
                            معاً ...بالحوكمـــة والإدارة الرشـــيدة الكفوءة نحو إســـهام فعـــال في تحقيق التنميـــة المســـتدامة
                            بأبعادها التعليميـــة والثقافية والتنمويـــة والرياضية بما يعزز الأمن والاســـتقرار وبناء السلام
                        </p>
                    </div>

                    <div class="vision-div-p1" id="behavior-About-Us">
                        <h1 class="font-news-paragraph-header-About-Us">القيم</h1>
                        <ul class="font-news-paragraph-About-Us" id="behaviorList">
                            <li>الأخلاق الحسنة</li>
                            <li>المسؤولية المجتمعية</li>
                            <li>العدالة والنزاهة</li>
                            <li>الجودة والاتقان</li>
                            <li>الشفافية والمساءلة</li>
                            <li>التشاركية والعمل بروح الفريق</li>
                        </ul>
                    </div>
                    <div class="forImage">
                        <h1 class="font-style-image-About-Us2">شهادة جودة المشاركة المجتمعية</h1>
                        <img src="images/ISO.png" alt="sport" id="startOfGoal" />
                    </div>
                    <div class="vision-div-p1" id="end-letter-About-Us">
                        <hr class="new4-About-Us2" />
                    </div>
                    <!--<div class="vision-div-p1">
                        <hr class="new4-About-Us2" />
                    </div>-->
                    <div class="icon-bar">
                        <a href="https://www.facebook.com/pcdhumanitarian/" class="facebook"><img src='images/facebook.png' alt="facebook of Onder" /></a>
                        <a href="https://twitter.com/pcdhumanitarian" class="facebook"><img src='images/twitter.png' alt="twitter of Onder" /></a>
                        <a href="https://www.youtube.com/channel/UCV1knLQAouEJZ2l7OpQVCEQ/featured" class="facebook"><img id="youtubeimg" src='images/youtube.png' alt="youtube of Onder" /></a>
                        <a href="https://www.instagram.com/pcdhumanitarian9" class="facebook"><img src='images/instagram.png' alt="instagram of Onder" /></a>
                    </div>
                    <div class="vision-div-p2" id="goals-About-Us">
                        <h1 class="font-news-paragraph-header-About-Us">الأهداف</h1>
                        <ol class="font-news-paragraph-About-Us" id="goalList">
                            <li>
                                المساهمة ... في نشر ثقافة و قواعد العمل الإنساني و التطوعي في المجتمع
                                وإبراز  دور المنظمات الإنسانية كشريك أساسي وفاعل لتحقيق التنمية ( الريفية و الحضرية ) المستدامة .
                            </li>
                            <li>المساهمة ... في تيسير الإندماج الإيجابي للسوريين في المجتمعات المضيفة . </li>
                            <li>
                                المساهمة ... في تطوير الأداء المؤسسي وبناء القدرات للمنظمات الإنسانية وللمؤسسات  المجتمعية و الحكومية بما يعزز المشاركة
                                والمسؤولية المجتمعية.
                            </li>
                            <li>المساهمة ... في تعزيز الأمن و الإستقرار  المجتمعي وتوفير فرص العمل لتحقيق التنمية وبناء الشراكات لتحقيق السلام و إعادة الإعمار.</li>
                            <li>المساهمة ... في إطلاق و تفعيل برامج حماية الأطفال بأبعادها النفسية و التربوية و السلوكية و التنموية وتحفيز قدراتهم الإبداعية.</li>
                            <li id="startOfHonour">المساهمة ... في بناء قدرات اليافعين و الشباب و تنمية مهاراتهم الحياتية و خلق روح التعاون والإبتكار و المشاركة المجتمعية الفاعلة. </li>
                            <li>المساهمة ... في تفعيل الدور المجتمعي للمرأة بتنمية قدراتها وتمكينها وإبراز إنجازاتها وتعزيز مشاركتها.</li>
                            <li>المساهمة ... في إطلاق برامج الرعاية المجتمعية  للأيتام والمسنين.</li>
                            <li>المساهمة ... في تطوير البرامج و المشاريع و الفعاليات التعليمية والثقافية والتنموية والرياضية. </li>
                            <li>المساهمة ... في تعزيز الوعي البيئي وزيادة المساحات الخضراء .</li>
                        </ol>
                    </div>
                    <div class="vision-div-p1" id="end-goals-About-Us">
                        <hr class="new4-About-Us2" />
                    </div>
                    <div class="vision-div-p2" id="Honour-About-Us">
                        <h1 class="font-news-paragraph-header-About-Us">ميثاق الشرف</h1>
                        <h1 class="font-news-paragraph-header-About-Us2">منظمة مجتمع مدني – غير حكومية – غير ربحية</h1>
                        <ul class="font-news-paragraph-About-Us" id="HonourList">
                            <li>تتبنى منظمة الرواد للتعاون والتنمية في فكرها وبرامجها ومشاريعها المبادئ والقيم والسياسات الإنسانية المنسجمة مع مبادئ العمل الإنساني وحقوق الانسان والمواثيق العامة للمنظمات الدولية التي تؤطر العلاقة مع أصحاب المصلحة، وذلك لخدمة الإنسانية عامةً والمجتمع السوري خاصة ، دون تمييز  عنصري أو عرقي أو ديني أو قومي ، والمساهمة في الاستجابة للاحتياجات الإنسانية الأساسية، وتوفيـر سبل العيش اللائق بما يحترم حرية الانسان وكرامته، والسعي الدائم لبناء وتطوير الموارد والقدرات وترشيدها وتكريمها، لتحقيق تنمية مجتمعية مستدامة بأبعادها الإنسانية والأخلاقية والقانونية والتعليمية والثقافية والاجتماعية والاقتصادية والبيئية، وعليه : </li>
                            <li><span class="firstWord">تتبنى</span> منظمة الرواد للتعاون والتنمية في فكرها وبرامجها ومشاريعها المبادئ والقيم والسياسات الإنسانية المنسجمة مع مبادئ العمل الإنساني وحقوق الانسان والمواثيق العامة للمنظمات الدولية التي تؤطر العلاقة مع أصحاب المصلحة، وذلك لخدمة الإنسانية عامةً والمجتمع السوري خاصة ،  </li>
                            <li><span class="firstWord">تلتـزم</span> المنظمة باحتـرام الشرائع السماوية، والقوانيـن الوطنية، والميثاق العالمي للأمم المتحدة، والمبادئ العامة لحقوق الانسان، ومبادئ العمل الإنساني، ومدونات السلوك الأخلاقي، والمساواة، وعدم التحيز، وعدم التمييـز، على أساس الجنس أو الدين أو العرق، للفئات المستهدفة، وحل المظالم، ورد الحقوق، وحفظها. </li>
                            <li><span class="firstWord">تلتـزم</span> المنظمة بتعزيز المسؤولية المجتمعية وتحسين ممارساتها، وإدماجها في مدونات المنظمة ومكوناته وشراكاتها، وتفعيل قيم العمل الجماعي والتشاركية، والسعي لما هو في صالح رفاهية المجتمع والارتقاء بالإنسان.</li>
                            <li><span class="firstWord">تراعي</span> المنظمة مبدأ الاستقلالية، والحياد عن أي أيديولوجيا أو حزبية في برامجها، ومشاريعها الإنسانية. </li>
                            <li><span class="firstWord">تتبنى</span> المنظمة مفاهيم الحوكمة المؤسساتية، واجراءاتها، والممارسات العمالية وممارسات التشغيل العادلة، والمشاركة في اتخاذ القرارات، بين الإدارة، وفرق العمل، والمستفيدين، وتوفير فرص التأهيل، والتدريب، داخل المنظمة وخارجها، وفق رؤية تنموية مستدامة، نحو مجتمع اقتصادي بنيوي ومعرفي. </li>
                            <li><span class="firstWord">تلتـزم</span> المنظمة بتبني قيم الشفافية والافصاح والنزاهة والمصداقية والمساءلة والمحاسبة، واعداد التقارير الإدارية، والمالية، وعرضها وفق المبادئ المهنية المقبولة عموماً، وكل ما يرعى حقوق أصحاب المصلحة ويحميهما.</li>
                            <li><span class="firstWord">تسعى</span> المنظمة إلى تحقيق إدارة الجودة والتحسين المستمر والإنتاجية، وتوظيفها وفق معايير التنافسية والتميـز في الأداء على مستوى البيئة الداخلية والخارجية، لتحقيق الرضى الوظيفي، وتطوير المهارات والكفاءات. </li>
                            <li><span class="firstWord">تعمــل</span> المنظمة على تعزيز ثقافة العمل الإنساني التطوعي، والتوعية والتربية السليمة، وبناء الشراكات المجتمعية الإيجابية، وإشراك المجتمع المحلي، والاستثمار الاجتماعي التنموي، في التعليم والثقافة والاقتصاد.</li>
                            <li><span class="firstWord">تعمـــل</span> المنظمة على التعاون والتنسيق الاستراتيجي مع الحكومات والمنظمات والمؤسسات ذات العلاقة. </li>
                            <li><span class="firstWord">تعمل</span> المنظمة على التعريف بحقوق المستهلك وحمايته وتحديد احتياجاته والاستجابة  المناسبة لتلبيتها.</li>
                            <li><span class="firstWord">تلتـزم</span> المنظمة بالمعايير البيئية، ومنع التلوث، والتخفيف من آثار   تغيـر المناخ، والاستخدام المستدام للموارد، وحماية البيئة والتنوع البيولوجي واستعادة المواطن الطبيعية.  </li>
                        </ul>

                    </div>
                    <div id="end-honour-About-Us" class="vision-div-p1">
                        <hr class="new4-About-Us2" />
                    </div>
                    <div class="clear"></div>
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
    <script>
        // Select all links with hashes
        $('a[href*="#"]')
          // Remove links that don't actually link to anything
          .not('[href="#"]')
          .not('[href="#0"]')
          .click(function (event) {
              // On-page links
              if (
                location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '')
                &&
                location.hostname == this.hostname
              ) {
                  // Figure out element to scroll to
                  var target = $(this.hash);
                  target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
                  // Does a scroll target exist?
                  if (target.length) {
                      // Only prevent default if animation is actually gonna happen
                      event.preventDefault();
                      $('html, body').animate({
                          scrollTop: target.offset().top
                      }, 1000, function () {
                          // Callback after animation
                          // Must change focus!
                          var $target = $(target);
                          $target.focus();
                          if ($target.is(":focus")) { // Checking if the target was focused
                              return false;
                          } else {
                              $target.attr('tabindex', '-1'); // Adding tabindex for elements not focusable
                              $target.focus(); // Set focus again
                          };
                      });
                  }
              }
          });

    </script>
</asp:Content>
