'
' Created by SharpDevelop.
' User: IP-Man
' Date: 6/27/2017
' Time: 9:55 PM
' 
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.loadfileBTN = New System.Windows.Forms.Button()
		Me.convertBTN = New System.Windows.Forms.Button()
		Me.inputBox = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.outputBox = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.outputfontBTN = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.savetextBTN = New System.Windows.Forms.Button()
		Me.uniTOfont = New System.Windows.Forms.RadioButton()
		Me.fontTOuni = New System.Windows.Forms.RadioButton()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
		Me.SuspendLayout
		'
		'loadfileBTN
		'
		Me.loadfileBTN.Location = New System.Drawing.Point(13, 12)
		Me.loadfileBTN.Name = "loadfileBTN"
		Me.loadfileBTN.Size = New System.Drawing.Size(134, 21)
		Me.loadfileBTN.TabIndex = 0
		Me.loadfileBTN.Text = "Load from a file"
		Me.loadfileBTN.UseVisualStyleBackColor = true
		AddHandler Me.loadfileBTN.Click, AddressOf Me.LoadfileBTNClick
		'
		'convertBTN
		'
		Me.convertBTN.Location = New System.Drawing.Point(13, 410)
		Me.convertBTN.Name = "convertBTN"
		Me.convertBTN.Size = New System.Drawing.Size(177, 38)
		Me.convertBTN.TabIndex = 1
		Me.convertBTN.Text = "Convert"
		Me.convertBTN.UseVisualStyleBackColor = true
		AddHandler Me.convertBTN.Click, AddressOf Me.ConvertBTNClick
		'
		'inputBox
		'
		Me.inputBox.Font = New System.Drawing.Font("Iskoola Pota", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.inputBox.Location = New System.Drawing.Point(13, 66)
		Me.inputBox.Multiline = true
		Me.inputBox.Name = "inputBox"
		Me.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.inputBox.Size = New System.Drawing.Size(546, 143)
		Me.inputBox.TabIndex = 2
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(13, 48)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 26)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Input Text : "
		'
		'outputBox
		'
		Me.outputBox.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.outputBox.Location = New System.Drawing.Point(13, 252)
		Me.outputBox.Multiline = true
		Me.outputBox.Name = "outputBox"
		Me.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.outputBox.Size = New System.Drawing.Size(546, 143)
		Me.outputBox.TabIndex = 4
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(13, 234)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 26)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Output Text : "
		'
		'outputfontBTN
		'
		Me.outputfontBTN.Location = New System.Drawing.Point(425, 225)
		Me.outputfontBTN.Name = "outputfontBTN"
		Me.outputfontBTN.Size = New System.Drawing.Size(134, 21)
		Me.outputfontBTN.TabIndex = 6
		Me.outputfontBTN.Text = "Arial"
		Me.outputfontBTN.UseVisualStyleBackColor = true
		AddHandler Me.outputfontBTN.Click, AddressOf Me.OutputfontBTNClick
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(390, 229)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(37, 17)
		Me.label3.TabIndex = 7
		Me.label3.Text = "Font : "
		'
		'savetextBTN
		'
		Me.savetextBTN.Location = New System.Drawing.Point(196, 410)
		Me.savetextBTN.Name = "savetextBTN"
		Me.savetextBTN.Size = New System.Drawing.Size(177, 38)
		Me.savetextBTN.TabIndex = 8
		Me.savetextBTN.Text = "Save Converted Text"
		Me.savetextBTN.UseVisualStyleBackColor = true
		AddHandler Me.savetextBTN.Click, AddressOf Me.SavetextBTNClick
		'
		'uniTOfont
		'
		Me.uniTOfont.Checked = true
		Me.uniTOfont.Location = New System.Drawing.Point(341, 12)
		Me.uniTOfont.Name = "uniTOfont"
		Me.uniTOfont.Size = New System.Drawing.Size(104, 24)
		Me.uniTOfont.TabIndex = 9
		Me.uniTOfont.TabStop = true
		Me.uniTOfont.Text = "Unicode to Font"
		Me.uniTOfont.UseVisualStyleBackColor = true
		'
		'fontTOuni
		'
		Me.fontTOuni.Enabled = false
		Me.fontTOuni.Location = New System.Drawing.Point(455, 12)
		Me.fontTOuni.Name = "fontTOuni"
		Me.fontTOuni.Size = New System.Drawing.Size(104, 24)
		Me.fontTOuni.TabIndex = 10
		Me.fontTOuni.Text = "Font to Unicode"
		Me.fontTOuni.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(572, 456)
		Me.Controls.Add(Me.fontTOuni)
		Me.Controls.Add(Me.uniTOfont)
		Me.Controls.Add(Me.savetextBTN)
		Me.Controls.Add(Me.outputBox)
		Me.Controls.Add(Me.outputfontBTN)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.inputBox)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.convertBTN)
		Me.Controls.Add(Me.loadfileBTN)
		Me.Controls.Add(Me.label3)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Lakbasa Sinhala Unicode Converter"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private saveFileDialog As System.Windows.Forms.SaveFileDialog
	Private openFileDialog As System.Windows.Forms.OpenFileDialog
	Private fontTOuni As System.Windows.Forms.RadioButton
	Private uniTOfont As System.Windows.Forms.RadioButton
	Private savetextBTN As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private outputfontBTN As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private outputBox As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private inputBox As System.Windows.Forms.TextBox
	Private convertBTN As System.Windows.Forms.Button
	Private loadfileBTN As System.Windows.Forms.Button
End Class
