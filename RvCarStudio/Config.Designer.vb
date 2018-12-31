<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.ComboBoxLang = New System.Windows.Forms.ComboBox()
        Me.trans = New System.Windows.Forms.Label()
        Me.FileSelectPanel = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Up = New System.Windows.Forms.Button()
        Me.FileSelectView = New System.Windows.Forms.ListView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.FileSelectPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 126)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1129, 28)
        Me.Panel1.TabIndex = 1
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(1129, 28)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Title"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLang.FormattingEnabled = True
        Me.ComboBoxLang.Location = New System.Drawing.Point(86, 192)
        Me.ComboBoxLang.Name = "ComboBox1"
        Me.ComboBoxLang.Size = New System.Drawing.Size(244, 21)
        Me.ComboBoxLang.TabIndex = 2
        '
        'trans
        '
        Me.trans.AutoSize = True
        Me.trans.Location = New System.Drawing.Point(367, 196)
        Me.trans.Name = "trans"
        Me.trans.Size = New System.Drawing.Size(57, 13)
        Me.trans.TabIndex = 5
        Me.trans.Text = "Translator:"
        '
        'Panel2
        '
        Me.FileSelectPanel.Controls.Add(Me.TextBox7)
        Me.FileSelectPanel.Controls.Add(Me.Button3)
        Me.FileSelectPanel.Controls.Add(Me.GroupBox2)
        Me.FileSelectPanel.Controls.Add(Me.GroupBox1)
        Me.FileSelectPanel.Controls.Add(Me.Up)
        Me.FileSelectPanel.Controls.Add(Me.FileSelectView)
        Me.FileSelectPanel.Location = New System.Drawing.Point(593, 47)
        Me.FileSelectPanel.Name = "Panel2"
        Me.FileSelectPanel.Size = New System.Drawing.Size(533, 186)
        Me.FileSelectPanel.TabIndex = 6
        Me.FileSelectPanel.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Snow
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.ForeColor = System.Drawing.Color.Black
        Me.TextBox7.Location = New System.Drawing.Point(3, 162)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(523, 20)
        Me.TextBox7.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCyan
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.CarStudio.My.Resources.Resources.reload
        Me.Button3.Location = New System.Drawing.Point(41, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 28)
        Me.Button3.TabIndex = 29
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(81, -4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 37)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Location = New System.Drawing.Point(121, 11)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Special folders:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(384, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 37)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Drive:"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Location = New System.Drawing.Point(60, 11)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(65, 21)
        Me.ComboBox3.TabIndex = 21
        '
        'Up
        '
        Me.Up.BackColor = System.Drawing.Color.LightCyan
        Me.Up.BackgroundImage = CType(resources.GetObject("Up.BackgroundImage"), System.Drawing.Image)
        Me.Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Up.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Up.ForeColor = System.Drawing.Color.White
        Me.Up.Image = Global.CarStudio.My.Resources.Resources.undo
        Me.Up.Location = New System.Drawing.Point(5, 5)
        Me.Up.Name = "Up"
        Me.Up.Size = New System.Drawing.Size(30, 27)
        Me.Up.TabIndex = 26
        Me.Up.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.FileSelectView.BackColor = System.Drawing.Color.Azure
        Me.FileSelectView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileSelectView.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FileSelectView.ForeColor = System.Drawing.Color.Black
        Me.FileSelectView.Location = New System.Drawing.Point(3, 36)
        Me.FileSelectView.MultiSelect = False
        Me.FileSelectView.Name = "ListView1"
        Me.FileSelectView.Size = New System.Drawing.Size(521, 128)
        Me.FileSelectView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.FileSelectView.TabIndex = 20
        Me.FileSelectView.UseCompatibleStateImageBehavior = False
        Me.FileSelectView.View = System.Windows.Forms.View.List
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.CarStudio.My.Resources.Resources.Button
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Prev>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.ButtonNext.BackgroundImage = Global.CarStudio.My.Resources.Resources.Button
        Me.ButtonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNext.FlatAppearance.BorderSize = 0
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNext.ForeColor = System.Drawing.Color.White
        Me.ButtonNext.Location = New System.Drawing.Point(400, 255)
        Me.ButtonNext.Name = "Button1"
        Me.ButtonNext.Size = New System.Drawing.Size(131, 28)
        Me.ButtonNext.TabIndex = 3
        Me.ButtonNext.Text = "&Next >"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1129, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.FileSelectPanel)
        Me.Controls.Add(Me.trans)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ComboBoxLang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.FileSelectPanel.ResumeLayout(False)
        Me.FileSelectPanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents ComboBoxLang As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents trans As System.Windows.Forms.Label
    Friend WithEvents FileSelectPanel As System.Windows.Forms.Panel
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents FileSelectView As System.Windows.Forms.ListView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Up As System.Windows.Forms.Button

End Class
