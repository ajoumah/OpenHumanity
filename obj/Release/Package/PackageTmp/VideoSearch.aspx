<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="VideoSearch.aspx.cs" Inherits="Onder1.VideoSearch" %>
<%@ Register Src="~/UserControls/Pager.ascx" TagPrefix="uc1" TagName="Pager" %>
<%@ Register Src="~/UserControls/SearchVideoBox.ascx" TagPrefix="uc1" TagName="SearchVideoBox" %>


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
        .container {
            /*margin-top: 100px*/
        }

        .imageselect .imagebox {
            position: relative
        }

            .imageselect .imagebox figure {
                position: relative;
                overflow: hidden
            }

            .imageselect .imagebox figcaption {
                background: rgba(45, 62, 82, 0.9);
                position: absolute;
                left: 1px;
                right: 1px;
                bottom: 0px;
                padding: 10px;
                -webkit-transform: translateY(140%);
                -moz-transform: translateY(140%);
                -ms-transform: translateY(140%);
                -o-transform: translateY(140%);
                transform: translateY(140%);
                -moz-transition: -moz-transform 0.5s ease;
                -o-transition: -o-transform 0.5s ease;
                -webkit-transition: -webkit-transform 0.5s ease;
                -ms-transition: -ms-transform 0.5s ease;
                transition: transform 0.5s ease;
                border-radius: 14px;
            }

            .imageselect .imagebox .caption-title {
                margin-bottom: 0;
                color: #fff
            }

            .imageselect .imagebox .price {
                color: #fdb714
            }

            .imageselect .imagebox:hover figcaption {
                -webkit-transform: translateY(0);
                -moz-transform: translateY(0);
                -ms-transform: translateY(0);
                -o-transform: translateY(0);
                transform: translateY(0)
            }

        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container bg-faded bg-light">
                <div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 ">
                
                    <uc1:SearchVideoBox runat="server" id="SearchVideoBox" class="w-25" />
                                <p class="w-75 align-content-end  text-right font-style-motto  " style="direction:rtl">
                                    <asp:Label CssClass="CatalogTitle" ID="titleLabel" runat="server"></asp:Label>
                                    <br />
                                    <asp:Label CssClass="CatalogDescription" ID="descriptionLabel" runat="server"></asp:Label>
                                    <br />
                                </p>
             
                            </div>
          <div class="mt-5 mb-5">
              <p class="w-100 align-content-end  text-right font-style-motto  " style="direction: rtl">
                  <asp:Label ID="noResultLabel" class="SectorColor" Visible="false" runat="server"></asp:Label>
                  <br />

              </p>
            <asp:Repeater ID="VideoGalleryRepeater" runat="server"   >
                <ItemTemplate >
                    <div class=" col-xl-6 col-lg-12  col-md-12 col-sm-12 pull-right mt-5 mb-5" style="float:right;height:420px">
                        <div class=" " style="border-radius: 14px 14px 0 0;width:100%;float:right">
                            <div class="col-10" style="float:right;">
                                
                                
                                 <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor" height="311"  style="border-radius: 14px;width:100%" allowfullscreen></iframe> 
                                
                                <div class=" text-right border-bottom" style="direction:rtl">
                                 
                                <p >
                                    <div class="  ">
                                        <span class="glyphicon glyphicon-dashboard col-2"> </span>
                                        <asp:Label ID="Label1" runat="server"  Text = '<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                     
                                    </div>
                                </p>
                            </div>
                             <div class="pt-0 pr-4 text-right border-bottom font-news-paragraph-header" style="direction: rtl">

                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
                                </div>

                            </div>
                            <%--<div class="col-6" style="float:right;">
                                 <div class="pt-5 pr-4 text-right border-bottom font-news-paragraph-header" style="direction:rtl">
                               
                                <asp:Label ID="Label2" runat="server"  Text='<%#Eval("Title")%>'></asp:Label>
                            </div>
                              <div class=" text-right border-bottom" style="direction:rtl">
                                 
                                <p >
                                    <div class="  ">
                                        <span class="glyphicon glyphicon-dashboard col-2"> </span>
                                        <asp:Label ID="Label1" runat="server"  Text = '<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                     
                                    </div>
                                </p>
                            </div>
                                 <div class="card-body  text-right border-bottom" style="direction:rtl">
                                
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("Details")%>'></asp:Label>
                            </div>   
                               <div class="card-body  text-right border-bottom mb-5" style="direction:rtl">
                                
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                            </div>  
                                 
                                 
                          </div>--%>
                        </div>
                    </div>
                    
                </ItemTemplate>
            </asp:Repeater>

              

          </div>
         
   </div>  
     <div class="container bg-faded bg-light">
       <div class="  text-center ">
             <uc1:Pager runat="server" ID="BottomPager" Visible="False" />
         </div>
         
        <hr class="featurette-divider" />
        </div>
</asp:Content>
