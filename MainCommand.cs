using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    [Autodesk.Revit.Attributes.TransactionAttribute(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class MainCommand : IExternalCommand
    {
        static AddInId AddInId = new AddInId(new Guid("1B8F0C4B-B7B7-4260-B6F4-2711479B8153"));
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var uidocument = commandData.Application.ActiveUIDocument;
            var document = uidocument.Document;
            Reference reference = null;
            try
            {
                reference = uidocument.Selection.PickObject(ObjectType.Element);
            }
            catch
            {
                return Result.Cancelled;
            }

            var element = document.GetElement(reference);
            //var parameters = new List<Parameter>();
            var parameterSet = element.Parameters;

            MainWindow window = new MainWindow();
            window.Element = element;
            foreach (var paramObj in parameterSet)
            {
                var parameter = paramObj as Parameter;
                if (parameter.StorageType == StorageType.ElementId) continue;
                //parameters.Add(parameter);
                window.ParametersBox.Items.Add(parameter.Definition.Name);
            }

            //window.ParametersBox.DataSource = parameters;
            //window.ParametersBox.DisplayMember = "Definition.Name";

            window.ShowDialog();

            return Result.Succeeded;

        }
    }
}
