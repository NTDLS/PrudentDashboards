@Echo Off

SET PATH=%PATH%;C:\Program Files\Vroom Performance Technologies\SQL Script Generator;C:\Program Files\7-Zip;

Echo Creating new schema dump directory...
MD "Database Setup Scripts"

Echo Dumping database schema...
SSGC.exe /Config:_DumpSchemaConfig.json
