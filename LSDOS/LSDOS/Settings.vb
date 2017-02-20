Module Settings
    'Variables
    Dim Command As String
    Dim Password1 As String
    Dim Password2 As String
    Dim User As String
    Sub Main()
        Console.Title = "LS-DOS Settings pane"
        Console.WriteLine("")
        Console.WriteLine("LS-DOS 2017 Settings panel")
        Console.WriteLine("=================================================")
        Console.WriteLine("Password   | Changes the password of LS-DOS.")
        Console.WriteLine("Username   | Changes the username of LS-DOS.")
        Console.WriteLine("Exit       | Closes the settings pane.")
        Console.WriteLine("=================================================")
        Console.WriteLine("")
        Console.Write(">")
        Command = Console.ReadLine
        If Command.ToLower = "password" Then
            Password()
        End If
        If Command.ToLower = "username" Then
            Username()
        End If
        If Command.ToLower = "exit" Then
            Terminal.Main()
        End If
    End Sub
    Sub Password()
        Console.WriteLine("")
        Console.WriteLine("Please enter your current password to change your password")
        Console.Write("Current Password: ")
        Password1 = Console.ReadLine
        If Password1 = My.Settings.Password Then
            Console.Write("New Password: ")
            Password2 = Console.ReadLine
            Console.Write("Confirm: ")
            If Console.ReadLine = Password2 Then
                My.Settings.Password = Password2
                My.Settings.Save()
            Else
                Console.WriteLine("Password does not match. Starting over.")
                Password()
            End If
            Console.WriteLine("")
                Terminal.Main()
            End If
    End Sub
    Sub Username()
        Console.WriteLine("")
        Console.Write("New Username: ")
        User = Console.ReadLine
        My.Settings.username = User
        My.Settings.Save()
        Console.WriteLine("")
        Terminal.Main()
    End Sub
End Module
