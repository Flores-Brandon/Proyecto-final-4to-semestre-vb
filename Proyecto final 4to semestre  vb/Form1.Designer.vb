<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSaveToJson = New System.Windows.Forms.Button()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.btnLoadFromDatabase = New System.Windows.Forms.Button()
        Me.btnSaveToDatabase = New System.Windows.Forms.Button()
        Me.btnSaveToXML = New System.Windows.Forms.Button()
        Me.btnAddrow = New System.Windows.Forms.Button()
        Me.btnSaveToCSV = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveToJson
        '
        Me.btnSaveToJson.Location = New System.Drawing.Point(449, 180)
        Me.btnSaveToJson.Name = "btnSaveToJson"
        Me.btnSaveToJson.Size = New System.Drawing.Size(121, 23)
        Me.btnSaveToJson.TabIndex = 23
        Me.btnSaveToJson.Text = "SaveToJSON"
        Me.btnSaveToJson.UseVisualStyleBackColor = True
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(33, 279)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFile.TabIndex = 22
        Me.btnLoadFile.Text = "LoadFile"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'btnLoadFromDatabase
        '
        Me.btnLoadFromDatabase.Location = New System.Drawing.Point(33, 387)
        Me.btnLoadFromDatabase.Name = "btnLoadFromDatabase"
        Me.btnLoadFromDatabase.Size = New System.Drawing.Size(143, 23)
        Me.btnLoadFromDatabase.TabIndex = 21
        Me.btnLoadFromDatabase.Text = "LoadFromDatabase"
        Me.btnLoadFromDatabase.UseVisualStyleBackColor = True
        '
        'btnSaveToDatabase
        '
        Me.btnSaveToDatabase.Location = New System.Drawing.Point(33, 332)
        Me.btnSaveToDatabase.Name = "btnSaveToDatabase"
        Me.btnSaveToDatabase.Size = New System.Drawing.Size(151, 23)
        Me.btnSaveToDatabase.TabIndex = 20
        Me.btnSaveToDatabase.Text = "SaveToDatabase"
        Me.btnSaveToDatabase.UseVisualStyleBackColor = True
        '
        'btnSaveToXML
        '
        Me.btnSaveToXML.Location = New System.Drawing.Point(449, 111)
        Me.btnSaveToXML.Name = "btnSaveToXML"
        Me.btnSaveToXML.Size = New System.Drawing.Size(121, 23)
        Me.btnSaveToXML.TabIndex = 19
        Me.btnSaveToXML.Text = "SaveToXML"
        Me.btnSaveToXML.UseVisualStyleBackColor = True
        '
        'btnAddrow
        '
        Me.btnAddrow.Location = New System.Drawing.Point(449, 250)
        Me.btnAddrow.Name = "btnAddrow"
        Me.btnAddrow.Size = New System.Drawing.Size(75, 23)
        Me.btnAddrow.TabIndex = 18
        Me.btnAddrow.Text = "Add Row"
        Me.btnAddrow.UseVisualStyleBackColor = True
        '
        'btnSaveToCSV
        '
        Me.btnSaveToCSV.Location = New System.Drawing.Point(449, 39)
        Me.btnSaveToCSV.Name = "btnSaveToCSV"
        Me.btnSaveToCSV.Size = New System.Drawing.Size(121, 23)
        Me.btnSaveToCSV.TabIndex = 17
        Me.btnSaveToCSV.Text = "SaveToCSV"
        Me.btnSaveToCSV.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(33, 39)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(387, 234)
        Me.DataGridView2.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSaveToJson)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.btnLoadFromDatabase)
        Me.Controls.Add(Me.btnSaveToDatabase)
        Me.Controls.Add(Me.btnSaveToXML)
        Me.Controls.Add(Me.btnAddrow)
        Me.Controls.Add(Me.btnSaveToCSV)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSaveToJson As Button
    Friend WithEvents btnLoadFile As Button
    Friend WithEvents btnLoadFromDatabase As Button
    Friend WithEvents btnSaveToDatabase As Button
    Friend WithEvents btnSaveToXML As Button
    Friend WithEvents btnAddrow As Button
    Friend WithEvents btnSaveToCSV As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
