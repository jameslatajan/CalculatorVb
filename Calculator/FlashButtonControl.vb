Imports System.ComponentModel

Public Class FlashButtonControl
    Inherits Button

    Private WithEvents timer As New Timer()
    Private isFlashing As Boolean = False
    Private currentBackColor As Color

    Public Sub New()
        currentBackColor = BackColor
        BackColor = Color.FromArgb(255, 244, 245, 249)
        FlashColor = Color.FromArgb(255, 241, 63, 75)
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderColor = Color.White
        Margin = New Padding(0)
        Font = New Font("MS Reference Sans Serif", 18)
        TabStop = False
        Dock = DockStyle.Fill
    End Sub


    <Category("Flash")>
    <Description("Defines the color the button will flash when it is clicked.")>
    Public Property FlashColor As Color


    Private Sub FlashButtonControl_Click(sender As Object, e As EventArgs) Handles Me.Click
        isFlashing = True
        timer = New Timer() With {.Interval = 10}
        Dim color As Color = BackColor
        BackColor = FlashColor
        timer.Start()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        BackColor = currentBackColor
        timer.Stop()
        isFlashing = False
    End Sub

    Private Sub FlashButtonControl_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        If isFlashing Then Return
        currentBackColor = BackColor
    End Sub
End Class
