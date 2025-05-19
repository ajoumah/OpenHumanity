<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsControl.ascx.cs" Inherits="Onder1.UserControls.NewsControl"  EnableViewState="false"%>
<div class="">
            <asp:Repeater ID="NewsRepeater" runat="server" OnItemDataBound="NewsRepeater_ItemDataBound"  >
                <ItemTemplate >
                    <div class="col-xl-3 col-lg-12  col-md-12 col-sm-12 pull-right">
                        <div class="card " style="border-radius: 14px 14px 0 0;">
                            <div class="">
                                
                                 <asp:Image ImageUrl='<%#Eval("NewsImage")%>' runat="server" ID="ImageNews" CssClass="BorderSectorColor" Width="100%" height="181" style="border-radius: 14px;"/>
                                 <iframe id="VideoFrame" src='<%#Eval("VideoUrl")%>' runat="server" class="BorderSectorColor"  Width="100%" height="181" style="border-radius: 14px;display:none;" allowfullscreen></iframe> 
                                
    
                            </div>
                            <div class="pt-2 pr-4 text-right border-bottom font-news-paragraph-header" style="direction:rtl">
                               
                                <asp:Label ID="Label2" runat="server"  Text='<%#Eval("Title")%>'></asp:Label>
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
                            <%--<div class=" text-right border-bottom" style="direction:rtl">
                                 
                                <p >
                                    <div class="  ">
                                        <span class="glyphicon glyphicon-dashboard col-2"> </span>
                                        <asp:Label ID="Label1" runat="server"  Text = '<%#Eval("Date", "{0:dd / MM / yyyy}") %>'></asp:Label>
                                    
                                    </div>
                                </p>
                            </div>--%>
                            <div class="card-body  text-right border-bottom" style="direction:rtl;display:flex">
                                <p class=" ">
                                    <%#Eval("Details")%>
                                    <a class=" SectorColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="display: inline-block;" role="button">المزيد  &raquo;</a>

                                </p>
                                <%--<p class=" ">
                                    <%#Eval("Details")%>
                                    <a class="btn more-news btn-xs SectorBackgoundColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color:white;display: inline-block;" role="button">المزيد  &raquo;</a>

                                </p>--%>
                                <%--<asp:Label ID="Label3" runat="server" Text='<%#Eval("Details")%>' style="display: inline-block;">

                                </asp:Label>
                                <p class="mt-5 "><a class="btn more-news btn-sm SectorBackgoundColor " href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color:white;display: inline-block;" role="button">المزيد  &raquo;</a></p>--%>
                            </div>
                            <%--<div class="card-body  text-right border-bottom" style="direction:rtl">--%>
                                
                                <%--<p><a class="btn more-news btn-sm SectorBackgoundColor" href='<%# Onder1.Class1.ToNews((Eval("NewsID").ToString()))%>' style="color:white" role="button">المزيد  &raquo;</a></p>--%>
                            <%--</div>--%>
                            <%--<div class="card-body  text-right border-bottom" style="direction:rtl">
                                
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("BelongsTo" )%>'></asp:Label>
                            </div>--%>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
</div>
