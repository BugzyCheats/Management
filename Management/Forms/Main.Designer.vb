<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Management = New Management.UbuntuTheme()
        Me.Dns = New Management.UbuntuButtonOrange()
        Me.Prefetch = New Management.UbuntuButtonOrange()
        Me.Temp = New Management.UbuntuButtonOrange()
        Me.Clipboard = New Management.UbuntuButtonGray()
        Me.Bin = New Management.UbuntuButtonGray()
        Me.UbuntuControlBox1 = New Management.UbuntuControlBox()
        Me.Management.SuspendLayout()
        Me.SuspendLayout()
        '
        'Management
        '
        Me.Management.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Management.Controls.Add(Me.Dns)
        Me.Management.Controls.Add(Me.Prefetch)
        Me.Management.Controls.Add(Me.Temp)
        Me.Management.Controls.Add(Me.Clipboard)
        Me.Management.Controls.Add(Me.Bin)
        Me.Management.Controls.Add(Me.UbuntuControlBox1)
        Me.Management.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Management.Location = New System.Drawing.Point(0, 0)
        Me.Management.Name = "Management"
        Me.Management.Size = New System.Drawing.Size(320, 176)
        Me.Management.TabIndex = 0
        Me.Management.Text = "Management"
        '
        'Dns
        '
        Me.Dns.BackColor = System.Drawing.Color.Transparent
        Me.Dns.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Dns.Location = New System.Drawing.Point(12, 141)
        Me.Dns.Name = "Dns"
        Me.Dns.Size = New System.Drawing.Size(296, 23)
        Me.Dns.TabIndex = 5
        Me.Dns.Text = "Flush DNS Cache"
        '
        'Prefetch
        '
        Me.Prefetch.BackColor = System.Drawing.Color.Transparent
        Me.Prefetch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Prefetch.Location = New System.Drawing.Point(12, 115)
        Me.Prefetch.Name = "Prefetch"
        Me.Prefetch.Size = New System.Drawing.Size(296, 23)
        Me.Prefetch.TabIndex = 4
        Me.Prefetch.Text = "Clear Prefetch Files"
        '
        'Temp
        '
        Me.Temp.BackColor = System.Drawing.Color.Transparent
        Me.Temp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Temp.Location = New System.Drawing.Point(12, 89)
        Me.Temp.Name = "Temp"
        Me.Temp.Size = New System.Drawing.Size(296, 23)
        Me.Temp.TabIndex = 3
        Me.Temp.Text = "Clear Temp Files"
        '
        'Clipboard
        '
        Me.Clipboard.BackColor = System.Drawing.Color.Transparent
        Me.Clipboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Clipboard.Location = New System.Drawing.Point(12, 63)
        Me.Clipboard.Name = "Clipboard"
        Me.Clipboard.Size = New System.Drawing.Size(296, 23)
        Me.Clipboard.TabIndex = 2
        Me.Clipboard.Text = "Clear Clipboard"
        '
        'Bin
        '
        Me.Bin.BackColor = System.Drawing.Color.Transparent
        Me.Bin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Bin.Location = New System.Drawing.Point(12, 37)
        Me.Bin.Name = "Bin"
        Me.Bin.Size = New System.Drawing.Size(296, 23)
        Me.Bin.TabIndex = 1
        Me.Bin.Text = "Clear Recycle Bin"
        '
        'UbuntuControlBox1
        '
        Me.UbuntuControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UbuntuControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.UbuntuControlBox1.Font = New System.Drawing.Font("Marlett", 7.0!)
        Me.UbuntuControlBox1.Location = New System.Drawing.Point(256, 2)
        Me.UbuntuControlBox1.Name = "UbuntuControlBox1"
        Me.UbuntuControlBox1.Size = New System.Drawing.Size(75, 23)
        Me.UbuntuControlBox1.TabIndex = 0
        Me.UbuntuControlBox1.Text = "UbuntuControlBox1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 176)
        Me.Controls.Add(Me.Management)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Management.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Management As UbuntuTheme
    Friend WithEvents UbuntuControlBox1 As UbuntuControlBox
    Friend WithEvents Dns As UbuntuButtonOrange
    Friend WithEvents Prefetch As UbuntuButtonOrange
    Friend WithEvents Temp As UbuntuButtonOrange
    Friend WithEvents Clipboard As UbuntuButtonGray
    Friend WithEvents Bin As UbuntuButtonGray
End Class
