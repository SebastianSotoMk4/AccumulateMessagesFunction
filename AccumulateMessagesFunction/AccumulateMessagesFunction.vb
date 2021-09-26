'Sebastian Soto
'RCET0265
'Fall 2021
'_projectName
'_gitURL
Option Strict On
Option Explicit On
Module AccumulateMessagesFunction
    Sub Main()
        Dim newMessage As String
        Dim clear As Boolean
        Dim quantity As Integer
        Dim forUser(quantity) As String

        UserMessages(newMessage, clear)

        Do
            quantity = quantity + 1
            For i = LBound(forUser) To UBound(forUser)

                Console.WriteLine(forUser(quantity))


            Next
        Loop Until clear = True
        Console.ReadLine()
    End Sub
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String

        newMessage = Console.ReadLine()


        If newMessage = "clear" Then
            clear = True
            newMessage = Nothing
        End If

        Return newMessage
    End Function
End Module