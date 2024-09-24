Option Explicit On
Option Strict On
Imports System.Windows.Forms.Form

''' <summary>
''' Dialog class with a ProgressBar widget to 
''' show the progress of a long running task
''' </summary>
''' <remarks></remarks>
Public Class ProgressDialog
    Inherits Form

    ''' <summary>
    ''' Delegate to update the progress 
    ''' of the ProgressBar widget
    ''' </summary>
    ''' <param name="progress">Progress value</param>
    ''' <remarks></remarks>
    Delegate Sub DelegateUpdate(ByVal progress As Integer)
    ''' <summary>
    ''' Delegate to handle the Close event 
    ''' for this dialog
    ''' </summary>
    ''' <param name="dialog"></param>
    ''' <remarks></remarks>
    Delegate Sub DelegateClose(ByRef dialog As Form)

    ''' <summary>
    ''' Default constructor which initializes 
    ''' this control
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
    End Sub


    ''' <summary>
    ''' Method to update the progress bar widget. This 
    ''' uses the InvokeRequired and BeginInvoke methods
    ''' </summary>
    ''' <param name="progress">Progress value</param>
    ''' <remarks></remarks>
    Public Sub UpdateProgress(ByVal progress As Integer)
    End Sub

    ''' <summary>
    ''' Overloads the Close method
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub Close()
        If Me.InvokeRequired Then
            Me.BeginInvoke(New  _
                           DelegateClose(AddressOf CloseDelegateImpl), Me)
        Else
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' Implementation of the DelegateUpdate
    ''' </summary>
    ''' <param name="progress"></param>
    ''' <remarks></remarks>
    Sub UpdateDelegateImpl(ByVal progress As Integer)
        'ProgressBar1.Value = progress
        'LabelProgress.Text = ""
        'LabelProgress.Text = progress & CStr("%")
    End Sub
    ''' <summary>
    ''' Implmentation of the DelegateClose
    ''' </summary>
    ''' <param name="dialog"></param>
    ''' <remarks></remarks>
    Sub CloseDelegateImpl(ByRef dialog As Form)
        dialog.Close()
    End Sub

End Class
