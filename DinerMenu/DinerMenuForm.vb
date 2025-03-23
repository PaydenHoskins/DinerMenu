'Payden Hoskins
'RCET2265
'Spring 2026
'Diner Menu Program
'https://github.com/PaydenHoskins/DinerMenu.git



Public Class DinerMenuForm
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        'display salad item
        DisplaySpecialLabel.Text = "~Salad of the Day~" & vbNewLine _
            & "Buona buona insalata" & vbNewLine _
            & vbNewLine _
            & "Questa è un'insalata molto" & vbNewLine _
            & "buona con formaggio e" & vbNewLine _
            & "sottaceti, ma noi la friggiamo."
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Close and end
        Me.Close()
        End
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        'Displays fish item
        DisplaySpecialLabel.Text = "~Fish of the Day~" & vbNewLine _
            & "Hamburger Di Pesce" & vbNewLine _
           & vbNewLine _
           & "un delizioso piatto di pesce che" & vbNewLine _
           & "in realtà" & vbNewLine _
           & "è un hamburger travestito."
    End Sub
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        'displays soup item
        DisplaySpecialLabel.Text = "~Soup of the Day~" & vbNewLine _
            & "Zuppa di vongole" & vbNewLine _
           & vbNewLine _
           & "Vongole sotto forma di zuppa," & vbNewLine _
           & "ottima per le giornate" & vbNewLine _
           & "fredde o qualcosa del genere."
    End Sub
End Class
