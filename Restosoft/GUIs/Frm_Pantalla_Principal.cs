using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Restosoft.Entity;
using System.Data.EntityClient;
using System.Linq;

namespace Restosoft.GUIs
{
    public partial class Frm_Pantalla_Principal : XtraForm
    {
        Restosoft_Entities Restosoft_db;

        public Frm_Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Pantalla_Principal_Load(object sender, EventArgs e)
        {
            Restosoft_db = new Restosoft_Entities("metadata=res://*/Entity.Restosoft_Model.csdl|res://*/Entity.Restosoft_Model.ssdl|res://*/Entity.Restosoft_Model.msl;provider=MySql.Data.MySqlClient;provider connection string=\"server=localhost;user id=root;password=1234;database=restosoft\"");
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            CrearGrupo();
        }
        void CrearCategoria()
        {
            categorias_articulos cat = new categorias_articulos();
            cat.categoria = "Categoria " + Restosoft_db.categorias_articulos.ToList().Count;
            Restosoft_db.categorias_articulos.AddObject(cat);
            Restosoft_db.SaveChanges();
            MessageBox.Show("Nueva categoria creada." + Environment.NewLine + cat.categoria); 
        }

        void CrearGrupo()
        {
            grupos_articulos g = new grupos_articulos();
            g.grupo = "Cervezas";
            g.categorias_articulos = Restosoft_db.categorias_articulos.First();
            Restosoft_db.grupos_articulos.AddObject(g);
            Restosoft_db.SaveChanges();
            MessageBox.Show("Nuevo grupo creado." + Environment.NewLine + g.grupo);            
        }

        void CrearTurno()
        {
            turnos t = new turnos();
            t.id_turno = Guid.NewGuid();
            t.fecha_inicio = DateTime.Now;
            Restosoft_db.turnos.AddObject(t);
            Restosoft_db.SaveChanges();
            MessageBox.Show("Nuevo turno creado." + Environment.NewLine + t.fecha_inicio.ToLongDateString());  
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            CrearTurno();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CrearCategoria();
        }

        private void btnMostrarGrupo_Click(object sender, EventArgs e)
        {
            MostrarGrupo();
        }
        void MostrarGrupo()
        {
            var g = Restosoft_db.grupos_articulos.First();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID Grupo: " + g.id_grupo);
            sb.AppendLine("Nombre del Grupo: " + g.grupo);
            sb.AppendLine("ID Categoria " + g.categorias_articulos.id_categoria);
            sb.AppendLine("Categoria " + g.categorias_articulos.categoria);

            MessageBox.Show(sb.ToString(), "Mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            new Frm_MapaMesas().ShowDialog();
        }
    }
}