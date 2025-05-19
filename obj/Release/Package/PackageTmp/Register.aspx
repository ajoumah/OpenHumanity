<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Onder1.Register3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts2/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts2/Linearicons-Free-v1.0.0/icon-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="css2/util.css">
    <link rel="stylesheet" type="text/css" href="css2/main.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-50">
                <form class="login100-form validate-form">
                    <span class="login100-form-title p-b-33">تسجيل مستخدم جديد 
                    </span>
                    <p>
                        <asp:Literal runat="server" ID="StatusMessage" />
                    </p>
                    <asp:PlaceHolder runat="server" ID="LoginForm">
                        <div class="wrap-input100 validate-input" data-validate="Valid email is required: ex@abc.xyz">


                            <asp:TextBox runat="server" class="input100" ID="UserName" placeholder="الاسم" style="direction: rtl" />
                            <span class="focus-input100-1"></span>
                            <span class="focus-input100-2"></span>
                        </div>



                        <div class="wrap-input100 rs1 validate-input" data-validate="يجب ادخال كلمة مرور">

                            <asp:TextBox runat="server" class="input100" ID="Password" TextMode="Password" placeholder="كلمة المرور" style="direction: rtl" />
                            <span class="focus-input100-1"></span>
                            <span class="focus-input100-2"></span>
                        </div>
                        <div class="wrap-input100 rs1 validate-input" data-validate="يجب تأكيد ادخال كلمة مرور">

                            <asp:TextBox runat="server" class="input100" ID="ConfirmPassword" TextMode="Password" placeholder="تأكيد كلمة المرور" style="direction: rtl" />
                            <span class="focus-input100-1"></span>
                            <span class="focus-input100-2"></span>
                        </div>

                        <div class="container-login100-form-btn m-t-20">

                            <asp:Button runat="server" class="login100-form-btn" OnClick="CreateUser_Click" Text="تسجيل " />
                        </div>
                    </asp:PlaceHolder>




                    

                    
                </form>
            </div>
        </div>
        </div>




    <!--===============================================================================================-->
    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/animsition/js/animsition.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/bootstrap/js/popper.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/daterangepicker/moment.min.js"></script>
    <script src="vendor/daterangepicker/daterangepicker.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/countdowntime/countdowntime.js"></script>
    <!--===============================================================================================-->
    <script src="js/main.js"></script>
</asp:Content>
