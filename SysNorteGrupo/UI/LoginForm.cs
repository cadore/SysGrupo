﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfLibGrupo;
using System.Threading;
using EntitiesGrupo;
using SysNorteGrupo.Utils;
using SecureApp;
using UserIdle;
using DevExpress.XtraSplashScreen;
using SysNorteGrupo.UI.Utils;

namespace SysNorteGrupo.UI.Usuarios
{
    public partial class LoginForm : Form
    {

        private IServiceGrupo conn = null;
        private Color backColor = ConfigSistema.backColorFoco;
        public FormPrincipal formPrincipal;
        private UserIdleDetect userIdleDetectTimeExit;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "SysNorteGrupo Login - SysNorte Tecnologia Copyright © 2014 Versão: 1.0.0.0";
            tfSenha.Properties.UseSystemPasswordChar = true;
            conn = GerenteDeConexoes.conexaoServico();


            foreach (Control c in pnControl.Controls)
            {
                preencheFundoControls(c);
            }
            userIdleDetectTimeExit = UserIdleDetect.StartDetection(UserIdleDetect.minutes(20));
            userIdleDetectTimeExit.UserIdleDetected += userIdleDetect_UserIdleDetectedExitSystem;

            tfLogin.Text = "admin";
            tfSenha.Text = "admin";
            Thread.Sleep(1500);
        }

        void executaLogin()
        {
            lbSenha.Visible = false;
            DTICrypto crypto = new DTICrypto();
            string senha = crypto.Cifrar(tfSenha.Text, Util.chaveSecureApp);
            string login = tfLogin.Text;
            if (validator.Validate())
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(PleaseWaitForm));
                    bool flag = conn.verificaUsuarioAtivoPorLoginESenha(login, senha);
                    //SplashScreenManager.CloseForm();
                    if (flag)
                    {
                        if(formPrincipal == null)
                        {
                            usuario usuario_instc = conn.recuperaUsuarioPorLoginEhSenha(login, senha);
                            Program.usuario_instc = usuario_instc;
                            Log.createLog(EventLog.entered, String.Format("ao sistema após validar credenciais"));
                        }
                        else
                        {
                            GerenteDeConexoes.iniciaConexaoServico();
                            formPrincipal.adicionarControleNavegacao(formPrincipal.controleAtual);
                            formPrincipal.thisIDLE = false;
                            Log.createLog(EventLog.entered, String.Format("ao sistema após bloquear por inatividade"));
                        }                        
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        Log.createLog(EventLog.empty, String.Format("falha ao tentar executar login, login ou senha incorretos. LOGIN: {0} SENHA: {1}",
                        tfLogin.Text, new DTICrypto().Cifrar(tfSenha.Text, Util.chaveSecureApp)));
                        Program.usuario_instc = null;
                        lbSenha.Visible = true;
                        tfSenha.Focus();
                        tfSenha.SelectAll();
                        //SplashScreenManager.CloseForm();
                    }
                }
                catch (Exception ex)
                {                    
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    XtraMessageBox.Show(ex.Message);
                }
                finally
                {
                    SplashScreenManager.CloseForm();
                }
            }
            
        }

        void preencheFundoControls(Control item)
        {
            switch (item.GetType().ToString())
            {
                case "DevExpress.XtraEditors.TextEdit": ((TextEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.SearchLookUpEdit": ((SearchLookUpEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.RadioGroup": ((RadioGroup)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.CheckEdit": ((CheckEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Log.createLog(EventLog.cloused, "aplicação, apartir do formulario de login");
            if (formPrincipal == null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else
            {   
                Environment.Exit(0);   
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {            
            executaLogin();
        }
        
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                executaLogin();

            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        void userIdleDetect_UserIdleDetectedExitSystem(object sender, EventArgs e)
        {
            /*this.Invoke((MethodInvoker)delegate()
            {
                userIdleDetectTimeExit.StopDetection();              
                XtraMessageBox.Show("VOCÊ ESTEVE AUSENTE POR MAIS DE 20 (VINTE) MINUTOS\nO SISTEMA SERÁ ENCERRADO POR QUESTÕES DE SEGURANÇA.",
                    "SYSNORTE TECNOLOGIA - SysNorteGrupo");
                Environment.Exit(0);
            });*/
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //btnSair_Click(sender, e);
        }
    }
}