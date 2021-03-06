﻿using GangOfSeven.OPEManager.Application.Forms;
using SmartNet.OPEManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutGestaoOPE.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                if (ClsUtil.IsNumeric(txtUsuario.Text))
                {
                    FormLogin loginDao = new FormLogin();
                    Usuario usuario = loginDao.fazerLogin(int.Parse(txtUsuario.Text));

                    if (usuario != null)
                    {
                        FrmMenu frmMenu = new FrmMenu();
                        FrmMenu.usuario = usuario;
                        this.Hide();
                        frmMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorreto.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("RA é um campo numerico.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
