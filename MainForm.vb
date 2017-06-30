'
' Created by SharpDevelop.
' User: IP-Man
' Date: 6/27/2017
' Time: 9:55 PM
' 
Imports System.IO
Imports System.Drawing.Font
Public Partial Class MainForm
	
	Dim inputfile,inputfilename As String 
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Function DoConvert(inputText As String)		
		Dim uni,font As String
		Dim TotalLines As Integer = File.ReadAllLines("charlist.txt").Length
		For Each Line As String In File.ReadLines("charlist.txt")
			If Line.Contains("-") Then
				uni=Line.Split("-")(0)
				font=Line.Split("-")(1)	
				inputText=inputText.Replace(uni,font)	
				
			End If
		Next
		
		Return inputText
	End Function
	
	Sub OutputfontBTNClick(sender As Object, e As EventArgs)
		Dim objFontDlg As New FontDialog
		If objFontDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
			outputBox.Font = objFontDlg.Font
			outputfontBTN.Text = objFontDlg.Font.Name
		End If
	End Sub
	
	Sub ConvertBTNClick(sender As Object, e As EventArgs)
		outputBox.Text=DoConvert(inputBox.Text)
	End Sub
	
	Sub LoadfileBTNClick(sender As Object, e As EventArgs)
		If openFileDialog.ShowDialog()=DialogResult.OK Then
			inputfile=openFileDialog.FileName
			inputfilename=System.IO.Path.GetFileName(inputfile)
			inputfile=File.ReadAllText(inputfile)
			inputBox.Text = inputfile
		End If 	
	End Sub
	
	Sub SavetextBTNClick(sender As Object, e As EventArgs)
		saveFileDialog.FileName="converted_" & inputfilename
		If saveFileDialog.ShowDialog() = DialogResult.OK Then
			System.IO.File.WriteAllText(saveFileDialog.FileName,outputBox.Text)
		End If
	End Sub
End Class
