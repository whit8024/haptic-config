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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tarAddrBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tarAddrbox2 = New System.Windows.Forms.TextBox()
        Me.tarAddrBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tarAddrBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.applyConfigBtn = New System.Windows.Forms.Button()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.devGrp = New System.Windows.Forms.GroupBox()
        Me.slaveRad = New System.Windows.Forms.RadioButton()
        Me.masterRad = New System.Windows.Forms.RadioButton()
        Me.sensorBox = New System.Windows.Forms.CheckBox()
        Me.devGrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Target Address: "
        '
        'tarAddrBox1
        '
        Me.tarAddrBox1.Location = New System.Drawing.Point(124, 84)
        Me.tarAddrBox1.Name = "tarAddrBox1"
        Me.tarAddrBox1.Size = New System.Drawing.Size(28, 20)
        Me.tarAddrBox1.TabIndex = 1
        Me.tarAddrBox1.Text = "192"
        Me.tarAddrBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "."
        '
        'tarAddrbox2
        '
        Me.tarAddrbox2.Location = New System.Drawing.Point(162, 84)
        Me.tarAddrbox2.Name = "tarAddrbox2"
        Me.tarAddrbox2.Size = New System.Drawing.Size(28, 20)
        Me.tarAddrbox2.TabIndex = 3
        Me.tarAddrbox2.Text = "168"
        Me.tarAddrbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tarAddrBox3
        '
        Me.tarAddrBox3.Location = New System.Drawing.Point(200, 84)
        Me.tarAddrBox3.Name = "tarAddrBox3"
        Me.tarAddrBox3.Size = New System.Drawing.Size(28, 20)
        Me.tarAddrBox3.TabIndex = 5
        Me.tarAddrBox3.Text = "1"
        Me.tarAddrBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(190, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "."
        '
        'tarAddrBox4
        '
        Me.tarAddrBox4.Location = New System.Drawing.Point(238, 84)
        Me.tarAddrBox4.Name = "tarAddrBox4"
        Me.tarAddrBox4.Size = New System.Drawing.Size(28, 20)
        Me.tarAddrBox4.TabIndex = 7
        Me.tarAddrBox4.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(228, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "."
        '
        'applyConfigBtn
        '
        Me.applyConfigBtn.Location = New System.Drawing.Point(153, 186)
        Me.applyConfigBtn.Name = "applyConfigBtn"
        Me.applyConfigBtn.Size = New System.Drawing.Size(75, 23)
        Me.applyConfigBtn.TabIndex = 10
        Me.applyConfigBtn.Text = "Apply"
        Me.applyConfigBtn.UseVisualStyleBackColor = True
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(72, 186)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(75, 23)
        Me.okBtn.TabIndex = 11
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'devGrp
        '
        Me.devGrp.Controls.Add(Me.slaveRad)
        Me.devGrp.Controls.Add(Me.masterRad)
        Me.devGrp.Location = New System.Drawing.Point(36, 12)
        Me.devGrp.Name = "devGrp"
        Me.devGrp.Size = New System.Drawing.Size(230, 56)
        Me.devGrp.TabIndex = 14
        Me.devGrp.TabStop = False
        Me.devGrp.Text = "Device Type: "
        '
        'slaveRad
        '
        Me.slaveRad.AutoSize = True
        Me.slaveRad.Location = New System.Drawing.Point(157, 33)
        Me.slaveRad.Name = "slaveRad"
        Me.slaveRad.Size = New System.Drawing.Size(52, 17)
        Me.slaveRad.TabIndex = 1
        Me.slaveRad.Text = "Slave"
        Me.slaveRad.UseVisualStyleBackColor = True
        '
        'masterRad
        '
        Me.masterRad.AutoSize = True
        Me.masterRad.Checked = True
        Me.masterRad.Location = New System.Drawing.Point(157, 10)
        Me.masterRad.Name = "masterRad"
        Me.masterRad.Size = New System.Drawing.Size(57, 17)
        Me.masterRad.TabIndex = 0
        Me.masterRad.TabStop = True
        Me.masterRad.Text = "Master"
        Me.masterRad.UseVisualStyleBackColor = True
        '
        'sensorBox
        '
        Me.sensorBox.AutoSize = True
        Me.sensorBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sensorBox.Location = New System.Drawing.Point(30, 132)
        Me.sensorBox.Name = "sensorBox"
        Me.sensorBox.Size = New System.Drawing.Size(122, 17)
        Me.sensorBox.TabIndex = 16
        Me.sensorBox.Text = "Use Force Sensors: "
        Me.sensorBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleName = "sensorBox"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(310, 235)
        Me.Controls.Add(Me.sensorBox)
        Me.Controls.Add(Me.devGrp)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.applyConfigBtn)
        Me.Controls.Add(Me.tarAddrBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tarAddrBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tarAddrbox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tarAddrBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Haptic Configuration"
        Me.devGrp.ResumeLayout(False)
        Me.devGrp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tarAddrBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tarAddrbox2 As System.Windows.Forms.TextBox
    Friend WithEvents tarAddrBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tarAddrBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents applyConfigBtn As System.Windows.Forms.Button
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents devGrp As System.Windows.Forms.GroupBox
    Friend WithEvents slaveRad As System.Windows.Forms.RadioButton
    Friend WithEvents masterRad As System.Windows.Forms.RadioButton
    Friend WithEvents sensorBox As System.Windows.Forms.CheckBox

End Class
