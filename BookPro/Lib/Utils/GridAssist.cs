using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPro.Lib.Utils
{
  public static class GridAssist
  {
    public static String GetGridSortQuery(DataGridView aGirdView)
    {
      String _SortQuery = "";
      DataGridViewColumn _Column = aGirdView.SortedColumn;

      if (_Column != null)
      {
        String _SortFieldName = _Column.DataPropertyName;

        SortOrder _SortOrder = aGirdView.SortOrder;
        if (_SortOrder == SortOrder.Ascending)
        {
          _SortQuery = String.Format(" {0} ASC", _SortFieldName);
        }
        else
        {
          _SortQuery = String.Format(" {0} DESC", _SortFieldName);
        }
      }

      return _SortQuery;
    }

    public static DataRow SelectedRow(DataGridView aGridView)
    {
      DataRow _Row = null;
      DataTable _Table = null;
      String _TableName = aGridView.DataMember;
      if (aGridView.DataSource is DataSet)
      {
        DataSet _DataSet = aGridView.DataSource as DataSet;
        _Table = _DataSet.Tables[_TableName];
      }
      else if (aGridView.DataSource is DataTable)
      {
        _Table = aGridView.DataSource as DataTable;
      }

      if (_Table != null)
      {
        String _SortQuery = GetGridSortQuery(aGridView);
        DataRow[] _SortedRows = _Table.Select("", _SortQuery);

        int _SelectedIndex = -1;
        if (aGridView.CurrentRow != null)
        {
          _SelectedIndex = aGridView.CurrentRow.Index;
        }

        if (_SelectedIndex >= 0 && _SelectedIndex < _SortedRows.Length)
        {
          _Row = _SortedRows[_SelectedIndex];
        }

      }


      return _Row;
    }

    public static DataRow SortedRow(DataGridView aGridView, int _SelectedIndex)
    {
      DataRow _Row = null;
      DataTable _Table = null;
      String _TableName = aGridView.DataMember;
      if (aGridView.DataSource is DataSet)
      {
        DataSet _DataSet = aGridView.DataSource as DataSet;
        _Table = _DataSet.Tables[_TableName];
      }
      else if (aGridView.DataSource is DataTable)
      {
        _Table = aGridView.DataSource as DataTable;
      }
      if (_Table != null)
      {
        String _SortQuery = GetGridSortQuery(aGridView);
        DataRow[] _SortedRows = _Table.Select("", _SortQuery);

        if (_SelectedIndex >= 0 && _SelectedIndex < _SortedRows.Length)
        {
          _Row = _SortedRows[_SelectedIndex];
        }
      }

      return _Row;
    }
  }
}
