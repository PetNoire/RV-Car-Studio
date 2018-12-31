Public Class _About

    Public Sub DoLoad()
        TextBox1.Text = "Name: " & APPNAME & vbLf & _
                      "Made by: " & Maker & vbLf & _
                      "Version: " & MajorVersion & "." & MinorVersion & "." & BuildNumber & "." & Revision & "[" & Type.ToString & "]" & vbLf & _
                      "COPYRIGHTS:" & vbLf & COPY & vbLf & _
                        vbLf & _
                            FULL_INFO


    End Sub
    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class