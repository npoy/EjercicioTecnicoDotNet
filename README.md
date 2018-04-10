# EjercicioTecnicoDotNet
Ejercicio técnico .NET

#EXERCICE RESUME:
Hi, in this article im going to explain which design and development practices i choose to do this exercise.
At first, i create an implementation of the pattern "Simple Factory". In this case i choose to do that, because i want to delegate the instantiation to a common class to have more control. I could used "Factory Method" pattern, but i think that this solution is in line with the example. 
I used to add summary to my code, that could be seen in all the exercise and i used "NLog" to trace the code if my product someday is going to production and i want to know more information about a crash.

#UNIT TETS.
To run the unit tests, just execute "RunTests.bat" located at the solution folder. That batch file use "MSTest" and you have to use a CLI compatible with .NET Framework 4.6.2.