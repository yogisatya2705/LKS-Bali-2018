﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAdminNavigation
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
        Me.blogout = New System.Windows.Forms.Button()
        Me.bscore = New System.Windows.Forms.Button()
        Me.bschedule = New System.Windows.Forms.Button()
        Me.bedit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'blogout
        '
        Me.blogout.Location = New System.Drawing.Point(202, 22)
        Me.blogout.Name = "blogout"
        Me.blogout.Size = New System.Drawing.Size(83, 29)
        Me.blogout.TabIndex = 8
        Me.blogout.Text = "Logout"
        Me.blogout.UseVisualStyleBackColor = True
        '
        'bscore
        '
        Me.bscore.Location = New System.Drawing.Point(16, 145)
        Me.bscore.Name = "bscore"
        Me.bscore.Size = New System.Drawing.Size(131, 29)
        Me.bscore.TabIndex = 9
        Me.bscore.Text = "Manage Class"
        Me.bscore.UseVisualStyleBackColor = True
        '
        'bschedule
        '
        Me.bschedule.Location = New System.Drawing.Point(16, 110)
        Me.bschedule.Name = "bschedule"
        Me.bschedule.Size = New System.Drawing.Size(131, 29)
        Me.bschedule.TabIndex = 10
        Me.bschedule.Text = "Manage Teacher"
        Me.bschedule.UseVisualStyleBackColor = True
        '
        'bedit
        '
        Me.bedit.Location = New System.Drawing.Point(16, 75)
        Me.bedit.Name = "bedit"
        Me.bedit.Size = New System.Drawing.Size(131, 29)
        Me.bedit.TabIndex = 11
        Me.bedit.Text = "Manage Student"
        Me.bedit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome, [ Nama Admin ]"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Manage Schedule"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(154, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Finalize Schedule"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(154, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 29)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "View Report Score"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FAdminNavigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 190)
        Me.Controls.Add(Me.blogout)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bscore)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bschedule)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bedit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FAdminNavigation"
        Me.Text = "FAdminNavigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blogout As System.Windows.Forms.Button
    Friend WithEvents bscore As System.Windows.Forms.Button
    Friend WithEvents bschedule As System.Windows.Forms.Button
    Friend WithEvents bedit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class