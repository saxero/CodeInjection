# CodeInjection

CodeInjection.cs file
---------------------
Simple example of dependency injection by setter in C#.

The classes Anemometro, Barometro and Termometro implement the IMeteoReferencia interface.
The class EstacionMeteorologica offers a public property that can be injected with the corresponding class (Anemometro, Barometro 
or Termometro).  

The Main function uses Activator.CreateInstance in order to get the corresponding instance of the class to be injected.
```C#
Type type = System.Type.GetType("CodeInjection.Barometro");
IMeteoReferencia dependency = (IMeteoReferencia)Activator.CreateInstance(type);
estacion.referencia = dependency;
```
