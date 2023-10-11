using Parameter = Autodesk.Revit.DB.Parameter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace WindowsFormsApp
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Element Element { get; set; }

        private void SelectionChanged(object sender, EventArgs e)
        {
            var parameterName = ParametersBox.SelectedItem as string;
            var parameter = Element.LookupParameter(parameterName);
            TextUserValue.Text = parameter?.AsValueString();            
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (this.ParametersBox.SelectedIndex == -1) return;
            var parameterName = ParametersBox.SelectedItem as string;
            var parameter = Element.LookupParameter(parameterName);
            var document = Element.Document;
            using (Transaction transaction = new Transaction(document, "Обновление значения"))
            {
                transaction.Start();
                bool result = false;
                if (parameter.StorageType == StorageType.String)
                {
                    result = parameter.Set(TextUserValue.Text);
                }
                else if (parameter.StorageType == StorageType.Integer)
                {
                    try
                    {
                        result = parameter.Set(int.Parse(TextUserValue.Text));
                    }
                    catch { }
                }
                else if (parameter.StorageType == StorageType.Double)
                {
                    try
                    {
                        var value = double.Parse(TextUserValue.Text);
                        value = UnitUtils.ConvertToInternalUnits(value, parameter.GetUnitTypeId());
                        result = parameter.Set(value);
                    }
                    catch { }
                }
                if (result)
                {
                    TaskDialog.Show("Результат", "Значение параметра обновлено");
                    transaction.Commit();
                }
                else
                {
                    TaskDialog.Show("Результат", "Значение параметра обновить не удалось");
                    transaction.Commit();
                }
                Close();
            }
        }
    }
}
