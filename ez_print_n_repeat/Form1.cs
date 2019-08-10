
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading;
using PdfiumViewer;

/// <credit>
/// APPLICATION ICON PROVIDED BY jannoon028
/// </credit>

namespace ez_print_n_repeat
{
    public partial class Form1 : Form
    {

        private static string PrintDirectoryName = "";
        private static decimal PrintProgressIncrement;
        

        public Form1()
        {
            InitializeComponent();
            Print_Button.Enabled = false;
            FilesListView.View = View.Details;
            FilesListView.Columns.Add("File Name", width: FilesListView.Width);
            foreach (string printer_name in get_printer_names())
            {
                printer_select_combo_box.Items.Add(printer_name);
            }
        }

        private string[] file_path_names = { };

        private PrinterSettings.StringCollection get_printer_names() => PrinterSettings.InstalledPrinters;

        private void choose_folder_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult res = dialog
                .ShowDialog();

            if (res.Equals(DialogResult.OK))
            {
                FilesListView.Items.Clear();
                PrintDirectoryName = dialog.SelectedPath.ToString();
                file_path_names = Directory.GetFiles(dialog.SelectedPath);
                try
                {
                    PrintProgressIncrement = 100 / file_path_names.Length;
                }
                catch(DivideByZeroException dzx)
                {
                    MessageBox.Show("Cannot Print Empty Directory!");
                    Console.WriteLine(dzx.StackTrace.ToString());
                    return;
                }
                choose_folder_label.Text = PrintDirectoryName;

                for (int i = 0; i < file_path_names.Length; i++)
                {
                    string name = Path.GetFileName(file_path_names[i]);
                    FilesListView.Items.Add(name);
                }

                if (printer_select_combo_box.SelectedIndex > -1)
                {
                    Print_Button.Enabled = true;
                }
                else
                {
                    Print_Button.Enabled = false;
                }
            }
            else {
                MessageBox.Show(
                    "Unable to Complete Requested Action\n" +
                    "Selected Directory May Have Been an Incompatible Type!",
                    "Title");
            }
        }

        private void printer_select_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (file_path_names.Length > 0)
            {
                Print_Button.Enabled = true;
            } else
            {
                Print_Button.Enabled = false;
            }
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                null, 
                "Ready to Start Printing?", 
                "Comfirmation", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

          
            print_progress_label.Visible = true;
            print_progress_bar.Visible = true;
            print_progress_bar.Value = 0;
            Print_Button.Enabled = false;
           

            if (result.Equals(DialogResult.OK))
            {
                var uiContext = TaskScheduler.FromCurrentSynchronizationContext();
                //Configure Printer Settings
                PrinterSettings settings = setup_printer();

                foreach (var document_name in file_path_names)
                {
                    var count = FilesListView.Items.Count;

                    start_printing(settings, document_name);

                    Task t = Task.Factory.StartNew(() => {
                        
                        for (int i = 0; i < count; i++)
                        {
                            Task.Factory.StartNew(() => {

                                try
                                {
                                    print_progress_bar.Value += (int)PrintProgressIncrement;
                                } catch (ArgumentOutOfRangeException rangeException)
                                {
                                    Console.Error.WriteLine(rangeException.ToString());
                                }

                                if (i == count)
                                {
                                    print_progress_bar.Value = 100;
                                    print_progress_label.Text = "Finished Sending";
                                    Print_Button.Enabled = true;
                                }
                            }, CancellationToken.None, TaskCreationOptions.None, uiContext);

                        }
                    }); ///////// END TASK LAMBDA
                }

                
                
            }
            else if (result.Equals(DialogResult.Cancel))
            {
                //Do nothing

                print_progress_label.Visible = false;
                print_progress_bar.Visible = false;
                print_progress_bar.Value = 0;
            }

            
        }

        public PrinterSettings setup_printer()
        {
            PrinterSettings settings = new PrinterSettings();
            settings.PrinterName = printer_select_combo_box.SelectedItem.ToString();
            settings.Duplex = Duplex.Vertical;
            PrintDocument document = new PrintDocument();

            return settings;
        }

        public void start_printing(PrinterSettings settings, string document_path)
        {
            using (var pdf_document = PdfDocument.Load(document_path))
            {
                using (var print_document = pdf_document.CreatePrintDocument())
                {
                    print_document.PrinterSettings = settings;
                    print_document.PrintController = new StandardPrintController();
                    print_document.Print();
                }
            }
        }

        //BELOW METHODS LEFT INTENTIONALLY BLANK!!!!!
        ////////////////////////////////////////////////////////////////
       

        private void Form1_Load(object sender, EventArgs e)
        {
            //LEFT INTENTIONALLY BLANK
        }

        private void printer_select_button_Click(object sender, EventArgs e)
        {
            //LEFT INTENTIONALLY BLANK
        }
    }
}
