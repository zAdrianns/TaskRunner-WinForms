namespace ObjetivaScripts
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pg1BatFiles = new System.Windows.Forms.TabPage();
            this.GroupBoxPg1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilaImpressao = new System.Windows.Forms.Button();
            this.btnDellDLLECF = new System.Windows.Forms.Button();
            this.btnEndUniDanfe = new System.Windows.Forms.Button();
            this.btnStartSQLService = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnPermObjC = new System.Windows.Forms.Button();
            this.btnPermObjD = new System.Windows.Forms.Button();
            this.btnIndexBD = new System.Windows.Forms.Button();
            this.btnEndVarejo = new System.Windows.Forms.Button();
            this.btnRecEstatistBD = new System.Windows.Forms.Button();
            this.btnLibSqlFirewall = new System.Windows.Forms.Button();
            this.btnUpdCustosEntrada = new System.Windows.Forms.Button();
            this.btnDellRegistroObjetiva = new System.Windows.Forms.Button();
            this.btnUpdCustosFilial50 = new System.Windows.Forms.Button();
            this.LabTitlePg1 = new System.Windows.Forms.Label();
            this.pg2SqlRoutineScripts = new System.Windows.Forms.TabPage();
            this.btnUpdateCadSys = new System.Windows.Forms.Button();
            this.pg2TxtSelecionarServidor = new System.Windows.Forms.Label();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CopyScripts = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Script1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Pg1BatFiles.SuspendLayout();
            this.GroupBoxPg1.SuspendLayout();
            this.pg2SqlRoutineScripts.SuspendLayout();
            this.CopyScripts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pg1BatFiles);
            this.tabControl1.Controls.Add(this.pg2SqlRoutineScripts);
            this.tabControl1.Controls.Add(this.CopyScripts);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // Pg1BatFiles
            // 
            this.Pg1BatFiles.Controls.Add(this.GroupBoxPg1);
            this.Pg1BatFiles.Location = new System.Drawing.Point(4, 25);
            this.Pg1BatFiles.Name = "Pg1BatFiles";
            this.Pg1BatFiles.Padding = new System.Windows.Forms.Padding(3);
            this.Pg1BatFiles.Size = new System.Drawing.Size(579, 444);
            this.Pg1BatFiles.TabIndex = 0;
            this.Pg1BatFiles.Text = ".bat Files";
            this.Pg1BatFiles.UseVisualStyleBackColor = true;
            // 
            // GroupBoxPg1
            // 
            this.GroupBoxPg1.Controls.Add(this.btnClearFilaImpressao);
            this.GroupBoxPg1.Controls.Add(this.btnDellDLLECF);
            this.GroupBoxPg1.Controls.Add(this.btnEndUniDanfe);
            this.GroupBoxPg1.Controls.Add(this.btnStartSQLService);
            this.GroupBoxPg1.Controls.Add(this.btnBackup);
            this.GroupBoxPg1.Controls.Add(this.btnPermObjC);
            this.GroupBoxPg1.Controls.Add(this.btnPermObjD);
            this.GroupBoxPg1.Controls.Add(this.btnIndexBD);
            this.GroupBoxPg1.Controls.Add(this.btnEndVarejo);
            this.GroupBoxPg1.Controls.Add(this.btnRecEstatistBD);
            this.GroupBoxPg1.Controls.Add(this.btnLibSqlFirewall);
            this.GroupBoxPg1.Controls.Add(this.btnUpdCustosEntrada);
            this.GroupBoxPg1.Controls.Add(this.btnDellRegistroObjetiva);
            this.GroupBoxPg1.Controls.Add(this.btnUpdCustosFilial50);
            this.GroupBoxPg1.Controls.Add(this.LabTitlePg1);
            this.GroupBoxPg1.Location = new System.Drawing.Point(6, 15);
            this.GroupBoxPg1.Name = "GroupBoxPg1";
            this.GroupBoxPg1.Size = new System.Drawing.Size(553, 423);
            this.GroupBoxPg1.TabIndex = 0;
            this.GroupBoxPg1.TabStop = false;
            // 
            // btnClearFilaImpressao
            // 
            this.btnClearFilaImpressao.Location = new System.Drawing.Point(23, 313);
            this.btnClearFilaImpressao.Name = "btnClearFilaImpressao";
            this.btnClearFilaImpressao.Size = new System.Drawing.Size(233, 34);
            this.btnClearFilaImpressao.TabIndex = 14;
            this.btnClearFilaImpressao.Text = "Limpar Fila de Impressão";
            this.btnClearFilaImpressao.UseVisualStyleBackColor = true;
            this.btnClearFilaImpressao.Click += new System.EventHandler(this.btnClearFilaImpressao_Click);
            // 
            // btnDellDLLECF
            // 
            this.btnDellDLLECF.Location = new System.Drawing.Point(23, 273);
            this.btnDellDLLECF.Name = "btnDellDLLECF";
            this.btnDellDLLECF.Size = new System.Drawing.Size(233, 34);
            this.btnDellDLLECF.TabIndex = 13;
            this.btnDellDLLECF.Text = "Deletar DLLECF";
            this.btnDellDLLECF.UseVisualStyleBackColor = true;
            this.btnDellDLLECF.Click += new System.EventHandler(this.btnDellDLLECF_Click);
            // 
            // btnEndUniDanfe
            // 
            this.btnEndUniDanfe.Location = new System.Drawing.Point(23, 233);
            this.btnEndUniDanfe.Name = "btnEndUniDanfe";
            this.btnEndUniDanfe.Size = new System.Drawing.Size(233, 34);
            this.btnEndUniDanfe.TabIndex = 12;
            this.btnEndUniDanfe.Text = "Finalizar UniDanfe";
            this.btnEndUniDanfe.UseVisualStyleBackColor = true;
            this.btnEndUniDanfe.Click += new System.EventHandler(this.btnEndUniDanfe_Click);
            // 
            // btnStartSQLService
            // 
            this.btnStartSQLService.Location = new System.Drawing.Point(294, 153);
            this.btnStartSQLService.Name = "btnStartSQLService";
            this.btnStartSQLService.Size = new System.Drawing.Size(233, 34);
            this.btnStartSQLService.TabIndex = 11;
            this.btnStartSQLService.Text = "Iniciar Serviço SQL";
            this.btnStartSQLService.UseVisualStyleBackColor = true;
            this.btnStartSQLService.Click += new System.EventHandler(this.btnStartSQLService_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(23, 153);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(233, 34);
            this.btnBackup.TabIndex = 10;
            this.btnBackup.Text = "Realizar Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnPermObjC
            // 
            this.btnPermObjC.Location = new System.Drawing.Point(294, 73);
            this.btnPermObjC.Name = "btnPermObjC";
            this.btnPermObjC.Size = new System.Drawing.Size(233, 34);
            this.btnPermObjC.TabIndex = 9;
            this.btnPermObjC.Text = "Permissão Objetiva C";
            this.btnPermObjC.UseVisualStyleBackColor = true;
            this.btnPermObjC.Click += new System.EventHandler(this.btnPermObjC_Click);
            // 
            // btnPermObjD
            // 
            this.btnPermObjD.Location = new System.Drawing.Point(294, 113);
            this.btnPermObjD.Name = "btnPermObjD";
            this.btnPermObjD.Size = new System.Drawing.Size(233, 34);
            this.btnPermObjD.TabIndex = 8;
            this.btnPermObjD.Text = "Permissão Objetiva D";
            this.btnPermObjD.UseVisualStyleBackColor = true;
            this.btnPermObjD.Click += new System.EventHandler(this.btnPermObjD_Click);
            // 
            // btnIndexBD
            // 
            this.btnIndexBD.Location = new System.Drawing.Point(294, 273);
            this.btnIndexBD.Name = "btnIndexBD";
            this.btnIndexBD.Size = new System.Drawing.Size(233, 34);
            this.btnIndexBD.TabIndex = 7;
            this.btnIndexBD.Text = "Indexar Banco";
            this.btnIndexBD.UseVisualStyleBackColor = true;
            this.btnIndexBD.Click += new System.EventHandler(this.btnIndexBD_Click);
            // 
            // btnEndVarejo
            // 
            this.btnEndVarejo.Location = new System.Drawing.Point(23, 193);
            this.btnEndVarejo.Name = "btnEndVarejo";
            this.btnEndVarejo.Size = new System.Drawing.Size(233, 34);
            this.btnEndVarejo.TabIndex = 6;
            this.btnEndVarejo.Text = "Finalizar Tarefas Varejo 2º Plano";
            this.btnEndVarejo.UseVisualStyleBackColor = true;
            this.btnEndVarejo.Click += new System.EventHandler(this.btnEndVarejo_Click);
            // 
            // btnRecEstatistBD
            // 
            this.btnRecEstatistBD.Location = new System.Drawing.Point(294, 233);
            this.btnRecEstatistBD.Name = "btnRecEstatistBD";
            this.btnRecEstatistBD.Size = new System.Drawing.Size(233, 34);
            this.btnRecEstatistBD.TabIndex = 5;
            this.btnRecEstatistBD.Text = "Recria Estatisticas Banco";
            this.btnRecEstatistBD.UseVisualStyleBackColor = true;
            this.btnRecEstatistBD.Click += new System.EventHandler(this.btnRecEstatistBD_Click);
            // 
            // btnLibSqlFirewall
            // 
            this.btnLibSqlFirewall.Location = new System.Drawing.Point(294, 193);
            this.btnLibSqlFirewall.Name = "btnLibSqlFirewall";
            this.btnLibSqlFirewall.Size = new System.Drawing.Size(233, 34);
            this.btnLibSqlFirewall.TabIndex = 4;
            this.btnLibSqlFirewall.Text = "Liberar SQL Firewall";
            this.btnLibSqlFirewall.UseVisualStyleBackColor = true;
            this.btnLibSqlFirewall.Click += new System.EventHandler(this.btnLibSqlFirewall_Click);
            // 
            // btnUpdCustosEntrada
            // 
            this.btnUpdCustosEntrada.Location = new System.Drawing.Point(23, 113);
            this.btnUpdCustosEntrada.Name = "btnUpdCustosEntrada";
            this.btnUpdCustosEntrada.Size = new System.Drawing.Size(233, 34);
            this.btnUpdCustosEntrada.TabIndex = 3;
            this.btnUpdCustosEntrada.Text = "Atualizar Custo a Partir da Entrada";
            this.btnUpdCustosEntrada.UseVisualStyleBackColor = true;
            this.btnUpdCustosEntrada.Click += new System.EventHandler(this.btnUpdCustosEntrada_Click);
            // 
            // btnDellRegistroObjetiva
            // 
            this.btnDellRegistroObjetiva.Location = new System.Drawing.Point(294, 313);
            this.btnDellRegistroObjetiva.Name = "btnDellRegistroObjetiva";
            this.btnDellRegistroObjetiva.Size = new System.Drawing.Size(233, 34);
            this.btnDellRegistroObjetiva.TabIndex = 2;
            this.btnDellRegistroObjetiva.Text = "Excluir Registro Objetiva";
            this.btnDellRegistroObjetiva.UseVisualStyleBackColor = true;
            this.btnDellRegistroObjetiva.Click += new System.EventHandler(this.btnDellRegistroObjetiva_Click);
            // 
            // btnUpdCustosFilial50
            // 
            this.btnUpdCustosFilial50.Location = new System.Drawing.Point(23, 73);
            this.btnUpdCustosFilial50.Name = "btnUpdCustosFilial50";
            this.btnUpdCustosFilial50.Size = new System.Drawing.Size(233, 34);
            this.btnUpdCustosFilial50.TabIndex = 1;
            this.btnUpdCustosFilial50.Text = "Atualizar Custo a Partir da Filial 50";
            this.btnUpdCustosFilial50.UseVisualStyleBackColor = true;
            this.btnUpdCustosFilial50.Click += new System.EventHandler(this.btnUpdCustosFilial50_Click);
            // 
            // LabTitlePg1
            // 
            this.LabTitlePg1.AutoSize = true;
            this.LabTitlePg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitlePg1.Location = new System.Drawing.Point(146, 18);
            this.LabTitlePg1.Name = "LabTitlePg1";
            this.LabTitlePg1.Size = new System.Drawing.Size(258, 25);
            this.LabTitlePg1.TabIndex = 0;
            this.LabTitlePg1.Text = "Painel de Execução .BAT";
            // 
            // pg2SqlRoutineScripts
            // 
            this.pg2SqlRoutineScripts.Controls.Add(this.btnUpdateCadSys);
            this.pg2SqlRoutineScripts.Controls.Add(this.pg2TxtSelecionarServidor);
            this.pg2SqlRoutineScripts.Controls.Add(this.btnTestarConexao);
            this.pg2SqlRoutineScripts.Controls.Add(this.comboBox1);
            this.pg2SqlRoutineScripts.Location = new System.Drawing.Point(4, 25);
            this.pg2SqlRoutineScripts.Name = "pg2SqlRoutineScripts";
            this.pg2SqlRoutineScripts.Padding = new System.Windows.Forms.Padding(3);
            this.pg2SqlRoutineScripts.Size = new System.Drawing.Size(579, 444);
            this.pg2SqlRoutineScripts.TabIndex = 1;
            this.pg2SqlRoutineScripts.Text = "SQL Routine Scripts";
            this.pg2SqlRoutineScripts.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCadSys
            // 
            this.btnUpdateCadSys.Location = new System.Drawing.Point(23, 73);
            this.btnUpdateCadSys.Name = "btnUpdateCadSys";
            this.btnUpdateCadSys.Size = new System.Drawing.Size(233, 34);
            this.btnUpdateCadSys.TabIndex = 5;
            this.btnUpdateCadSys.Text = "Update CadSys";
            this.btnUpdateCadSys.UseVisualStyleBackColor = true;
            this.btnUpdateCadSys.Click += new System.EventHandler(this.btnUpdateCadSys_Click);
            // 
            // pg2TxtSelecionarServidor
            // 
            this.pg2TxtSelecionarServidor.AutoSize = true;
            this.pg2TxtSelecionarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pg2TxtSelecionarServidor.Location = new System.Drawing.Point(6, 20);
            this.pg2TxtSelecionarServidor.Name = "pg2TxtSelecionarServidor";
            this.pg2TxtSelecionarServidor.Size = new System.Drawing.Size(157, 16);
            this.pg2TxtSelecionarServidor.TabIndex = 4;
            this.pg2TxtSelecionarServidor.Text = "Selecione o Servidor:";
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTestarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTestarConexao.Location = new System.Drawing.Point(537, 12);
            this.btnTestarConexao.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTestarConexao.Size = new System.Drawing.Size(32, 31);
            this.btnTestarConexao.TabIndex = 3;
            this.btnTestarConexao.Text = "✔️";
            this.btnTestarConexao.UseVisualStyleBackColor = false;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CopyScripts
            // 
            this.CopyScripts.Controls.Add(this.groupBox1);
            this.CopyScripts.Location = new System.Drawing.Point(4, 25);
            this.CopyScripts.Name = "CopyScripts";
            this.CopyScripts.Padding = new System.Windows.Forms.Padding(3);
            this.CopyScripts.Size = new System.Drawing.Size(579, 444);
            this.CopyScripts.TabIndex = 2;
            this.CopyScripts.Text = "Scripts Text";
            this.CopyScripts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Script1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scripts para Copiar";
            // 
            // Script1
            // 
            this.Script1.Location = new System.Drawing.Point(23, 73);
            this.Script1.Name = "Script1";
            this.Script1.Size = new System.Drawing.Size(233, 34);
            this.Script1.TabIndex = 0;
            this.Script1.Text = "Resetar Transporte da Nota Fiscal";
            this.Script1.UseVisualStyleBackColor = true;
            this.Script1.Click += new System.EventHandler(this.Script1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 497);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObjetivaScripts";
            this.tabControl1.ResumeLayout(false);
            this.Pg1BatFiles.ResumeLayout(false);
            this.GroupBoxPg1.ResumeLayout(false);
            this.GroupBoxPg1.PerformLayout();
            this.pg2SqlRoutineScripts.ResumeLayout(false);
            this.pg2SqlRoutineScripts.PerformLayout();
            this.CopyScripts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pg1BatFiles;
        private System.Windows.Forms.GroupBox GroupBoxPg1;
        private System.Windows.Forms.TabPage pg2SqlRoutineScripts;
        private System.Windows.Forms.Button btnUpdCustosFilial50;
        private System.Windows.Forms.Label LabTitlePg1;
        private System.Windows.Forms.Button btnPermObjC;
        private System.Windows.Forms.Button btnPermObjD;
        private System.Windows.Forms.Button btnIndexBD;
        private System.Windows.Forms.Button btnEndVarejo;
        private System.Windows.Forms.Button btnRecEstatistBD;
        private System.Windows.Forms.Button btnLibSqlFirewall;
        private System.Windows.Forms.Button btnUpdCustosEntrada;
        private System.Windows.Forms.Button btnDellRegistroObjetiva;
        private System.Windows.Forms.Button btnDellDLLECF;
        private System.Windows.Forms.Button btnEndUniDanfe;
        private System.Windows.Forms.Button btnStartSQLService;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnClearFilaImpressao;
        private System.Windows.Forms.Label pg2TxtSelecionarServidor;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUpdateCadSys;
        private System.Windows.Forms.TabPage CopyScripts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Script1;
        private System.Windows.Forms.Label label1;
    }
}

