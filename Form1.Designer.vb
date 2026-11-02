<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdditionner = New System.Windows.Forms.RadioButton()
        Me.txtMultiplication = New System.Windows.Forms.RadioButton()
        Me.txtSoustraction = New System.Windows.Forms.RadioButton()
        Me.txtDivision = New System.Windows.Forms.RadioButton()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultat = New System.Windows.Forms.TextBox()
        Me.txtCalculer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDivision)
        Me.GroupBox1.Controls.Add(Me.txtSoustraction)
        Me.GroupBox1.Controls.Add(Me.txtMultiplication)
        Me.GroupBox1.Controls.Add(Me.txtAdditionner)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 214)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selectionner Une Operation"
        '
        'txtAdditionner
        '
        Me.txtAdditionner.AutoSize = True
        Me.txtAdditionner.Location = New System.Drawing.Point(38, 53)
        Me.txtAdditionner.Name = "txtAdditionner"
        Me.txtAdditionner.Size = New System.Drawing.Size(92, 24)
        Me.txtAdditionner.TabIndex = 0
        Me.txtAdditionner.TabStop = True
        Me.txtAdditionner.Text = "Addition"
        Me.txtAdditionner.UseVisualStyleBackColor = True
        '
        'txtMultiplication
        '
        Me.txtMultiplication.AutoSize = True
        Me.txtMultiplication.Location = New System.Drawing.Point(38, 83)
        Me.txtMultiplication.Name = "txtMultiplication"
        Me.txtMultiplication.Size = New System.Drawing.Size(122, 24)
        Me.txtMultiplication.TabIndex = 1
        Me.txtMultiplication.TabStop = True
        Me.txtMultiplication.Text = "Mutiplication"
        Me.txtMultiplication.UseVisualStyleBackColor = True
        '
        'txtSoustraction
        '
        Me.txtSoustraction.AutoSize = True
        Me.txtSoustraction.Location = New System.Drawing.Point(38, 113)
        Me.txtSoustraction.Name = "txtSoustraction"
        Me.txtSoustraction.Size = New System.Drawing.Size(124, 24)
        Me.txtSoustraction.TabIndex = 2
        Me.txtSoustraction.TabStop = True
        Me.txtSoustraction.Text = "Soustraction"
        Me.txtSoustraction.UseVisualStyleBackColor = True
        '
        'txtDivision
        '
        Me.txtDivision.AutoSize = True
        Me.txtDivision.Location = New System.Drawing.Point(38, 143)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(88, 24)
        Me.txtDivision.TabIndex = 3
        Me.txtDivision.TabStop = True
        Me.txtDivision.Text = "Division"
        Me.txtDivision.UseVisualStyleBackColor = True
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(233, 90)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(100, 26)
        Me.txtNombre1.TabIndex = 3
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(233, 146)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(100, 26)
        Me.txtNombre2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultat"
        '
        'txtResultat
        '
        Me.txtResultat.Location = New System.Drawing.Point(233, 43)
        Me.txtResultat.Name = "txtResultat"
        Me.txtResultat.Size = New System.Drawing.Size(100, 26)
        Me.txtResultat.TabIndex = 6
        '
        'txtCalculer
        '
        Me.txtCalculer.Location = New System.Drawing.Point(515, 146)
        Me.txtCalculer.Name = "txtCalculer"
        Me.txtCalculer.Size = New System.Drawing.Size(115, 26)
        Me.txtCalculer.TabIndex = 7
        Me.txtCalculer.Text = "Calculer"
        Me.txtCalculer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCalculer)
        Me.Controls.Add(Me.txtResultat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre2)
        Me.Controls.Add(Me.txtNombre1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDivision As RadioButton
    Friend WithEvents txtSoustraction As RadioButton
    Friend WithEvents txtMultiplication As RadioButton
    Friend WithEvents txtAdditionner As RadioButton
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultat As TextBox
    Friend WithEvents txtCalculer As Button
End Class
