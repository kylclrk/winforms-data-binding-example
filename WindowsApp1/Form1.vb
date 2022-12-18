Public Class Form1

    Private ReadOnly data As Data
    Public Sub New()
        InitializeComponent()
        data = New Data("Kyle")

        BindDataToControls()
    End Sub

    Private Sub BindDataToControls()
        TextBox1.DataBindings.Add(NameOf(TextBox1.Text), data, NameOf(data.CustomerName))
        Label2.DataBindings.Add(NameOf(Label2.Text), data, NameOf(data.CustomerName))
        Label4.DataBindings.Add(NameOf(Label4.Text), data, NameOf(data.SaySomethingNice))
    End Sub

    Private Sub changeItemBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        data.CustomerName = "Adam"
    End Sub
End Class
