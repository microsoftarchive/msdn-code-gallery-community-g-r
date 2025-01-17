﻿Namespace My
    <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Partial Friend Class _Dialogs
        Private Function CreateLineBreaks(ByVal Text As String) As String
            Return Text.Replace("~", Environment.NewLine)
        End Function
        ''' <summary>
        ''' Ask question with NO as the default button
        ''' </summary>
        ''' <param name="Text"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Question(ByVal Text As String) As Boolean
            Return (MessageBox.Show(CreateLineBreaks(Text), My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        Public Function Question(ByVal Text As String, ByVal Title As String) As Boolean
            Return (MessageBox.Show(CreateLineBreaks(Text), Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        Public Function QuestionOnFormClosing(ByVal Text As String) As Boolean
            Return Not Question(Text)
        End Function
        ''' <summary>
        ''' Ask question
        ''' </summary>
        ''' <param name="Text">Question to ask</param>
        ''' <param name="Title">Text for dialog caption</param>
        ''' <param name="DefaultButton">Which button is the default</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Question(ByVal Text As String, ByVal Title As String, ByVal DefaultButton As MsgBoxResult) As Boolean
            Dim db As MessageBoxDefaultButton
            If DefaultButton = MsgBoxResult.No Then
                db = MessageBoxDefaultButton.Button2
            End If
            Return (MessageBox.Show(CreateLineBreaks(Text), Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, db) = MsgBoxResult.Yes)
        End Function
        ''' <summary>
        ''' Shows text in dialog with information icon
        ''' </summary>
        ''' <param name="Text">Message to display</param>
        ''' <remarks></remarks>
        Public Sub MsgBox(ByVal Text As String)
            MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Sub MsgBox(ByVal Text As String, ByVal arg0 As Object)
            MessageBox.Show(String.Format(Text, arg0), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Sub MsgBox(ByVal Text As String, ByVal arg0 As Object, ByVal arg1 As Object)
            MessageBox.Show(String.Format(Text, arg0, arg1), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Sub MsgBox(ByVal Text As String, ByVal arg0 As Object, ByVal arg1 As Object, ByVal arg2 As Object)
            MessageBox.Show(String.Format(Text, arg0, arg1, arg2), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        ''' <summary>
        ''' Shows text in dialog with information icon
        ''' </summary>
        ''' <param name="Text">Message to display</param>
        ''' <remarks></remarks>
        Public Sub InformationDialog(ByVal Text As String)
            MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        ''' <summary>
        ''' Shows text in dialog with information icon
        ''' </summary>
        ''' <param name="Text">Message to display</param>
        ''' <param name="Title"></param>
        ''' <remarks></remarks>
        Public Sub InformationDialog(ByVal Text As String, ByVal Title As String)
            MessageBox.Show(Text, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Sub WarningDialog(ByVal Text As String)
            MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub
        Public Sub WarningDialog(ByVal Text As String, ByVal Title As String)
            MessageBox.Show(Text, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub
        ''' <summary>
        ''' For displaying error/exception text with Error icon
        ''' </summary>
        ''' <param name="Text"></param>
        ''' <remarks></remarks>
        Public Sub ExceptionDialog(ByVal Text As String)
            MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        ''' <summary>
        ''' For displaying error/exception text with Error icon
        ''' </summary>
        ''' <param name="Text"></param>
        ''' <param name="Title"></param>
        ''' <remarks></remarks>
        Public Sub ExceptionDialog(ByVal Text As String, ByVal Title As String)
            MessageBox.Show(Text, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        Public Sub ExceptionDialog(ByVal Text As String, ByVal Title As String, ByVal ex As Exception)
            Dim Message As String = String.Concat(Text, Environment.NewLine, ex.Message)
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ex"></param>
        ''' <param name="Text"></param>
        ''' <param name="Title"></param>
        ''' <remarks>
        ''' </remarks>
        Public Sub ExceptionDialog(ByVal ex As Exception, ByVal Text As String, ByVal Title As String)
            MessageBox.Show(String.Format("{0}{1}{2}", Text, Environment.NewLine, ex.Message), Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        ''' <summary>
        ''' Displays a dialog with Abort, Retry and Ignore buttons
        ''' </summary>
        ''' <param name="Text">text to display to the user</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function AbortRetryIgnoreDialog(ByVal Text As String) As DialogResult
            Return MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop)
        End Function
        ''' <summary>
        ''' Displays a dialog with Abort, Retry and Ignore buttons
        ''' </summary>
        ''' <param name="Text">text to display to the user</param>
        ''' <param name="Title">text property of the dialog</param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Default button is the default for this type of dialog
        ''' </remarks>
        Public Function AbortRetryIgnoreDialog(ByVal Text As String, ByVal Title As String) As DialogResult
            Return MessageBox.Show(Text, Title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop)
        End Function
        ''' <summary>
        ''' Displays a dialog with Abort, Retry and Ignore buttons
        ''' </summary>
        ''' <param name="Text">text to display to the user</param>
        ''' <param name="Title">text property of the dialog</param>
        ''' <param name="DefaultButton"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Default button is the default for this type of dialog
        ''' </remarks>
        Public Function AbortRetryIgnoreDialog(ByVal Text As String, ByVal Title As String, ByVal DefaultButton As MessageBoxDefaultButton) As DialogResult
            Return MessageBox.Show(Text, Title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop, DefaultButton)
        End Function
        Public Function IntegerInputBox(ByVal Message As String, ByVal Title As String, ByVal DefaultValue As Integer, ByRef Value As Integer) As Boolean
            Dim Result As Object

            Dim Success As Boolean = False

            Result = InputBox(Message, Title, DefaultValue.ToString)
            If Result IsNot Nothing Then
                If Integer.TryParse(Result.ToString, Value) Then
                    Success = True
                End If
            End If

            Return Success

        End Function
        Public Function IntegerInputBox(ByVal Message As String, ByVal Title As String, ByVal Low As Integer, ByVal High As Integer, ByRef Value As Integer) As Boolean
            Dim Result As Object

            Dim Success As Boolean = False

            Result = InputBox(Message, Title, Low.ToString)
            If Result IsNot Nothing Then
                If Integer.TryParse(Result.ToString, Value) Then
                    If IsBetween(Value, Low, High) Then
                        Success = True
                    End If
                End If
            End If

            Return Success

        End Function
        Private Function IsBetween(ByRef sender As Integer, ByRef LowerLimit As Integer, ByRef UpperLimit As Integer) As Boolean
            If sender < LowerLimit Or sender > UpperLimit Then Return False
            Return True
        End Function
    End Class
    <Global.Microsoft.VisualBasic.HideModuleName()> _
    Friend Module KSG_Dialogs
        Private instance As New ThreadSafeObjectProvider(Of _Dialogs)
        ReadOnly Property Dialogs() As _Dialogs
            Get
                Return instance.GetInstance()
            End Get
        End Property
    End Module
End Namespace
