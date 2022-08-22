<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="DotNetWebFormAPP.Views.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>

<body>
    <form id="form1" runat="server">
        <div>
            <%
                //foreach (DataRow row in dataTable.Rows)
                //{
                //    Response.Write("Name is: " + row["d_name"].ToString());
                //}


                Response.Write("count: " + arrNames.Rows.Count);
                for (int i = 0; i < arrNames.Rows.Count; i++)
                {
                    Response.Write("<br><br> Name: " + arrNames.Rows[i][1]);
                }
            %>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
