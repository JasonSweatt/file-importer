@echo off

SET DIR=%~d0%~p0%

SET database.name="Location"
SET sql.files.directory="%DIR%Scripts"
SET output.directory="%DIR%rh-log"
SET server.database="(local)"
SET version.file="_BuildInfo.xml"
SET version.xpath="//buildInfo/version"
SET environment="LOCAL"

"%DIR%Console\rh.exe" /d=%database.name% /f=%sql.files.directory% /s=%server.database% /vf=%version.file% /vx=%version.xpath% /o=%output.directory% /env=%environment% /drop /disableoutput
"%DIR%Console\rh.exe" /d=%database.name% /f=%sql.files.directory% /s=%server.database% /vf=%version.file% /vx=%version.xpath% /o=%output.directory% /env=%environment% /simple /disableoutput
