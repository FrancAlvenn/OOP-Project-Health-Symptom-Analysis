Module DatabaseConfiguration
    Public ReadOnly Property DataSourceUserAuthentication As String
        Get
            Return "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/userAuthentication.sqlite;"
        End Get
    End Property
    Public ReadOnly Property DataSourceAdminAuthentication As String
        Get
            Return "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/adminAuthentication.sqlite;"
        End Get
    End Property
    Public ReadOnly Property DataSourceSystemDatabase As String
        Get
            Return "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        End Get
    End Property
End Module
