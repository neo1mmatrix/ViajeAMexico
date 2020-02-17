Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Viaje a Mexico
        DateTimePicker1.Value = "19/10/2018 00:00:00"
        'Concierto de Melendi
        DateTimePicker1.Value = "11/05/2019 22:00:00"
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CalcularTiempo()
    End Sub

    Private Sub CalcularTiempo()
        Try

            'Guarda las fechas
            Dim _FechaLimite As Date = Date.Parse(DateTimePicker1.Value)
            Dim _FechaInicio As Date = Now

            'Almacena el Tiempo Restante
            Dim _DiasL As Long = 0
            Dim _HoraL As Long = 0
            Dim _MinutoL As Long = 0
            Dim _SegundoL As Long = 0

            'Representa el tiempo en letras
            Dim _Hora As String = ""
            Dim _Minuto As String = ""
            Dim _Segundo As String = ""

            _DiasL = DateDiff(DateInterval.Day, _FechaInicio, _FechaLimite)
            _FechaLimite = _FechaLimite.AddDays(-_DiasL)
            _HoraL = DateDiff(DateInterval.Hour, _FechaInicio, _FechaLimite)
            _FechaLimite = _FechaLimite.AddHours(-_HoraL)
            _MinutoL = DateDiff(DateInterval.Minute, _FechaInicio, _FechaLimite)
            _FechaLimite = _FechaLimite.AddMinutes(-_MinutoL)
            _SegundoL = DateDiff(DateInterval.Second, _FechaInicio, _FechaLimite)

            If _HoraL > 0 And _HoraL < 10 Then
                _Hora = "0" & _HoraL.ToString
            Else
                _Hora = _HoraL.ToString
            End If

            If _MinutoL > 0 And _MinutoL < 10 Then
                _Minuto = "0" & _MinutoL.ToString
            Else
                _Minuto = _MinutoL.ToString
            End If

            If _SegundoL > 0 And _SegundoL < 10 Then
                _Segundo = "0" & _SegundoL.ToString
            Else
                _Segundo = _SegundoL.ToString
            End If

            lbDias.Text = "Dias: " & _DiasL.ToString
            lbHoras.Text = "Horas: " & _Hora & ":" & _Minuto & ":" & _Segundo

        Catch ex As Exception
            MessageBox.Show("Invalid Date: " & ex.Message)
        End Try
    End Sub

    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick

    End Sub
End Class
