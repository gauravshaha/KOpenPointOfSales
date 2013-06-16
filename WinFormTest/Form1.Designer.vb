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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(868, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(868, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel7)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(868, 554)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Location = New System.Drawing.Point(23, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Location = New System.Drawing.Point(229, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Location = New System.Drawing.Point(435, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Linen
        Me.Panel4.Location = New System.Drawing.Point(641, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Wheat
        Me.Panel5.Location = New System.Drawing.Point(23, 129)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 100)
        Me.Panel5.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel6.Location = New System.Drawing.Point(229, 129)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 100)
        Me.Panel6.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Khaki
        Me.Panel7.Location = New System.Drawing.Point(435, 129)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 100)
        Me.Panel7.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(868, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel

End Class
