set "source_directory=C:\SourceDirectory"
set "destination_directory=C:\DestinationDirectory"

if not exist "%destination_directory%" mkdir "%destination_directory%"

for /r "%source_directory%" %%F in (*) do (
    if "%%~dpF" neq "%destination_directory%\" (
        echo Copying "%%~fF" to "%destination_directory%\%%~nxF"
        xcopy "%%~fF" "%destination_directory%\" /Y
    )
)

echo Copy operation complete.
pause