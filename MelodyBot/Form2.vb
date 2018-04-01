Imports System.Timers

Public Class Form2

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Dim timer As New System.Timers.Timer()
        timer.Interval = 5000
        timer.Enabled = True
        timer.Start()
        AddHandler timer.Elapsed, AddressOf OnTimedEvent
    End Sub

    Private Delegate Sub CloseFormCallBack()

    Private Sub CloseForm()
        If InvokeRequired Then
            Dim x As New CloseFormCallBack(AddressOf CloseForm)
            Invoke(x, Nothing)
        Else
            Close()
        End If
    End Sub

    Private Sub OnTimedEvent(sender As Object, e As ElapsedEventArgs)
        CloseForm()
    End Sub

    'click and drag the window
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    ' Left mouse button pressed
    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Form2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class