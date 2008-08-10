#Region "Side Panels - Creation and events"

    Public Sub CreatePanels()
        '-----------------------------------------------------------Panel 1
        PanelBox(1) = New PanelProperties
        PanelBox(1).CurrentSize = EquationsListPanel.Height
        PanelBox(1).MinResize = 200
        PanelBox(1).MinSize = 19
        PanelBox(1).TopPos = EquationsListPanel.Top
        PanelBox(1).ThisPanel = EquationsListPanel
        PanelBox(1).State = Expanded
        PanelBox(1).MySplitter = Equation_Splitter
        PanelBox(1).PanelIndex = "Equations"
        HEADER_Equations.Panel_Index_Name = "Equations"
        PanelBox(1).HeaderBar = HEADER_Equations
        PanelBox(1).HeaderBar.Icon.Image = SidePanelImages.Images(0)
        '-----------------------------------------------------------Panel 2
        PanelBox(2) = New PanelProperties
        PanelBox(2).CurrentSize = NewEquationPanel.Height
        PanelBox(2).MinResize = 100
        PanelBox(2).MinSize = 19
        PanelBox(2).TopPos = NewEquationPanel.Top
        PanelBox(2).ThisPanel = NewEquationPanel
        PanelBox(2).State = Expanded
        PanelBox(2).MySplitter = NewEquation_Splitter
        PanelBox(2).PanelIndex = "NewEquations"
        HEADER_NewEquation.Panel_Index_Name = "NewEquations"
        PanelBox(2).HeaderBar = HEADER_NewEquation
        PanelBox(2).HeaderBar.Icon.Image = SidePanelImages.Images(1)
        '-----------------------------------------------------------Panel 3
        PanelBox(3) = New PanelProperties
        PanelBox(3).CurrentSize = Panel3.Height
        PanelBox(3).MinResize = 100
        PanelBox(3).MinSize = 19
        PanelBox(3).TopPos = Panel3.Top
        PanelBox(3).ThisPanel = Panel3
        PanelBox(3).State = Expanded
        PanelBox(3).MySplitter = Splitter3
        PanelBox(3).PanelIndex = "Panel3"
        Header3.Panel_Index_Name = "Panel3"
        PanelBox(3).HeaderBar = Header3
        '-----------------------------------------------------------Panel 4
        PanelBox(4) = New PanelProperties
        PanelBox(4).CurrentSize = EvaluatePanel.Height
        PanelBox(4).MinResize = 100
        PanelBox(4).MinSize = 19
        PanelBox(4).TopPos = EvaluatePanel.Top
        PanelBox(4).ThisPanel = EvaluatePanel
        PanelBox(4).State = Expanded
        PanelBox(4).MySplitter = Evaluate_Splitter
        PanelBox(4).PanelIndex = "Evalute"
        Header_Evaluate.Panel_Index_Name = "Evalute"
        PanelBox(4).HeaderBar = Header_Evaluate

        FormLoaded = True
    End Sub


    Private Sub Equation_Splitter_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Equation_Splitter.MouseDown, NewEquation_Splitter.MouseDown, Splitter3.MouseDown, Evaluate_Splitter.MouseDown
        y = e.Y
    End Sub

    Private Sub HEADER_Equations_Closed(ByVal SenderIndex As String) Handles HEADER_Equations.Closed, Header_Evaluate.Closed, HEADER_NewEquation.Closed, Header3.Closed
        Call ClosePanel(SenderIndex, PanelBox)
    End Sub

    Private Sub HEADER_Equations_Collapse(ByVal SenderIndex As String) Handles HEADER_Equations.Collapse, Header_Evaluate.Collapse, HEADER_NewEquation.Collapse, Header3.Collapse
        Call ExpandCollapse(SenderIndex, 0, PanelBox)
    End Sub


    Private Sub HEADER_Equations_MouseMove2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs, ByVal SenderIndex As String) Handles HEADER_Equations.MouseMove2, Header_Evaluate.MouseMove2, HEADER_NewEquation.MouseMove2, Header3.MouseMove2
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Call SebsPanels.HighLight_Panel(e.Y, SenderIndex, PanelBox)
        End If
    End Sub

    Private Sub HEADER_Equations_MouseUp2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs, ByVal SenderIndex As String) Handles HEADER_Equations.MouseUp2, Header_Evaluate.MouseUp2, HEADER_NewEquation.MouseUp2, Header3.MouseUp2
        SebsPanels.PosistionsChanging(e.Y, PanelBox, SenderIndex)
    End Sub


    Private Sub Equation_Splitter_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Equation_Splitter.MouseMove, Evaluate_Splitter.MouseMove, NewEquation_Splitter.MouseMove, Splitter3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim Diff As Integer = y - e.Y
            Dim CallerString As String
            Dim Caller As Integer
            Dim a As Integer
            CallerString = CType(sender, Panel).Name
            For a = 1 To PanelBox.Length - 1
                If PanelBox(a).MySplitter.Name = CallerString Then
                    Caller = a
                    Exit For
                End If
            Next
            Resizing(Caller, PanelBox, Diff)
        End If
    End Sub

#End Region