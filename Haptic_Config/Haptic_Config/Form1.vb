Option Strict On
Imports System.IO

Public Class Form1
    ' ** The following strings are for composing the ip address **
    Private Property addr1 As String

    Private Property addr2 As String

    Private Property dec As String

    Private Property addr3 As String

    Private Property addr4 As String

    ' ** When form loads store the decimal **
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dec = "."
    End Sub

    '** SAVE CONFIGURATION SETTINGS **
    Private Sub applyConfigBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles applyConfigBtn.Click

        ' ** WRITE HAPTIC CONFIGURATION SETTINGS TO: config.txt **

        Dim writer As StreamWriter = _
        New StreamWriter("config.txt")
        writer.Write("address: ")
        ' ** get address values from textbox input and  **
        ' ** store values in config file                **
        writer.Write(tarAddrBox1.Text)
        writer.Write(dec)
        writer.Write(tarAddrbox2.Text)
        writer.Write(dec)
        writer.Write(tarAddrBox3.Text)
        writer.Write(dec)
        writer.WriteLine(tarAddrBox4.Text)

        writer.Write("master: ")
        '** Check if master checkbox is checked **
        '** Write the boolean to the configuration **
        If (masterRad.Checked) Then
            writer.WriteLine("yes")
        ElseIf (slaveRad.Checked) Then
            writer.WriteLine("no")
        End If

        writer.Write("sensors: ")
        '** Check if labview force sensors box is checked **
        '** Write the boolean to the configuration **
        If (sensorBox.Checked) Then
            writer.WriteLine("yes")
        Else
            writer.WriteLine("no")
        End If

        writer.Close()

    End Sub


    '** SAVE CONFIGURATION SETTINGS AND CLOSE **
    Private Sub okBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okBtn.Click
        ' ** WRITE HAPTIC CONFIGURATION SETTINGS TO: config.txt **

        Dim writer As StreamWriter = _
        New StreamWriter("config.txt")
        writer.Write("address: ")
        ' ** get address values from textbox input and  **
        ' ** store values in config file                **
        writer.Write(tarAddrBox1.Text)
        writer.Write(dec)
        writer.Write(tarAddrbox2.Text)
        writer.Write(dec)
        writer.Write(tarAddrBox3.Text)
        writer.Write(dec)
        writer.WriteLine(tarAddrBox4.Text)

        writer.Write("master: ")
        '** Check if master checkbox is checked **
        '** Write the boolean to the configuration **
        If (masterRad.Checked) Then
            writer.WriteLine("yes")
        ElseIf (slaveRad.Checked) Then
            writer.WriteLine("no")
        End If

        writer.Write("sensors: ")
        '** Check if labview force sensors box is checked **
        '** Write the boolean to the configuration **
        If (sensorBox.Checked) Then
            writer.WriteLine("yes")
        Else
            writer.WriteLine("no")
        End If

        writer.Close()
        Close()

    End Sub

End Class
