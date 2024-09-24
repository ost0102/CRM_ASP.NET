Imports BankMarcro.Common
Imports BankMarcro

Class MacroLogic

    Public Sub Bank()

        If RunProcess = True Then
            Exit Sub
        End If 

        WriteLog("메크로를 시작합니다.")

        Common.RunProcess = True
        MainForm.WriteText(MainForm.LastRun, Now.ToString("yyyy-MM-dd"))
        MainForm.DeleteTxtLog()
        MainForm.DeleteFile()

        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "iexplore" Then
                prog.Kill()
            End If
        Next

        Dim Result As Boolean = False
        Dim FileName As String = ""
        Try
            WriteLog("인터넷 창을 오픈합니다.")
            ' Shell("C:\Program Files\Internet Explorer\IEXPLORE.EXE " & MainForm.TextBox1.Text, AppWinStyle.MaximizedFocus)
            Process.Start("explorer.exe", MainForm.TextBox1.Text)

            Threading.Thread.Sleep(MainForm.DelayTime.Text * 1000)

            WriteLog(MainForm.DelayTime.Text & " 초 대기.")


            '========================================================
            FileName = "스크롤하단"
            WriteLog(FileName & " 찾기를 시도합니다.")
            Result = BaseAction(FileName, 2000, 0, 0, False)
            If Result = False Then
                WriteLog(FileName & " 찾기 실패")
                Threading.Thread.Sleep(60000)
                Exit Try
                ' End If 
            End If
            WriteLog(FileName & " 찾기 완료했습니다.")

            Threading.Thread.Sleep(1000)
            MouseClick()
            Threading.Thread.Sleep(1000)
            MouseClick()


            Threading.Thread.Sleep(3000)
            '========================================================
            FileName = "현재"
            WriteLog(FileName & " 찾기를 시도합니다.")
            Result = BaseAction(FileName, 2000, 0, 0, False)

            If Result = False Then
                WriteLog(FileName & " 찾기 실패")
                Threading.Thread.Sleep(60000)
                Exit Try
                ' End If 
            End If
            WriteLog(FileName & " 찾기 완료했습니다.")
            '========================================================
            '///////////////////////////////////////////////////////

            Threading.Thread.Sleep(1000)
            SetCursorPos(MainForm.LastCursorPointX, MainForm.LastCursorPointY - 20)
            MouseClick()

            Threading.Thread.Sleep(1000)
            SetCursorPos(MainForm.LastCursorPointX, MainForm.LastCursorPointY - 20)
            MouseClick()



            '======================================================== 
            FileName = "조회"
            WriteLog(FileName & " 찾기 시도합니다.")
            Result = BaseAction(FileName, 2000, 0, 0, False)

            If Result = False Then
                WriteLog(FileName & " 찾기 실패")
                Threading.Thread.Sleep(60000)
                Exit Try
                '  End If  
            End If

            WriteLog(FileName & " 찾기 완료했습니다.")
            Threading.Thread.Sleep(2000)

            '========================================================
            '///////////////////////////////////////////////////////


            '======================================================== 
            FileName = "고시1회차"
            WriteLog(FileName & " 찾기 시도합니다.")

            Result = BaseAction(FileName, 2000, 0, 0, False)

            If Result = False Then
                WriteLog(FileName & " 찾기 실패")
                Threading.Thread.Sleep(60000)
                Exit Try
                '  End If  
            End If
            WriteLog(FileName & " 찾기 완료했습니다.")
            '========================================================
            '///////////////////////////////////////////////////////



            '======================================================== 
            FileName = "텍스트로저장"
            WriteLog(FileName & " 찾기 시도합니다.")
            Result = BaseAction(FileName, 2000, 0, 0, False)

            If Result = False Then
                WriteLog(FileName & " 찾기 실패")
                Threading.Thread.Sleep(60000)
                Exit Try
                '  End If  
            End If
            WriteLog(FileName & " 찾기 완료했습니다.")

            '========================================================
            '///////////////////////////////////////////////////////



            '======================================================== 
            FileName = "저장"
            Result = BaseAction(FileName, 2000, 0, 0, False)

            If Result = False Then
                FileName = "저장1"
                WriteLog(FileName & " 찾기 시도합니다.")
                Result = BaseAction(FileName, 2000, 0, 0, False)

                If Result = False Then
                    WriteLog(FileName & " 찾기 실패")
                    Threading.Thread.Sleep(60000)
                    Exit Try
                End If
            End If

            Threading.Thread.Sleep(3000)

            WriteLog("다운받은 파일을 찾기 시도합니다.")
            Do While True
                Dim t As String = MainForm.GetExrateTxtPath
                If t <> "" Then
                    WriteLog("파일을 찾았습니다.")
                    Exit Do
                Else
                    Threading.Thread.Sleep(1000)
                End If
            Loop
            WriteLog("다운받은 파일을 저장을 시도합니다.")
            MainForm.SaveExrate()

        Catch ex As Exception
            WriteLog(ex.Message)
        End Try
        RunProcess = False
    End Sub

End Class
