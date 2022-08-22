<%@ Page Title="Add Doctor"Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDoctor.aspx.cs" Inherits="DotNetWebFormAPP.Views.AddDoctor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>
    <h3>Add doctor page.</h3>
    <link href="../Content/bootstrap-datetimepicker.css" rel="stylesheet" />
    <link href="../Content/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-ui-1.13.1.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/jquery-ui.css" rel="stylesheet" />
    <div class="form-group">
        <label for="textName">Name</label>
        <asp:TextBox ID="textName" runat="server" class="form-control" aria-describedby="nameHelp" placeholder="Enter name"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="textContact">Contact</label>
        <asp:TextBox ID="textContact" runat="server" class="form-control" aria-describedby="contactHelp" placeholder="Enter contact number"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="textEmail">Email</label>
        <asp:TextBox ID="textEmail" runat="server" class="form-control" aria-describedby="emailHelp" placeholder="Enter email"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="dob">Date Of Birth</label>
        <input type="text" id="dob" name="dob" value="" class="form-control" />

    </div>


    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Save" OnClick="SaveDoctor"/>


    <script>
        $(document).ready(function () {
            $('#dob').datepicker({
                dateFormat: "dd/mm/yy",
                changeMonth: true,
                changeYear: true,
                yearRange: "2000:2019",
                //showOn: "both",
                //buttonText: "<i class='fa fa-calendar'></i>"
            });
        });
    </script>
</asp:Content>




