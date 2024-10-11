Imports MySql.Data.MySqlClient


Public Class Form1
    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click

        Dim connectionString As String = "Server=localhost; database=dbuser; User ID=root; Password=12Yellow34!"

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Using cmd As New MySqlCommand("sp_hello_world", conn)

                cmd.CommandType = CommandType.StoredProcedure

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then

                        While reader.Read()

                            txtOutput.Text = reader("message").ToString()

                        End While

                    End If

                End Using

            End Using


            End Using

    End Sub
End Class
