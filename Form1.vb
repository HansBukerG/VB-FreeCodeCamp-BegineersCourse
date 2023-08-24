Imports System.Globalization

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOcuppation.Items.Add("Writter")
        lstOcuppation.Items.Add("Actor")
        lstOcuppation.Items.Add("Somnoliento")
        lstOcuppation.Items.Add("Bailarin")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        MsgBox("Hello World")
        MsgBox("This is my first app")
        MsgBox("Made by Hans Buker Gutiérrez")
        MsgBox("This is thanks to freecodecamp.org")
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MsgBox("welcome to your first vb.net programming course") 'This is the old version, always usefull when you dont want to write a lot of code
        MessageBox.Show("this is another message") 'this is the new version POO oriented
    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim intAge As Integer

        stFirstName = "Hans"
        stLastName = "Buker"
        intAge = 29

        MsgBox(stFirstName & " " & stLastName & " i hope you are well" & " Your age is: " & intAge)

        stFirstName = "Raul"
        stLastName = "Bequer"

        MsgBox(stFirstName & " " & stLastName & " i hope you are well")
    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegisterted As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColour = "Red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.999
        dtDateRegisterted = #11/2/2020#

        MsgBox("The car is " & stMake _
               & " With model: " & stModel _
               & " Quantity of doors " & iDoors _
               & " bTaxed: " & bTaxed _
               & " Engiune size: " & iEngineSize _
               & " price: " & decPrice _
               & " Date Registered: " & dtDateRegisterted)

    End Sub

    Private Sub btnInputData_Click(sender As Object, e As EventArgs) Handles btnInputData.Click
        Dim strFirstName As String
        strFirstName = InputBox("Please enter your first name")

        MsgBox("Hello " & strFirstName)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFormData.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOcuppation.SelectedItem

        MsgBox("Hello " & stFirstName _
               & " " & stLastName _
               & " " & stGender _
               & " " & stOccupation
               )
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNumber1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer

        Dim iResult As Integer

        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 + iNumber2

        MsgBox(iResult)

        iResult = iNumber1 - iNumber2

        MsgBox(iResult)

        iResult = iNumber1 * iNumber2

        MsgBox(iResult)

        iResult = iNumber1 / iNumber2

        MsgBox(iResult)

    End Sub

    Private Sub btnCountry_Click(sender As Object, e As EventArgs) Handles btnCountry.Click

        Dim stCountry As String

        stCountry = txtCountry.Text.Trim()

        If stCountry.ToUpper = "CHILE" Then
            MsgBox("Ruidos en Chileno")
        ElseIf stCountry.ToUpper = "AUSTRALIA" Then
            MsgBox("AUSTRALIAAAAA")
        Else
            MsgBox("Puro perkin oe")
        End If

    End Sub

    Private Sub btnCheckGrade_Click(sender As Object, e As EventArgs) Handles btnCheckGrade.Click

        Dim iScore As Integer

        Try
            If IsNumeric(txtGrade.Text) = False Then
                MsgBox("You must insert a number first")
                Exit Sub
            End If

            iScore = CInt(txtGrade.Text)

            If iScore < 0 Or iScore > 100 Then
                MsgBox("That is not a valid number, please try again with other value ( was:" & iScore & " ) i need somehting between 0 and 100")
                Exit Sub
            End If

            If iScore < 50 Then
                MsgBox("Fail!")
                Exit Sub
            End If

            MsgBox("Success")
            MsgBox("All done boii!")

        Catch ex As Exception
            Dim errorMessage As String = "(btnCheckGrade_Click) " & "Error: " & ex.Message
            MessageBox.Show(errorMessage)
        End Try




    End Sub


    Private Async Function DoAsyncWork() As Task
        Await Task.Delay(2000)

        Throw New Exception("¡Something has happened!")
    End Function

    Private Async Sub btnAsyncFunction_Click(sender As Object, e As EventArgs) Handles btnAsyncFunction.Click

        Try
            Await DoAsyncWork()
            MessageBox.Show("Async task done succesfully!")
        Catch ex As Exception
            Dim errorMessage As String = "(btnAsyncFunction_Click) " & "Error: " & ex.Message
            MessageBox.Show(errorMessage)
        End Try

    End Sub

    Private Sub btnCheckTemperature_Click(sender As Object, e As EventArgs) Handles btnCheckTemperature.Click
        Try
            Dim iTemperature As Integer

            If IsNumeric(txtCheckTemperature.Text) = False Then
                Throw New Exception("Insert a number please")
            End If

            iTemperature = CInt(txtCheckTemperature.Text)

            Select Case iTemperature
                Case Is = 0
                    MessageBox.Show("Freezing")
                Case Is < 0
                    MessageBox.Show("Sub Zero")
                Case 1 To 10
                    MessageBox.Show("Its cold")
                Case 11 To 20
                    MessageBox.Show("Its getting warm")
                Case 21 To 30
                    MessageBox.Show("Its hot")
                Case 31 To 40
                    MessageBox.Show("Its very hot, turn on the air conditioneer")
                Case Else
                    MessageBox.Show("Its out of my parameters sadly :(")
            End Select


        Catch ex As Exception
            Dim errorMessage As String = "(btnCheckTemperature_Click) " & "Error: " & ex.Message
            MessageBox.Show(errorMessage)
        End Try
    End Sub
End Class
