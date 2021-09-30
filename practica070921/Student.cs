using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica070921
{
    class Student
    { public int idStudent { get; set; }
        public string firtName { get; set; }
        public string lastName { get; set; }

        public int age { get; set; }
        public string genero { get; set; }


        //Crear la coleccion de datos
        public static List<Student> GetStudents() 
        {
            List<Student> students = new List<Student>
            { new Student { idStudent=1001, firtName="Ana", lastName="Flores", age=22, genero="F"}, 
            new Student { idStudent=1002, firtName="Sofia", lastName="Lopez", age=21, genero="F"},
            new Student { idStudent=1003, firtName="Pedro", lastName="Aguilar", age=20, genero="M"},
            new Student { idStudent=1004, firtName="Juan", lastName="Santo", age=21, genero="M"},
            new Student { idStudent=1005, firtName="Maria", lastName="Araujo", age=23, genero="F"},
            new Student { idStudent=1006, firtName="Marta", lastName="Lopez", age=21, genero="F"},
            new Student { idStudent=1007, firtName="Mario", lastName="Avilez", age=22, genero="M"}


            };

            //Valor de retorno, sera la lista de estudiantes 
            return students;


        }


} 
}
