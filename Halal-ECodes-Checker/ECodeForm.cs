using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Halal_ECodes_Checker
{
    public partial class halal_ecode_form : Form
    {
        private string eCodesJsonFile = "e-codes.json";
        public halal_ecode_form()
        {
            InitializeComponent();
        }

        private List<EList> ParseJsonData(string jsonFile)
        {
            bool fileExist = File.Exists(jsonFile);

            if (!fileExist)
            {
                throw new Exception("File '" + eCodesJsonFile + "' not found in current directory");
            }

            //Parse json file and return List.
            string jsonData = File.ReadAllText(jsonFile);
            var eLists = JsonSerializer.Deserialize<List<EList>>(jsonData);
            return eLists;
        }

        //Parse and filter for 'Haram','Halal' and 'Musbooh' codes.
        private string ParseAndFilter(string jsonFile, string filter)
        {
            var eLists = ParseJsonData(jsonFile);
            var sb = new StringBuilder();
            sb.Append(filter + " Codes:\n");

            foreach (var eList in eLists)
            {
                if (eList.eStatus.Contains(filter))
                {
                    sb.Append(eList.eCode + ", ");
                }
            }
            return sb.ToString();
        }

        //Parse and Show output for search.
        private void ParseAndShowOutput(string jsonFile, string inputCode)
        {
            var eLists = ParseJsonData(jsonFile);
            bool found = false;
            foreach (var eList in eLists)
            {
                if (eList.eCode == inputCode)
                {
                    name_lbl.Text = "Name: " + eList.eName;
                    desc_lbl.Text = "Description: " + eList.eDesc;
                    status_lbl.Text = "Status: " + eList.eStatus;
                    clarification_lbl.Text = "Clarification: " + eList.eClarification;

                    //Change color of status label.
                    if(eList.eStatus == "Halal")
                        status_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(252)))), ((int)(((byte)(3)))));
                    else if (eList.eStatus == "MUSBOOH")
                        status_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(3)))));

                    found = true;
                    break;
                }
            }

            //Show error if not found code.
            if (!found)
            {
                Utils.ShowError("Input code not found in database");
            }
        }

        private void check_ecode_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string inputCode = ecode_inp_txt.Text;
                if (String.IsNullOrEmpty(inputCode))
                    Utils.ShowError("Input E-Code is missing or invalid");
                else
                    ParseAndShowOutput(eCodesJsonFile, inputCode);
            }
            catch (Exception ex)
            {
                Utils.ShowError(ex.Message);
            }
        }

        private void halal_btn_Click(object sender, EventArgs e)
        {
            var ecodesStr = ParseAndFilter(eCodesJsonFile, "Halal");
            Utils.ShowInfo(ecodesStr);
        }

        private void haram_btn_Click(object sender, EventArgs e)
        {
            var ecodesStr = ParseAndFilter(eCodesJsonFile, "Haram");
            Utils.ShowInfo(ecodesStr);
        }

        private void musbooh_btn_Click(object sender, EventArgs e)
        {
            var ecodesStr = ParseAndFilter(eCodesJsonFile, "MUSBOOH");
            Utils.ShowInfo(ecodesStr);
        }

        //Class for storing ECode Json data.
        public class EList
        {
            [JsonPropertyName("eCode")]
            public string eCode { get; set; }

            [JsonPropertyName("eName")]
            public string eName { get; set; }

            [JsonPropertyName("eDesc")]
            public string eDesc { get; set; }

            [JsonPropertyName("eStatus")]
            public string eStatus { get; set; }

            [JsonPropertyName("eClarification")]
            public string eClarification { get; set; }

            public EList(string eCode, string eName, string eDesc, string eStatus,string eClarification)
            {
                this.eCode = eCode;
                this.eName = eName;
                this.eDesc = eDesc;
                this.eStatus = eStatus;
                this.eClarification = eClarification;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            StringBuilder helpStr = new StringBuilder();
            helpStr.Append("Application Name : ECode Checker\n");
            helpStr.Append("Application Version : 1.0\n");
            helpStr.Append("UI Design : Haseeb Mir\n");
            helpStr.Append("Core Application : Haseeb Mir\n");
            helpStr.Append("Data Source API/SDK : halalsign.com/e-numbers/ .NET 5.0\n");
            Utils.ShowInfo(helpStr.ToString());
        }
    }
}
