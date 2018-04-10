# EjercicioTecnicoDotNet
Ejercicio técnico .NET

#EXERCICE RESUME:
Hi, in this article I'm going to explain which design and development practices I choose to do this exercise.
At first, I create an implementation of the pattern "Simple Factory". In this case I choose to do that, because I want to delegate the instantiation to a common class to have more control. I could used "Factory Method" pattern, but I think that this solution is in line with the example. 
I use to add summary's to my code, that could be seen in all the exercise. I used "NLog" to trace the code if my product someday would be in production and I'd wanted to know more information about a crash.

#ESTIMATED TIME:
3 hours aprox.

#UNIT TETS.
To run the unit tests, just execute "RunTests.bat" located at the solution folder. That batch file use "MSTest" and you have to use a CLI compatible with .NET Framework 4.6.2. In case of getting an error, just use visual studio IDE.