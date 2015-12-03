using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutGestaoOPE.Forms
{
    class ClsUtil
    {
        public static bool IsNumeric(string s)
        {
            int output;
            return int.TryParse(s, out output);
        }

        public void criarGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.ColumnCount = 2;
            dgv.CurrentCell = null;

            var _columnHeader = dgv.ColumnHeadersDefaultCellStyle;
            _columnHeader.BackColor = Color.Navy;
            _columnHeader.ForeColor = Color.White;
            _columnHeader.Font = new Font("Garamond", 12, FontStyle.Bold);

            dgv.Columns[0].HeaderText = "Codigo";
            dgv.Columns[0].Name = "Codigo";
            dgv.Columns[0].Width = 218;
            dgv.Columns[0].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Regular);
            dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[0].DividerWidth = 1;
            dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].HeaderText = "Nome";
            dgv.Columns[1].Name = "Nome";
            dgv.Columns[1].Width = 330;
            dgv.Columns[1].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Regular);
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[1].DividerWidth = 1;
            dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgv.GridColor = Color.Black;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Beige;
        }

        public static String converterNumero(string hora)
        {
            if(hora.Length >= 16) {
                return hora.Substring(11, hora.Length - 11);
            }

            return "";
        }

    }
}
