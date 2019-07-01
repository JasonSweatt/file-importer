IF OBJECT_ID(N'dbo.GeoName', 'U') IS NULL
    CREATE TABLE dbo.GeoName (
        GeoNameId BIGINT NOT NULL
       ,Name VARCHAR(200) NOT NULL
       ,AsciiName VARCHAR(200) NULL
       ,AlternateNames VARCHAR(MAX) NULL
       ,Latitude DECIMAL(20, 15) NULL
       ,LatitudeInRadians AS CASE WHEN Latitude IS NULL THEN NULL ELSE (Latitude * (PI() / 180)) END
       ,Longitude DECIMAL(20, 15) NULL
       ,LongitudeInRadians AS CASE WHEN Longitude IS NULL THEN NULL ELSE (Longitude * (PI() / 180)) END
       ,GeoCode AS CASE WHEN (Latitude IS NULL AND Longitude IS NULL) OR
                          (Latitude IS NULL AND Longitude IS NOT NULL) OR
                          (Latitude IS NOT NULL AND Longitude IS NULL) THEN NULL ELSE geography::STPointFromText('POINT(' + CAST(Longitude AS VARCHAR(30)) + ' ' + CAST(Latitude AS VARCHAR(30)) + ')', 4326) END
       ,IsValid AS CASE WHEN (Latitude IS NULL AND Longitude IS NULL) OR
                          (Latitude IS NULL AND Longitude IS NOT NULL) OR
                          (Latitude IS NOT NULL AND Longitude IS NULL) THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END PERSISTED
       ,FeatureClass VARCHAR(1) NULL
       ,FeatureCode VARCHAR(10) NULL
       ,CountryIsoCode VARCHAR(2) NULL
       ,CountryCodes VARCHAR(200) NULL
       ,Admin1Code VARCHAR(20) NULL
       ,Admin2Code VARCHAR(20) NULL
       ,Admin3Code VARCHAR(20) NULL
       ,Admin4Code VARCHAR(20) NULL
       ,Population BIGINT NULL
       ,Elevation INT NULL -- in meters
       ,Dem INT NULL
       ,TimeZone VARCHAR(40) NULL
       ,ModificationDate VARCHAR(10) NULL
       ,CreatedBy VARCHAR(50) NOT NULL DEFAULT('Api')
       ,CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
       ,LastUpdatedBy VARCHAR(50) NOT NULL DEFAULT('Api')
       ,LastUpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
       ,CONSTRAINT PK_GeoName PRIMARY KEY CLUSTERED (GeoNameId)
    )
GO
