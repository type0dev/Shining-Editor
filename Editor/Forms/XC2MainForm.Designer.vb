<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XC2MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SaveAsFileBtn = New System.Windows.Forms.Button()
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CharacterEditor = New ShiningEditor.XC2FieldTypeEditor()
        Me.SigilsEditor = New ShiningEditor.XC2FieldTypeEditor()
        Me.AspectsEditor = New ShiningEditor.XC2FieldTypeEditor()
        Me.MaterialsEditor = New ShiningEditor.XC2FieldTypeEditor()
        Me.ConsumablesEditor = New ShiningEditor.XC2FieldTypeEditor()
        Me.PlayerInfoEditor = New ShiningEditor.XC2FieldTypeEditor()
        Me.SuspendLayout()
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(521, 365)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'SaveAsFileBtn
        '
        Me.SaveAsFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsFileBtn.Location = New System.Drawing.Point(603, 365)
        Me.SaveAsFileBtn.Name = "SaveAsFileBtn"
        Me.SaveAsFileBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveAsFileBtn.TabIndex = 14
        Me.SaveAsFileBtn.Text = "Save As..."
        Me.SaveAsFileBtn.UseVisualStyleBackColor = True
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFileBtn.Location = New System.Drawing.Point(438, 365)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(77, 30)
        Me.OpenFileBtn.TabIndex = 13
        Me.OpenFileBtn.Text = "Open"
        Me.OpenFileBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(752, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Credits"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CharacterEditor
        '
        Me.CharacterEditor.CanEdit = False
        Me.CharacterEditor.CurrentValue = Nothing
        Me.CharacterEditor.DataSource = Nothing
        Me.CharacterEditor.FieldTypeLabel = Nothing
        Me.CharacterEditor.FieldValueLabel = "Value"
        Me.CharacterEditor.Location = New System.Drawing.Point(436, 12)
        Me.CharacterEditor.Name = "CharacterEditor"
        Me.CharacterEditor.Size = New System.Drawing.Size(405, 93)
        Me.CharacterEditor.TabIndex = 22
        '
        'SigilsEditor
        '
        Me.SigilsEditor.CanEdit = False
        Me.SigilsEditor.CurrentValue = Nothing
        Me.SigilsEditor.DataSource = Nothing
        Me.SigilsEditor.FieldTypeLabel = Nothing
        Me.SigilsEditor.FieldValueLabel = "Value"
        Me.SigilsEditor.Location = New System.Drawing.Point(436, 226)
        Me.SigilsEditor.Name = "SigilsEditor"
        Me.SigilsEditor.Size = New System.Drawing.Size(405, 93)
        Me.SigilsEditor.TabIndex = 21
        '
        'AspectsEditor
        '
        Me.AspectsEditor.CanEdit = False
        Me.AspectsEditor.CurrentValue = Nothing
        Me.AspectsEditor.DataSource = Nothing
        Me.AspectsEditor.FieldTypeLabel = Nothing
        Me.AspectsEditor.FieldValueLabel = "Value"
        Me.AspectsEditor.Location = New System.Drawing.Point(436, 111)
        Me.AspectsEditor.Name = "AspectsEditor"
        Me.AspectsEditor.Size = New System.Drawing.Size(405, 93)
        Me.AspectsEditor.TabIndex = 20
        '
        'MaterialsEditor
        '
        Me.MaterialsEditor.CanEdit = False
        Me.MaterialsEditor.CurrentValue = Nothing
        Me.MaterialsEditor.DataSource = Nothing
        Me.MaterialsEditor.FieldTypeLabel = Nothing
        Me.MaterialsEditor.FieldValueLabel = "Value"
        Me.MaterialsEditor.Location = New System.Drawing.Point(13, 226)
        Me.MaterialsEditor.Name = "MaterialsEditor"
        Me.MaterialsEditor.Size = New System.Drawing.Size(405, 93)
        Me.MaterialsEditor.TabIndex = 19
        '
        'ConsumablesEditor
        '
        Me.ConsumablesEditor.CanEdit = False
        Me.ConsumablesEditor.CurrentValue = Nothing
        Me.ConsumablesEditor.DataSource = Nothing
        Me.ConsumablesEditor.FieldTypeLabel = Nothing
        Me.ConsumablesEditor.FieldValueLabel = "Value"
        Me.ConsumablesEditor.Location = New System.Drawing.Point(12, 111)
        Me.ConsumablesEditor.Name = "ConsumablesEditor"
        Me.ConsumablesEditor.Size = New System.Drawing.Size(405, 93)
        Me.ConsumablesEditor.TabIndex = 18
        '
        'PlayerInfoEditor
        '
        Me.PlayerInfoEditor.CanEdit = False
        Me.PlayerInfoEditor.CurrentValue = Nothing
        Me.PlayerInfoEditor.DataSource = Nothing
        Me.PlayerInfoEditor.FieldTypeLabel = Nothing
        Me.PlayerInfoEditor.FieldValueLabel = "Value"
        Me.PlayerInfoEditor.Location = New System.Drawing.Point(12, 12)
        Me.PlayerInfoEditor.Name = "PlayerInfoEditor"
        Me.PlayerInfoEditor.Size = New System.Drawing.Size(402, 93)
        Me.PlayerInfoEditor.TabIndex = 16
        '
        'XC2MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShiningEditor.My.Resources.Resources.shinning3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 402)
        Me.Controls.Add(Me.CharacterEditor)
        Me.Controls.Add(Me.SigilsEditor)
        Me.Controls.Add(Me.AspectsEditor)
        Me.Controls.Add(Me.MaterialsEditor)
        Me.Controls.Add(Me.ConsumablesEditor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PlayerInfoEditor)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.SaveAsFileBtn)
        Me.Controls.Add(Me.OpenFileBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "XC2MainForm"
        Me.Text = "Shining Resonance:  Save Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayerInfoEditor As XC2FieldTypeEditor
    Friend WithEvents SaveBtn As Button
    Friend WithEvents SaveAsFileBtn As Button
    Friend WithEvents OpenFileBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ConsumablesEditor As XC2FieldTypeEditor
    Friend WithEvents MaterialsEditor As XC2FieldTypeEditor
    Friend WithEvents AspectsEditor As XC2FieldTypeEditor
    Friend WithEvents SigilsEditor As XC2FieldTypeEditor
    Friend WithEvents CharacterEditor As XC2FieldTypeEditor
End Class
