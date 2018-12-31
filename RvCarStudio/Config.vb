Public Class Config

    Private Sub Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  Dim V As New OpenTK.GLControl()
        Me.Size = New Size(572, 288)
        FileSelectPanel.Left = 35
        Title.Text = APPNAME
        '  Label1.Text = "Hello and welcome to " & APPNAME & ". Please choose your language"
        ComboBoxLang.SelectedIndex = 1


        Dim drv = IO.Directory.GetLogicalDrives()
        For i = 0 To drv.Count - 1
            ComboBox3.Items.Add(drv(i))
        Next
        With ComboBox2.Items
            .Add(Environment.SpecialFolder.CommonApplicationData)
            .Add(Environment.SpecialFolder.CommonProgramFiles)
            .Add(Environment.SpecialFolder.Desktop)
            .Add(Environment.SpecialFolder.MyDocuments)
            .Add(Environment.SpecialFolder.MyMusic)
            .Add(Environment.SpecialFolder.MyPictures)
            .Add(Environment.SpecialFolder.Personal)
            .Add(Environment.SpecialFolder.ProgramFiles)
            .Add(Environment.SpecialFolder.System)
        End With

    End Sub
    Public Sub OnHover(ByVal sender As Object, ByVal e As Object) Handles ButtonNext.MouseMove, Button2.MouseMove, Button3.MouseMove
        ' If GetType(Object).ToString <> "Button" Then Exit Sub
        If Not (sender.BackgroundImage Is My.Resources.button2) Then sender.BackgroundImage = My.Resources.button2
    End Sub
    Public Sub OnExit(ByVal sender As Object, ByVal e As Object) Handles ButtonNext.MouseLeave, Button2.MouseLeave, Button3.MouseLeave
        '  If GetType(Object).ToString <> "Button" Then Exit Sub
        If Not (sender.BackgroundImage Is My.Resources.Button) Then sender.BackgroundImage = My.Resources.Button

    End Sub
    Public Sub OnDown(ByVal sender As Object, ByVal e As Object) Handles ButtonNext.MouseDown, Button2.MouseDown, Button3.MouseDown
        ' If GetType(Object).ToString <> "Button" Then Exit Sub
        If Not (sender.BackgroundImage Is My.Resources.button3) Then sender.BackgroundImage = My.Resources.button3

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxLang.SelectedIndexChanged
        LanguageFile.Languages(ComboBoxLang.SelectedIndex).LoadAll()
    End Sub

    Private Sub Title_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Title.Click

    End Sub

    Dim CurPos As Point
    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Title.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += MousePosition - CurPos
            CurPos = MousePosition
        Else
            CurPos = MousePosition
        End If
    End Sub
    Public state = 0
    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        If state = 2 Then
            FileSelectPanel.Left = 60
            RVPATH = TextBox7.Text
            Sett_set("dir", RVPATH)
            Sett_set("lang", Languages(ComboBoxLang.SelectedIndex).LPath)
            '   SaveSetting("Car Load", "seLanguages(ComboBox1.SelectedIndex).LPathttings", "dir", RVPATH)
            '  SaveSetting("Car Load", "settings", "lang", Languages(ComboBox1.SelectedIndex).LPath)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            HideForm(Me)
            Me.Hide()
        End If



        HideForm(Me)
        state += 1
        loadState(state)
        ShowForm(Me)

    End Sub
    Public Sub loadState(ByVal st%)
        Select Case st
            Case 0
                ComboBoxLang.Show()
                trans.Show()
                FileSelectPanel.Hide()
                Button2.Enabled = False
                ButtonNext.Enabled = True
                Text = "Select Language"
                LanguageFile.Languages(ComboBoxLang.SelectedIndex).LoadConfig()
            Case 1
                ComboBoxLang.Hide()
                trans.Hide()
                Button2.Enabled = True
                TextBox7_TextChanged(Nothing, Nothing)
                LanguageFile.Languages(ComboBoxLang.SelectedIndex).LoadSelectFolder()
                Text = "Select Re-Volt Folder"
                FileSelectPanel.Show()
            Case 2
                FileSelectPanel.Hide()
                Button2.Enabled = True
                LanguageFile.Languages(ComboBoxLang.SelectedIndex).LoadFinishConfig()

        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        HideForm(Me)
        state -= 1
        loadState(state)
        ShowForm(Me)
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles FileSelectView.DoubleClick
        If FileSelectView.SelectedItems.Count = 0 Then Exit Sub
        If FileSelectView.SelectedItems(0).Text <> "" Or FileSelectView.SelectedItems(0).Text <> Nothing Then
            Try
                ChDir(FileSelectView.SelectedItems(0).Text)
                FileSelectView.Items.Clear()
                TextBox7.Text = CurDir()
            Catch

            End Try
        End If
    End Sub

    Private Sub ListView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FileSelectView.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                Button4_Click(sender, e)
            Case Keys.Enter
                ListView1_DoubleClick(sender, e)


        End Select
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileSelectView.SelectedIndexChanged

    End Sub

    Private Sub Config_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        If Not (GetSetting("Car Load", "settings", "dir", "") = "" Or Not IO.File.Exists(GetSetting("Car Load", "settings", "dir", ""))) Then
            ChDir(GetSetting("Car Load", "settings", "dir", ""))
        Else
            ChDir(Sett_get("dir", Environ("programfiles") & "\..\"))
        End If

        TextBox7.Text = CurDir()

        Dim Dirs() As String
        Dirs = IO.Directory.GetDirectories(CurDir)

        FileSelectView.Items.Add("..", 0)




        '   For i = LBound(Dirs) To UBound(Dirs)
        'Dim LV2 As New ListViewItem
        '    LV2.ImageIndex = 0
        '   LV2.Text = Dirs(i).Split("\")(UBound(Dirs(i).Split("\")))
        '   ListView1.Items.Add(LV2)
        '   Next

        ' If GetSetting("Car Load", "settings", "dir", "") <> "" Then
        'TextBox7.Text = GetSetting("Car Load", "settings", "dir", "")
        'End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If IO.Directory.Exists(TextBox7.Text) = True Then
            FileSelectView.Items.Clear()
            ChDir(TextBox7.Text)
            Dim Dirs() As String
            Dirs = IO.Directory.GetDirectories(CurDir)

            '    If Not Mid(TextBox7.Text, 2) = ":\" Then _
            '  ListView1.Items.Add("..", 0)

            For i = LBound(Dirs) To UBound(Dirs)
                Dim LV As New ListViewItem
                LV.ImageIndex = 0
                LV.Text = Dirs(i).Split("\")(UBound(Dirs(i).Split("\")))
                FileSelectView.Items.Add(LV)


            Next


        End If

        If IO.Directory.Exists(CurDir() & "\cars\") = False And state = 1 Then
            ButtonNext.Enabled = False
        Else
            ButtonNext.Enabled = True
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Up.Click
        ChDir("..\")
        TextBox7.Text = CurDir()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox7_TextChanged(sender, e)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If IO.Directory.Exists(ComboBox3.Text) Then
            ChDir(ComboBox3.Text)
            TextBox7.Text = CurDir()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ChDir(Environment.GetFolderPath(ComboBox2.SelectedItem))
        TextBox7.Text = CurDir()
    End Sub

    Private Sub OnDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown, Button2.MouseDown, ButtonNext.MouseDown

    End Sub

    Private Sub OnHover(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove, Button2.MouseMove, ButtonNext.MouseMove

    End Sub

    Private Sub OnExit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave, Button2.MouseLeave, ButtonNext.MouseLeave

    End Sub


End Class
