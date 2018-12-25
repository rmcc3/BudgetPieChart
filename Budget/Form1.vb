' Raymond McCann
Public Class Form1
    Dim legend() As String = {"Housing", "Transportation", "Food", "Other"}
    Dim br() As Brush = {Brushes.Blue, Brushes.Red, Brushes.Green, Brushes.Orange}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Housing As Integer = CInt(txtHousing.Text)
        Dim Transportation As Integer = CInt(txtTransport.Text)
        Dim Food As Integer = CInt(txtFood.Text)
        Dim Other As Integer = CInt(txtOther.Text)
        Dim amounts() As Integer = {Housing, Transportation, Food, Other}
        Dim gr As Graphics = chart.CreateGraphics

        Dim sum As Decimal = 0
        Dim sweep As Decimal = 0
        Dim percent(amounts.Count - 1) As Decimal
        Dim radius As Integer = 130
        Dim center As Integer = 135

        For i As Integer = 0 To (amounts.Count - 1)
            sum += amounts(i)
        Next

        For i As Integer = 0 To (amounts.Count - 1)
            percent(i) = amounts(i) / sum
        Next

        For i As Integer = 0 To (amounts.Count - 1)
            gr.FillPie(br(i), center - radius, center - radius, 2 * radius, 2 * radius, sweep, percent(i) * 360)
            sweep += CDec(percent(i) * 360)
            gr.FillRectangle(br(i), 420, 20 + 30 * i, 20, 20)
            gr.DrawString(legend(i), Me.Font, Brushes.Black, 450, 22 + 30 * i)
        Next
    End Sub
End Class
