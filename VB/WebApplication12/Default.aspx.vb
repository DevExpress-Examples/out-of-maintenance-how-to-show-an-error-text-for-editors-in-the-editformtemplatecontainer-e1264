Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors
Imports System.Collections.Generic

Namespace WebApplication12


	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected errorList As Dictionary(Of GridViewColumn, String)

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub ASPxGridView1_RowValidating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataValidationEventArgs)
			If e.NewValues("CategoryName").ToString().Length > 16 Then
				Dim col As GridViewDataColumn = TryCast((CType(sender, ASPxGridView)).Columns("CategoryName"), GridViewDataColumn)
				e.Errors.Add(col, "The name is too long")


			End If
			errorList = e.Errors
		End Sub

		Protected Sub ShowFieldError(ByVal templateEditor As ASPxEdit, ByVal errorColumn As GridViewDataColumn)
			If errorList IsNot Nothing Then
				For i As Integer = 0 To errorList.Count - 1
					If errorList.ContainsKey(errorColumn) Then
						Dim errorText As String = errorList(errorColumn)
						templateEditor.IsValid = False
						templateEditor.ValidationSettings.ErrorText = errorText
					End If
				Next i
			End If
		End Sub

		Protected Sub ASPxTextBox1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim col As GridViewDataColumn = TryCast(ASPxGridView1.Columns("CategoryName"), GridViewDataColumn)
			ShowFieldError((TryCast(sender, ASPxTextBox)),col)
		End Sub
	End Class
End Namespace
