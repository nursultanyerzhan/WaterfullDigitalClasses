namespace WaterfullDigitalClasses
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяЗадачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТекущийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьМножествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезапускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельУправлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слайдшоуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеВидыЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоГлубинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоШиринуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прорывВодыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(923, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, "Координата и высота указываемой точки");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.панельУправлениеToolStripMenuItem,
            this.слайдшоуToolStripMenuItem,
            this.дополнительныеВидыЗадачToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяЗадачаToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьТекущийToolStripMenuItem,
            this.сохранитьМножествоToolStripMenuItem,
            this.перезапускToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("файлToolStripMenuItem.Image")));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новаяЗадачаToolStripMenuItem
            // 
            this.новаяЗадачаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новаяЗадачаToolStripMenuItem.Image")));
            this.новаяЗадачаToolStripMenuItem.Name = "новаяЗадачаToolStripMenuItem";
            this.новаяЗадачаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.новаяЗадачаToolStripMenuItem.Text = "Новая задача";
            this.новаяЗадачаToolStripMenuItem.Click += new System.EventHandler(this.новаяЗадачаToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.открытьToolStripMenuItem.Text = "Открыть снимок";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // сохранитьТекущийToolStripMenuItem
            // 
            this.сохранитьТекущийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьТекущийToolStripMenuItem.Image")));
            this.сохранитьТекущийToolStripMenuItem.Name = "сохранитьТекущийToolStripMenuItem";
            this.сохранитьТекущийToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сохранитьТекущийToolStripMenuItem.Text = "Сохранить текущий";
            this.сохранитьТекущийToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТекущийToolStripMenuItem_Click_1);
            // 
            // сохранитьМножествоToolStripMenuItem
            // 
            this.сохранитьМножествоToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьМножествоToolStripMenuItem.Image")));
            this.сохранитьМножествоToolStripMenuItem.Name = "сохранитьМножествоToolStripMenuItem";
            this.сохранитьМножествоToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сохранитьМножествоToolStripMenuItem.Text = "Сохранить множество";
            this.сохранитьМножествоToolStripMenuItem.Click += new System.EventHandler(this.сохранитьМножествоToolStripMenuItem_Click);
            // 
            // перезапускToolStripMenuItem
            // 
            this.перезапускToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("перезапускToolStripMenuItem.Image")));
            this.перезапускToolStripMenuItem.Name = "перезапускToolStripMenuItem";
            this.перезапускToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.перезапускToolStripMenuItem.Text = "Перезапуск ";
            this.перезапускToolStripMenuItem.Click += new System.EventHandler(this.перезапускToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // панельУправлениеToolStripMenuItem
            // 
            this.панельУправлениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("панельУправлениеToolStripMenuItem.Image")));
            this.панельУправлениеToolStripMenuItem.Name = "панельУправлениеToolStripMenuItem";
            this.панельУправлениеToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.панельУправлениеToolStripMenuItem.Text = "Панель управление";
            this.панельУправлениеToolStripMenuItem.Click += new System.EventHandler(this.панельУправлениеToolStripMenuItem_Click_1);
            // 
            // слайдшоуToolStripMenuItem
            // 
            this.слайдшоуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("слайдшоуToolStripMenuItem.Image")));
            this.слайдшоуToolStripMenuItem.Name = "слайдшоуToolStripMenuItem";
            this.слайдшоуToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.слайдшоуToolStripMenuItem.Text = "Слайд-шоу";
            this.слайдшоуToolStripMenuItem.Click += new System.EventHandler(this.слайдшоуToolStripMenuItem_Click_1);
            // 
            // дополнительныеВидыЗадачToolStripMenuItem
            // 
            this.дополнительныеВидыЗадачToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоГлубинуToolStripMenuItem,
            this.поискПоШиринуToolStripMenuItem,
            this.прорывВодыToolStripMenuItem});
            this.дополнительныеВидыЗадачToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("дополнительныеВидыЗадачToolStripMenuItem.Image")));
            this.дополнительныеВидыЗадачToolStripMenuItem.Name = "дополнительныеВидыЗадачToolStripMenuItem";
            this.дополнительныеВидыЗадачToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
            this.дополнительныеВидыЗадачToolStripMenuItem.Text = "Дополнительные виды задач";
            this.дополнительныеВидыЗадачToolStripMenuItem.Click += new System.EventHandler(this.дополнительныеВидыЗадачToolStripMenuItem_Click);
            // 
            // поискПоГлубинуToolStripMenuItem
            // 
            this.поискПоГлубинуToolStripMenuItem.Name = "поискПоГлубинуToolStripMenuItem";
            this.поискПоГлубинуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.поискПоГлубинуToolStripMenuItem.Text = "Поиск по глубину";
            this.поискПоГлубинуToolStripMenuItem.Click += new System.EventHandler(this.поискПоГлубинуToolStripMenuItem_Click);
            // 
            // поискПоШиринуToolStripMenuItem
            // 
            this.поискПоШиринуToolStripMenuItem.Name = "поискПоШиринуToolStripMenuItem";
            this.поискПоШиринуToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.поискПоШиринуToolStripMenuItem.Text = "Поиск по ширину";
            this.поискПоШиринуToolStripMenuItem.Click += new System.EventHandler(this.поискПоШиринуToolStripMenuItem_Click);
            // 
            // прорывВодыToolStripMenuItem
            // 
            this.прорывВодыToolStripMenuItem.Name = "прорывВодыToolStripMenuItem";
            this.прорывВодыToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.прорывВодыToolStripMenuItem.Text = "Прорыв воды";
            this.прорывВодыToolStripMenuItem.Click += new System.EventHandler(this.прорывВодыToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("помощьToolStripMenuItem.Image")));
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WaterfullDigitalClasses.Properties.Resources._1920x1080_navodnenie_nature_floods_priroda_after_flood;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(923, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование наводнений";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяЗадачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТекущийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьМножествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезапускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельУправлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеВидыЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слайдшоуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоГлубинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоШиринуToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem прорывВодыToolStripMenuItem;
    }
}

