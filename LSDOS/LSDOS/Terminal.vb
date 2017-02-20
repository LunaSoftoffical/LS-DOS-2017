Imports System
Imports System.IO
Module Terminal
    'Variables
    Dim Input As String
    Dim Foldername As String
    Dim Print As String
    Dim Dir As String
    Sub Main()
        Console.Title = "LS-DOS Terminal"
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.Write(">")
        Input = System.Console.ReadLine()
        If Input = "" Then
            Main()
        End If
        If Input.ToLower = "exit" Then
            Environment.Exit(0)
        End If
        If Input.ToLower = "help" Then
            Help.Main()
        End If
        If Input.ToLower = "mkdir" Then
            Console.Write("Folder name: ")
            Foldername = Console.ReadLine
            My.Computer.FileSystem.CreateDirectory("C:\LunaSoft\LS-DOS\" & Foldername)
            Main()
        End If
        If Input.ToLower = "cls" Then
            Console.Clear()
            Main()
        End If
        If Input.ToLower = "calc" Then
            Calculator.Main()
        End If
        If Input.ToLower = "about" Then
            About.Main()
        End If
        If Input.ToLower = "debug" Then
            Debug.Pass()
        End If
        If Input.ToLower = "username" Then
            Username()
        End If
        If Input.ToLower = "password" Then
            Settings.Password()
        End If
        If Input.ToLower = "settings" Then
            Settings.Main()
        End If
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Error: Invalid Command")
        Main()
    End Sub
End Module
