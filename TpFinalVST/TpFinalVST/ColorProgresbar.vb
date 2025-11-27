Public Class ColorProgresbar
    Inherits ProgressBar
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim rec As Rectangle = e.ClipRectangle
        rec.Width = CInt(rec.Width * (Value / Maximum))
        If ProgressBarRenderer.IsSupported Then ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle)
        e.Graphics.FillRectangle(New SolidBrush(Color.DodgerBlue), 0, 0, rec.Width, rec.Height)
    End Sub
End Class
