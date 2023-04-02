Module Module1
    Public db As New ADODB.Connection 'Variavel conexao de banco
    Public rs As New ADODB.Recordset 'variavel tabela
    Public sql As String 'query do CRUD leitura e escrita

    Sub conectar_banco()
        'tratamento de erro
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB; ")
        Catch ex As Exception

        End Try
    End Sub
End Module