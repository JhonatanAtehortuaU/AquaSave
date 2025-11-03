using AquaSave.Models;
using AquaSave.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaSave.Forms
{
    public partial class FormMain : Form
    {
        private User _usuario;
        private InMemoryRepository _repo;

        public FormMain(User usuario, InMemoryRepository repo)
        {
            InitializeComponent();
            _usuario = usuario;
            _repo = repo;

            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.Text = $"AquaSave {_usuario.nombreCompleto}";

            var retosDiarios = _repo.RetoDiarios(_usuario.correo);
            var retoSemanales = _repo.RetoSemanales(_usuario.correo);

            if ((retosDiarios == null || retosDiarios.Count == 0) &&
                (retoSemanales == null || retoSemanales.Count == 0))
            {
                MessageBox.Show("No tienes retos asignados actualmente.", "Información");
                return;
            }

            dataGridDiarios.DataSource = retosDiarios;
            dataGridSemanales.DataSource = retoSemanales;

            //Ocultar columnas
            OcultarColumnas(dataGridDiarios);
            OcultarColumnas(dataGridSemanales);

        }

        private void OcultarColumnas(DataGridView grid)
        {
            if (grid.Columns.Count == 0) return;

            if (grid.Columns.Contains("id"))
                grid.Columns["id"].Visible = false;

            if (grid.Columns.Contains("usuarioAsig"))
                grid.Columns["usuarioAsig"].Visible = false;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ReadOnly = true;
            grid    .SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridDiarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si se hace doble clic en el encabezado
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            var fila = dataGridDiarios.Rows[e.RowIndex];

            string titulo = fila.Cells["titulo"].Value?.ToString() ?? "Sin título";
            string descripcion = fila.Cells["descripcion"].Value?.ToString() ?? "Sin descripción";
            string tipo = fila.Cells["tipo"].Value?.ToString() ?? "N/A";
            string puntos = fila.Cells["puntos"].Value?.ToString() ?? "0";

            MessageBox.Show(
                $"Reto: {titulo}\n\nDescripción: {descripcion}\nTipo: {tipo}\nPuntos: {puntos}",
                "Detalle del reto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

    }
}
