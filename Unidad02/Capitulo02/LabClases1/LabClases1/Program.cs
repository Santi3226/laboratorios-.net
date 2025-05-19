using Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

A i1 = new A();
i1.NombreInstancia = "Instancia 1";
i1.MostrarNombre();
i1.M1();
i1.M2();
i1.M3();

B i2 = new B();
i2.MostrarNombre();
i2.M4();

A i3 = new A();
i3.MostrarNombre();