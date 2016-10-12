Module Module1

    Sub Main()
        Dim mealCost As Double
        Dim tipPercent As Integer
        Dim taxPercent As Integer
        Dim totalCost As Double
        Dim tip As Integer
        Dim tax As Integer


        mealCost = Console.ReadLine()
        tipPercent = Console.ReadLine()
        taxPercent = Console.ReadLine()

        tip = mealCost * (tipPercent / 100)
        tax = mealCost * (taxPercent / 100)
        totalCost = mealCost + tip + tax

        Console.WriteLine("The total meal cost is " + Math.Floor(totalCost).ToString() + " dollars.")
        Console.ReadKey()
    End Sub
End Module
