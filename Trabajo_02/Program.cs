using System;

namespace Trabajo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Breidyn";
            cliente1.ApellidoPaterno = "Rios";
            cliente1.ApellidoMaterno = "Briceño";
            cliente1.Dni = 4845493;
            DateTime fecha = new DateTime(2022, 02, 20);
            cliente1.FechaNacimiento = fecha;
            cliente1.Edad = 28;
            cliente1.Telefono = "4864834";

            Cliente cliente2 = new Cliente("Anderson", "Rios", "Briceño");
            cliente2.Dni = 8496642;
            cliente2.Edad = 19;
            DateTime fecha_2 = new DateTime(2001,3,30);
            cliente2.FechaNacimiento = fecha_2;
            cliente2.Telefono = "6284619";

            DateTime FechaNacimiento = new DateTime(1986, 4, 23);
            Cliente cliente3 = new Cliente(56491454, FechaNacimiento);
            cliente3.Nombre = "Lucinda";
            cliente3.ApellidoPaterno = "Briceño";
            cliente3.ApellidoMaterno = "Alva";
            cliente3.Edad = 48;
            cliente3.Dni = 32135848;
            cliente3.Telefono = "84146";


            Console.WriteLine($" Tengo un hermano llamado  {cliente1.Nombre} y sus apellidos son  {cliente1.ApellidoPaterno} {cliente1.ApellidoMaterno}" +
                              $" y tiene {cliente1.Edad} años de edad, su fecha de nacimiento es el {String.Format("{0:d}", fecha)}, el perdio su billetera en el  cual estaba su DNI " +
                              $" que su número era {cliente1.Dni} y una señorita lo encontro en un taxi y estaba su número de telefeno y marco al {cliente1.Telefono}" +
                              $" y el contesto, luego  quedaron en encontrare y la señorita le devolvio su billetera y el agradecido la invito a salir. \n\n");
            

            Console.WriteLine($"Me llamo {cliente2.Nombre} {cliente2.ApellidoPaterno} {cliente2.ApellidoMaterno}, naci en  { String.Format("{0:d}", fecha_2)} y tengo {cliente2.Edad} " +
                              $" años de edad, mi telefono es {cliente2.Telefono} y si quieres estar seguro de que soy yo, este es mi DNI {cliente2.Dni}. \n\n");
            
            Console.WriteLine($"El nombre de mi mamá es {cliente3.Nombre} y sus apellidos son {cliente3.ApellidoPaterno} {cliente3.ApellidoMaterno}, ella nacio" +
                              $" en  {String.Format("{0:d}", FechaNacimiento)}, ella tiene {cliente3.Edad} años de edad, le gusta mucho salir y la unica manera de " +
                              $" comunicarce con ella es llamandola a su telefono que es {cliente3.Telefono}, hoy ira a renovar su DNI y su numero es " +
                              $" {cliente3.Dni} luego de eso llega a casa.\n\n");
        }
    } 
}
