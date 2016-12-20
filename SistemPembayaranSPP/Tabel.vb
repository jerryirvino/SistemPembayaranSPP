Imports System.Data.SqlClient
Public Class Tabel
    Private conn As SqlConnection
    Private dt As New DataTable()
    Private bs As New BindingSource()
    Private namaTabel As String

    Public Function getBs() As BindingSource '<-- metede public
        Return Me.bs
    End Function

    Public Function getDt() As DataTable
        Return Me.dt
    End Function

    Public Sub New(namaTabel As String) '<-- KonStruktor
        Me.namaTabel = namaTabel
        Me.conn = New SqlConnection(My.Settings.strConn)
        isiDataTable()
    End Sub

    Public Sub isiDataTable(strSql As String) '<-- metode public
        Me.conn.Open()
        Dim cmd As New SqlCommand(strSql, Me.conn)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        If Not Me.dt Is Nothing Then
            Me.dt.Clear()
        End If
        da.Fill(Me.dt)
        Me.conn.Close()
        Me.bs.DataSource = dt '<-- Struktur Data ditangani oleh BS
    End Sub

    Private Sub isiDataTable() '<-- metode private
        Me.conn.Open()
        Dim cmd As New SqlCommand("SELECT * FROM " & Me.namaTabel, Me.conn)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        If Not Me.dt Is Nothing Then
            Me.dt.Clear()
        End If
        da.Fill(Me.dt)
        Me.conn.Close()
        Me.bs.DataSource = dt '<-- Struktur Data ditangani oleh BS
    End Sub

    Public Function executeSQL(strSql As String) As Boolean
        Me.conn.Open()
        Dim cmd As New SqlCommand(strSql, Me.conn)
        Dim berhasil As Integer = cmd.ExecuteNonQuery()
        Me.conn.Close()
        If berhasil > 0 Then
            Me.isiDataTable()
        End If
        Return berhasil > 0
    End Function
End Class