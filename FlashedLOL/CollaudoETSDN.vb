Imports System.Threading
Imports System.IO
Imports FlashedLOL.Peak.Can.Basic
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.Text
Imports System.Security.Cryptography.X509Certificates
Imports MongoDB.Driver.Encryption

Public Class CollaudoETSDN

    Private thread As Thread
    Private AnimatedImage As Image
    Private varETSDN As New VarRxFromETSDN
    Dim canEtsdnVar As New CanEtsdn
    Dim varTxEtsdn As New VarTxToETSDN
    Dim resultTest As New ResultTestDoneETSDN
    Dim statoCollaudo As New StatoTestCollaudo
    Dim abortTests = False
    Dim log As New WriteRepor
    Dim reportInfo As New ReportInfoTestEtsdn
    Dim reportstart As New InfoEventTest
    Dim reportPwr As New ReportTestPower
    Dim reportRl As New ReportTestRele
    Dim reportIp As New ReportTestInput
    Dim reportAna As New ReportTestAnalog
    Dim report5V As New ReportTest5V
    Dim reportAcc As New ReportoTestAccelerometer
    Dim enableReading5V As Boolean = False
    Dim enableReading10V As Boolean = False
    Private Declare Sub CopyMemory Lib "kernel32" Alias _
    "RtlMoveMemory" (ByVal Destination As Long, ByVal _
    Source As Long, ByVal Length As Integer)

    Private Sub CollaudoETSDN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statoCollaudo.fsmTest = 0
        LabelClock.Text = Date.Today.ToLongDateString
        'If File.Exists(Application.StartupPath & "\\Log\\logOld.txt") Then
        '    File.Delete(Application.StartupPath & "\\Log\\logOld.txt")
        'End If

        'If File.Exists(Application.StartupPath & "\\Log\\logDataTempEtsdn.txt") Then
        '    My.Computer.FileSystem.RenameFile(Application.StartupPath & "\\Log\\logDataTempEtsdn.txt", "logOld.txt")
        'End If

        Try
            thread = New Thread(AddressOf MyBackgroundThreadETSDN)
            thread.Start()
        Catch ex As Exception
            System.Console.WriteLine("Error during thread start")
        End Try

        InitializeBasicComponents()
        unInit_CANOPEN()
        statoCollaudo.NameOperator = Main.TextboxPredictionUsername.Text
        Try
            Dim tm As New Stopwatch
            tm.Restart()
            Do While tm.ElapsedMilliseconds < 3000 Or canEtsdnVar.canOpenInizialized = False
                canEtsdnVar.InitCanOpen()
                Console.WriteLine("InitCAN")
                If canEtsdnVar.canOpenInizialized Then
                    Console.WriteLine("InitCAN_Done")
                    Exit Do
                End If
            Loop

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        'canEtsdnVar.InitCanOpen()
        SetPopUpInfoTest()

        ChangeBarColor(BarTestEtsdn, ProgressBarColor.Yellow)

    End Sub
    Private Sub CloseCollETSDN(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        statoCollaudo.RequestToStopTest = True
        BarTestEtsdn.Enabled = False
        Wait(100)
        'MyBackgroundThreadETSDN()
    End Sub
    Private Sub ResetLoadingVisibility()
        ChangeControlVisibility(LoadingPWR, False)
        ChangeControlVisibility(LoadingRL, False)
        ChangeControlVisibility(LoadingIP, False)
        ChangeControlVisibility(Loading5V, False)
        ChangeControlVisibility(LoadingAcc, False)
    End Sub

    Private Sub ResetAllVisibility()
        ChangeControlVisibility(StatoTestAlimentazione, False)
        ChangeControlVisibility(StatotestRele, False)
        ChangeControlVisibility(StatoTestIngressi, False)

        ChangeControlVisibility(StatoTest5V, False)
        ChangeControlVisibility(StatoTestCAN, False)
        ChangeControlVisibility(StatoTestAccellerometro, False)

        ChangeControlVisibility(LoadingPWR, False)
        ChangeControlVisibility(LoadingRL, False)
        ChangeControlVisibility(LoadingIP, False)

        ChangeControlVisibility(Loading5V, False)
        ChangeControlVisibility(LoadingAcc, False)

        ChangeControlVisibility(ErrorTestPWR, False)
        ChangeControlVisibility(ErrorTestRL, False)
        ChangeControlVisibility(ErrorTestIP, False)

        ChangeControlVisibility(ErrorTest5V, False)
        ChangeControlVisibility(ErrorTestCAN, False)
        ChangeControlVisibility(ErrorTestACC, False)

        ChangeControlVisibility(IP1_OK, False)
        ChangeControlVisibility(IP1_NOT, False)
        ChangeControlVisibility(IP2_OK, False)
        ChangeControlVisibility(IP2_NOT, False)
        ChangeControlVisibility(IN1_OK, False)
        ChangeControlVisibility(IN1_NOT, False)
        ChangeControlVisibility(IN2_OK, False)
        ChangeControlVisibility(IN2_NOT, False)
        ChangeControlVisibility(ANA5V_OK, False)
        ChangeControlVisibility(ANA5V_NOT, False)
        ChangeControlVisibility(ANA10V_OK, False)
        ChangeControlVisibility(ANA10V_NOT, False)
        ChangeControlVisibility(OUT5V_OK, False)
        ChangeControlVisibility(OUT5V_NOT, False)
        ChangeControlVisibility(RL1_OK, False)
        ChangeControlVisibility(RL1_NOT, False)
        ChangeControlVisibility(RL2_OK, False)
        ChangeControlVisibility(RL2_NOT, False)
        ChangeControlVisibility(RL3_OK, False)
        ChangeControlVisibility(RL3_NOT, False)

        ChangeControlVisibility(ETSDN_Statico, False)
        ChangeControlVisibility(MovimentoETSDN, False)
        ChangeControlVisibility(ButtonErrorView, False)

        statoCollaudo.testPWRsuccess = False
        statoCollaudo.testRLsuccess = False
        statoCollaudo.testIngressiSuccess = False
        statoCollaudo.test5Vsuccess = False
        statoCollaudo.testCANsuccess = False
        statoCollaudo.testACCsuccess = False

        statoCollaudo.testPWRcompleted = False
        statoCollaudo.testRLcompleted = False
        statoCollaudo.testIPcompleted = False
        statoCollaudo.testIngressiCompleted = False
        statoCollaudo.test5Vcompleted = False
        statoCollaudo.testCANcompleted = False
        statoCollaudo.testACCcompleted = False

        statoCollaudo.OldSerialDevice = ""
        statoCollaudo.StepRele = 0
        statoCollaudo.timerRele.Reset()
        statoCollaudo.timerANA.Reset()
        BarTestEtsdn.Minimum = 0
        BarTestEtsdn.Maximum = 60
        BarTestEtsdn.Value = 0
        ChangeBarColor(BarTestEtsdn, ProgressBarColor.Yellow)
    End Sub


    Public Sub SetPopUpInfoTest()
        Dim PopUpInfo As New ToolTip()
        PopUpInfo.ShowAlways = True
        PopUpInfo.SetToolTip(StartEtsdn,
        "Premere per eseguire il test")
        PopUpInfo.SetToolTip(InfoPWR,
        "Viene controllata la corretta erogazione di corrente dal dispositivo.
    WARNING:
        controllare sempre sull'alimentatore possibili corti;
        il test va eseguito a 24V sull'alimentatore altrimenti il test potrebbe fallire.")
        PopUpInfo.SetToolTip(InfoRL,
        "Viene controllato che non ci sia alimentazione con tutti i relè aperti,
    viene effettuato un controllo corrente su ogni relè aprendone uno alla volta.")
        PopUpInfo.SetToolTip(InfoIP,
        "Viene fornita alimentazione singolarmente ad ogni IP e IN, viene controlalto anche che non ci siano 'corti' tra i vari ingressi.
    Gli analogici vengono controllati in base alla loro salita e discesa e che sia la stessa che viene fornita dalla centralina.")
        PopUpInfo.SetToolTip(Info5V,
        "Viene controlalto che il valore erogato dal dispositivo non superi e non scenda sotto i 5,1 e i 4,9")
        PopUpInfo.SetToolTip(InfoACC,
        "Viene richiesto all'operatore di posizionare il dispositivo come mostrerà la figura durante il test e successivamente 
    muoverlo sempre seguendo l'illustrazione del test")
        PopUpInfo.SetToolTip(ErrorInfo,
        "Apre la gestione degli errori")
    End Sub
    Public Class VarRxFromETSDN
        Public vTensione As Single
        Public xStatoRL1, xStatoRL2, xStatoRL3 As Boolean
        Public xStatoIP1, xStatoIP2, xStatoIN1, xStatoIN2 As Single
        Public rANA5, rANA10, r5V As Single
        Public rSupplyANA10v, rSupplyANA5v As Single
        Public axisX, axisY, axisZ As Single
        Public plcEcuK15, plcPowerCurr, plc5V As Double
        Public vCurrentRL1, vCurrentRL2, vCurrentRL3 As Single
        Public xState_Gnd_5v As Single
        Public rSupplyVoltageEtsdn As UInteger
        Public MsgCanPLC As Single
        Dim canOpenInizialized As Boolean
        Public etsdnOnline As Boolean
        Public etsdnSN As String = ""
        Public tmrAna5v As New Stopwatch
        Public tmrAna10v As New Stopwatch
        Public stop_Cycle_5v As Boolean = True
        Public stop_Cycle_10v As Boolean = True
        Public counter5V As Integer = 0
        Public counter10V As Integer = 0
        Public end_test_5v As Byte = 0, end_test_10v As Byte = 0
        Public result_test_5v As Byte = 0, result_test_10v As Byte = 0



        Public Sub ParsingMSG(ID, Data)

            Static Dim etsdnSN01 As String
            Static Dim etsdnSN02 As String
            Static Dim etsdnSN03 As String
            Static Dim oldValue5v As Single = 0
            Static Dim oldValue10v As Single = 0

            Try


                Select Case (ID)
                    Case &H10000
                        xStatoRL1 = Data(0) And &B1
                        xStatoRL2 = Data(0) And &B10
                        xStatoRL3 = Data(0) And &B100
                        etsdnOnline = Data(1)
                        xState_Gnd_5v = (Data(2) >> 0) And &B1

                    Case &H10001
                        plcEcuK15 = Convert.ToSingle(Data(0)) + (Convert.ToSingle(Data(1)) << 8)
                        plcPowerCurr = Convert.ToSingle(Data(2)) + (Convert.ToSingle(Data(3)) << 8)
                        plc5V = Data(4) + (CType(Data(5), UShort) << 8)

                    Case &H10002
                        vCurrentRL1 = Data(0) + (CType(Data(1), UShort) << 8)
                        vCurrentRL2 = Data(2) + (CType(Data(3), UShort) << 8)
                        vCurrentRL3 = Data(4) + (CType(Data(5), UShort) << 8)


                    Case &H20001
                        xStatoIP1 = (Data(0) >> 0) And &B1
                        xStatoIP2 = (Data(0) >> 1) And &B1
                        xStatoIN1 = (Data(0) >> 2) And &B1
                        xStatoIN2 = (Data(0) >> 3) And &B1

                        rSupplyVoltageEtsdn = Data(4) + (CType(Data(5), UInteger) << 8)

                    Case &H20002
                        rANA10 = Convert.ToSingle(Data(0)) + (Convert.ToSingle(Data(1)) << 8)
                        rANA5 = Convert.ToSingle(Data(2)) + (Convert.ToSingle(Data(3)) << 8)
                        rSupplyANA10v = Convert.ToSingle(Data(4)) + (Convert.ToSingle(Data(5)) << 8)
                        rSupplyANA5v = Convert.ToSingle(Data(6)) + (Convert.ToSingle(Data(7)) << 8)


                        If (rSupplyANA5v > oldValue5v + 0.5) And Not stop_Cycle_5v Then
                            tmrAna5v.Restart()
                            counter5V = counter5V + 1
                        End If
                        oldValue5v = rSupplyANA5v
                        If (counter5V = 5 And tmrAna5v.ElapsedMilliseconds > 3000) Or (stop_Cycle_5v = True) Then
                            counter5V = 0
                            stop_Cycle_5v = True
                            oldValue5v = 0
                            tmrAna5v.Stop()
                        End If

                        If (rSupplyANA10v > oldValue10v + 0.5) And Not stop_Cycle_10v Then
                            tmrAna10v.Restart()
                            counter10V = counter10V + 1
                        End If
                        oldValue10v = rSupplyANA10v
                        If (counter10V = 5 And tmrAna10v.ElapsedMilliseconds > 3000) Or (stop_Cycle_10v = True) Then
                            counter10V = 0
                            stop_Cycle_10v = True
                            oldValue10v = 0
                            tmrAna10v.Stop()
                        End If

                    Case &H20003
                        Dim tempB0, tempB1 As Int16
                        tempB0 = tempB1 = 0

                        tempB0 = Data(0)
                        tempB1 = Data(1)

                        axisY = (Convert.ToSingle(tempB0 + ((tempB1) << 8))) * 0.000244140625

                        tempB0 = Data(2)
                        tempB1 = Data(3)
                        axisX = (Convert.ToSingle(tempB0 + ((tempB1) << 8))) * 0.000244140625

                        tempB0 = Data(6)
                        tempB1 = Data(7)
                        axisZ = (Convert.ToSingle(tempB0 + ((tempB1) << 8))) * 0.000244140625

                    Case &H101
                        etsdnSN01 = Chr(Data(0)) & Chr(Data(1)) & Chr(Data(2)) & Chr(Data(3)) &
                                  Chr(Data(4)) & Chr(Data(5)) & Chr(Data(6)) & Chr(Data(7))
                    Case &H102
                        etsdnSN02 = Chr(Data(0)) & Chr(Data(1)) & Chr(Data(2)) & Chr(Data(3)) &
                                  Chr(Data(4)) & Chr(Data(5)) & Chr(Data(6)) & Chr(Data(7))
                    Case &H103
                        etsdnSN03 = Chr(Data(0)) & Chr(Data(1)) & Chr(Data(2)) & Chr(Data(3)) &
                                Chr(Data(4)) & Chr(Data(5)) & Chr(Data(6)) & Chr(Data(7))

                        etsdnSN = etsdnSN01 & etsdnSN02 & etsdnSN03
                        If Not etsdnSN = Nothing Then
                            Dim pos = InStr(etsdnSN, vbCrLf)
                            etsdnSN = etsdnSN.Substring(0, pos - 1)
                            etsdnSN = Replace(etsdnSN, "|", "_")
                            etsdnSN = Replace(etsdnSN, ".", "-")
                        End If

                    Case &H105
                        end_test_5v = Data(0)
                        result_test_5v = Data(1)
                        end_test_10v = Data(2)
                        result_test_10v = Data(3)
                End Select
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        End Sub

    End Class

    Public Class VarTxToETSDN
        Dim setRL1, setRL2, setRL3, setAllRl, setSupplyRl1, setSupplyRl2, setSupplyRl3, setIP1, setIP2, setIN1, setIN2, set10V, Set5V, setCargo5v As Byte

        Public Sub SetStateCargo5V(stato)
            setCargo5v = stato
        End Sub

        Public Sub SetStateRL1(stato)
            setRL1 = stato
        End Sub

        Public Sub SetStateRL2(stato)
            setRL2 = stato
        End Sub

        Public Sub SetStateRL3(stato)
            setRL3 = stato
        End Sub

        Public Sub SetStateAllRl(stato)
            setRL1 = stato
            setRL2 = stato
            setRL3 = stato
        End Sub

        Public Sub SetPwrRL1(stato)
            setSupplyRl1 = stato
        End Sub

        Public Sub SetPwrRL2(stato)
            setSupplyRl2 = stato
        End Sub

        Public Sub SetPwrRL3(stato)
            setSupplyRl3 = stato
        End Sub
        Public Sub SetAllPwrRL(stato)
            setSupplyRl1 = stato
            setSupplyRl2 = stato
            setSupplyRl3 = stato
        End Sub
        Public Sub SetState10V(stato)
            set10V = stato
        End Sub

        Public Sub SetState5V(stato)
            Set5V = stato
        End Sub
        Public Sub SetStateIP1(stato)
            setIP1 = stato
        End Sub

        Public Sub SetStateIP2(stato)
            setIP2 = stato
        End Sub

        Public Sub SetStateIN1(stato)
            setIN1 = stato
        End Sub

        Public Sub SetStateIN2(stato)
            setIN2 = stato
        End Sub


        Function MsgComposer() As UShort
            Dim VarTempComposer As UShort

            VarTempComposer = 0
            VarTempComposer = VarTempComposer + setRL1
            VarTempComposer = VarTempComposer + (CType(setRL2, UShort) << 1)
            VarTempComposer = VarTempComposer + (CType(setRL3, UShort) << 2)
            VarTempComposer = VarTempComposer + (CType(setSupplyRl1, UShort) << 3)
            VarTempComposer = VarTempComposer + (CType(setSupplyRl2, UShort) << 4)
            VarTempComposer = VarTempComposer + (CType(setSupplyRl3, UShort) << 5)
            VarTempComposer = VarTempComposer + (CType(set10V, UShort) << 6)
            VarTempComposer = VarTempComposer + (CType(Set5V, UShort) << 7)


            VarTempComposer = VarTempComposer + (CType(setIP1, UShort) << 8)
            VarTempComposer = VarTempComposer + (CType(setIP2, UShort) << 9)
            VarTempComposer = VarTempComposer + (CType(setIN1, UShort) << 10)
            VarTempComposer = VarTempComposer + (CType(setIN2, UShort) << 11)
            VarTempComposer = VarTempComposer + (CType(setCargo5v, UShort) << 12)
            Return VarTempComposer
        End Function

    End Class


    Public Class CanEtsdn
        Public canOpenInizialized As Boolean

        '       Public byteToSend As Byte

        Function InitCanOpen()
            Try
                Dim canChannels = getAvailableCanChannels()
                canOpenInizialized = False

                If init_CANOPEN(canChannels(0), TPCANOPENBaudrate.PCANOPENBAUD_250K, False) Then
                    canOpenInizialized = True
                End If

            Catch ex As Exception
                Console.WriteLine("Error during init Can")
            End Try

        End Function



        Function SendCmdToEtsdn(bytesToSend As UShort, Optional timeoutmilliseconds As Integer = 50)


            If canOpenInizialized Then

                Dim canMsg As New TPCANOPENMsg()

                canMsg.ID = &H380
                canMsg.LEN = 8
                canMsg.DATA = New Byte() {0, 0, 0, 0, 0, 0, 0, 0}

                canMsg.DATA(0) = 0
                canMsg.DATA(1) = Convert.ToByte(bytesToSend And &HFF)
                canMsg.DATA(2) = Convert.ToByte(bytesToSend >> 8)
                sendCANMessage(canMsg)


                canMsg.ID = &H180
                canMsg.LEN = 8
                canMsg.DATA = New Byte() {0, 0, 0, 0, 0, 0, 0, 0}

                canMsg.DATA(0) = 1
                sendCANMessage(canMsg)

            End If
        End Function

    End Class

    Public Function ScanParseMsg(Optional timeoutmilliseconds As Integer = 100)

        Dim raw_msg As New TPCANMsg()
        Dim sw As New Stopwatch

        sw.Restart()

        While sw.ElapsedMilliseconds <= timeoutmilliseconds

            If receiveCANMessage(raw_msg) Then
                Dim ID = raw_msg.ID
                Dim DATA = raw_msg.DATA
            End If

            varETSDN.ParsingMSG(raw_msg.ID, raw_msg.DATA)
        End While
    End Function

    Public Sub ErrorTestDevice()
        If ErrorTestPWR.Visible = True Or
                ErrorTestRL.Visible = True Or
                ErrorTestIP.Visible = True Or
                ErrorTest5V.Visible = True Or
                ErrorTestCAN.Visible = True Or
                ErrorTestACC.Visible = True Then

            ChangeControlVisibility(ButtonErrorView, True)
            ChangeBarColor(BarTestEtsdn, ProgressBarColor.Red)
        Else
            ChangeBarColor(BarTestEtsdn, ProgressBarColor.Green)
        End If


    End Sub

    Private Sub StopEtsdn_Click(sender As Object, e As EventArgs) Handles StopEtsdn.Click
        reportstart.SetStopTest(clickstop:=True)
        StartEtsdn.Visible = True
        StopEtsdn.Visible = False
        abortTests = True
        statoCollaudo.fsmTest = 6
        varETSDN.stop_Cycle_5v = True
        varETSDN.stop_Cycle_10v = True
        varTxEtsdn.SetState5V(0)
        varTxEtsdn.SetState10V(0)

        'reportStop.SetStopTest(clickstop:=True)
        ResetLoadingVisibility()
    End Sub

    Private Sub StartEtsdn_Click(sender As Object, e As EventArgs) Handles StartEtsdn.Click
        Try
            If Not File.Exists(Application.StartupPath & "\\log\\Etsdn\\" & varETSDN.etsdnSN) Then
                My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\\log\\Etsdn\\" & varETSDN.etsdnSN, True)
                reportInfo.SetInfoTest(serial:=varETSDN.etsdnSN, day:=Date.Today.ToLongDateString, title:="<<<<<<ETSDN_TEST>>>>>>",
                                       name:=statoCollaudo.NameOperator.Text)
            Else
                reportInfo.SetInfoTest(serial:=varETSDN.etsdnSN, day:=Date.Today.ToLongDateString, title:="● New attempt ●",
                                       name:=statoCollaudo.NameOperator.Text)
            End If
        Catch ex As Exception

        End Try
        varETSDN.stop_Cycle_5v = False
        varETSDN.stop_Cycle_10v = False
        reportstart.SetStartTest(clickstart:=True)
        abortTests = False
        ResetAllVisibility()
        statoCollaudo.fsmTest = 1
        ChangeControlVisibility(StartEtsdn, False)
        ChangeControlVisibility(StopEtsdn, True)
    End Sub

    Private Delegate Sub ChangeControlTextDelegate(ByVal ctrl As Control, ByVal text As String)
    Private Sub ChangeControlText(ByVal ctrl As Control, ByVal text As String)
        If Me.InvokeRequired Then
            Try
                Me.Invoke(New ChangeControlTextDelegate(AddressOf ChangeControlText), New Object() {ctrl, text})
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try

            Return
        End If
        ctrl.Text = text
    End Sub

    Private Delegate Sub ChangeControlBackgroundColorDelegate(ByVal ctrl As Control, ByVal color As Color)
    Private Sub ChangeControlBackgroundColor(ByVal ctrl As Control, ByVal color As Color)
        If Me.InvokeRequired Then
            Me.Invoke(New ChangeControlBackgroundColorDelegate(AddressOf ChangeControlBackgroundColor), New Object() {ctrl, color})
            Return
        End If
        ctrl.BackColor = color
    End Sub

    Private Delegate Sub ChangeControlVisibilityDelegate(ByVal ctrl As Control, ByVal visible As Boolean)
    Private Sub ChangeControlVisibility(ByVal ctrl As Control, ByVal visible As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New ChangeControlVisibilityDelegate(AddressOf ChangeControlVisibility), New Object() {ctrl, visible})
            Return
        End If
        ctrl.Visible = visible

    End Sub

    Private Delegate Sub ChangeControlValueDelegate(ByVal ctrl As ProgressBar, ByVal value As Integer)
    Private Sub ChangeControlBarValue(ByVal ctrl As ProgressBar, ByVal value As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New ChangeControlValueDelegate(AddressOf ChangeControlBarValue), New Object() {ctrl, value})
            Return
        End If
        ctrl.Value = value
    End Sub

    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Enum ProgressBarColor
        Green = &H1
        Red = &H2
        Yellow = &H3
    End Enum

    Private Delegate Sub ChangeProgBarColorDelegate(ByVal ProgressBar_name As Windows.Forms.ProgressBar, ByVal ProgressBar_Color As ProgressBarColor)
    Private Sub ChangeBarColor(ByVal ProgressBar_name As Windows.Forms.ProgressBar, ByVal ProgressBar_Color As ProgressBarColor)
        If Me.InvokeRequired Then
            Me.Invoke(New ChangeProgBarColorDelegate(AddressOf ChangeBarColor), New Object() {ProgressBar_name, ProgressBar_Color})
            Return
        End If
        SendMessage(ProgressBar_name.Handle, &H410, ProgressBar_Color, 0)
    End Sub
    Sub Wait(ByVal millisecondi As Integer, Optional showWait As Boolean = False)

        System.Threading.Thread.Sleep(millisecondi)
    End Sub
    Function ProgressBarIncrease()
        If statoCollaudo.fsmTest <> 0 Then
            ChangeControlBarValue(BarTestEtsdn, statoCollaudo.fsmTest * 10)
        Else
            ChangeControlBarValue(BarTestEtsdn, 60)
        End If
    End Function

    Function UpdateValue()
        ChangeControlText(Amps, varETSDN.rSupplyVoltageEtsdn / 10)
        ChangeControlText(OUT5V, varETSDN.plc5V / 10)
        ChangeControlText(TestingSerial, varETSDN.etsdnSN)
        log.serialdevice = TestingSerial.Text
        ProgressBarIncrease()
    End Function

    Function CheckCommunication()
        'If varETSDN.timerComunicationCan.ElapsedMilliseconds > 1000 Then
        '    varETSDN.timerComunicationCan.Reset()
        '    MsgBox("Nessuna comunicazione con il collaudatore", MsgBoxStyle.Critical)
        'Else
        'If Not varETSDN.etsdnOnline > 0 Then
        '    MsgBox("Nessuna comunicazione con ETSDN", MsgBoxStyle.Exclamation)
        'End If
        'End If

    End Function

    Sub MyBackgroundThreadETSDN()
        Dim timValidation As New Stopwatch
        timValidation.Restart()

        While statoCollaudo.RequestToStopTest = False

            ScanParseMsg()
            UpdateValue()
            canEtsdnVar.SendCmdToEtsdn(varTxEtsdn.MsgComposer(), 20)
            'If varETSDN.timerComunicationCan.ElapsedMilliseconds > 1000 Then

            If varETSDN.etsdnOnline Then
                ChangeControlVisibility(StatoTestCAN, True)
                ChangeControlVisibility(ErrorTestCAN, False)
                ChangeControlVisibility(GifCan, True)
            Else
                ChangeControlVisibility(StatoTestCAN, False)
                ChangeControlVisibility(ErrorTestCAN, True)
                ChangeControlVisibility(GifCan, False)
            End If
            'End If


            Select Case statoCollaudo.fsmTest

                Case 0
                    timValidation.Restart()
                    statoCollaudo.ResetAllStatus()
                Case 1
                    If CheckPWR.Checked And Not abortTests Then
                        If Not statoCollaudo.testPWRsuccess And (timValidation.ElapsedMilliseconds <= 5000) Then
                            ChangeControlVisibility(LoadingPWR, True)
                            AvviotestAlimetazione()
                            If statoCollaudo.testPWRcompleted Then
                                statoCollaudo.testPWRsuccess = True
                            End If
                        Else
                            ChangeControlVisibility(LoadingPWR, False)
                            If statoCollaudo.testPWRsuccess Then
                                ChangeControlVisibility(StatoTestAlimentazione, True)
                            Else
                                ChangeControlVisibility(ErrorTestPWR, True)
                            End If
                            statoCollaudo.fsmTest += 1
                            timValidation.Restart()
                        End If
                    Else
                        statoCollaudo.fsmTest += 1
                        timValidation.Restart()
                    End If
                    reportPwr.SetResultTest("●TEST POWER", CheckPWR.Checked, statoCollaudo.testPWRsuccess)


                Case 2
                    If CheckRL.Checked And Not abortTests Then
                        If Not statoCollaudo.testRLsuccess And (timValidation.ElapsedMilliseconds <= 15000) Then
                            ChangeControlVisibility(LoadingRL, True)
                            AvvioTestRele()
                            If statoCollaudo.testRLcompleted Then
                                statoCollaudo.testRLsuccess = True
                            End If
                        Else
                            ChangeControlVisibility(LoadingRL, False)
                            If statoCollaudo.testRLsuccess Then
                                ChangeControlVisibility(StatotestRele, True)
                            Else
                                ChangeControlVisibility(ErrorTestRL, True)
                            End If
                            statoCollaudo.fsmTest += 1
                            timValidation.Restart()
                        End If
                    Else
                        statoCollaudo.fsmTest += 1
                        timValidation.Restart()
                    End If
                    reportRl.SetResultTest("●TEST RELE", CheckRL.Checked, statoCollaudo.testRLsuccess)

                Case 3
                    If CheckIP.Checked And Not abortTests Then
                        If Not statoCollaudo.testIngressiSuccess And (timValidation.ElapsedMilliseconds <= 15000) Then
                            ChangeControlVisibility(LoadingIP, True)
                            AvvioTestIngressi()
                            If statoCollaudo.testIngressiCompleted Then
                                statoCollaudo.testIngressiSuccess = True
                            End If
                        Else
                            ChangeControlVisibility(LoadingIP, False)
                            If statoCollaudo.testIngressiSuccess Then
                                ChangeControlVisibility(StatoTestIngressi, True)
                            Else
                                ChangeControlVisibility(ErrorTestIP, True)
                                varTxEtsdn.SetState10V(0)
                                varTxEtsdn.SetState5V(0)
                                statoCollaudo.stepIP = 0
                                If ANA5V_NOT.Visible = True Then
                                    reportAna.SetResultANA1(pass:=False, comment:=" Error value: Irregular progress")
                                End If
                                If ANA10V_NOT.Visible = True Then
                                    reportAna.SetResultANA2(pass:=False, comment:=" Error value: Irregular progress")
                                End If
                            End If
                            statoCollaudo.fsmTest += 1
                            timValidation.Restart()
                        End If
                    Else
                        statoCollaudo.fsmTest += 1
                        timValidation.Restart()
                    End If
                    reportIp.SetResultTest("●TEST INGRESSI/ANALOGICI", CheckIP.Checked, statoCollaudo.testIngressiSuccess)

                Case 4
                    If Check5V.Checked And Not abortTests Then
                        If Not statoCollaudo.test5Vsuccess And (timValidation.ElapsedMilliseconds <= 6000) Then
                            ChangeControlVisibility(Loading5V, True)
                            AvvioTest5V()
                            If statoCollaudo.test5Vcompleted Then
                                statoCollaudo.test5Vsuccess = True
                            End If
                        Else
                            ChangeControlVisibility(Loading5V, False)
                            If statoCollaudo.test5Vsuccess Then
                                ChangeControlVisibility(StatoTest5V, True)
                            Else
                                ChangeControlVisibility(ErrorTest5V, True)
                            End If
                            statoCollaudo.fsmTest += 1
                            timValidation.Restart()
                            varTxEtsdn.SetStateCargo5V(0)
                            statoCollaudo.tmrCargo5v.Reset()
                        End If
                    Else
                        statoCollaudo.fsmTest += 1
                        timValidation.Restart()
                    End If
                    report5V.SetResultTest("●TEST 5V", Check5V.Checked, statoCollaudo.test5Vsuccess)

                Case 5
                    If CheckAcc.Checked And Not abortTests Then
                        If Not statoCollaudo.testACCsuccess And (timValidation.ElapsedMilliseconds <= 10000) Then
                            ChangeControlVisibility(LoadingAcc, True)
                            AvviotestAcc()
                            If statoCollaudo.testACCcompleted Then
                                statoCollaudo.testACCsuccess = True
                            End If
                        Else
                            ChangeControlVisibility(LoadingAcc, False)
                            If statoCollaudo.testACCsuccess Then
                                ChangeControlVisibility(StatoTestAccellerometro, True)
                            Else
                                ChangeControlVisibility(ErrorTestACC, True)
                                ChangeControlVisibility(MovimentoETSDN, False)
                                reportAcc.SetResulAcc(pass:=False)
                            End If
                            statoCollaudo.fsmTest += 1
                            timValidation.Restart()
                        End If
                    Else
                        statoCollaudo.fsmTest += 1
                        timValidation.Restart()
                    End If
                    reportAcc.SetResultTest("●TEST ACCELEROMETRO", CheckAcc.Checked, statoCollaudo.testACCsuccess)
                Case 6
                    statoCollaudo.fsmTest = 0
                    ChangeControlVisibility(StartEtsdn, True)
                    ChangeControlVisibility(StopEtsdn, False)
                    ErrorTestDevice()
                    log.WriteOnFile(reportInfo)
                    log.WriteOnFile(reportstart, reportInfo)
                    log.WriteOnFile(reportPwr, reportInfo)
                    log.WriteOnFile(reportRl, reportInfo)
                    log.WriteOnFile(reportIp, reportAna, reportInfo)
                    log.WriteOnFile(report5V, reportInfo)
                    log.WriteOnFile(reportAcc, reportInfo)
                    log.ExportFileData()
            End Select
        End While
        Console.WriteLine("close Form")

    End Sub

    Private Sub CheckTutti_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTutti.Click
        Dim b = CheckTutti.Checked

        CheckPWR.Checked = b
        CheckRL.Checked = b
        Check5V.Checked = b
        CheckAcc.Checked = b
        CheckIP.Checked = b
    End Sub


    Public Sub AvviotestAlimetazione()
        If (varETSDN.plcPowerCurr < 10) Or (varETSDN.plcPowerCurr > 600) Or
           (varETSDN.rSupplyVoltageEtsdn < varETSDN.plcEcuK15 - 10) Or (varETSDN.rSupplyVoltageEtsdn > varETSDN.plcEcuK15 + 10) Then

            statoCollaudo.testPWRcompleted = False
            ChangeControlVisibility(PWR_NOT, True)
            ChangeControlVisibility(PWR_OK, False)
            reportPwr.SetResultPwr(pass:=False, valueplc:=varETSDN.plcPowerCurr, value:=varETSDN.rSupplyVoltageEtsdn / 10,
                                    comment:=" (PowerETSDN must not be < 23,8 and >24,8)")
        Else
            statoCollaudo.testPWRcompleted = True
            reportPwr.SetResultPwr(pass:=True)
            ChangeControlVisibility(PWR_NOT, False)
            ChangeControlVisibility(PWR_OK, True)
        End If
    End Sub

    Public Sub AvvioTestRele()

        ChangeControlText(LabelRL1, varETSDN.vCurrentRL1)
        ChangeControlText(LabelRL2, varETSDN.vCurrentRL2)
        ChangeControlText(LabelRL3, varETSDN.vCurrentRL3)
        Select Case statoCollaudo.StepRele
            Case 0
                varTxEtsdn.SetStateAllRl(0)
                varTxEtsdn.SetAllPwrRL(1)
                statoCollaudo.StepRele += 1
                statoCollaudo.timerRele.Restart()
            Case 1

                If Not varETSDN.vCurrentRL1 > 5 And Not varETSDN.vCurrentRL2 > 15 And Not varETSDN.vCurrentRL3 > 5 Then
                    statoCollaudo.StepRele += 1
                    varTxEtsdn.SetStateRL1(1)
                Else
                End If
            Case 2
                If Not RL1_OK.Visible = True Then
                    If varETSDN.vCurrentRL1 > 450 And varETSDN.vCurrentRL1 < 510 Then 'da modificare in base alla resistenza 
                        ChangeControlVisibility(RL1_OK, True)
                        varTxEtsdn.SetStateRL1(0)
                        varTxEtsdn.SetStateRL2(1)

                        statoCollaudo.StepRele += 1
                        statoCollaudo.timerRele.Restart()
                        reportRl.SetResultRL1(pass:=True)

                    ElseIf statoCollaudo.timerRele.ElapsedMilliseconds >= 3000 Then
                        ChangeControlVisibility(RL1_NOT, True)
                        varTxEtsdn.SetStateRL1(0)
                        varTxEtsdn.SetStateRL2(1)

                        statoCollaudo.StepRele += 1
                        statoCollaudo.timerRele.Restart()
                        reportRl.SetResultRL1(pass:=False, value:=varETSDN.vCurrentRL1, comment:="  (Must be > 450 and < 510)")
                    End If
                End If

            Case 3
                If Not RL2_OK.Visible = True Then
                    If varETSDN.vCurrentRL2 > 450 And varETSDN.vCurrentRL2 < 510 Then
                        ChangeControlVisibility(RL2_OK, True)
                        varTxEtsdn.SetStateRL2(0)
                        varTxEtsdn.SetStateRL3(1)

                        statoCollaudo.StepRele += 1
                        statoCollaudo.timerRele.Restart()
                        reportRl.SetResultRL2(pass:=True)

                    ElseIf statoCollaudo.timerRele.ElapsedMilliseconds >= 3000 Then
                        ChangeControlVisibility(RL2_NOT, True)
                        varTxEtsdn.SetStateRL2(0)
                        varTxEtsdn.SetStateRL3(1)

                        statoCollaudo.StepRele += 1
                        statoCollaudo.timerRele.Restart()
                        reportRl.SetResultRL2(pass:=False, value:=varETSDN.vCurrentRL2, comment:="  (Must be > 450 and < 510)")
                    End If
                End If

            Case 4
                If Not RL3_OK.Visible = True Then
                    If varETSDN.vCurrentRL3 > 450 And varETSDN.vCurrentRL3 < 510 Then
                        ChangeControlVisibility(RL3_OK, True)
                        varTxEtsdn.SetStateRL3(0)

                        statoCollaudo.StepRele += 1
                        statoCollaudo.timerRele.Restart()
                        reportRl.SetResultRL3(pass:=True)

                    ElseIf statoCollaudo.timerRele.ElapsedMilliseconds >= 3000 Then
                        ChangeControlVisibility(RL3_NOT, True)
                        varTxEtsdn.SetStateRL3(0)

                        statoCollaudo.StepRele += 1
                        statoCollaudo.timerRele.Restart()
                        reportRl.SetResultRL3(pass:=False, value:=varETSDN.vCurrentRL3, comment:="  (Must be > 450 and < 510)")
                    End If
                End If

            Case 5
                If RL1_OK.Visible And RL2_OK.Visible And RL3_OK.Visible Then
                    statoCollaudo.StepRele = 0
                    statoCollaudo.testRLcompleted = True
                    varTxEtsdn.SetAllPwrRL(0)
                    varTxEtsdn.SetStateAllRl(0)
                Else
                    statoCollaudo.StepRele = 0
                    varTxEtsdn.SetAllPwrRL(0)
                    varTxEtsdn.SetStateAllRl(0)
                End If
        End Select

        If abortTests Then
            varTxEtsdn.SetAllPwrRL(0)
            varTxEtsdn.SetStateAllRl(0)
        End If


    End Sub

    Public Sub AvvioTestIngressi()

        If statoCollaudo.testIPcompleted = False Then
            Select Case statoCollaudo.stepIP
                Case 0
                    varTxEtsdn.SetStateIP1(1)
                    statoCollaudo.timerIP.Restart()
                    statoCollaudo.timerANA.Start()
                    statoCollaudo.stepIP += 1
                Case 1
                    If varETSDN.xStatoIP1 <> varETSDN.xStatoIP2 And varETSDN.xStatoIP1 <> varETSDN.xStatoIN1 And varETSDN.xStatoIP1 <> varETSDN.xStatoIN2 Then
                        ChangeControlVisibility(IP1_OK, True)
                        ChangeControlVisibility(IP1_NOT, False)
                        reportIp.SetResultIP1(pass:=True)
                        varTxEtsdn.SetStateIP2(1)
                        varTxEtsdn.SetStateIP1(0)
                        statoCollaudo.timerIP.Restart()
                        statoCollaudo.stepIP += 1
                    ElseIf statoCollaudo.timerIP.ElapsedMilliseconds >= 1000 Then
                        ChangeControlVisibility(IP1_NOT, True)
                        ChangeControlVisibility(IP1_OK, False)
                        reportIp.SetResultIP1(pass:=False, comment:="  IP1 Must be = 1 and IP2 = 0 and IN1 = 0 and IN2 = 0" + Environment.NewLine,
                                             valIp1:=varETSDN.xStatoIP1, valIp2:=varETSDN.xStatoIP2, valIn1:=varETSDN.xStatoIN1, valIn2:=varETSDN.xStatoIN2)
                        varTxEtsdn.SetStateIP2(1)
                        varTxEtsdn.SetStateIP1(0)
                        statoCollaudo.stepIP += 1
                    End If
                Case 2
                    If varETSDN.xStatoIP2 <> varETSDN.xStatoIP1 And varETSDN.xStatoIP2 <> varETSDN.xStatoIN1 And varETSDN.xStatoIP2 <> varETSDN.xStatoIN2 Then
                        ChangeControlVisibility(IP2_OK, True)
                        ChangeControlVisibility(IP2_NOT, False)
                        reportIp.SetResultIP2(pass:=True)
                        varTxEtsdn.SetStateIN1(1)
                        varTxEtsdn.SetStateIP2(0)
                        statoCollaudo.timerIP.Restart()
                        statoCollaudo.stepIP += 1
                    ElseIf statoCollaudo.timerIP.ElapsedMilliseconds >= 1000 Then
                        ChangeControlVisibility(IP2_NOT, True)
                        ChangeControlVisibility(IP2_OK, False)
                        reportIp.SetResultIP2(pass:=False, comment:="  IP2 Must be = 1 and IP1 = 0 and IN1 = 0 and IN2 = 0" + Environment.NewLine,
                                             valIp1:=varETSDN.xStatoIP1, valIp2:=varETSDN.xStatoIP2, valIn1:=varETSDN.xStatoIN1, valIn2:=varETSDN.xStatoIN2)
                        varTxEtsdn.SetStateIN1(1)
                        varTxEtsdn.SetStateIP2(0)
                        statoCollaudo.stepIP += 1
                    End If
                Case 3
                    If varETSDN.xStatoIN1 <> varETSDN.xStatoIP1 And varETSDN.xStatoIN1 <> varETSDN.xStatoIP2 And varETSDN.xStatoIN1 <> varETSDN.xStatoIN2 Then
                        ChangeControlVisibility(IN1_OK, True)
                        ChangeControlVisibility(IN1_NOT, False)
                        reportIp.SetResultIN1(pass:=True)
                        varTxEtsdn.SetStateIN2(1)
                        varTxEtsdn.SetStateIN1(0)
                        statoCollaudo.timerIP.Restart()
                        statoCollaudo.stepIP += 1
                    ElseIf statoCollaudo.timerIP.ElapsedMilliseconds >= 1000 Then
                        ChangeControlVisibility(IN1_NOT, True)
                        ChangeControlVisibility(IN1_OK, False)
                        reportIp.SetResultIN1(pass:=False, comment:="  IN1 Must be = 1 and IP1 = 0 and IP2 = 0 and IN2 = 0" + Environment.NewLine,
                                             valIp1:=varETSDN.xStatoIP1, valIp2:=varETSDN.xStatoIP2, valIn1:=varETSDN.xStatoIN1, valIn2:=varETSDN.xStatoIN2)
                        varTxEtsdn.SetStateIN2(1)
                        varTxEtsdn.SetStateIN1(0)
                        statoCollaudo.stepIP += 1
                    End If
                Case 4
                    If varETSDN.xStatoIN2 <> varETSDN.xStatoIP1 And varETSDN.xStatoIN2 <> varETSDN.xStatoIP2 And varETSDN.xStatoIN2 <> varETSDN.xStatoIN1 Then
                        ChangeControlVisibility(IN2_OK, True)
                        ChangeControlVisibility(IN2_NOT, False)
                        reportIp.SetResultIN2(pass:=True)
                        varTxEtsdn.SetStateIN2(0)
                        statoCollaudo.timerIP.Restart()
                        statoCollaudo.stepIP += 1
                    ElseIf statoCollaudo.timerIP.ElapsedMilliseconds >= 1000 Then
                        ChangeControlVisibility(IN2_NOT, True)
                        ChangeControlVisibility(IN2_OK, False)
                        reportIp.SetResultIN2(pass:=False, comment:="  IN2 Must be = 1 and IP1 = 0 and IP2 = 0 and IN1 = 0" + Environment.NewLine,
                                             valIp1:=varETSDN.xStatoIP1, valIp2:=varETSDN.xStatoIP2, valIn1:=varETSDN.xStatoIN1, valIn2:=varETSDN.xStatoIN2)
                        varTxEtsdn.SetStateIN2(0)
                        statoCollaudo.stepIP += 1
                    End If
                Case 5
                    If IP1_OK.Visible = True And IP2_OK.Visible = True And IN1_OK.Visible = True And IN2_OK.Visible = True Then
                        statoCollaudo.testIPcompleted = True
                        statoCollaudo.stepIP = 0
                    Else
                        statoCollaudo.stepIP = 0
                        statoCollaudo.timerIP.Restart()
                    End If
            End Select
        End If


        varTxEtsdn.SetState10V(1)
        varTxEtsdn.SetState5V(1)

        ChangeControlText(ANAVolt5, varETSDN.rANA5.ToString / 1000)
        ChangeControlText(ANAVolt10, varETSDN.rANA10.ToString / 1000)

        If varETSDN.end_test_5v And varETSDN.end_test_10v Then

            If varETSDN.result_test_5v = 0 Then
                ChangeControlVisibility(ANA5V_OK, True)
            Else
                ChangeControlVisibility(ANA5V_NOT, True)
            End If

            If varETSDN.result_test_10v = 0 Then
                ChangeControlVisibility(ANA10V_OK, True)
            Else
                ChangeControlVisibility(ANA10V_NOT, True)
            End If

        End If

        If statoCollaudo.testIPcompleted And ANA5V_OK.Visible And ANA10V_OK.Visible Then
            statoCollaudo.testIngressiCompleted = True
            reportAna.SetResultANA1(pass:=True)
            reportAna.SetResultANA2(pass:=True)
            varTxEtsdn.SetState10V(0)
            varTxEtsdn.SetState5V(0)
        End If


    End Sub
    Public Sub AvvioTest5V()
        statoCollaudo.tmrCargo5v.Start()

        If varETSDN.xState_Gnd_5v Then
            varTxEtsdn.SetStateCargo5V(1)

            If Not varETSDN.plc5V > 51 And Not varETSDN.plc5V < 49 And statoCollaudo.tmrCargo5v.ElapsedMilliseconds > 5000 Then
                statoCollaudo.test5Vsuccess = True
                ChangeControlVisibility(OUT5V_OK, True)
                ChangeControlVisibility(OUT5V_NOT, False)
                report5V.SetResult5V(OUT5V_OK.Visible, value:=varETSDN.plc5V.ToString / 10)
                varTxEtsdn.SetStateCargo5V(0)
            Else
                ChangeControlVisibility(OUT5V_NOT, True)
                ChangeControlVisibility(OUT5V_OK, False)
                report5V.SetResult5V(pass:=False, comment:=" Value of 5V must not be > 5,1 and < 4,9 ", value:=varETSDN.plc5V.ToString / 10)
            End If
        Else
            report5V.SetResult5V(pass:=False, comment:="Error on pin GND of 5v, the value must be 1 ", value:=varETSDN.xState_Gnd_5v.ToString / 10)
        End If
    End Sub

    Public Sub AvviotestCAN()

        statoCollaudo.testCANsuccess = True

    End Sub

    Public Sub AvviotestAcc()

        ChangeControlText(accZ, "Z= " & Math.Round(varETSDN.axisZ, 3, MidpointRounding.AwayFromZero))
        ChangeControlText(accY, "Y= " & Math.Round(varETSDN.axisY, 3, MidpointRounding.AwayFromZero))
        ChangeControlText(accX, "X= " & Math.Round(varETSDN.axisX, 3, MidpointRounding.AwayFromZero))

        Select Case statoCollaudo.stepAcc
            Case 0
                ChangeControlVisibility(ETSDN_Statico, True)
                ChangeControlText(MsgTestAcc, "Posizionare ETSDN come in figura")
                If (varETSDN.axisZ > 1 - statoCollaudo.rAccTolerance And varETSDN.axisZ < 1 + statoCollaudo.rAccTolerance) And
                   (varETSDN.axisY > -statoCollaudo.rAccTolerance And varETSDN.axisY < statoCollaudo.rAccTolerance) And
                   (varETSDN.axisX > -statoCollaudo.rAccTolerance And varETSDN.axisX < statoCollaudo.rAccTolerance) Then
                    statoCollaudo.stepAcc += 1
                End If

            Case 1
                ChangeControlVisibility(ETSDN_Statico, False)
                ChangeControlVisibility(MovimentoETSDN, True)
                ChangeControlText(MsgTestAcc, "Inclina ETSDN come in figura")
                If (varETSDN.axisY > -1 - statoCollaudo.rAccTolerance And varETSDN.axisY < -1 + statoCollaudo.rAccTolerance) And
                   (varETSDN.axisZ > -statoCollaudo.rAccTolerance And varETSDN.axisZ < statoCollaudo.rAccTolerance) And
                   (varETSDN.axisX > -statoCollaudo.rAccTolerance And varETSDN.axisX < statoCollaudo.rAccTolerance) Then
                    statoCollaudo.stepAcc += 1
                End If

            Case 2
                statoCollaudo.testACCsuccess = True
                ChangeControlVisibility(MovimentoETSDN, False)
                reportAcc.SetResulAcc(pass:=True)
                statoCollaudo.stepAcc = 0
                ChangeControlText(MsgTestAcc, "")
        End Select

    End Sub

    Private Sub OpenLog_Click(sender As Object, e As EventArgs) Handles OpenLog.Click
        Process.Start(Application.StartupPath + "\\Log\\Etsdn\\LogPDF\\")
    End Sub

    Private Sub ErrorInfo_Click(sender As Object, e As EventArgs) Handles ErrorInfo.Click
        Process.Start(Application.StartupPath + "\\Log\\gestioneErrori.txt")
    End Sub

    Private Sub ButtonErrorView_Click(sender As Object, e As EventArgs) Handles ButtonErrorView.Click
        Dim readFile As TextReader = New StreamReader(Application.StartupPath + "\\Log\\Etsdn\\LogPDF\\" + varETSDN.etsdnSN + ".pdf")
        readFile.Close()
        Process.Start(Application.StartupPath + "\\Log\\Etsdn\\LogPDF\\" + varETSDN.etsdnSN + ".pdf")
    End Sub
End Class

Class StatoTestCollaudo

    Public fsmTest = 0
    Public RequestToStopTest = False
    Public IPstato = 0
    Public StepRele = 0
    Public testPWRsuccess = False
    Public testRLsuccess = False
    Public testIPsuccess = False
    Public testANAsucces = False
    Public test5Vsuccess = False
    Public testCANsuccess = False
    Public testACCsuccess = False
    Public MsgCanPLC = 0
    Public testPWRcompleted = False
    Public testRLcompleted = False
    Public testIPcompleted = False
    Public testIngressiCompleted = False
    Public testIngressiSuccess = False
    Public test5Vcompleted = False
    Public testCANcompleted = False
    Public testACCcompleted = False
    Public stepAcc = 0
    Public stepIP = 0
    Public cFailANA10 = 0
    Public cFailANA5 = 0
    Public rAccTolerance = 0.3
    Public asseY = False
    Public asseZ = False
    Public OldSerialDevice As String
    Public timerRele As New Stopwatch
    Public timerIP As New Stopwatch
    Public timerANA As New Stopwatch
    Public timerIn5V As New Stopwatch
    Public tmrCargo5v As New Stopwatch
    Public NameOperator = ""
    Public CheckCanCom As Boolean

    Public Sub ResetAllStatus()
        fsmTest = 0
        IPstato = 0
        StepRele = 0
        testPWRsuccess = False
        testRLsuccess = False
        testANAsucces = False
        test5Vsuccess = False
        testCANsuccess = False
        testACCsuccess = False
        MsgCanPLC = 0
        cFailANA10 = 0
        cFailANA5 = 0
        rAccTolerance = 0.3
        asseY = False
        asseZ = False
        testPWRcompleted = False
        testRLcompleted = False
        testIPcompleted = False
        testIngressiCompleted = False
        testIngressiSuccess = False
        test5Vcompleted = False
        testCANcompleted = False
        testACCcompleted = False
        timerRele.Reset()
        timerRele.Reset()
        timerIP.Reset()
        timerANA.Reset()
        timerIn5V.Reset()

    End Sub
End Class

Public Class TestNotCompletedETSDN
    Inherits Exception

    Public Sub New()
    End Sub
    Public Sub New(message As String, inner As Exception)
        MyBase.New(message, inner)
    End Sub
End Class


Public Class ResultTestDoneETSDN

    Public nameOperator As String = "", dateNow As String, serialDevice As String = ""
    Public nameTest As String = "", checked As String = "", resultTest As String = "", comment As String = ""
    Public startTest As String = "", stoptest As String = ""

    Public Function SetResultTest(name As String, check As Boolean, result As Boolean)
        nameTest = name
        checked = " Checked: " & check
        resultTest = " Result test: " & result.ToString
    End Function

End Class

Public Class ReportTestPower
    Inherits ResultTestDoneETSDN

    Public testPwr As String = "", currentPlc As String = ""
    Public errorPwr As String = ""
    Public Sub SetResultPwr(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As Double = 0, Optional valueplc As Double = 0)

        If pass Then
            testPwr = " testPOWER: " + pass.ToString
        Else
            testPwr = " testPOWER: " + pass.ToString
            currentPlc = "  PlcCurrent: " + valueplc.ToString + " (must not be < 10 and > 600)"
            errorPwr = currentPlc + Environment.NewLine + "  PowerETSDN: " + value.ToString + comment
        End If
    End Sub
End Class

Public Class ReportTestRele
    Inherits ResultTestDoneETSDN
    Public testR1 As String = "", testR2 As String = "", testR3 As String = ""
    Public CurrentR1 As String = "", CurrentR2 As String = "", CurrentR3 As String = ""
    Public errorR1 As String = "", errorR2 As String = "", errorR3 As String = ""

    Public Sub SetResultRL1(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As Double = 0)
        If pass Then
            testR1 = " testR1: " + pass.ToString
        Else
            CurrentR1 = value
            testR1 = " testR1: " + pass.ToString
            errorR1 = "  Erorr value: " + CurrentR1 + comment
        End If
    End Sub
    Public Sub SetResultRL2(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As Double = 0)
        If pass Then
            testR2 = " testR2: " + pass.ToString
        Else
            CurrentR2 = value
            testR2 = " testR2: " + pass.ToString
            errorR2 = "  Erorr value: " + CurrentR2 + comment
        End If
    End Sub
    Public Sub SetResultRL3(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As Double = 0)
        If pass Then
            testR3 = " testR3: " + pass.ToString
        Else
            CurrentR3 = value
            testR3 = " testR3: " + pass.ToString
            errorR3 = "  Erorr value: " + CurrentR3 + comment
        End If
    End Sub
End Class

Public Class ReportTestInput
    Inherits ResultTestDoneETSDN
    Public testIP1 As String = "", testIP2 As String = "", testIN1 As String = "", testIN2 As String = ""
    Public errorIP1 As String = "", errorIP2 As String = "", errorIN1 As String = "", errorIN2 As String = ""

    Public Sub SetResultIP1(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional valIp1 As String = "",
                            Optional valIp2 As String = "", Optional valIn1 As String = "", Optional valIn2 As String = "")
        If pass Then
            testIP1 = " testIP1: " + pass.ToString
        Else
            testIP1 = " testIP1: " + pass.ToString
            errorIP1 = "  Error value: " & Environment.NewLine &
                        "  IP1=" & valIp1 + Environment.NewLine +
                        "  IP2=" + valIp2 + Environment.NewLine +
                        "  IN1=" + valIn1 + Environment.NewLine +
                        "  IN2=" + valIn2 + Environment.NewLine + comment
        End If
    End Sub

    Public Sub SetResultIP2(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional valIp1 As String = "",
                            Optional valIp2 As String = "", Optional valIn1 As String = "", Optional valIn2 As String = "")
        If pass Then
            testIP2 = " testIP2: " + pass.ToString
        Else
            testIP2 = " testIP2: " + pass.ToString
            errorIP2 = "  Error value: " + Environment.NewLine +
                        "  IP2=" + valIp2 + Environment.NewLine +
                        "  IP1=" + valIp1 + Environment.NewLine +
                        "  IN1=" + valIn1 + Environment.NewLine +
                        "  IN2=" + valIn2 + Environment.NewLine + comment

        End If
    End Sub
    Public Sub SetResultIN1(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional valIp1 As String = "",
                            Optional valIp2 As String = "", Optional valIn1 As String = "", Optional valIn2 As String = "")
        If pass Then
            testIN1 = " testIN1: " + pass.ToString
        Else
            testIN1 = " testIN1: " + pass.ToString
            errorIN1 = "  Error value: " + Environment.NewLine +
                       "  IN1=" + valIn1 + Environment.NewLine +
                       "  IP1=" + valIp1 + Environment.NewLine +
                       "  IP2=" + valIp2 + Environment.NewLine +
                       "  IN2=" + valIn2 + Environment.NewLine + comment
        End If
    End Sub
    Public Sub SetResultIN2(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional valIp1 As String = "",
                            Optional valIp2 As String = "", Optional valIn1 As String = "", Optional valIn2 As String = "")
        If pass Then
            testIN2 = " testIN2: " + pass.ToString
        Else
            testIN2 = " testIN2: " + pass.ToString
            errorIN2 = "  Error value: " + Environment.NewLine +
                      "  IN2=" + valIn2 + Environment.NewLine +
                      "  IP1=" + valIp1 + Environment.NewLine +
                      "  IP2=" + valIp2 + Environment.NewLine +
                      "  IN1=" + valIn1 + Environment.NewLine + comment
        End If
    End Sub


End Class

Public Class ReportTestAnalog
    Inherits ResultTestDoneETSDN
    Public testANA1 As String = "", testANA2 As String = ""
    Public errorANA1 As String = "", errorANA2 As String = ""
    Public Sub SetResultANA1(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As Double = 0)
        If pass Then
            testANA1 = " testANA1(5V): " + pass.ToString
        Else
            testANA1 = " testANA1(5V): " + pass.ToString
            errorANA1 = "  Error: " + comment
        End If
    End Sub
    Public Sub SetResultANA2(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As Double = 0)
        If pass Then
            testANA2 = " testANA2(10V) " + pass.ToString
        Else
            testANA2 = " testANA2(10V) " + pass.ToString
            errorANA2 = "  Error: " + comment
        End If
    End Sub
End Class

Public Class ReportTest5V
    Inherits ResultTestDoneETSDN
    Public test5V As String = "", value5V As String = "", error5V As String = ""

    Public Sub SetResult5V(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As String = "")
        If pass Then
            test5V = " test5V: " + pass.ToString
        Else
            test5V = " test5V: " + pass.ToString
            error5V = "  Erorr value: " + comment + value
        End If
    End Sub

End Class

Public Class ReportoTestAccelerometer
    Inherits ResultTestDoneETSDN
    Public testAcc As String = ""
    Public errorAcc As String = ""
    Public Sub SetResulAcc(Optional comment As String = "", Optional pass As Boolean = Nothing, Optional value As String = "")
        If pass Then
            testAcc = " testAccelerometer: " + pass.ToString
        Else
            testAcc = " testAccelerometer: " + pass.ToString
        End If
    End Sub

End Class

Public Class InfoEventTest
    Inherits ResultTestDoneETSDN
    Public buttonStart As String = "", buttonStop As String = ""
    Function SetStartTest(Optional clickstart As String = "", Optional time As String = "", Optional comment As String = "")

        buttonStart = "Button Start: " + clickstart.ToString + " (" + Date.Now.ToLongTimeString + ")" + Environment.NewLine

    End Function
    Function SetStopTest(Optional clickstop As String = "", Optional time As String = "", Optional comment As String = "")

        buttonStop = "Button Stop: " + clickstop.ToString + " (" + Date.Now.ToLongTimeString + ")" + Environment.NewLine

    End Function
End Class

Public Class ReportInfoTestEtsdn
    Public sn As String = "", dayn As String = "", line As String = "", namePortal As String = "", nameOperator As String = ""
    Function SetInfoTest(Optional serial As String = "", Optional day As String = "", Optional title As String = "", Optional portal As String = "",
                         Optional name As String = "")
        sn = serial.ToString
        dayn = day
        line = title.ToString
        namePortal = portal.ToString
        nameOperator = name.ToString
    End Function
End Class

Public Class WriteRepor
    Public path = Application.StartupPath & "\\log\\Etsdn\\"
    Public serialdevice As String

    Public Function WriteOnFile(a As ReportInfoTestEtsdn)
        Try
            Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)
            val.WriteLine(a.line)
            val.WriteLine(a.dayn)
            val.WriteLine(a.sn)
            val.WriteLine(a.nameOperator)
            val.Close()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

    End Function

    Public Function WriteOnFile(a As InfoEventTest, b As ReportInfoTestEtsdn)

        Try
            Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)

            If a.buttonStart.Contains(True) Then
                val.WriteLine(a.buttonStart)
                val.Close()
            Else
                val.WriteLine(a.buttonStop)
                val.Close()
            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function

    Public Function WriteOnFile(a As ReportTestPower, b As ReportInfoTestEtsdn)

        Try
            Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)

            If a.checked.Contains(True) Then
                If a.errorPwr = Nothing Or a.errorPwr = "" Then
                    val.WriteLine(a.nameTest, a.checked)
                    val.WriteLine(a.testPwr)
                    val.WriteLine(a.resultTest & Environment.NewLine)
                    val.Close()
                Else
                    val.WriteLine(a.nameTest, a.checked)
                    val.WriteLine(a.testPwr)
                    val.WriteLine(a.errorPwr)
                    val.WriteLine(a.resultTest & Environment.NewLine)
                    val.Close()
                End If
            Else
                val.WriteLine(a.nameTest & a.checked & Environment.NewLine)
                val.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function

    Public Function WriteOnFile(a As ReportTestRele, b As ReportInfoTestEtsdn)
        Try
            Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)
            If a.checked.Contains(True) Then
                val.WriteLine(a.nameTest, a.checked)
                val.WriteLine(a.testR1)
                val.WriteLine(a.errorR1)
                val.WriteLine(a.testR2)
                val.WriteLine(a.errorR2)
                val.WriteLine(a.testR3)
                val.WriteLine(a.errorR3)
                val.WriteLine(a.resultTest & Environment.NewLine)
                val.Close()
            Else
                val.WriteLine(a.nameTest & a.checked & Environment.NewLine)
                val.Close()
            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function

    Public Function WriteOnFile(a As ReportTestInput, b As ReportTestAnalog, c As ReportInfoTestEtsdn)
        Try
            Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)
            If a.checked.Contains(True) Then
                val.WriteLine(a.nameTest, a.checked)
                val.WriteLine(a.testIP1)
                val.WriteLine(a.errorIP1)
                val.WriteLine(a.testIP2)
                val.WriteLine(a.errorIP2)
                val.WriteLine(a.testIN1)
                val.WriteLine(a.errorIN1)
                val.WriteLine(a.testIN2)
                val.WriteLine(a.errorIN2)
                val.WriteLine(b.testANA1)
                val.WriteLine(b.testANA2)
                val.WriteLine(a.resultTest & Environment.NewLine)
                val.Close()
            Else
                val.WriteLine(a.nameTest & a.checked & Environment.NewLine)
                val.Close()
            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function

    Public Function WriteOnFile(a As ReportTest5V, b As ReportInfoTestEtsdn)
        Try
            Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)
            If a.checked.Contains(True) Then
                If a.error5V = Nothing Or a.error5V = "" Then
                    val.WriteLine(a.nameTest, a.checked)
                    val.WriteLine(a.test5V)
                    val.WriteLine(a.resultTest & Environment.NewLine)
                    val.Close()
                Else
                    val.WriteLine(a.nameTest, a.checked)
                    val.WriteLine(a.test5V)
                    val.WriteLine(a.error5V)
                    val.WriteLine(a.resultTest & Environment.NewLine)
                    val.Close()
                End If
            Else
                val.WriteLine(a.nameTest & a.checked & Environment.NewLine)
                val.Close()
            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function

    Public Function WriteOnFile(a As ReportoTestAccelerometer, b As ReportInfoTestEtsdn)
        Try
            Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)
            If a.checked.Contains(True) Then
                val.WriteLine(a.nameTest, a.checked)
                val.WriteLine(a.testAcc)
                val.WriteLine(a.resultTest & Environment.NewLine)
                val.Close()
            Else
                val.WriteLine(a.nameTest & a.checked & Environment.NewLine)
                val.Close()
            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function

    Public Function ExportFileData()

        Try
            Dim line As String
            Dim readFile As TextReader = New StreamReader(Application.StartupPath & "\\log\\Etsdn\\" & serialdevice)
            Dim yPoint As Integer = 0
            Dim pdf As PdfDocument = New PdfDocument
            pdf.Info.Title = "Text File to PDF"
            Dim pdfPage As PdfPage = pdf.AddPage()
            Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)
            Dim font As XFont = New XFont("Verdana", 10, XFontStyle.Regular)

            While True
                line = readFile.ReadLine
                If line Is Nothing Then
                    Exit While
                Else
                    graph.DrawString(line, font, XBrushes.Black,
                    New XRect(8.27, yPoint, pdfPage.Width.Inch, pdfPage.Height.Inch), XStringFormats.TopLeft)
                    yPoint = yPoint + 11.69
                    If yPoint = 840 Then
                        pdfPage = pdf.AddPage
                        graph = XGraphics.FromPdfPage(pdfPage)
                        yPoint = 0
                    End If
                End If
            End While

            Dim pdfFilename As String = Application.StartupPath & "\\log\\Etsdn\\LogPDF\\" & serialdevice & ".pdf"
            pdf.Save(pdfFilename)
            readFile.Close()
            readFile = Nothing

            'File.Delete(Application.StartupPath & "\\log\\Etsdn\\" & a.sn)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function



End Class



