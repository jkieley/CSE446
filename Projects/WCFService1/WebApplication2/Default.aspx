<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<script runat="server">
  protected override void OnLoad(EventArgs e)
  {
      Response.Redirect("WebForm1.aspx");
      base.OnLoad(e);
  }
</script>
