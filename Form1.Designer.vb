<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.btnInputData = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnFormData = New System.Windows.Forms.Button()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lstOcuppation = New System.Windows.Forms.ListBox()
        Me.lblOcuppation = New System.Windows.Forms.Label()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnCountry = New System.Windows.Forms.Button()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnCheckGrade = New System.Windows.Forms.Button()
        Me.btnAsyncFunction = New System.Windows.Forms.Button()
        Me.btnCheckTemperature = New System.Windows.Forms.Button()
        Me.txtCheckTemperature = New System.Windows.Forms.TextBox()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnStart.Size = New System.Drawing.Size(111, 40)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Press Here"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(129, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(111, 40)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(246, 12)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(111, 40)
        Me.btnVariables.TabIndex = 2
        Me.btnVariables.Text = "variables"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(363, 12)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(111, 40)
        Me.btnDataTypes.TabIndex = 3
        Me.btnDataTypes.Text = "Data types"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'btnInputData
        '
        Me.btnInputData.Location = New System.Drawing.Point(480, 12)
        Me.btnInputData.Name = "btnInputData"
        Me.btnInputData.Size = New System.Drawing.Size(228, 40)
        Me.btnInputData.TabIndex = 4
        Me.btnInputData.Text = "Input Data From User"
        Me.btnInputData.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(129, 101)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(228, 22)
        Me.txtFirstName.TabIndex = 5
        Me.txtFirstName.Text = " "
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 101)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(75, 16)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name:"
        '
        'btnFormData
        '
        Me.btnFormData.Location = New System.Drawing.Point(129, 194)
        Me.btnFormData.Name = "btnFormData"
        Me.btnFormData.Size = New System.Drawing.Size(111, 40)
        Me.btnFormData.TabIndex = 7
        Me.btnFormData.Text = "Form Data"
        Me.btnFormData.UseVisualStyleBackColor = True
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 129)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(75, 16)
        Me.lblLastName.TabIndex = 9
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(129, 129)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(228, 22)
        Me.txtLastName.TabIndex = 8
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(12, 157)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(55, 16)
        Me.lblGender.TabIndex = 11
        Me.lblGender.Text = "Gender:"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(129, 157)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(228, 22)
        Me.txtGender.TabIndex = 10
        '
        'lstOcuppation
        '
        Me.lstOcuppation.FormattingEnabled = True
        Me.lstOcuppation.ItemHeight = 16
        Me.lstOcuppation.Items.AddRange(New Object() {"Ingeniero", "Doctor", "Animal", "Viajero"})
        Me.lstOcuppation.Location = New System.Drawing.Point(439, 101)
        Me.lstOcuppation.Name = "lstOcuppation"
        Me.lstOcuppation.Size = New System.Drawing.Size(187, 84)
        Me.lstOcuppation.TabIndex = 12
        '
        'lblOcuppation
        '
        Me.lblOcuppation.AutoSize = True
        Me.lblOcuppation.Location = New System.Drawing.Point(436, 82)
        Me.lblOcuppation.Name = "lblOcuppation"
        Me.lblOcuppation.Size = New System.Drawing.Size(75, 16)
        Me.lblOcuppation.TabIndex = 13
        Me.lblOcuppation.Text = "Occupation"
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(12, 278)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(86, 16)
        Me.lblNumber1.TabIndex = 15
        Me.lblNumber1.Text = "First Number:"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(129, 278)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(228, 22)
        Me.txtNumber1.TabIndex = 14
        Me.txtNumber1.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Second Number:"
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(129, 306)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(228, 22)
        Me.txtNumber2.TabIndex = 16
        Me.txtNumber2.Text = " "
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(129, 334)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(111, 40)
        Me.btnResult.TabIndex = 18
        Me.btnResult.Text = "Result"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnCountry
        '
        Me.btnCountry.Location = New System.Drawing.Point(439, 334)
        Me.btnCountry.Name = "btnCountry"
        Me.btnCountry.Size = New System.Drawing.Size(111, 40)
        Me.btnCountry.TabIndex = 19
        Me.btnCountry.Text = "Country check"
        Me.btnCountry.UseVisualStyleBackColor = True
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(497, 284)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(228, 22)
        Me.txtCountry.TabIndex = 20
        Me.txtCountry.Text = " "
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(436, 284)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(55, 16)
        Me.lblCountry.TabIndex = 21
        Me.lblCountry.Text = "Country:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(773, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Enterr the examination score:"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(957, 278)
        Me.txtGrade.MaxLength = 5
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(112, 22)
        Me.txtGrade.TabIndex = 23
        Me.txtGrade.Text = " "
        '
        'btnCheckGrade
        '
        Me.btnCheckGrade.Location = New System.Drawing.Point(776, 334)
        Me.btnCheckGrade.Name = "btnCheckGrade"
        Me.btnCheckGrade.Size = New System.Drawing.Size(111, 40)
        Me.btnCheckGrade.TabIndex = 22
        Me.btnCheckGrade.Text = "Get grade"
        Me.btnCheckGrade.UseVisualStyleBackColor = True
        '
        'btnAsyncFunction
        '
        Me.btnAsyncFunction.Location = New System.Drawing.Point(129, 380)
        Me.btnAsyncFunction.Name = "btnAsyncFunction"
        Me.btnAsyncFunction.Size = New System.Drawing.Size(144, 40)
        Me.btnAsyncFunction.TabIndex = 25
        Me.btnAsyncFunction.Text = "Test Async Function"
        Me.btnAsyncFunction.UseVisualStyleBackColor = True
        '
        'btnCheckTemperature
        '
        Me.btnCheckTemperature.Location = New System.Drawing.Point(129, 559)
        Me.btnCheckTemperature.Name = "btnCheckTemperature"
        Me.btnCheckTemperature.Size = New System.Drawing.Size(144, 40)
        Me.btnCheckTemperature.TabIndex = 26
        Me.btnCheckTemperature.Text = "Check Temperature"
        Me.btnCheckTemperature.UseVisualStyleBackColor = True
        '
        'txtCheckTemperature
        '
        Me.txtCheckTemperature.Location = New System.Drawing.Point(129, 531)
        Me.txtCheckTemperature.Name = "txtCheckTemperature"
        Me.txtCheckTemperature.Size = New System.Drawing.Size(228, 22)
        Me.txtCheckTemperature.TabIndex = 27
        Me.txtCheckTemperature.Text = " "
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(15, 534)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(88, 16)
        Me.lblTemperature.TabIndex = 28
        Me.lblTemperature.Text = "Temperature:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 691)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.txtCheckTemperature)
        Me.Controls.Add(Me.btnCheckTemperature)
        Me.Controls.Add(Me.btnAsyncFunction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.btnCheckGrade)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.btnCountry)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblOcuppation)
        Me.Controls.Add(Me.lstOcuppation)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.btnFormData)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnInputData)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents btnInputData As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnFormData As Button
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lstOcuppation As ListBox
    Friend WithEvents lblOcuppation As Label
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnResult As Button
    Friend WithEvents btnCountry As Button
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnCheckGrade As Button
    Friend WithEvents btnAsyncFunction As Button
    Friend WithEvents btnCheckTemperature As Button
    Friend WithEvents txtCheckTemperature As TextBox
    Friend WithEvents lblTemperature As Label
End Class
