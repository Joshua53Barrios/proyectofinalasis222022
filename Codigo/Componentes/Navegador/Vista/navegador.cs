﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Controlador;

namespace Vista
{
    public partial class navegador : Form
    {
        csControlador cn = new csControlador();
        public navegador()
        {
            InitializeComponent();
        }
        bool opcion;
        //si opcion es true será insercion
        //si opcion es false será actualizacion
        private void btnInsert_Click(object sender, EventArgs e)
        {
            opcion = true;
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte };
            cn.bloquearbotones(boton, true);
            cn.limpiar(this);
            cn.activar(this);
            TextBox[] textbox = { textBox1, textBox2 };
            cn.crearid(textbox, dgv_tabla);
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            opcion = false;
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte };
            cn.bloquearbotones(boton, true);
            TextBox[] textbox = { textBox1, textBox2 };
            cn.activar(this);
            cn.enfocar(textbox);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox, dgv_tabla, "i");
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte };
            
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            if (opcion == true)//Insercion
            {
                cn.ingresar(textbox, dgv_tabla, boton);
                

            }
            else if (opcion == false)//actualizacion
            {
                cn.actualizar(textbox, dgv_tabla,boton);
               
               
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte };
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.bloquearbotones(boton, false);
            cn.limpiar(this);
            cn.desactivar(this);
            cn.llenartxt(textbox, dgv_tabla);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox,dgv_tabla,"i");
            cn.desactivar(this);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.moverseIF(textbox, dgv_tabla, "f");
            cn.desactivar(this);
        }

        private void bnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void navegador_Load(object sender, EventArgs e)
        {
            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            cn.llenartablaa(dgv_tabla.Tag.ToString(), dgv_tabla);
            cn.desactivar(this);
            cn.llenartxt(textbox, dgv_tabla);
            IconButton[] boton = { btnSave, btnCancelar, btnInsert, btnModificar, btnDelete, btnUpdate, btnConsultar, btnReporte };
            cn.bloquearbotones(boton,false);
            
        }
    }
}
