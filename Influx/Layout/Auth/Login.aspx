<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Influx.Layout.Auth.Login" %>

<html lang="en">
<head>
    <meta charset="utf-8">

    <title>Influx Login</title>

</head>

<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="username_textbox" placeholder="Username" runat="server"></asp:TextBox>
        <asp:TextBox ID="password_textbox" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
        <asp:Button ID="ForgotPasswordBtn" runat="server" Text="Forgot password?" />
        <asp:Button ID="RegisterBtn" runat="server" Text="Register Now!" OnClick="RegisterBtn_Click" />
    </form>
</body>

</html>
