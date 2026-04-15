Imports System.ComponentModel
Imports System.IO

Public Class XC2MainForm
    Inherits Form
    Implements INotifyPropertyChanged

    Private Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Const FILE_DIALOG_FILTER = "Save files ( PLAY00 )|PLAY00|All files (*.*)|*.*"

    Private FilePath As String = Nothing
    Private FileBytes As Byte() = Nothing

    Public Property CanEdit As Boolean
        Get
            Return _canEdit
        End Get
        Set(value As Boolean)
            _canEdit = value
            RaisePropertyChanged(New PropertyChangedEventArgs(NameOf(CanEdit)))
        End Set
    End Property
    Private _canEdit As Boolean = False

    Private ReadOnly ReadFromFileBytes As Func(Of HexDataInfo, Integer) =
        Function(hexData)
            Return HexEditor.ReadAsDecimal(FileBytes, hexData)
        End Function

    Private ReadOnly SetFileBytes As Action(Of HexDataInfo, Integer) =
        Sub(hexData, value)
            HexEditor.SaveDecimalValue(FileBytes, hexData, value)
        End Sub

    Private Sub OpenFile(btn As Button, e As EventArgs) Handles OpenFileBtn.Click
        Dim openDialog = New OpenFileDialog With {.Filter = FILE_DIALOG_FILTER}
        Dim dialogResult = openDialog.ShowDialog()

        If dialogResult = DialogResult.OK Then
            Try
                FilePath = openDialog.FileName
                FileBytes = File.ReadAllBytes(FilePath)
                CanEdit = True
            Catch ex As IOException
                MessageBox.Show("Unable to read the selected save file.", "Open File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SaveFile(btn As Button, e As EventArgs) Handles SaveBtn.Click
        If FileBytes Is Nothing OrElse String.IsNullOrWhiteSpace(FilePath) Then
            Return
        End If

        Dim dialogResult = MessageBox.Show("Are you sure you want to overwrite the currently loaded file?", "Save File", MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then
            File.WriteAllBytes(FilePath, FileBytes)
        End If
    End Sub

    Private Sub SaveFileAs(btn As Button, e As EventArgs) Handles SaveAsFileBtn.Click
        If FileBytes Is Nothing Then
            Return
        End If

        Dim saveDialog = New SaveFileDialog With {.Filter = FILE_DIALOG_FILTER}
        Dim dialogResult = saveDialog.ShowDialog()

        If dialogResult = DialogResult.OK Then
            FilePath = saveDialog.FileName
            File.WriteAllBytes(FilePath, FileBytes)
        End If
    End Sub

    Private Sub OnPlayerInfoEditorLoaded(sender As XC2FieldTypeEditor, e As EventArgs) Handles PlayerInfoEditor.Load
        PlayerInfoEditor.Configure(XC2Data.PlayerInfoOffsets, "Player Info", ReadFromFileBytes, SetFileBytes)
        PlayerInfoEditor.DataBindings.Add(New Binding(NameOf(PlayerInfoEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        ConsumablesEditor.Configure(XC2Data.ConsumablesOffsets, "Consumables", ReadFromFileBytes, SetFileBytes)
        ConsumablesEditor.DataBindings.Add(New Binding(NameOf(ConsumablesEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        MaterialsEditor.Configure(XC2Data.MaterialsOffsets, "Materials", ReadFromFileBytes, SetFileBytes)
        MaterialsEditor.DataBindings.Add(New Binding(NameOf(MaterialsEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        AspectsEditor.Configure(XC2Data.AspectsOffsets, "Aspects", ReadFromFileBytes, SetFileBytes)
        AspectsEditor.DataBindings.Add(New Binding(NameOf(AspectsEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        SigilsEditor.Configure(XC2Data.SigilsOffsets, "Sigils", ReadFromFileBytes, SetFileBytes)
        SigilsEditor.DataBindings.Add(New Binding(NameOf(SigilsEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))

        CharacterEditor.Configure(XC2Data.CharacterOffsets, "Characters", ReadFromFileBytes, SetFileBytes)
        CharacterEditor.DataBindings.Add(New Binding(NameOf(CharacterEditor.CanEdit), Me, NameOf(CanEdit), False, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub XC2MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerInfoEditor.BackColor = Color.Transparent
        CharacterEditor.BackColor = Color.Transparent
        ConsumablesEditor.BackColor = Color.Transparent
        AspectsEditor.BackColor = Color.Transparent
        MaterialsEditor.BackColor = Color.Transparent
        SigilsEditor.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Credits.Visible = True
    End Sub

    Private Sub RaisePropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub
End Class
