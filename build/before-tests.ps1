Param(
    [string]$Configuration = "Releaseasd"
)

$startPath = "$PSScriptRoot\..\tests\Ilaro.Admin.Tests\bin\$Configuration"
$sqlInstance = "(local)\SQL2014"
$dbName = "IlaroTestDb"

# replace the db connection with the local instance
$config = join-path $startPath "Ilaro.Admin.Tests.dll.config"
$doc = (gc $config) -as [xml]
$doc.SelectSingleNode('//connectionStrings/add[@name="IlaroTestDb"]').connectionString = "Server=$sqlInstance; Database=$dbName; Trusted_connection=true"
$doc.Save($config)

# create test db
sqlcmd -S "$sqlInstance" -Q "Use [master]; CREATE DATABASE [$dbName]"