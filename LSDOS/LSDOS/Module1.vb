Module Module1
    'Variables
    Dim Pass As String
    Sub Password()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("LS-DOS Password")
        Console.WriteLine("")
        Console.Write("Password: ")
        Pass = Console.ReadLine
        If Pass = My.Settings.Password Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Welcome to LS-DOS 2017 " & My.Settings.username & ", " & "Check out all of the commands by using help")
            Console.WriteLine("")
            Terminal.Main()
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Wrong password!")
            Console.ForegroundColor = ConsoleColor.White
            Threading.Thread.Sleep(1000)
            Console.Clear()
            Password()
        End If
    End Sub
    Sub Main()
        Console.Title = "GS-DOS"
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Starting LS-DOS 2017...")
        Threading.Thread.Sleep(1000)
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        If My.Settings.Password = String.Empty Then
            Console.WriteLine("Welcome to LS-DOS 2017 " & My.Settings.username & ", " & "Check out all of the commands by using help")
            Console.WriteLine("")
            Terminal.Main()
        Else
            Password()
        End If
    End Sub
End Module
