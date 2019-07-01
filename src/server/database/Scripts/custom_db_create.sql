USE master
IF NOT EXISTS(SELECT * FROM sys.databases WHERE [name] = '{{DatabaseName}}')
BEGIN
    -- Create the database
    CREATE DATABASE [{{DatabaseName}}]

    -- Enable Snapshot Isolation
    --ALTER DATABASE [{{DatabaseName}}]
    --SET ALLOW_SNAPSHOT_ISOLATION ON

    -- signal success
    SELECT 1
END

