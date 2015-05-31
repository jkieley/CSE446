<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumberGuessingForm.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .input-group {
            display: inline-block;
        }

        .input-group input {
            width: 100px !important;
        }

        .row {
            display: block;
            margin: 10px
        }
        #outputLabel{
            margin-left: 10px
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Welcome To the Number Guessing Game</h2>
        <div class="row">
             <div class="input-group">
                <label for="lowerLimit">Lower Limit</label>
                <asp:TextBox ID="lowerLimit" Width="300" runat="server"/>
            </div>
            <div class="input-group">
                <label for="upperLimit">Upper Limit</label>
                <asp:TextBox ID="upperLimit" Width="300" runat="server"/>
            </div>
            <asp:Button ID="generateNumber" Text="Generate Secret Number" runat="server" OnClick="generateNumber_Click" />
        </div>
        <div class="row">
            <div class="input-group">
                <label for="guess">Make a Guess</label>
                <asp:TextBox ID="guess" Width="300" runat="server"/>
            </div>
            <asp:Button ID="play" Text="Play" runat="server"/>
            <asp:Label ID="outputLabel" Text="Generate a Number" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
