using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EntitiNestoNesto
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			EF baza = new EF();
			//baza.Adresas.ToList();
			//var oso = baza.Osobas.FirstOrDefault();


			//DataContext = oso;
			//dg.ItemsSource = oso.Adrese;

			/*Osoba o = new Osoba();
			o.Ime = "Pera";
			o.Prezime = "Peric";
			o.Adrese.Add(new Adresa());
			
		
			baza.Osobas.Add(o);

			baza.SaveChanges(); */

			Artikal a1 = new Artikal();
			Artikal a2 = new Artikal();
			Racun r1 = new Racun();
			Racun r2 = new Racun();
			r1.Artikli.Add(a1);
			r1.Artikli.Add(a2);
			r2.Artikli.Add(a1);
			r2.Artikli.Add(a2);

			baza.Racuns.Add(r1);
			baza.Racuns.Add(r2);
			baza.SaveChanges();
		}
	}
}
