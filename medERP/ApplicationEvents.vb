Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private m_ConnectionString As String
        Private m_ConnectionStringFinder As String
        Private m_OrgName As String
        Private m_CompanyName As String
        Private m_CompanyLine1 As String

        Property ConnectionString() As String
            Get
                ConnectionString = m_ConnectionString
            End Get
            Set(value As String)
                m_ConnectionString = value
            End Set
        End Property

        Property ConnectionStringFinder() As String
            Get
                ConnectionStringFinder = m_ConnectionStringFinder
            End Get
            Set(value As String)
                m_ConnectionStringFinder = value
            End Set
        End Property

        Property OrgName() As String
            Get
                OrgName = m_OrgName
            End Get
            Set(value As String)
                m_OrgName = value
            End Set
        End Property

        Property CompanyName() As String
            Get
                CompanyName = m_CompanyName
            End Get
            Set(value As String)
                m_CompanyName = value
            End Set
        End Property

        Property CompanyLine1() As String
            Get
                CompanyLine1 = m_CompanyLine1
            End Get
            Set(value As String)
                m_CompanyLine1 = value
            End Set
        End Property
    End Class
End Namespace
