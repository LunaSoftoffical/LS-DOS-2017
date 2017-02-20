Module Calculator
    'Variables
    Dim Number1 As Integer
    Dim Number2 As Integer
    Dim Answer As Integer
    Dim Division
    Sub Main()
        Console.Title = "LS-DOS Calculator"
        Console.WriteLine("")
        Console.WriteLine("LS-DOS 2017 Calculator")
        Console.WriteLine("=================================================")
        Console.Write("First number: ")
        Number1 = Console.ReadLine
        Console.Write("Second Number: ")
        Number2 = Console.ReadLine
        Console.Write("Division: ")
        Division = Console.ReadLine
        If Division = "+" Then
            Answer = Number1 + Number2
            Console.WriteLine("")
            Console.WriteLine("The answer is: " & Answer)
            Terminal.Main()
        End If
        If Division = "-" Then
            Answer = Number1 - Number2
            Console.WriteLine("")
            Console.WriteLine("The answer is: " & Answer)
            Terminal.Main()
        End If
        If Division = "/" Then
            Answer = Number1 / Number2
            Console.WriteLine("")
            Console.WriteLine("The answer is: " & Answer)
            Console.WriteLine("")
            Terminal.Main()
        End If
        If Division = "*" Then
            Answer = Number1 * Number2
            Console.WriteLine("")
            Console.WriteLine("The answer is: " & Answer)
            Terminal.Main()
        End If
    End Sub
End Module
