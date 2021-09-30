using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica070921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Definir las columnas del DataGridView
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firtName", "NOMBRE");
            dgData.Columns.Add("lasttudent", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("genero", "GENERO");


            //Llenara las filas
            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firtName, student.lastName, student.age);
            
            }

        }

        //metodo para retornar la coleccion de datos
        private List<Student> selectAllData()
        {
            //crear la consulta
            List<Student> result = (
                                    from student in Student.GetStudents()
                                    select new Student()
                                    {
                                        idStudent = student.idStudent,
                                        firtName = student.firtName,
                                        lastName = student.lastName,
                                        age = student.age,
                                        genero = student.genero
                                    }
                ).ToList();
            //retorna el resultado de la consulta
            return result;
        }
    }
}
