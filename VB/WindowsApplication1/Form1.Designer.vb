﻿Namespace WindowsApplication1
    Partial Public Class Form1
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
            Me.myGridControl1 = New WindowsApplication1.MyGridControl()
            Me.myGridView1 = New WindowsApplication1.MyGridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.myGridControl1.MainView = Me.myGridView1
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(739, 511)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1})
            ' 
            ' myGridView1
            ' 
            Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colTrademark})
            Me.myGridView1.GridControl = Me.myGridControl1
            Me.myGridView1.Name = "myGridView1"
            ' 
            ' colID
            ' 
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colTrademark
            ' 
            Me.colTrademark.Caption = "Trademark"
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            Me.colTrademark.Visible = True
            Me.colTrademark.VisibleIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(739, 511)
            Me.Controls.Add(Me.myGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private myGridControl1 As MyGridControl
        Private myGridView1 As MyGridView
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

