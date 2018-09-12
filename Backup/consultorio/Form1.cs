using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace consultorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DTP1.MinDate = DateTime.Today;
            DTP1.MaxDate = new DateTime(2017,12,31);
            DTPCITA.MinDate = DateTime.Today;
            DTPCITA.MaxDate = new DateTime(2018,12,31);
            DTPHORA.Format = DateTimePickerFormat.Time;
            DTPHORA.ShowUpDown = true;
            DTPHORA.CustomFormat = "hh:mm tt";
            DTPHORA.MinDate = DateTime.Parse("8:00 am");
            DTPHORA.MaxDate = DateTime.Parse("19:00 pm");
        }
        public string Dia;
        private void CMDSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CBXPAC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Nom = CBXPAC.Text;
            switch (Nom)
            {
                case "Clara": PBXPAC.Image = Image.FromFile("F:/DATOS/5 semestre/Desarrollo Visual 2/consultorio/consultorio/base.bmp");
                    TXTSINT.Text = "Ve borroso";
                    break;
                case "Ivan": PBXPAC.Image = Image.FromFile("F:/DATOS/5 semestre/Desarrollo Visual 2/consultorio/consultorio/base5.bmp");
                    TXTSINT.Text = "dolor en los dedos del pie";
                    break;
                case "Janeth": PBXPAC.Image = Image.FromFile("F:/DATOS/5 semestre/Desarrollo Visual 2/consultorio/consultorio/DUH.png");
                    TXTSINT.Text = "Fiebre";
                    break;
                case "Ronaldo": PBXPAC.Image = Image.FromFile("F:/DATOS/5 semestre/Desarrollo Visual 2/consultorio/consultorio/base4.bmp");
                    TXTSINT.Text = "Vomito  ";
                    break;

            }
        }

        private void CBXDR_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Nom2 = CBXDR.Text;
            switch (Nom2)
            {
                case "Dr.Rivas": PBXDR.Image = Image.FromFile("F:/DATOS/5 semestre/Desarrollo Visual 2/consultorio/consultorio/allison.jpg");
                    TXTESP.Text = "Pediatria";
                  
                    break;
                case "Dr.Silva": PBXDR.Image = Image.FromFile("F:/DATOS/5 semestre/Desarrollo Visual 2/consultorio/consultorio/carita.jpg");
                    TXTESP.Text = "Oftamologo";
                
                    break;
                case "Dr.Salas": PBXDR.Image = Image.FromFile("F:/DATOS/5 semestre/Desarrollo Visual 2/consultorio/consultorio/sirena.png");
                    TXTESP.Text = "Podologo";
                   
                     break;
             

            }
        }

        private void RBN7D_CheckedChanged(object sender, EventArgs e)
        {
            if(RBN7D.Checked)
            {
                DTPCITA.Value = DTP1.Value.AddDays(7);
                Dia = DTPCITA.Value.DayOfWeek.ToString();
                if (Dia == "Sunday")
                {
                    DTPCITA.Value=DTPCITA.Value.AddDays(1);
                }
                if (Dia == "Saturday")
                {
                    DTPHORA.MinDate = DateTime.Parse("9:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("14:00 pm");
                }
                else
                {
                    DTPHORA.MinDate = DateTime.Parse("8:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("19:00 pm");
                }
            }
        }

        private void DTPCITA_ValueChanged(object sender, EventArgs e)
        {
            
                
                Dia = DTPCITA.Value.DayOfWeek.ToString();
                if (Dia == "Sunday")
                {
                    DTPCITA.Value = DTPCITA.Value.AddDays(1);
                }
                if (Dia == "Saturday")
                {
                    DTPHORA.MinDate = DateTime.Parse("9:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("14:00 pm");
                }
                else
                {
                    DTPHORA.MinDate = DateTime.Parse("8:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("14:00 pm");
                }
            
        }

        private void RBN15D_CheckedChanged(object sender, EventArgs e)
        {
            if (RBN15D.Checked)
            {
                DTPCITA.Value = DTP1.Value.AddDays(15);
                Dia = DTPCITA.Value.DayOfWeek.ToString();
                if (Dia == "Sunday")
                {
                    DTPCITA.Value = DTPCITA.Value.AddDays(1);
                }
                if (Dia == "Saturday")
                {
                    DTPHORA.MinDate = DateTime.Parse("9:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("14:00 pm");
                }
                else
                {
                    DTPHORA.MinDate = DateTime.Parse("8:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("19:00 pm");
                }
            }
        }

        private void RBN1M_CheckedChanged(object sender, EventArgs e)
        {
            if (RBN1M.Checked)
            {
                DTPCITA.Value = DTP1.Value.AddMonths(1);
                Dia = DTPCITA.Value.DayOfWeek.ToString();
                if (Dia == "Sunday")
                {
                    DTPCITA.Value = DTPCITA.Value.AddDays(1);
                }
                if (Dia == "Saturday")
                {
                    DTPHORA.MinDate = DateTime.Parse("9:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("14:00 pm");
                }
                else
                {
                    DTPHORA.MinDate = DateTime.Parse("8:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("19:00 pm");
                }
            }
        }

        private void RBN1A_CheckedChanged(object sender, EventArgs e)
        {
            if (RBN1A.Checked)
            {
                DTPCITA.Value = DTP1.Value.AddDays(15);
                Dia = DTPCITA.Value.DayOfWeek.ToString();
                if (Dia == "Sunday")
                {
                    DTPCITA.Value = DTPCITA.Value.AddDays(1);
                }
                if (Dia == "Saturday")
                {
                    DTPHORA.MinDate = DateTime.Parse("9:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("14:00 pm");
                }
                else
                {
                    DTPHORA.MinDate = DateTime.Parse("8:00 am");
                    DTPHORA.MaxDate = DateTime.Parse("19:00 pm");
                }
            }
        }


       


       
    }
}
