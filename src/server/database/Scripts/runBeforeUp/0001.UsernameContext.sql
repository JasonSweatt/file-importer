IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetContextUserNameCore]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
	execute dbo.sp_executesql @statement = N'
		CREATE FUNCTION [dbo].[GetContextUserNameCore] ()
		RETURNS varchar(50)
		AS
		BEGIN
			DECLARE	@username varchar(50),
					@length tinyint,
					@context varbinary(128)

			-- we store the length of the username in the first character of the context
			select @context = CONTEXT_INFO()
			select @Length = convert(tinyint, substring(@context, 1, 1))
			select @username = convert(varchar(50), substring(@context, 2, @Length))

			-- If context has not been populated, use the underling connection name
			IF @username is NULL SET @username = SUSER_SNAME()

			RETURN @username
		END
	'
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetContextUserName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
	execute dbo.sp_executesql @statement = N'
		CREATE FUNCTION [dbo].[GetContextUserName] ()
		RETURNS varchar(50)
		AS
		BEGIN
			-- this is a wrapper for the core GetContextUserName functionality
			-- so if we need to change the implementation we do not have to worry about dependencies
			RETURN dbo.GetContextUserNameCore()
		END
	'
END
