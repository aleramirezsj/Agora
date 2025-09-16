using System.Data;
using Service.Models;
using Service.Services;

namespace Desktop.Views
{
    public partial class CapacitacionesView : Form
    {
        GenericService<Capacitacion> _capacitacionService = new GenericService<Capacitacion>();
        Capacitacion _currentCapacitacion;
        List<Capacitacion>? _capacitaciones;

        public CapacitacionesView()
        {
            InitializeComponent();
            _ = GetAllData();
        }


        private async Task GetAllData()
        {
            if (checkVerEliminados.Checked)
                _capacitaciones = await _capacitacionService.GetAllDeletedsAsync();
            else
                _capacitaciones = await _capacitacionService.GetAllAsync();

            DataGrid.DataSource = _capacitaciones;
            DataGrid.Columns["Id"].Visible = false; // Ocultar la columna Pais
            DataGrid.Columns["IsDeleted"].Visible = false; // Ocultar la columna Eliminado

        }

        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                //Capacitacion _curr = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                //FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)DataGrid.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar la capacitación {entitySelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _capacitacionService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Nombre} eliminada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la capacitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabPageAgregarEditar");
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtTitulo.Clear();
            NumericDuracion.Value = 0;
            TxtPortada.Clear();
            ComboPaises.SelectedIndex = -1; // No seleccionar ningún país
            NumericCalificacion.Value = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Pelicula peliculaAGuardar = new Pelicula
            //{
            //    id = peliculaModificada?.id ??null, 
            //    titulo = TxtTitulo.Text,
            //    duracion = (int)NumericDuracion.Value,
            //    portada = TxtPortada.Text,
            //    calificacion = (double)NumericCalificacion.Value,
            //    PaisId = (int?)ComboPaises.SelectedValue, // Asignar el ID del país seleccionado
            //};

            //bool response;
            //if (peliculaModificada != null)
            //{
            //    response=await peliculaService.UpdateAsync(peliculaAGuardar);
            //}
            //else
            //{
            //    response = await peliculaService.AddAsync(peliculaAGuardar);
            //}
            //if (response)
            //{
            //    peliculaModificada = null; // Reset the modified movie after saving
            //    LabelStatusMessage.Text = "Pelicula guardada correctamente";
            //    TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
            //    ObtenemosPeliculas();
            //    LimpiarControlesAgregarEditar();
            //    TabControl.SelectTab("TabPageLista");
            //}
            //else
            //{
            //    MessageBox.Show("Error al agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            //if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            //{
            //    peliculaModificada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
            //    TxtTitulo.Text = peliculaModificada.titulo;
            //    NumericDuracion.Value = peliculaModificada.duracion;
            //    TxtPortada.Text = peliculaModificada.portada;
            //    NumericCalificacion.Value = (decimal)peliculaModificada.calificacion;
            //    // Asignar el país seleccionado al ComboBox
            //    if (peliculaModificada.PaisId != null)
            //    {
            //        ComboPaises.SelectedValue = peliculaModificada.PaisId;
            //    }
            //    else
            //    {
            //        ComboPaises.SelectedIndex = -1; // No seleccionar ningún país si es nulo
            //    }
            //    TabControl.SelectTab("TabPageAgregarEditar");
            //}
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //GridPeliculas.DataSource = peliculas.Where(p => p.titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
            //    .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }

        private async void checkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (!checkVerEliminados.Checked) return;
            //checheamos que haya peliculas seleccionadas
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)DataGrid.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que recuper la capacitación {entitySelected.Nombre}?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _capacitacionService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Nombre} restaurada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar la capacitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para restaurarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
