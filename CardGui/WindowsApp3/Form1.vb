' Author: Keith Djouba
' Date: December, 10 2017

Public Class Form1
    Private Colo As String ' initialize string global variable
    Private drawColor As Color = Color.Olive  'Declare color global variable
    Private colors() As String = {"Red", " Blue", "Green", "Yellow"}
    Private drawImage As Image 'Declare color global variabl
    Private radioValue As Integer ' Declare the value of the radio button
    'create a boolean for checking if the arrangement is saved or not yet
    Private saved As Boolean
    ' if click on save button
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        ' inittalize random class
        Static gen As System.Random = New System.Random()
        SaveDialog.ShowDialog() 'pop up a new window
        ' declare string fro save file
        Dim filename As String = SaveDialog.FileName
        ' create file
        Dim objWriter As New System.IO.StreamWriter(filename)
        objWriter.WriteLine(Colo) ' write color value
        ' if the user select 4
        If RadioButton4.Checked = True Then
            radioValue = 4 ' integer value equal 4
            Dim nBoxes As Integer
            nBoxes = radioValue ' get the radio button value
            objWriter.WriteLine(radioValue) ' write the radio button value on the file
            For boxNum3 As Integer = 1 To nBoxes 'for the current trackbar value
                'write random colors on the file
                objWriter.WriteLine(colors(gen.Next(0, 4)) & " " & colors(gen.Next(0, 4)) & " " & colors(gen.Next(0, 4)))
            Next
            'if the user select 5
        ElseIf RadioButton5.Checked = True Then
            radioValue = 5 ' integer value equal 5
            Dim nBoxes As Integer
            nBoxes = radioValue ' get the radio button value
            objWriter.WriteLine(radioValue) ' write the radio button value on the file
            For boxNum3 As Integer = 1 To nBoxes 'for the current trackbar value
                'write random colors on the file
                objWriter.WriteLine(colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)))
            Next
            ' if the user select 6
        ElseIf RadioButton6.Checked = True Then
            radioValue = 6 ' integer value equal 6
            Dim nBoxes As Integer
            nBoxes = radioValue ' get the radio button value
            objWriter.WriteLine(radioValue) ' write the radio button value on the file
            For boxNum3 As Integer = 1 To nBoxes 'for the current trackbar value
                'write random colors on the file
                objWriter.WriteLine(colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)))
            Next
            ' if the user select 7
        ElseIf RadioButton7.Checked = True Then
            radioValue = 7 ' integer value equal 7
            Dim nBoxes As Integer
            nBoxes = radioValue ' get the radio button value
            objWriter.WriteLine(radioValue) ' write the radio button value on the file
            For boxNum3 As Integer = 1 To nBoxes 'for the current trackbar value
                'write random colors on the file
                objWriter.WriteLine(colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)))
            Next
            ' if the user select 8
        ElseIf RadioButton8.Checked = True Then
            radioValue = 8 ' integer value equal 8
            Dim nBoxes As Integer
            nBoxes = radioValue ' get the radio button value
            objWriter.WriteLine(radioValue) ' write the radio button value on the file
            For boxNum3 As Integer = 1 To nBoxes 'for the current trackbar value
                'write random colors on the file
                objWriter.WriteLine(colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)))
            Next
            ' if the user select 9
        ElseIf RadioButton9.Checked = True Then
            radioValue = 9 ' integer value equal 9
            Dim nBoxes As Integer
            nBoxes = radioValue ' get the radio button value
            objWriter.WriteLine(radioValue) ' write the radio button value on the file
            For boxNum3 As Integer = 1 To nBoxes 'for the current trackbar value
                'write random colors on the file
                objWriter.WriteLine(colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)))
            Next
        ElseIf RadioButton10.Checked = True Then
            radioValue = 10 ' integer value equal 9
            Dim nBoxes As Integer
            nBoxes = radioValue ' get the radio button value
            objWriter.WriteLine(radioValue) ' write the radio button value on the file
            For boxNum3 As Integer = 1 To nBoxes 'for the current trackbar value
                'write random colors on the file
                objWriter.WriteLine(colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)) & " " & colors(gen.Next(0, 3)))
            Next
        Else
            radioValue = "not selected"
        End If


        objWriter.Close()
        saved = True
    End Sub

    Private Sub oliveButton_CheckedChanged(sender As Object, e As EventArgs) Handles oliveButton.CheckedChanged
        Colo = "Olive"
        drawColor = Color.Olive ' modify the background color of global variable to Olive
        Dim nextBox As myBox ' create user control variable
        nextBox = New myBox(drawColor) ' set boxes background color
        showColor.Controls.Add(nextBox)
        If grayButton.Checked = True Then ' if the radio button checked
            showColor.Controls.Clear()
        End If
    End Sub
    Private Sub grayButton_CheckedChanged(sender As Object, e As EventArgs) Handles grayButton.CheckedChanged
        Colo = "Gray"
        drawColor = Color.Gray ' modify the background color of global variable to Olive
        Dim nextBox As myBox ' create user control variable
        nextBox = New myBox(drawColor) ' set boxes background color
        showColor.Controls.Add(nextBox)
    End Sub

    Private Sub imageButton_CheckedChanged(sender As Object, e As EventArgs) Handles imageButton.CheckedChanged
        showColor.Controls.Clear()
        If imageButton.Checked = True Then 'if the radio button checked
            imageFileLoader.Title = "Select an Iamge File" ' load file directory
            'imageFileLoader.InitialDirectory = "C:\"
            imageFileLoader.RestoreDirectory = True ' restore directory the last location
            If imageFileLoader.ShowDialog() = DialogResult.OK Then 'if click Ok
                Dim fullFile As String ' create a string
                fullFile = imageFileLoader.FileName 'get the file from directory
                showColor.BackgroundImage = System.Drawing.Image.FromFile(fullFile) 'insert image to groupBox
                'drawImage = System.Drawing.Image.FromFile(fullFile) ' insert picture to User control
            End If
        End If
    End Sub
    ' if user click on exit buuton
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        If Not saved Then
            'set up a message
            Dim message As String
            message = "You have not saved your Game."
            message += vbNewLine
            message += "Are you sure you want to quit?"
            ' pop up confirmation box
            Dim result = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then ' if user click on "yes"
                Application.Exit() ' exit the application

            End If
        Else
            Application.Exit() ' if saved exit application
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        helpForm.Show()
    End Sub
End Class
