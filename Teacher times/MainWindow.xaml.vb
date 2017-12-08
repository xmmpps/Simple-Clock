Class MainWindow
    Dim dispatcherTimer As New Threading.DispatcherTimer()
    Private Sub 初始化() Handles Me.Loaded
        AddHandler dispatcherTimer.Tick, AddressOf dispatcherTimer_Tick
        dispatcherTimer.Interval = New TimeSpan(0, 0, 1)
        dispatcherTimer.Start()
    End Sub
    Private Sub dispatcherTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim h As String
        h = DateAndTime.Hour(Now)
        Dim a As New RotateTransform(15 * h)
        HourS.RenderTransform = a
        h = DateAndTime.Second(Now)
        a = New RotateTransform(6 * h)
        SecondS.RenderTransform = a
        h = DateAndTime.Minute(Now)
        a = New RotateTransform(6 * h)
        MinuteS.RenderTransform = a
        CommandManager.InvalidateRequerySuggested()
    End Sub
    Private Sub Click() Handles Me.MouseLeftButtonDown
        DragMove()
        [Exit].Visibility = Visibility.Hidden
    End Sub
    Private Sub Sho1w() Handles Me.MouseRightButtonDown
        [Exit].Visibility = Visibility.Visible
    End Sub
    Private Sub Exxit() Handles [Exit].Click
        End
    End Sub
End Class
