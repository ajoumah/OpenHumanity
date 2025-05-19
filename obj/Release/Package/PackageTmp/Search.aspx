<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Onder1.Search" %>
<%@ Register Src="~/UserControls/Pager.ascx" TagPrefix="uc1" TagName="Pager" %>
<%@ Register Src="~/UserControls/SearchBox.ascx" TagPrefix="uc1" TagName="SearchBox" %>
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
        <div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 ">
            <uc1:SearchBox runat="server" ID="SearchBox" class="w-25"/>
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
            <asp:Repeater ID="NewsSearchRepeater" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound"  >
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
     <div class="container bg-faded bg-light">
       <div class="  text-center ">
             <uc1:Pager runat="server" ID="BottomPager" Visible="False" />
         </div>
         
        <hr class="featurette-divider" />
        </div>

</asp:Content>
