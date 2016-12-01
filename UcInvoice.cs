using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DataMiner
{
	/// <summary>
	/// Description of UcInvoice.
	/// </summary>
	public partial class UcInvoice : UserControl
	{
		string invoiceNumber;
		
		public UcInvoice(string number, DateTime time)
		{
			InitializeComponent();
			
			invoiceNumber = number;
			lblInvoiceNumber.Text = number;
			lblDateTime.Text = time.ToString("dd/mm/yyyy HH:MM");
		}
		
		/// <summary>
		/// When the view invoice button is pressed
		/// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
		void BtnViewClick(object sender, EventArgs e)
		{
			(ParentForm as FrmMain).SearchTerm = invoiceNumber;
			(ParentForm as FrmMain).FindInvoice();
		}
	}
}
