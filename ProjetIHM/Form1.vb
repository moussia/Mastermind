Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonJouer_Click(sender As Object, e As EventArgs) Handles ButtonEnregistrer.Click
        setNomJoueur(1, Joueur1.Text)
        setNomJoueur(2, Joueur2.Text)
        My.Forms.Form2.Show()
        Me.Hide()
        Me.clear()
    End Sub


    Private Sub bouttonAnnuler_Click(sender As Object, e As EventArgs) Handles bouttonAnnuler.Click
        clear()
    End Sub

    Sub clear()
        Joueur1.Text = ""
        Joueur2.Text = ""
    End Sub

End Class
