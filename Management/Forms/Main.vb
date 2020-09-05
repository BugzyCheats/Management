Imports System.IO

Public Class Main
    Private ReadOnly tempPath As String = Path.GetTempPath
    Private ReadOnly tempCount As String() = Directory.GetFiles(tempPath, $"*.*", SearchOption.AllDirectories)

    Private ReadOnly prefetchPath As String = $"C:\Windows\Prefetch"
    Private ReadOnly PFfileAmount As String() = Directory.GetFiles(prefetchPath, $"*.*", SearchOption.AllDirectories)

    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32
    Private Const SHERB_NOCONFIRMATION = &H1
    Private Const SHERB_NOPROGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4

    Private Sub ClearRecycleBin()
        Try
            SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION + SHERB_NOSOUND)
            SHUpdateRecycleBinIcon()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Bin_Click(sender As Object, e As EventArgs) Handles Bin.Click
        ClearRecycleBin()
    End Sub

    Private Sub ClearClipboard()
        Try
            My.Computer.Clipboard.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Clipboard_Click(sender As Object, e As EventArgs) Handles Clipboard.Click
        ClearClipboard()
    End Sub

    Private Sub ClearTemp()
        For Each TMPdeleteFile As String In tempCount
            Try
                My.Computer.FileSystem.DeleteDirectory(tempPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub Temp_Click(sender As Object, e As EventArgs) Handles Temp.Click
        ClearTemp()
    End Sub

    Private Sub ClearPrefetch()
        For Each PFdeleteFile As String In PFfileAmount
            Try
                My.Computer.FileSystem.DeleteDirectory(prefetchPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub Prefetch_Click(sender As Object, e As EventArgs) Handles Prefetch.Click
        ClearPrefetch()
    End Sub

    Private Sub FlushDNS()
        Shell($"cmd.exe /c ipconfig -flushdns")
    End Sub

    Private Sub Dns_Click(sender As Object, e As EventArgs) Handles Dns.Click
        FlushDNS()
    End Sub
End Class