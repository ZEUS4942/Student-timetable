using System;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
	public class CGroup : Controller, IController
	{
		public CGroup() : base("Группа")
		{
			DataColumn[] keys = new DataColumn[9];

			DataColumn column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Position";
			column.ReadOnly = false;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Group";
			column.ReadOnly = true;
			column.Unique = true;
			table.Columns.Add(column);

			keys[0] = column;

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Semestr";
			column.ReadOnly = true;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Specialty";
			column.ReadOnly = true;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Shift";
			column.ReadOnly = true;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "Students";
			column.ReadOnly = true;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MinNumberOfClass";
			column.ReadOnly = true;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(ushort);
			column.ColumnName = "MaxNumberOfClass";
			column.ReadOnly = true;
			table.Columns.Add(column);

			column = new DataColumn();
			column.DataType = typeof(string);
			column.ColumnName = "Weekends";
			column.ReadOnly = true;
			table.Columns.Add(column);

			table.PrimaryKey = keys;
		}
		public override bool Delete(Model model)
		{
			MGroup mGroup = (MGroup)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				if ((string)table.Rows[i]["Group"] == mGroup.Group)
				{
					table.Rows[i].Delete();
					Recount(i);
					return true;
				}
			}
			return false;
		}

		private void Recount(int pos)
		{
			for (int i = pos; i < table.Rows.Count; i++)
			{
				table.Rows[i]["Position"] = (ushort)table.Rows[i]["Position"] - 1;
			}
		}


		private bool isValidKey(MGroup mGroup)
		{
			foreach (DataRow Row in table.Rows)
			{
				if (mGroup.Group == (string)Row["Group"])
					return false;
			}
			return true;
		}


		public override bool Insert(Model model)
		{
			MGroup mGroup = (MGroup)model;

			if (isValidKey(mGroup))
			{
				try
				{
					DataRow newRow = table.NewRow();
					newRow["ID"] = Guid.NewGuid();
					newRow["Position"] = table.Rows.Count + 1;
					newRow["Group"] = mGroup.Group;
					newRow["Semestr"] = mGroup.Semester;
					newRow["Specialty"] = mGroup.Specialty;
					newRow["Shift"] = mGroup.Shift;
					newRow["Students"] = mGroup.Students;
					newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
					newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
					newRow["Weekends"] = mGroup.Weekends;
					table.Rows.Add(newRow);
					return true;
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Source);
					return false;
				}
			}

			return false;

		}

		public override bool Update(Model model)
		{
			MGroup mGroup = (MGroup)model;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				
				if ((ushort)table.Rows[i]["Position"] == mGroup.Position)
					try
					{
						table.Rows[i].Delete();
						DataRow newRow = table.NewRow();
						newRow["ID"] = mGroup.ID;
						newRow["Position"] = mGroup.Position;
						newRow["Group"] = mGroup.Group;
						newRow["Semestr"] = mGroup.Semester;
						newRow["Specialty"] = mGroup.Specialty;
						newRow["Shift"] = mGroup.Shift;
						newRow["Students"] = mGroup.Students;
						newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
						newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
						newRow["Weekends"] = mGroup.Weekends;
						table.Rows.Add(newRow);
						return true;
					}
					catch (Exception ex)
					{
						Debug.WriteLine(ex.Source);
						return false;
					}

			}
			return false;
		}
		public  bool Update(Model model, DataRow row)
		{

			MGroup mGroup = (MGroup)model;
			table.Rows[0]["Group"] = row;
			return true;
			// По заданию мне было велено организовывать проверку на совпадение старой и новой строки группы не здесь,так что пусть всё время возвращает истину.
			//Делал по заданию.
		}
	}
}
