using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
	public class MessageModel : IMessageModel
	{
		public string UserName { get; set; }
		public string Content { get; set; }
		public DateTime PostedOn { get; set; }
		public string Tag { get; set; }
	}
}
