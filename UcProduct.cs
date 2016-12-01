using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DataMiner
{
	/// <summary>
	/// Description of UcProduct.
	/// </summary>
	public partial class UcProduct : UserControl
	{
		public UcProduct(string stockCode, string description, float unitPrice, int quantity)
		{
			InitializeComponent();
			
			lblCodeName.Text = stockCode + ": " + description;
			lblUnitPrice.Text = "£" + unitPrice.ToString("F");;
			lblQuantity.Text = "x " + quantity.ToString() + " =";
			lblTotal.Text = "£" + (unitPrice * (float)quantity).ToString("F");
		}
	}
}
