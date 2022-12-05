rd /S /Q .vs 2> nul
rd /S /Q TripleAProject.Application/.vs 2> nul
rd /S /Q TripleAProject.Application/bin 2> nul
rd /S /Q TripleAProject.Application/obj 2> nul
rd /S /Q TripleAProject.Webapi/.vs 2> nul
rd /S /Q TripleAProject.Webapi/bin 2> nul
rd /S /Q TripleAProject.Webapi/obj 2> nul

:start
cd TripleAProject.Webapi
dotnet watch run -c Debug
goto start