﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Module code
    'ฐานข้อมูล'
    Friend cn As New SqlConnection("Data Source=LAPTOP-598BT430\SQLEXPRESS1; Initial Catalog=coffeeshopmd; Integrated Security=SSPI;")
    Friend cmd As New SqlCommand
    Friend DA As New SqlDataAdapter
    Friend sql As String




    'เปิดฐานข้อมูลง
    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()

    End Sub


    'ฟังก์ชั้นรีเทินค่าฐานข้อมูล'
    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar
    End Function


    'ฟังก์ชั่นสุ่มตัวเลข security code'
    Friend Function rnd_securitu_code()
        Randomize()
        Dim i As Integer = 99999 * Rnd()
        Return i.ToString.PadLeft(5, "0")

    End Function

    Friend Sub msg_error(text As String, Optional title As String = "ผิดพลาด")
        MsgBox(text, vbCritical + vbOKOnly, title)
    End Sub

    Friend Sub msg_ok(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub


    Friend Function confirm(text As String, Optional title As String = "ยืนยัน")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function

End Module
