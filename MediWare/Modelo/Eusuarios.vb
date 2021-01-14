Public Class Eusuarios
    Dim usuario_ As String
    Dim clave_ As String

    Public Sub New(usuario_ As String, clave_ As String)
        Me.usuario_ = usuario_
        Me.clave_ = clave_
    End Sub

    Public Sub New()
        Me.usuario_ = ""
        Me.clave_ = ""
    End Sub

    Public Property Usuario As String
        Get
            Return usuario_
        End Get
        Set(value As String)
            usuario_ = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return clave_
        End Get
        Set(value As String)
            clave_ = value
        End Set
    End Property
End Class
