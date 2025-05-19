<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="SearchImage.aspx.cs" Inherits="Onder1.SearchImage" %>
<%@ Register Src="~/UserControls/Pager.ascx" TagPrefix="uc1" TagName="Pager" %>
<%@ Register Src="~/UserControls/SearchImageBox.ascx" TagPrefix="uc1" TagName="SearchImageBox" %>
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
            <uc1:SearchImageBox runat="server" ID="SearchImageBox" class="w-25"/>
                                <p class="w-75 align-content-end  text-right font-style-motto  " style="direction:rtl">
                                    <asp:Label CssClass="CatalogTitle" ID="titleLabel" runat="server"></asp:Label>
                                    <br />
                                    <asp:Label CssClass="CatalogDescription" ID="descriptionLabel" runat="server"></asp:Label>
                                    <br />
                                </p>
             
                            </div>
          <div class="mt-5 mb-5">
                          <p class="w-100 align-content-end  text-right font-style-motto  " style="direction:rtl">
                                    <asp:Label  ID="noResultLabel" class="SectorColor" Visible="false" runat="server"></asp:Label>
                                    <br />
                                    
                                </p>
            <asp:Repeater ID="ImageRepeater" runat="server"  >
                <ItemTemplate  >
                    <div class="col-xl-4 col-lg-12  col-md-12 col-sm-12 pull-right mt-1 mb-1 " style="float:right;height:390px">
                        <div class="" >
                            <%--<div class="card" style="border-radius: 14px;">
                                
                                 <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" id="btnEditComment" Width="100%"  height="291px" style="border-radius: 14px;"   />
                               

                                
                                <div class="card-img-overlay pb-0 mb-0  d-flex justify-content-center align-items-end" >
                                    <p class="pr-5 pl-5 pb-0 mb-0  text-block SectorColor" style="background-color:white;border-radius:15px 15px 0px 0px;">
                                    <asp:Label ID="Label1" runat="server"  Text='<%#  Container.ItemIndex+1 %>'></asp:Label>
                                 
                                    </p>
                                </div>
                                  
                                
                            
                            
                        </div>--%>
                            <div class="imageselect  add-clearfix image-imagebox">
                                    <div class="">
                                        <article class="imagebox">
                                            <figure>
                                                 <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" id="btnEditComment" Width="100%"  height="291px" style="border-radius: 14px;"   />
                               
                                               
                                                <figcaption>
                                                    <h2 class="caption-title text-center">
                                                        <asp:Label ID="Label2" runat="server"  Text='<%#Eval("Title")%>'></asp:Label>

                                                    </h2>
                                                </figcaption>
                                            </figure>
                                        </article>
                                    </div>
                                </div>
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
