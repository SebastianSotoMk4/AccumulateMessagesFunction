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
        Dim storage As String
        Dim quit As Boolean

        Do Until quit = True
            Console.WriteLine("Type a message for the user")
            newMessage = Console.ReadLine()

            If newMessage = "quit" Then
                quit = True
            ElseIf newMessage = "show" Then
                MsgBox(UserMessages(newMessage, clear, storage))
            ElseIf newMessage = "clear" Then
                Console.WriteLine("messages cleared")
                clear = True
                storage = UserMessages(newMessage, clear, storage)
            Else
                UserMessages(newMessage, clear, storage)
                storage = UserMessages(newMessage, clear, storage)
            End If
        Loop
        Console.ReadLine()
    End Sub
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean, ByVal storage As String) As String
        Dim messages As String = newMessage + vbNewLine + storage
        'Dim staticMessages As String = ""
        If clear = True Then
            messages = Nothing ' " "
        ElseIf newMessage = "show" Then
            messages = storage
        End If
        Return messages
    End Function
End Module
'Dim storeStr As String = newMessage + vbNewLine + storage