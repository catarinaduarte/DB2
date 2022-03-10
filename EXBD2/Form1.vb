Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RevistaDataSet.Artigos' table. You can move, or remove it, as needed.
        Me.ArtigosTableAdapter.Fill(Me.RevistaDataSet.Artigos)

    End Sub

    Private Sub ArtigosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtigosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtigosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RevistaDataSet)

    End Sub

    Private Sub TituloArtTextBox_TextChanged(sender As Object, e As EventArgs) Handles TituloArtTextBox.TextChanged

    End Sub

    Private Sub CodArtTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodArtTextBox.TextChanged

    End Sub

    Private Sub BindingNavigatorPositionItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Click

    End Sub
End Class
