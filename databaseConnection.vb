Imports System.Net.Http
Imports System.Text.Json
Imports System.Data.SQLite
Imports Newtonsoft.Json.Linq

Module databaseConnection

    Public symptomName As String
    Public Function APISymptoms()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim connection As New SQLiteConnection(connectionString)

        connection.Open()

        Dim apiUrl As String = "https://healthservice.priaid.ch/symptoms?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzg4Nzg3LCJuYmYiOjE2OTc3ODE1ODd9.Ea4J559wgRDYnuDnlk_M8Lrjd3sB_CiL6UYGV-9xMvI&format=json&language=en-gb" ' Example URL
        Dim client As New HttpClient()

        ' Make the GET request
        Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            Dim users As JsonDocument = JsonDocument.Parse(responseContent)


            For Each user As JsonElement In users.RootElement.EnumerateArray()
                symptomName = user.GetProperty("Name").GetString()
                Dim symptomID As Integer = user.GetProperty("ID").GetInt32()

                'to add value from api call to combo box
                'Home.cmbSymptoms.Items.Add(symptomName)

                'Insert Data into SQLite
                Dim query As String = $"INSERT INTO tblSymptoms (ID, Name) VALUES (@id, @name)"
                Dim command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@id", symptomID)
                command.Parameters.AddWithValue("@name", symptomName)
                command.ExecuteNonQuery()
            Next

        Else
            Console.WriteLine("Error: " & response.ReasonPhrase)
        End If

        Return 0
    End Function

    Public Function APIIssues()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim connection As New SQLiteConnection(connectionString)

        connection.Open()

        Dim apiUrl As String = "https://healthservice.priaid.ch/issues?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzg5MzM0LCJuYmYiOjE2OTc3ODIxMzR9.14gSbEPyFrL8xwpZGjizUnnZ8vDvKGwlGL-yLhzzwYo&format=json&language=en-gb"
        Dim client As New HttpClient()

        ' Make the GET request
        Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            Dim users As JsonDocument = JsonDocument.Parse(responseContent)


            For Each user As JsonElement In users.RootElement.EnumerateArray()
                Dim issuesName As String = user.GetProperty("Name").GetString()
                Dim issuesID As Integer = user.GetProperty("ID").GetInt32()

                'Insert Data into SQLite
                Dim query As String = $"INSERT INTO tblIssues (ID, Name) VALUES (@id, @name)"
                Dim command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@id", issuesID)
                command.Parameters.AddWithValue("@name", issuesName)
                command.ExecuteNonQuery()
            Next

        Else
            Console.WriteLine("Error: " & response.ReasonPhrase)
        End If

        Return 0
    End Function

    Public Function APIIssueSpecific()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim connection As New SQLiteConnection(connectionString)

        connection.Open()

        Dim apiUrl As String = "https://healthservice.priaid.ch/issues?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzg5MzM0LCJuYmYiOjE2OTc3ODIxMzR9.14gSbEPyFrL8xwpZGjizUnnZ8vDvKGwlGL-yLhzzwYo&format=json&language=en-gb"
        Dim client As New HttpClient()

        ' Make the GET request
        Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            Dim users As JsonDocument = JsonDocument.Parse(responseContent)


            For Each user As JsonElement In users.RootElement.EnumerateArray()
                Dim id As Integer = user.GetProperty("ID").GetInt32()

                apiUrl = "https://healthservice.priaid.ch/issues/" & id & "/info?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzg5NTU5LCJuYmYiOjE2OTc3ODIzNTl9.i4aFQZ-j0qZHeB7z-p3fB9oeG2IR5GuAdu1WjHYHZh8&format=json&language=en-gb"

                Dim client2 As New HttpClient()

                ' Make the GET request
                Dim response2 As HttpResponseMessage = client2.GetAsync(apiUrl).Result

                If response2.IsSuccessStatusCode Then
                    Dim responseContent2 As String = response2.Content.ReadAsStringAsync().Result
                    Dim users2 As JsonDocument = JsonSerializer.Deserialize(Of JsonDocument)(responseContent2)


                    Dim Description As String = users2.RootElement.GetProperty("Description").GetString()
                    Dim DescriptionShort As String = users2.RootElement.GetProperty("DescriptionShort").GetString()
                    Dim MedicalCondition As String = users2.RootElement.GetProperty("MedicalCondition").GetString()
                    Dim Name As String = users2.RootElement.GetProperty("Name").GetString()
                    Dim PossibleSymptoms As String = users2.RootElement.GetProperty("PossibleSymptoms").GetString()
                    Dim ProfName As String = users2.RootElement.GetProperty("ProfName").GetString()
                    Dim TreatmentDescription As String = users2.RootElement.GetProperty("TreatmentDescription").GetString()


                    'Insert Data into SQLite
                    Dim query As String = $"INSERT INTO tblIssueSpecific (Description, DescriptionShort, MedicalCondition, Name, PossibleSymptoms, ProfName, TreatmentDescription) VALUES (@Description, @DescriptionShort, @MedicalCondition, @Name, @PossibleSymptoms, @ProfName, @TreatmentDescription)"
                    Dim command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@Description", Description)
                    command.Parameters.AddWithValue("@DescriptionShort", DescriptionShort)
                    command.Parameters.AddWithValue("@MedicalCondition", MedicalCondition)
                    command.Parameters.AddWithValue("@Name", Name)
                    command.Parameters.AddWithValue("@PossibleSymptoms", PossibleSymptoms)
                    command.Parameters.AddWithValue("@ProfName", ProfName)
                    command.Parameters.AddWithValue("@TreatmentDescription", TreatmentDescription)
                    command.ExecuteNonQuery()

                End If
            Next

        Else
            Console.WriteLine("Error: " & response.ReasonPhrase)
        End If

        Return 0
    End Function

    Public Function APIBodyLocations()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim connection As New SQLiteConnection(connectionString)

        connection.Open()

        Dim apiUrl As String = "https://healthservice.priaid.ch/body/locations?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzk4NDYxLCJuYmYiOjE2OTc3OTEyNjF9.ZczOe4BDvDoURtp1SV4GkHvBNR5Gb08bQGLJyb7dPo0&format=json&language=en-gb"
        Dim client As New HttpClient()

        ' Make the GET request
        Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            Dim users As JsonDocument = JsonDocument.Parse(responseContent)


            For Each user As JsonElement In users.RootElement.EnumerateArray()
                Dim bodyLocationsID As Integer = user.GetProperty("ID").GetInt32()
                Dim bodyLocationName As String = user.GetProperty("Name").GetString()


                'Insert Data into SQLite
                Dim query As String = $"INSERT INTO tblBodyLocations (ID, Name) VALUES (@id, @name)"
                Dim command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@id", bodyLocationsID)
                command.Parameters.AddWithValue("@name", bodyLocationName)
                command.ExecuteNonQuery()
            Next

        Else
            Console.WriteLine("Error: " & response.ReasonPhrase)
        End If

        Return 0
    End Function

    Public Function APIBodyLocationSpecific()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim connection As New SQLiteConnection(connectionString)

        connection.Open()

        Dim apiUrl As String = "https://healthservice.priaid.ch/body/locations?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzk4NDYxLCJuYmYiOjE2OTc3OTEyNjF9.ZczOe4BDvDoURtp1SV4GkHvBNR5Gb08bQGLJyb7dPo0&format=json&language=en-gb"
        Dim client As New HttpClient()

        ' Make the GET request
        Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            Dim users As JsonDocument = JsonDocument.Parse(responseContent)


            For Each user As JsonElement In users.RootElement.EnumerateArray()
                Dim bodyLocationID As Integer = user.GetProperty("ID").GetInt32()

                apiUrl = "https://healthservice.priaid.ch/body/locations/" & bodyLocationID & "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzk4NjQ3LCJuYmYiOjE2OTc3OTE0NDd9.t2JqgLS98qurzL8Y74OzcdaL8YTPjOBfoKf1CjN5xfw&format=json&language=en-gb"

                Dim client2 As New HttpClient()

                ' Make the GET request
                Dim response2 As HttpResponseMessage = client2.GetAsync(apiUrl).Result

                If response2.IsSuccessStatusCode Then
                    Dim _responseContent As String = response2.Content.ReadAsStringAsync().Result
                    Dim _users As JsonDocument = JsonDocument.Parse(_responseContent)
                    For Each _user As JsonElement In _users.RootElement.EnumerateArray()
                        Dim bodyLocationSpecificID As Integer = _user.GetProperty("ID").GetInt32()
                        Dim bodyLocationSpecificName As String = _user.GetProperty("Name").GetString()


                        'Insert Data into SQLite
                        Dim query As String = $"INSERT INTO tblBodyLocationSpecific (ID, Name, BodyLocationID) VALUES (@id, @name, @bodylocationid)"
                        Dim command As New SQLiteCommand(query, connection)
                        command.Parameters.AddWithValue("@id", bodyLocationSpecificID)
                        command.Parameters.AddWithValue("@name", bodyLocationSpecificName)
                        command.Parameters.AddWithValue("@bodylocationid", bodyLocationID)
                        command.ExecuteNonQuery()
                    Next

                End If
            Next

        Else
            Console.WriteLine("Error: " & response.ReasonPhrase)
        End If

        Return 0
    End Function

    Public Function APIBodySymptom()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim connection As New SQLiteConnection(connectionString)

        connection.Open()

        Dim apiUrl As String = "https://healthservice.priaid.ch/body/locations?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzk4NDYxLCJuYmYiOjE2OTc3OTEyNjF9.ZczOe4BDvDoURtp1SV4GkHvBNR5Gb08bQGLJyb7dPo0&format=json&language=en-gb"
        Dim client As New HttpClient()

        ' Make the GET request
        Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result

        If response.IsSuccessStatusCode Then
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            Dim users As JsonDocument = JsonDocument.Parse(responseContent)


            For Each user As JsonElement In users.RootElement.EnumerateArray()
                Dim bodyLocationID As Integer = user.GetProperty("ID").GetInt32()

                apiUrl = "https://healthservice.priaid.ch/body/locations/" & bodyLocationID & "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3Nzk4NjQ3LCJuYmYiOjE2OTc3OTE0NDd9.t2JqgLS98qurzL8Y74OzcdaL8YTPjOBfoKf1CjN5xfw&format=json&language=en-gb"

                Dim client2 As New HttpClient()

                ' Make the GET request
                Dim response2 As HttpResponseMessage = client2.GetAsync(apiUrl).Result

                If response2.IsSuccessStatusCode Then
                    Dim _responseContent As String = response2.Content.ReadAsStringAsync().Result
                    Dim _users As JsonDocument = JsonDocument.Parse(_responseContent)
                    For Each _user As JsonElement In _users.RootElement.EnumerateArray()
                        Dim bodyLocationSpecificID As Integer = _user.GetProperty("ID").GetInt32()

                        apiUrl = "https://healthservice.priaid.ch/symptoms/" & bodyLocationSpecificID & "/0?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Imp1ZW5jeXphbHR5QGdtYWlsLmNvbSIsInJvbGUiOiJVc2VyIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvc2lkIjoiMTAzODMiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3ZlcnNpb24iOiIxMDkiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xpbWl0IjoiMTAwIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwIjoiQmFzaWMiLCJodHRwOi8vZXhhbXBsZS5vcmcvY2xhaW1zL2xhbmd1YWdlIjoiZW4tZ2IiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL2V4cGlyYXRpb24iOiIyMDk5LTEyLTMxIiwiaHR0cDovL2V4YW1wbGUub3JnL2NsYWltcy9tZW1iZXJzaGlwc3RhcnQiOiIyMDIzLTEwLTA3IiwiaXNzIjoiaHR0cHM6Ly9hdXRoc2VydmljZS5wcmlhaWQuY2giLCJhdWQiOiJodHRwczovL2hlYWx0aHNlcnZpY2UucHJpYWlkLmNoIiwiZXhwIjoxNjk3ODAxODcwLCJuYmYiOjE2OTc3OTQ2NzB9.E-eZb7DE6KK7rZZrEVV_b7VMyxZT-b8Yj8JyaZgxvd8&format=json&language=en-gb"

                        Dim client3 As New HttpClient()

                        ' Make the GET request
                        Dim response3 As HttpResponseMessage = client3.GetAsync(apiUrl).Result
                        If response3.IsSuccessStatusCode Then
                            Dim __responseContent As String = response3.Content.ReadAsStringAsync().Result
                            Dim __users As JsonDocument = JsonDocument.Parse(__responseContent)
                            For Each __user As JsonElement In __users.RootElement.EnumerateArray()
                                Dim bodySymptomID As Integer = __user.GetProperty("ID").GetInt32()
                                Dim bodySymptomName As String = __user.GetProperty("Name").GetString()

                                ' Retrieve HealthSymptomLocationIDs array
                                Dim healthSymptomLocationIDs As JsonElement = __user.GetProperty("HealthSymptomLocationIDs")
                                ' Create an array to store the IDs
                                Dim healthLocationIDArray As New List(Of Integer)
                                For Each id As JsonElement In healthSymptomLocationIDs.EnumerateArray()
                                    healthLocationIDArray.Add(id.GetInt32())

                                Next

                                'Insert Data into SQLite
                                Dim query As String = $"INSERT INTO tblBodySymptoms (ID, Name, HealthSymptomLocationID) VALUES (@id, @name, @healthsymptomlocationid)"
                                Dim command As New SQLiteCommand(query, connection)
                                command.Parameters.AddWithValue("@id", bodySymptomID)
                                command.Parameters.AddWithValue("@name", bodySymptomName)
                                command.Parameters.AddWithValue("@healthsymptomlocationid", String.Join(",", healthLocationIDArray))
                                command.ExecuteNonQuery()



                            Next

                        End If
                    Next
                Else
                    Console.WriteLine("Error: " & response.ReasonPhrase)
                End If
            Next
        End If
        Return 0
    End Function

End Module
