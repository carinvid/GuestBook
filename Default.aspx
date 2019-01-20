<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guest Book</title>
</head>
<body>
    <form id="guestForm" runat="server">
        <div>
            <p>

                <strong>Enter your name to sign our guest book!</strong>
            </p>

        </div>
        <p>
            First Name
            <asp:TextBox ID="first" runat="server" /><asp:RequiredFieldValidator ID="FirstNameValidator" runat="server" ErrorMessage="**" ControlToValidate="first" /><br />
            Last Name
            <asp:TextBox ID="last" runat="server" /><asp:RequiredFieldValidator ID="LastNameValidator" runat="server" ErrorMessage="**" ControlToValidate="last" />
            <p>
                <asp:Button ID="signGuestBook" runat="server" Text="Sign Guest Book" OnClick="signGuestBook_Click" Width="157px" /><br />
                <asp:Button ID="showGuestBook" runat="server" Text="Show Guest Book" CausesValidation="false" OnClick="showGuestBook_Click" Width="157px" />
            </p>
    </form>
    <asp:Literal ID="outputBox" runat="server" />
</html>
