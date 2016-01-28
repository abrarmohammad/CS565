Imports System.Data.OleDb
Imports System.Data.Sql
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\v-niansa\Desktop\Data base\Data base .net\Data base\student.mdb")


        Try
            Dim cmd As New OleDbCommand("insert into Student(First_Name, Last_Name) values(@a1, @a2)", con)
            cmd.Parameters.AddWithValue("a1", Fname.Text)
            cmd.Parameters.AddWithValue("a2", Lname.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Registration Request of " + Fname.Text + " " + Lname.Text + " has been received.")
            Fname.Text = ""
            Lname.Text = ""
            GridView1.DataBind()

        Catch ex As Exception
            con.Close()
            MsgBox("Error during Registration.")
        End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class