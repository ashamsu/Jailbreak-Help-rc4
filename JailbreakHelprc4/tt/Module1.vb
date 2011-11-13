Module Module1
    Public firmware As String = ""
    Public iPhonev As String = ""
    Public model As String = ""
    Public extra As String = ""
    Public tether As Boolean = False
    Public bits As String
    Public itunesexists As Boolean = False
    Public mode As String
    Private Property window As ProcessWindowStyle

    Public Sub cmd(ByVal file As String, ByVal arg As String)
        'from stantheripper (who probably took it from iH8s0w)...
        Dim procNlite As New Process
        window = 1
        procNlite.StartInfo.FileName = file
        procNlite.StartInfo.Arguments = " " & arg
        procNlite.StartInfo.WindowStyle = window
        Application.DoEvents()
        procNlite.Start()
        Do Until procNlite.HasExited
            Application.DoEvents()
            For i = 0 To 5000000
                Application.DoEvents()
            Next
        Loop
        procNlite.WaitForExit()
    End Sub

    Public Sub modex64()
        'From stantheripper...
        Form2.Button1.Enabled = False
        Form2.Button2.Enabled = False
        Form2.Button3.Enabled = False
        Form2.Label1.Text = "Entering Recovery"
        cmd("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe", "-qo enterrecovery")
        Form2.Label1.Text = "Entered Recovery!"
        Form2.Delay(2)
        Form2.Button1.Enabled = True
        Form2.Button2.Enabled = True
        Form2.Button3.Enabled = True
    End Sub

    Public Sub modex86()
        'From stantheripper...
        Form2.Button1.Enabled = False
        Form2.Button2.Enabled = False
        Form2.Button3.Enabled = False
        Form2.Label1.Text = "Entering Recovery"
        cmd("C:\Program Files\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe", "-qo enterrecovery")
        Form1.Button1.Text = "Entered Recovery"
        Form2.Delay(2)
        Form2.Label1.Text = "Enter Recovery"
        Form2.Button1.Enabled = True
        Form2.Button2.Enabled = True
        Form2.Button3.Enabled = True
    End Sub

    Public Sub ExitRecoverymode()
        'From stantheripper...
        Form2.Button1.Enabled = False
        Form2.Button2.Enabled = False
        Form2.Button3.Enabled = False
        Form2.Label1.Text = "Exiting Recovery"
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = mode & "\itunnel.exe"
        ProcessProperties.Arguments = "--autoboot"
        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        Dim myProcess As Process = Process.Start(ProcessProperties)
        myProcess.WaitForExit(6000)
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If
        Threading.Thread.Sleep(1)
        Form2.Label1.Text = "Exited Recovery"
        Form2.Delay(2)
        Form2.Button1.Enabled = True
        Form2.Button2.Enabled = True
        Form2.Button3.Enabled = True
    End Sub
    'how to jailbreak!
    Public Sub ipt3(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form3.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form3.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub ipt4(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form3.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form3.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub ipt2mc(ByVal fwv As String)
        If fwv = "4.2.1" Then
            greenpois0n.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub ipt2mb(ByVal fwv As String)
        If fwv = "4.2.1" Then
            greenpois0n.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub ipt1(ByVal fwv As String)
        If fwv = "3.1.3" Then
            freezeme.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub atv2(ByVal fwv As String)
        MessageBox.Show("Unsupported firmware, will be supported soon!")
    End Sub
    Public Sub ip1(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form3.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form3.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub ip2(ByVal fwv As String)
        If fwv = "5.0.1" Then
            Form3.Show()
        ElseIf fwv = "5.0" Then
            Form3.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub iph2(ByVal fwv As String)
        If fwv = "3.1.3" Then
            freezeme.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub iph3(ByVal fwv As String)
        If fwv = "4.2.1" Then
            greenpois0n.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub iph3gs(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form3.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form3.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub iph4(ByVal fwv As String)
        If fwv = "5.0.1" Then
            tether = True
            Form3.Show()
        ElseIf fwv = "5.0" Then
            tether = True
            Form3.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
    Public Sub iph4s(ByVal fwv As String)
        If fwv = "5.0.1" Then
            Form3.Show()
        ElseIf fwv = "5.0" Then
            Form3.Show()
        Else
            MessageBox.Show("Unsupported firmware, will be supported soon!")
        End If
    End Sub
End Module
