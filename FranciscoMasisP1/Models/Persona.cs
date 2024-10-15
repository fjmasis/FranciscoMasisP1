using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FranciscoMasisP1.Models
{
    public class Persona
    {
        private string id;
        private string nombre;
        private string apellido;
        private string email;
        private int edad;

        public Persona(string id, string nombre, string apellido, string email, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.edad = edad;
        }

        // Getters y Setters
        public string ID
        {
            get => id;
            set => id = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Nombre: {Nombre}, Apellido: {Apellido}, Email: {Email}, Edad: {Edad}";
        }
    }

    public class Estudiante : Persona
    {
        private string carrera;
        private int añoIngreso;

        public Estudiante(string id, string nombre, string apellido, string email, int edad, string carrera, int añoIngreso)
            : base(id, nombre, apellido, email, edad)
        {
            this.carrera = carrera;
            this.añoIngreso = añoIngreso;
        }

        // Getters y Setters
        public string Carrera
        {
            get => carrera;
            set => carrera = value;
        }

        public int AñoIngreso
        {
            get => añoIngreso;
            set => añoIngreso = value;
        }

        public override string ToString()
        {
            return base.ToString() + $", Carrera: {Carrera}, Año de Ingreso: {AñoIngreso}";
        }
    }

    public class Profesor : Persona
    {
        private string departamento;
        private string titulo;

        public Profesor(string id, string nombre, string apellido, string email, int edad, string departamento, string titulo)
            : base(id, nombre, apellido, email, edad)
        {
            this.departamento = departamento;
            this.titulo = titulo;
        }

        // Getters y Setters
        public string Departamento
        {
            get => departamento;
            set => departamento = value;
        }

        public string Titulo
        {
            get => titulo;
            set => titulo = value;
        }

        public override string ToString()
        {
            return base.ToString() + $", Departamento: {Departamento}, Título: {Titulo}";
        }
    }

    public class Usuario : Persona
    {
        private string rol;
        private DateTime fechaRegistro;

        public Usuario(string id, string nombre, string apellido, string email, int edad, string rol, DateTime fechaRegistro)
            : base(id, nombre, apellido, email, edad)
        {
            this.rol = rol;
            this.fechaRegistro = fechaRegistro;
        }

        // Getters y Setters
        public string Rol
        {
            get => rol;
            set => rol = value;
        }

        public DateTime FechaRegistro
        {
            get => fechaRegistro;
            set => fechaRegistro = value;
        }

        public override string ToString()
        {
            return base.ToString() + $", Rol: {Rol}, Fecha de Registro: {FechaRegistro:yyyy-MM-dd}";
        }
    }



