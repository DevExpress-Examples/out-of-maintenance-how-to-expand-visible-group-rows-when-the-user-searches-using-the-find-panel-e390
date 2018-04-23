Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Grid

Namespace FindPanelExample
	Partial Public Class MainForm
		Inherits XtraForm
		Private Const Alphabet As String = "abcdefghigklmnopqarstuvwxyz"
		Private Shared Randomizer As New Random()

		Public Sub New()
			InitializeComponent()
			GridControl.BeginUpdate()
			Try
				For i As Integer = 0 To 999
					For j As Integer = 0 To 9
						dataTable1.Rows.Add(GetRandomText(), i)
					Next j
				Next i
			Finally
				GridControl.EndUpdate()
			End Try
		End Sub

		Private Shared Function GetRandomText() As String
			Dim result As New StringBuilder()
			For i As Integer = 0 To 9
				result.Append(Alphabet.Chars(Randomizer.Next(27)))
			Next i
			Return result.ToString()
		End Function

		Private Sub OnGridViewRowCountChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView.RowCountChanged
			If String.IsNullOrEmpty(GridView.FindFilterText) Then
				Return
			End If
			BeginInvoke(New MethodInvoker(AddressOf ExpandVisibleRows))
		End Sub

		Private Sub ExpandVisibleRows()
			Dim rowHandle As Integer
			Dim i As Integer = GridView.TopRowIndex
'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: for (int i = GridView.TopRowIndex; GridView.IsRowVisible(rowHandle = GridView.GetVisibleRowHandle(i)) == RowVisibleState.Visible; i += 1)
			Do While GridView.IsRowVisible(rowHandle = GridView.GetVisibleRowHandle(i)) = RowVisibleState.Visible
				If GridView.IsGroupRow(rowHandle) Then
					GridView.ExpandGroupRow(rowHandle)
				End If
				i += 1
			Loop
		End Sub
	End Class
End Namespace