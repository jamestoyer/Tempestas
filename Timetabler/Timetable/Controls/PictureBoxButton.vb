Imports System.Windows.Forms

''' <summary>
''' This control extends the standard PictureBox control into a
''' clickable button supporting images for the "up-state",
''' "down-state" and "disabled-state" of the button.
''' </summary>
Public Class PictureBoxButton
	Inherits PictureBox
	Implements IButtonControl

#Region " Constants "

	Private Const UP_STATE As Integer = 0
	Private Const DOWN_STATE As Integer = 1
	Private Const DISABLED_STATE As Integer = 2

#End Region

#Region " Private Fields "

	Private _imageList As ImageList

#End Region

#Region " Properties "

	''' <summary>
	''' Gets/sets the list of images used to display
	''' for the three states: normal (up), depressed
	''' (down) and disabled (grayed)
	''' </summary>
	Public Property ImageList() As ImageList

		Get

			Return Me._imageList

		End Get

		Set(ByVal value As ImageList)

			Me._imageList = value
			Me.SetImageList()

		End Set

	End Property

#End Region

#Region " Override PictureBox Methods "

	''' <summary>
	''' When the control is instantiated, load
	''' the images used by the various button states.
	''' </summary>
	Protected Overrides Sub OnCreateControl()

		Me.SetImageList()

	End Sub

	''' <summary>
	''' When the control is clicked, display the image
	''' for "normal" (up) state.
	''' </summary>
	Protected Overrides Sub OnClick(ByVal e As System.EventArgs)

		MyBase.OnClick(e)

		Me.SetButtonImage(UP_STATE)

	End Sub
    ''' <summary>
    ''' When a mouse button is released, display the image
    ''' for the "normal" (up) state.
    ''' </summary>
    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)

        MyBase.OnMouseUp(e)

        Me.SetButtonImage(UP_STATE)

    End Sub


    ''' <summary>
	''' When a mouse button is pressed on the control,
	''' display the image for the "depressed" (down) state.
	''' </summary>
	Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)

		MyBase.OnMouseDown(e)

		Me.SetButtonImage(DOWN_STATE)

	End Sub

	''' <summary>
	''' When the control is enabled or disabled, display
    ''' the appropriate image for the enabled (normal) or
	''' disabled (gray) state.
	''' </summary>
	Protected Overrides Sub OnEnabledChanged(ByVal e As System.EventArgs)

		MyBase.OnEnabledChanged(e)

		If Me.Enabled Then
			Me.SetButtonImage(UP_STATE)
		Else
			Me.SetButtonImage(DISABLED_STATE)
		End If

	End Sub

#End Region

#Region " Image Management "

	''' <summary>
	''' This method (called when the ImageList property
	''' is set) sets the appropriate image for the control
	''' based on its enabled state, and sizes itself
	''' to accommodate the dimensions of the image.
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetImageList()

		If Me._imageList IsNot Nothing Then

			If Not Me._imageList.Images.Empty Then

				If Me.Enabled Then
					Me.Image = Me._imageList.Images(UP_STATE)
				Else
					Me.Image = Me._imageList.Images(DISABLED_STATE)
				End If

				Me.Size = New Size(Me.Image.Size.Width, Me.Image.Size.Height)

			End If

		End If

		Me.BackColor = Color.Transparent

	End Sub

	''' <summary>
	''' Set the image to the state specified by the
	''' imageIndex parameter, which must be set to
	''' one of the three values for normal (0),
	''' depressed (1) or disabled (2).
	''' </summary>
	Private Sub SetButtonImage(ByVal imageIndex As Integer)

		If Me._imageList IsNot Nothing AndAlso Me._imageList.Images.Count > imageIndex Then
			Me.Image = Me._imageList.Images(imageIndex)
		End If

	End Sub

#End Region

#Region " Implement IButtonControl "

	''' <summary>
	''' Stub property required to implement IButtonControl
	''' </summary>
	Public Property DialogResult() As DialogResult Implements IButtonControl.DialogResult
		Get
		End Get
		Set(ByVal value As DialogResult)
		End Set
	End Property

	''' <summary>
	''' Stub method required to implement IButtonControl
	''' </summary>
	Public Sub NotifyDefault(ByVal value As Boolean) Implements IButtonControl.NotifyDefault
	End Sub

	''' <summary>
	''' Respond to the notification given by IButtonControl that
	''' a button click has occurred. 
	''' </summary>
	Public Sub PerformClick() Implements IButtonControl.PerformClick
		Me.OnClick(EventArgs.Empty)
	End Sub

#End Region

End Class
