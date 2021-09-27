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
        Dim quit As Boolean

        Dim message As String
        Dim storage As String
        Do Until quit = True

            Console.WriteLine("Type a message for the user:")
            UserMessages(newMessage, clear, storage)
            If UserMessages(newMessage, clear, storage) = "quit" Then
                quit = True
            End If
        Loop

        Console.ReadLine()
    End Sub
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean, ByVal storage As String) As String
        Dim storeStr As String = newMessage + vbNewLine + storage
        newMessage = Console.ReadLine()

        If newMessage = "clear" Then
            storeStr = Nothing

        ElseIf newMessage = "show" Then
            storage = newMessage

        End If

        Return storage
    End Function
End Module