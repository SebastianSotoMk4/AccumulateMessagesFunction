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
        Dim message As String = UserMessages(newMessage, clear)

        Console.WriteLine(message)



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