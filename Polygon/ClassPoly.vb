Public Class TPoint
    Public X As Integer
    Public Y As Integer

    Public Sub SetP(ByVal PX As Integer, ByVal PY As Integer)
        X = PX
        Y = PY
    End Sub
End Class

Public Class TPoly
    Public N As Integer
    Public Elmt() As TPoint
    Public Wdth As Integer
    Public Clr As Color

    Sub Init()
        N = 0
        ReDim Elmt(- 1)
        Wdth = 1
        Clr = Color.Black
    End Sub

    Public Overloads Sub InsLast(ByVal x As Integer, ByVal y As Integer)
        Dim P As New TPoint
        ReDim Preserve Elmt(N)

        P.SetP(x, y)
        Elmt(N) = P
        N = N + 1
    End Sub

    Public Overloads Sub InsIdx(ByVal idx As Integer, ByVal x As Integer, ByVal y As Integer)
        Dim P As New TPoint
        Dim i As Integer
        ReDim Preserve Elmt(N)

        For i = N - 1 To idx Step - 1
            Elmt(i + 1) = Elmt(i)
        Next

        P.SetP(x, y)
        Elmt(idx) = P
        N = N + 1
    End Sub

    Public Overloads Sub DelIdx(ByVal idx As Integer)
        Dim i As Integer
        Dim P As TPoint

        P = Elmt(idx)
        For i = idx To N - 2
            Elmt(i) = Elmt(i + 1)
        Next
        N = N - 1
    End Sub
End Class


Public Class TArrPoly
    Public N As Integer
    Public Elmt() As TPoly

    Sub Init()
        N = 0
        ReDim Elmt(- 1)
    End Sub

    Public Overloads Sub InsLast(ByVal P As TPoly)
        ReDim Preserve Elmt(N)

        Elmt(N) = P
        N = N + 1
    End Sub

    Public Overloads Sub DelIdx(ByVal idx As Integer)
        Dim i As Integer
        Dim P As TPoly

        P = Elmt(idx)
        For i = idx To N - 2
            Elmt(i) = Elmt(i + 1)
        Next
        N = N - 1
    End Sub
End Class
