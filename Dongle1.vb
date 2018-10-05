Imports System
Imports System.Object
Imports System.ComponentModel
Imports System.Math
Imports System.Threading
Imports System.IO
Imports System.IO.Ports
Imports System.IO.Stream
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmMain
    Dim myPort As Array                                         'array of possible Com Ports

    Dim filename As String
    Dim writefstream As StreamWriter

    Dim xDataOn As Boolean = True                               'hide/show xData on the chart
    Dim yDataOn As Boolean = True                               'hide/show yData on the chart
    Dim zDataOn As Boolean = True                               'hide/show zData on the chart
    Dim magDataOn As Boolean = True                             'hide/show magnitude data on the chart
    Dim record As Boolean = False                               'record Data
    Dim setupBarometerChart As Boolean = True                   'Barometer chart needs to be set up
    Dim setupAccelerometerChart As Boolean = True               'Accelerometer chart needs to be set up
    Dim countsTomG As Double = 1                                'Counts to mili g conversion factor

    Dim frameSize As Int16 = 25                                 'chart data frame size
    Dim exceptionCount As Int16 = 0                                 'error counter

    Dim bw As BackgroundWorker = New BackgroundWorker

    Delegate Sub ChangeAxis(ByVal conversion As Double)
    Delegate Sub ChangeSeriesEnable(ByVal bool As Boolean, ByVal S1 As Series)
    Delegate Sub SetTextCallback(ByVal [text] As String)

    Private Sub frmMain_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.SerialPort1.Close()              'close serial port
        Me.SerialPort1.Dispose()            'Dispose of the serial port
        'Dispose of all used form controls
        Me.cmbPort.Dispose()
        Me.comPortLabel.Dispose()
        Me.btnConnect.Dispose()
        Me.txtTransmit.Dispose()
        Me.sendCommandLabel.Dispose()
        Me.txtReceive.Dispose()
        Me.btnSend.Dispose()
        Me.writefstream.Dispose()
        Me.checkXdata.Dispose()
        Me.checkYdata.Dispose()
        Me.checkZdata.Dispose()
        Me.groupBox.Dispose()
        Me.responseTextLabel.Dispose()
        Me.chartDisplay.Dispose()
        Me.grpBox1.Dispose()
        Me.checkMagData.Dispose()
        Me.countsCheckBox.Dispose()
        Me.fileButton.Dispose()
        Me.recordBtn.Dispose()
        Exit Sub

    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()             'Get available Serial Ports
        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))                        'Populate the Port Combo Box
        Next
        SerialPort1.PortName = vbNull                           'Set default serial port to NUll
        With chartWindowSizeControl                             'Set the number of ticks in the slider bar
            .Maximum = 11
            .Minimum = 0
        End With

    End Sub


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        SerialPort1.BaudRate = 115200                           'Set baud rate to 115200 baud
        SerialPort1.Parity = IO.Ports.Parity.None               'Set serial port Parity
        SerialPort1.StopBits = IO.Ports.StopBits.One            'Set the number of serial port stop bits
        SerialPort1.DataBits = 8                                'Set the number of Data bits

        If SerialPort1.PortName.Contains("COM") Then            'If there is a valid serial port name selected
            If btnConnect.Text.Equals("Connect") Then           'If the button currently reads Connect
                Try
                    SerialPort1.Open()                          'Open the serial Port
                    groupBox.Enabled = True                     'Turn on the group box
                    btnConnect.Text = "Disconnect"              'Change the button text to Disconnect
                    btnConnect.Update()
                    SerialPort1.Write("v" & vbCr)               'Send data Out a verstion request via the Serial port

                    Return
                Catch ex As IOException
                    MsgBox("Error opening COM Port")            'send error message
                End Try

            End If

            If btnConnect.Text.Equals("Disconnect") Then        'If the serial port is open
                Try
                    SerialPort1.DiscardInBuffer()               'Clear the input buffer
                Catch ex As Exception

                Finally
                    If SerialPort1.IsOpen Then
                        SerialPort1.Close()                     'Close the serial port
                    End If
                End Try
                btnConnect.Text = "Connect"                     'Change the text to Connect
                groupBox.Enabled = False                        'Disable the groupBox with data checkboxes
                btnConnect.Update()
                Return
            End If

        Else
            MsgBox("Select a valid COM Port", vbCritical)       'else send error message
            Return
        End If


    End Sub


    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Write(txtTransmit.Text & vbCr)          'Send data Out via the Serial port
        End If
    End Sub


    Private Sub SerialPort1_DataRecieved(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If SerialPort1.IsOpen Then
            ReceivedText(SerialPort1.ReadExisting())            'Recieve Data via the serial port
        End If
    End Sub


    Private Sub ReceivedText(ByVal [text] As String)
        Dim rxData As String = Nothing                          'String for incoming serial port data

        'Handle Incoming serial data
        If Me.txtReceive.InvokeRequired Then                    'If threadsafe call needed
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            rxData = [text]                                     'Else assign rxData to the Serial Port Received Text
            bw_DoWork(rxData)                                   'Do the computations on the recieved text
        End If

    End Sub


    Private Sub SetAxisAccel()
        Me.chartDisplay.ChartAreas(0).AxisY.Maximum = (16000 * countsTomG)      'Set Y axis max
        Me.chartDisplay.ChartAreas(0).AxisY.Minimum = (-16000 * countsTomG)     'Set Y axis Min

        If countsTomG = 1 Then
            chartDisplay.ChartAreas(0).AxisY.Title = ("Counts")                 'change the y axis label to Counts
        Else
            chartDisplay.ChartAreas(0).AxisY.Title = ("mili-g")                 'change the y axis label to mili-g
        End If

    End Sub


    Private Sub SetAxisBarometer()
        Me.chartDisplay.ChartAreas(1).AxisY.Maximum = (500)      'Set Y axis max
        Me.chartDisplay.ChartAreas(1).AxisY.Minimum = (100)     'Set Y axis Min
        Me.chartDisplay.ChartAreas(0).AxisY.Maximum = 200000
        Me.chartDisplay.ChartAreas(0).AxisY.Minimum = 90000
    End Sub


    Private Sub SetSeriesEnable(ByVal Bool As Boolean, ByVal S1 As Series)
        If Bool = False Then
            S1.Enabled = False                                                  'hide the series
        Else
            S1.Enabled = True                                                   'show the series
        End If
    End Sub


    Private Sub cmbPort_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPort.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text                                 'change the serial port to the name selected in the combo box
        Else
            MsgBox("valid only if port is Closed", vbCritical)                  'ohterwise output error message
        End If
    End Sub


    Private Sub checkXdata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkXdata.CheckedChanged
        If checkXdata.Checked Then
            xDataOn = True              'Show xData on the chart
        Else
            xDataOn = False             'Hide xData on the chart
        End If
    End Sub


    Private Sub checkYdata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkYdata.CheckedChanged
        If checkYdata.Checked Then
            yDataOn = True              'Show yData on the chart
        Else
            yDataOn = False             'Hide yData on the chart
        End If
    End Sub


    Private Sub checkZdata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkZdata.CheckedChanged
        If checkZdata.Checked Then
            zDataOn = True              'Show zData on the chart
        Else
            zDataOn = False             'Hide zData on the chart
        End If
    End Sub


    Private Sub checkMagData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkMagData.CheckedChanged
        If checkMagData.Checked Then
            magDataOn = True            'Show magnitude Data on the chart
        Else
            magDataOn = False           'Hide magnitude Data on the chart
        End If
    End Sub


    Private Sub txtTransmit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransmit.TextChanged
        If SerialPort1.IsOpen Then
            'If the text is a command
            If txtTransmit.Text.Contains("+") Or txtTransmit.Text.Contains("-") Or txtTransmit.Text.Contains("m") Or txtTransmit.Text.Contains("M") Or txtTransmit.Text.Contains("d") Or txtTransmit.Text.Contains("D") Or txtTransmit.Text.Contains("?") Or txtTransmit.Text.Contains("v") Or txtTransmit.Text.Contains("c") Or txtTransmit.Text.Contains("z") Or txtTransmit.Text.Contains("s") Or txtTransmit.Text.Contains("x") Then
                SerialPort1.Write(txtTransmit.Text & vbCrLf) 'send the command
            End If
        End If
    End Sub


    Private Sub countsCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countsCheckBox.CheckedChanged
        If countsCheckBox.Checked Then
            countsTomG = 1                  'raw counts
        Else
            countsTomG = 1000 / 1024        'conversion to mili g
        End If
    End Sub


    Private Sub chartWindowSizeControl_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chartWindowSizeControl.Scroll

        If chartWindowSizeControl.Value = 0 Then
            frameSize = 25                                          'set the frame size to 25
        End If
        If chartWindowSizeControl.Value = 1 Then
            frameSize = 50                                          'set the frame size to 50
        End If
        If chartWindowSizeControl.Value = 2 Then
            frameSize = 100                                          'set the frame size to 100
        End If
        If chartWindowSizeControl.Value = 3 Then
            frameSize = 200                                          'set the frame size to 200
        End If
        If chartWindowSizeControl.Value = 4 Then
            frameSize = 300                                          'set the frame size to 300
        End If
        If chartWindowSizeControl.Value = 5 Then
            frameSize = 400                                          'set the frame size to 400
        End If
        If chartWindowSizeControl.Value = 6 Then
            frameSize = 500                                          'set the frame size to 500
        End If
        If chartWindowSizeControl.Value = 7 Then
            frameSize = 600                                          'set the frame size to 600
        End If
        If chartWindowSizeControl.Value = 8 Then
            frameSize = 700                                          'set the frame size to 700
        End If
        If chartWindowSizeControl.Value = 9 Then
            frameSize = 800                                          'set the frame size to 800
        End If
        If chartWindowSizeControl.Value = 10 Then
            frameSize = 900                                          'set the frame size to 900
        End If
        If chartWindowSizeControl.Value = 11 Then
            frameSize = 1000                                          'set the frame size to 1000
        End If

        windowSizeLabel.Text = frameSize                              'update the window Size Label


    End Sub


    Private Sub bw_DoWork(ByVal rxData As String)
        Static Dim accel As Boolean = True                                  'set accelerometer as connected by default
        Static Dim barometer As Boolean = False                             'set barometer as not connected by default
        Dim lineData() As String                                            'stores the incomming serial data as an array of lines
        Dim seperatedData() As String


        lineData = rxData.Split(vbCrLf)                                     'Split serial text recieved by line
        For i = 0 To lineData.Length - 1                                    'Itterate through the lines
            lineData(i) = lineData(i).Trim()                                'Trim of begining and ending spaces

            If lineData(i).Contains(";") Then
                Me.txtReceive.Text &= lineData(i) & vbCrLf                  'Display responses to commands in the text box

                'If the device connected is a barometer
                If lineData(i).Contains(";Barometer svn: 20:21M, BMP085") Then
                    barometer = True                                        'Set unit type to barometer
                    accel = False
                    groupBox.Enabled = False                                'Disable Acceleromter Specific functions
                End If

                'If the device connected is an accelerometer
                If lineData(i).Contains(";d16-x, 0x13, 20130910 15:09:29, ADXL345") Then
                    accel = True                                            'set unit type to acceleromter
                    barometer = False                                       'disable barometer specific functions
                End If

            Else

                seperatedData = lineData(i).Split(",")                      'seperate a line of serial data by commas

                If accel.Equals(True) Then
                    If seperatedData.Count.Equals(4) Then
                        plotAccelChart(seperatedData)                           'plot the Acceleromter Chart
                        'If Record is enabled
                        If record Then
                            If lineData(i) IsNot Null Then
                                RecordData(lineData(i))                                 'Record the serial data
                            End If
                        End If
                    End If
                End If

                If barometer.Equals(True) Then
                    If seperatedData.Count.Equals(3) Then
                        plotBarometerChart(seperatedData)                       'plot the barometer Chart
                        'If Record is enabled
                        If record Then
                            If lineData(i) IsNot Null Then
                                RecordData(lineData(i))                                 'Record the serial data
                            End If
                        End If
                    End If
                End If
            End If


        Next
    End Sub


    Private Sub plotAccelChart(ByVal Data() As String)
        Static Dim oldSize As Int16 = 25                                    'holds the old window size
        Dim pointData(4) As String                                          'stores the incomming serial data as an array of points
        Dim xcord As Int64
        Dim ycord As Int64
        Dim zcord As Int64
        Dim Magnitude As UInt64

        'Set up series names
        Dim xData As New Series                                             'make xData the first series
        Dim yData As New Series                                             'make yData the second series
        Dim zData As New Series                                             'make zData the third series
        Dim MagnitudeData As New Series                                     'make MagnitudeData the fourth series

        If setupAccelerometerChart Then
            makeAccelChart(xData, yData, zData, MagnitudeData)              'setup the Accelerometer chart
            setupAccelerometerChart = False                                 'Acceleromter chart does not need to be setup
            setupBarometerChart = True                                      'Barometer chart needs to be setup
        End If

        xData.Name = "x Data"
        yData.Name = "y Data"
        zData.Name = "z Data"
        MagnitudeData.Name = "Magnitude Data"
        Dim updateAxis As New ChangeAxis(AddressOf SetAxisAccel)
        Me.Invoke(updateAxis, New Object() {(countsTomG)})                  'edit axis in a thread safe manner
        Dim xSeries As New ChangeSeriesEnable(AddressOf SetSeriesEnable)
        Me.Invoke(xSeries, New Object() {(xDataOn), (xData)})               'edit series.enable in a thread safe manner 
        Dim ySeries As New ChangeSeriesEnable(AddressOf SetSeriesEnable)
        Me.Invoke(ySeries, New Object() {(yDataOn), (yData)})               'edit series.enable in a thread safe manner
        Dim zSeries As New ChangeSeriesEnable(AddressOf SetSeriesEnable)
        Me.Invoke(zSeries, New Object() {(zDataOn), (zData)})               'edit series.enable in a thread safe manner
        Dim magSeries As New ChangeSeriesEnable(AddressOf SetSeriesEnable)
        Me.Invoke(magSeries, New Object() {(magDataOn), (MagnitudeData)})   'edit series.enable in a thread safe manner

        pointData = Data

        If pointData.Length.Equals(4) Then                                  'If the line is a dataset

            Try
                xcord = pointData(1) * countsTomG                           ' Set x coordinate
                ycord = pointData(2) * countsTomG                           ' Set y coordinate
                zcord = pointData(3) * countsTomG                           ' Set z coordinate
                'add points to the chart
                chartDisplay.Series(xData.Name).Points.AddXY(pointData(0), xcord)
                chartDisplay.Series(yData.Name).Points.AddXY(pointData(0), ycord)
                chartDisplay.Series(zData.Name).Points.AddXY(pointData(0), zcord)
                'get coordinates ready for the magnitude 
                xcord = xcord * xcord
                ycord = ycord * ycord
                zcord = zcord * zcord
                Magnitude = Sqrt(xcord + ycord + zcord)                     'process the magnitude
                chartDisplay.Series(MagnitudeData.Name).Points.AddXY(pointData(0), Magnitude)   'add the magnitude points

            Catch ex As InvalidCastException
                exceptionCount = exceptionCount + 1
            Finally

            End Try

            If chartDisplay.Series(xData.Name).Points.Count > frameSize Then              ' set the sliding window size
                'delete the first point of the chart
                chartDisplay.Series(xData.Name).Points.RemoveAt(0)          'remove points to set the window size
                chartDisplay.Series(yData.Name).Points.RemoveAt(0)
                chartDisplay.Series(zData.Name).Points.RemoveAt(0)
                chartDisplay.Series(MagnitudeData.Name).Points.RemoveAt(0)
            End If

            If oldSize > frameSize Then                                     ' set the sliding window size
                Dim currsize As Int16 = (chartDisplay.Series(xData.Name).Points.Count - frameSize - 1)
                oldSize = frameSize

                If chartDisplay.Series(xData.Name).Points.Count > frameSize Then
                    For k = currsize To 0 Step -1
                        'delete the points from from the chart to ensure that the correct number of points are displayed
                        chartDisplay.Series(xData.Name).Points.RemoveAt(k)
                        chartDisplay.Series(yData.Name).Points.RemoveAt(k)
                        chartDisplay.Series(zData.Name).Points.RemoveAt(k)
                        chartDisplay.Series(MagnitudeData.Name).Points.RemoveAt(k)
                    Next
                End If

            ElseIf oldSize < frameSize Then
                oldSize = frameSize                                         'set the old frame size to the current frame size
            End If
        End If
    End Sub


    Private Sub makeAccelChart(ByVal S1 As Series, ByVal S2 As Series, ByVal S3 As Series, ByVal S4 As Series)
        Dim accelLegend As Legend = New Legend
        Dim area1 As New ChartArea

        Me.chartDisplay.Series.Clear()

        'Begin Chart Setup
        Me.chartDisplay.ChartAreas.Clear()
        area1.Name = "Area1"
        Me.chartDisplay.ChartAreas.Add(area1)

        'setup the legend
        accelLegend.Name = "Legend"
        Me.chartDisplay.Legends.Clear()
        Me.chartDisplay.Legends.Add(accelLegend)

        'setup series
        S1.ChartArea = "Area1"
        S1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        S1.Legend = "Legend"
        S1.Name = "xData"
        Me.chartDisplay.Series.Add(S1)
        S2.ChartArea = "Area1"
        S2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        S2.Legend = "Legend"
        S2.Name = "yData"
        Me.chartDisplay.Series.Add(S2)
        S3.ChartArea = "Area1"
        S3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        S3.Legend = "Legend"
        S3.Name = "zData"
        Me.chartDisplay.Series.Add(S3)
        S4.ChartArea = "Area1"
        S4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        S4.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        S4.Legend = "Legend"
        S4.Name = "MagnitudeData"
        Me.chartDisplay.Series.Add(S4)
        'Set up series X value member (The x axis)
        chartDisplay.Series(S1.Name).XValueMember = "Time Stamp"
        chartDisplay.Series(S2.Name).XValueMember = "Time Stamp"
        chartDisplay.Series(S3.Name).XValueMember = "Time Stamp"
        chartDisplay.Series(S4.Name).XValueMember = "Time Stamp"
        'End Chart Setup
    End Sub


    Private Sub plotBarometerChart(ByVal Data() As String)
        Static Dim oldSize As Int16 = 25                        'holds the old window size
        Dim pressure As Int64
        Dim temperature As Int64
        'Set up series names
        Dim pressureData As New Series                          'make pressure Data the first series
        Dim temperatureData As New Series                       'make  temperature Data the second series

        If setupBarometerChart Then
            makeBarometerChart(pressureData, temperatureData)   'Setup the barometer chart
            setupBarometerChart = False                         'Barometer chart does not need to be setup
            setupAccelerometerChart = True                      'Accelerometer chart does need to be setup
        End If

        pressureData.Name = "Pressure"                          'set the pressure Data series name to Pressure
        temperatureData.Name = "Temperature"                    'set the temperature Data series name to Temperature
        SetAxisBarometer()


        'Time stamp should be the first string in the series
        If Data.Length.Equals(3) Then
            'the first data value is equal to the time stamp
            pressure = Data(1)                                  'set pressure equal to the second data value
            temperature = Data(2)                               'set temperature equal to the third data value

            chartDisplay.Series(pressureData.Name).Points.AddXY(Data(0), pressure)          'add a point to the pressure graph
            chartDisplay.Series(temperatureData.Name).Points.AddXY(Data(0), temperature)    'add a point to the temperature graph

            If chartDisplay.Series(pressureData.Name).Points.Count > frameSize Then         'set the sliding window size
                'delete the first point of the chart
                chartDisplay.Series(pressureData.Name).Points.RemoveAt(0)                   'remove points to set the window size
                chartDisplay.Series(temperatureData.Name).Points.RemoveAt(0)
            End If

            If oldSize > frameSize Then              'set the sliding window size
                Dim currsize As Int16 = (chartDisplay.Series(pressureData.Name).Points.Count - frameSize - 1)
                oldSize = frameSize                  'set the old window size to the current window size

                If chartDisplay.Series(pressureData.Name).Points.Count > frameSize Then
                    For k = currsize To 0 Step -1
                        'delete the points from the chart to ensure the correct window size
                        chartDisplay.Series(pressureData.Name).Points.RemoveAt(k)
                        chartDisplay.Series(temperatureData.Name).Points.RemoveAt(k)
                    Next
                End If

            ElseIf oldSize < frameSize Then
                oldSize = frameSize                  'set the old window size to the current window size
            End If
        End If
    End Sub


    Private Sub makeBarometerChart(ByVal S1 As Series, ByVal S2 As Series)
        Dim baromLegend As Legend = New Legend
        Dim area1 As New ChartArea
        Dim area2 As New ChartArea

        Me.chartDisplay.Series.Clear()
        'begin chart setup
        Me.chartDisplay.ChartAreas.Clear()
        area1.Name = "Area1"
        Me.chartDisplay.ChartAreas.Add(area1)
        area2.Name = "Area2"
        Me.chartDisplay.ChartAreas.Add(area2)

        'setup the legend
        baromLegend.Name = "Legend"
        Me.chartDisplay.Legends.Clear()
        Me.chartDisplay.Legends.Add(baromLegend)

        'setup series
        S1.ChartArea = "Area1"
        S1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        S1.Legend = "Legend"
        S1.Name = "xData"
        Me.chartDisplay.Series.Add(S1)
        S2.ChartArea = "Area2"
        S2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        S2.Legend = "Legend"
        S2.Name = "yData"
        Me.chartDisplay.Series.Add(S2)
        'Set up series X value member (The x axis)
        chartDisplay.Series(S1.Name).XValueMember = "Time Stamp"
        chartDisplay.Series(S2.Name).XValueMember = "Time Stamp"
        'End Chart Setup

    End Sub


    Private Sub RecordData(ByVal line As String)
        Static Dim lineIndex As Int32 = 0                                       'number of lines written to the file
        Static Dim tempfile As New StringBuilder                                       'temporay file buffer for data
        Dim sb As New StringBuilder


        tempfile.AppendLine(line.Trim(vbCr, vbLf))                                               'add the line to the temporay file variable

        lineIndex = lineIndex + 1                                               'update the file line index
        Try
            Using writefstream = File.AppendText(filename)
                writefstream.Write(tempfile.ToString())                     'write line to the file
                'writefstream.Flush()                                            'make sure the filestream is writen to the file
                tempfile.Clear()
            End Using

        Catch ex As IOException
            MsgBox("Error writning to file")                                    'send error message
        End Try

        If lineIndex > 50000 Then
            makeNewFileName(filename)
            lineIndex = 0
        End If

    End Sub


    Private Sub makeNewFileName(ByRef fname As String)
        Static Dim origString As String = vbEmpty
        Static Dim firstRun As Boolean = True
        Dim sb As New StringBuilder

        If firstRun Then
            origString = fname                          'save the orginal filename string
            firstRun = False
        End If

        sb.Append(origString)                           'append the original string
        sb.Replace(".csv", "_" & DateTime.Now.ToString("yyyyMMdd") & "_" & DateTime.Now.ToString("HHmmss"))     'replace .csv with _yyyyMMdd_HHmmss this creates a unique file identifier
        sb.Append(".csv")   'add the .csv extention back
        fname = sb.ToString 'return the filename

    End Sub


    Private Sub fileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileButton.Click
        SaveFileDialog1.Filter = "csv files (*.csv)|*.csv"          'only show .csv files
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then      'If the dialog executed
            filename = (SaveFileDialog1.FileName)                   'set filename to the name given to the file in the save file dialog
            recordBtn.Enabled = True                                'Enable the record button
        End If
    End Sub


    Private Sub recordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recordBtn.Click

        If recordBtn.Text.Equals("Record") Then
            recordBtn.Text = "Stop"                 'change the record button text to Stop
            record = True                           'set state to recording
            fileButton.Enabled = False              'Disable the file save button
            Return
        End If

        If recordBtn.Text.Equals("Stop") Then
            recordBtn.Text = "Record"               'change the rcord button text to Record
            record = False                          'set state to not recording
            fileButton.Enabled = True               'Enable the file save button
            recordBtn.Enabled = False               'Disable the record button
            Return
        End If

    End Sub


End Class

