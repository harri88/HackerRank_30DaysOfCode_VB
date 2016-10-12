Module Module1

    Sub Main()
        Dim n As Integer
        Dim index As Integer
        n = Console.ReadLine()
        If n >= 2 And n <= 20 Then
            For index = 1 To 10
                Console.WriteLine(n.ToString() + " x " + index.ToString() + " = " + (n * index).ToString())
            Next
            Console.ReadLine()
        End If

    End Sub

End Module
