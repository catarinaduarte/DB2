<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CodArtLabel As System.Windows.Forms.Label
        Dim TituloArtLabel As System.Windows.Forms.Label
        Dim DescriçãoArtLabel As System.Windows.Forms.Label
        Dim TemaArtLabel As System.Windows.Forms.Label
        Dim AutorArtLabel As System.Windows.Forms.Label
        Dim NumRevLabel As System.Windows.Forms.Label
        Dim MesAnoRevLabel As System.Windows.Forms.Label
        Me.RevistaDataSet = New EXBD2.RevistaDataSet()
        Me.ArtigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtigosTableAdapter = New EXBD2.RevistaDataSetTableAdapters.ArtigosTableAdapter()
        Me.TableAdapterManager = New EXBD2.RevistaDataSetTableAdapters.TableAdapterManager()
        Me.ArtigosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ArtigosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodArtTextBox = New System.Windows.Forms.TextBox()
        Me.TituloArtTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoArtTextBox = New System.Windows.Forms.TextBox()
        Me.TemaArtTextBox = New System.Windows.Forms.TextBox()
        Me.AutorArtTextBox = New System.Windows.Forms.TextBox()
        Me.NumRevTextBox = New System.Windows.Forms.TextBox()
        Me.MesAnoRevTextBox = New System.Windows.Forms.TextBox()
        CodArtLabel = New System.Windows.Forms.Label()
        TituloArtLabel = New System.Windows.Forms.Label()
        DescriçãoArtLabel = New System.Windows.Forms.Label()
        TemaArtLabel = New System.Windows.Forms.Label()
        AutorArtLabel = New System.Windows.Forms.Label()
        NumRevLabel = New System.Windows.Forms.Label()
        MesAnoRevLabel = New System.Windows.Forms.Label()
        CType(Me.RevistaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtigosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArtigosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'RevistaDataSet
        '
        Me.RevistaDataSet.DataSetName = "RevistaDataSet"
        Me.RevistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtigosBindingSource
        '
        Me.ArtigosBindingSource.DataMember = "Artigos"
        Me.ArtigosBindingSource.DataSource = Me.RevistaDataSet
        '
        'ArtigosTableAdapter
        '
        Me.ArtigosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArtigosTableAdapter = Me.ArtigosTableAdapter
        Me.TableAdapterManager.AutorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RevistaTableAdapter = Nothing
        Me.TableAdapterManager.TemaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EXBD2.RevistaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtigosBindingNavigator
        '
        Me.ArtigosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ArtigosBindingNavigator.BindingSource = Me.ArtigosBindingSource
        Me.ArtigosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ArtigosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ArtigosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorPositionItem, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ArtigosBindingNavigatorSaveItem})
        Me.ArtigosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ArtigosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ArtigosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ArtigosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ArtigosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ArtigosBindingNavigator.Name = "ArtigosBindingNavigator"
        Me.ArtigosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ArtigosBindingNavigator.Size = New System.Drawing.Size(484, 25)
        Me.ArtigosBindingNavigator.TabIndex = 0
        Me.ArtigosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ArtigosBindingNavigatorSaveItem
        '
        Me.ArtigosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ArtigosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ArtigosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ArtigosBindingNavigatorSaveItem.Name = "ArtigosBindingNavigatorSaveItem"
        Me.ArtigosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ArtigosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodArtLabel
        '
        CodArtLabel.AutoSize = True
        CodArtLabel.Location = New System.Drawing.Point(45, 45)
        CodArtLabel.Name = "CodArtLabel"
        CodArtLabel.Size = New System.Drawing.Size(45, 13)
        CodArtLabel.TabIndex = 1
        CodArtLabel.Text = "Cod Art:"
        '
        'CodArtTextBox
        '
        Me.CodArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "CodArt", True))
        Me.CodArtTextBox.Location = New System.Drawing.Point(96, 42)
        Me.CodArtTextBox.Name = "CodArtTextBox"
        Me.CodArtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodArtTextBox.TabIndex = 2
        '
        'TituloArtLabel
        '
        TituloArtLabel.AutoSize = True
        TituloArtLabel.Location = New System.Drawing.Point(38, 83)
        TituloArtLabel.Name = "TituloArtLabel"
        TituloArtLabel.Size = New System.Drawing.Size(52, 13)
        TituloArtLabel.TabIndex = 3
        TituloArtLabel.Text = "Titulo Art:"
        '
        'TituloArtTextBox
        '
        Me.TituloArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "TituloArt", True))
        Me.TituloArtTextBox.Location = New System.Drawing.Point(96, 80)
        Me.TituloArtTextBox.Name = "TituloArtTextBox"
        Me.TituloArtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TituloArtTextBox.TabIndex = 4
        '
        'DescriçãoArtLabel
        '
        DescriçãoArtLabel.AutoSize = True
        DescriçãoArtLabel.Location = New System.Drawing.Point(16, 124)
        DescriçãoArtLabel.Name = "DescriçãoArtLabel"
        DescriçãoArtLabel.Size = New System.Drawing.Size(74, 13)
        DescriçãoArtLabel.TabIndex = 5
        DescriçãoArtLabel.Text = "Descrição Art:"
        '
        'DescriçãoArtTextBox
        '
        Me.DescriçãoArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "DescriçãoArt", True))
        Me.DescriçãoArtTextBox.Location = New System.Drawing.Point(96, 106)
        Me.DescriçãoArtTextBox.Multiline = True
        Me.DescriçãoArtTextBox.Name = "DescriçãoArtTextBox"
        Me.DescriçãoArtTextBox.Size = New System.Drawing.Size(355, 52)
        Me.DescriçãoArtTextBox.TabIndex = 6
        '
        'TemaArtLabel
        '
        TemaArtLabel.AutoSize = True
        TemaArtLabel.Location = New System.Drawing.Point(37, 167)
        TemaArtLabel.Name = "TemaArtLabel"
        TemaArtLabel.Size = New System.Drawing.Size(53, 13)
        TemaArtLabel.TabIndex = 7
        TemaArtLabel.Text = "Tema Art:"
        '
        'TemaArtTextBox
        '
        Me.TemaArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "TemaArt", True))
        Me.TemaArtTextBox.Location = New System.Drawing.Point(96, 164)
        Me.TemaArtTextBox.Name = "TemaArtTextBox"
        Me.TemaArtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TemaArtTextBox.TabIndex = 8
        '
        'AutorArtLabel
        '
        AutorArtLabel.AutoSize = True
        AutorArtLabel.Location = New System.Drawing.Point(39, 211)
        AutorArtLabel.Name = "AutorArtLabel"
        AutorArtLabel.Size = New System.Drawing.Size(51, 13)
        AutorArtLabel.TabIndex = 9
        AutorArtLabel.Text = "Autor Art:"
        '
        'AutorArtTextBox
        '
        Me.AutorArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "AutorArt", True))
        Me.AutorArtTextBox.Location = New System.Drawing.Point(96, 208)
        Me.AutorArtTextBox.Name = "AutorArtTextBox"
        Me.AutorArtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AutorArtTextBox.TabIndex = 10
        '
        'NumRevLabel
        '
        NumRevLabel.AutoSize = True
        NumRevLabel.Location = New System.Drawing.Point(35, 253)
        NumRevLabel.Name = "NumRevLabel"
        NumRevLabel.Size = New System.Drawing.Size(55, 13)
        NumRevLabel.TabIndex = 11
        NumRevLabel.Text = "Num Rev:"
        '
        'NumRevTextBox
        '
        Me.NumRevTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "NumRev", True))
        Me.NumRevTextBox.Location = New System.Drawing.Point(96, 250)
        Me.NumRevTextBox.Name = "NumRevTextBox"
        Me.NumRevTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumRevTextBox.TabIndex = 12
        '
        'MesAnoRevLabel
        '
        MesAnoRevLabel.AutoSize = True
        MesAnoRevLabel.Location = New System.Drawing.Point(15, 298)
        MesAnoRevLabel.Name = "MesAnoRevLabel"
        MesAnoRevLabel.Size = New System.Drawing.Size(75, 13)
        MesAnoRevLabel.TabIndex = 13
        MesAnoRevLabel.Text = "Mes Ano Rev:"
        '
        'MesAnoRevTextBox
        '
        Me.MesAnoRevTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtigosBindingSource, "MesAnoRev", True))
        Me.MesAnoRevTextBox.Location = New System.Drawing.Point(96, 295)
        Me.MesAnoRevTextBox.Name = "MesAnoRevTextBox"
        Me.MesAnoRevTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MesAnoRevTextBox.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(MesAnoRevLabel)
        Me.Controls.Add(Me.MesAnoRevTextBox)
        Me.Controls.Add(NumRevLabel)
        Me.Controls.Add(Me.NumRevTextBox)
        Me.Controls.Add(AutorArtLabel)
        Me.Controls.Add(Me.AutorArtTextBox)
        Me.Controls.Add(TemaArtLabel)
        Me.Controls.Add(Me.TemaArtTextBox)
        Me.Controls.Add(DescriçãoArtLabel)
        Me.Controls.Add(Me.DescriçãoArtTextBox)
        Me.Controls.Add(TituloArtLabel)
        Me.Controls.Add(Me.TituloArtTextBox)
        Me.Controls.Add(CodArtLabel)
        Me.Controls.Add(Me.CodArtTextBox)
        Me.Controls.Add(Me.ArtigosBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RevistaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtigosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArtigosBindingNavigator.ResumeLayout(False)
        Me.ArtigosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RevistaDataSet As RevistaDataSet
    Friend WithEvents ArtigosBindingSource As BindingSource
    Friend WithEvents ArtigosTableAdapter As RevistaDataSetTableAdapters.ArtigosTableAdapter
    Friend WithEvents TableAdapterManager As RevistaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArtigosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ArtigosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodArtTextBox As TextBox
    Friend WithEvents TituloArtTextBox As TextBox
    Friend WithEvents DescriçãoArtTextBox As TextBox
    Friend WithEvents TemaArtTextBox As TextBox
    Friend WithEvents AutorArtTextBox As TextBox
    Friend WithEvents NumRevTextBox As TextBox
    Friend WithEvents MesAnoRevTextBox As TextBox
End Class
