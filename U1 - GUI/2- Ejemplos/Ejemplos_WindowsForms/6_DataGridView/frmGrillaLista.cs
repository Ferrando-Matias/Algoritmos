namespace _6_DataGridView
{
    public partial class frmGrillaLista : Form
    {
        // Declaro la lista justo debajo de la declaracion de la clase, para que su ambito sea a nivel formulario
        List<Persona> lPersonas = new List<Persona>();

        public frmGrillaLista()
        {
            InitializeComponent();
            this.Text = "Ejemplo de DataGridView Basico enlazado a Listas de Objetos";

            instaciarListaCargarDatos();

            configurarGrilla(dgvPrueba);

            actualizarGrilla();
        }

        #region METODOS
        private void instaciarListaCargarDatos()
        {
            lPersonas.Add(new Persona() { Identificador = 1, Apellido = "Perez", Nombres = "Juan", DNI = 12345678, Baja = false });
            lPersonas.Add(new Persona() { Identificador = 2, Apellido = "Gonzales", Nombres = "Maria", DNI = 87654321, Baja = true });
            lPersonas.Add(new Persona() { Identificador = 3, Apellido = "Gomez", Nombres = "Soledad", DNI = 94328766, Baja = false });
            lPersonas.Add(new Persona() { Identificador = 4, Apellido = "Rios", Nombres = "Joaquin", DNI = 99883453, Baja = true });
            lPersonas.Add(new Persona() { Identificador = 5, Apellido = "Salinas", Nombres = "Jorge", DNI = 94328766, Baja = false });
            lPersonas.Add(new Persona() { Identificador = 6, Apellido = "Paredes", Nombres = "Eduardo", DNI = 99883453, Baja = true });
        }

        private void configurarGrilla(DataGridView dgv)
        {
            // Doy formato a la grilla con las siguientes instrucciones
            // Comportamiento
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila al hacer click en alguna celda
            dgv.MultiSelect = false; // Que no pueda seleccionar multiples filas
            dgv.ReadOnly = true; // Hace que la grilla no se pueda editar
            dgv.AllowUserToAddRows = false; // Desactiva  la ultima fila 
            dgv.RowHeadersVisible = false; // Oculto los encabezados de filas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;    // Estilo de los bordes del datagrid
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;    // Estilo de los bordes de las celdas
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Estilo de las columnas
            dgv.GridColor = Color.Black;   // Color de las lineas divisorias
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;    // Estilo de la fila de encabezado
            dgv.BackgroundColor = Control.DefaultBackColor;

            // Grafica
            dgv.EnableHeadersVisualStyles = false; // Para poder modificar estilos en la cabecera
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Quito los bordes de la cabecera
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue; // Color de fondo de la cabecera
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Color de texto de la cabecera
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue; // Color de fondo de la celda del encabezado seleccionada
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// Centro el texto de las cabeceras
        }

        private void actualizarGrilla()
        {

            // Enlazo la lista a la grilla
            dgvPrueba.DataSource = null; // Primero debo romper un enlace anterior
            dgvPrueba.DataSource = lPersonas; // Enlazo la lista a la grilla
            // Oculto la columna correspondiente al Identificador o ID
            dgvPrueba.Columns["Identificador"].Visible = false;
            /* Cambio un encabezado de columna
             * NOTA: DEBE HACERSE LUEGO DE ENLAZAR LOS DATOS, CASO CONTRARIO DARA ERROR
             */
            dgvPrueba.Columns[4].HeaderText = "ESTADO DE LA PERSONA"; // Busco la columna por indice y le doy el nuevo texto
            // Alineo la columna 3 a la derecha
            dgvPrueba.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Desactivar la generación automática de columnas para evitar desordenar el botón
            dgvPrueba.AutoGenerateColumns = false;

            // Si no existe, agregamos el botón
            agregarBotonGrilla(dgvPrueba, "boton", "Editar", "Mostrar Nombre");

        }

        private void agregarBotonGrilla(DataGridView dgv, string nombreBoton, string nombreCabecera, string textoBoton)
        {

            // Verificar si el botón ya existe en la grilla
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name == nombreBoton) // Si la columna ya existe, salimos del método
                {
                    return;
                }
            }
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn(); // Creo el objeto 
            // Especifico las propiedades del objeto
            btn.HeaderText = nombreCabecera; // Texto que tendra la cabecera
            btn.Name = nombreBoton; // Nombre de la columna
            btn.Text = textoBoton; // Texto del boton
            btn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btn); // Agrego el objeto a la grilla

            btn.DisplayIndex = dgv.Columns.Count - 1; // Muevo el botón al final de las columnas visibles
        }

        private void ColorGrilla(DataGridView dgv, int Col)
        {
            string? text = dgv.Rows[0].Cells[Col].Value.ToString();
            Color blue = Color.DarkGray;
            Color white = Color.WhiteSmoke;
            Color color = Color.WhiteSmoke;
            for (int i = 0; i < this.dgvPrueba.Rows.Count; i++)
            {
                if (this.dgvPrueba.Rows[i].Cells[Col].Value.ToString() != text)
                {
                    color = ((!(color == blue)) ? blue : white);
                }
                this.dgvPrueba.Rows[i].DefaultCellStyle.BackColor = color;
                text = this.dgvPrueba.Rows[i].Cells[Col].Value.ToString();
            }
        }

        // Metodo para "bloquear" los controles de un formulario
        // recibe como parametro el nobre del form
        private void bloquearControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt) txt.Enabled = false;
                if (item is ComboBox cmb) cmb.Enabled = false;
                if (item is CheckBox chk) chk.Enabled = false;
                if (item is RadioButton rdb) rdb.Enabled = false;
                if (item is GroupBox | item is Panel) bloquearControles(item);
            }
        }

        // Metodo para "desbloquear" los controles de un formulario
        // recibe como parametro el nobre del form
        private void desbloquearControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt) txt.Enabled = true;
                if (item is ComboBox cmb) cmb.Enabled = true;
                if (item is CheckBox chk) chk.Enabled = true;
                if (item is RadioButton rdb) rdb.Enabled = true;
                if (item is GroupBox | item is Panel) desbloquearControles(item);
            }
        }

        // Metodo para "limpiar" los controles de un formulario
        // recibe como parametro el nobre del form
        private void LimpiarControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt) txt.Text = null;
                if (item is ComboBox cmb) cmb.Text = null;
                if (item is GroupBox | item is Panel) LimpiarControles(item);
            }
        }


        #endregion

        #region EVENTOS
        private void frmGrillaLista_Load(object sender, EventArgs e)
        {
            //Luego de actualizar la grilla, llamo a la funcion que colorea las filas
            ColorGrilla(dgvPrueba, 1);
        }

        private void chkPermitirEdicion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPermitirEdicion.CheckState == CheckState.Checked)
            {
                dgvPrueba.SelectionMode = DataGridViewSelectionMode.CellSelect; //Selecciona solo la celda clickeada
                dgvPrueba.ReadOnly = false; // Hace que la grilla se pueda editar
            }
            else
            {
                dgvPrueba.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona toda la fila
                dgvPrueba.ReadOnly = true; // Hace que la grilla no se pueda editar
            }
            dgvPrueba.Focus(); // Llevo el foco al DataGridView
        }

        private void dgvPrueba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // Este evento ocurre cuando se hace click en una celda determinada de la grilla
        {
            /* El Objeto "e" que trae el evento, contiene en su propiedad ColumnIndex, que es el
             * indice de columna en la cual se clickeo.
             */
            if (dgvPrueba.Columns[e.ColumnIndex].Name == "boton") // Si se clickeo la columna llamada boton obtengo los datos de dicha columna
            {
                int y = e.RowIndex;
                // Tomo, de la fila seleccionada, el valor de la celda "Apellido"/"Nombres" y lo convierto a String
                string Apellido = dgvPrueba.Rows[y].Cells["Apellido"].Value.ToString() ?? string.Empty; // Como la variable string no admite valores nulos, le asigno un string vacío
                string Nombre = dgvPrueba.Rows[y].Cells["Nombres"].Value.ToString() ?? string.Empty;
                MessageBox.Show($"Diste click en la persona: {Nombre} {Apellido} ");
            }
        }

        private void dgvPrueba_RowEnter(object sender, DataGridViewCellEventArgs e)
        // Este evento pertenece al DataGridView, y ocurre cualdo toma el foco o cambia de fila
        {
            if (dgvPrueba.SelectedRows.Count > 0) // Esta pregunta debo hacerla para verificar que el haya seleccionado algo en el DataGrid
            {
                // Asigno los datos de la fila seleccionada a los controles del formulario
                lblId.Text = "Identificacion Persona Nº " + dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Identificador"].Value.ToString();
                txtApellido.Text = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Apellido"].Value.ToString();
                txtNombres.Text = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["Nombres"].Value.ToString();
                txtDNI.Text = dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["DNI"].Value.ToString();
                chkBaja.Checked = (bool)dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["baja"].Value;
                lblBaja.Visible = (bool)dgvPrueba.Rows[dgvPrueba.SelectedRows[0].Index].Cells["baja"].Value;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Agregar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Visible = false;
                btnEliminar.Text = "Cancelar";

                desbloquearControles(this);
                LimpiarControles(this);
                txtApellido.Focus();
            }
            else
            {
                btnAgregar.Text = "Agregar";
                btnEliminar.Text = "Eliminar";
                btnModificar.Visible = true;


                bloquearControles(this);
                lPersonas.Add(new Persona()
                {
                    //Verifico que la lista no este vacía, si lo esta, le asigno 1 al Identificador, caso contrario, le asigno el valor máximo de la lista + 1
                    Identificador = (lPersonas.Any()) ? lPersonas.Max(x => x.Identificador) + 1 : 1,
                    Apellido = txtApellido.Text,
                    Nombres = txtNombres.Text,
                    DNI = Convert.ToInt32(txtDNI.Text),
                    Baja = chkBaja.Checked
                });
                actualizarGrilla();
                LimpiarControles(this);
                dgvPrueba.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnModificar.Text = "Guardar Cambios";
                btnAgregar.Visible = false;
                btnEliminar.Text = "Cancelar";

                desbloquearControles(this);
                txtApellido.Focus();
            }
            else
            {
                btnModificar.Text = "Modificar";
                btnAgregar.Visible = true;
                btnEliminar.Text = "Eliminar";
                bloquearControles(this);
                //Se obtiene la fila seleccionada del DataGridView (dgvPrueba) y se accede al índice del elemento en la lista lPersonas
                lPersonas[dgvPrueba.SelectedRows[0].Index].Apellido = txtApellido.Text;
                lPersonas[dgvPrueba.SelectedRows[0].Index].Nombres = txtNombres.Text;
                lPersonas[dgvPrueba.SelectedRows[0].Index].DNI = Convert.ToInt32(txtDNI.Text);
                lPersonas[dgvPrueba.SelectedRows[0].Index].Baja = chkBaja.Checked;
                actualizarGrilla();
                LimpiarControles(this);
                dgvPrueba.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (btnEliminar.Text == "Eliminar")
            {
                if (dgvPrueba.SelectedRows.Count > 0)
                {
                    lPersonas.RemoveAt(dgvPrueba.SelectedRows[0].Index);
                    actualizarGrilla();
                    LimpiarControles(this);
                    dgvPrueba.Focus();
                }
            }
            else
            {
                btnAgregar.Text = "Agregar";
                btnEliminar.Text = "Eliminar";
                btnModificar.Text = "Modificar";
                btnModificar.Visible = true;
                btnAgregar.Visible = true;

                bloquearControles(this);
                LimpiarControles(this);
                dgvPrueba.Focus();
            }
        } 
        #endregion
    }
}
