<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gar = New Button()
        pogi = New TextBox()
        love = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' gar
        ' 
        gar.Location = New Point(208, 69)
        gar.Name = "gar"
        gar.Size = New Size(75, 23)
        gar.TabIndex = 0
        gar.Text = "division"
        gar.UseVisualStyleBackColor = True
        ' 
        ' pogi
        ' 
        pogi.Location = New Point(23, 69)
        pogi.Name = "pogi"
        pogi.Size = New Size(100, 23)
        pogi.TabIndex = 1
        ' 
        ' love
        ' 
        love.Location = New Point(370, 69)
        love.Name = "love"
        love.Size = New Size(100, 23)
        love.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 3
        Label1.Text = "fafa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(405, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 4
        Label2.Text = "mwahh"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(536, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 5
        Label3.Text = "sagotttttttt"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(love)
        Controls.Add(pogi)
        Controls.Add(gar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gar As Button
    Friend WithEvents pogi As TextBox
    Friend WithEvents love As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
