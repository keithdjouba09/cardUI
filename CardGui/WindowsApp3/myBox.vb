
' Author: Keith Djouba
' Date: December, 10 2017


Public Class myBox
    Private colorList As New List(Of SolidBrush) ' declare Brush Global Variable
    Public Sub New(Col As Color)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = Col ' 
    End Sub
    Private Sub myBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
