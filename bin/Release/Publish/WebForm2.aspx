<%@ Page Title="" Language="C#" MasterPageFile="~/Onder.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Onder1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul id="accordion1" class="nav nav-pills flex-column">
  <li class="nav-item">
    <a class="nav-link" data-toggle="collapse" href="#item-1" data-parent="#accordion1">Item 1</a>
    <div id="item-1" class="collapse show">
      <ul class="nav flex-column ml-3">
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 1-1</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 1-2</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 1-3</a>
        </li>
      </ul>
    </div>
  </li>
  <li class="nav-item">
    <a class="nav-link" data-toggle="collapse" href="#item-2" data-parent="#accordion1">Item 2</a>
    <div id="item-2" class="collapse">
      <ul class="nav flex-column ml-3">
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 2-1</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 2-2</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 2-3</a>
        </li>
      </ul>
    </div>
  </li>
  <li class="nav-item">
    <a class="nav-link" data-toggle="collapse" href="#item-3" data-parent="#accordion1">Item 3</a>
    <div id="item-3" class="collapse">
      <ul class="nav flex-column ml-3">
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 3-1</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 3-2</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sub 3-3</a>
        </li>
      </ul>
    </div>
  </li>
</ul>
</asp:Content>
