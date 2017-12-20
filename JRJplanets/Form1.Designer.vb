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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pic0 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.gbControls = New System.Windows.Forms.GroupBox()
        Me.gbZoom = New System.Windows.Forms.GroupBox()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.hsbSpeed = New System.Windows.Forms.HScrollBar()
        Me.lblRunSpeed = New System.Windows.Forms.Label()
        Me.lblRunSpeedLabel = New System.Windows.Forms.Label()
        Me.gbButtons = New System.Windows.Forms.GroupBox()
        Me.btnShowSimple = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbPan = New System.Windows.Forms.GroupBox()
        Me.btnPanLeft = New System.Windows.Forms.Button()
        Me.btnPanRight = New System.Windows.Forms.Button()
        Me.btnPanDown = New System.Windows.Forms.Button()
        Me.btnPanUp = New System.Windows.Forms.Button()
        Me.hsbIndex = New System.Windows.Forms.HScrollBar()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblYSpeed = New System.Windows.Forms.Label()
        Me.lblXSpeed = New System.Windows.Forms.Label()
        Me.hsbYSpeed = New System.Windows.Forms.HScrollBar()
        Me.lstTypes = New System.Windows.Forms.ListBox()
        Me.hsbXSpeed = New System.Windows.Forms.HScrollBar()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.lblMass = New System.Windows.Forms.Label()
        Me.txtMass = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblYSpeedLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbPresets = New System.Windows.Forms.GroupBox()
        Me.lstPresets = New System.Windows.Forms.ListBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.pic8 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuControls = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPresets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pic0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControls.SuspendLayout()
        Me.gbZoom.SuspendLayout()
        Me.gbButtons.SuspendLayout()
        Me.gbPan.SuspendLayout()
        Me.gbPresets.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic0
        '
        Me.pic0.BackColor = System.Drawing.Color.Transparent
        Me.pic0.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic0.Location = New System.Drawing.Point(531, 35)
        Me.pic0.Margin = New System.Windows.Forms.Padding(2)
        Me.pic0.Name = "pic0"
        Me.pic0.Size = New System.Drawing.Size(56, 56)
        Me.pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic0.TabIndex = 0
        Me.pic0.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic1.Location = New System.Drawing.Point(660, 46)
        Me.pic1.Margin = New System.Windows.Forms.Padding(2)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(38, 41)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 1
        Me.pic1.TabStop = False
        '
        'tmrMove
        '
        Me.tmrMove.Enabled = True
        '
        'gbControls
        '
        Me.gbControls.BackColor = System.Drawing.SystemColors.Control
        Me.gbControls.Controls.Add(Me.gbZoom)
        Me.gbControls.Controls.Add(Me.hsbSpeed)
        Me.gbControls.Controls.Add(Me.lblRunSpeed)
        Me.gbControls.Controls.Add(Me.lblRunSpeedLabel)
        Me.gbControls.Controls.Add(Me.gbButtons)
        Me.gbControls.Controls.Add(Me.gbPan)
        Me.gbControls.Controls.Add(Me.hsbIndex)
        Me.gbControls.Controls.Add(Me.lblIndex)
        Me.gbControls.Controls.Add(Me.Label7)
        Me.gbControls.Controls.Add(Me.lblYSpeed)
        Me.gbControls.Controls.Add(Me.lblXSpeed)
        Me.gbControls.Controls.Add(Me.hsbYSpeed)
        Me.gbControls.Controls.Add(Me.lstTypes)
        Me.gbControls.Controls.Add(Me.hsbXSpeed)
        Me.gbControls.Controls.Add(Me.lblRadius)
        Me.gbControls.Controls.Add(Me.txtRadius)
        Me.gbControls.Controls.Add(Me.lblMass)
        Me.gbControls.Controls.Add(Me.txtMass)
        Me.gbControls.Controls.Add(Me.txtY)
        Me.gbControls.Controls.Add(Me.txtX)
        Me.gbControls.Controls.Add(Me.Label4)
        Me.gbControls.Controls.Add(Me.Label3)
        Me.gbControls.Controls.Add(Me.lblYSpeedLabel)
        Me.gbControls.Controls.Add(Me.Label1)
        Me.gbControls.Location = New System.Drawing.Point(9, 35)
        Me.gbControls.Margin = New System.Windows.Forms.Padding(2)
        Me.gbControls.Name = "gbControls"
        Me.gbControls.Padding = New System.Windows.Forms.Padding(2)
        Me.gbControls.Size = New System.Drawing.Size(315, 359)
        Me.gbControls.TabIndex = 2
        Me.gbControls.TabStop = False
        Me.gbControls.Text = "Controls"
        '
        'gbZoom
        '
        Me.gbZoom.Controls.Add(Me.btnZoomOut)
        Me.gbZoom.Controls.Add(Me.btnZoomIn)
        Me.gbZoom.Location = New System.Drawing.Point(159, 267)
        Me.gbZoom.Margin = New System.Windows.Forms.Padding(2)
        Me.gbZoom.Name = "gbZoom"
        Me.gbZoom.Padding = New System.Windows.Forms.Padding(2)
        Me.gbZoom.Size = New System.Drawing.Size(146, 82)
        Me.gbZoom.TabIndex = 37
        Me.gbZoom.TabStop = False
        Me.gbZoom.Text = "Zoom"
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Location = New System.Drawing.Point(13, 48)
        Me.btnZoomOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(118, 31)
        Me.btnZoomOut.TabIndex = 27
        Me.btnZoomOut.TabStop = False
        Me.btnZoomOut.Text = "&-"
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Location = New System.Drawing.Point(13, 15)
        Me.btnZoomIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(118, 30)
        Me.btnZoomIn.TabIndex = 0
        Me.btnZoomIn.TabStop = False
        Me.btnZoomIn.Text = "&+"
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'hsbSpeed
        '
        Me.hsbSpeed.LargeChange = 1
        Me.hsbSpeed.Location = New System.Drawing.Point(159, 117)
        Me.hsbSpeed.Maximum = 11
        Me.hsbSpeed.Name = "hsbSpeed"
        Me.hsbSpeed.Size = New System.Drawing.Size(122, 21)
        Me.hsbSpeed.TabIndex = 36
        Me.hsbSpeed.Value = 9
        Me.hsbSpeed.Visible = False
        '
        'lblRunSpeed
        '
        Me.lblRunSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRunSpeed.Location = New System.Drawing.Point(111, 119)
        Me.lblRunSpeed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRunSpeed.Name = "lblRunSpeed"
        Me.lblRunSpeed.Size = New System.Drawing.Size(34, 19)
        Me.lblRunSpeed.TabIndex = 35
        Me.lblRunSpeed.Text = "100"
        Me.lblRunSpeed.Visible = False
        '
        'lblRunSpeedLabel
        '
        Me.lblRunSpeedLabel.AutoSize = True
        Me.lblRunSpeedLabel.Location = New System.Drawing.Point(16, 120)
        Me.lblRunSpeedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRunSpeedLabel.Name = "lblRunSpeedLabel"
        Me.lblRunSpeedLabel.Size = New System.Drawing.Size(64, 13)
        Me.lblRunSpeedLabel.TabIndex = 34
        Me.lblRunSpeedLabel.Text = "Run Speed:"
        Me.lblRunSpeedLabel.Visible = False
        '
        'gbButtons
        '
        Me.gbButtons.Controls.Add(Me.btnShowSimple)
        Me.gbButtons.Controls.Add(Me.btnGo)
        Me.gbButtons.Controls.Add(Me.btnHide)
        Me.gbButtons.Controls.Add(Me.btnReset)
        Me.gbButtons.Location = New System.Drawing.Point(10, 267)
        Me.gbButtons.Name = "gbButtons"
        Me.gbButtons.Size = New System.Drawing.Size(143, 82)
        Me.gbButtons.TabIndex = 27
        Me.gbButtons.TabStop = False
        Me.gbButtons.Text = "Buttons"
        '
        'btnShowSimple
        '
        Me.btnShowSimple.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowSimple.Location = New System.Drawing.Point(7, 18)
        Me.btnShowSimple.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowSimple.Name = "btnShowSimple"
        Me.btnShowSimple.Size = New System.Drawing.Size(56, 19)
        Me.btnShowSimple.TabIndex = 31
        Me.btnShowSimple.TabStop = False
        Me.btnShowSimple.Text = "&Advanced"
        Me.btnShowSimple.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(79, 18)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(56, 19)
        Me.btnGo.TabIndex = 5
        Me.btnGo.Text = "&Pause"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Location = New System.Drawing.Point(7, 51)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(56, 19)
        Me.btnHide.TabIndex = 18
        Me.btnHide.TabStop = False
        Me.btnHide.Text = "&Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(79, 51)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(56, 19)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'gbPan
        '
        Me.gbPan.Controls.Add(Me.btnPanLeft)
        Me.gbPan.Controls.Add(Me.btnPanRight)
        Me.gbPan.Controls.Add(Me.btnPanDown)
        Me.gbPan.Controls.Add(Me.btnPanUp)
        Me.gbPan.Location = New System.Drawing.Point(159, 154)
        Me.gbPan.Name = "gbPan"
        Me.gbPan.Size = New System.Drawing.Size(146, 100)
        Me.gbPan.TabIndex = 33
        Me.gbPan.TabStop = False
        Me.gbPan.Text = "Panning"
        '
        'btnPanLeft
        '
        Me.btnPanLeft.Location = New System.Drawing.Point(116, 14)
        Me.btnPanLeft.Name = "btnPanLeft"
        Me.btnPanLeft.Size = New System.Drawing.Size(23, 80)
        Me.btnPanLeft.TabIndex = 3
        Me.btnPanLeft.TabStop = False
        Me.btnPanLeft.Text = ">"
        Me.btnPanLeft.UseVisualStyleBackColor = True
        '
        'btnPanRight
        '
        Me.btnPanRight.Location = New System.Drawing.Point(6, 14)
        Me.btnPanRight.Name = "btnPanRight"
        Me.btnPanRight.Size = New System.Drawing.Size(23, 80)
        Me.btnPanRight.TabIndex = 2
        Me.btnPanRight.TabStop = False
        Me.btnPanRight.Text = "<"
        Me.btnPanRight.UseVisualStyleBackColor = True
        '
        'btnPanDown
        '
        Me.btnPanDown.Location = New System.Drawing.Point(35, 71)
        Me.btnPanDown.Name = "btnPanDown"
        Me.btnPanDown.Size = New System.Drawing.Size(75, 23)
        Me.btnPanDown.TabIndex = 1
        Me.btnPanDown.TabStop = False
        Me.btnPanDown.Text = "v"
        Me.btnPanDown.UseVisualStyleBackColor = True
        '
        'btnPanUp
        '
        Me.btnPanUp.Location = New System.Drawing.Point(35, 14)
        Me.btnPanUp.Name = "btnPanUp"
        Me.btnPanUp.Size = New System.Drawing.Size(75, 23)
        Me.btnPanUp.TabIndex = 0
        Me.btnPanUp.TabStop = False
        Me.btnPanUp.Text = "^"
        Me.btnPanUp.UseVisualStyleBackColor = True
        '
        'hsbIndex
        '
        Me.hsbIndex.LargeChange = 1
        Me.hsbIndex.Location = New System.Drawing.Point(159, 33)
        Me.hsbIndex.Maximum = 8
        Me.hsbIndex.Name = "hsbIndex"
        Me.hsbIndex.Size = New System.Drawing.Size(122, 21)
        Me.hsbIndex.TabIndex = 21
        '
        'lblIndex
        '
        Me.lblIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIndex.Location = New System.Drawing.Point(111, 33)
        Me.lblIndex.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(34, 19)
        Me.lblIndex.TabIndex = 20
        Me.lblIndex.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Body:"
        '
        'lblYSpeed
        '
        Me.lblYSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYSpeed.Location = New System.Drawing.Point(111, 89)
        Me.lblYSpeed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYSpeed.Name = "lblYSpeed"
        Me.lblYSpeed.Size = New System.Drawing.Size(34, 19)
        Me.lblYSpeed.TabIndex = 17
        Me.lblYSpeed.Text = "0"
        Me.lblYSpeed.Visible = False
        '
        'lblXSpeed
        '
        Me.lblXSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblXSpeed.Location = New System.Drawing.Point(111, 63)
        Me.lblXSpeed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblXSpeed.Name = "lblXSpeed"
        Me.lblXSpeed.Size = New System.Drawing.Size(34, 19)
        Me.lblXSpeed.TabIndex = 16
        Me.lblXSpeed.Text = "0"
        '
        'hsbYSpeed
        '
        Me.hsbYSpeed.Location = New System.Drawing.Point(159, 89)
        Me.hsbYSpeed.Maximum = 409
        Me.hsbYSpeed.Name = "hsbYSpeed"
        Me.hsbYSpeed.Size = New System.Drawing.Size(122, 21)
        Me.hsbYSpeed.TabIndex = 15
        Me.hsbYSpeed.Value = 200
        Me.hsbYSpeed.Visible = False
        '
        'lstTypes
        '
        Me.lstTypes.FormattingEnabled = True
        Me.lstTypes.Items.AddRange(New Object() {"Normal Star", "Red Giant", "White Dwarf", "Black Hole", "Gas Giant", "Giant Gas Giant", "Rocky Planet", "Moon", "Death Star"})
        Me.lstTypes.Location = New System.Drawing.Point(62, 202)
        Me.lstTypes.Margin = New System.Windows.Forms.Padding(2)
        Me.lstTypes.Name = "lstTypes"
        Me.lstTypes.Size = New System.Drawing.Size(91, 56)
        Me.lstTypes.TabIndex = 3
        '
        'hsbXSpeed
        '
        Me.hsbXSpeed.Location = New System.Drawing.Point(159, 63)
        Me.hsbXSpeed.Maximum = 409
        Me.hsbXSpeed.Name = "hsbXSpeed"
        Me.hsbXSpeed.Size = New System.Drawing.Size(122, 21)
        Me.hsbXSpeed.TabIndex = 14
        Me.hsbXSpeed.Value = 200
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(16, 240)
        Me.lblRadius.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(43, 13)
        Me.lblRadius.TabIndex = 13
        Me.lblRadius.Text = "Radius:"
        Me.lblRadius.Visible = False
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(70, 240)
        Me.txtRadius.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(76, 20)
        Me.txtRadius.TabIndex = 4
        Me.txtRadius.Text = "0"
        Me.txtRadius.Visible = False
        '
        'lblMass
        '
        Me.lblMass.AutoSize = True
        Me.lblMass.Location = New System.Drawing.Point(16, 209)
        Me.lblMass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMass.Name = "lblMass"
        Me.lblMass.Size = New System.Drawing.Size(34, 13)
        Me.lblMass.TabIndex = 11
        Me.lblMass.Text = "Type:"
        '
        'txtMass
        '
        Me.txtMass.Location = New System.Drawing.Point(70, 209)
        Me.txtMass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMass.Name = "txtMass"
        Me.txtMass.Size = New System.Drawing.Size(76, 20)
        Me.txtMass.TabIndex = 3
        Me.txtMass.Text = "0"
        Me.txtMass.Visible = False
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(70, 177)
        Me.txtY.Margin = New System.Windows.Forms.Padding(2)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(76, 20)
        Me.txtY.TabIndex = 2
        Me.txtY.Text = "0"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(70, 149)
        Me.txtX.Margin = New System.Windows.Forms.Padding(2)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(76, 20)
        Me.txtX.TabIndex = 1
        Me.txtX.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Y:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&X:"
        '
        'lblYSpeedLabel
        '
        Me.lblYSpeedLabel.AutoSize = True
        Me.lblYSpeedLabel.Location = New System.Drawing.Point(16, 89)
        Me.lblYSpeedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYSpeedLabel.Name = "lblYSpeedLabel"
        Me.lblYSpeedLabel.Size = New System.Drawing.Size(51, 13)
        Me.lblYSpeedLabel.TabIndex = 1
        Me.lblYSpeedLabel.Text = "Y Speed:"
        Me.lblYSpeedLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X Speed:"
        '
        'gbPresets
        '
        Me.gbPresets.BackColor = System.Drawing.SystemColors.Control
        Me.gbPresets.Controls.Add(Me.lstPresets)
        Me.gbPresets.Location = New System.Drawing.Point(328, 35)
        Me.gbPresets.Margin = New System.Windows.Forms.Padding(2)
        Me.gbPresets.Name = "gbPresets"
        Me.gbPresets.Padding = New System.Windows.Forms.Padding(2)
        Me.gbPresets.Size = New System.Drawing.Size(118, 68)
        Me.gbPresets.TabIndex = 19
        Me.gbPresets.TabStop = False
        Me.gbPresets.Text = "Presets"
        Me.gbPresets.Visible = False
        '
        'lstPresets
        '
        Me.lstPresets.FormattingEnabled = True
        Me.lstPresets.Items.AddRange(New Object() {"Basic System", "Binary Star System", "Three Part System"})
        Me.lstPresets.Location = New System.Drawing.Point(12, 18)
        Me.lstPresets.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPresets.Name = "lstPresets"
        Me.lstPresets.Size = New System.Drawing.Size(94, 43)
        Me.lstPresets.TabIndex = 0
        Me.lstPresets.TabStop = False
        '
        'pic2
        '
        Me.pic2.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic2.Location = New System.Drawing.Point(780, 46)
        Me.pic2.Margin = New System.Windows.Forms.Padding(2)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(38, 41)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2.TabIndex = 3
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic3.Location = New System.Drawing.Point(539, 148)
        Me.pic3.Margin = New System.Windows.Forms.Padding(2)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(38, 41)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic3.TabIndex = 21
        Me.pic3.TabStop = False
        '
        'pic4
        '
        Me.pic4.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic4.Location = New System.Drawing.Point(660, 148)
        Me.pic4.Margin = New System.Windows.Forms.Padding(2)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(38, 41)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic4.TabIndex = 22
        Me.pic4.TabStop = False
        '
        'pic5
        '
        Me.pic5.Image = CType(resources.GetObject("pic5.Image"), System.Drawing.Image)
        Me.pic5.Location = New System.Drawing.Point(780, 148)
        Me.pic5.Margin = New System.Windows.Forms.Padding(2)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(38, 41)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic5.TabIndex = 23
        Me.pic5.TabStop = False
        '
        'pic6
        '
        Me.pic6.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic6.Location = New System.Drawing.Point(539, 252)
        Me.pic6.Margin = New System.Windows.Forms.Padding(2)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(38, 41)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic6.TabIndex = 24
        Me.pic6.TabStop = False
        '
        'pic7
        '
        Me.pic7.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic7.Location = New System.Drawing.Point(660, 252)
        Me.pic7.Margin = New System.Windows.Forms.Padding(2)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(38, 41)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic7.TabIndex = 25
        Me.pic7.TabStop = False
        '
        'pic8
        '
        Me.pic8.Image = Global.JRJplanets.My.Resources.Resources.RockyPlanet
        Me.pic8.Location = New System.Drawing.Point(788, 252)
        Me.pic8.Margin = New System.Windows.Forms.Padding(2)
        Me.pic8.Name = "pic8"
        Me.pic8.Size = New System.Drawing.Size(38, 41)
        Me.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic8.TabIndex = 26
        Me.pic8.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuControls, Me.mnuPresets, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1012, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuControls
        '
        Me.mnuControls.Name = "mnuControls"
        Me.mnuControls.Size = New System.Drawing.Size(64, 20)
        Me.mnuControls.Text = "&Controls"
        '
        'mnuPresets
        '
        Me.mnuPresets.Name = "mnuPresets"
        Me.mnuPresets.Size = New System.Drawing.Size(56, 20)
        Me.mnuPresets.Text = "&Presets"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1012, 419)
        Me.Controls.Add(Me.pic8)
        Me.Controls.Add(Me.pic7)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.gbControls)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pic0)
        Me.Controls.Add(Me.gbPresets)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Enabled = False
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Joel Johnson's Gravitation Simulation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControls.ResumeLayout(False)
        Me.gbControls.PerformLayout()
        Me.gbZoom.ResumeLayout(False)
        Me.gbButtons.ResumeLayout(False)
        Me.gbPan.ResumeLayout(False)
        Me.gbPresets.ResumeLayout(False)
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic0 As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents tmrMove As Timer
    Friend WithEvents gbControls As GroupBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtX As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblMass As Label
    Friend WithEvents txtMass As TextBox
    Friend WithEvents lblRadius As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents hsbYSpeed As HScrollBar
    Friend WithEvents hsbXSpeed As HScrollBar
    Friend WithEvents lblXSpeed As Label
    Friend WithEvents lblYSpeed As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents lblIndex As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents hsbIndex As HScrollBar
    Friend WithEvents lstPresets As ListBox
    Friend WithEvents lstTypes As ListBox
    Friend WithEvents btnShowSimple As Button
    Friend WithEvents gbPan As GroupBox
    Friend WithEvents btnPanUp As Button
    Friend WithEvents btnPanDown As Button
    Friend WithEvents btnPanLeft As Button
    Friend WithEvents btnPanRight As Button
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents pic7 As PictureBox
    Friend WithEvents pic8 As PictureBox
    Friend WithEvents gbPresets As GroupBox
    Friend WithEvents gbButtons As GroupBox
    Friend WithEvents hsbSpeed As HScrollBar
    Friend WithEvents lblRunSpeed As Label
    Friend WithEvents lblRunSpeedLabel As Label
    Friend WithEvents lblYSpeedLabel As Label
    Friend WithEvents gbZoom As GroupBox
    Friend WithEvents btnZoomOut As Button
    Friend WithEvents btnZoomIn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuControls As ToolStripMenuItem
    Friend WithEvents mnuPresets As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
