Imports System.ComponentModel

Friend Interface IPiano

    Function GetColorTecla() As String

End Interface

Public Class Piano
    Implements IPiano

    Public ReadOnly Property Teclas As Integer

    Sub New(teclas As Integer)
        Me.Teclas = teclas
    End Sub

    Public Function GetColorTecla() As String Implements IPiano.GetColorTecla
        Return New Tecla(Teclas).ColorTecla
    End Function

    Public Function GetCurrentIndex() As Integer
        Return New Tecla(Teclas).Index
    End Function

    Private Class Tecla

        Private _position As Integer

        Friend Sub New(position As Integer)

            Dim value = position / 88

            _position = (value - value) * 100

            If _position = 0 Then
                _position = position
            End If

        End Sub

        Friend ReadOnly Property Index As Integer
            Get
                Return _position
            End Get
        End Property

        Public ReadOnly Property ColorTecla
            Get

                Dim blackColors = {2, 5, 7, 10, 12, 14, 17, 19, 22, 24, 26, 29, 31, 34,
                                   41, 43, 46, 48, 50, 53, 55, 58, 60, 62, 65, 67, 70, 72,
                                   74, 77, 79, 82, 84, 86}

                If blackColors.Contains(_position) Then
                    Return Color.Black.ToString()
                Else
                    Return Color.White.ToString()
                End If

            End Get
        End Property

        Public Enum Color
            <Description("Preta")>
            Black = 1
            <Description("Branca")>
            White = 2
        End Enum

    End Class

End Class



