Public Class Form1


    Dim num1 As Double
    Dim num2 As Double
    Dim op As String
    Dim isAnswer As Boolean = False ' <-- 4 වෙනියා

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn9.Text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If isAnswer Then
            txtNumber.Text = ""
            isAnswer = False
        End If
        txtNumber.Text = txtNumber.Text & btn0.Text
    End Sub

    Private Sub btnDote_Click(sender As Object, e As EventArgs) Handles btnDote.Click
        txtNumber.Text = txtNumber.Text & btnDote.Text
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim expression As String = txtNumber.Text
        Dim result As Double

        Try
            If expression.Contains("+") Then
                Dim nums() As String = expression.Split("+"c)
                result = Val(nums(0)) + Val(nums(1))

            ElseIf expression.Contains("-") Then
                Dim nums() As String = expression.Split("-"c)
                result = Val(nums(0)) - Val(nums(1))

            ElseIf expression.Contains("*") Then
                Dim nums() As String = expression.Split("*"c)
                result = Val(nums(0)) * Val(nums(1))

            ElseIf expression.Contains("/") Then
                Dim nums() As String = expression.Split("/"c)
                If Val(nums(1)) = 0 Then
                    txtNumber.Text = "Error"
                    Exit Sub
                End If
                result = Val(nums(0)) / Val(nums(1))

            ElseIf expression.Contains("%") Then  ' <-- % එක තියෙන්න ඕන එක තැනක් විතරයි
                Dim nums() As String = expression.Split("%"c)
                result = Val(nums(0)) * Val(nums(1)) / 100  ' 200 % 10 = 20

            End If

            txtNumber.Text = result.ToString()
            isAnswer = True
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try


    End Sub

    Private Sub btnPluse_Click(sender As Object, e As EventArgs) Handles btnPluse.Click
        AddOperator("+")
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        AddOperator("-")
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        AddOperator("*")
    End Sub

    Private Sub btnDevide_Click(sender As Object, e As EventArgs) Handles btnDevide.Click
        AddOperator("/")
    End Sub
    Private Sub btnPresentsge_Click(sender As Object, e As EventArgs) Handles btnPresentsge.Click
        AddOperator("%")
    End Sub

    Sub AddOperator(newOp As String)
        Dim text As String = txtNumber.Text
        If text = "" Then Exit Sub
        Dim lastChar As Char = text(text.Length - 1)
        If "+-*/%".Contains(lastChar) Then
            txtNumber.Text = text.Substring(0, text.Length - 1) & newOp
        Else
            txtNumber.Text = txtNumber.Text & newOp
        End If

        isAnswer = False
    End Sub



    Private Sub btnAc_Click(sender As Object, e As EventArgs) Handles btnAc.Click
        txtNumber.Clear()
        isAnswer = False
    End Sub

    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        Dim text As String = txtNumber.Text

        If text <> "" Then
            txtNumber.Text = text.Substring(0, text.Length - 1) ' අන්තිම එක මකනවා
        End If

        isAnswer = False
    End Sub


End Class
