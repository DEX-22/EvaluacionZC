<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TablaPagos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboxProducto = New System.Windows.Forms.ComboBox()
        Me.PRODUCTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDPAGOS = New EnriqueSaenz___Prueba.BDPAGOS()
        Me.PRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboxCliente = New System.Windows.Forms.ComboBox()
        Me.CLIENTEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboxUsuario = New System.Windows.Forms.ComboBox()
        Me.USUARIOCAJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chbxEstado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.PRODUCTOTableAdapter = New EnriqueSaenz___Prueba.BDPAGOSTableAdapters.PRODUCTOTableAdapter()
        Me.CLIENTETableAdapter = New EnriqueSaenz___Prueba.BDPAGOSTableAdapters.CLIENTETableAdapter()
        Me.BDPAGOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIO_CAJATableAdapter = New EnriqueSaenz___Prueba.BDPAGOSTableAdapters.USUARIO_CAJATableAdapter()
        CType(Me.TablaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDPAGOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOCAJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDPAGOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaPagos
        '
        Me.TablaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaPagos.Location = New System.Drawing.Point(312, 7)
        Me.TablaPagos.MultiSelect = False
        Me.TablaPagos.Name = "TablaPagos"
        Me.TablaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaPagos.Size = New System.Drawing.Size(1161, 598)
        Me.TablaPagos.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 597)
        Me.Panel1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "OBSERVACION"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(115, 220)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(128, 20)
        Me.txtFecha.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FECHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRODUCTO"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(125, 34)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(101, 20)
        Me.txtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDENTIFICADOR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cboxProducto)
        Me.GroupBox1.Controls.Add(Me.cboxCliente)
        Me.GroupBox1.Controls.Add(Me.cboxUsuario)
        Me.GroupBox1.Controls.Add(Me.chbxEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 598)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crud Pagos - Datos"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(116, 193)
        Me.txtTotal.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "PRECIO"
        '
        'Button4
        '
        Me.Button4.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.eliminar_30
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(150, 451)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 42)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.lupa_30
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(28, 451)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 42)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "LISTAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.editar_30
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(150, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 42)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "MODIFICAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.agregar_30
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(26, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "INGRESAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboxProducto
        '
        Me.cboxProducto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUCTOBindingSource1, "CODE_PRODUCT", True))
        Me.cboxProducto.DataSource = Me.PRODUCTOBindingSource
        Me.cboxProducto.DisplayMember = "DESRIPTION"
        Me.cboxProducto.FormattingEnabled = True
        Me.cboxProducto.Location = New System.Drawing.Point(116, 78)
        Me.cboxProducto.Name = "cboxProducto"
        Me.cboxProducto.Size = New System.Drawing.Size(121, 21)
        Me.cboxProducto.TabIndex = 5
        Me.cboxProducto.ValueMember = "CODE_PRODUCT"
        '
        'PRODUCTOBindingSource1
        '
        Me.PRODUCTOBindingSource1.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource1.DataSource = Me.BDPAGOS
        '
        'BDPAGOS
        '
        Me.BDPAGOS.DataSetName = "BDPAGOS"
        Me.BDPAGOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOBindingSource
        '
        Me.PRODUCTOBindingSource.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource.DataSource = Me.BDPAGOS
        '
        'cboxCliente
        '
        Me.cboxCliente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CLIENTEBindingSource1, "CODE_CLIENT", True))
        Me.cboxCliente.DataSource = Me.CLIENTEBindingSource
        Me.cboxCliente.DisplayMember = "NAME"
        Me.cboxCliente.FormattingEnabled = True
        Me.cboxCliente.Location = New System.Drawing.Point(116, 122)
        Me.cboxCliente.Name = "cboxCliente"
        Me.cboxCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboxCliente.TabIndex = 4
        Me.cboxCliente.ValueMember = "CODE_CLIENT"
        '
        'CLIENTEBindingSource1
        '
        Me.CLIENTEBindingSource1.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource1.DataSource = Me.BDPAGOS
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.BDPAGOS
        '
        'cboxUsuario
        '
        Me.cboxUsuario.DataSource = Me.USUARIOCAJABindingSource
        Me.cboxUsuario.DisplayMember = "USERNAME"
        Me.cboxUsuario.FormattingEnabled = True
        Me.cboxUsuario.Location = New System.Drawing.Point(116, 163)
        Me.cboxUsuario.Name = "cboxUsuario"
        Me.cboxUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cboxUsuario.TabIndex = 3
        Me.cboxUsuario.ValueMember = "CODE_USER"
        '
        'USUARIOCAJABindingSource
        '
        Me.USUARIOCAJABindingSource.DataMember = "USUARIO_CAJA"
        Me.USUARIOCAJABindingSource.DataSource = Me.BDPAGOS
        '
        'chbxEstado
        '
        Me.chbxEstado.AutoSize = True
        Me.chbxEstado.Location = New System.Drawing.Point(116, 323)
        Me.chbxEstado.Name = "chbxEstado"
        Me.chbxEstado.Size = New System.Drawing.Size(65, 17)
        Me.chbxEstado.TabIndex = 2
        Me.chbxEstado.Text = "ACTIVO"
        Me.chbxEstado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ESTADO"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(116, 252)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(162, 42)
        Me.txtObservacion.TabIndex = 0
        Me.txtObservacion.Text = ""
        '
        'PRODUCTOTableAdapter
        '
        Me.PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'BDPAGOSBindingSource
        '
        Me.BDPAGOSBindingSource.DataSource = Me.BDPAGOS
        Me.BDPAGOSBindingSource.Position = 0
        '
        'USUARIO_CAJATableAdapter
        '
        Me.USUARIO_CAJATableAdapter.ClearBeforeFill = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TablaPagos)
        Me.Name = "Principal"
        Me.Text = "CRUD"
        CType(Me.TablaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDPAGOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOCAJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDPAGOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaPagos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboxUsuario As ComboBox
    Friend WithEvents chbxEstado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservacion As RichTextBox
    Friend WithEvents cboxProducto As ComboBox
    Friend WithEvents cboxCliente As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BDPAGOS As BDPAGOS
    Friend WithEvents PRODUCTOBindingSource As BindingSource
    Friend WithEvents PRODUCTOTableAdapter As BDPAGOSTableAdapters.PRODUCTOTableAdapter
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As BDPAGOSTableAdapters.CLIENTETableAdapter
    Friend WithEvents BDPAGOSBindingSource As BindingSource
    Friend WithEvents USUARIOCAJABindingSource As BindingSource
    Friend WithEvents USUARIO_CAJATableAdapter As BDPAGOSTableAdapters.USUARIO_CAJATableAdapter
    Friend WithEvents txtTotal As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents PRODUCTOBindingSource1 As BindingSource
    Friend WithEvents CLIENTEBindingSource1 As BindingSource
End Class
