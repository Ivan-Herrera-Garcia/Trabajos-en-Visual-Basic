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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.N1 = New System.Windows.Forms.NumericUpDown()
        Me.N2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.N3 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ma = New System.Windows.Forms.RadioButton()
        Me.Men = New System.Windows.Forms.RadioButton()
        CType(Me.N1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1"
        '
        'N1
        '
        Me.N1.Location = New System.Drawing.Point(66, 59)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(109, 20)
        Me.N1.TabIndex = 1
        '
        'N2
        '
        Me.N2.Location = New System.Drawing.Point(66, 85)
        Me.N2.Name = "N2"
        Me.N2.Size = New System.Drawing.Size(109, 20)
        Me.N2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor 2"
        '
        'N3
        '
        Me.N3.Location = New System.Drawing.Point(66, 111)
        Me.N3.Name = "N3"
        Me.N3.Size = New System.Drawing.Size(109, 20)
        Me.N3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor 3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(91, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(171, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 34)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ma)
        Me.GroupBox1.Controls.Add(Me.Men)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 45)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Que numero quiere encontrar?"
        '
        'Ma
        '
        Me.Ma.AutoSize = True
        Me.Ma.Location = New System.Drawing.Point(140, 17)
        Me.Ma.Name = "Ma"
        Me.Ma.Size = New System.Drawing.Size(54, 17)
        Me.Ma.TabIndex = 1
        Me.Ma.TabStop = True
        Me.Ma.Text = "Mayor"
        Me.Ma.UseVisualStyleBackColor = True
        '
        'Men
        '
        Me.Men.AutoSize = True
        Me.Men.Checked = True
        Me.Men.Location = New System.Drawing.Point(18, 17)
        Me.Men.Name = "Men"
        Me.Men.Size = New System.Drawing.Size(55, 17)
        Me.Men.TabIndex = 0
        Me.Men.TabStop = True
        Me.Men.Text = "Menor"
        Me.Men.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 183)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.N3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.N2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.N1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Menor o Mayor"
        CType(Me.N1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents N1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents N2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents N3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Ma As System.Windows.Forms.RadioButton
    Friend WithEvents Men As System.Windows.Forms.RadioButton

End Class
