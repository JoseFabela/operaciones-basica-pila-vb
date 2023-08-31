Module Module1

    Dim maxSize As Integer = 10
        Dim stackArray(maxSize - 1) As Integer
        Dim top As Integer = -1

        Sub Push(item As Integer)
            If top < maxSize - 1 Then
                top += 1
                stackArray(top) = item
            Else
                Console.WriteLine("Stack Overflow")
            End If
        End Sub

        Function Pop() As Integer
            If top >= 0 Then
                Dim item As Integer = stackArray(top)
                top -= 1
                Return item
            Else
                Console.WriteLine("Stack Underflow")
                Return -1 ' or throw an exception
            End If
        End Function




        Sub Main()
            Push(10)
            Push(20)
            Push(30)

            Console.WriteLine("Popped: " & Pop()) ' Output: 30
            Console.WriteLine("Popped: " & Pop()) ' Output: 20
        End Sub

End Module
