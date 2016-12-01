using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace DataMiner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ofdFilePicker.FileName = "";
        }



        #region Variables



        //Storage for the read information
        List<Invoice> allInvoices;
        List<Product> allProducts;
        List<Customer> allCustomers;

        //Mandatory graph information
        float[] totalItemsSoldPerMonth;
        float[] totalValueSoldPerMonth;
        List<Customer>[] uniqueCustomersPerMonth;
        float[] totalUniqueCustomersPerMonth;
        float[] totalInvoicesPerMonth;

        //Pick-one graph information
        List<int>[] itemsPerInvoicePerMonth;
        float[] averageItemsPerInvoicePerMonth;

        //Mandatory graph percentage information
        float[] totalItemsSoldPerMonthPercentages;
        float[] totalValueSoldPerMonthPercentages;
        float[] uniqueCustomersPerMonthPercentages;
        float[] totalInvoicesPerMonthPercentages;

        //Pick-one graph percentage information
        float[] averageItemsPerInvoicePerMonthPercentages;

        //Constants
        string[] graphFullNames =
        {
            "The total number of items sold per month",
            "The total value of items sold per month (£)",
            "The number of unique customers per month",
            "The total number of invoices per month",
            "The average number of items sold per invoice per month"
        };
        float[][] graphPercentValues;
        float[][] graphActualValues;
        float[] graphMaxValues;
        int currentGraph;
        Label[] barValues;
        Panel[] bars;
        Color[] barColours = new Color[] { Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red, Color.Red };
        BackgroundWorker bwAnalyse;
        Bitmap imageToPrint;
		
		//For UserControl acess
        public string SearchTerm
        {
        	set
        	{
        		tbxID.Text = value;
        	}
        }
        
        

        #endregion
        #region Methods



        /// <summary>
        /// Runs file-picking and and a background worker for data-analysing
        /// </summary>
        /// <code>
        /// Ask the user to select a file
        /// If they do:
        ///     Clear any current graph
        ///     Create and run a backgroundworker on the data in the file
        /// </code>
        private void Run()
        {
            //Ask the user to select a file
            DialogResult result = ofdFilePicker.ShowDialog();
            //If they do:
            if (result == DialogResult.OK)
            {
                pbDataAnalysing.Visible = true;
                //Clear any current graph
                ClearGraph();
                //Create and run a backgroundworker on the data in the file
                bwAnalyse = new BackgroundWorker();
                bwAnalyse.WorkerSupportsCancellation = true;
                bwAnalyse.DoWork += BwAnalyse_DoWork;
                bwAnalyse.RunWorkerCompleted += BwAnalyse_RunWorkerCompleted;
                bwAnalyse.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Removes all of the graph from the graph area
        /// </summary>
        /// <code>
        /// Remove the border
        /// Remove the Y-axis Values
        /// Remove the X-axis Values
        /// Remove the bars
        /// Lock the graph Buttons
        /// Remove the titles
        /// </code>
        private void ClearGraph()
        {
            //Remove the border
            tlpGraph.BorderStyle = BorderStyle.None;
            //Remove the Y-axis Values
            lblMaxValue.Text = "";
            lblMidValue.Text = "";
            lblMinValue.Text = "";
            //Remove the X-axis Values
            tlpMonthHolder.Visible = false;
            //Remove the bars
            foreach (Panel bar in bars)
            {
                bar.Height = 0;
            }
            //Lock the graph Buttons
            foreach (Control control in gbxValuesPerMonth.Controls)
                control.Enabled = false;
            foreach (Control control in gbxAveragesPerMonth.Controls)
                control.Enabled = false;
            foreach (Control control in gbxLookUps.Controls)
        		control.Enabled = false;
            //Remove the titles
            lblFileName.Text = "";
            lblGraphTitle.Text = "";

        }

        /// <summary>
        /// Reads the data in the user-selected file into allInvoices, allProducts, and allCustomers
        /// </summary>
        /// <code>
        /// Clear all current data
        /// For the length of the file:
        ///     Read the line of data into an array
        ///     
        ///     Find the current product if it already exists
        ///     If the current product doesn't exist then make it
        ///     
        ///     Find the current customer if it already exists
        ///     If the current customer doesn't exist then make it
        ///     
        ///     Find the current invoice if it already exists
        ///     If the current invoice doesn't exist then make it
        /// 
        ///     Add the line of the file to it's corresponding invoice
        /// </code>
        /// <param name="uri">The file location of the data to read</param>
        private void ReadData(string uri)
        {
            //Clear all current data
            allProducts = new List<Product>();
            allCustomers = new List<Customer>();
            allInvoices = new List<Invoice>();

            using (StreamReader reader = new StreamReader(uri))
            {
                reader.ReadLine();
                //For the length of the file:
                while (!reader.EndOfStream)
                {
                    //Read the line of data into an array
                    //(Invoice Number, Stock code, Description, Quantity, Invoice date, Unit price, Customer ID)
                    //(Using Regex.Split instead of String.Split to allow the use of .CSV files with commas in their data)
                    string[] lineData = Regex.Split(reader.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    Product currentProduct = null;
                    Customer currentCustomer = null;
                    Invoice currentInvoice = null;

                    //Find the current product if it already exists
                    foreach (Product product in allProducts)
                    {
                        if (lineData[1] == product.StockCode)
                            currentProduct = product;
                    }

                    //If the current product doesn't exist then make it
                    if (currentProduct == null)
                    {
                        currentProduct = new Product(lineData[1], lineData[2], float.Parse(lineData[5]));
                        allProducts.Add(currentProduct);
                    }

                    //Find the current customer if it already exists
                    foreach (Customer customer in allCustomers)
                    {
                        if (lineData[6] == customer.ID)
                            currentCustomer = customer;
                    }

                    //If the current customer doesn't exist then make it
                    if (currentCustomer == null)
                    {
                        currentCustomer = new Customer(lineData[6]);
                        allCustomers.Add(currentCustomer);
                    }

                    //Find the current invoice if it already exists
                    foreach (Invoice invoice in allInvoices)
                    {
                        if (lineData[0] == invoice.InvoiceNumber)
                            currentInvoice = invoice;
                    }

                    //If the current invoice doesn't exist then make it
                    if (currentInvoice == null)
                    {
                        currentInvoice = new Invoice(lineData[0], currentCustomer, Convert.ToDateTime(lineData[4]));
                        allInvoices.Add(currentInvoice);
                    }

                    //Add the line of the file to it's corresponding invoice
                    currentInvoice.AddProduct(currentProduct,Convert.ToInt32(lineData[3]));
                    
                    currentCustomer.AddInvoice(currentInvoice);
                }
            }
        }

        /// <summary>
        /// Takes the read data and generates the values for the graphs
        /// </summary>
        /// <code>
        /// Clear all current value data
        /// Clear all current percentage data
        /// Group all the data together
        /// For each invoice in the system:
        ///     Find it's month and minus 1
        ///     Add the invoice's information to the correct month in the arrays
        /// Average the 3 pick-one options
        /// Calculate the max values per data set
        /// Calculate the percentages of each month compared to the max value
        /// </code>
        private void AnalyseData()
        {
            //Clear all current value data
            totalItemsSoldPerMonth = new float[12];
            totalValueSoldPerMonth = new float[12];
            uniqueCustomersPerMonth = new List<Customer>[12];
            for (int i = 0; i < uniqueCustomersPerMonth.Length; i++)
            {
                uniqueCustomersPerMonth[i] = new List<Customer>();
            }
            totalUniqueCustomersPerMonth = new float[12];
            totalInvoicesPerMonth = new float[12];

            itemsPerInvoicePerMonth = new List<int>[12];
            for (int i = 0; i < itemsPerInvoicePerMonth.Length; i++)
            {
                itemsPerInvoicePerMonth[i] = new List<int>();
            }

            averageItemsPerInvoicePerMonth = new float[12];

            //Clear all current percentage data
            totalItemsSoldPerMonthPercentages = new float[12];
            totalValueSoldPerMonthPercentages = new float[12];
            uniqueCustomersPerMonthPercentages = new float[12];
            totalInvoicesPerMonthPercentages = new float[12];

            averageItemsPerInvoicePerMonthPercentages = new float[12];

            //Group all the data together
            graphActualValues = new float[][]
            {
                totalItemsSoldPerMonth,
                totalValueSoldPerMonth,
                totalUniqueCustomersPerMonth,
                totalInvoicesPerMonth,

                averageItemsPerInvoicePerMonth
            };

            graphPercentValues = new float[][]
            {
                totalItemsSoldPerMonthPercentages,
                totalValueSoldPerMonthPercentages,
                uniqueCustomersPerMonthPercentages,
                totalInvoicesPerMonthPercentages,

                averageItemsPerInvoicePerMonthPercentages
            };

            //For each invoice in the system:
            foreach (Invoice invoice in allInvoices)
            {
                //Find it's month and minus 1
                //(The -1 is because Jan is month 1 but at index 0 in the arrays, Feb is month 2 but at index 1, etc..)
                int month = invoice.TransactionTime.Month - 1;

                //Add the invoice's information to the correct month in the arrays
                //(The 4 mandatory analytics)
                totalItemsSoldPerMonth[month] += invoice.TotalQuantity();
                totalValueSoldPerMonth[month] += invoice.TotalValue();
                if (!uniqueCustomersPerMonth[month].Contains(invoice.Customer))
                    uniqueCustomersPerMonth[month].Add(invoice.Customer);
                totalInvoicesPerMonth[month]++;

                //(The pick-one analytic)
                itemsPerInvoicePerMonth[month].Add(invoice.TotalQuantity());
                
            }
            for (int i = 0; i < uniqueCustomersPerMonth.Length; i++)
            {
                totalUniqueCustomersPerMonth[i] = uniqueCustomersPerMonth[i].Count;
            }

            //Average the pick-one option
            for (int i = 0; i < itemsPerInvoicePerMonth.Length; i++)
            {
                int total = 0;
                float average = 0;

                if (itemsPerInvoicePerMonth[i].Count == 0)
                    averageItemsPerInvoicePerMonth[i] = 0;
                else
                {
                    foreach (int value in itemsPerInvoicePerMonth[i])
                    {
                        total += value;
                    }
                    average = (float)total / (float)itemsPerInvoicePerMonth[i].Count;
                    
                    averageItemsPerInvoicePerMonth[i] = average;
                }
            }

            //Calculate the max values per data set
            //Calculate the percentages of each month compared to the max value
            float max;
            graphMaxValues = new float[7];
            
            for (int i = 0; i < graphMaxValues.Length; i++)
            {
                max = 0;
                foreach (float item in graphActualValues[i])
                {
                    if (item > max) max = item;
                }
                for (int ii = 0; ii < graphActualValues[i].Length; ii++)
                {
                    graphPercentValues[i][ii] = (graphActualValues[i][ii] / max) * 100;
                }
                graphMaxValues[i] = max;
            }
        }

        /// <summary>
        /// DEBUG ONLY
        /// 
        /// Shows the 7 sets of 12 data in the console for actual values
        /// and for percentages of the graph height
        /// </summary>
        /// <code>
        /// Print months as column headers
        /// For each set of 12 raw values:
        ///     Append an empty string with each value
        ///     Print the string to the console
        /// For each set of 12 percentage values:
        ///     Append an empty string with each percentage
        ///     Print the string to the console
        /// </code>
        private void ShowInConsole()
        {
            string line = "";
            //Print months as column headers
            Console.WriteLine("J\tF\tM\tA\tM\tJ\tJ\tA\tS\tO\tN\tD");
            Console.WriteLine();

            //For each set of 12 raw values:
            foreach (float[] graph in graphActualValues)
            {
                foreach (float value in graph)
                {
                    //Append an empty string with each value
                    line += value.ToString("F") + "\t";
                }
                //Print the string to the console
                Console.WriteLine(line);
                line = "";
            }

            Console.WriteLine();
            Console.WriteLine();

            //For each set of 12 percentage values:
            foreach (float[] graph in graphPercentValues)
            {
                line = "";
                foreach (float value in graph)
                {
                    //Append an empty string with each percentage
                    line += value.ToString("F0") + "\t";
                }
                //Print the string to the console
                Console.WriteLine(line);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Shows the current graph in the graph panel
        /// </summary>
        /// <code>
        /// Show the graph area
        /// Add the graph title, X-axis, and formatting to the graph
        /// Give the bars their height values
        /// Add in the Y-axis values
        /// </code>
        private void ShowGraph()
        {
        	//Show the graph area
        	tlpDataSwitcher.RowStyles[0] = new RowStyle(SizeType.Percent, 100);
        	tlpDataSwitcher.RowStyles[1] = new RowStyle(SizeType.Percent, 0);
            //Add the graph title, X-axis, and formatting to the graph
            lblGraphTitle.Text = graphFullNames[currentGraph];
            lblMinValue.Text = "0";
            lblMidValue.Text = (graphMaxValues[currentGraph] / 2).ToString("F");
            lblMaxValue.Text = graphMaxValues[currentGraph].ToString("F");
            tlpGraph.BorderStyle = BorderStyle.FixedSingle;
            tlpMonthHolder.Visible = true;

            //Give the bars their height values
            barValues = new Label[] { lblJanValue, lblFebValue, lblMarValue, lblAprValue, lblMayValue, lblJunValue, lblJulValue, lblAugValue, lblSepValue, lblOctValue, lblNovValue, lblDecValue };
            for (int i = 0; i < barValues.Length; i++)
            {
                barValues[i].Text = graphActualValues[currentGraph][i].ToString("F");
            }

            //Add in the Y-axis values
            for (int i = 0; i < bars.Length; i++)
            {
                bars[i].Height = (int)((tlpGraph.Height / 100f) * graphPercentValues[currentGraph][i]);
                bars[i].BackColor = barColours[i];
            }
        }
        
        /// <summary>
        /// Serches through all of the customers by customer ID and adds the results to the result panel
        /// </summary>
        public void FindCustomer()
        {
        		bool isFound = false;
        		foreach (Invoice invoice in allInvoices)
        		{
        			if (invoice.Customer.ID == tbxID.Text)
        			{
        				isFound = true;
        				
			        	tlpDataSwitcher.RowStyles[0] = new RowStyle(SizeType.Percent, 0);
			        	tlpDataSwitcher.RowStyles[1] = new RowStyle(SizeType.Percent, 100);
			        	lblGraphTitle.Text = "Search results for customer: " + tbxID.Text;
			        	
			        	pnlSearchResults.Controls.Clear();
			        	
			        	UcInvoice newResult = new UcInvoice(invoice.InvoiceNumber, invoice.TransactionTime);
			        	newResult.Dock = DockStyle.Top;
			        	newResult.Parent = pnlSearchResults;
        			}
        		}
        		
        		if (!isFound)
        		{
        			MessageBox.Show("No customer was found with that customer ID.\t\t", "Search for customer: " + tbxID.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        		}
        }
        
        /// <summary>
        /// Serches through all of the invoices by invoice ID and adds the results to the result panel
        /// </summary>
        public void FindInvoice()
        {
        	bool isFound = false;
    		foreach (Invoice invoice in allInvoices)
    		{
    			if (invoice.InvoiceNumber == tbxID.Text)
    			{
    				isFound = true;
    				
		        	tlpDataSwitcher.RowStyles[0] = new RowStyle(SizeType.Percent, 0);
		        	tlpDataSwitcher.RowStyles[1] = new RowStyle(SizeType.Percent, 100);
		        	lblGraphTitle.Text = "Search results for invoice: " + tbxID.Text + " - Customer ID: " + invoice.Customer.ID;
		        	
		        	pnlSearchResults.Controls.Clear();
    				
		        	foreach (KeyValuePair<Product, int> product in invoice.Order)
		        	{
		        		UcProduct newResult = new UcProduct(product.Key.StockCode, product.Key.Description, product.Key.UnitPrice, product.Value);
		        		newResult.Dock = DockStyle.Top;
		        		newResult.Parent = pnlSearchResults;
		        	}
    			}
    		}
    		
    		if (!isFound)
    		{
    			MessageBox.Show("No invoice was found with that invoice ID.\t\t", "Search for invoice: " + tbxID.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
    		}
        }



        #endregion
        #region Events


        /// <summary>
        /// When the "Pick File" MenuItem is clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void tmiPickFile_Click(object sender, EventArgs e)
        {
            Run();
        }

        /// <summary>
        /// When the "Print" MenuItem is clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void tmiPrint_Click(object sender, EventArgs e)
        {
            imageToPrint = new Bitmap(pnlGraphHolder.Width, pnlGraphHolder.Height);
            pnlGraphHolder.BorderStyle = BorderStyle.FixedSingle;
            pnlGraphHolder.DrawToBitmap(imageToPrint, new Rectangle(0, 0, pnlGraphHolder.Width + 1, pnlGraphHolder.Height + 1));
            pnlGraphHolder.BorderStyle = BorderStyle.Fixed3D;

            pdtPrintArea.PrintPage += pdtPrintArea_PrintPage;
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = pdtPrintArea;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    pdtPrintArea.Print();
                }
                catch
                {
                    /*No need to have a catch statement as the
                    DocumentPrinter already shows an error message box
                    to the user*/
                }
            }
        }

        /// <summary>
        /// Setting the print area
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void pdtPrintArea_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle margin = e.MarginBounds;

            margin.Height = (int)((double)imageToPrint.Height / (double)imageToPrint.Width * (double)margin.Width);
            
            e.Graphics.DrawImage(imageToPrint, margin);
        }

        /// <summary>
        /// When the "Colours" MenuItem is clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void tmiColours_Click(object sender, EventArgs e)
        {
            frmOptions o1 = new frmOptions();
            o1.BarColours = barColours;
            o1.ShowDialog();
            if (o1.Save)
                barColours = o1.BarColours;
            if (tlpGraph.BorderStyle == BorderStyle.FixedSingle)
                ShowGraph();
        }

        /// <summary>
        /// When the "About" MenuItem is clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void tmiAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.Show();
        }

        /// <summary>
        /// When the "Close" MenuItem is clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void tmiClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// When any of the 5 graph Buttons are clicked
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void GraphButton_click(object sender, EventArgs e)
        {
            currentGraph = Convert.ToInt16((sender as Button).Tag);
            ShowGraph(); 
        }

        /// <summary>
        /// When this form first opens
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            bars = new Panel[] { pnlJan, pnlFeb, pnlMar, pnlApr, pnlMay, pnlJun, pnlJul, pnlAug, pnlSep, pnlOct, pnlNov, pnlDec };
            lblGraphTitle.Text = "";
            lblMinValue.Text = "";
            lblMidValue.Text = "";
            lblMaxValue.Text = "";
            lblFileName.Text = "";
        }

        /// <summary>
        /// When the size of this form changes
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (tlpGraph.BorderStyle == BorderStyle.FixedSingle)
                ShowGraph();
        }

        /// <summary>
        /// When the BackgroundWorker bwAnalyse runs it's tasks
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void BwAnalyse_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadData(ofdFilePicker.FileName);
            AnalyseData();
        }

        /// <summary>
        /// When the BackgroundWorker bwAnalyse has completed it's tasks
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        private void BwAnalyse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbDataAnalysing.Visible = false;

            ShowInConsole();//DEBUG

            foreach (Control control in gbxValuesPerMonth.Controls)
                control.Enabled = true;
            foreach (Control control in gbxAveragesPerMonth.Controls)
                control.Enabled = true;
            foreach (Control control in gbxLookUps.Controls)
                control.Enabled = true;
            lblFileName.Text = ofdFilePicker.FileName.Split('\\')[ofdFilePicker.FileName.Split('\\').Length - 1];
        }
        
        /// <summary>
        /// When the text in the search box is changed
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        void tbxID_textChanged(object sender, EventArgs e)
        {
        	tbxID.ForeColor = Color.Black;
        	tbxID.Font = new Font(tbxID.Font.FontFamily, tbxID.Font.Size, FontStyle.Regular);
        }
        
        /// <summary>
        /// When the search box gains focus
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        void TbxID_click(object sender, EventArgs e)
        {
        	tbxID.SelectAll();
        }
        
        /// <summary>
        /// When either of the search buttons are pressed
        /// </summary>
        /// <param name="sender">The sending object</param>
        /// <param name="e">The Event Data</param>
        void SearchButton_click(object sender, EventArgs e)
        {        	
        	if ((sender as Button).Text == "Find invoice")
        	{
        		FindInvoice();
        	}
        	else
        	{
        		FindCustomer();
        	}
        }


        
        #endregion
    }
}
