<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LabelWelcome = New MaterialSkin.Controls.MaterialLabel()
        Me.LabelLogIn = New MaterialSkin.Controls.MaterialLabel()
        Me.LabelEmail = New MaterialSkin.Controls.MaterialLabel()
        Me.LabelPassword = New MaterialSkin.Controls.MaterialLabel()
        Me.BtnSubmit = New MaterialSkin.Controls.MaterialButton()
        Me.InputEmail = New MaterialSkin.Controls.MaterialTextBox2()
        Me.InputPassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.BackColor = System.Drawing.Color.Transparent
        Me.LabelWelcome.Depth = 0
        Me.LabelWelcome.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.LabelWelcome.Location = New System.Drawing.Point(31, 34)
        Me.LabelWelcome.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(97, 17)
        Me.LabelWelcome.TabIndex = 0
        Me.LabelWelcome.Text = "Welcome back!"
        '
        'LabelLogIn
        '
        Me.LabelLogIn.AutoSize = True
        Me.LabelLogIn.Depth = 0
        Me.LabelLogIn.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelLogIn.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.LabelLogIn.Location = New System.Drawing.Point(29, 63)
        Me.LabelLogIn.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelLogIn.Name = "LabelLogIn"
        Me.LabelLogIn.Size = New System.Drawing.Size(93, 41)
        Me.LabelLogIn.TabIndex = 1
        Me.LabelLogIn.Text = "Log In"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Depth = 0
        Me.LabelEmail.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelEmail.Location = New System.Drawing.Point(31, 119)
        Me.LabelEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(41, 19)
        Me.LabelEmail.TabIndex = 2
        Me.LabelEmail.Text = "Email"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Depth = 0
        Me.LabelPassword.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelPassword.Location = New System.Drawing.Point(31, 211)
        Me.LabelPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(71, 19)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Password"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnSubmit.Depth = 0
        Me.BtnSubmit.HighEmphasis = True
        Me.BtnSubmit.Icon = Nothing
        Me.BtnSubmit.Location = New System.Drawing.Point(34, 302)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnSubmit.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnSubmit.Size = New System.Drawing.Size(83, 36)
        Me.BtnSubmit.TabIndex = 6
        Me.BtnSubmit.Text = "Login ➝"
        Me.BtnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnSubmit.UseAccentColor = False
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'InputEmail
        '
        Me.InputEmail.AnimateReadOnly = False
        Me.InputEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.InputEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.InputEmail.Depth = 0
        Me.InputEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.InputEmail.HideSelection = True
        Me.InputEmail.LeadingIcon = Nothing
        Me.InputEmail.Location = New System.Drawing.Point(32, 142)
        Me.InputEmail.MaxLength = 32767
        Me.InputEmail.MouseState = MaterialSkin.MouseState.OUT
        Me.InputEmail.Name = "InputEmail"
        Me.InputEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InputEmail.PrefixSuffixText = Nothing
        Me.InputEmail.ReadOnly = False
        Me.InputEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InputEmail.SelectedText = ""
        Me.InputEmail.SelectionLength = 0
        Me.InputEmail.SelectionStart = 0
        Me.InputEmail.ShortcutsEnabled = True
        Me.InputEmail.Size = New System.Drawing.Size(318, 48)
        Me.InputEmail.TabIndex = 3
        Me.InputEmail.TabStop = False
        Me.InputEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.InputEmail.TrailingIcon = Nothing
        Me.InputEmail.UseSystemPasswordChar = False
        '
        'InputPassword
        '
        Me.InputPassword.AnimateReadOnly = False
        Me.InputPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.InputPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.InputPassword.Depth = 0
        Me.InputPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.InputPassword.HideSelection = True
        Me.InputPassword.LeadingIcon = Nothing
        Me.InputPassword.Location = New System.Drawing.Point(32, 234)
        Me.InputPassword.MaxLength = 32767
        Me.InputPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.InputPassword.Name = "InputPassword"
        Me.InputPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.InputPassword.PrefixSuffixText = Nothing
        Me.InputPassword.ReadOnly = False
        Me.InputPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InputPassword.SelectedText = ""
        Me.InputPassword.SelectionLength = 0
        Me.InputPassword.SelectionStart = 0
        Me.InputPassword.ShortcutsEnabled = True
        Me.InputPassword.Size = New System.Drawing.Size(318, 48)
        Me.InputPassword.TabIndex = 5
        Me.InputPassword.TabStop = False
        Me.InputPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.InputPassword.TrailingIcon = Global.Login_Form.My.Resources.Resources.visibility
        Me.InputPassword.UseSystemPasswordChar = True
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.Login_Form.My.Resources.Resources.close
        Me.BtnClose.Location = New System.Drawing.Point(686, 10)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(25, 25)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Background
        '
        Me.Background.Image = CType(resources.GetObject("Background.Image"), System.Drawing.Image)
        Me.Background.ImageLocation = ""
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(720, 480)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 7
        Me.Background.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(720, 480)
        Me.Controls.Add(Me.InputPassword)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelLogIn)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.InputEmail)
        Me.Controls.Add(Me.Background)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.KeyPreview = True
        Me.Name = "LoginForm"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Sizable = False
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Background As PictureBox
    Private WithEvents LabelLogIn As MaterialSkin.Controls.MaterialLabel
    Private WithEvents LabelEmail As MaterialSkin.Controls.MaterialLabel
    Private WithEvents LabelPassword As MaterialSkin.Controls.MaterialLabel
    Private WithEvents BtnSubmit As MaterialSkin.Controls.MaterialButton
    Private WithEvents LabelWelcome As MaterialSkin.Controls.MaterialLabel
    Private WithEvents BtnClose As Button
    Private WithEvents InputEmail As MaterialSkin.Controls.MaterialTextBox2
    Private WithEvents InputPassword As MaterialSkin.Controls.MaterialTextBox2
End Class
