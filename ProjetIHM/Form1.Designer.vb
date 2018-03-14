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
        Me.Joueur1 = New System.Windows.Forms.TextBox()
        Me.Joueur2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.titre = New System.Windows.Forms.Label()
        Me.Enregistrement = New System.Windows.Forms.Label()
        Me.ButtonEnregistrer = New System.Windows.Forms.Button()
        Me.bouttonAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Joueur1
        '
        Me.Joueur1.Location = New System.Drawing.Point(229, 116)
        Me.Joueur1.Name = "Joueur1"
        Me.Joueur1.Size = New System.Drawing.Size(100, 20)
        Me.Joueur1.TabIndex = 0
        '
        'Joueur2
        '
        Me.Joueur2.Location = New System.Drawing.Point(229, 163)
        Me.Joueur2.Name = "Joueur2"
        Me.Joueur2.Size = New System.Drawing.Size(100, 20)
        Me.Joueur2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Joueur1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Joueur2"
        '
        'titre
        '
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.Location = New System.Drawing.Point(163, 19)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(90, 13)
        Me.titre.TabIndex = 4
        Me.titre.Text = "MASTERMIND"
        Me.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Enregistrement
        '
        Me.Enregistrement.AutoSize = True
        Me.Enregistrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enregistrement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enregistrement.Location = New System.Drawing.Point(73, 78)
        Me.Enregistrement.Name = "Enregistrement"
        Me.Enregistrement.Size = New System.Drawing.Size(123, 13)
        Me.Enregistrement.TabIndex = 5
        Me.Enregistrement.Text = "Veuilliez saisir vos nom : "
        '
        'ButtonEnregistrer
        '
        Me.ButtonEnregistrer.Location = New System.Drawing.Point(253, 211)
        Me.ButtonEnregistrer.Name = "ButtonEnregistrer"
        Me.ButtonEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEnregistrer.TabIndex = 6
        Me.ButtonEnregistrer.Text = "Enregistrer"
        Me.ButtonEnregistrer.UseVisualStyleBackColor = True
        '
        'bouttonAnnuler
        '
        Me.bouttonAnnuler.Location = New System.Drawing.Point(67, 211)
        Me.bouttonAnnuler.Name = "bouttonAnnuler"
        Me.bouttonAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.bouttonAnnuler.TabIndex = 7
        Me.bouttonAnnuler.Text = "Annuler"
        Me.bouttonAnnuler.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 261)
        Me.Controls.Add(Me.bouttonAnnuler)
        Me.Controls.Add(Me.ButtonEnregistrer)
        Me.Controls.Add(Me.Enregistrement)
        Me.Controls.Add(Me.titre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Joueur2)
        Me.Controls.Add(Me.Joueur1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Joueur1 As System.Windows.Forms.TextBox
    Friend WithEvents Joueur2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents titre As System.Windows.Forms.Label
    Friend WithEvents Enregistrement As System.Windows.Forms.Label
    Friend WithEvents ButtonEnregistrer As System.Windows.Forms.Button
    Friend WithEvents bouttonAnnuler As System.Windows.Forms.Button

End Class
