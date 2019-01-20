using System.Data.SqlClient;
/// <summary>

/// </summary>
public class GuestBook
{
    private SqlConnection dbConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True");

    public string signGuestBook(string lastname, string firstname)
    {
        string results = "";
        try
        {
            string hitinfo = "INSERT INTO guest VALUES('" + firstname + "', '" + lastname + "')";
            SqlCommand updateCommand = new SqlCommand(hitinfo, dbConnection);
            updateCommand.ExecuteNonQuery();
            results = "<p>Thank you for signing our Guest Book!</p>";
        }

        catch (SqlException exception)
        {
            results = "<p>Error Code " + exception.Number + "; " + exception.Message + "</p>";

        }
        return results;
    }

    public string showGuestBook()
    {
        string guestList = "";
        string SQLString = "SELECT firstname, lastname FROM guests";
        SqlCommand guestTable = new SqlCommand(SQLString, dbConnection);
        SqlDataReader guestRecords = guestTable.ExecuteReader();
        if (guestRecords.Read())
        {
            guestList = "<p>The following visitors have signed our guest book:</p>";
            guestList += "<table width='100% border='1'>";
            guestList += "<tr><th>First Name <th><th>Last Name </th></tr>";
            do
            {
                guestList += "<tr><td>" + guestRecords["firstName"] + "</td>";
                guestList += "<td>" + guestRecords["lastName"] + "</td></tr>";

            }
            while (guestRecords.Read());
            guestList += "</table>";
        }
        else
        {
            guestList = "<p>There are no entries in the guest book!</p>";
        }

        return guestList;
    }
    public GuestBook()
    {
        dbConnection.Open();
        dbConnection.ChangeDatabase("C:\\GuestBook\\GuestBook\\App_Data\\GuestBook.mdf");
    }

    ~GuestBook()
    {
        dbConnection.Close();
    }
}
