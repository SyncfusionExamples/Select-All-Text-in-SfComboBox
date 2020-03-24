using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CustomRenderer
{
	public partial class MainPageXaml : ContentPage
	{
		public MainPageXaml ()
		{
			InitializeComponent ();
		}
	}

	public class Employee
	{
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}

	public class EmployeeViewModel
	{
		private ObservableCollection<Employee> employeeCollection;
		public ObservableCollection<Employee> EmployeeCollection
		{
			get { return employeeCollection; }
			set { employeeCollection = value; }
		}
		public EmployeeViewModel()
		{
			employeeCollection = new ObservableCollection<Employee>();
			employeeCollection.Add(new Employee() { ID = 1, Name = "Frank" });
			employeeCollection.Add(new Employee() { ID = 2, Name = "James" });
			employeeCollection.Add(new Employee() { ID = 3, Name = "Steve" });
			employeeCollection.Add(new Employee() { ID = 4, Name = "Lucas" });
			employeeCollection.Add(new Employee() { ID = 5, Name = "Mark" });
			employeeCollection.Add(new Employee() { ID = 6, Name = "Michael" });
			employeeCollection.Add(new Employee() { ID = 7, Name = "Aldrin" });
			employeeCollection.Add(new Employee() { ID = 8, Name = "Jack" });
			employeeCollection.Add(new Employee() { ID = 9, Name = "Howard" });
		}
	}
}

