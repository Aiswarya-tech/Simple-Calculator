Public Class Form1
    Dim cnt As Integer
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Num0.Click, Num1.Click, Num2.Click, Num3.Click, Num4.Click, Num5.Click, Num6.Click, Num7.Click, Num8.Click, Num9.Click, Dot.Click, OpAdd.Click, OpDiv.Click, OpSub.Click, OpMul.Click, OpEquals.Click, BackSpace.Click, Clear.Click, OpPer.Click

        Dim button As Button = CType(sender, Button)
        If (cnt < 15) Then
            If button.Name = "Num0" Then
                Display.Text = Display.Text + "0"
                cnt = cnt + 1
            End If

            If button.Name = "Num1" Then
                Display.Text = Display.Text + "1"
                cnt = cnt + 1
            End If

            If button.Name = "Num2" Then
                Display.Text = Display.Text + "2"
                cnt = cnt + 1
            End If

            If button.Name = "Num3" Then
                Display.Text = Display.Text + "3"
                cnt = cnt + 1
            End If

            If button.Name = "Num4" Then
                Display.Text = Display.Text + "4"
                cnt = cnt + 1
            End If

            If button.Name = "Num5" Then
                Display.Text = Display.Text + "5"
                cnt = cnt + 1
            End If

            If button.Name = "Num6" Then
                Display.Text = Display.Text + "6"
                cnt = cnt + 1
            End If

            If button.Name = "Num7" Then
                Display.Text = Display.Text + "7"
                cnt = cnt + 1
            End If

            If button.Name = "Num8" Then
                Display.Text = Display.Text + "8"
                cnt = cnt + 1
            End If

            If button.Name = "Num9" Then
                Display.Text = Display.Text + "9"
                cnt = cnt + 1
            End If
        End If
        If button.Name = "Dot" Then
            Display.Text = Display.Text + "."
        End If


        If button.Name = "OpAdd" Then
            Display.Text = Display.Text + "+"
            cnt = 0
        End If

        If button.Name = "OpSub" Then
            Display.Text = Display.Text + "-"
            cnt = 0
        End If

        If button.Name = "OpMul" Then
            Display.Text = Display.Text + "*"
            cnt = 0
        End If

        If button.Name = "OpDiv" Then
            Display.Text = Display.Text + "/"
            cnt = 0
        End If

        If button.Name = "OpPer" Then
            Display.Text = Display.Text + "%"
            cnt = 0
        End If

        If button.Name = "Clear" Then
            Display.Text = ""
            cnt = 0
        End If

        If button.Name = "BackSpace" Then
            If Display.Text < " " Then
                Display.Text = Mid(Display.Text, 1, Len(Display.Text) - 1 + 1)
                cnt = 0
            Else
                Display.Text = Mid(Display.Text, 1, Len(Display.Text) - 1)
                cnt = cnt - 1
            End If
        End If

        If button.Name = "OpEquals" Then
            Try
                Dim equation As String = Display.Text
                Dim result = New DataTable().Compute(equation, Nothing)
                If Double.IsInfinity(result) Or Double.IsNaN(result) Then
                    Display.Text = "Can't Divide by 0 "
                Else
                    result = result.ToString.TrimEnd("0")
                    result = result.ToString.TrimEnd(".")
                    Display.Text = result
                End If

            Catch ex As Exception
                MsgBox("Invalid Expression")
            End Try

        End If
    End Sub

    Private Sub display_keypress(sender As Object, e As KeyPressEventArgs) Handles Display.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 37 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 43 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 42 Or Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) = 61 Then

        Else
            e.Handled = True
            MsgBox("Invalid input type")
        End If
    End Sub

    Private Sub Display_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Display.KeyPress

        Try
            If e.KeyChar = "=" Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                e.KeyChar = ""
                Dim equation As String = Display.Text
                Dim result = New DataTable().Compute(equation, Nothing)
                If Double.IsInfinity(result) Or Double.IsNaN(result) Then
                    Display.Text = "Can't Divide by 0 "

                Else
                    result = result.ToString.TrimEnd("0")
                    result = result.ToString.TrimEnd(".")
                    Display.Text = result
                End If

            End If
        Catch ex As Exception
            MsgBox("Invalid Expression")
        End Try

    End Sub


End Class
