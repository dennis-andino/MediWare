Public Class Easegurado
    Private _Aseg_Codigo, _Aseg_Nacionalidad, _Aseg_DeptoNac, _Aseg_CiudadNac, _Aseg_Peso, _Aseg_DeptoRes, _Aseg_CiudadRes As Integer
    Private _Aseg_Id, _Aseg_Nombre, _Aseg_Apellido, _Aseg_nomConyugue, _Aseg_NomEmpresa, _Aseg_EmpresaWeb, _Aseg_puestoTrab, _Aseg_direccionRes, _Aseg_nomAseguradoraT As String
    Private _Aseg_FechaNac As Date
    Private _Aseg_Estatura, _Aseg_AntiguedadLab, _Aseg_tiempoT As Byte
    Private _Aseg_Genero, _Aseg_EstadoCivil As Char

    Public Sub New()

    End Sub

    Public Property Aseg_Codigo As Integer
        Get
            Return _Aseg_Codigo
        End Get
        Set(value As Integer)
            _Aseg_Codigo = value
        End Set
    End Property

    Public Property Aseg_Nacionalidad As Integer
        Get
            Return _Aseg_Nacionalidad
        End Get
        Set(value As Integer)
            _Aseg_Nacionalidad = value
        End Set
    End Property

    Public Property Aseg_DeptoNac As Integer
        Get
            Return _Aseg_DeptoNac
        End Get
        Set(value As Integer)
            _Aseg_DeptoNac = value
        End Set
    End Property

    Public Property Aseg_CiudadNac As Integer
        Get
            Return _Aseg_CiudadNac
        End Get
        Set(value As Integer)
            _Aseg_CiudadNac = value
        End Set
    End Property

    Public Property Aseg_Peso As Integer
        Get
            Return _Aseg_Peso
        End Get
        Set(value As Integer)
            _Aseg_Peso = value
        End Set
    End Property

    Public Property Aseg_DeptoRes As Integer
        Get
            Return _Aseg_DeptoRes
        End Get
        Set(value As Integer)
            _Aseg_DeptoRes = value
        End Set
    End Property

    Public Property Aseg_CiudadRes As Integer
        Get
            Return _Aseg_CiudadRes
        End Get
        Set(value As Integer)
            _Aseg_CiudadRes = value
        End Set
    End Property

    Public Property Aseg_direccionRes As String
        Get
            Return _Aseg_direccionRes
        End Get
        Set(value As String)
            _Aseg_direccionRes = value
        End Set
    End Property

    Public Property Aseg_Id As String
        Get
            Return _Aseg_Id
        End Get
        Set(value As String)
            _Aseg_Id = value
        End Set
    End Property

    Public Property Aseg_Nombre As String
        Get
            Return _Aseg_Nombre
        End Get
        Set(value As String)
            _Aseg_Nombre = value
        End Set
    End Property

    Public Property Aseg_Apellido As String
        Get
            Return _Aseg_Apellido
        End Get
        Set(value As String)
            _Aseg_Apellido = value
        End Set
    End Property

    Public Property Aseg_nomConyugue As String
        Get
            Return _Aseg_nomConyugue
        End Get
        Set(value As String)
            _Aseg_nomConyugue = value
        End Set
    End Property

    Public Property Aseg_NomEmpresa As String
        Get
            Return _Aseg_NomEmpresa
        End Get
        Set(value As String)
            _Aseg_NomEmpresa = value
        End Set
    End Property

    Public Property Aseg_EmpresaWeb As String
        Get
            Return _Aseg_EmpresaWeb
        End Get
        Set(value As String)
            _Aseg_EmpresaWeb = value
        End Set
    End Property

    Public Property Aseg_puestoTrab As String
        Get
            Return _Aseg_puestoTrab
        End Get
        Set(value As String)
            _Aseg_puestoTrab = value
        End Set
    End Property

    Public Property Aseg_nomAseguradoraT As String
        Get
            Return _Aseg_nomAseguradoraT
        End Get
        Set(value As String)
            _Aseg_nomAseguradoraT = value
        End Set
    End Property

    Public Property Aseg_FechaNac As Date
        Get
            Return _Aseg_FechaNac
        End Get
        Set(value As Date)
            _Aseg_FechaNac = value
        End Set
    End Property

    Public Property Aseg_Estatura As Byte
        Get
            Return _Aseg_Estatura
        End Get
        Set(value As Byte)
            _Aseg_Estatura = value
        End Set
    End Property

    Public Property Aseg_AntiguedadLab As Byte
        Get
            Return _Aseg_AntiguedadLab
        End Get
        Set(value As Byte)
            _Aseg_AntiguedadLab = value
        End Set
    End Property

    Public Property Aseg_tiempoT As Byte
        Get
            Return _Aseg_tiempoT
        End Get
        Set(value As Byte)
            _Aseg_tiempoT = value
        End Set
    End Property

    Public Property Aseg_Genero As Char
        Get
            Return _Aseg_Genero
        End Get
        Set(value As Char)
            _Aseg_Genero = value
        End Set
    End Property

    Public Property Aseg_EstadoCivil As Char
        Get
            Return _Aseg_EstadoCivil
        End Get
        Set(value As Char)
            _Aseg_EstadoCivil = value
        End Set
    End Property
End Class
