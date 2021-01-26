Imports Newtonsoft.Json

Public Class Perfil
    Public Property Perfiles() As List(Of Configuracion)

    Public Sub SaveConfig()
        Save_Config(Perfiles)
    End Sub

    Public Sub LoadConfig()
        Perfiles = Load_Config()
    End Sub
End Class
