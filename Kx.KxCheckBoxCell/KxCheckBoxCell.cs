using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Kx.KxCheckBoxCell.Properties;

namespace Kx.KxCheckBoxCell
{
    public class KxCheckBoxCell : System.Windows.Forms.DataGridViewImageCell
    {
        public bool Checked { get; set; }
    }

    public class KxCheckBoxColumn : System.Windows.Forms.DataGridViewImageColumn
    {
        private DataGridView grid = null;

        public KxCheckBoxColumn(DataGridView grid)
        {
            Resources.x_on.Tag = true;
            Resources.x_off.Tag = false;

            this.Image = Resources.x_off;
            this.CellTemplate = new KxCheckBoxCell();

            this.grid = grid;
            this.grid.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && this.grid.Columns[e.ColumnIndex].Name == this.Name)
            {
                var cell = ((KxCheckBoxCell)this.grid.Rows[e.RowIndex].Cells[this.Name]);
                if (cell != null)
                {
                    if (cell.Checked)
                    {
                        cell.Value = Resources.x_off;
                        cell.Checked = false;
                    }
                    else
                    {
                        cell.Value = Resources.x_on;
                        cell.Checked = true;
                    }
                }
            }
        }
    }
}
