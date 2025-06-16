Imports System.IO

Public Class FormPoly
    Dim Pen As New Pen(Color.Black, 1)
    Dim g As Graphics

    Dim Current As New TPoint
    Dim Poly As New TPoly
    Dim AP, APL, CurAP As New TArrPoly
    Dim Msg, LineMsg As String
    Dim Edit, Line, ILine As Boolean
    Dim IPolyIdx, IPointIdx, PolyIdx, PointIdx, Width As Integer

    Private Sub FormPoly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poly.Init()
        AP.Init()
        APL.Init()
        IPolyIdx = - 1
        IPointIdx = - 1
        PolyIdx = - 1
        PointIdx = - 1
        Edit = False
        CurAP = AP
    End Sub

    Private Sub RBtnPoly_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnPoly.CheckedChanged
        If RBtnPoly.Checked Then
            Line = False
            GBoxPoly.Text = "List Polygon"
            BtnDelPoly.Text = "Delete Polygon"
            LineMsg = "gon "
            CurAP = AP
        Else
            Line = True
            GBoxPoly.Text = "List Polyline"
            BtnDelPoly.Text = "Delete Polyline"
            LineMsg = "line "
            CurAP = APL
        End If
        UpdLBPoly()
    End Sub

    Private Sub RBtnOne_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnOne.CheckedChanged
        If RBtnOne.Checked Then
            Width = 1
            If PolyIdx <> - 1 Then
                CurAP.Elmt(PolyIdx).Wdth = 1
                CreatePoly()
            End If
        End If
    End Sub

    Private Sub RBtnTwo_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnTwo.CheckedChanged
        If RBtnTwo.Checked Then
            Width = 2
            If PolyIdx <> - 1 Then
                CurAP.Elmt(PolyIdx).Wdth = 2
                CreatePoly()
            End If
        End If
    End Sub

    Private Sub RBtnThree_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnThree.CheckedChanged
        If RBtnThree.Checked Then
            Width = 3
            If PolyIdx <> - 1 Then
                CurAP.Elmt(PolyIdx).Wdth = 3
                CreatePoly()
            End If
        End If
    End Sub

    Private Sub RBtnFour_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnFour.CheckedChanged
        If RBtnFour.Checked Then
            Width = 4
            If PolyIdx <> - 1 Then
                CurAP.Elmt(PolyIdx).Wdth = 4
                CreatePoly()
            End If
        End If
    End Sub

    Private Sub RBtnFive_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnFive.CheckedChanged
        If RBtnFive.Checked Then
            Width = 5
            If PolyIdx <> - 1 Then
                CurAP.Elmt(PolyIdx).Wdth = 5
                CreatePoly()
            End If
        End If
    End Sub

    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            If PolyIdx <> - 1 Then
                CurAP.Elmt(PolyIdx).Clr = ColorDialog1.Color
                CreatePoly()
            End If
            BtnColor.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If IPointIdx = - 1 Then
            Poly.Init()
            AP.Init()
            APL.Init()
            CreatePoly()
            UpdLBPoly()
        Else 'IPointIdx <> -1
            MsgBox("Please click the canvas in the coordinate where the point want to be " & Msg, , "Message")
        End If
    End Sub

    Private Sub BtnUnselect_Click(sender As Object, e As EventArgs) Handles BtnUnselect.Click
        UpdLBPoly()
    End Sub

    Private Sub PicBox_MouseMove(sender As Object, e As MouseEventArgs) Handles PicBox.MouseMove
        LblCoor.Text = "( x , y ) : ( " & e.X & " , " & e.Y & " )"
        Cursor = Cursors.Cross
    End Sub

    Private Sub PicBox_MouseLeave(sender As Object, e As EventArgs) Handles PicBox.MouseLeave
        LblCoor.Text = "( x , y ) :"
        Cursor = Cursors.Default
    End Sub

    Private Sub PicBox_Click(sender As Object, e As MouseEventArgs) Handles PicBox.Click
        If IPointIdx = - 1 Then
            If Poly.N = 0 Then
                Poly.InsLast(e.X, e.Y)
                Poly.Clr = ColorDialog1.Color
                Poly.Wdth = Width
                Pen = New Pen(Poly.Clr, Poly.Wdth)
            Else 'Poly.N <> 0
                g = PicBox.CreateGraphics
                Current = Poly.Elmt(Poly.N - 1)
                g.DrawLine(Pen, Current.X, Current.Y, e.X, e.Y)
                Poly.InsLast(e.X, e.Y)
            End If
        Else 'IPointIdx <> -1
            Dim Pol As New TPoly

            If ILine Then
                Pol = APL.Elmt(IPolyIdx)
            Else 'Not ILine
                Pol = AP.Elmt(IPolyIdx)
            End If

            If Edit Then
                Pol.DelIdx(IPointIdx)
                Edit = False
            End If

            Pol.InsIdx(IPointIdx, e.X, e.Y)
            If PolyIdx = IPolyIdx And ILine = Line Then
                UpdLBPoint(Pol)
            End If

            CreatePoly()
            IPolyIdx = - 1
            IPointIdx = - 1
        End If
    End Sub

    Private Sub PicBox_DoubleClick(sender As Object, e As EventArgs) Handles PicBox.DoubleClick
        If (Poly.N > 2 And Not Line) Or (Poly.N > 1 And Line) Then
            g = PicBox.CreateGraphics
            Current = Poly.Elmt(Poly.N - 1)
            CurAP.InsLast(Poly)
            LBoxPoly.Items.Add("Poly" & LineMsg & CurAP.N)
            If Not Line Then
                g.DrawLine(Pen, Current.X, Current.Y, Poly.Elmt(0).X, Poly.Elmt(0).Y)
            End If

            Poly = New TPoly
            Poly.Init()
        Else '(Poly.N <= 2 Or Line) And (Poly.N <= 1 Or Not Line)
            MsgBox("You need more point(s)", , "Message")
        End If
    End Sub

    Private Sub LBoxPoly_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxPoly.SelectedIndexChanged
        PolyIdx = LBoxPoly.SelectedIndex
        If PolyIdx <> - 1 Then
            UpdLBPoint(CurAP.Elmt(PolyIdx))
        End If
    End Sub

    Private Sub BtnDelPoly_Click(sender As Object, e As EventArgs) Handles BtnDelPoly.Click
        If CurAP.N <> 0 Then
            If PolyIdx <> - 1 Or CurAP.N = 1 Then
                If CurAP.N = 1 Then
                    PolyIdx = 0
                End If

                If PolyIdx <> IPolyIdx Or ILine <> Line Then
                    If PolyIdx < IPolyIdx Then
                        IPolyIdx = IPolyIdx - 1
                    End If

                    CurAP.DelIdx(PolyIdx)
                    UpdLBPoly()
                    CreatePoly()
                Else 'PolyIdx = IPolyIdx And ILine = Line
                    MsgBox("Please click the canvas in the coordinate where the point want to be " & Msg, , "Message")
                End If
            Else 'PolyIdx = -1 And CurAP.N <> 1
                MsgBox("Please choose the poly" & LineMsg & "to be deleted", , "Message")
            End If
        Else 'CurAP.N = 0
            MsgBox("There is no poly" & LineMsg & "in the canvas", , "Message")
        End If
    End Sub

    Private Sub LBoxPoint_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBoxPoint.SelectedIndexChanged
        PointIdx = LBoxPoint.SelectedIndex
    End Sub

    Private Sub BtnDelPoint_Click(sender As Object, e As EventArgs) Handles BtnDelPoint.Click
        Dim Pol As New TPoly
        Dim i As Integer

        If Line Then
            i = 2
        Else 'Not Line
            i = 3
        End If

        If CurAP.N <> 0 Then
            If PolyIdx <> - 1 Then
                If PolyIdx <> IPolyIdx Or ILine <> Line Then
                    Pol = CurAP.Elmt(PolyIdx)
                    If Pol.N > i Then
                        If PointIdx <> - 1 Then
                            Pol.DelIdx(PointIdx)
                            UpdLBPoint(Pol)
                            CreatePoly()
                        Else 'PointIdx = -1
                            MsgBox("Please choose the point to be deleted", , "Message")
                        End If
                    Else 'Pol.N <= i
                        MsgBox("You cannot delete any point", , "Message")
                    End If
                Else 'PolyIdx = IPolyIdx And ILine = Line
                    MsgBox("Please click the canvas in the coordinate where the point want to be " & Msg, , "Message")
                End If
            Else 'PolyIdx = -1
                MsgBox("Please choose the poly" & LineMsg, , "Message")
            End If
        Else 'CurAP.N = 0
            MsgBox("There is no poly" & LineMsg & "in the canvas", , "Message")
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CurAP.N <> 0 Then
            If IPointIdx = - 1 Then
                If PolyIdx <> - 1 Then
                    IPointIdx =
                        Val(InputBox("Input the index for the added point ( 1 - " & CurAP.Elmt(PolyIdx).N + 1 & " )",
                                     "Add Point"))
                    If IPointIdx < 1 Or IPointIdx > CurAP.Elmt(PolyIdx).N + 1 Then
                        MsgBox("Sorry, your input is wrong", , "Message")
                        IPointIdx = - 1
                    Else '1 < IPointIdx < CurAP.Elmt(PolyIdx).N + 1
                        IPolyIdx = PolyIdx
                        IPointIdx = IPointIdx - 1
                        ILine = Line
                        Msg = "added"
                        MsgBox("Now click the canvas in the coordinate where the point want to be added", , "Add Point")
                    End If
                Else 'PolyIdx = -1
                    MsgBox("Please choose the poly" & LineMsg, , "Message")
                End If
            Else 'IPointIdx <> -1
                MsgBox("Please click the canvas in the coordinate where the point want to be " & Msg, , "Message")
            End If
        Else 'CurAP.N = 0
            MsgBox("There is no poly" & LineMsg & "in the canvas", , "Message")
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If CurAP.N <> 0 Then
            If IPointIdx = - 1 Then
                If PolyIdx <> - 1 Then
                    If PointIdx <> - 1 Then
                        IPolyIdx = PolyIdx
                        IPointIdx = PointIdx
                        Edit = True
                        ILine = Line
                        Msg = "edited"
                        MsgBox("Now click the canvas in the coordinate where the point want to be edited", ,
                               "Edit Point")
                    Else 'PointIdx = -1
                        MsgBox("Please choose the point to be edited", , "Message")
                    End If
                Else 'PolyIdx = -1
                    MsgBox("Please choose the poly" & LineMsg, , "Message")
                End If
            Else 'IPolyIdx <> -1
                MsgBox("Please click the canvas in the coordinate where the point want to be " & Msg, , "Message")
            End If
        Else 'CurAP.N = 0
            MsgBox("There is no poly" & LineMsg & "in the canvas", , "Message")
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim FileSW As System.IO.StreamWriter
        Dim SaveFD As New SaveFileDialog()
        Dim ClrConv As New System.Drawing.ColorConverter()
        Dim Pol As New TPoly
        Dim i, j As Integer
        Dim S As String

        SaveFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFD.FilterIndex = 1

        If SaveFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileSW = System.IO.File.CreateText(SaveFD.FileName)
            FileSW.WriteLine(AP.N)
            For i = 1 To AP.N
                Pol = AP.Elmt(i - 1)
                FileSW.WriteLine(Pol.N)
                FileSW.WriteLine(Pol.Wdth)
                S = ClrConv.ConvertToString(Pol.Clr)
                FileSW.WriteLine(S)
                For j = 1 To Pol.N
                    FileSW.Write(Pol.Elmt(j - 1).X)
                    FileSW.WriteLine("")
                    FileSW.Write(Pol.Elmt(j - 1).Y)
                    FileSW.WriteLine("")
                Next
                FileSW.WriteLine("")
            Next
            FileSW.WriteLine("")

            FileSW.WriteLine(APL.N)
            For i = 1 To APL.N
                Pol = APL.Elmt(i - 1)
                FileSW.WriteLine(Pol.N)
                FileSW.WriteLine(Pol.Wdth)
                S = ClrConv.ConvertToString(Pol.Clr)
                FileSW.WriteLine(S)
                For j = 1 To Pol.N
                    FileSW.Write(Pol.Elmt(j - 1).X)
                    FileSW.WriteLine("")
                    FileSW.Write(Pol.Elmt(j - 1).Y)
                    FileSW.WriteLine("")
                Next
                FileSW.WriteLine("")
            Next
            FileSW.WriteLine("")

            FileSW.WriteLine(Poly.N)
            FileSW.WriteLine(Poly.Wdth)
            S = ClrConv.ConvertToString(Poly.Clr)
            FileSW.WriteLine(S)
            For i = 1 To Poly.N
                FileSW.Write(Poly.Elmt(i - 1).X)
                FileSW.WriteLine("")
                FileSW.Write(Poly.Elmt(i - 1).Y)
                FileSW.WriteLine("")
            Next

            FileSW.Close()
        End If
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim Strm As Stream = Nothing
        Dim FileSR As System.IO.StreamReader
        Dim OpenFD As New OpenFileDialog()
        Dim ClrConv As New System.Drawing.ColorConverter()
        Dim Color As System.Drawing.Color
        Dim Pol As New TPoly
        Dim i, j, x, y, ApN, PolN As Integer
        Dim S As String

        OpenFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFD.FilterIndex = 1

        If OpenFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Strm = OpenFD.OpenFile()
                If (Strm IsNot Nothing) Then
                    FileSR = System.IO.File.OpenText(OpenFD.FileName)
                    S = FileSR.ReadLine
                    ApN = Val(S)
                    AP.Init()

                    For i = 1 To ApN
                        S = FileSR.ReadLine
                        PolN = Val(S)
                        Pol.Init()
                        S = FileSR.ReadLine
                        Pol.Wdth = Val(S)
                        S = FileSR.ReadLine
                        Color = CType(ClrConv.ConvertFromString(S), Color)
                        Pol.Clr = Color
                        For j = 1 To PolN
                            S = FileSR.ReadLine
                            x = Val(S)
                            S = FileSR.ReadLine
                            y = Val(S)
                            Pol.InsLast(x, y)
                        Next
                        AP.InsLast(Pol)
                        Pol = New TPoly
                        S = FileSR.ReadLine
                    Next
                    S = FileSR.ReadLine

                    S = FileSR.ReadLine
                    ApN = Val(S)
                    APL.Init()

                    For i = 1 To ApN
                        S = FileSR.ReadLine
                        PolN = Val(S)
                        Pol.Init()
                        S = FileSR.ReadLine
                        Pol.Wdth = Val(S)
                        S = FileSR.ReadLine
                        Color = CType(ClrConv.ConvertFromString(S), Color)
                        Pol.Clr = Color
                        For j = 1 To PolN
                            S = FileSR.ReadLine
                            x = Val(S)
                            S = FileSR.ReadLine
                            y = Val(S)
                            Pol.InsLast(x, y)
                        Next
                        APL.InsLast(Pol)
                        Pol = New TPoly
                        S = FileSR.ReadLine
                    Next
                    S = FileSR.ReadLine

                    S = FileSR.ReadLine
                    PolN = Val(S)
                    Poly.Init()
                    S = FileSR.ReadLine
                    Poly.Wdth = Val(S)
                    S = FileSR.ReadLine
                    Color = CType(ClrConv.ConvertFromString(S), Color)
                    Poly.Clr = Color

                    For i = 1 To PolN
                        S = FileSR.ReadLine
                        x = Val(S)
                        S = FileSR.ReadLine
                        y = Val(S)
                        Poly.InsLast(x, y)
                    Next

                    FileSR.Close()
                    CreatePoly()
                    UpdLBPoly()
                End If
            Catch ex As Exception
                MessageBox.Show("Cannot find file : " & ex.ToString)
            Finally
                If (Strm IsNot Nothing) Then
                    Strm.Close()
                End If
            End Try
        End If
    End Sub

    Public Sub CreatePoly()
        Dim i, j As Integer

        g = PicBox.CreateGraphics
        g.Clear(Color.White)
        For i = 1 To AP.N
            Dim Pol As New TPoly
            Pol = AP.Elmt(i - 1)
            Pen = New Pen(Pol.Clr, Pol.Wdth)
            For j = 0 To Pol.N - 2
                g.DrawLine(Pen, Pol.Elmt(j).X, Pol.Elmt(j).Y, Pol.Elmt(j + 1).X, Pol.Elmt(j + 1).Y)
            Next
            j = Pol.N - 1
            g.DrawLine(Pen, Pol.Elmt(j).X, Pol.Elmt(j).Y, Pol.Elmt(0).X, Pol.Elmt(0).Y)
        Next

        For i = 1 To APL.N
            Dim Pol As New TPoly
            Pol = APL.Elmt(i - 1)
            Pen = New Pen(Pol.Clr, Pol.Wdth)
            For j = 0 To Pol.N - 2
                g.DrawLine(Pen, Pol.Elmt(j).X, Pol.Elmt(j).Y, Pol.Elmt(j + 1).X, Pol.Elmt(j + 1).Y)
            Next
        Next

        Pen = New Pen(Poly.Clr, Poly.Wdth)
        For j = 0 To Poly.N - 2
            g.DrawLine(Pen, Poly.Elmt(j).X, Poly.Elmt(j).Y, Poly.Elmt(j + 1).X, Poly.Elmt(j + 1).Y)
        Next
    End Sub

    Public Sub UpdLBPoly()
        Dim i, j As Integer

        j = CurAP.N
        LBoxPoly.Items.Clear()
        LBoxPoint.Items.Clear()
        For i = 1 To j
            LBoxPoly.Items.Add("Poly" & LineMsg & i)
        Next
        PolyIdx = - 1
    End Sub

    Public Sub UpdLBPoint(ByVal Pol As TPoly)
        Dim Pt As New TPoint
        Dim i As Integer

        LBoxPoint.Items.Clear()
        For i = 1 To Pol.N
            Pt = Pol.Elmt(i - 1)
            LBoxPoint.Items.Add("Point " & i & " : ( " & Pt.X & " , " & Pt.Y & " )")
        Next
        PointIdx = - 1
    End Sub
End Class
