# Location Database

## Local Database Setup
* Ensure that you have SQL Server (2016 or greater) installed on your local machine and configured to allow Windows & SQL Auth
    * Additional details available at [https://github.com/xpologistics/xpo-conventions/tree/master/sql](https://github.com/xpologistics/xpo-conventions/tree/master/sql)

## Running Migrations
* Open a command prompt
* Run ```LOCAL.DBDeployment.bat``` or ```LOCAL.DBDeployment.DropCreate.bat```
    * Use ```LOCAL.DBDeployment.bat``` when you just want to update your database with the latest changes 
    * Use ```LOCAL.DBDeployment.DropCreate.bat``` when you want to drop your database and re-run all migrations

## Folders 
The folders will be executed in the order listed.

#### runAfterCreateDatabase
To be used for database configuration scripts. 
- NOTE: we do not allow roundhouse to create databases in production and any settings in this folder will need to be manually executed by the DBA team.

#### runBeforeUp
For scripts that need to be run prior to migrations in the _up_ folder.

#### up
Where you place your modifications to the database schema. The scripts in this folder will be executed in alphabetical order so it is recommended to
prefix the scripts with a timestamp or an incrementing number like ```0001_Script1```, ```0002_Script2.sql```. Scripts in this folder are only meant to
be run once and should not be modified.

#### functions
Folder to place all user defined functions.  Files in this folder will be re-run every they are modified.

#### view
Folder to place all user defined views.  Files in this folder will be re-run every they are modified.

#### sprocs
Folder to place all user defined stored procs.  Files in this folder will be re-run every they are modified.

#### runAfterOtherAnyTimeScripts
Folder to place all seed files.  Files in this folder will be re-run every they are modified.

#### permissions
Folder to place files that you need to be run with every migration.  This a good place to put files that you need to run to cleanse data after a restore 
from production.    


## Gotchas
- Roundhouse is expecting file names to be unique across all folders, so make sure you pick a different script naming convention for your *runAfterOtherAnyTimeScripts* and *up* folders.

## Additional References
* [Roudhouse Documentation](https://github.com/chucknorris/roundhouse)
* [Xpo SQL Conventions](https://github.com/xpologistics/xpo-conventions/tree/master/sql)
