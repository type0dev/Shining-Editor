Imports System.ComponentModel
Imports System.Linq

''' <summary>
''' A dropdown and field combo.
''' </summary>

Public Class XC2FieldTypeEditor
    Inherits UserControl
    Implements INotifyPropertyChanged

    Private Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public ReadFromFile As Func(Of HexDataInfo, Integer) = Nothing
    Public SaveToFile As Action(Of HexDataInfo, Integer) = Nothing

    Public Property FieldTypeLabel As String
        Get
            Return _fieldTypeLabel
        End Get
        Set(value As String)
            _fieldTypeLabel = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(FieldTypeLabel)))
        End Set
    End Property
    Private _fieldTypeLabel As String = Nothing

    Public Property FieldValueLabel As String
        Get
            Return _fieldValueLabel
        End Get
        Set(value As String)
            _fieldValueLabel = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(FieldValueLabel)))
        End Set
    End Property
    Private _fieldValueLabel As String = "Value"

    Public Property CanEdit As Boolean
        Get
            Return _canEdit
        End Get
        Set(value As Boolean)
            _canEdit = value
            LoadValueFromFile(TypeDropdown, EventArgs.Empty)
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(CanEdit)))
        End Set
    End Property
    Private _canEdit As Boolean = False

    Public Property CurrentValue As String
        Get
            Return _currentValue
        End Get
        Set(value As String)
            _currentValue = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(CurrentValue)))
        End Set
    End Property
    Private _currentValue As String = Nothing

    Public Property DataSource As List(Of XC2NamedField)
        Get
            Return _dataSource
        End Get
        Set(value As List(Of XC2NamedField))
            _dataSource = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(DataSource)))
        End Set
    End Property
    Private _dataSource As List(Of XC2NamedField) = Nothing

    Public Sub Configure(ds As List(Of XC2NamedField), label As String, readFn As Func(Of HexDataInfo, Integer), saveFn As Action(Of HexDataInfo, Integer))
        DataSource = ds
        TypeDropdown.DataSource = Nothing
        TypeDropdown.DisplayMember = NameOf(XC2NamedField.Name)
        TypeDropdown.ValueMember = Nothing
        TypeDropdown.DataSource = DataSource
        FieldTypeLabel = label
        ReadFromFile = readFn
        SaveToFile = saveFn
    End Sub

    Private Sub OnInitialLoad(sender As XC2FieldTypeEditor, e As EventArgs) Handles MyBase.Load
        TypeDropdown.DataBindings.Add(New Binding(NameOf(ComboBox.Enabled), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))
        ValueDropdown.DataBindings.Add(New Binding(NameOf(TextBox.Text), Me, NameOf(CurrentValue), True, DataSourceUpdateMode.OnPropertyChanged))
        ValueDropdown.DataBindings.Add(New Binding(NameOf(TextBox.Enabled), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))
        TypeLabel.DataBindings.Add(New Binding(NameOf(Label.Text), Me, NameOf(FieldTypeLabel), True, DataSourceUpdateMode.OnPropertyChanged))
        ValueLabel.DataBindings.Add(New Binding(NameOf(Label.Text), Me, NameOf(FieldValueLabel), True, DataSourceUpdateMode.OnPropertyChanged))
        UpdateBtn.DataBindings.Add(New Binding(NameOf(Button.Enabled), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Function GetSelectedField() As XC2NamedField
        Return TryCast(TypeDropdown.SelectedItem, XC2NamedField)
    End Function

    Private Sub LoadValueFromFile(cbox As ComboBox, e As EventArgs) Handles TypeDropdown.SelectedIndexChanged
        If CanEdit Then
            Dim selectedField = GetSelectedField()
            If selectedField IsNot Nothing Then
                CurrentValue = ReadFromFile(selectedField.Data).ToString()
            End If
        End If
    End Sub

    Private Sub SaveValueToFile(btn As Button, e As EventArgs) Handles UpdateBtn.Click
        Dim selectedField = GetSelectedField()
        If selectedField Is Nothing Then
            Return
        End If

        Dim parsedVal As Integer
        If Not Integer.TryParse(CurrentValue, parsedVal) Then
            MessageBox.Show("Enter a valid whole number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SaveToFile(selectedField.Data, parsedVal)
        CurrentValue = ReadFromFile(selectedField.Data).ToString()
    End Sub

    Private Sub RaisePropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub
End Class
