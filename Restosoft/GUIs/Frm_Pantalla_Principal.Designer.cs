namespace Restosoft.GUIs
{
    partial class Frm_Pantalla_Principal
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
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnTurno = new DevExpress.XtraEditors.SimpleButton();
            this.btnCategoria = new DevExpress.XtraEditors.SimpleButton();
            this.btnMostrarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnMesas = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton16 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton18 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(336, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(12, 57);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(133, 84);
            this.btnGrupo.TabIndex = 1;
            this.btnGrupo.Text = "Crear un grupo";
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnTurno
            // 
            this.btnTurno.Location = new System.Drawing.Point(151, 57);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(133, 84);
            this.btnTurno.TabIndex = 2;
            this.btnTurno.Text = "Crear un turno";
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(12, 237);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(133, 84);
            this.btnCategoria.TabIndex = 3;
            this.btnCategoria.Text = "Crear categoría";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMostrarGrupo
            // 
            this.btnMostrarGrupo.Location = new System.Drawing.Point(12, 147);
            this.btnMostrarGrupo.Name = "btnMostrarGrupo";
            this.btnMostrarGrupo.Size = new System.Drawing.Size(133, 84);
            this.btnMostrarGrupo.TabIndex = 4;
            this.btnMostrarGrupo.Text = "Mostrar Grupo";
            this.btnMostrarGrupo.Click += new System.EventHandler(this.btnMostrarGrupo_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Location = new System.Drawing.Point(151, 147);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(133, 84);
            this.btnMesas.TabIndex = 6;
            this.btnMesas.Text = "Crear categoría";
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(12, 327);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(350, 248);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton15);
            this.panelControl1.Controls.Add(this.simpleButton16);
            this.panelControl1.Controls.Add(this.simpleButton17);
            this.panelControl1.Controls.Add(this.simpleButton18);
            this.panelControl1.Controls.Add(this.simpleButton11);
            this.panelControl1.Controls.Add(this.simpleButton12);
            this.panelControl1.Controls.Add(this.simpleButton13);
            this.panelControl1.Controls.Add(this.simpleButton14);
            this.panelControl1.Controls.Add(this.simpleButton7);
            this.panelControl1.Controls.Add(this.simpleButton8);
            this.panelControl1.Controls.Add(this.simpleButton9);
            this.panelControl1.Controls.Add(this.simpleButton10);
            this.panelControl1.Controls.Add(this.simpleButton6);
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Location = new System.Drawing.Point(372, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(600, 400);
            this.panelControl1.TabIndex = 8;
            // 
            // simpleButton15
            // 
            this.simpleButton15.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton15.Appearance.Options.UseBackColor = true;
            this.simpleButton15.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton15.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton15.Location = new System.Drawing.Point(425, 293);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(116, 84);
            this.simpleButton15.TabIndex = 19;
            // 
            // simpleButton16
            // 
            this.simpleButton16.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton16.Appearance.Options.UseBackColor = true;
            this.simpleButton16.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton16.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton16.Location = new System.Drawing.Point(303, 293);
            this.simpleButton16.Name = "simpleButton16";
            this.simpleButton16.Size = new System.Drawing.Size(116, 84);
            this.simpleButton16.TabIndex = 18;
            // 
            // simpleButton17
            // 
            this.simpleButton17.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton17.Appearance.Options.UseBackColor = true;
            this.simpleButton17.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton17.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton17.Location = new System.Drawing.Point(181, 293);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(116, 84);
            this.simpleButton17.TabIndex = 17;
            // 
            // simpleButton18
            // 
            this.simpleButton18.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton18.Appearance.Options.UseBackColor = true;
            this.simpleButton18.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton18.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton18.Location = new System.Drawing.Point(59, 293);
            this.simpleButton18.Name = "simpleButton18";
            this.simpleButton18.Size = new System.Drawing.Size(116, 84);
            this.simpleButton18.TabIndex = 16;
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton11.Appearance.Options.UseBackColor = true;
            this.simpleButton11.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton11.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton11.Location = new System.Drawing.Point(425, 203);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(116, 84);
            this.simpleButton11.TabIndex = 15;
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton12.Appearance.Options.UseBackColor = true;
            this.simpleButton12.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton12.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton12.Location = new System.Drawing.Point(303, 203);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(116, 84);
            this.simpleButton12.TabIndex = 14;
            // 
            // simpleButton13
            // 
            this.simpleButton13.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton13.Appearance.Options.UseBackColor = true;
            this.simpleButton13.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton13.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton13.Location = new System.Drawing.Point(181, 203);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(116, 84);
            this.simpleButton13.TabIndex = 13;
            // 
            // simpleButton14
            // 
            this.simpleButton14.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton14.Appearance.Options.UseBackColor = true;
            this.simpleButton14.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton14.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton14.Location = new System.Drawing.Point(59, 203);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(116, 84);
            this.simpleButton14.TabIndex = 12;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton7.Location = new System.Drawing.Point(425, 113);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(116, 84);
            this.simpleButton7.TabIndex = 11;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton8.Location = new System.Drawing.Point(303, 113);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(116, 84);
            this.simpleButton8.TabIndex = 10;
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton9.Appearance.Options.UseBackColor = true;
            this.simpleButton9.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton9.Location = new System.Drawing.Point(181, 113);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(116, 84);
            this.simpleButton9.TabIndex = 9;
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton10.Appearance.Options.UseBackColor = true;
            this.simpleButton10.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton10.Location = new System.Drawing.Point(59, 113);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(116, 84);
            this.simpleButton10.TabIndex = 8;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton6.Location = new System.Drawing.Point(425, 23);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(116, 84);
            this.simpleButton6.TabIndex = 7;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton5.Location = new System.Drawing.Point(303, 23);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(116, 84);
            this.simpleButton5.TabIndex = 6;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton4.Location = new System.Drawing.Point(181, 23);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(116, 84);
            this.simpleButton4.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.simpleButton3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton3.BackgroundImage = global::Restosoft.Properties.Resources.Mexicandroid;
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton3.Location = new System.Drawing.Point(59, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(116, 84);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Chilaquiles con queso";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton2.Location = new System.Drawing.Point(548, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 396);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "u";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.Location = new System.Drawing.Point(2, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(50, 396);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "t";
            // 
            // Frm_Pantalla_Principal
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 722);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.btnMesas);
            this.Controls.Add(this.btnMostrarGrupo);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Pantalla_Principal";
            this.Text = "Frm_Pantalla_Principal";
            this.Load += new System.EventHandler(this.Frm_Pantalla_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGrupo;
        private DevExpress.XtraEditors.SimpleButton btnTurno;
        private DevExpress.XtraEditors.SimpleButton btnCategoria;
        private DevExpress.XtraEditors.SimpleButton btnMostrarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnMesas;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton15;
        private DevExpress.XtraEditors.SimpleButton simpleButton16;
        private DevExpress.XtraEditors.SimpleButton simpleButton17;
        private DevExpress.XtraEditors.SimpleButton simpleButton18;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton13;
        private DevExpress.XtraEditors.SimpleButton simpleButton14;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}