using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;

namespace FindPanelExample {
    public partial class MainForm :XtraForm {
        const string Alphabet = "abcdefghigklmnopqarstuvwxyz";
        static Random Randomizer = new Random();

        public MainForm() {
            InitializeComponent();
            GridControl.BeginUpdate();
            try {
                for (int i = 0; i < 1000; i++)
                    for (int j = 0; j < 10; j++)
                        dataTable1.Rows.Add(GetRandomText(), i);
            } finally { GridControl.EndUpdate(); }
        }

        static string GetRandomText() {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 10; i++)
                result.Append(Alphabet[Randomizer.Next(27)]);
            return result.ToString();
        }

        void OnGridViewRowCountChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(GridView.FindFilterText)) return;
            BeginInvoke(new MethodInvoker(ExpandVisibleRows));
        }

        void ExpandVisibleRows() {
            int rowHandle;
            for (int i = GridView.TopRowIndex; GridView.IsRowVisible(rowHandle =
                GridView.GetVisibleRowHandle(i)) == RowVisibleState.Visible; i++)
                if (GridView.IsGroupRow(rowHandle))
                    GridView.ExpandGroupRow(rowHandle);
        }
    }
}