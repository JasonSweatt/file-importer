-- Create dev user
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'dev')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'dev')
    BEGIN
        CREATE LOGIN dev WITH PASSWORD = 'PasswordAbc123', CHECK_EXPIRATION = OFF, CHECK_POLICY = OFF;
    END;

    CREATE USER [dev] FOR LOGIN [dev]
END;
GO

-- Create app user
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'app')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'app')
    BEGIN
        CREATE LOGIN app WITH PASSWORD = 'PasswordAbc123', CHECK_EXPIRATION = OFF, CHECK_POLICY = OFF;
    END;

    CREATE USER [app] FOR LOGIN [app]
END;
GO

-- Grant dev db_owner
IF NOT EXISTS (SELECT * FROM sys.database_role_members drm
                    INNER JOIN sys.database_principals dp1 ON drm.role_principal_id=dp1.principal_id AND dp1.type='R'
                    INNER JOIN sys.database_principals dp2 ON drm.member_principal_id=dp2.principal_id AND dp2.type='S'
                    WHERE dp1.name='db_owner' AND dp2.name='dev')
BEGIN
    EXEC sp_addrolemember N'db_owner', N'dev'
    EXEC sp_addrolemember N'db_owner', N'app'
END
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'dev_user')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'dev_user')
    BEGIN
        CREATE LOGIN dev_user WITH PASSWORD = 'PasswordAbc123', CHECK_EXPIRATION = OFF, CHECK_POLICY = OFF;
    END;

    CREATE USER [dev_user] FOR LOGIN [dev_user]
    EXEC sp_addrolemember N'db_owner', N'dev_user'
END;
GO