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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TablaPagos = New System.Windows.Forms.DataGridView()
        Me.PRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDPAGOS = New EnriqueSaenz___Prueba.BDPAGOS()
        Me.CLIENTEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOCAJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTETableAdapter = New EnriqueSaenz___Prueba.BDPAGOSTableAdapters.CLIENTETableAdapter()
        Me.BDPAGOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIO_CAJATableAdapter = New EnriqueSaenz___Prueba.BDPAGOSTableAdapters.USUARIO_CAJATableAdapter()
        Me.PAGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAGOTableAdapter = New EnriqueSaenz___Prueba.BDPAGOSTableAdapters.PAGOTableAdapter()
        Me.PRODUCTOBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOTableAdapter = New EnriqueSaenz___Prueba.BDPAGOSTableAdapters.PRODUCTOTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chbxEstado = New System.Windows.Forms.CheckBox()
        Me.cboxUsuario = New System.Windows.Forms.ComboBox()
        Me.cboxCliente = New System.Windows.Forms.ComboBox()
        Me.cboxProducto = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TablaReportes = New System.Windows.Forms.DataGridView()
        Me.cboxOpcion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PAGOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDPAGOSDataSet1 = New EnriqueSaenz___Prueba.BDPAGOSDataSet1()
        Me.PRODUCTOBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOTableAdapter1 = New EnriqueSaenz___Prueba.BDPAGOSDataSet1TableAdapters.PRODUCTOTableAdapter()
        Me.PRODUCTOBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TablaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDPAGOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USUARIOCAJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDPAGOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TablaReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAGOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDPAGOSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaPagos
        '
        Me.TablaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaPagos.DefaultCellStyle = DataGridViewCellStyle3
        Me.TablaPagos.Location = New System.Drawing.Point(312, 7)
        Me.TablaPagos.MultiSelect = False
        Me.TablaPagos.Name = "TablaPagos"
        Me.TablaPagos.ReadOnly = True
        Me.TablaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaPagos.Size = New System.Drawing.Size(853, 480)
        Me.TablaPagos.TabIndex = 0
        '
        'PRODUCTOBindingSource
        '
        Me.PRODUCTOBindingSource.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource.DataSource = Me.BDPAGOS
        '
        'BDPAGOS
        '
        Me.BDPAGOS.DataSetName = "BDPAGOS"
        Me.BDPAGOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'USUARIOCAJABindingSource
        '
        Me.USUARIOCAJABindingSource.DataMember = "USUARIO_CAJA"
        Me.USUARIOCAJABindingSource.DataSource = Me.BDPAGOS
        '
        'PRODUCTOBindingSource1
        '
        Me.PRODUCTOBindingSource1.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource1.DataSource = Me.BDPAGOS
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
        'PAGOBindingSource
        '
        Me.PAGOBindingSource.DataMember = "PAGO"
        Me.PAGOBindingSource.DataSource = Me.BDPAGOSBindingSource
        '
        'PAGOTableAdapter
        '
        Me.PAGOTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTOBindingSource2
        '
        Me.PRODUCTOBindingSource2.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource2.DataSource = Me.BDPAGOSBindingSource
        '
        'PRODUCTOTableAdapter
        '
        Me.PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboxProducto)
        Me.GroupBox1.Controls.Add(Me.cboxCliente)
        Me.GroupBox1.Controls.Add(Me.cboxUsuario)
        Me.GroupBox1.Controls.Add(Me.chbxEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 480)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crud Pagos - Datos"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(116, 252)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(162, 42)
        Me.txtObservacion.TabIndex = 0
        Me.txtObservacion.Text = ""
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
        'cboxProducto
        '
        Me.cboxProducto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUCTOBindingSource5, "CODE_PRODUCT", True))
        Me.cboxProducto.DataSource = Me.PRODUCTOBindingSource4
        Me.cboxProducto.DisplayMember = "DESCRIPTION"
        Me.cboxProducto.FormattingEnabled = True
        Me.cboxProducto.Location = New System.Drawing.Point(116, 78)
        Me.cboxProducto.Name = "cboxProducto"
        Me.cboxProducto.Size = New System.Drawing.Size(121, 21)
        Me.cboxProducto.TabIndex = 5
        Me.cboxProducto.ValueMember = "CODE_PRODUCT"
        '
        'Button1
        '
        Me.Button1.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.agregar_30
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(28, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "INGRESAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.editar_30
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(152, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 42)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "MODIFICAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.lupa_30
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(30, 423)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 42)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "LISTAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.EnriqueSaenz___Prueba.My.Resources.Resources.eliminar_30
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(152, 423)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 42)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
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
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(116, 193)
        Me.txtTotal.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDENTIFICADOR"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(126, 40)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(101, 20)
        Me.txtId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRODUCTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CLIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "USUARIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FECHA"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(116, 226)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(128, 20)
        Me.txtFecha.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "OBSERVACION"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.txtDato)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboxOpcion)
        Me.GroupBox2.Controls.Add(Me.TablaReportes)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 493)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1158, 298)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "REPORTES"
        '
        'TablaReportes
        '
        Me.TablaReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaReportes.Location = New System.Drawing.Point(225, 19)
        Me.TablaReportes.Name = "TablaReportes"
        Me.TablaReportes.Size = New System.Drawing.Size(927, 269)
        Me.TablaReportes.TabIndex = 0
        '
        'cboxOpcion
        '
        Me.cboxOpcion.FormattingEnabled = True
        Me.cboxOpcion.Items.AddRange(New Object() {"Reporte 1 - ingrese codigo de producto", "Resporte 2 - ingrese dni de cliente", "Reporte 3 - ingrese usuario de vendedor"})
        Me.cboxOpcion.Location = New System.Drawing.Point(60, 61)
        Me.cboxOpcion.Name = "cboxOpcion"
        Me.cboxOpcion.Size = New System.Drawing.Size(121, 21)
        Me.cboxOpcion.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Seleccione una opcion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Ingrese dato a buscar"
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(60, 122)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(121, 20)
        Me.txtDato.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 194)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(184, 45)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "CONSULTAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PAGOBindingSource1
        '
        Me.PAGOBindingSource1.DataMember = "PAGO"
        Me.PAGOBindingSource1.DataSource = Me.BDPAGOS
        '
        'PRODUCTOBindingSource3
        '
        Me.PRODUCTOBindingSource3.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource3.DataSource = Me.BDPAGOS
        '
        'BDPAGOSDataSet1
        '
        Me.BDPAGOSDataSet1.DataSetName = "BDPAGOSDataSet1"
        Me.BDPAGOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOBindingSource4
        '
        Me.PRODUCTOBindingSource4.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource4.DataSource = Me.BDPAGOSDataSet1
        '
        'PRODUCTOTableAdapter1
        '
        Me.PRODUCTOTableAdapter1.ClearBeforeFill = True
        '
        'PRODUCTOBindingSource5
        '
        Me.PRODUCTOBindingSource5.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource5.DataSource = Me.BDPAGOSDataSet1
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 793)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TablaPagos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Principal"
        Me.Text = "CRUD"
        CType(Me.TablaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDPAGOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USUARIOCAJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDPAGOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TablaReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAGOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDPAGOSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaPagos As DataGridView
    Friend WithEvents BDPAGOS As BDPAGOS
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As BDPAGOSTableAdapters.CLIENTETableAdapter
    Friend WithEvents BDPAGOSBindingSource As BindingSource
    Friend WithEvents USUARIOCAJABindingSource As BindingSource
    Friend WithEvents USUARIO_CAJATableAdapter As BDPAGOSTableAdapters.USUARIO_CAJATableAdapter
    Friend WithEvents PRODUCTOBindingSource1 As BindingSource
    Friend WithEvents CLIENTEBindingSource1 As BindingSource
    Friend WithEvents PAGOBindingSource As BindingSource
    Friend WithEvents PAGOTableAdapter As BDPAGOSTableAdapters.PAGOTableAdapter
    Friend WithEvents PRODUCTOBindingSource2 As BindingSource
    Friend WithEvents PRODUCTOBindingSource As BindingSource
    Friend WithEvents PRODUCTOTableAdapter As BDPAGOSTableAdapters.PRODUCTOTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As NumericUpDown
    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxProducto As ComboBox
    Friend WithEvents cboxCliente As ComboBox
    Friend WithEvents cboxUsuario As ComboBox
    Friend WithEvents chbxEstado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservacion As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtDato As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboxOpcion As ComboBox
    Friend WithEvents TablaReportes As DataGridView
    Friend WithEvents PRODUCTOBindingSource3 As BindingSource
    Friend WithEvents PAGOBindingSource1 As BindingSource
    Friend WithEvents BDPAGOSDataSet1 As BDPAGOSDataSet1
    Friend WithEvents PRODUCTOBindingSource4 As BindingSource
    Friend WithEvents PRODUCTOTableAdapter1 As BDPAGOSDataSet1TableAdapters.PRODUCTOTableAdapter
    Friend WithEvents PRODUCTOBindingSource5 As BindingSource
End Class
