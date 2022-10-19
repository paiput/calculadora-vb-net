Public Class Form1
    Dim N1 As Integer
    Dim N2 As Integer
    Dim Mem As Boolean = False
    Dim Op As String
    Dim Res As Integer

    Private Sub SetDisplay(ByVal p_Op As String)
        If Display.Text = "" Then
            N1 = 0
        Else
            N1 = Integer.Parse(Display.Text)
        End If
        Op = p_Op
        Display2.Text = N1.ToString() + " " + Op
        Display.Text = ""
        Mem = False
    End Sub

    Private Sub CalcResult()
        If Not Mem Then
            N2 = Integer.Parse(Display.Text)
        End If
        Display2.Text = N1.ToString() + " " + Op + " " + N2.ToString() + " = "
        Select Case Op
            Case "+"
                Res = N1 + N2
            Case "-"
                Res = N1 - N2
            Case "x"
                Res = N1 * N2
            Case "/"
                Res = N1 / N2
            Case Else
                Res = N1
        End Select
        Display.Text = Res.ToString()
        Dim Aux As Integer = N1
        N1 = Res
        Mem = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Display.Text += "1"
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Display.Text += "2"
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Display.Text += "3"
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        Display.Text += "4"
    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        Display.Text += "5"
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click
        Display.Text += "6"
    End Sub

    Private Sub B7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B7.Click
        Display.Text += "7"
    End Sub

    Private Sub B8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B8.Click
        Display.Text += "8"
    End Sub

    Private Sub B9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B9.Click
        Display.Text += "9"
    End Sub

    Private Sub B0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B0.Click
        Display.Text += "0"
    End Sub

    Private Sub BDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDel.Click
        If Not Mem And Display.Text.Length > 0 Then
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1)
        End If
    End Sub

    Private Sub BC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BC.Click
        Display.Text = ""
        Display2.Text = ""
        Mem = False
    End Sub

    Private Sub BSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSum.Click
        SetDisplay("+")
    End Sub

    Private Sub BSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSub.Click
        SetDisplay("-")
    End Sub

    Private Sub BMul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMul.Click
        SetDisplay("x")
    End Sub

    Private Sub BDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDiv.Click
        SetDisplay("/")
    End Sub

    Private Sub BEq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEq.Click
        CalcResult()
    End Sub
End Class
