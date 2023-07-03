using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
	public class ImmediateAttentionDataModel : IImmediateAttentionDataModel
	{
		public string Item { get; set; }
		public int Occurrences { get; set; }
	}
}
