Module Module1

    Sub Main()
        Console.WriteLine(" THIS SOFTWARE CALCULATE THE ROOT OF A QUADRATIC EQUATION")

        'FORMULAR: x = (-b +- sqrt(b^2 - 4ac))/2a

        Dim a, b, c, d, e, g, i As Integer
        Dim f, h, x1, x2 As Double

        Console.WriteLine(" ENTER VALUE FOR a:")
        a = Console.ReadLine()

        Console.WriteLine("ENTER VALUE FOR b:")
        b = Console.ReadLine()

        Console.WriteLine(" ENTER VALUE FOR c")
        c = Console.ReadLine()

        d = b * b           'FORMULAR: x = (-b +- sqrt(d - 4ac))/2a
        e = 4 * a * c       'FORMULAR: x = (-b +- sqrt(d - e))/2a
        f = d - e           'FORMULAR: x = (-b +- sqrt(f))/2a
        g = 2 * a           'FORMULAR: x = (-b +- sqrt(f))/g
        h = Math.Sqrt(f)    'FORMULAR: x = (-b +- h)/g

        'FORMULAR: x = (-b - h) / g OR x = (-b + h) / g

        x1 = (-b + h) / g
        x2 = (-b - h) / g

        Console.WriteLine("x1: " & x1.ToString)
        Console.WriteLine("x2: " & x2.ToString)

        Console.ReadLine()

    End Sub

End Module
