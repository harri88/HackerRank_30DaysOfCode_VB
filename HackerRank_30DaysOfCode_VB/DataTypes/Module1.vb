Module Module1

    Sub Main()
        Dim i As Integer = 4
        Dim d As Double = 4.0
        Dim s As String = "HackerRank "


        Dim ii As Integer
        Dim dd As Double
        Dim ss As String

        ii = Console.ReadLine()
        dd = Console.ReadLine()
        ss = Console.ReadLine()

        Console.WriteLine(i + ii)
        Console.WriteLine((d + dd).ToString("N1"))
        Console.WriteLine(s + ss)

        Console.ReadKey()

    End Sub

End Module
