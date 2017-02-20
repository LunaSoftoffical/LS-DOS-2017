Module Debug
    'Variables
    Dim Password As String

    Sub Pass()
        Console.Title = "LS-DOS Developers console"
        Console.WriteLine("")
        Console.WriteLine("=================================================")
        Console.WriteLine("GS-DOS 2017 Developers console password")
        Console.WriteLine("=================================================")
        Console.Write("Password: ")
        Password = Console.ReadLine
        If Password = My.Settings.DevPASS Then
            Main()
        Else
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Wrong password!")
            Terminal.Main()
        End If
    End Sub
    Sub Main()
        Console.WriteLine("")
        Console.WriteLine("=================================================")
        Console.WriteLine("GS-DOS 2017 Developers console")
        Console.WriteLine("=================================================")
        Console.WriteLine("Version: " & My.Settings.Version)
        Console.WriteLine("Build date: 19/07/2017")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("This version is not ready to be released.")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("=================================================")
        Console.WriteLine("")
        Terminal.Main()
    End Sub
End Module
