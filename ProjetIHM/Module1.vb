Module Module1

    Dim nomJ1 As String
    Dim nomJ2 As String

    Sub main()
        Application.Run(Form1)
    End Sub

    Function getNomJoueur(i As Integer) As String
        If i = 1 Then
            Return nomJ1
        Else
            Return nomJ2
        End If
    End Function

    Function setNomJoueur(i As Integer, nom As String)
        If i = 1 Then
            nomJ1 = nom
        Else
            nomJ2 = nom
        End If
    End Function

End Module
