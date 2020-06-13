<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandardCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStandardCalculator))
        Me.ButtonLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DisplayPanel = New System.Windows.Forms.Panel()
        Me.TextBox_Big = New System.Windows.Forms.TextBox()
        Me.TextBox_Small = New System.Windows.Forms.TextBox()
        Me.Button_Equals = New WindowsApplication1.FlashButtonControl()
        Me.Button_Dot = New WindowsApplication1.FlashButtonControl()
        Me.Button0 = New WindowsApplication1.FlashButtonControl()
        Me.Button_Add = New WindowsApplication1.FlashButtonControl()
        Me.Button3 = New WindowsApplication1.FlashButtonControl()
        Me.Button2 = New WindowsApplication1.FlashButtonControl()
        Me.Button1 = New WindowsApplication1.FlashButtonControl()
        Me.Button_Sub = New WindowsApplication1.FlashButtonControl()
        Me.Button6 = New WindowsApplication1.FlashButtonControl()
        Me.Button5 = New WindowsApplication1.FlashButtonControl()
        Me.Button4 = New WindowsApplication1.FlashButtonControl()
        Me.Button_Div = New WindowsApplication1.FlashButtonControl()
        Me.Button9 = New WindowsApplication1.FlashButtonControl()
        Me.Button8 = New WindowsApplication1.FlashButtonControl()
        Me.Button7 = New WindowsApplication1.FlashButtonControl()
        Me.Button_Mul = New WindowsApplication1.FlashButtonControl()
        Me.Button_Modulus = New WindowsApplication1.FlashButtonControl()
        Me.Button_AddSub = New WindowsApplication1.FlashButtonControl()
        Me.Button_Clear = New WindowsApplication1.FlashButtonControl()
        Me.ButtonLayoutPanel.SuspendLayout()
        Me.DisplayPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonLayoutPanel
        '
        Me.ButtonLayoutPanel.ColumnCount = 4
        Me.ButtonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ButtonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ButtonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ButtonLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Equals, 3, 4)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Dot, 2, 4)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button0, 0, 4)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Add, 3, 3)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button3, 2, 3)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button2, 1, 3)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button1, 0, 3)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Sub, 3, 2)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button6, 2, 2)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button5, 1, 2)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button4, 0, 2)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Div, 3, 1)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button9, 2, 1)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button8, 1, 1)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button7, 0, 1)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Mul, 3, 0)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Modulus, 2, 0)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_AddSub, 1, 0)
        Me.ButtonLayoutPanel.Controls.Add(Me.Button_Clear, 0, 0)
        Me.ButtonLayoutPanel.Location = New System.Drawing.Point(0, 185)
        Me.ButtonLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLayoutPanel.Name = "ButtonLayoutPanel"
        Me.ButtonLayoutPanel.RowCount = 5
        Me.ButtonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ButtonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ButtonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ButtonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ButtonLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ButtonLayoutPanel.Size = New System.Drawing.Size(333, 415)
        Me.ButtonLayoutPanel.TabIndex = 0
        '
        'DisplayPanel
        '
        Me.DisplayPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DisplayPanel.Controls.Add(Me.TextBox_Big)
        Me.DisplayPanel.Controls.Add(Me.TextBox_Small)
        Me.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DisplayPanel.Location = New System.Drawing.Point(0, 0)
        Me.DisplayPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.DisplayPanel.Name = "DisplayPanel"
        Me.DisplayPanel.Size = New System.Drawing.Size(333, 185)
        Me.DisplayPanel.TabIndex = 1
        '
        'TextBox_Big
        '
        Me.TextBox_Big.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Big.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBox_Big.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Big.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox_Big.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Big.ForeColor = System.Drawing.Color.White
        Me.TextBox_Big.Location = New System.Drawing.Point(0, 94)
        Me.TextBox_Big.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_Big.Name = "TextBox_Big"
        Me.TextBox_Big.ReadOnly = True
        Me.TextBox_Big.Size = New System.Drawing.Size(312, 47)
        Me.TextBox_Big.TabIndex = 3
        Me.TextBox_Big.TabStop = False
        Me.TextBox_Big.Text = "0"
        Me.TextBox_Big.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_Small
        '
        Me.TextBox_Small.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Small.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBox_Small.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Small.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Small.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.TextBox_Small.Location = New System.Drawing.Point(0, 63)
        Me.TextBox_Small.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_Small.Name = "TextBox_Small"
        Me.TextBox_Small.ReadOnly = True
        Me.TextBox_Small.Size = New System.Drawing.Size(312, 25)
        Me.TextBox_Small.TabIndex = 2
        Me.TextBox_Small.TabStop = False
        Me.TextBox_Small.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button_Equals
        '
        Me.Button_Equals.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Equals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Equals.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Equals.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Equals.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Equals.Location = New System.Drawing.Point(249, 332)
        Me.Button_Equals.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Equals.Name = "Button_Equals"
        Me.Button_Equals.Size = New System.Drawing.Size(84, 83)
        Me.Button_Equals.TabIndex = 18
        Me.Button_Equals.TabStop = False
        Me.Button_Equals.Text = "="
        Me.Button_Equals.UseVisualStyleBackColor = False
        '
        'Button_Dot
        '
        Me.Button_Dot.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button_Dot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Dot.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Dot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Dot.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Dot.Location = New System.Drawing.Point(166, 332)
        Me.Button_Dot.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Dot.Name = "Button_Dot"
        Me.Button_Dot.Size = New System.Drawing.Size(83, 83)
        Me.Button_Dot.TabIndex = 17
        Me.Button_Dot.TabStop = False
        Me.Button_Dot.Text = "."
        Me.Button_Dot.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonLayoutPanel.SetColumnSpan(Me.Button0, 2)
        Me.Button0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button0.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button0.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button0.Location = New System.Drawing.Point(0, 332)
        Me.Button0.Margin = New System.Windows.Forms.Padding(0)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(166, 83)
        Me.Button0.TabIndex = 16
        Me.Button0.TabStop = False
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button_Add
        '
        Me.Button_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Add.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Add.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Add.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Add.Location = New System.Drawing.Point(249, 249)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(84, 83)
        Me.Button_Add.TabIndex = 15
        Me.Button_Add.TabStop = False
        Me.Button_Add.Text = "+"
        Me.Button_Add.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button3.Location = New System.Drawing.Point(166, 249)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 83)
        Me.Button3.TabIndex = 14
        Me.Button3.TabStop = False
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button2.Location = New System.Drawing.Point(83, 249)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 83)
        Me.Button2.TabIndex = 13
        Me.Button2.TabStop = False
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(0, 249)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 83)
        Me.Button1.TabIndex = 12
        Me.Button1.TabStop = False
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button_Sub
        '
        Me.Button_Sub.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Sub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Sub.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Sub.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Sub.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Sub.Location = New System.Drawing.Point(249, 166)
        Me.Button_Sub.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Sub.Name = "Button_Sub"
        Me.Button_Sub.Size = New System.Drawing.Size(84, 83)
        Me.Button_Sub.TabIndex = 11
        Me.Button_Sub.TabStop = False
        Me.Button_Sub.Text = "-"
        Me.Button_Sub.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button6.Location = New System.Drawing.Point(166, 166)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 83)
        Me.Button6.TabIndex = 10
        Me.Button6.TabStop = False
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button5.Location = New System.Drawing.Point(83, 166)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 83)
        Me.Button5.TabIndex = 9
        Me.Button5.TabStop = False
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button4.Location = New System.Drawing.Point(0, 166)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 83)
        Me.Button4.TabIndex = 8
        Me.Button4.TabStop = False
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button_Div
        '
        Me.Button_Div.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Div.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Div.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Div.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Div.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Div.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Div.Location = New System.Drawing.Point(249, 83)
        Me.Button_Div.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Div.Name = "Button_Div"
        Me.Button_Div.Size = New System.Drawing.Size(84, 83)
        Me.Button_Div.TabIndex = 7
        Me.Button_Div.TabStop = False
        Me.Button_Div.Text = "/"
        Me.Button_Div.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button9.Location = New System.Drawing.Point(166, 83)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(83, 83)
        Me.Button9.TabIndex = 6
        Me.Button9.TabStop = False
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button8.Location = New System.Drawing.Point(83, 83)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 83)
        Me.Button8.TabIndex = 5
        Me.Button8.TabStop = False
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button7.Location = New System.Drawing.Point(0, 83)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(83, 83)
        Me.Button7.TabIndex = 4
        Me.Button7.TabStop = False
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button_Mul
        '
        Me.Button_Mul.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Mul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Mul.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Mul.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Mul.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Mul.Location = New System.Drawing.Point(249, 0)
        Me.Button_Mul.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Mul.Name = "Button_Mul"
        Me.Button_Mul.Size = New System.Drawing.Size(84, 83)
        Me.Button_Mul.TabIndex = 3
        Me.Button_Mul.TabStop = False
        Me.Button_Mul.Text = "*"
        Me.Button_Mul.UseVisualStyleBackColor = False
        '
        'Button_Modulus
        '
        Me.Button_Modulus.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Modulus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Modulus.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Modulus.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Modulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Modulus.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Modulus.Location = New System.Drawing.Point(166, 0)
        Me.Button_Modulus.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Modulus.Name = "Button_Modulus"
        Me.Button_Modulus.Size = New System.Drawing.Size(83, 83)
        Me.Button_Modulus.TabIndex = 2
        Me.Button_Modulus.TabStop = False
        Me.Button_Modulus.Text = "%"
        Me.Button_Modulus.UseVisualStyleBackColor = False
        '
        'Button_AddSub
        '
        Me.Button_AddSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_AddSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_AddSub.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_AddSub.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_AddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_AddSub.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_AddSub.Location = New System.Drawing.Point(83, 0)
        Me.Button_AddSub.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_AddSub.Name = "Button_AddSub"
        Me.Button_AddSub.Size = New System.Drawing.Size(83, 83)
        Me.Button_AddSub.TabIndex = 1
        Me.Button_AddSub.TabStop = False
        Me.Button_AddSub.Text = "+/_"
        Me.Button_AddSub.UseVisualStyleBackColor = False
        '
        'Button_Clear
        '
        Me.Button_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button_Clear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Clear.FlashColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clear.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!)
        Me.Button_Clear.Location = New System.Drawing.Point(0, 0)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(0)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(83, 83)
        Me.Button_Clear.TabIndex = 0
        Me.Button_Clear.TabStop = False
        Me.Button_Clear.Text = "AC"
        Me.Button_Clear.UseVisualStyleBackColor = False
        '
        'frmStandardCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 597)
        Me.Controls.Add(Me.DisplayPanel)
        Me.Controls.Add(Me.ButtonLayoutPanel)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmStandardCalculator"
        Me.Text = "Standard Calculator"
        Me.ButtonLayoutPanel.ResumeLayout(False)
        Me.DisplayPanel.ResumeLayout(False)
        Me.DisplayPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DisplayPanel As System.Windows.Forms.Panel
    Friend WithEvents TextBox_Big As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Small As System.Windows.Forms.TextBox
    Friend WithEvents Button_Clear As FlashButtonControl
    Friend WithEvents Button_AddSub As FlashButtonControl
    Friend WithEvents Button_Modulus As FlashButtonControl
    Friend WithEvents Button_Equals As FlashButtonControl
    Friend WithEvents Button_Dot As FlashButtonControl
    Friend WithEvents Button0 As FlashButtonControl
    Friend WithEvents Button_Add As FlashButtonControl
    Friend WithEvents Button3 As FlashButtonControl
    Friend WithEvents Button2 As FlashButtonControl
    Friend WithEvents Button1 As FlashButtonControl
    Friend WithEvents Button_Sub As FlashButtonControl
    Friend WithEvents Button6 As FlashButtonControl
    Friend WithEvents Button5 As FlashButtonControl
    Friend WithEvents Button4 As FlashButtonControl
    Friend WithEvents Button_Div As FlashButtonControl
    Friend WithEvents Button9 As FlashButtonControl
    Friend WithEvents Button8 As FlashButtonControl
    Friend WithEvents Button7 As FlashButtonControl
    Friend WithEvents Button_Mul As FlashButtonControl
End Class
