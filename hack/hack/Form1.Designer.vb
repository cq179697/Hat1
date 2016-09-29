<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picCT = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        CType(Me.picCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCT
        '
        Me.picCT.Image = CType(resources.GetObject("picCT.Image"), System.Drawing.Image)
        Me.picCT.Location = New System.Drawing.Point(103, 73)
        Me.picCT.Name = "picCT"
        Me.picCT.Size = New System.Drawing.Size(154, 86)
        Me.picCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCT.TabIndex = 0
        Me.picCT.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(116, 205)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 351)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.picCT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCT As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
