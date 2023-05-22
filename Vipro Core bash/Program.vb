Imports System

Module Program
    Sub Main(args As String())
        Dim var
        Do
            Console.Write("X:/source > ")
            var = Console.ReadLine()
            If var = "poweroff" Then
                System.Diagnostics.Process.Start("shutdown", "-s -f -t 00")
            ElseIf var = "restart" Then
                System.Diagnostics.Process.Start("shutdown", "-s -r -f -t 00")
            ElseIf var = "cmd" Then
                Process.Start("C:\\Windows\System32\cmd.exe")
                Do


                Loop

            ElseIf var = "powershell" Then
                Process.Start("C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe")
                Do


                Loop
            ElseIf var = "build" Then
                Console.WriteLine("build complete()")
            ElseIf var = "smartTune.app" Then
                Console.WriteLine("app requires .net 6.0")
                Process.Start("ntpr1.exe")
            ElseIf var = "compress.app" Then
                Console.WriteLine("app requires .net 6.0")
                Process.Start("ntpr2.exe")
            Else
                Try
                    Process.Start(var)
                Catch ex As Exception
                    Console.WriteLine("ProgramErr : Program_DoesNotExist (526f626f74206769726c73207475726e6564206576696c2061726f756e642074686520776f726c64)")
                End Try
            End If

        Loop
    End Sub
End Module
