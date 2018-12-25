<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.chart = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHousing = New System.Windows.Forms.TextBox()
        Me.txtTransport = New System.Windows.Forms.TextBox()
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chart
        '
        Me.chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chart.Location = New System.Drawing.Point(12, 278)
        Me.chart.Name = "chart"
        Me.chart.Size = New System.Drawing.Size(743, 353)
        Me.chart.TabIndex = 0
        Me.chart.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Housing:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transportation:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Food:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Other:"
        '
        'txtHousing
        '
        Me.txtHousing.Location = New System.Drawing.Point(82, 24)
        Me.txtHousing.Name = "txtHousing"
        Me.txtHousing.Size = New System.Drawing.Size(158, 22)
        Me.txtHousing.TabIndex = 5
        Me.txtHousing.Text = "9700"
        '
        'txtTransport
        '
        Me.txtTransport.Location = New System.Drawing.Point(123, 103)
        Me.txtTransport.Name = "txtTransport"
        Me.txtTransport.Size = New System.Drawing.Size(158, 22)
        Me.txtTransport.TabIndex = 6
        Me.txtTransport.Text = "4800"
        '
        'txtFood
        '
        Me.txtFood.Location = New System.Drawing.Point(360, 21)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(158, 22)
        Me.txtFood.TabIndex = 7
        Me.txtFood.Text = "3900"
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(364, 98)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(158, 22)
        Me.txtOther.TabIndex = 8
        Me.txtOther.Text = "6000"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(636, 24)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(92, 76)
        Me.btnDisplay.TabIndex = 9
        Me.btnDisplay.Text = "Display Chart"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 643)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.txtFood)
        Me.Controls.Add(Me.txtTransport)
        Me.Controls.Add(Me.txtHousing)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chart)
        Me.Name = "Form1"
        Me.Text = "Budget"
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chart As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHousing As TextBox
    Friend WithEvents txtTransport As TextBox
    Friend WithEvents txtFood As TextBox
    Friend WithEvents txtOther As TextBox
    Friend WithEvents btnDisplay As Button
End Class
