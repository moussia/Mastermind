<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.LabelCombinaison = New System.Windows.Forms.Label()
        Me.LabelMasterMind = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LabelCaractère = New System.Windows.Forms.Label()
        Me.LabelVraiCaractère = New System.Windows.Forms.Label()
        Me.ButtonCacher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelCombinaison
        '
        Me.LabelCombinaison.AutoSize = True
        Me.LabelCombinaison.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCombinaison.Location = New System.Drawing.Point(105, 115)
        Me.LabelCombinaison.Name = "LabelCombinaison"
        Me.LabelCombinaison.Size = New System.Drawing.Size(319, 22)
        Me.LabelCombinaison.TabIndex = 0
        Me.LabelCombinaison.Text = "Veuillez entrer votre combinaison svp "
        '
        'LabelMasterMind
        '
        Me.LabelMasterMind.AutoSize = True
        Me.LabelMasterMind.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMasterMind.ForeColor = System.Drawing.Color.Black
        Me.LabelMasterMind.Location = New System.Drawing.Point(171, 43)
        Me.LabelMasterMind.Name = "LabelMasterMind"
        Me.LabelMasterMind.Size = New System.Drawing.Size(173, 31)
        Me.LabelMasterMind.TabIndex = 1
        Me.LabelMasterMind.Text = "Master Mind"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(73, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(145, 170)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(37, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(218, 170)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(29, 20)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(282, 170)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(28, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(354, 170)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(30, 20)
        Me.TextBox5.TabIndex = 6
        '
        'LabelCaractère
        '
        Me.LabelCaractère.AutoSize = True
        Me.LabelCaractère.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaractère.Location = New System.Drawing.Point(292, 219)
        Me.LabelCaractère.Name = "LabelCaractère"
        Me.LabelCaractère.Size = New System.Drawing.Size(157, 17)
        Me.LabelCaractère.TabIndex = 7
        Me.LabelCaractère.Text = "Caractères Jouables"
        '
        'LabelVraiCaractère
        '
        Me.LabelVraiCaractère.AutoSize = True
        Me.LabelVraiCaractère.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVraiCaractère.Location = New System.Drawing.Point(341, 255)
        Me.LabelVraiCaractère.Name = "LabelVraiCaractère"
        Me.LabelVraiCaractère.Size = New System.Drawing.Size(57, 13)
        Me.LabelVraiCaractère.TabIndex = 8
        Me.LabelVraiCaractère.Text = "# $ £ % @"
        '
        'ButtonCacher
        '
        Me.ButtonCacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCacher.Location = New System.Drawing.Point(411, 170)
        Me.ButtonCacher.Name = "ButtonCacher"
        Me.ButtonCacher.Size = New System.Drawing.Size(87, 23)
        Me.ButtonCacher.TabIndex = 9
        Me.ButtonCacher.Text = "Cacher"
        Me.ButtonCacher.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(553, 328)
        Me.Controls.Add(Me.ButtonCacher)
        Me.Controls.Add(Me.LabelVraiCaractère)
        Me.Controls.Add(Me.LabelCaractère)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelMasterMind)
        Me.Controls.Add(Me.LabelCombinaison)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCombinaison As System.Windows.Forms.Label
    Friend WithEvents LabelMasterMind As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents LabelCaractère As System.Windows.Forms.Label
    Friend WithEvents LabelVraiCaractère As System.Windows.Forms.Label
    Friend WithEvents ButtonCacher As System.Windows.Forms.Button

End Class
