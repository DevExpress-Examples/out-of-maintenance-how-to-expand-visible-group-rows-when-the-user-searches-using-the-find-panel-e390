Imports Microsoft.VisualBasic
Imports System
Namespace FindPanelExample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.GridControl = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colGroup = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' GridControl
			' 
			Me.GridControl.DataSource = Me.bindingSource1
			Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.GridControl.Location = New System.Drawing.Point(0, 0)
			Me.GridControl.MainView = Me.GridView
			Me.GridControl.Name = "GridControl"
			Me.GridControl.Size = New System.Drawing.Size(431, 268)
			Me.GridControl.TabIndex = 0
			Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.GridView})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Name"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Group"
			' 
			' GridView
			' 
			Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colGroup})
			Me.GridView.GridControl = Me.GridControl
			Me.GridView.GroupCount = 1
			Me.GridView.Name = "GridView"
			Me.GridView.OptionsFind.AlwaysVisible = True
			Me.GridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGroup, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.GridView.RowCountChanged += New System.EventHandler(Me.OnGridViewRowCountChanged);
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colGroup
			' 
			Me.colGroup.FieldName = "Group"
			Me.colGroup.Name = "colGroup"
			Me.colGroup.Visible = True
			Me.colGroup.VisibleIndex = 1
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(431, 268)
			Me.Controls.Add(Me.GridControl)
			Me.Name = "MainForm"
			Me.Text = "DX Sample"
			CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private GridControl As DevExpress.XtraGrid.GridControl
		Private WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colGroup As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

