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

        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        
        public Persona(string id, string nombre, string apellido, string email, int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Edad = edad;
        }

        
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Email: {Email}, Edad: {Edad}";
        }
    }

    public class Estudiante : Persona
    {
       
        private string carrera;
        private int anioIngreso;

       
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public int AnioIngreso
        {
            get { return anioIngreso; }
            set { anioIngreso = value; }
        }

        
        public Estudiante(string id, string nombre, string apellido, string email, int edad, string carrera, int anioIngreso)
            : base(id, nombre, apellido, email, edad)
        {
            Carrera = carrera;
            AnioIngreso = anioIngreso;
        }

        
        public override string ToString()
        {
            return base.ToString() + $", Carrera: {Carrera}, Año de Ingreso: {AnioIngreso}";
        }
    }

    public class Profesor : Persona
    {
       
        private string departamento;
        private string titulo;

        
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

       
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
        
        private string rol;
        private DateTime fechaRegistro;

        
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

      
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


