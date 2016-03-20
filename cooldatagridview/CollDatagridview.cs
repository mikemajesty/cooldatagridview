using System.Windows.Forms;

namespace cooldatagridview
{
    public static class CollDatagridview
    {
        public static void CoolGrid(this DataGridView dgv)
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            dgv.AllowDrop = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = System.Drawing.Color.White;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellStyle.ForeColor = System.Drawing.Color.Black;
            cellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;
            cellStyle.WrapMode = DataGridViewTriState.True;
            dgv.DefaultCellStyle = cellStyle;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.SystemColors.Window;
            headerStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerStyle.ForeColor = System.Drawing.Color.Black;
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = System.Drawing.Color.Black;
            headerStyle.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.TabIndex = 0;
            dgv.TabStop = false;

        }
        public static void MoveToUp(this DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int indexUp = dgv.SelectedRows[0].Index;
                if (indexUp > 0)
                {
                    dgv.Rows[indexUp].Selected = false;
                    dgv.Rows[indexUp - 1].Selected = true;
                }
            }
        }
        public static void MoveToDown(this DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int indexDown = dgv.SelectedRows[0].Index;
                if (indexDown >= 0 && indexDown < dgv.Rows.Count - 1)
                {
                    dgv.Rows[indexDown].Selected = false;
                    dgv.Rows[indexDown + 1].Selected = true;
                }
            }
        }
        public static void HideColumn(this DataGridView dgv, string columnName)
        {
            dgv.Columns[columnName].Visible = false;
        }
    }
}
