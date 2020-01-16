using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace ParamsToFamily
{
	[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
	class ParamsToFamily : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
			ParamsDialog form1 = new ParamsDialog();
			form1.ShowDialog();

			if (form1.DialogResult != System.Windows.Forms.DialogResult.OK)
			{
				return Result.Cancelled;
			}
			
			Document doc = commandData.Application.ActiveUIDocument.Document;
			ElementId selFiId = null;
			FamilyParameter FamilyParParent = null;
			Parameter SubPar = null;
			FamilyManager FM = null;
			FamilyManager SFM = null;
			string ParName =  form1.parParentName;
			string SubParName = form1.parNestedName;

			Selection sel = commandData.Application.ActiveUIDocument.Selection;
			if (sel.GetElementIds().Count == 0)
			{
				Reference R = sel.PickObject(ObjectType.Element, "Выберите семейство");
				selFiId = R.ElementId;
			}
			else
			{
				selFiId = sel.GetElementIds().First();
			}

			FamilyInstance selFi = doc.GetElement(selFiId) as FamilyInstance;
			Element FamEl = selFi as Element;

			Document FamilyDoc = doc.EditFamily(selFi.Symbol.Family);

			FamilyDoc.LoadFamily(doc, new FamilyOption());

			List<FamilyInstance> SubFamList = new FilteredElementCollector(FamilyDoc)
				.OfClass(typeof(FamilyInstance))
				.Cast<FamilyInstance>()
				.ToList();

			if (FamilyDoc != null && FamilyDoc.IsFamilyDocument == true)
			{
				FM = FamilyDoc.FamilyManager;

				using (Transaction t = new Transaction(FamilyDoc))
				{
					t.Start("Добавление параметров");

					if (selFi.LookupParameter(ParName) == null)
					{
						FamilyParameter ParParent = FM.AddParameter(ParName, BuiltInParameterGroup.PG_TEXT, ParameterType.Length, form1.ParIsInst);
						FM.Set(ParParent, 100.0 / 304.8);
					}
					else
					{
						TaskDialog.Show("Предупреждение", "Параметр " + ParName + " у экземпляра " + selFi.Name + " существует");
					}

					t.Commit();
				}

				FamilyParParent = FM.get_Parameter(ParName);
			}

			foreach (FamilyInstance i in SubFamList)
			{
				Document SubFamilyDoc = FamilyDoc.EditFamily(i.Symbol.Family);

				try
				{

					SubFamilyDoc.LoadFamily(FamilyDoc, new FamilyOption());

					if (SubFamilyDoc != null && SubFamilyDoc.IsFamilyDocument == true)
					{
						SFM = SubFamilyDoc.FamilyManager;
						Element SubFamEl = i as Element;

						bool isInstance;
						if (i.Symbol.Family.get_Parameter(BuiltInParameter.FAMILY_SHARED).AsInteger() == 1)
						{
							isInstance = true;
						}
						else
						{
							isInstance = false;
						}

						using (Transaction t = new Transaction(SubFamilyDoc))
						{
							t.Start("Добавление параметров во вложенное семейство");

							if (i.LookupParameter(SubParName) == null)
							{
								FamilyParameter ParNested = SFM.AddParameter(SubParName, BuiltInParameterGroup.PG_TEXT, ParameterType.Length, isInstance);
							}
							else
							{
								TaskDialog.Show("Предупреждение", "Параметр " + SubParName + " у экземпляра " + i.Name + " существует");
							}

							t.Commit();
						}

						SubFamilyDoc.LoadFamily(FamilyDoc, new FamilyOption());

						if (form1.ParIsInst == true)
						{
							SubPar = SubFamEl.LookupParameter(SubParName);
						}
						else
						{
							SubPar = i.Symbol.LookupParameter(SubParName);
						}
					}
				}
				catch(Exception ex)
				{
					SubFamilyDoc.Close(false);
					message += ex.Message;
					return Result.Failed;
				}

					using (Transaction t = new Transaction(FamilyDoc))
					{
						t.Start("Связывание параметров семейств");

						FM.AssociateElementParameterToFamilyParameter(SubPar, FamilyParParent);

						t.Commit();
					}

			}

			FamilyDoc.LoadFamily(doc, new FamilyOption());
			return Result.Succeeded;
		}

		class FamilyOption : IFamilyLoadOptions
		{

			public bool OnFamilyFound(bool familyInUse, out bool overwriteParameterValues)
			{
				overwriteParameterValues = true;
				return true;
			}

			public bool OnSharedFamilyFound(Family sharedFamily, bool familyInUse, out FamilySource source, out bool overwriteParameterValues)
			{
				source = FamilySource.Family;
				overwriteParameterValues = true;
				return true;
			}
		}

	}
}
