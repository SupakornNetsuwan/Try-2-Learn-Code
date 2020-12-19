
Public Class โปรแกรมซื้อของ
    Dim drag As Boolean
    Dim mousex, mousey, Count, Amounte(36), price(36) As Integer
    Dim id(17) As Integer
    Dim Q(17) As String

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles GI1.Click
        Dim name, m As String
        name = Label1.Text
        m = TextBox1.Text
        Amounte(1) = m
        price(1) = 420 * Amounte(1)
        Dim AQ As String
        AQ = MsgBox(name & Amounte(1) & "ตัว " & "ราคา " & price(1) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(1) & "ตัว " & " ราคา " & price(1) & " บาท"
        End If
    End Sub
    Private Sub GI2_Click(sender As Object, e As EventArgs) Handles GI2.Click
        Dim name, m As String
        name = Label3.Text
        m = TextBox2.Text
        Amounte(2) = m
        price(2) = 26 * Amounte(2)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(2) & "ตัว " & "ราคา " & price(2) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 2
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(2) & "ตัว " & " ราคา " & price(2) & " บาท"
        End If
    End Sub
    Private Sub GI3_Click(sender As Object, e As EventArgs) Handles GI3.Click
        Dim name, m As String
        name = Label5.Text
        m = TextBox3.Text
        Amounte(3) = m
        price(3) = 230 * Amounte(3)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(3) & "ตัว " & "ราคา " & price(3) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 3
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(3) & "ตัว " & " ราคา " & price(3) & " บาท"
        End If
    End Sub
    Private Sub GI4_Click(sender As Object, e As EventArgs) Handles GI4.Click
        Dim name, m As String
        name = Label6.Text
        m = TextBox4.Text
        Amounte(4) = m
        price(4) = 215 * Amounte(4)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(4) & "ตัว " & "ราคา " & price(4) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 4
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(4) & "ตัว " & " ราคา " & price(4) & " บาท"
        End If
    End Sub
    Private Sub GI5_Click(sender As Object, e As EventArgs) Handles GI5.Click
        Dim name, m As String
        name = Label9.Text
        m = TextBox5.Text
        Amounte(5) = m
        price(5) = 860 * Amounte(5)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(5) & "ตัว " & "ราคา " & price(5) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 5
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(5) & "ตัว " & " ราคา " & price(5) & " บาท"
        End If
    End Sub
    Private Sub general_Click(sender As Object, e As EventArgs) Handles general.Click
        Panel1.Show()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel7.Hide()
    End Sub
    Private Sub GI6_Click(sender As Object, e As EventArgs) Handles GI6.Click
        Dim name, m As String
        name = Label60.Text
        m = TextBox6.Text
        Amounte(6) = m
        price(6) = 130 * Amounte(6)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(6) & "ตัว " & "ราคา " & price(6) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 6
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(6) & "ตัว " & " ราคา " & price(6) & " บาท"
        End If
    End Sub
    Private Sub F7_Click(sender As Object, e As EventArgs) Handles F1.Click
        Dim name, m As String
        name = Label24.Text
        m = TextBox12.Text
        Amounte(7) = m
        price(7) = 50 * Amounte(7)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(7) & "ตัว " & "ราคา " & price(7) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 7
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(7) & "ตัว " & " ราคา " & price(7) & " บาท"
        End If
    End Sub

    Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click
        Dim name, m As String
        name = Label28.Text
        m = TextBox9.Text
        Amounte(8) = m
        price(8) = 195 * Amounte(8)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(8) & "ตัว " & "ราคา " & price(8) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 8
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(8) & "ตัว " & " ราคา " & price(8) & " บาท"
        End If
    End Sub
    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
        Dim name, m As String
        name = Label23.Text
        m = TextBox11.Text
        Amounte(9) = m
        price(9) = 18 * Amounte(9)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(9) & "ตัว " & "ราคา " & price(9) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 9
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(9) & "ตัว " & " ราคา " & price(9) & " บาท"
        End If

    End Sub
    Private Sub F4_Click(sender As Object, e As EventArgs) Handles F4.Click
        Dim name, m As String
        name = Label20.Text
        m = TextBox8.Text
        Amounte(10) = m
        price(10) = 40 * Amounte(10)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(10) & "ตัว " & "ราคา " & price(10) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 10
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(10) & "ตัว " & " ราคา " & price(10) & " บาท"
        End If

    End Sub

    Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click
        Dim name, m As String
        name = Label22.Text
        m = TextBox10.Text
        Amounte(11) = m
        price(11) = 36 * Amounte(11)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(11) & "ตัว " & "ราคา " & price(11) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 11
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(11) & "ตัว " & " ราคา " & price(11) & " บาท"
        End If

    End Sub

    Private Sub F6_Click(sender As Object, e As EventArgs) Handles F6.Click
        Dim name, m As String
        name = Label19.Text
        m = TextBox7.Text
        Amounte(12) = m
        price(12) = 129 * Amounte(12)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(12) & "ตัว " & "ราคา " & price(12) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 12
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(12) & "ตัว " & " ราคา " & price(12) & " บาท"
        End If

    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        Dim name, m As String
        name = Label36.Text
        m = TextBox18.Text
        Amounte(1) = m
        price(13) = 450 * Amounte(13)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(13) & "ตัว " & "ราคา " & price(13) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(1) & "ตัว " & " ราคา " & price(13) & " บาท"
        End If


    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        Dim name, m As String
        name = Label33.Text
        m = TextBox15.Text
        Amounte(14) = m
        price(14) = 156 * Amounte(14)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(14) & "ตัว " & "ราคา " & price(14) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(14) & "ตัว " & " ราคา " & price(14) & " บาท"
        End If

    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        Dim name, m As String
        name = TextBox17.Text
        m = Label35.Text
        Amounte(15) = m
        price(1) = 1299 * Amounte(15)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(15) & "ตัว " & "ราคา " & price(15) & " บาท", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(15) & "ตัว " & " ราคา " & price(15) & " บาท"
        End If

    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        Dim name, m As String
        name = Label32.Text
        m = TextBox14.Text
        Amounte(1) = m
        price(1) = 399 * Amounte(16)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(16) & "ตัว " & "ราคา " & price(16) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(16) & "ตัว " & " ราคา " & price(16) & " บาท"
        End If

    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        Dim name, m As String
        name = Label34.Text
        m = TextBox16.Text
        Amounte(17) = m
        price(17) = 279 * Amounte(17)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(17) & "ตัว " & "ราคา " & price(17) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(17) & "ตัว " & " ราคา " & price(17) & " บาท"
        End If

    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        Dim name, m As String
        name = Label31.Text
        m = TextBox13.Text
        Amounte(18) = m
        price(18) = 3500 * Amounte(18)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(18) & "ตัว " & "ราคา " & price(18) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then
            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(18) & "ตัว " & " ราคา " & price(18) & " บาท"
        End If

    End Sub

    Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click
        Dim name, m As String
        name = Label48.Text
        m = TextBox24.Text
        Amounte(19) = m
        price(19) = 450 * Amounte(19)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(19) & "ตัว " & "ราคา " & price(19) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(19) & "ตัว " & " ราคา " & price(19) & " บาท"
        End If

    End Sub

    Private Sub E2_Click(sender As Object, e As EventArgs) Handles E2.Click
        Dim name, m As String
        name = Label45.Text
        m = TextBox21.Text
        Amounte(20) = m
        price(20) = 1550 * Amounte(1)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(20) & "ตัว " & "ราคา " & price(20) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then


            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(20) & "ตัว " & " ราคา " & price(20) & " บาท"
        End If

    End Sub

    Private Sub E3_Click(sender As Object, e As EventArgs) Handles E3.Click
        Dim name, m As String
        name = Label47.Text
        m = TextBox23.Text
        Amounte(21) = m
        price(21) = 4029 * Amounte(1)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(21) & "ตัว " & "ราคา " & price(21) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then


            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(21) & "ตัว " & " ราคา " & price(21) & " บาท"
        End If

    End Sub

    Private Sub E4_Click(sender As Object, e As EventArgs) Handles E4.Click
        Dim name, m As String
        name = Label44.Text
        m = TextBox20.Text
        Amounte(22) = m
        price(22) = 3990 * Amounte(22)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(22) & "ตัว " & "ราคา " & price(22) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(22) & "ตัว " & " ราคา " & price(22) & " บาท"
        End If

    End Sub

    Private Sub E5_Click(sender As Object, e As EventArgs) Handles E5.Click
        Dim name, m As String
        name = TextBox22.Text
        m = Label46.Text
        Amounte(23) = m
        price(23) = 15990 * Amounte(1)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(23) & "ตัว " & "ราคา " & price(23) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then


            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(23) & "ตัว " & " ราคา " & price(23) & " บาท"
        End If

    End Sub

    Private Sub E6_Click(sender As Object, e As EventArgs) Handles E6.Click
        Dim name, m As String
        name = Label43.Text
        m = TextBox19.Text
        Amounte(24) = m
        price(24) = 9990 * Amounte(24)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(24) & "ตัว " & "ราคา " & price(24) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(24) & "ตัว " & " ราคา " & price(24) & " บาท"
        End If

    End Sub

    Private Sub PictureBox84_Click(sender As Object, e As EventArgs) Handles PictureBox84.Click
        Dim name, m As String
        name = Label60.Text
        m = TextBox30.Text
        Amounte(25) = m
        price(25) = 2990 * Amounte(25)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(25) & "ตัว " & "ราคา " & price(25) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(25) & "ตัว " & " ราคา " & price(25) & " บาท"
        End If

    End Sub

    Private Sub PictureBox81_Click(sender As Object, e As EventArgs) Handles PictureBox81.Click
        Dim name, m As String
        name = Label57.Text
        m = TextBox27.Text
        Amounte(26) = m
        price(26) = 3600 * Amounte(26)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(26) & "ตัว " & "ราคา " & price(26) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(26) & "ตัว " & " ราคา " & price(26) & " บาท"
        End If
    End Sub

    Private Sub PictureBox83_Click(sender As Object, e As EventArgs) Handles PictureBox83.Click
        Dim name, m As String
        name = Label59.Text
        m = TextBox29.Text
        Amounte(27) = m
        price(27) = 150 * Amounte(27)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(27) & "ตัว " & "ราคา " & price(27) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(27) & "ตัว " & " ราคา " & price(27) & " บาท"
        End If

    End Sub

    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        Dim name, m As String
        name = Label56.Text
        m = TextBox26.Text
        Amounte(28) = m
        price(28) = 1150 * Amounte(28)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(28) & "ตัว " & "ราคา " & price(28) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(28) & "ตัว " & " ราคา " & price(28) & " บาท"
        End If

    End Sub

    Private Sub PictureBox82_Click(sender As Object, e As EventArgs) Handles PictureBox82.Click
        Dim name, m As String
        name = Label58.Text
        m = TextBox28.Text
        Amounte(29) = m
        price(29) = 51 * Amounte(29)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(29) & "ตัว " & "ราคา " & price(29) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(29) & "ตัว " & " ราคา " & price(29) & " บาท"
        End If

    End Sub

    Private Sub PictureBox79_Click(sender As Object, e As EventArgs) Handles PictureBox79.Click
        Dim name, m As String
        name = Label55.Text
        m = TextBox25.Text
        Amounte(30) = m
        price(30) = 6600 * Amounte(1)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(30) & "ตัว " & "ราคา " & price(30) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(30) & "ตัว " & " ราคา " & price(30) & " บาท"
        End If

    End Sub

    Private Sub PictureBox102_Click(sender As Object, e As EventArgs) Handles PictureBox102.Click
        Dim name, m As String
        name = Label72.Text
        m = TextBox36.Text
        Amounte(31) = m
        price(31) = 105 * Amounte(1)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(31) & "ตัว " & "ราคา " & price(31) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(31) & "ตัว " & " ราคา " & price(31) & " บาท"
        End If

    End Sub
    Private Sub PictureBox99_Click(sender As Object, e As EventArgs) Handles PictureBox99.Click
        Dim name, m As String
        name = Label69.Text
        m = TextBox33.Text
        Amounte(32) = m
        price(32) = 22 * Amounte(1)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(32) & "ตัว " & "ราคา " & price(32) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(32) & "ตัว " & " ราคา " & price(32) & " บาท"
        End If

    End Sub

    Private Sub PictureBox101_Click(sender As Object, e As EventArgs) Handles PictureBox101.Click
        Dim name, m As String
        name = Label71.Text
        m = TextBox35.Text
        Amounte(33) = m
        price(33) = 750 * Amounte(33)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(33) & "ตัว " & "ราคา " & price(33) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(33) & "ตัว " & " ราคา " & price(33) & " บาท"
        End If

    End Sub

    Private Sub PictureBox98_Click(sender As Object, e As EventArgs) Handles PictureBox98.Click
        Dim name, m As String
        name = Label68.Text
        m = TextBox32.Text
        Amounte(34) = m
        price(34) = 90 * Amounte(34)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(34) & "ตัว " & "ราคา " & price(34) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(34) & "ตัว " & " ราคา " & price(34) & " บาท"
        End If

    End Sub

    Private Sub PictureBox100_Click(sender As Object, e As EventArgs) Handles PictureBox100.Click
        Dim name, m As String
        name = Label70.Text
        m = TextBox34.Text
        Amounte(35) = m
        price(35) = 179 * Amounte(35)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(35) & "ตัว " & "ราคา " & price(35) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(35) & "ตัว " & " ราคา " & price(35) & " บาท"
        End If

    End Sub

    Private Sub PictureBox97_Click(sender As Object, e As EventArgs) Handles PictureBox97.Click
        Dim name, m As String
        name = Label67.Text
        m = TextBox31.Text
        Amounte(36) = m
        price(36) = 990 * Amounte(36)
        Dim AQ As String
        AQ = MsgBox(name & " จำนวน " & Amounte(36) & "ตัว " & "ราคา " & price(36) & " บาท ", vbYesNo, "ยืนยันการซื้อ")
        If AQ = vbYes Then

            Count = Count + 1
            id(Count) = 1
            Q(Count) = Count & "." & name & " จำนวน " & Amounte(36) & "ตัว " & " ราคา " & price(36) & " บาท"
        End If

    End Sub
    Private Sub Food_Click(sender As Object, e As EventArgs) Handles Food.Click
        Panel2.Show()
        Panel1.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel7.Hide()
    End Sub
    Private Sub clothes_Click(sender As Object, e As EventArgs) Handles clothes.Click
        Panel3.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel7.Hide()
    End Sub



    Private Sub electronics_Click(sender As Object, e As EventArgs) Handles electronics.Click
        Panel4.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel7.Hide()
    End Sub




    Private Sub furniture_Click_1(sender As Object, e As EventArgs) Handles furniture.Click
        Panel5.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel6.Hide()
        Panel7.Hide()
    End Sub

    Private Sub Youcart_Click(sender As Object, e As EventArgs) Handles Youcart.Click
        Panel7.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub kitchen_Click(sender As Object, e As EventArgs) Handles kitchen.Click
        Panel6.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel7.Hide()
    End Sub
    'ตกแต่ง
    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles WBar.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles WBar.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles WBar.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles CloseBnt.MouseClick
        End
    End Sub
    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles CloseBnt.MouseEnter
        CloseBnt.BackColor = Color.FromArgb(231, 76, 60)
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles CloseBnt.MouseLeave
        CloseBnt.BackColor = Color.FromArgb(35, 39, 42)
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles general.MouseEnter
        general.BackColor = Color.FromArgb(56, 59, 61)
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles general.MouseLeave
        general.BackColor = Color.FromArgb(44, 47, 51)
    End Sub
    Private Sub Food_MouseEnter(sender As Object, e As EventArgs) Handles Food.MouseEnter
        Food.BackColor = Color.FromArgb(56, 59, 61)
    End Sub
    Private Sub Food_MouseLeave(sender As Object, e As EventArgs) Handles Food.MouseLeave
        Food.BackColor = Color.FromArgb(44, 47, 51)
    End Sub
    Private Sub clothes_MouseEnter(sender As Object, e As EventArgs) Handles clothes.MouseEnter
        clothes.BackColor = Color.FromArgb(56, 59, 61)
    End Sub
    Private Sub clothes_MouseLeave(sender As Object, e As EventArgs) Handles clothes.MouseLeave
        clothes.BackColor = Color.FromArgb(44, 47, 51)
    End Sub
    Private Sub electronics_MouseEnter(sender As Object, e As EventArgs) Handles electronics.MouseEnter
        electronics.BackColor = Color.FromArgb(56, 59, 61)
    End Sub
    Private Sub electronics_MouseLeave(sender As Object, e As EventArgs) Handles electronics.MouseLeave
        electronics.BackColor = Color.FromArgb(44, 47, 51)
    End Sub
    Private Sub furniture_MouseEnter(sender As Object, e As EventArgs) Handles furniture.MouseEnter
        furniture.BackColor = Color.FromArgb(56, 59, 61)
    End Sub
    Private Sub furniture_MouseLeave(sender As Object, e As EventArgs) Handles furniture.MouseLeave
        furniture.BackColor = Color.FromArgb(44, 47, 51)
    End Sub
    Private Sub kitchen_MouseEnter(sender As Object, e As EventArgs) Handles kitchen.MouseEnter
        kitchen.BackColor = Color.FromArgb(56, 59, 61)
    End Sub
    Private Sub kitchen_MouseLeave(sender As Object, e As EventArgs) Handles kitchen.MouseLeave
        kitchen.BackColor = Color.FromArgb(44, 47, 51)
    End Sub
    Private Sub Youcart_MouseEnter(sender As Object, e As EventArgs) Handles Youcart.MouseEnter
        Youcart.BackColor = Color.FromArgb(56, 59, 61)
    End Sub
    Private Sub Youcart_MouseLeave(sender As Object, e As EventArgs) Handles Youcart.MouseLeave
        Youcart.BackColor = Color.FromArgb(44, 47, 51)
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles GI1.MouseEnter
        GI1.Image = My.Resources.สั่ง1
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles GI1.MouseLeave
        GI1.Image = My.Resources.สั่ง2
    End Sub
    Private Sub GI2_MouseEnter(sender As Object, e As EventArgs) Handles GI2.MouseEnter
        GI2.Image = My.Resources.สั่ง1
    End Sub
    Private Sub GI2_MouseLeave(sender As Object, e As EventArgs) Handles GI2.MouseLeave
        GI2.Image = My.Resources.สั่ง2
    End Sub
    Private Sub GI3_MouseEnter(sender As Object, e As EventArgs) Handles GI3.MouseEnter
        GI3.Image = My.Resources.สั่ง1
    End Sub
    Private Sub GI3_MouseLeave(sender As Object, e As EventArgs) Handles GI3.MouseLeave
        GI3.Image = My.Resources.สั่ง2
    End Sub
    Private Sub GI4_MouseEnter(sender As Object, e As EventArgs) Handles GI4.MouseEnter
        GI4.Image = My.Resources.สั่ง1
    End Sub
    Private Sub GI4_MouseLeave(sender As Object, e As EventArgs) Handles GI4.MouseLeave
        GI4.Image = My.Resources.สั่ง2
    End Sub
    Private Sub GI5_MouseEnter(sender As Object, e As EventArgs) Handles GI5.MouseEnter
        GI5.Image = My.Resources.สั่ง1
    End Sub
    Private Sub GI5_MouseLeave(sender As Object, e As EventArgs) Handles GI5.MouseLeave
        GI5.Image = My.Resources.สั่ง2
    End Sub
    Private Sub GI6_MouseEnter(sender As Object, e As EventArgs) Handles GI6.MouseEnter
        GI6.Image = My.Resources.สั่ง1
    End Sub
    Private Sub GI6_MouseLeave(sender As Object, e As EventArgs) Handles GI6.MouseLeave
        GI6.Image = My.Resources.สั่ง2
    End Sub
    Private Sub F1_MouseEnter(sender As Object, e As EventArgs) Handles F1.MouseEnter
        F1.Image = My.Resources.สั่ง1
    End Sub
    Private Sub F1_MouseLeave(sender As Object, e As EventArgs) Handles F1.MouseLeave
        F1.Image = My.Resources.สั่ง2
    End Sub
    Private Sub F3_MouseEnter(sender As Object, e As EventArgs) Handles F3.MouseEnter
        F3.Image = My.Resources.สั่ง1
    End Sub
    Private Sub F3_MouseLeave(sender As Object, e As EventArgs) Handles F3.MouseLeave
        F3.Image = My.Resources.สั่ง2
    End Sub
    Private Sub F4_MouseEnter(sender As Object, e As EventArgs) Handles F4.MouseEnter
        F4.Image = My.Resources.สั่ง1
    End Sub
    Private Sub F4_MouseLeave(sender As Object, e As EventArgs) Handles F4.MouseLeave
        F4.Image = My.Resources.สั่ง2
    End Sub
    Private Sub F5_MouseEnter(sender As Object, e As EventArgs) Handles F5.MouseEnter
        F5.Image = My.Resources.สั่ง1
    End Sub
    Private Sub F5_MouseLeave(sender As Object, e As EventArgs) Handles F5.MouseLeave
        F5.Image = My.Resources.สั่ง2
    End Sub
    Private Sub F6_MouseEnter(sender As Object, e As EventArgs) Handles F6.MouseEnter
        F6.Image = My.Resources.สั่ง1
    End Sub
    Private Sub F6_MouseLeave(sender As Object, e As EventArgs) Handles F6.MouseLeave
        F6.Image = My.Resources.สั่ง2
    End Sub
    Private Sub E1_MouseEnter(sender As Object, e As EventArgs) Handles E1.MouseEnter
        E1.Image = My.Resources.สั่ง1
    End Sub
    Private Sub E1_MouseLeave(sender As Object, e As EventArgs) Handles E1.MouseLeave
        E1.Image = My.Resources.สั่ง2
    End Sub
    Private Sub PictureBox48_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox48.MouseEnter
        PictureBox48.Image = My.Resources.สั่ง1
    End Sub
    Private Sub PictureBox48_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox48.MouseLeave
        PictureBox48.Image = My.Resources.สั่ง2
    End Sub
    Private Sub PictureBox45_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox45.MouseEnter
        PictureBox45.Image = My.Resources.สั่ง1
    End Sub
    Private Sub PictureBox45_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox45.MouseLeave
        PictureBox45.Image = My.Resources.สั่ง2
    End Sub
    Private Sub PictureBox47_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox47.MouseEnter
        PictureBox47.Image = My.Resources.สั่ง1
    End Sub
    Private Sub PictureBox47_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox47.MouseLeave
        PictureBox47.Image = My.Resources.สั่ง2
    End Sub
    Private Sub PictureBox44_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox44.MouseEnter
        PictureBox44.Image = My.Resources.สั่ง1
    End Sub
    Private Sub PictureBox44_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox44.MouseLeave
        PictureBox44.Image = My.Resources.สั่ง2
    End Sub
    Private Sub PictureBox46_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox46.MouseEnter
        PictureBox46.Image = My.Resources.สั่ง1
    End Sub
    Private Sub PictureBox46_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox46.MouseLeave
        PictureBox46.Image = My.Resources.สั่ง2
    End Sub
    Private Sub PictureBox43_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox43.MouseEnter
        PictureBox43.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox43_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox43.MouseLeave
        PictureBox43.Image = My.Resources.สั่ง2
    End Sub

    Private Sub E2_MouseEnter(sender As Object, e As EventArgs) Handles E2.MouseEnter
        E2.Image = My.Resources.สั่ง1
    End Sub

    Private Sub E2_MouseLeave(sender As Object, e As EventArgs) Handles E2.MouseLeave
        E2.Image = My.Resources.สั่ง2
    End Sub

    Private Sub E3_MouseEnter(sender As Object, e As EventArgs) Handles E3.MouseEnter
        E3.Image = My.Resources.สั่ง1
    End Sub

    Private Sub E3_MouseLeave(sender As Object, e As EventArgs) Handles E3.MouseLeave
        E3.Image = My.Resources.สั่ง2
    End Sub

    Private Sub E4_MouseEnter(sender As Object, e As EventArgs) Handles E4.MouseEnter
        E4.Image = My.Resources.สั่ง1
    End Sub

    Private Sub E4_MouseLeave(sender As Object, e As EventArgs) Handles E4.MouseLeave
        E4.Image = My.Resources.สั่ง2
    End Sub

    Private Sub E5_MouseEnter(sender As Object, e As EventArgs) Handles E5.MouseEnter
        E5.Image = My.Resources.สั่ง1
    End Sub

    Private Sub E5_MouseLeave(sender As Object, e As EventArgs) Handles E5.MouseLeave
        E5.Image = My.Resources.สั่ง2
    End Sub

    Private Sub E6_MouseEnter(sender As Object, e As EventArgs) Handles E6.MouseEnter
        E6.Image = My.Resources.สั่ง1
    End Sub

    Private Sub E6_MouseLeave(sender As Object, e As EventArgs) Handles E6.MouseLeave
        E6.Image = My.Resources.สั่ง2
    End Sub

    Private Sub F2_MouseEnter(sender As Object, e As EventArgs) Handles F2.MouseEnter
        F2.Image = My.Resources.สั่ง1
    End Sub

    Private Sub F2_MouseLeave(sender As Object, e As EventArgs) Handles F2.MouseLeave
        F2.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox84_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox84.MouseEnter
        PictureBox84.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox84_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox84.MouseLeave
        PictureBox84.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox81_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox81.MouseEnter
        PictureBox81.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox81_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox81.MouseLeave
        PictureBox81.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox83_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox83.MouseEnter
        PictureBox83.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox83_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox83.MouseLeave
        PictureBox83.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox80_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox80.MouseEnter
        PictureBox80.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox80_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox80.MouseLeave
        PictureBox80.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox82_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox82.MouseEnter
        PictureBox82.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox82_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox82.MouseLeave
        PictureBox82.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox79_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox79.MouseEnter
        PictureBox79.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox79_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox79.MouseLeave
        PictureBox79.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox102_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox102.MouseEnter
        PictureBox102.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox102_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox102.MouseLeave
        PictureBox102.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox99_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox99.MouseEnter
        PictureBox99.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox99_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox99.MouseLeave
        PictureBox99.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox101_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox101.MouseEnter
        PictureBox101.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox101_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox101.MouseLeave
        PictureBox101.Image = My.Resources.สั่ง2
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If id(1) = 1 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 2 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 3 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 4 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 5 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 6 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 7 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 8 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 9 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 10 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 11 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 12 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 13 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 14 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 15 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 16 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 17 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 18 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 19 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 20 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 20 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 21 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 22 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 23 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 24 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 25 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 26 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 27 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 28 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 29 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 30 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 31 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 32 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 33 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 34 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 35 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(1) = "ยกเลิกสินค้า"
        ElseIf id(1) = 36 Then
            Label74.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(1) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If id(2) = 1 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 2 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 3 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 4 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 5 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 6 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 7 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 8 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 9 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 20 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 22 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 22 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 23 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 24 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 25 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 26 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 27 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 28 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 29 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 20 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 20 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 22 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 22 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 23 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 24 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 25 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 26 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 27 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 28 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 29 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 30 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 32 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 32 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 33 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 34 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 35 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(2) = "ยกเลิกสินค้า"
        ElseIf id(2) = 36 Then
            Label75.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(2) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label82.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton33_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If id(3) = 1 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 2 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 3 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 4 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 5 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 6 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 7 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 8 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 9 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 10 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 11 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 12 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 13 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 14 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 15 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 16 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 17 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 18 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 19 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 20 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 20 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 21 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 22 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 23 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 24 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 25 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 26 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 27 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 28 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 29 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 30 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 31 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 32 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 33 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 34 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 35 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(3) = "ยกเลิกสินค้า"
        ElseIf id(3) = 36 Then
            Label76.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(3) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        If id(4) = 1 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 2 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 3 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 4 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 5 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 6 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 7 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 8 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 9 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 10 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 11 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 12 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 13 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 14 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 15 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 16 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 17 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 18 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 19 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 20 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 20 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 21 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 22 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 23 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 24 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 25 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 26 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 27 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 28 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 29 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 30 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 31 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 32 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 33 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 34 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 35 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(4) = "ยกเลิกสินค้า"
        ElseIf id(4) = 36 Then
            Label77.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(4) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        If id(5) = 1 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 2 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 3 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 4 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 5 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 6 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 7 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 8 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 9 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 10 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 11 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 12 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 13 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 14 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 15 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 16 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 17 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 18 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 19 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 20 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 20 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 21 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 22 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 23 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 24 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 25 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 26 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 27 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 28 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 29 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 30 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 31 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 32 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 33 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 34 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 35 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(5) = "ยกเลิกสินค้า"
        ElseIf id(5) = 36 Then
            Label78.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(5) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        If id(6) = 1 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 2 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 3 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 4 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 5 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 6 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 7 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 8 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 9 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 10 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 11 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 12 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 13 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 14 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 15 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 16 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 17 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 18 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 19 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 20 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 20 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 21 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 22 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 23 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 24 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 25 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 26 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 27 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 28 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 29 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 30 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 31 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 32 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 33 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 34 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 35 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(6) = "ยกเลิกสินค้า"
        ElseIf id(6) = 36 Then
            Label79.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(6) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        If id(7) = 1 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 2 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 3 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 4 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 5 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 6 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 7 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 8 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 9 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 10 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 11 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 12 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 13 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 14 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 15 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 16 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 17 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 18 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 19 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 20 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 20 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 21 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 22 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 23 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 24 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 25 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 26 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 27 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 28 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 29 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 30 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 31 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 32 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 33 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 34 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 35 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(7) = "ยกเลิกสินค้า"
        ElseIf id(7) = 36 Then
            Label80.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(7) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles BunifuThinButton28.Click
        If id(8) = 1 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 2 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 3 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 4 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 5 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 6 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 7 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 8 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 9 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 10 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 11 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 12 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 13 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 14 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 15 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 16 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 17 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 18 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 19 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 20 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 20 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 21 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 22 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 23 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 24 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 25 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 26 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 27 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 28 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 29 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 30 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 31 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 32 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 33 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 34 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 35 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(8) = "ยกเลิกสินค้า"
        ElseIf id(8) = 36 Then
            Label81.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(8) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton29_Click(sender As Object, e As EventArgs) Handles BunifuThinButton29.Click
        If id(9) = 1 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 2 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 3 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 4 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 5 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 6 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 7 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 8 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 9 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 10 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 11 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 12 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 13 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 14 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 15 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 16 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 17 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 18 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 19 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 20 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 20 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 21 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 22 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 23 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 24 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 25 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 26 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 27 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 28 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 29 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 30 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 31 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 32 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 33 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 34 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 35 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(9) = "ยกเลิกสินค้า"
        ElseIf id(9) = 36 Then
            Label82.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(9) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton210_Click(sender As Object, e As EventArgs) Handles BunifuThinButton210.Click
        If id(10) = 1 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 2 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 3 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 4 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 5 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 6 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 7 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 8 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 9 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 10 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 11 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 12 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 13 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 14 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 15 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 16 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 17 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 18 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 19 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 20 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 20 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 21 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 22 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 23 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 24 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 25 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 26 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 27 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 28 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 29 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 30 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 31 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 32 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 33 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 34 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 35 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(10) = "ยกเลิกสินค้า"
        ElseIf id(10) = 36 Then
            Label83.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(10) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton211_Click(sender As Object, e As EventArgs) Handles BunifuThinButton211.Click
        If id(11) = 1 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 2 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 3 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 4 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 5 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 6 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 7 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 8 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 9 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 10 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 11 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 12 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 13 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 14 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 15 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 16 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 17 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 18 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 19 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 20 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 20 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 21 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 22 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 23 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 24 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 25 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 26 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 27 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 28 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 29 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 30 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 31 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 32 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 33 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 34 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 35 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(11) = "ยกเลิกสินค้า"
        ElseIf id(11) = 36 Then
            Label84.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(11) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton212_Click(sender As Object, e As EventArgs) Handles BunifuThinButton212.Click
        If id(12) = 1 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 2 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 3 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 4 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 5 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 6 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 7 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 8 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 9 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 10 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 11 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 12 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 13 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 14 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 15 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 16 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 17 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 18 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 19 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 20 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 20 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 21 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 22 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 23 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 24 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 25 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 26 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 27 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 28 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 29 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 30 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 31 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 32 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 33 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 34 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 35 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(12) = "ยกเลิกสินค้า"
        ElseIf id(12) = 36 Then
            Label85.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(12) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton213_Click(sender As Object, e As EventArgs) Handles BunifuThinButton213.Click
        If id(13) = 1 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 2 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 3 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 4 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 5 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 6 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 7 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 8 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 9 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 10 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 11 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 12 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 13 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 14 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 15 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 16 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 17 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 18 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 19 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 20 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 20 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 21 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 22 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 23 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 24 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 25 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 26 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 27 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 28 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 29 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 30 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 31 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 32 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 33 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 34 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 35 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(13) = "ยกเลิกสินค้า"
        ElseIf id(13) = 36 Then
            Label86.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(13) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton214_Click(sender As Object, e As EventArgs) Handles BunifuThinButton214.Click
        If id(14) = 1 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 2 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 3 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 4 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 5 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 6 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 7 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 8 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 9 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 10 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 11 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 12 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 13 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 14 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 15 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 16 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 17 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 18 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 19 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 20 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 20 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 21 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 22 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 23 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 24 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 25 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 26 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 27 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 28 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 29 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 30 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 31 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 32 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 33 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 34 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 35 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(14) = "ยกเลิกสินค้า"
        ElseIf id(14) = 36 Then
            Label87.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(14) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton215_Click(sender As Object, e As EventArgs) Handles BunifuThinButton215.Click
        If id(15) = 1 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 2 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 3 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 4 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 5 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 6 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 7 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 8 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 9 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 10 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 11 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 12 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 13 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 14 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 15 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 16 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 17 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 18 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 19 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 20 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 20 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 21 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 22 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 23 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 24 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 25 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 26 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 27 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 28 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 29 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 30 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 31 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 32 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 33 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 34 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 35 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(15) = "ยกเลิกสินค้า"
        ElseIf id(15) = 36 Then
            Label88.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(15) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton216_Click(sender As Object, e As EventArgs) Handles BunifuThinButton216.Click
        If id(16) = 1 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 2 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 3 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 4 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 5 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 6 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 7 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 8 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 9 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 10 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 11 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 12 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 13 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 14 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 15 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 16 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 17 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 18 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 19 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 20 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 20 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 21 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 22 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 23 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 24 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 25 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 26 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 27 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 28 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 29 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 30 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 31 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 32 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 33 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 34 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 35 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(16) = "ยกเลิกสินค้า"
        ElseIf id(16) = 36 Then
            Label89.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(16) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub BunifuThinButton217_Click(sender As Object, e As EventArgs) Handles BunifuThinButton217.Click
        If id(17) = 1 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(1) = 0
            price(1) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 2 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(2) = 0
            price(2) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 3 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(3) = 0
            price(3) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 4 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(4) = 0
            price(4) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 5 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 6 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(6) = 0
            price(6) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 7 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(7) = 0
            price(7) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 8 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(8) = 0
            price(8) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 9 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(9) = 0
            price(9) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 10 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(10) = 0
            price(10) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 11 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(11) = 0
            price(11) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 12 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(12) = 0
            price(12) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 13 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(13) = 0
            price(13) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 14 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(14) = 0
            price(14) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 15 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(15) = 0
            price(15) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 16 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(16) = 0
            price(16) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 17 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(17) = 0
            price(17) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 18 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(18) = 0
            price(18) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 19 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(19) = 0
            price(19) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 20 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 20 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(20) = 0
            price(20) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 21 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(21) = 0
            price(21) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 22 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(22) = 0
            price(22) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 23 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(23) = 0
            price(23) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 24 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(24) = 0
            price(24) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 25 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(25) = 0
            price(25) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 26 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(26) = 0
            price(26) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 27 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(27) = 0
            price(27) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 28 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(28) = 0
            price(28) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 29 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(29) = 0
            price(29) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 30 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(30) = 0
            price(30) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 31 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(31) = 0
            price(31) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 32 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(32) = 0
            price(32) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 33 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(33) = 0
            price(33) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 34 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(34) = 0
            price(34) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 35 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(35) = 0
            price(35) = 0
            Q(17) = "ยกเลิกสินค้า"
        ElseIf id(17) = 36 Then
            Label90.Text = "ยกเลิกสินค้า"
            Amounte(36) = 0
            price(36) = 0
            Q(17) = "ยกเลิกสินค้า"
        End If
        Label74.Text = Q(1)
        Label75.Text = Q(2)
        Label76.Text = Q(3)
        Label77.Text = Q(4)
        Label78.Text = Q(5)
        Label79.Text = Q(6)
        Label80.Text = Q(7)
        Label81.Text = Q(8)
        Label82.Text = Q(9)
        Label83.Text = Q(10)
        Label84.Text = Q(11)
        Label85.Text = Q(12)
        Label86.Text = Q(13)
        Label87.Text = Q(14)
        Label88.Text = Q(15)
        Label89.Text = Q(16)
        Label90.Text = Q(17)
        Dim PriceAll As Integer
        PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
        Label91.Text = PriceAll
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As MouseEventArgs) Handles CloseBnt.MouseClick

    End Sub

    Private Sub BunifuThinButton218_Click(sender As Object, e As EventArgs) Handles BunifuThinButton218.Click
        Dim A As String
        A = MsgBox("คุณได้ตรวจสอบรายการทั้งหมดแล้วใช่ไหม" & vbCrLf & "ยืนยันการซื้อ?", MsgBoxStyle.YesNo, "ยืนยันรายการ")
        If A = vbYes Then
            Count = 0
            price(1) = 0
            price(2) = 0
            price(3) = 0
            price(4) = 0
            price(5) = 0
            price(6) = 0
            price(7) = 0
            price(8) = 0
            price(9) = 0
            price(10) = 0
            price(11) = 0
            price(12) = 0
            price(13) = 0
            price(14) = 0
            price(15) = 0
            price(16) = 0
            price(17) = 0
            price(18) = 0
            price(19) = 0
            price(20) = 0
            price(21) = 0
            price(22) = 0
            price(23) = 0
            price(24) = 0
            price(25) = 0
            price(26) = 0
            price(27) = 0
            price(28) = 0
            price(29) = 0
            price(30) = 0
            price(31) = 0
            price(32) = 0
            price(33) = 0
            price(34) = 0
            price(35) = 0
            price(36) = 0
            Amounte(1) = 0
            Amounte(2) = 0
            Amounte(3) = 0
            Amounte(4) = 0
            Amounte(5) = 0
            Amounte(6) = 0
            Amounte(7) = 0
            Amounte(8) = 0
            Amounte(9) = 0
            Amounte(10) = 0
            Amounte(11) = 0
            Amounte(12) = 0
            Amounte(13) = 0
            Amounte(14) = 0
            Amounte(15) = 0
            Amounte(16) = 0
            Amounte(17) = 0
            Amounte(18) = 0
            Amounte(19) = 0
            Amounte(20) = 0
            Amounte(21) = 0
            Amounte(22) = 0
            Amounte(23) = 0
            Amounte(24) = 0
            Amounte(25) = 0
            Amounte(26) = 0
            Amounte(27) = 0
            Amounte(28) = 0
            Amounte(29) = 0
            Amounte(30) = 0
            Amounte(31) = 0
            Amounte(32) = 0
            Amounte(33) = 0
            Amounte(34) = 0
            Amounte(35) = 0
            Amounte(36) = 0
            id(1) = 0
            id(2) = 0
            id(3) = 0
            id(4) = 0
            id(5) = 0
            id(6) = 0
            id(7) = 0
            id(8) = 0
            id(9) = 0
            id(10) = 0
            id(11) = 0
            id(12) = 0
            id(13) = 0
            id(14) = 0
            id(15) = 0
            id(16) = 0
            id(17) = 0
            Q(1) = ""
            Q(2) = ""
            Q(3) = ""
            Q(4) = ""
            Q(5) = ""
            Q(6) = ""
            Q(7) = ""
            Q(8) = ""
            Q(9) = ""
            Q(10) = ""
            Q(11) = ""
            Q(12) = ""
            Q(13) = ""
            Q(14) = ""
            Q(15) = ""
            Q(16) = ""
            Q(17) = ""

            Label74.Text = Q(1)
            Label75.Text = Q(2)
            Label76.Text = Q(3)
            Label77.Text = Q(4)
            Label78.Text = Q(5)
            Label79.Text = Q(6)
            Label80.Text = Q(7)
            Label81.Text = Q(8)
            Label82.Text = Q(9)
            Label83.Text = Q(10)
            Label84.Text = Q(11)
            Label85.Text = Q(12)
            Label86.Text = Q(13)
            Label87.Text = Q(14)
            Label88.Text = Q(15)
            Label89.Text = Q(16)
            Label90.Text = Q(17)
            Dim PriceAll As Integer
            PriceAll = price(1) + price(2) + price(3) + price(4) + price(5) + price(6) + price(7) + price(8) + price(9) + price(10) + price(11) + price(12) + price(13) + price(14) + price(15) + price(16) + price(17) + price(18) + price(19) + price(20) + price(21) + price(22) + price(23) + price(24) + price(25) + price(26) + price(27) + price(28) + price(29) + price(30) + price(31) + price(32) + price(33) + price(34) + price(35) + price(36)
            Label91.Text = PriceAll
        End If
    End Sub

    Private Sub PictureBox98_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox98.MouseEnter
        PictureBox98.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox98_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox98.MouseLeave
        PictureBox98.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox100_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox100.MouseEnter
        PictureBox100.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox100_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox100.MouseLeave
        PictureBox100.Image = My.Resources.สั่ง2
    End Sub

    Private Sub PictureBox97_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox97.MouseEnter
        PictureBox97.Image = My.Resources.สั่ง1
    End Sub

    Private Sub PictureBox97_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox97.MouseLeave
        PictureBox97.Image = My.Resources.สั่ง2
    End Sub


End Class
