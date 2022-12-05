@echo off
FOR %%d IN (TripleAProject/TripleAProject.Webapi) DO (
    rd /S /Q "%%d/bin" 2> nul 
    rd /S /Q "%%d/obj" 2> nul
    rd /S /Q "%%d/.vs" 2> nul
    rd /S /Q "%%d/.vscode" 2> nul
)
cd webapi
dotnet watch run -c Debug
