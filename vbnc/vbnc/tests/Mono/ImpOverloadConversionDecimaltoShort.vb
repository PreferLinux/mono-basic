'Author:
'   V. Sudharsan (vsudharsan@novell.com)
'
' (C) 2005 Novell, Inc.
Option Strict Off

Module ImpConversionDecimaltoShort
    Function fun(ByVal i As Short)
        If i <> 10 Then
            System.Console.WriteLine("Implicit Conversion of Decimal to Short not working. Expected 10 but got " & i) : Return 1
        End If
    End Function
    Function Main() As Integer
        Dim i As Decimal = 10
        fun(i)

    End Function
End Module
