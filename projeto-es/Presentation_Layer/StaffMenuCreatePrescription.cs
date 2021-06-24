﻿using projeto_es.Business_Layer;
using projeto_es.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_es.Presentation_Layer
{
    public partial class StaffMenuCreatePrescription : Form
    {
        public LoggedInSingleton LoggedSingleton { get; set; }
        public int AppointmentID { get; }

        public StaffMenuCreatePrescription(LoggedInSingleton loggedSingleton)
        {
            InitializeComponent();
            LoggedSingleton = loggedSingleton;
            //AppointmentID = appointmentID;
        }

        private void btn_close(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        private void btn_confirm_prescription_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            PrescriptionService prescriptionService = new PrescriptionService();
            prescriptionService.CreatePrescription(new Prescription()
            {
                Name = tb_name_utente.Text,
                Description = area_descrição.Text,
                DatePrescribed = localDate.ToString(),
                Appointment_Id = (uint)LoggedSingleton.appointmentId,

            });
            this.Close();

        }


        private void StaffMenuCreateAppointment_Load(object sender, EventArgs e)
        {
           
        }

        private void area_descrição_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_name_utente_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_utente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
