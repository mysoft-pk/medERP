Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private m_reportPath As String
        Private m_Connectionsting As String
        Private m_ConnectionstingFinder As String
        Private m_Userid As String
        Private m_UserName As String
        Private m_ipaddress As String
        Private m_SDate As Date
        Private m_LoginOrgName As String
        Private m_CompanyName As String
        Private m_CompanyAddress As String
        Private m_CompanyPhone As String
        Private m_ServerName As String
        Private m_LoginID As String
        Private m_Password As String
        Private m_Database As String
        Private m_UserType As String
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            ' Set the display time to 5000 milliseconds (5 seconds). 
            Me.MinimumSplashScreenDisplayTime = 5000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

        Property UserType() As String
            Get
                UserType = m_UserType
            End Get
            Set(ByVal value As String)
                m_UserType = value
            End Set
        End Property

        Property Userid() As String
            Get
                Userid = m_Userid
            End Get
            Set(ByVal value As String)
                m_Userid = value
            End Set
        End Property
        Property CompanyName() As String
            Get
                CompanyName = m_CompanyName
            End Get
            Set(ByVal value As String)
                m_CompanyName = value
            End Set
        End Property
        Property CompanyAddress() As String
            Get
                CompanyAddress = m_CompanyAddress
            End Get
            Set(ByVal value As String)
                m_CompanyAddress = value
            End Set
        End Property
        Property CompanyPhone() As String
            Get
                CompanyPhone = m_CompanyPhone
            End Get
            Set(ByVal value As String)
                m_CompanyPhone = value
            End Set
        End Property
        Property LoginOrgName() As String
            Get
                LoginOrgName = m_LoginOrgName
            End Get
            Set(ByVal value As String)
                m_LoginOrgName = value
            End Set
        End Property
        Property UserName() As String
            Get
                UserName = m_UserName
            End Get
            Set(ByVal value As String)
                m_UserName = value
            End Set
        End Property

        Property ReportPath() As String
            Get
                ReportPath = m_reportPath
            End Get
            Set(ByVal value As String)
                m_reportPath = value
            End Set
        End Property
        Property ConnectionString() As String
            Get
                ConnectionString = m_Connectionsting
            End Get
            Set(ByVal value As String)
                m_Connectionsting = value
            End Set
        End Property

        Property ConnectionStringFinder() As String
            Get
                ConnectionStringFinder = m_ConnectionstingFinder
            End Get
            Set(ByVal value As String)
                m_ConnectionstingFinder = value
            End Set
        End Property

        Property SDate() As Date
            Get
                SDate = m_SDate
            End Get
            Set(ByVal value As Date)
                m_SDate = value
            End Set
        End Property
        Property IpAddress() As String
            Get
                IpAddress = m_ipaddress
            End Get
            Set(ByVal value As String)
                m_ipaddress = value
            End Set
        End Property
        Property ServerName() As String
            Get
                ServerName = m_ServerName
            End Get
            Set(ByVal value As String)
                m_ServerName = value
            End Set
        End Property
        Property LoginID() As String
            Get
                LoginID = m_LoginID
            End Get
            Set(ByVal value As String)
                m_LoginID = value
            End Set
        End Property
        Property Password() As String
            Get
                Password = m_Password
            End Get
            Set(ByVal value As String)
                m_Password = value
            End Set
        End Property
        Property Database() As String
            Get
                Database = m_Database
            End Get
            Set(ByVal value As String)
                m_Database = value
            End Set
        End Property
    End Class

End Namespace

