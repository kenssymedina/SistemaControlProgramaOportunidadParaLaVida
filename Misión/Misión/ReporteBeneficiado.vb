Imports DevExpress.XtraReports.UI
Public Class ReporteBeneficiado

    Public Sub generareporte(ByVal fechai As Integer)

        Me.parameter1.Visible = False
        Me.parameter1.Value = fechai
    End Sub

End Class