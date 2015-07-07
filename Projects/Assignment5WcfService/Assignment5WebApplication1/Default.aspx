<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment5WebApplication1.Index" %>

<script runat=server>
protected string uuid()
{
    return System.Guid.NewGuid().ToString();
}
</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>Message Service Test Client</h4>
        <h4>Your id is: <% =uuid() %></h4>
        <div class="input-group">
            <label>To Whom(ID)?</label>
            <input type="text" id="receiverId" runat="server"/>
        </div>
        <div class="input-group">
            <label>Message:</label>
            <input type="text" id="content" runat="server"/>
            <div>
                <asp:Button Text="Send This Message" runat="server" OnClick="Unnamed1_Click" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
