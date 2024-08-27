using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnREstados_Click(object sender, EventArgs e)
        {
            string estados =cboEstados.SelectedItem.ToString();
            if(estados == "SP" | estados == "RJ" | estados == "MG" | estados == "ES") 
            {
                cboSudeste.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboSudeste.Focus();
            } 
            else if (estados == "AM" | estados == "PA" | estados == "AC" | estados == "RR" | estados == "RO" | estados == "AP" | estados == "TO") 
            {
                cboNorte.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboNorte.Focus();
            }
            else if (estados == "PR" | estados == "SC" | estados == "RS") 
            {
                cboSul.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboSul.Focus();
            }
            else if (estados == "GO" | estados == "MT" | estados == "MS" | estados == "DF" ) 
            {
                cboCo.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboCo.Focus();
            }
            else if (estados == "CE" | estados == "BA" | estados == "SE" | estados == "AL" | estados == "MA" | estados == "PI" | estados == "RN" | estados == "PB" | estados == "PE" ) 
            {
                cboNordeste.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboNordeste.Focus();
            }

            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblCo.Text = cboCo.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();

            cboEstados.ResetText();
            
        }

        private void btnRNorte_Click(object sender, EventArgs e)
        {
            string estados = cboNorte.SelectedItem.ToString();
            if (estados == "AM" | estados == "PA" | estados == "AC" | estados == "RR" | estados == "RO" | estados == "AP" | estados == "TO")
            {
                cboEstados.Items.Add(cboNorte.SelectedItem.ToString());
                cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
                cboNorte.ResetText();
                lblNorte.Text = cboNorte.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
            }
        }

        private void btnRNordeste_Click(object sender, EventArgs e)
        {
            string estados = cboNordeste.SelectedItem.ToString();
            if (estados == "CE" | estados == "BA" | estados == "SE" | estados == "AL" | estados == "MA" | estados == "PI" | estados == "RN" | estados == "PB" | estados == "PE")
            {
                cboEstados.Items.Add(cboNordeste.SelectedItem.ToString());
                cboNordeste.Items.Remove(cboNordeste.SelectedItem.ToString());
                cboNordeste.ResetText();
                lblNordeste.Text = cboNordeste.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString() ;
            }
        }

        private void btnRCo_Click(object sender, EventArgs e)
        {
            string estados = cboCo.SelectedItem.ToString();
            if (estados == "GO" | estados == "MT" | estados == "MS" | estados == "DF")
            {
                cboEstados.Items.Add(cboCo.SelectedItem.ToString());
                cboCo.Items.Remove(cboCo.SelectedItem.ToString());
                cboCo.ResetText();
                lblCo.Text = cboCo.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
            }
        }

        private void btnRSudeste_Click(object sender, EventArgs e)
        {
            string estados = cboSudeste.SelectedItem.ToString();
            if (estados == "SP" | estados == "RJ" | estados == "MG" | estados == "ES")
            {
                cboEstados.Items.Add(cboSudeste.SelectedItem.ToString());
                cboSudeste.Items.Remove(cboSudeste.SelectedItem.ToString());
                cboSudeste.ResetText();
                lblSudeste.Text = cboSudeste.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
            }
        }

        private void btnRSul_Click(object sender, EventArgs e)
        {
            string estados = cboSul.SelectedItem.ToString();
            if (estados == "PR" | estados == "SC" | estados == "RS")
            {
                cboEstados.Items.Add(cboSul.SelectedItem.ToString());
                cboSul.Items.Remove(cboSul.SelectedItem.ToString());
                cboSul.ResetText();
                lblSul.Text = cboSul.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
            }
        }
    }
}
