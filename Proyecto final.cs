using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static string[] usuario1 = new string[6];
        static string[] usuario2 = new string[6] { "Darisleydi Santana", "40229620436", "21212121", "Administrator", "21/2/2002", "Activo" };
        static string[] usuario3 = new string[6] { "Ana Maria", "00126987516", "123456", "Supervisor", "28/8/2020", "Activo" };
        static string[] usuario4 = new string[6] { "Arisleydi", "40256353849", "1234567", "Vendedor", "3/9/2020", "Inactivo" };
        static string answer = "";
        static string usuario = "";
        static string contra = "";
        public static void Main(string[] args)
        {

            Console.WriteLine("¿Esta usted registrado o ya tiene un cuenta?");
            Console.WriteLine("Solo puede responder con 'Si' o 'No' si intenta responder de otra manera dara error!");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "Si":
                    Console.WriteLine("Digitar su usuario");
                    usuario = Console.ReadLine();
                    Console.WriteLine("Digitar su contraseña");
                    contra = Console.ReadLine();
                    if (usuario == usuario1[1] && usuario1[5] == "Activo")
                    {
                        Program.procedimiento();
                    }
                    else
                    {

                        if (usuario == usuario2[1] && usuario2[5] == "Activo")
                        {
                            Program.procedimiento();
                        }
                        else
                        {

                            if (usuario == usuario3[1] && usuario3[5] == "Activo")
                            {
                                Program.procedimiento();
                            }
                            else
                            {

                                if (usuario == usuario4[1] && usuario4[5] == "Activo")
                                {
                                    Program.procedimiento();
                                }
                                else
                                {
                                    Console.WriteLine("Error tu usuario no esta activo, debes contactarte con el administrador para que lo active");

                                }
                            }
                        }
                    }

                    break;
                case "No":
                    Console.WriteLine("Favor Escriba su nombre");
                    usuario1[0] = Console.ReadLine();
                    Console.WriteLine("Favor Escriba su usuario, el usuario debe ser su cedula la cual contenga 11 digitos, de no ser asi le dara error ");
                    usuario1[1] = Console.ReadLine();
                    Console.WriteLine("Favor Escriba su clave, que sea numerica");
                    usuario1[2] = Console.ReadLine();
                    Console.WriteLine("Favor Escriba su rol");
                    usuario1[3] = Console.ReadLine();
                    Console.WriteLine("Favor Escriba su Fecha de Creacion");
                    usuario1[4] = Console.ReadLine();
                    Console.WriteLine("Favor Escriba su estado, para el estado debe poner 'Activo' o 'Inactivo'");
                    usuario1[5] = Console.ReadLine();
                    Console.WriteLine("Listo, tus datos fueron guardados correctamente, ahora te debes loguear");
                    Console.WriteLine("Digitar su usuario");
                    usuario = Console.ReadLine();
                    Console.WriteLine("Digitar su contraseña");
                    contra = Console.ReadLine();
                    if (usuario == usuario1[1] && usuario1[5] == "Activo")
                    {
                        Program.procedimiento();
                    }
                    else
                    {

                        if (usuario == usuario2[1] && usuario2[5] == "Activo")
                        {
                            Program.procedimiento();
                        }
                        else
                        {

                            if (usuario == usuario3[1] && usuario3[5] == "Activo")
                            {
                                Program.procedimiento();
                            }
                            else
                            {

                                if (usuario == usuario4[1] && usuario4[5] == "Activo")
                                {
                                    Program.procedimiento();
                                }
                                else
                                {
                                    Console.WriteLine("Error tu usuario no esta activo, debes contactarte con el administrador para que lo active");

                                }
                            }
                        }
                    }


                    break;
                default:
                    Console.WriteLine("Revise bien si escribio la respuesta como se le pide: 'Si' o 'No'");
                    break;

            }
            Console.ReadKey();



        }


        static void procedimiento()
        {

            if (usuario == usuario1[1] && contra == usuario1[2])
            {
                Console.WriteLine("Acabas de ingresar con el usuario " + usuario1[1] + " De nombre " + usuario1[0] + " Y su rol es: " + usuario1[3]);
            }
            else
            {
                if (usuario == usuario2[1] && contra == usuario2[2])
                {
                    Console.WriteLine("Acabas de ingresar con el usuario " + usuario2[1] + " De nombre " + usuario2[0] + " Y su rol es: " + usuario2[3]);
                }
                else
                {
                    if (usuario == usuario3[1] && contra == usuario3[2])
                    {
                        Console.WriteLine("Acabas de ingresar con el usuario " + usuario3[1] + " De nombre " + usuario3[0] + " Y su rol es: " + usuario3[3]);
                    }
                    else
                    {
                        if (usuario == usuario4[1] && contra == usuario4[2])
                        {
                            Console.WriteLine("Acabas de ingresar con el usuario " + usuario4[1] + " De nombre " + usuario4[0] + " Y su rol es: " + usuario4[3]);
                        }
                        else
                        {
                            Console.WriteLine("Usted no esta registrado en la base de datos.");
                        }
                    }
                }
            }

        }
    }
}
