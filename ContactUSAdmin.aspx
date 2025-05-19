<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="ContactUSAdmin.aspx.cs" Inherits="Onder1.ContactUSAdmin" %>
<%@ Register src="UserControls/UserInfo.ascx" tagname="UserInfo" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="Content/bootstrap2.min.css"/>

    <script src="Scripts/3.4.1/jquery.min.js"></script>
  
    <script src="Scripts/1.14.7/popper.min.js"></script>
  
    <script src="Scripts/4.3.1/bootstrap.min.js"></script>
    <!-- Bootstrap core CSS -->
   <link href="Content/bootstrap.min.css" rel="stylesheet"  />

    <!-- Default CSS -->
    <link href="Content/DefaultCss.css" rel="stylesheet"  />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
         <%--<uc1:UserInfo ID="UserInfo1" runat="server" class="w-25 pt-4 mt-4" />--%>
         <div class="container  mt-5 ">
     <div class="row mt-3 col-12 text-right" style="float:right" >
         <div class="w-25">
       <uc1:UserInfo ID="UserInfo1" runat="server" class="w-25 pt-4 mt-4" />
        </div>
         <div class="w-75">
        <p class="text-right display-4 SectorColor pt-5 pr-5" >اتصل بنا</p>
        </div>
     </div> 
        
         
         <%--<div class="row w-100 p-0 m-0 mb-5 border border-bottom-3 border-dark border-top-0 border-right-0 border-left-0 ">
            <uc1:SearchImageBox runat="server" ID="SearchImageBox" class="w-25" />
            <p class="w-75 align-content-end  text-right font-style-motto  ">
                <asp:Label ID="SectorNameLabel" runat="server" class=" SectorColor"></asp:Label>
            </p>

        </div>--%>
     
    <!-- Grid row -->
    <div class="row mt-3 p-5" id="">
        <div class="col mt-5 pull-right">

        
          
        <div class="w-100" id="contact-wrap">
         <p class="font-style-CallNumber">
          <i class="fas fa-phone mr-5"><img src="images/emailUs.png" /></i> info@pcd-humanitarian.com</p>
        <p class="font-style-CallNumber mt-5">
          <i class="fas fa-home mr-5 "><img src="images/pingUs.png" /></i>+(90) 555 055 37 45</p>
           
            <p class="font-style-CallNumber ">
                <i class=" mr-5 ">
                    <img src="images/locationUs.png" class="pt-0 mb-5" style="top:0"/>
                </i>
                <label class="pt-5">
                <span class="firstSentence d-inline-block " >Türkiye.Gaziantep İncilipInar Mah
                    <br />
                    ali Fuat Cebesoy Bulv,-/N:13, Şehitkamil

                </span>
                </label>
            </p>
           <p class="font-style-CallNumber ">
                <i class=" mr-5 ">
                    <img src="images/locationUs.png" class="pt-0 mb-5" style="top:0"/>
                </i>
                <label class="pt-3">
                <span class="firstSentence d-inline-block " >Türkiye.Gaziantep
                    <br />
                    İncili Pınar, 36013. Sk., 27090 Şehitkamil

                </span>
                </label>
            </p>
            <p class="font-style-CallNumber ">
                <i class=" mr-5 ">
                    <img src="images/locationUs.png" class="pt-0 mb-5" style="top:0"/>
                </i>
                <label class="pt-3">
                <span class="firstSentence d-inline-block " >Türkiye.Nizip/Gaziantep
                    <br />
                    Özel Emine Özyurt İlkokulu, Hazımoğlu, 27700

                </span>
                </label>
            </p>
            <p class="font-style-CallNumber ">
                <i class=" mr-5 ">
                    <img src="images/locationUs.png" class="pt-0 mb-5" style="top:0"/>
                </i>
                <label class="pt-3">
                <span class="firstSentence d-inline-block " >Türkiye.Nizip/Gaziantep
                    <br />
                   Hafızpaşa, Çeker Sk., 27700

                </span>
                </label>
            </p>
        </div>

      </div>
      <!-- Grid column -->
      <div class="col mt-5 pull-right container marketing bg-light" >
       
        <form class="">

	<div class="form-group"> <!-- Name field -->
		<label class="control-label pull-right" for="name">الاسم</label>
		<%--<input class="form-control" id="name" name="name" type="text" style="direction:rtl"/>--%>
        <asp:TextBox class="form-control" ID="TextBoxName" runat="server" style="direction:rtl"></asp:TextBox>
	</div>
	
	<div class="form-group"> <!-- Email field -->
		<label class="control-label requiredField pull-right" for="email">الايميل<span class="asteriskField">*</span></label>
		<%--<input class="form-control" id="email" name="email" type="text"/>--%>
         <asp:TextBox class="form-control" ID="TextBoxEmail" runat="server" style="direction:rtl"></asp:TextBox>
	</div>
	
	<div class="form-group"> <!-- Subject field -->
		<label class="control-label pull-right" for="subject">الموضوع</label>
		<%--<input class="form-control" id="subject" name="subject" type="text" style="direction:rtl"/>--%>
        <asp:TextBox class="form-control" ID="TextBoxSubject" runat="server" style="direction:rtl"></asp:TextBox>
	</div>
	
	<div class="form-group"> <!-- Message field -->
		<label class="control-label pull-right" for="message">الرسالة</label>
		<%--<textarea class="form-control" cols="40" id="message" name="message" rows="10" style="direction:rtl"></textarea>--%>
        <asp:TextBox class="form-control" ID="TextBoxMessage" runat="server" style="direction:rtl"  Height="300" TextMode="MultiLine"></asp:TextBox>
	</div>
	
	<div class="form-group  mt-5 pt-5">
		<%--<button class="btn  pull-right " name="submit" type="submit" style="background-color:#ff9102;color:white">ارسال</button>--%>
         <asp:LinkButton class="btn  pull-right " ID="LinkButtonNews"  runat="server"  style="background-color:#ff9102;color:white" OnClick="LinkButtonNews_Click">ارسال</asp:LinkButton>
	</div>
	
</form>	

    
      </div>
      
      
      

    </div>
   

  </div>
</asp:Content>
