'Sebastian Soto
'RCET0265
'Fall 2021
'AccumulateMessageFunction
'https://github.com/SebastianSotoMk4/AccumulateMessagesFunction.git
Option Strict On
Option Explicit On
Module AccumulateMessagesFunction
    Sub Main()
        Dim newMessage As String
        Dim clear As Boolean
        Dim storage As String
        Dim quit As Boolean
        'type "quit" to close program 
        'type "show" to view messages
        'type "clear" to clear erase stored messages
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

                'comment storage
            Else
                UserMessages(newMessage, clear, storage)
                storage = UserMessages(newMessage, clear, storage)
            End If
        Loop
        Console.ReadLine()
    End Sub
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean, ByVal storage As String) As String
        Dim messages As String = newMessage + vbNewLine + storage
        If clear = True Then
            messages = Nothing ' " "
        ElseIf newMessage = "show" Then
            messages = storage
        End If
        Return messages
    End Function
End Module