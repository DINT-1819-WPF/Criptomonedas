Class MainWindow
    Private Sub Image_MouseUp(sender As Object, e As MouseButtonEventArgs)
        NombreTextBlock.DataContext = sender
    End Sub
End Class
