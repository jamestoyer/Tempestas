Public Class Button
    ' Enumeration for different states
    Private Enum intState As Integer
        UpLeave = 0
        Enter = 1
        Down = 2
        Disabled = 3
    End Enum

    ' The image list variable
    Dim imgImages As ImageList

    Public Property ImageList() As ImageList
        Get
            Return Me.imgImages
        End Get
        Set(ByVal value As ImageList)
            Me.imgImages = value

            ' Set up the control for the image list
            Me.SetImageList()
        End Set
    End Property

    Private Sub SetImageList()
        ' Check to see if an image list is attached and act accordingly
        If Me.imgImages IsNot Nothing Then
            ' Check to see if the image list contains images and act accordingly
            If Not Me.imgImages.Images.Empty Then
                ' Get the state of the button and act accordingly
                If Me.Enabled Then
                    ' If the button is enabled then show the enabled image
                    Me.BackgroundImage = Me.imgImages.Images(intState.UpLeave)
                Else
                    ' If the button is diabled then show the disabled image
                    Me.BackgroundImage = Me.imgImages.Images(intState.Disabled)
                End If

                ' Resize the control to be the size of the image
                Me.Size = New Size(Me.BackgroundImage.Size.Width, Me.BackgroundImage.Size.Height)
            End If
        End If

        ' Set the back colour to transparent
        Me.BackColor = Color.Transparent

    End Sub

    Private Sub SetButtonImage(ByVal imageIndex As Integer)
        ' Check to see if an imagelist is selected and that there is and image for the state chosen
        If Me.imgImages IsNot Nothing AndAlso Me.imgImages.Images.Count > imageIndex Then
            ' Set the background image of the button
            Me.BackgroundImage = Me.imgImages.Images(imageIndex)
        End If

    End Sub

    Private Sub Button_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Call the set image list sub
        Me.SetImageList()
    End Sub

    Private Sub Button_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        ' Set the image to the up state
        Me.SetButtonImage(intState.Enter)
    End Sub

    Private Sub Button_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ' Set the image to the down state
        Me.SetButtonImage(intState.Down)
    End Sub

    Private Sub Button_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        ' Set the image to the up state
        Me.SetButtonImage(intState.Enter)
    End Sub

    Private Sub Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        ' Set the image to the up state
        Me.SetButtonImage(intState.UpLeave)
    End Sub

    Private Sub Button_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        ' Set the image to the up state
        Me.SetButtonImage(intState.Enter)
    End Sub
End Class
