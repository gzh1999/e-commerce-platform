using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class FourThis
    {

        public string Base { get; set; }
		private string returnBaseTool;

		public string BaseTool
		{
			get { return returnBaseTool; }
			set { returnBaseTool = "真的"; }
		}

	}
}
