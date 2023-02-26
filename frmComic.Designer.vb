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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        Me.radAutograph = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.grpType = New System.Windows.Forms.GroupBox()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.Image = CType(resources.GetObject("picComic.Image"), System.Drawing.Image)
        Me.picComic.Location = New System.Drawing.Point(0, 0)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(797, 208)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.White
        Me.lblHeading.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(39, 211)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(717, 77)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Comic Convention Registration"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroupSize
        '
        Me.lblGroupSize.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Red
        Me.lblGroupSize.Location = New System.Drawing.Point(226, 296)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(168, 50)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        Me.lblGroupSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGroup
        '
        Me.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGroup.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup.ForeColor = System.Drawing.Color.Red
        Me.txtGroup.Location = New System.Drawing.Point(483, 305)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(55, 34)
        Me.txtGroup.TabIndex = 3
        '
        'lblCost
        '
        Me.lblCost.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Red
        Me.lblCost.Location = New System.Drawing.Point(137, 538)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(319, 51)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Registration Cost:"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Cooper Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Red
        Me.lblPrice.Location = New System.Drawing.Point(424, 538)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(236, 51)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Location = New System.Drawing.Point(177, 611)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(188, 51)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(429, 611)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(188, 51)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'radSuperhero
        '
        Me.radSuperhero.AutoSize = True
        Me.radSuperhero.Location = New System.Drawing.Point(55, 29)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(420, 26)
        Me.radSuperhero.TabIndex = 9
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention + Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'radAutograph
        '
        Me.radAutograph.AutoSize = True
        Me.radAutograph.Location = New System.Drawing.Point(55, 67)
        Me.radAutograph.Name = "radAutograph"
        Me.radAutograph.Size = New System.Drawing.Size(306, 26)
        Me.radAutograph.TabIndex = 10
        Me.radAutograph.TabStop = True
        Me.radAutograph.Text = "Convention + Autographs"
        Me.radAutograph.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(55, 105)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(155, 26)
        Me.radConvention.TabIndex = 11
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grpType.Controls.Add(Me.radConvention)
        Me.grpType.Controls.Add(Me.radSuperhero)
        Me.grpType.Controls.Add(Me.radAutograph)
        Me.grpType.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpType.ForeColor = System.Drawing.Color.Red
        Me.grpType.Location = New System.Drawing.Point(121, 384)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(553, 141)
        Me.grpType.TabIndex = 12
        Me.grpType.TabStop = False
        Me.grpType.Text = "Select Badge Type"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(795, 686)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picComic)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comic Convention Registration"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents radSuperhero As RadioButton
    Friend WithEvents radAutograph As RadioButton
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents grpType As GroupBox
End Class
