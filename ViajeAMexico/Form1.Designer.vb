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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDias = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbHoras = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tiempo Restante Para Melendi"
        '
        'lbDias
        '
        Me.lbDias.Font = New System.Drawing.Font("Modern No. 20", 26.25!)
        Me.lbDias.ForeColor = System.Drawing.Color.Navy
        Me.lbDias.Location = New System.Drawing.Point(12, 208)
        Me.lbDias.Name = "lbDias"
        Me.lbDias.Size = New System.Drawing.Size(457, 43)
        Me.lbDias.TabIndex = 1
        Me.lbDias.Text = "Dias: 0"
        Me.lbDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CustomFormat = "dd/MMMM/yyyyy HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 93)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(340, 31)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.Value = New Date(2019, 5, 11, 20, 0, 0, 0)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbHoras
        '
        Me.lbHoras.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoras.ForeColor = System.Drawing.Color.DarkRed
        Me.lbHoras.Location = New System.Drawing.Point(12, 251)
        Me.lbHoras.Name = "lbHoras"
        Me.lbHoras.Size = New System.Drawing.Size(457, 43)
        Me.lbHoras.TabIndex = 5
        Me.lbHoras.Text = "Horas: 00:00:00 "
        Me.lbHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(347, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha De Concierto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 310)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbHoras)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbDias)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(501, 353)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(501, 353)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Melendi en Costa Rica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbDias As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbHoras As Label
    Friend WithEvents Label4 As Label
End Class
