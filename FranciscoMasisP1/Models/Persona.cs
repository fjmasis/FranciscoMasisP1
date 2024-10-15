using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FranciscoMasisP1.Models
{
    public class Persona
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }

        public Persona(string id, string nombre, string apellido, string email, int edad)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Nombre: {Nombre}, Apellido: {Apellido}, Email: {Email}, Edad: {Edad}";
        }



        public class Estudiante : Persona
        {
            public string Carrera { get; set; }
            public int AñoIngreso { get; set; }

            public Estudiante(string id, string nombre, string apellido, string email, int edad, string carrera, int añoIngreso)
                : base(id, nombre, apellido, email, edad)
            {
                Carrera = carrera;
                AñoIngreso = añoIngreso;
            }

            public override string ToString()
            {
                return base.ToString() + $", Carrera: {Carrera}, Año de Ingreso: {AñoIngreso}";
            }
        }


        public class Profesor : Persona
        {
            public string Departamento { get; set; }
            public string Titulo { get; set; }

            public Profesor(string id, string nombre, string apellido, string email, int edad, string departamento, string titulo)
                : base(id, nombre, apellido, email, edad)
            {
                Departamento = departamento;
                Titulo = titulo;
            }

            public override string ToString()
            {
                return base.ToString() + $", Departamento: {Departamento}, Título: {Titulo}";
            }
        }


        public class Usuario : Persona
        {
            public string Rol { get; set; }
            public DateTime FechaRegistro { get; set; }

            public Usuario(string id, string nombre, string apellido, string email, int edad, string rol, DateTime fechaRegistro)
                : base(id, nombre, apellido, email, edad)
            {
                Rol = rol;
                FechaRegistro = fechaRegistro;
            }

            public override string ToString()
            {
                return base.ToString() + $", Rol: {Rol}, Fecha de Registro: {FechaRegistro:yyyy-MM-dd}";
            }
        }


