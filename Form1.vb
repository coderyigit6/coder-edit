Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    ' The "Save" button's functionality
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ' Use SaveFileDialog to let user choose where to save
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        sfd.Title = "Save the file as..."

        If sfd.ShowDialog() = DialogResult.OK Then
            ' Write the contents of the RichTextBox to the chosen file
            System.IO.File.WriteAllText(sfd.FileName, RichTextBox1.Text)
            MessageBox.Show("File saved successfully :)", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Example: Load text from a file into a TextBox
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        ' Use OpenFileDialog to let user choose a file
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        ofd.Title = "Open a file..."

        If ofd.ShowDialog() = DialogResult.OK Then
            ' Read the contents of the chosen file
            Dim fileContent As String = System.IO.File.ReadAllText(ofd.FileName)
            RichTextBox1.Text = fileContent
            MessageBox.Show("File loaded successfully :)", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    ' Declare the form at class level
    Private frm As Form1

    Private Sub NewFileButton_Click(sender As Object, e As EventArgs) Handles NewFileButton.Click
        ' If the form is Nothing (not created yet) or disposed, create it
        If frm Is Nothing OrElse frm.IsDisposed Then
            frm = New Form1()
        End If

        ' Show the same instance
        frm.Show()

        ' Optionally bring it to front if already open
        frm.BringToFront()
    End Sub

End Class