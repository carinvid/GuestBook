
using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void showGuestBook_Click(object sender, EventArgs e)
    {
        guestForm.Visible = false;
        GuestBook guestList = new GuestBook();
        string signResult = guestList.showGuestBook();
        outputBox.Text = signResult;
    }
    protected void signGuestBook_Click(object sender, EventArgs e)
    {
        guestForm.Visible = false;
        GuestBook curGuest = new GuestBook();
        string signResult = curGuest.signGuestBook(last.Text, first.Text);
        outputBox.Text = signResult;
    }

}
