<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.FrostTheme1 = New Dark_God_Bot_Launcher.FrostTheme()
        Me.SuspendLayout()
        '
        'FrostTheme1
        '
        Me.FrostTheme1.BackColor = System.Drawing.Color.Black
        Me.FrostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.FrostTheme1.Color1 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.FrostTheme1.Color2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FrostTheme1.Color3 = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.FrostTheme1.Color4 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FrostTheme1.Color5 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FrostTheme1.Color6 = System.Drawing.Color.Red
        Me.FrostTheme1.Colors = New Dark_God_Bot_Launcher.Bloom(-1) {}
        Me.FrostTheme1.Customization = ""
        Me.FrostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrostTheme1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FrostTheme1.Image = Nothing
        Me.FrostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FrostTheme1.Movable = True
        Me.FrostTheme1.Name = "FrostTheme1"
        Me.FrostTheme1.NoRounding = False
        Me.FrostTheme1.Sizable = True
        Me.FrostTheme1.Size = New System.Drawing.Size(470, 400)
        Me.FrostTheme1.SmartBounds = True
        Me.FrostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FrostTheme1.TabIndex = 0
        Me.FrostTheme1.Text = "Live Chat"
        Me.FrostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FrostTheme1.Transparent = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 400)
        Me.Controls.Add(Me.FrostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Live Chat"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrostTheme1 As FrostTheme
End Class
