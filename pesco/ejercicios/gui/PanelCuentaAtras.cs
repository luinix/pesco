/**

Copyright 2011 Grupo de Investigación GEDES
Lenguajes y sistemas informáticos
Universidad de Granada

Licensed under the EUPL, Version 1.1 or – as soon they 
will be approved by the European Commission - subsequent  
versions of the EUPL (the "Licence"); 
You may not use this work except in compliance with the 
Licence. 
You may obtain a copy of the Licence at: 

http://ec.europa.eu/idabc/eupl  

Unless required by applicable law or agreed to in 
writing, software distributed under the Licence is 
distributed on an "AS IS" basis, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
express or implied. 
See the Licence for the specific language governing 
permissions and limitations under the Licence. 



*/
using Gtk;

using System;

namespace pesco
{

	[System.ComponentModel.ToolboxItem(true)]
	public partial class PanelCuentaAtras : Gtk.Bin
	{

		private int contador = 0;
		
		public PanelCuentaAtras ()
		{
			this.Build ();
		}
		
		public void setContador( int numero ) {
			
			contador = numero;
			// labelCuentaAtras.Markup = "<span foreground=\"blue\" font=\"64\">"+contador.ToString()+"</span>";
		}
		
		public int getContador() {
			return contador;
		}
			
	}
}

