﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = getKhmerLunarString(DateTimePicker1.Value)
    End Sub
End Class
