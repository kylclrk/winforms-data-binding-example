Imports System.ComponentModel

Public Class Data
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub New(customerName As String)
        _customerName = customerName
    End Sub

    Private Sub NotifyPropertyChanged(Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub


    ' The only thing we need to do to make editable data reactive in the view is to call NotifyPropertyChanged in the setter.
    ' Winforms takes care of the rest.
    Private _customerName As String = String.Empty
    Public Property CustomerName() As String
        Get
            Return _customerName
        End Get

        Set(value As String)
            If Not (value = _customerName) Then
                _customerName = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property

    Public ReadOnly Property SaySomethingNice() As String
        Get
            Dim randomNum As Short = Int((10 * Rnd()) + 1)
            If randomNum > 8 Then
                Return $"{CustomerName} is cool"
            ElseIf randomNum > 6 Then
                Return $"{CustomerName} smells good"
            ElseIf randomNum > 4 Then
                Return $"{CustomerName} eats an appropriate amount usually"
            ElseIf randomNum > 2 Then
                Return $"{CustomerName} deserves to win the lottery"
            Else
                Return $"{CustomerName} is probably a person"
            End If
        End Get
    End Property



End Class
