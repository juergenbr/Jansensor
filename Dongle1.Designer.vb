<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.comPortLabel = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.chartDisplay = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.sendCommandLabel = New System.Windows.Forms.Label()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.checkXdata = New System.Windows.Forms.CheckBox()
        Me.checkYdata = New System.Windows.Forms.CheckBox()
        Me.checkZdata = New System.Windows.Forms.CheckBox()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.windowSizeLabel = New System.Windows.Forms.Label()
        Me.countsCheckBox = New System.Windows.Forms.CheckBox()
        Me.checkMagData = New System.Windows.Forms.CheckBox()
        Me.chartWindowSizeControl = New System.Windows.Forms.TrackBar()
        Me.responseTextLabel = New System.Windows.Forms.Label()
        Me.grpBox1 = New System.Windows.Forms.GroupBox()
        Me.recordBtn = New System.Windows.Forms.Button()
        Me.fileButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.chartDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chartWindowSizeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'cmbPort
        '
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(68, 322)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(138, 21)
        Me.cmbPort.TabIndex = 1
        '
        'comPortLabel
        '
        Me.comPortLabel.AutoSize = True
        Me.comPortLabel.Location = New System.Drawing.Point(12, 325)
        Me.comPortLabel.Name = "comPortLabel"
        Me.comPortLabel.Size = New System.Drawing.Size(50, 13)
        Me.comPortLabel.TabIndex = 14
        Me.comPortLabel.Text = "Com Port"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(227, 320)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(83, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'chartDisplay
        '
        Me.chartDisplay.Dock = System.Windows.Forms.DockStyle.Top
        Me.chartDisplay.Location = New System.Drawing.Point(0, 0)
        Me.chartDisplay.MaximumSize = New System.Drawing.Size(1920, 1024)
        Me.chartDisplay.MinimumSize = New System.Drawing.Size(660, 310)
        Me.chartDisplay.Name = "chartDisplay"
        Me.chartDisplay.Size = New System.Drawing.Size(721, 310)
        Me.chartDisplay.TabIndex = 10
        Me.chartDisplay.TabStop = False
        Me.chartDisplay.Text = "Acceleration"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Acceleration"
        Title1.Text = "Acceleration"
        Me.chartDisplay.Titles.Add(Title1)
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(9, 39)
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(192, 20)
        Me.txtTransmit.TabIndex = 3
        '
        'sendCommandLabel
        '
        Me.sendCommandLabel.AutoSize = True
        Me.sendCommandLabel.Location = New System.Drawing.Point(6, 23)
        Me.sendCommandLabel.Name = "sendCommandLabel"
        Me.sendCommandLabel.Size = New System.Drawing.Size(82, 13)
        Me.sendCommandLabel.TabIndex = 11
        Me.sendCommandLabel.Text = "Send Command"
        '
        'txtReceive
        '
        Me.txtReceive.BackColor = System.Drawing.SystemColors.Window
        Me.txtReceive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceive.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtReceive.Location = New System.Drawing.Point(9, 92)
        Me.txtReceive.Multiline = True
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.ReadOnly = True
        Me.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceive.Size = New System.Drawing.Size(295, 94)
        Me.txtReceive.TabIndex = 13
        Me.txtReceive.TabStop = False
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(221, 39)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(83, 23)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'checkXdata
        '
        Me.checkXdata.AutoSize = True
        Me.checkXdata.Checked = True
        Me.checkXdata.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkXdata.Location = New System.Drawing.Point(15, 19)
        Me.checkXdata.Name = "checkXdata"
        Me.checkXdata.Size = New System.Drawing.Size(57, 17)
        Me.checkXdata.TabIndex = 5
        Me.checkXdata.Text = "x Data"
        Me.checkXdata.UseVisualStyleBackColor = True
        '
        'checkYdata
        '
        Me.checkYdata.AutoSize = True
        Me.checkYdata.Checked = True
        Me.checkYdata.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkYdata.Location = New System.Drawing.Point(15, 42)
        Me.checkYdata.Name = "checkYdata"
        Me.checkYdata.Size = New System.Drawing.Size(57, 17)
        Me.checkYdata.TabIndex = 6
        Me.checkYdata.Text = "y Data"
        Me.checkYdata.UseVisualStyleBackColor = True
        '
        'checkZdata
        '
        Me.checkZdata.AutoSize = True
        Me.checkZdata.Checked = True
        Me.checkZdata.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkZdata.Location = New System.Drawing.Point(15, 65)
        Me.checkZdata.Name = "checkZdata"
        Me.checkZdata.Size = New System.Drawing.Size(57, 17)
        Me.checkZdata.TabIndex = 7
        Me.checkZdata.Text = "z Data"
        Me.checkZdata.UseVisualStyleBackColor = True
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.GroupBox1)
        Me.groupBox.Controls.Add(Me.countsCheckBox)
        Me.groupBox.Controls.Add(Me.checkMagData)
        Me.groupBox.Controls.Add(Me.checkZdata)
        Me.groupBox.Controls.Add(Me.checkXdata)
        Me.groupBox.Controls.Add(Me.checkYdata)
        Me.groupBox.Enabled = False
        Me.groupBox.Location = New System.Drawing.Point(316, 320)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(247, 138)
        Me.groupBox.TabIndex = 17
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "Chart Controls"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.windowSizeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(141, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 54)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Window Size"
        '
        'windowSizeLabel
        '
        Me.windowSizeLabel.AutoSize = True
        Me.windowSizeLabel.Location = New System.Drawing.Point(35, 27)
        Me.windowSizeLabel.Name = "windowSizeLabel"
        Me.windowSizeLabel.Size = New System.Drawing.Size(19, 13)
        Me.windowSizeLabel.TabIndex = 12
        Me.windowSizeLabel.Text = "25"
        '
        'countsCheckBox
        '
        Me.countsCheckBox.AutoSize = True
        Me.countsCheckBox.Checked = True
        Me.countsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.countsCheckBox.Location = New System.Drawing.Point(15, 113)
        Me.countsCheckBox.Name = "countsCheckBox"
        Me.countsCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.countsCheckBox.TabIndex = 9
        Me.countsCheckBox.Text = "Counts/ mili g"
        Me.countsCheckBox.UseVisualStyleBackColor = True
        '
        'checkMagData
        '
        Me.checkMagData.AutoSize = True
        Me.checkMagData.Checked = True
        Me.checkMagData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkMagData.Location = New System.Drawing.Point(15, 89)
        Me.checkMagData.Name = "checkMagData"
        Me.checkMagData.Size = New System.Drawing.Size(76, 17)
        Me.checkMagData.TabIndex = 8
        Me.checkMagData.Text = "Magnitude"
        Me.checkMagData.UseVisualStyleBackColor = True
        '
        'chartWindowSizeControl
        '
        Me.chartWindowSizeControl.Location = New System.Drawing.Point(316, 496)
        Me.chartWindowSizeControl.Name = "chartWindowSizeControl"
        Me.chartWindowSizeControl.Size = New System.Drawing.Size(247, 45)
        Me.chartWindowSizeControl.TabIndex = 10
        '
        'responseTextLabel
        '
        Me.responseTextLabel.AutoSize = True
        Me.responseTextLabel.Location = New System.Drawing.Point(6, 70)
        Me.responseTextLabel.Name = "responseTextLabel"
        Me.responseTextLabel.Size = New System.Drawing.Size(105, 13)
        Me.responseTextLabel.TabIndex = 15
        Me.responseTextLabel.Text = "Command Response"
        '
        'grpBox1
        '
        Me.grpBox1.Controls.Add(Me.txtReceive)
        Me.grpBox1.Controls.Add(Me.responseTextLabel)
        Me.grpBox1.Controls.Add(Me.btnSend)
        Me.grpBox1.Controls.Add(Me.txtTransmit)
        Me.grpBox1.Controls.Add(Me.sendCommandLabel)
        Me.grpBox1.Location = New System.Drawing.Point(0, 355)
        Me.grpBox1.Name = "grpBox1"
        Me.grpBox1.Size = New System.Drawing.Size(310, 194)
        Me.grpBox1.TabIndex = 16
        Me.grpBox1.TabStop = False
        Me.grpBox1.Text = "Command Functions"
        '
        'recordBtn
        '
        Me.recordBtn.Enabled = False
        Me.recordBtn.Location = New System.Drawing.Point(17, 170)
        Me.recordBtn.Name = "recordBtn"
        Me.recordBtn.Size = New System.Drawing.Size(75, 23)
        Me.recordBtn.TabIndex = 18
        Me.recordBtn.Text = "Record"
        Me.recordBtn.UseVisualStyleBackColor = True
        '
        'fileButton
        '
        Me.fileButton.Location = New System.Drawing.Point(17, 16)
        Me.fileButton.Name = "fileButton"
        Me.fileButton.Size = New System.Drawing.Size(99, 42)
        Me.fileButton.TabIndex = 19
        Me.fileButton.Text = "Select " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File Name"
        Me.fileButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fileButton)
        Me.GroupBox2.Controls.Add(Me.recordBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(569, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 215)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create Data Files"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chartWindowSizeControl)
        Me.Controls.Add(Me.grpBox1)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.chartDisplay)
        Me.Controls.Add(Me.comPortLabel)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.btnConnect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "GCDC Dongle Example"
        CType(Me.chartDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chartWindowSizeControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox1.ResumeLayout(False)
        Me.grpBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents comPortLabel As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtTransmit As System.Windows.Forms.TextBox
    Friend WithEvents sendCommandLabel As System.Windows.Forms.Label
    Friend WithEvents txtReceive As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents checkXdata As System.Windows.Forms.CheckBox
    Friend WithEvents checkYdata As System.Windows.Forms.CheckBox
    Friend WithEvents checkZdata As System.Windows.Forms.CheckBox
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents responseTextLabel As System.Windows.Forms.Label
    Friend WithEvents chartDisplay As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents grpBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkMagData As System.Windows.Forms.CheckBox
    Friend WithEvents countsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents chartWindowSizeControl As System.Windows.Forms.TrackBar
    Friend WithEvents windowSizeLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents recordBtn As System.Windows.Forms.Button
    Friend WithEvents fileButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
