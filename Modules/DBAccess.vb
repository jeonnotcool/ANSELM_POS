Imports System.Data.OleDb
Imports System.Data

Module DBAccess

    ' For development ONLY (replace with |DataDirectory| above before deployment):
    Private excelFile As String = "C:\Users\wooonotcool\OneDrive - GMGuillergan\Documents\02 Development\Programming\POSData.xlsx"

    Private connectionString As String = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={excelFile};Extended Properties='Excel 12.0 Xml;HDR=YES;'"

    Public Function GetProducts() As DataTable
        Dim dt As New DataTable()
        Using connection As New OleDbConnection(connectionString)
            Using adapter As New OleDbDataAdapter("SELECT * FROM [Products$]", connection)
                Try
                    connection.Open()
                    adapter.Fill(dt)
                Catch ex As Exception
                    ' IMPORTANT:  Don't just show a message box in a real application.
                    ' Log the error properly (to a file, event log, etc.).
                    MessageBox.Show("Error loading products: " & ex.Message & vbCrLf & ex.StackTrace, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Function GetUsers() As DataTable
        Dim dt As New DataTable()
        Using connection As New OleDbConnection(connectionString)
            Using adapter As New OleDbDataAdapter("SELECT * FROM [Users$]", connection)
                Try
                    connection.Open()
                    adapter.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("Error loading users: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Function ValidateLogin(username As String, password As String) As String
        Dim userRole As String = "" ' Initialize to an empty string (no role found)

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand("SELECT Role FROM [Users$] WHERE StrComp(Username, @Username, 0) = 0 AND StrComp(Password, @Password, 0) = 0", connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    connection.Open()
                    Dim reader As OleDbDataReader = command.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        userRole = reader("Role").ToString() ' Get the role
                    End If

                    reader.Close() ' Important to close the reader

                Catch ex As Exception
                    MessageBox.Show("Error during login: " & ex.Message & vbCrLf & ex.StackTrace, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' Consider logging the exception details here
                End Try
            End Using
        End Using

        Return userRole ' Return the role (or an empty string if login failed)
    End Function


    Public Function GetLastTransactionID() As Integer
        Dim lastID As Integer = 0 ' Default to 0 if not found
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand("SELECT LastTransactionID FROM [Settings$]", connection)
                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar() ' ExecuteScalar gets the first column of the first row
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        Integer.TryParse(result.ToString(), lastID) ' Safely convert to Integer
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error getting last transaction ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return lastID
    End Function

    Public Sub SetLastTransactionID(id As Integer)
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand("UPDATE [Settings$] SET LastTransactionID = @ID", connection)
                command.Parameters.AddWithValue("@ID", id)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error updating last transaction ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Public Function GenerateTransactionID() As String
        Dim lastID As Integer = GetLastTransactionID()
        Dim nextID As Integer = lastID + 1
        Return nextID.ToString("D6") ' Format as "000001", "000002", etc.
    End Function

    Public Function GetStock(productName As String) As Integer
        Dim stock As Integer = 0 ' Default to 0 if not found
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand("SELECT StockQuantity FROM [Products$] WHERE ProductName = @ProductName", connection)
                command.Parameters.AddWithValue("@ProductName", productName)
                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        stock = CInt(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error getting stock quantity: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return stock
    End Function

    Public Sub UpdateStock(productName As String, quantity As Integer)
        Try
            Dim oldStock As Integer = GetStock(productName) ' Get the stock before updating

            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using command As New OleDbCommand("UPDATE [Products$] SET StockQuantity = StockQuantity - ? WHERE ProductName = ?", connection)
                    command.Parameters.Add("?", OleDbType.Integer).Value = quantity
                    command.Parameters.Add("?", OleDbType.VarChar).Value = productName

                    Dim rowsAffected = command.ExecuteNonQuery() ' Execute the query and get the number of rows affected
                    If rowsAffected <= 0 Then
                        MessageBox.Show("No rows updated. Please check if the product name exists in the sheet.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                End Using
            End Using

            Dim newStock As Integer = GetStock(productName) ' Get the stock after updating

        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function LogPayment(paymentDetails As Dictionary(Of String, Object)) As Boolean
        Try
            Using connection As New OleDb.OleDbConnection(connectionString)
                connection.Open()
                Using command As New OleDb.OleDbCommand("INSERT INTO [Payments$] ([TransactionID], [PaymentMethod], [ReferenceNo], [CustomerNumber], [Date], [User]) VALUES (@TransactionID, @PaymentMethod, @ReferenceNo, @CustomerNumber, @Date, @User)", connection)

                    ' Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@TransactionID", paymentDetails("TransactionID"))
                    command.Parameters.AddWithValue("@PaymentMethod", paymentDetails("PaymentMethod"))
                    command.Parameters.AddWithValue("@ReferenceNo", paymentDetails("ReferenceNo"))
                    command.Parameters.AddWithValue("@CustomerNumber", paymentDetails("CustomerNumber"))
                    command.Parameters.AddWithValue("@Date", DateTime.Parse(paymentDetails("Date"))) ' Ensure Date is formatted correctly
                    command.Parameters.AddWithValue("@User", paymentDetails("User"))

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error logging payment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



    Public Function SaveTransaction(transactionData As DataTable, totalAmount As Decimal, amountReceived As Decimal, change As Decimal, username As String, transactionID As String) As Boolean
        Dim success As Boolean = False
        Dim transactionDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            ' Start a transaction
            Dim transaction As OleDbTransaction = connection.BeginTransaction()

            Try
                For Each row As DataRow In transactionData.Rows
                    Dim productName As String = row("colProductName").ToString()
                    Dim quantity As Integer = CInt(row("colQuantity"))
                    Dim price As Decimal = CDec(row("colPrice"))
                    Dim subtotal As Decimal = CDec(row("colSubtotal"))

                    Dim cmd As New OleDbCommand("INSERT INTO [Transactions$] (TransactionID, TransactionDate, ProductName, Quantity, Price, Subtotal, TotalAmount, AmountReceived, Change, [User]) VALUES (@TransactionID, @TransactionDate, @ProductName, @Quantity, @Price, @Subtotal, @TotalAmount, @AmountReceived, @Change, @User)", connection)
                    cmd.Transaction = transaction ' Associate command with transaction

                    cmd.Parameters.AddWithValue("@TransactionID", transactionID)
                    cmd.Parameters.AddWithValue("@TransactionDate", transactionDate)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal)
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.Parameters.AddWithValue("@AmountReceived", amountReceived) ' Add amount received
                    cmd.Parameters.AddWithValue("@Change", change) ' Add change
                    cmd.Parameters.AddWithValue("@User", username) ' Add user

                    cmd.ExecuteNonQuery() ' Execute the INSERT statement
                Next

                transaction.Commit() ' Commit the entire transaction
                success = True

            Catch ex As Exception
                transaction.Rollback() ' Rollback if error occurs
                MessageBox.Show("Error saving transaction: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()

            End Try
        End Using

        Return success
    End Function

End Module