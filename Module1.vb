Module Module1

    Sub Main()
        Dim Kg As Double
        Dim PrecioPorKg As Double
        Dim Calidad As String
        Dim tamaño As Int32

        Console.WriteLine("Ingrese Calidad siendo : A  ó B .")
        Calidad = Console.ReadLine.ToUpper


        Select Case Calidad
            Case "A"

                Console.WriteLine("Ingreste Tamaño: 1 o 2")
                tamaño = Console.ReadLine
                Console.WriteLine("Ingrese precio por Kg de  Uva.")
                PrecioPorKg = Console.ReadLine
                Console.WriteLine("Ingrese Kg de  Uva.")
                Kg = Console.ReadLine

                If tamaño = 1 Then
                    Console.WriteLine("Usted obtiene de ganacia: $" & (PrecioPorKg * Kg) + 20)
                Else
                    Console.WriteLine("Usted obtiene de ganacia: $" & (PrecioPorKg * Kg) + 30)

                End If

            Case "B"

                Console.WriteLine("Ingreste Tamaño: 1 o 2")
                tamaño = Console.ReadLine
                Console.WriteLine("Ingrese precio por Kg de  Uva.")
                PrecioPorKg = Console.ReadLine
                Console.WriteLine("Ingrese Kg de  Uva.")
                Kg = Console.ReadLine

                If tamaño = 1 Then
                    Console.WriteLine("Usted obtiene de ganacia: $" & (PrecioPorKg * Kg) - 30)
                Else
                    Console.WriteLine("Usted obtiene de ganacia: $" & (PrecioPorKg * Kg) - 50)

                End If
            Case Else
                Console.WriteLine("ERORR..!! Ingrese Letra A ó B")
        End Select
        Console.Read()
    End Sub

End Module
