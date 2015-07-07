<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment5WebApplication1.Index" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .input-group label {
            vertical-align: top;
            width: 130px;
            display: inline-block;
        }

        .input-group {
            display: block;
            margin: 10px 0;
        }

        #sendMsg {
            margin-left: 134px;
            margin-top: 10px;
        }

        #recieveMsg {
            margin-left: 10px;
        }

        form {
            width: 600px;
            margin: auto;
            padding: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>Message Service Test Client</h4>
        <h4>Your id is: <%= this.test %></h4>
        <div class="input-group">
            <label>To Whom(ID)?</label>
            <input type="text" name="receiverId" runat="server"/>
            <input type="hidden" name="senderId" value="<%= this.test %>" />
        </div>
        <div class="input-group">
            <label>Message:</label>
             <asp:TextBox ID="messageContent" TextMode="multiline" Columns="50" Rows="5" runat="server"/>
            <div>
                <asp:Button Text="Send This Message" runat="server" OnClick="Unnamed1_Click" id="sendMsg"/>
            </div>
        </div>
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:Timer ID="Timer1" OnTick="Timer1_Tick" runat="server" Interval="1000" />
    <div>
        <div class="input-group">
            <label>My ID:</label>
            <input type="hidden" name="receiverId" value="<%= this.test %>" />
            <asp:Button Text="Recieve my Messages" runat="server" id="recieveMsg"/>
        </div>
        <div class="input-group">
            <label>All messages to me:</label>
             
            <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
                <ContentTemplate>
                    <asp:TextBox ID="TextBox1" TextMode="multiline" Columns="50" Rows="5" runat="server" Text="UpdatePanel1 not refreshed yet."/>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    </form>
</body>
</html>
