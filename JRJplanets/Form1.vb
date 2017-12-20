' Joel Johnson
' 4/10/2017
' JRJplanets
' Simulates the orbits of planets

Public Class Form1
    'The universal strength of gravity in the simulation
    Const G As Double = 1 '0.0000000000667408
    'The maximum number of bodies a user can create
    Const max As Integer = 9

    'Each body. Tracks everything about each planet
    Structure Body
        Dim mass As Double
        Dim radius As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim CenX As Integer 'The center of the body (X + radius)
        Dim CenY As Integer 'The center of the body (Y + radius)
        Dim XSpeed As Double 'Horizontal Speed
        Dim YSpeed As Double 'Vertical Speed
        Dim Strength As Double 'mass * G
    End Structure
    'Index is which body is currently being edited by the user
    Dim index As Integer = 0
    'A null body that can be used to reset a body
    Dim Defaults As Body
    'Where each planet will first be when it is created
    Const DefX As Integer = 400
    Const DefY As Integer = 400
    'The array of bodies that are simulated
    Dim Planet(max - 1) As Body

    'Used for dragging bodies around
    'DragMode tracks if something is currently being dragged
    'StartPoint is the location before a drag
    Dim DragMode As Boolean = False
    Dim StartPoint As Point

    '///////////////////////////////////////////////////////////
    'Used for preset masses and radii of body types
    'In the order of normal star, red giant, white dwarf, blackhole, gas giant, giant gas giant, rocky planet, moon, death star
    Dim Masses() As Double = {100000, 1000000, 10000, 10000000, 20, 30, 10, 5, 1}
    Dim Radii() As Integer = {65, 80, 35, 20, 12, 25, 8, 5, 3}
    'Used to refer to the planets as indexes
    Dim normalStar As Integer = 0
    Dim redGiant As Integer = 1
    Dim whiteDwarf As Integer = 2
    Dim blackHole As Integer = 3
    Dim gasGiant As Integer = 4
    Dim giantGasGiant As Integer = 5
    Dim rockyPlanet As Integer = 6
    Dim moon As Integer = 7
    Dim deathStar As Integer = 8
    'Stores the pictures of different types of bodies
    Dim Pictures(max - 1) As Image
    '////////////////////////////////////////////////////////////////

    'How far one press of a pan button will pan
    Const panDist As Integer = 100

    'Tracks how far zoomed in the user is
    Dim zoomFactor As Double = 1
    '/////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////
    'Handles everything that needs to happen when the form is first loaded
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The instructions that display at the start of the form
        'It uses a second form to get a custom font
        Form2.Show()

        'imports the pictures
        Pictures(0) = My.Resources.NormalStar
        Pictures(1) = My.Resources.RedGiant
        Pictures(2) = My.Resources.WhiteDwarf
        Pictures(3) = My.Resources.BlackHole
        Pictures(4) = My.Resources.GasGiant
        Pictures(5) = My.Resources.GasGiantGiant
        Pictures(6) = My.Resources.RockyPlanet
        Pictures(7) = My.Resources.Moon
        Pictures(8) = My.Resources.DeathStar
        'loads in the basic system to allow the user immediate access to a system
        basicSystem()
        'Sets all nine bodies to 300,300 and draws them with a radius of zero
        'This allows the user to easily see when a planet is first updated as it will not be at 0,0
        Defaults.X = DefX
        Defaults.Y = DefY
        For j = 0 To max - 1
            'Planet(j) = Defaults
            Draw(j)
        Next
        Updater(index)

    End Sub
    '/////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////////////
    'Toggles whether the simulation is running
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        RunToggle()
    End Sub

    Private Sub RunToggle()
        If tmrMove.Enabled Then
            tmrMove.Enabled = False
            btnGo.Text = "&Go"
        Else
            tmrMove.Enabled = True
            btnGo.Text = "&Pause"
        End If
    End Sub
    'End buttons that toggle running
    '////////////////////////////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////////////////////////////////
    'The timer routine, what runs every time a tick happens in the simulation
    'Recalculates the centers of the bodies
    'Checks for collisions
    'Calculates how each body affects every other body
    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrMove.Tick
        'represent the lengths between the two bodies as a right triangle
        Dim x As Double 'The horizontal length between two bodies
        Dim y As Double 'The vertical length between two bodies
        Dim squaredRadius As Double 'x^2 + y^2
        Dim radius As Double 'the squareroot of the squearedRadius
        Dim pull As Double 'The total gravitational pull
        'The whole gravity will be split into a vertical and horizontal pull
        Dim VerPull As Double 'The gravitational pull vertically
        Dim HorPull As Double 'The gravitational pull horizontally


        'Each planet has its center coords recalculated as they have been moved
        For j = 0 To max - 1
            Planet(j).CenX = Planet(j).X + Planet(j).radius
            Planet(j).CenY = Planet(j).Y + Planet(j).radius
        Next

        'Calculates the effect that each body k has on a body j
        'j has its speeds changed by body k's acc. due to gravity
        For j = 0 To max - 1
            For k = 0 To max - 1
                If Not (Planet(j).mass = 0 Or Planet(k).mass = 0 Or k = j) Then

                    x = Planet(k).CenX - Planet(j).CenX
                    y = Planet(k).CenY - Planet(j).CenY
                    squaredRadius = x ^ 2 + y ^ 2
                    pull = Planet(k).Strength / squaredRadius
                    radius = Math.Sqrt(squaredRadius)
                    VerPull = y / radius * pull
                    HorPull = x / radius * pull

                    Planet(j).XSpeed += HorPull
                    Planet(j).YSpeed += VerPull

                End If
            Next
        Next

        'Updates the X and Y coords now that the new speeds have been calculated
        For j = 0 To max - 1
            If Not Planet(j).mass = 0 Then
                'calculates new x and y
                Planet(j).X += Math.Round(Planet(j).XSpeed)
                Planet(j).Y += Math.Round(Planet(j).YSpeed)

                'Draws the pic box corresponding to planet j
                Draw(j)
            End If
        Next

        'Updates the information currently being edited by the user
        Updater(index)
    End Sub
    'End of timer routine
    '/////////////////////////////////////////////////////////////////////////////////////

    '/////////////////////////////////////////////////////////////////////////
    'Redraws the pic box belonging to the passed variable of e
    Private Sub Draw(e As Integer)
        If e = 0 Then
            pic0.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 1 Then
            pic1.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 2 Then
            pic2.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 3 Then
            pic3.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 4 Then
            pic4.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 5 Then
            pic5.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 6 Then
            pic6.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 7 Then
            pic7.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        ElseIf e = 8 Then
            pic8.SetBounds(CInt(Planet(e).X * zoomFactor), CInt(Planet(e).Y * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor), CInt(Planet(e).radius * 2 * zoomFactor))
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////////////////////////////////
    'Reset buttons and routine
    'Resets all labels, sliders, text, etc.
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()

        'Only want to reset this when the actual reset button is pressed and not when a preset is selected
        'Turns off the timer routine
        tmrMove.Enabled = False
        tmrMove.Interval = 100
        lblRunSpeed.Text = "100"
        hsbSpeed.Value = 9
        'updates pause/go button
        btnGo.Text = "Go"
    End Sub
    '////////////////////////////
    'Callable reset function
    Private Sub reset()
        'Sets all bodies to the default state
        For j = 0 To max - 1
            Planet(j) = Defaults
            Draw(j)
        Next

        'Resets the zoom
        zoomFactor = 1

        'selected planet is set to 1
        index = 0

        'Resets everything in the controls
        Updater(index)
        hsbIndex.Value = 0
        lblIndex.Text = "1"
    End Sub
    'End of reset routines
    '////////////////////////////////////////////////////////////////////////////////////////

    '/////////////////////////////////////////////////////////////////////////////
    'Updates the X coord belonging to the planet being edited
    Private Sub txtX_TextChanged(sender As Object, e As EventArgs) Handles txtX.TextChanged
        If (IsNumeric(txtX.Text)) Then
            Planet(index).X = CInt(txtX.Text)
            Draw(index)
        Else
            Planet(index).X = 0
        End If
    End Sub
    'End x coord editing
    '/////////////////////////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////////////////////////////
    'Updates the Y coord belonging to the planet being edited
    Private Sub txtY_TextChanged(sender As Object, e As EventArgs) Handles txtY.TextChanged
        If (IsNumeric(txtY.Text)) Then
            Planet(index).Y = CInt(txtY.Text)
            Draw(index)
        Else
            Planet(index).Y = 0
        End If
    End Sub
    'End Y coord editing
    '/////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////
    'Updates the radius belonging to the planet being edited
    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        If (IsNumeric(txtRadius.Text)) Then
            If txtRadius.Text >= 0 And txtRadius.Text < 100000000 Then
                Planet(index).radius = CInt(txtRadius.Text)
                Draw(index)
            End If
        Else
            Planet(index).radius = 0
        End If
    End Sub
    'radius in the simple controls is controlled by the presets in lstTypes
    '//////////////////////////////////////////////////////////////////////////////////

    '/////////////////////////////////////////////////////////////////////////////////////
    'Updates the Mass belonging to the planet being edited
    Private Sub txtMass_TextChanged(sender As Object, e As EventArgs) Handles txtMass.TextChanged
        If IsNumeric(txtMass.Text) Then
            If txtMass.Text > 0 And txtMass.Text < 100000000 Then
                Planet(index).mass = CInt(txtMass.Text)
                Planet(index).Strength = G * Planet(index).mass
            End If
        Else
            Planet(index).mass = 0
        End If
    End Sub
    'Mass in the simple controls is controlled by the presets in lstTypes
    '///////////////////////////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////
    'Changes the mass and radius for simple controls with a preset list
    Private Sub lstTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTypes.SelectedIndexChanged
        If Not (lstTypes.SelectedIndex = -1) Then
            Planet(index).mass = Masses(lstTypes.SelectedIndex)
            Planet(index).radius = Radii(lstTypes.SelectedIndex) * zoomFactor 'multiplies by zoom factor so that the created planet is the
            'correct size relative to the others
            Planet(index).Strength = Planet(index).mass * G

            'Updates the mass and radius text box in the advanced controls
            txtMass.Text = Masses(lstTypes.SelectedIndex).ToString
            txtRadius.Text = Radii(lstTypes.SelectedIndex).ToString * zoomFactor

            'Changes the picture to the one corresponding to the selected item
            If index = 0 Then
                pic0.Image = Pictures(lstTypes.SelectedIndex)
            ElseIf index = 1 Then
                pic1.Image = Pictures(lstTypes.SelectedIndex)
            ElseIf index = 2 Then
                pic2.Image = Pictures(lstTypes.SelectedIndex)
            ElseIf index = 3 Then
                pic3.Image = Pictures(lstTypes.SelectedIndex)
            ElseIf index = 4 Then
                pic4.Image = Pictures(lstTypes.SelectedIndex)
            ElseIf index = 5 Then
                pic5.Image = Pictures(lstTypes.SelectedIndex)
            ElseIf index = 6 Then
                pic6.Image = Pictures(lstTypes.SelectedIndex)
            ElseIf index = 7 Then
                pic7.Image = Pictures(lstTypes.SelectedIndex)
            Else
                pic8.Image = Pictures(lstTypes.SelectedIndex)
            End If

            Draw(index)
        End If
    End Sub
    '//////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////////
    'Updates the X Speed belonging to the planet being edited
    Private Sub hsbXSpeed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbXSpeed.Scroll
        Planet(index).XSpeed = Math.Round(CInt(hsbXSpeed.Value) / 10 - 20, 1)
        lblXSpeed.Text = Planet(index).XSpeed.ToString
    End Sub
    '//////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////
    'Updates the Y Speed belonging to the planet being edited
    Private Sub hsbYSpeed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbYSpeed.Scroll
        Planet(index).YSpeed = Math.Round(CInt(hsbYSpeed.Value) / 10 - 20, 1)
        lblYSpeed.Text = Planet(index).YSpeed.ToString
    End Sub
    '////////////////////////////////////////////////////////////////

    '/////////////////////////////////////////////////////////////////
    'Changese which body is currently being edited by the user
    Private Sub hsbIndex_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbIndex.Scroll
        index = (hsbIndex.Value)
        lblIndex.Text = (hsbIndex.Value + 1).ToString
        Updater(index) 'loads the saved information such as speeds, location, etc.
        lstTypes.SelectedIndex = -1
    End Sub
    '/////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////////////////
    'Updates all of the information of the planet being edited in the controls
    Private Sub Updater(e As Integer)
        txtMass.Text = Planet(e).mass.ToString
        txtX.Text = Planet(e).X.ToString
        txtY.Text = Planet(e).Y.ToString
        txtRadius.Text = Planet(e).radius.ToString
        lblXSpeed.Text = Planet(e).XSpeed.ToString
        lblYSpeed.Text = Planet(e).YSpeed.ToString
        hsbIndex.Value = e
        lblIndex.Text = (e + 1).ToString

        Dim dblHolder As Double

        dblHolder = ((Planet(index).XSpeed + 20) * 10)
        hsbXSpeed.Value = sizeUp(dblHolder)
        dblHolder = ((Planet(index).YSpeed + 20) * 10)
        hsbYSpeed.Value = sizeUp(dblHolder)
    End Sub
    '////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////
    'Checks to see if a value is too large or too small for the speed scroll bars
    Private Function sizeUp(e As Double)
        If e > 409 Then
            e = 409
        ElseIf e < 0 Then
            e = 0
        End If
        Return e
    End Function
    '/////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////////////
    'Allows the user to select from preset solar systems
    Private Sub lstPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPresets.SelectedIndexChanged
        reset()

        If lstPresets.SelectedIndex = 0 Then 'Basic System Selected
            basicSystem()
        ElseIf lstPresets.SelectedIndex = 1 Then 'Binary Star System Selected
            binaryStarSystem()
        ElseIf lstPresets.SelectedIndex = 2 Then 'Three Part System Selected
            threePartSystem()
        End If

        'Draws all of the bodies created by the preset
        For j = 0 To max - 1
            Planet(j).Strength = Planet(j).mass * G
            Draw(j)
        Next
    End Sub
    '///////////////////////////////////////////////////////////////////////////
    'The different presets
    '//////////////////////////////////////////////////////
    'Basic System
    Private Sub basicSystem()
        With Planet(0)
            .mass = Masses(normalStar)
            .radius = Radii(normalStar)
            .X = 700
            .Y = 300
            .XSpeed = 0
            .YSpeed = 0
        End With
        pic0.Image = Pictures(normalStar)

        For j = 1 To max - 1
            With Planet(j)
                .mass = Masses(rockyPlanet)
                .radius = Radii(rockyPlanet)
                .X = 700
                .Y = 400 + 50 * j
                .XSpeed = max + 12 - j
                .YSpeed = 0
            End With
        Next
        pic1.Image = Pictures(rockyPlanet)
        pic2.Image = Pictures(rockyPlanet)
        pic3.Image = Pictures(rockyPlanet)
        pic4.Image = Pictures(rockyPlanet)
        pic5.Image = Pictures(rockyPlanet)
        pic6.Image = Pictures(rockyPlanet)
        pic7.Image = Pictures(rockyPlanet)
        pic8.Image = Pictures(rockyPlanet)
    End Sub
    '///////////////////////////////////////////////////////////////
    'Binary Star System
    Private Sub binaryStarSystem()
        For j = 0 To 1
            With Planet(j)
                .mass = Masses(normalStar)
                .radius = Radii(normalStar)
                .X = 700
                .Y = 200 + j * 150
                .XSpeed = 20 + -40 * j
                .YSpeed = 0
            End With
        Next
        pic0.Image = Pictures(normalStar)
        pic1.Image = Pictures(normalStar)

        With Planet(2)
            .mass = Masses(rockyPlanet)
            .radius = Radii(rockyPlanet)
            .X = 750
            .Y = 630
            .XSpeed = 30
            pic2.Image = Pictures(rockyPlanet)
        End With
    End Sub
    '/////////////////////////////////////////////////////////////
    'Three Part System
    Private Sub threePartSystem()
        With Planet(0)
            .mass = Masses(normalStar) + 4000
            .radius = Radii(normalStar)
            .X = 1500
            .Y = 750
        End With
        pic0.Image = Pictures(normalStar)

        With Planet(1)
            .mass = Masses(whiteDwarf)
            .radius = Radii(giantGasGiant)
            .X = 1500
            .Y = 105
            .XSpeed = 14
        End With
        pic1.Image = Pictures(gasGiant)

        With Planet(2)
            .mass = Masses(moon)
            .radius = Radii(rockyPlanet)
            .X = 1515
            .Y = 70
            .XSpeed = 25
        End With
        pic2.Image = Pictures(moon)

        With Planet(3)
            .mass = Masses(moon)
            .radius = Radii(rockyPlanet)
            .X = 1515
            .Y = 65
            .XSpeed = 23
        End With
        pic3.Image = Pictures(moon)

        zoomFactor = 0.5
    End Sub
    '////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////////////////////////////
    'Toggles between the simple and advanced controls
    Private Sub btnShowSimple_Click(sender As Object, e As EventArgs) Handles btnShowSimple.Click
        If btnShowSimple.Text = "&Advanced" Then 'simple showing. show advanced
            lblYSpeed.Visible = True
            lblYSpeedLabel.Visible = True
            hsbYSpeed.Visible = True

            lblRadius.Visible = True
            lblMass.Text = "Mass:"
            txtMass.Visible = True
            txtRadius.Visible = True

            lblRunSpeed.Visible = True
            lblRunSpeedLabel.Visible = True
            hsbSpeed.Visible = True

            lstTypes.Visible = False
            btnShowSimple.Text = "&Simple"
        Else                                'advanced currently showing. show simple
            lblYSpeed.Visible = False
            lblYSpeedLabel.Visible = False
            hsbYSpeed.Visible = False

            lblRadius.Visible = False
            lblMass.Text = "Type:"
            txtMass.Visible = False
            txtRadius.Visible = False

            lblRunSpeed.Visible = False
            lblRunSpeedLabel.Visible = False
            hsbSpeed.Visible = False

            lstTypes.Visible = True
            btnShowSimple.Text = "&Advanced"
        End If
    End Sub

    'Dragging routines found via http://stackoverflow.com/questions/1086989/dragging-picturebox-inside-winform-on-runtime
    'All of these are used for dragging the pictures
    'The first sub is for detecting the mouse moving over the respective picture
    'The second sub does the actual dragging
    'The final sub detects the mouse moving off of the respective picture
    '////////////////////////////////////////////////////////////////////
    'Pic 0 & Body 0
    Private Sub Pic0_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic0.MouseDown
        StartPoint = pic0.PointToScreen(New Point(e.X, e.Y))
        StartDrag(0)
    End Sub

    Private Sub Pic0_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic0.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic0.PointToScreen(New Point(e.X, e.Y))
            pic0.Left += (NextPoint.X - StartPoint.X)
            pic0.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic0_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic0.MouseUp
        EndDrag(pic0.Location)
    End Sub
    '////////////////////////////////////////////////////////////////////////
    'Pic 1 & Body 1
    Private Sub Pic1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic1.MouseDown
        StartPoint = pic1.PointToScreen(New Point(e.X, e.Y))
        StartDrag(1)
    End Sub

    Private Sub Pic1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic1.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic1.PointToScreen(New Point(e.X, e.Y))
            pic1.Left += (NextPoint.X - StartPoint.X)
            pic1.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic1.MouseUp
        DragMode = False
        EndDrag(pic1.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Pic 2 & Body 2
    Private Sub Pic2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic2.MouseDown
        StartPoint = pic2.PointToScreen(New Point(e.X, e.Y))
        StartDrag(2)
    End Sub

    Private Sub Pic2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic2.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic2.PointToScreen(New Point(e.X, e.Y))
            pic2.Left += (NextPoint.X - StartPoint.X)
            pic2.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic2.MouseUp
        EndDrag(pic2.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Pic 3 & Body 3
    Private Sub Pic3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic3.MouseDown
        StartPoint = pic3.PointToScreen(New Point(e.X, e.Y))
        StartDrag(3)
    End Sub

    Private Sub Pic3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic3.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic3.PointToScreen(New Point(e.X, e.Y))
            pic3.Left += (NextPoint.X - StartPoint.X)
            pic3.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic3.MouseUp
        EndDrag(pic3.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Pic 4 & Body 4
    Private Sub Pic4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic4.MouseDown
        StartPoint = pic4.PointToScreen(New Point(e.X, e.Y))
        StartDrag(4)
    End Sub

    Private Sub Pic4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic4.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic4.PointToScreen(New Point(e.X, e.Y))
            pic4.Left += (NextPoint.X - StartPoint.X)
            pic4.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic4.MouseUp
        EndDrag(pic4.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Pic 5 & Body 5
    Private Sub Pic5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic5.MouseDown
        StartPoint = pic5.PointToScreen(New Point(e.X, e.Y))
        StartDrag(5)
    End Sub

    Private Sub Pic5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic5.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic5.PointToScreen(New Point(e.X, e.Y))
            pic5.Left += (NextPoint.X - StartPoint.X)
            pic5.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic5.MouseUp
        EndDrag(pic5.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Pic 6 & Body 
    Private Sub Pic6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic6.MouseDown
        StartPoint = pic6.PointToScreen(New Point(e.X, e.Y))
        StartDrag(6)
    End Sub

    Private Sub Pic6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic6.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic6.PointToScreen(New Point(e.X, e.Y))
            pic6.Left += (NextPoint.X - StartPoint.X)
            pic6.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic6.MouseUp
        EndDrag(pic6.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Pic 7 & Body 7
    Private Sub Pic7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic7.MouseDown
        StartPoint = pic7.PointToScreen(New Point(e.X, e.Y))
        StartDrag(7)
    End Sub

    Private Sub Pic7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic7.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic7.PointToScreen(New Point(e.X, e.Y))
            pic7.Left += (NextPoint.X - StartPoint.X)
            pic7.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic7.MouseUp
        EndDrag(pic7.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Pic 8 & Body 8
    Private Sub Pic8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic8.MouseDown
        StartPoint = pic8.PointToScreen(New Point(e.X, e.Y))
        StartDrag(8)
    End Sub

    Private Sub Pic8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic8.MouseMove
        If DragMode Then
            Dim NextPoint As Point = pic8.PointToScreen(New Point(e.X, e.Y))
            pic8.Left += (NextPoint.X - StartPoint.X)
            pic8.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Pic8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic8.MouseUp
        EndDrag(pic8.Location)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////
    'Starts a drag routine
    Private Sub StartDrag(e As Integer)
        DragMode = True 'Tracks that a picture is being dragged
        tmrMove.Enabled = False 'Turns off the timer
        index = e           'Sets the clicked on picture to be the one being edited in the controls
        btnGo.Text = "Go"
    End Sub

    'Ends a drag routine and updates all of the necessary information
    Private Sub EndDrag(picPoint As Point)
        DragMode = False
        Planet(index).X = picPoint.X
        Planet(index).Y = picPoint.Y
        hsbIndex.Value = index 'Updates the controls based on the now selected picture
        Updater(index)
    End Sub
    '////////////////////////////////////////////////////////////////////
    'Panning by dragging the form
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        DragMode = True
        StartPoint = Me.PointToScreen(New Point(e.X, e.Y))
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If DragMode Then
            Dim NextPoint As Point = Me.PointToScreen(New Point(e.X, e.Y))

            For j = 0 To max - 1
                Planet(j).X += NextPoint.X - StartPoint.X
                Planet(j).Y += NextPoint.Y - StartPoint.Y
                Draw(j)
            Next
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub Me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        DragMode = False
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////
    'Drag the controls around
    Private Sub gbControls_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gbControls.MouseDown
        DragMode = True
        StartPoint = gbControls.PointToScreen(New Point(e.X, e.Y))
    End Sub

    Private Sub gbControls_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gbControls.MouseMove
        If DragMode Then
            Dim NextPoint As Point = gbControls.PointToScreen(New Point(e.X, e.Y))
            gbControls.Left += (NextPoint.X - StartPoint.X)
            gbControls.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub gbControls_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gbControls.MouseUp
        DragMode = False
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////
    'Drag the Presets around
    Private Sub gbPresets_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gbPresets.MouseDown
        DragMode = True
        StartPoint = gbPresets.PointToScreen(New Point(e.X, e.Y))
    End Sub

    Private Sub gbPresets_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gbPresets.MouseMove
        If DragMode Then
            Dim NextPoint As Point = gbPresets.PointToScreen(New Point(e.X, e.Y))
            gbPresets.Left += (NextPoint.X - StartPoint.X)
            gbPresets.Top += (NextPoint.Y - StartPoint.Y)
            StartPoint = NextPoint
        End If
    End Sub

    Private Sub gbPresets_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gbPresets.MouseUp
        DragMode = False
    End Sub
    '/////////////////////////////////////////////////////////////////////
    'End of all dragging
    '//////////////////////////////////////////////////////////////////////////////////

    '/////////////////////////////////////////////////////////////////////
    'Panning routines
    'Four buttons controll panning in different directions
    '///////////////////////////////////////////////////////////////
    'Pans up 100 pixels
    Private Sub btnPanUp_Click(sender As Object, e As EventArgs) Handles btnPanUp.Click
        For j = 0 To max - 1
            Planet(j).Y -= panDist
            Draw(j)
        Next
    End Sub
    'Pans down 100 pixels
    Private Sub btnPanDown_Click(sender As Object, e As EventArgs) Handles btnPanDown.Click
        For j = 0 To max - 1
            Planet(j).Y += panDist
            Draw(j)
        Next
    End Sub
    'Pans right 100 pixels
    Private Sub btnPanRight_Click(sender As Object, e As EventArgs) Handles btnPanRight.Click
        For j = 0 To max - 1
            Planet(j).X -= panDist
            Draw(j)
        Next
    End Sub
    'Pans left 100 pixels
    Private Sub btnPanLeft_Click(sender As Object, e As EventArgs) Handles btnPanLeft.Click
        For j = 0 To max - 1
            Planet(j).X += panDist
            Draw(j)
        Next
    End Sub
    '//////////////////////////////////////////////////////
    'End all panning
    '/////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////
    'Hides the instructions
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        gbControls.Visible = False
    End Sub
    '////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////
    'Updates the speed of the simulation
    Private Sub hsbSpeed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbSpeed.Scroll
        '0-9 are tenths of a second
        '0 updates every second
        '1 updates every 9/10ths of a second
        '2 updates every 8/10ths of a second
        'etc
        If hsbSpeed.Value < 10 Then
            tmrMove.Interval = 1000 - 100 * hsbSpeed.Value
        ElseIf hsbSpeed.Value = 10 Then '10 sets the interval to every 50ms
            tmrMove.Interval = 50
        Else '11 sets the interval to every 10ms
            tmrMove.Interval = 10
        End If
        'Update the label showing the speed
        lblRunSpeed.Text = tmrMove.Interval.ToString
    End Sub
    '//////////////////////////////////////////////////
    'Handles the zoom factor in and out
    '//////////////////////////////
    'Zooms in
    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        zoomFactor = zoomFactor * 2
        For j = 0 To max - 1
            Draw(j)
        Next
    End Sub
    '////////////////////////////////////////////////////////////
    'Zooms out
    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        zoomFactor = zoomFactor / 2
        For j = 0 To max - 1
            Draw(j)
        Next
    End Sub
    '///////////////////////////////////////////////////
    'Menu options
    '///////////////////////////////////////////////////////////
    'Toggles the visibility of the main controls
    Private Sub mnuControls_Click(sender As Object, e As EventArgs) Handles mnuControls.Click
        gbControls.Visible = If(gbControls.Visible, False, True)
    End Sub
    '////////////////////////////////////////////////////
    'This shows the presets menu when clicked or hides them if they are already visible
    Private Sub mnuPresets_Click(sender As Object, e As EventArgs) Handles mnuPresets.Click
        gbPresets.Visible = If(gbPresets.Visible, False, True)
    End Sub
    '//////////////////////////////////////////////////////
    'Exits the form from the menu
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub
    '//////////////////////////////////////////
    'End all menu options
    '////////////////////////////////////////////////////////////
End Class
