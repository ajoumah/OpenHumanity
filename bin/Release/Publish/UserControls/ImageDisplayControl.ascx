<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImageDisplayControl.ascx.cs" Inherits="Onder1.UserControls.ImageDisplayControl" EnableViewState="false" %>
   <%--<link rel="stylesheet" href="Content/bootstrap2.min.css" />--%>

   <%-- <script src="Scripts/3.4.1/jquery.min.js"></script>--%>

    <%--<script src="Scripts/1.14.7/popper.min.js"></script>--%>

    <%--<script src="Scripts/4.3.1/bootstrap.min.js"></script>--%>
    <!-- Bootstrap core CSS -->
    <%--<link href="Content/bootstrap.min.css" rel="stylesheet" />--%>
    <!--  -->
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
    </style>
<div class="container" ID="Container1" runat="server" >
    <asp:Panel ID="Panel1" runat="server" CssClass="BorderSectorColor" style="height: 165px;border-radius: 10px;">
        
            <div class="MultiCarousel" data-items="1,3,5,6" data-slide="1" id="MultiCarousel" data-interval="1000" style="border-radius: 10px;padding:5px"  >
                <div class="MultiCarousel-inner" style="height: 150px;border-radius: 10px;"  >
                    
                    <asp:Repeater ID="ImageRepeater" runat="server"   >
                <ItemTemplate >
                    <div class="item col-2" style="padding-left:2px;padding-right:2px;">
                        <div style="height: 150px;" >
                             <%--<img src="images/1.png" style="width:100%;height: 100%"  />--%>
                             <asp:Image ImageUrl='<%#Eval("SectorImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" style="width:100%;height: 100%" />
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
