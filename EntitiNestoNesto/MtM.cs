using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiNestoNesto
{
	public class Artikal
	{
		public int Id { get; set; }
		public string Naziv { get; set; }
		public List<Racun> Racuni { get; set; } = new List<Racun>();
	}

	public class Racun
	{
		public int Rbr { get; set; }
		public List<Artikal> Artikli { get; set; } = new List<Artikal>();

	}
}
