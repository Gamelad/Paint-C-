
namespace PaintXs_mini
{
    partial class PaintXs
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintXs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bth_text = new System.Windows.Forms.Button();
            this.size_scroll = new System.Windows.Forms.TrackBar();
            this.group_file = new System.Windows.Forms.GroupBox();
            this.bth_open = new System.Windows.Forms.Button();
            this.bth_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bth_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.setka = new System.Windows.Forms.Button();
            this.bth_fill = new System.Windows.Forms.Button();
            this.bth_line = new System.Windows.Forms.Button();
            this.bth_ellipse = new System.Windows.Forms.Button();
            this.bth_clear = new System.Windows.Forms.Button();
            this.bth_pencil = new System.Windows.Forms.Button();
            this.bth_rect = new System.Windows.Forms.Button();
            this.bth_eraser = new System.Windows.Forms.Button();
            this.menu_parabola = new System.Windows.Forms.MenuStrip();
            this.vrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.введитеAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.создатьПараболуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дддToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снеговикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size_scroll)).BeginInit();
            this.group_file.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menu_parabola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 137);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.bth_text);
            this.panel3.Controls.Add(this.size_scroll);
            this.panel3.Controls.Add(this.group_file);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.menu_parabola);
            this.panel3.Location = new System.Drawing.Point(391, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 134);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 46);
            this.textBox1.TabIndex = 16;
            this.textBox1.Visible = false;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // bth_text
            // 
            this.bth_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bth_text.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_текст_48;
            this.bth_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_text.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_text.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_text.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_text.ForeColor = System.Drawing.Color.White;
            this.bth_text.Location = new System.Drawing.Point(725, 12);
            this.bth_text.Name = "bth_text";
            this.bth_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bth_text.Size = new System.Drawing.Size(39, 37);
            this.bth_text.TabIndex = 10;
            this.bth_text.UseVisualStyleBackColor = true;
            this.bth_text.Click += new System.EventHandler(this.bth_text_Click);
            // 
            // size_scroll
            // 
            this.size_scroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.size_scroll.Location = new System.Drawing.Point(284, 68);
            this.size_scroll.Maximum = 50;
            this.size_scroll.Name = "size_scroll";
            this.size_scroll.Size = new System.Drawing.Size(586, 69);
            this.size_scroll.TabIndex = 3;
            this.size_scroll.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // group_file
            // 
            this.group_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_file.Controls.Add(this.bth_open);
            this.group_file.Controls.Add(this.bth_save);
            this.group_file.ForeColor = System.Drawing.Color.White;
            this.group_file.Location = new System.Drawing.Point(770, 0);
            this.group_file.Name = "group_file";
            this.group_file.Size = new System.Drawing.Size(100, 70);
            this.group_file.TabIndex = 13;
            this.group_file.TabStop = false;
            this.group_file.Text = "Файл";
            // 
            // bth_open
            // 
            this.bth_open.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_открыть_папку_48;
            this.bth_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_open.ForeColor = System.Drawing.Color.White;
            this.bth_open.Location = new System.Drawing.Point(51, 25);
            this.bth_open.Name = "bth_open";
            this.bth_open.Size = new System.Drawing.Size(39, 37);
            this.bth_open.TabIndex = 10;
            this.bth_open.UseVisualStyleBackColor = true;
            this.bth_open.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // bth_save
            // 
            this.bth_save.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_сохранить_48;
            this.bth_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_save.ForeColor = System.Drawing.Color.White;
            this.bth_save.Location = new System.Drawing.Point(6, 25);
            this.bth_save.Name = "bth_save";
            this.bth_save.Size = new System.Drawing.Size(39, 37);
            this.bth_save.TabIndex = 8;
            this.bth_save.UseVisualStyleBackColor = true;
            this.bth_save.Click += new System.EventHandler(this.bth_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bth_color);
            this.groupBox1.Controls.Add(this.pic_color);
            this.groupBox1.Controls.Add(this.setka);
            this.groupBox1.Controls.Add(this.bth_fill);
            this.groupBox1.Controls.Add(this.bth_line);
            this.groupBox1.Controls.Add(this.bth_ellipse);
            this.groupBox1.Controls.Add(this.bth_clear);
            this.groupBox1.Controls.Add(this.bth_pencil);
            this.groupBox1.Controls.Add(this.bth_rect);
            this.groupBox1.Controls.Add(this.bth_eraser);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 131);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // bth_color
            // 
            this.bth_color.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_выбор_цвета_48;
            this.bth_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_color.ForeColor = System.Drawing.Color.White;
            this.bth_color.Location = new System.Drawing.Point(7, 25);
            this.bth_color.Name = "bth_color";
            this.bth_color.Size = new System.Drawing.Size(39, 37);
            this.bth_color.TabIndex = 1;
            this.bth_color.UseVisualStyleBackColor = true;
            this.bth_color.Click += new System.EventHandler(this.bth_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_color.Location = new System.Drawing.Point(232, 25);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(39, 37);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.button1_Click);
            // 
            // setka
            // 
            this.setka.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_хештег_2_40;
            this.setka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.setka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.setka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setka.ForeColor = System.Drawing.Color.White;
            this.setka.Location = new System.Drawing.Point(187, 68);
            this.setka.Name = "setka";
            this.setka.Size = new System.Drawing.Size(39, 37);
            this.setka.TabIndex = 9;
            this.setka.UseVisualStyleBackColor = true;
            this.setka.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bth_fill
            // 
            this.bth_fill.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_цвет_заливки_48;
            this.bth_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_fill.ForeColor = System.Drawing.Color.White;
            this.bth_fill.Location = new System.Drawing.Point(52, 25);
            this.bth_fill.Name = "bth_fill";
            this.bth_fill.Size = new System.Drawing.Size(39, 37);
            this.bth_fill.TabIndex = 2;
            this.bth_fill.UseVisualStyleBackColor = true;
            this.bth_fill.Click += new System.EventHandler(this.bth_fill_Click);
            // 
            // bth_line
            // 
            this.bth_line.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_вертикальная_линия_48;
            this.bth_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_line.ForeColor = System.Drawing.Color.White;
            this.bth_line.Location = new System.Drawing.Point(142, 68);
            this.bth_line.Name = "bth_line";
            this.bth_line.Size = new System.Drawing.Size(39, 37);
            this.bth_line.TabIndex = 6;
            this.bth_line.UseVisualStyleBackColor = true;
            this.bth_line.Click += new System.EventHandler(this.bth_line_Click);
            // 
            // bth_ellipse
            // 
            this.bth_ellipse.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_внутри_тонкой_окружности_48;
            this.bth_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_ellipse.ForeColor = System.Drawing.Color.White;
            this.bth_ellipse.Location = new System.Drawing.Point(52, 68);
            this.bth_ellipse.Name = "bth_ellipse";
            this.bth_ellipse.Size = new System.Drawing.Size(39, 37);
            this.bth_ellipse.TabIndex = 4;
            this.bth_ellipse.UseVisualStyleBackColor = true;
            this.bth_ellipse.Click += new System.EventHandler(this.bth_ellipse_Click);
            // 
            // bth_clear
            // 
            this.bth_clear.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_веник_поднимает_облако_пыли_48;
            this.bth_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_clear.ForeColor = System.Drawing.Color.White;
            this.bth_clear.Location = new System.Drawing.Point(142, 25);
            this.bth_clear.Name = "bth_clear";
            this.bth_clear.Size = new System.Drawing.Size(39, 37);
            this.bth_clear.TabIndex = 7;
            this.bth_clear.UseVisualStyleBackColor = true;
            this.bth_clear.Click += new System.EventHandler(this.bth_clear_Click);
            // 
            // bth_pencil
            // 
            this.bth_pencil.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_кончик_карандаша_481;
            this.bth_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_pencil.ForeColor = System.Drawing.Color.White;
            this.bth_pencil.Location = new System.Drawing.Point(6, 68);
            this.bth_pencil.Name = "bth_pencil";
            this.bth_pencil.Size = new System.Drawing.Size(39, 37);
            this.bth_pencil.TabIndex = 2;
            this.bth_pencil.UseVisualStyleBackColor = true;
            this.bth_pencil.Click += new System.EventHandler(this.bth_pencil_Click);
            // 
            // bth_rect
            // 
            this.bth_rect.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_прямоугольник_48;
            this.bth_rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_rect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_rect.ForeColor = System.Drawing.Color.White;
            this.bth_rect.Location = new System.Drawing.Point(97, 68);
            this.bth_rect.Name = "bth_rect";
            this.bth_rect.Size = new System.Drawing.Size(39, 37);
            this.bth_rect.TabIndex = 5;
            this.bth_rect.UseVisualStyleBackColor = true;
            this.bth_rect.Click += new System.EventHandler(this.bth_rect_Click);
            // 
            // bth_eraser
            // 
            this.bth_eraser.BackgroundImage = global::PaintXs_mini.Properties.Resources.icons8_ластик_48;
            this.bth_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bth_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bth_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.bth_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bth_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bth_eraser.ForeColor = System.Drawing.Color.White;
            this.bth_eraser.Location = new System.Drawing.Point(97, 25);
            this.bth_eraser.Name = "bth_eraser";
            this.bth_eraser.Size = new System.Drawing.Size(39, 37);
            this.bth_eraser.TabIndex = 3;
            this.bth_eraser.UseVisualStyleBackColor = true;
            this.bth_eraser.Click += new System.EventHandler(this.bth_eraser_Click);
            // 
            // menu_parabola
            // 
            this.menu_parabola.BackColor = System.Drawing.Color.Transparent;
            this.menu_parabola.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_parabola.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_parabola.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_parabola.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vrToolStripMenuItem,
            this.дддToolStripMenuItem});
            this.menu_parabola.Location = new System.Drawing.Point(284, 9);
            this.menu_parabola.Name = "menu_parabola";
            this.menu_parabola.Size = new System.Drawing.Size(88, 32);
            this.menu_parabola.TabIndex = 15;
            this.menu_parabola.Text = "menuStrip1";
            // 
            // vrToolStripMenuItem
            // 
            this.vrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.введитеAToolStripMenuItem,
            this.toolStripSeparator1,
            this.создатьПараболуToolStripMenuItem});
            this.vrToolStripMenuItem.Image = global::PaintXs_mini.Properties.Resources.icons8_текст_отчета_в_виде_графика_48;
            this.vrToolStripMenuItem.Name = "vrToolStripMenuItem";
            this.vrToolStripMenuItem.Size = new System.Drawing.Size(40, 28);
            // 
            // введитеAToolStripMenuItem
            // 
            this.введитеAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.введитеAToolStripMenuItem.Name = "введитеAToolStripMenuItem";
            this.введитеAToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.введитеAToolStripMenuItem.Text = "Введите a:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // создатьПараболуToolStripMenuItem
            // 
            this.создатьПараболуToolStripMenuItem.Name = "создатьПараболуToolStripMenuItem";
            this.создатьПараболуToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.создатьПараболуToolStripMenuItem.Text = "Создать параболу";
            this.создатьПараболуToolStripMenuItem.Click += new System.EventHandler(this.создатьПараболуToolStripMenuItem_Click);
            // 
            // дддToolStripMenuItem
            // 
            this.дддToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.снеговикToolStripMenuItem});
            this.дддToolStripMenuItem.Image = global::PaintXs_mini.Properties.Resources.icons8_очень_большие_иконки_40;
            this.дддToolStripMenuItem.Name = "дддToolStripMenuItem";
            this.дддToolStripMenuItem.Size = new System.Drawing.Size(40, 28);
            // 
            // снеговикToolStripMenuItem
            // 
            this.снеговикToolStripMenuItem.Name = "снеговикToolStripMenuItem";
            this.снеговикToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.снеговикToolStripMenuItem.Text = "Снеговик ";
            this.снеговикToolStripMenuItem.Click += new System.EventHandler(this.снеговикToolStripMenuItem_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::PaintXs_mini.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(0, 0);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(395, 134);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 4;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1273, 704);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PaintXs_mini.Properties.Resources.Interface_Builder_App;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(232, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 37);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // PaintXs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_parabola;
            this.Name = "PaintXs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintXs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size_scroll)).EndInit();
            this.group_file.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menu_parabola.ResumeLayout(false);
            this.menu_parabola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button bth_color;
        private System.Windows.Forms.Button bth_line;
        private System.Windows.Forms.Button bth_rect;
        private System.Windows.Forms.Button bth_ellipse;
        private System.Windows.Forms.Button bth_eraser;
        private System.Windows.Forms.Button bth_pencil;
        private System.Windows.Forms.Button bth_fill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button bth_save;
        private System.Windows.Forms.Button bth_clear;
        private System.Windows.Forms.TrackBar size_scroll;
        private System.Windows.Forms.Button setka;
        private System.Windows.Forms.Button bth_open;
        private System.Windows.Forms.GroupBox group_file;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menu_parabola;
        private System.Windows.Forms.ToolStripMenuItem vrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem введитеAToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem создатьПараболуToolStripMenuItem;
        private System.Windows.Forms.Button bth_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem дддToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снеговикToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

