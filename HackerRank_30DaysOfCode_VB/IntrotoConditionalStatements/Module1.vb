Module Module1

    Sub Main()
        Dim n As Integer
        n = Console.ReadLine()

        If (n >= 1 And n <= 100) Then
            If (n Mod 2 = 1) Then
                Console.WriteLine("Weird")
            Else
                If n >= 2 And n <= 5 Then
                    Console.WriteLine("Not Weird")
                ElseIf n >= 6 And n <= 20 Then
                    Console.WriteLine("Weird")
                Else
                    Console.WriteLine("Not Weird")
                End If
            End If
        End If
    End Sub

End Module
