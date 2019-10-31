﻿Public Class Form1
    Private equal As Boolean
    Private operation As Boolean
    Private isdotexistbool As Boolean

    Public Sub Removezero(ByVal number As String)
        If TextBox_Big.Text = "0" Then
            TextBox_Big.Text = number
            operation = True

        ElseIf equal = True Then
            TextBox_Big.Text = number
            TextBox_Small.Text = ""
            equal = False
            operation = True
        Else
            TextBox_Big.Text &= number
            operation = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Removezero("1")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Removezero("2")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Removezero("3")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Removezero("4")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Removezero("5")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Removezero("6")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Removezero("7")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Removezero("8")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Removezero("9")
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        If TextBox_Big.Text = "0" Then
            TextBox_Big.Text = 0
        Else
            TextBox_Big.Text &= 0
        End If
    End Sub

    Private Sub Button_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Clear.Click
        TextBox_Big.Text = ""
        TextBox_Big.Text = 0
        TextBox_Small.Text = ""
        isdotexistbool = False
    End Sub

    Private Sub Button_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Add.Click
        isdotexistbool = False
        If operation = True Then
            Removezero("+")
            operation = False
        End If
    End Sub

    Private Sub Button_Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Dot.Click
        If isdotexistbool = False Then
            Removezero(".")
            isdotexistbool = True
        End If
    End Sub

    Private Sub Button_Sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Sub.Click
        isdotexistbool = False
        If operation = True Then
            Removezero("-")
            operation = False
        End If
    End Sub

    Private Sub Button_Mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Mul.Click
        isdotexistbool = False
        If operation = True Then
            Removezero("*")
            operation = False
        End If
    End Sub

    Private Sub Button_div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Div.Click
        isdotexistbool = False
        If operation = True Then
            Removezero("/")
            operation = False
        End If
    End Sub

    Private Sub Button_Equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Equal.Click
        Dim equation As String = TextBox_Big.Text
        TextBox_Small.Text = TextBox_Big.Text
        Try
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox_Big.Text = result
        Catch ex As SyntaxErrorException
            TextBox_Big.Text = "Error"
        End Try
        isdotexistbool = False
        equal = True
    End Sub

    Private Sub Button_Modulus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Modulus.Click
        isdotexistbool = False
        If operation = True Then
            Removezero("%")
        End If
    End Sub

    Private Sub Button_PlusSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddSub.Click
        If TextBox_Big.Text <= 0 Then
            TextBox_Big.Text = 0
        Else
            TextBox_Big.Text = "(-" + TextBox_Big.Text + ")"
        End If
        isdotexistbool = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isdotexistbool = False
        operation = False
        equal = False
    End Sub


End Class

