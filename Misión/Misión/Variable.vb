Imports System.Data
Imports System.Data.SqlClient
Module Variable
    Public cnn As New MBBSDataContext()

    Public IdUsuarioSistemaActual As Integer  ' Id del usuario del sistema actual
    Public NombreUsuarioActual As String = "" ' Nombre del usuario del sistema actual

End Module
