@echo off
REM L�scht alle tempor�ren Visual Studio Dateien

FOR %%d IN (TripleAProject TripleAProject.Application TripleAProject.Webapi) DO (
    rd /S /Q "%%d/bin" 2> nul 
    rd /S /Q "%%d/obj" 2> nul
    rd /S /Q "%%d/.vs" 2> nul
    rd /S /Q "%%d/.vscode" 2> nul
)

FOR %%d IN (TripleAProject TripleAProject.Application TripleAProject.Application) DO (
  
  rd /S /Q "%%d/bin" 2> nul 
  rd /S /Q "%%d/obj" 2> nul
)