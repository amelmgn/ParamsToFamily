using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;

namespace ParamsToFamily
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class App : IExternalApplication
    {
        public static string assemblyPath = "";

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            try { application.CreateRibbonTab("Amel"); } catch { }

            string panelName = "Праметры";
            RibbonPanel panel = null;
            List<RibbonPanel> tryPanels = application.GetRibbonPanels("Amel").Where(i => i.Name == panelName).ToList();
            if (tryPanels.Count == 0)
            {
                panel = application.CreateRibbonPanel("Amel", panelName);
            }
            else
            {
                panel = tryPanels.First();
            }

            PushButton btn = panel.AddItem(new PushButtonData(
                "ParamsBtn",
                "Добавить \nпараметры \nк семействам",
                assemblyPath,
                "ParamsToFamily.ParamsToFamily")
                ) as PushButton;

            return Result.Succeeded;
        }
    }
}
