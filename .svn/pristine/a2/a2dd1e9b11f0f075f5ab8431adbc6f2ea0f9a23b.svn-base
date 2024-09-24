Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraGrid.Views.Grid


Public Class EdmSelectMgt

#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub InitPage()

        Try
            Dim TEMP2 As String = "*.Tif"
            Dim TEMP2_PATH As String = EdmPath.Fax & "IT\"

            ''생성된 이미지 확인
            'If GET_CREATE_TIF_FILENAME(TEMP2_PATH, TEMP2) = False Then
            '    'TEMP2_PATH = EdmFaxPath & "OUTBOX\"
            '    'If GET_CREATE_TIF_FILENAME(TEMP2_PATH, TEMP2) = False Then
            '    MsgBox("이미지가 생성되지 않았습니다.")
            '    Exit Sub
            '    'End If
            'End If
            ''==================
            Dim MyName As String = "*.Tif"
            If GetCreateTifFileName(EdmPath.Fax & "IT\", MyName) = False Then
                MsgBox("이미지가 생성되지 않았습니다.")
                Exit Sub
            End If

            ImgThumbnail1.Image = TEMP2_PATH & TEMP2
            ImgEdit1.Image = TEMP2_PATH & TEMP2

            ImgEdit1.Page = 1
            ImgEdit1.Display()
            ImgEdit1.FitTo(1)
            ImgThumbnail1.SelectAllThumbs()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "=================Data logic actions==========="

#End Region

#Region "=================Control Events==========="
    Private Sub EdmSelectMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitPage()
    End Sub

    Private Sub ImgThumbnail1_MouseUpEvent(sender As System.Object, e As AxThumbnailLibCtl._DImgThumbnailEvents_MouseUpEvent) Handles ImgThumbnail1.MouseUpEvent
        Try
            If e.button = 2 Then
                If ImgThumbnail1.get_ThumbSelected(e.thumbNumber) = True Then
                    ImgThumbnail1.set_ThumbSelected(e.thumbNumber, False)
                Else
                    ImgThumbnail1.set_ThumbSelected(e.thumbNumber, True)
                End If
            Else
                ImgThumbnail1.DeselectAllThumbs()
                ImgThumbnail1.set_ThumbSelected(e.thumbNumber, True)
            End If
            ImgEdit1.Page = e.thumbNumber
            ImgEdit1.Refresh()
            ImgEdit1.Display()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If ImgThumbnail1.SelectedThumbCount = 0 Then
                MsgBox("적어도 하나의 페이지는 선택해야 합니다.")
                Exit Sub
            End If


            Dim iPagesDeleted As Integer
            Dim TotalThumbs As Integer
            Dim I As Integer
            Dim ThumbsToDelete As Integer
            'Dim ThumbCount As Integer
            iPagesDeleted = 0
            ThumbsToDelete = ImgThumbnail1.SelectedThumbCount  'Get # of selected thumbnails
            TotalThumbs = ImgThumbnail1.ThumbCount


            'Loop until a selected thumbnail is encountered - delete it. Must
            'reset the loop because the thumbcount has changed as well as the
            'index of the next selected thumbnail
            Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
            EdmImgAdmin.CreateControl()
            EdmImgAdmin.Image = ImgEdit1.Image
            For I = ImgThumbnail1.ThumbCount To 1 Step -1
                If ImgThumbnail1.get_ThumbSelected(I) = False Then
                    ImgEdit1.ClearDisplay()
                    EdmImgAdmin.DeletePages(I, 1)  'Must delete pages from
                    'image file first
                    ImgThumbnail1.DeleteThumbs(I, 1)
                    iPagesDeleted = iPagesDeleted + 1
                End If
            Next I
        Catch ex As Exception
            Throw ex
        End Try

        Me.Close()
    End Sub
#End Region







End Class




