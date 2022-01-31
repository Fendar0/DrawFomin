using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawNikonov
{
    public partial class Form1 : Form
    {
        int w = 50, h = 50;
        int old_x, old_y;
        List<Figure> lst = new List<Figure>();
        SolidBrush br = new SolidBrush(Color.FromArgb(255, 255, 255));
        int index;
        int buf;    
        
        public Form1()
        {
            InitializeComponent();
        }

        Figure createFigure(string fig_type)
        {
            switch (fig_type)
            {
                case "Circle": return new Circle();
                case "Square": return new Square();
                case "Triangle": return new Triangle();
            }
            return null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {            
            Figure fig = createFigure(comboBoxFigure.SelectedItem.ToString());
            if (fig == null) return;
            fig.pos_x = 100.0f;
            fig.pos_y = 100.0f;
            ListFigure.Items.Add(fig.id);
            lst.Add(fig);
            Pictures.Invalidate();
        }

        private void Pictures_MouseMove(object sender, MouseEventArgs e)
        {                            
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;

                foreach (Figure fig in lst)
                {
                    if (fig.selected == false) continue;
                    fig.pos_x += dx;
                    fig.pos_y += dy;
                }
                Pictures.Invalidate();
            }
            old_x = e.X;
            old_y = e.Y;
        }

        private void Pictures_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Figure fig in lst)
                fig.selected = false;

            /*if (ModifierKeys == Keys.Shift && e.Button == MouseButtons.Left)   // doesn't work
            {
                for (int i = lst.Count - 1; i >= 0; i--)
                {
                    Figure fig = lst[i];
                    fig.selected |= fig.test(e.X, e.Y);
                    if (fig.selected == true)
                    {
                        for(int j = 0; j < lst.Count - 1; j ++)
                            lst2[j] = lst[i];
                        listBox1.SetSelected(i, true);
                        if (i == index)
                        {
                            fig.selected = true;
                        }

                        break;
                    }
                }
            }
            else
            {*/
                for (int i = lst.Count - 1; i >= 0; i--)
                {
                    ListFigure.SetSelected(buf, false);
                    Figure fig = lst[i];
                    fig.selected |= fig.test(e.X, e.Y);
                    if (fig.selected == true)
                    {
                        ListFigure.SetSelected(i, true);
                        buf = i;
                        break;
                    }
                }
           // }
            Pictures.Invalidate();            
        }

        private void Pictures_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(br, 0, 0, Pictures.Width, Pictures.Height);
            foreach (Figure fig in lst)
                fig.draw(e.Graphics);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = ListFigure.SelectedIndex;
            selectList(index);
        }

        private void selectList(int index)
        {
            foreach (Figure fig in lst)
                fig.selected = false;

            for (int i = lst.Count - 1; i >= 0; i--)
            {
                Figure fig = lst[i];
                if (i == index)
                {
                    fig.selected = true;
                }
            }
            Pictures.Invalidate();
        }
      
        private void Form1_Resize(object sender, EventArgs e)
        {
            w = ClientRectangle.Width - 230;
            h = ClientRectangle.Height - Pictures.Top - 10;

            Pictures.Width = w;
            Pictures.Height = h;
        }
         
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buf = 0;
            for (int j = lst.Count - 1; j >= 0; j--)
            {
                if (j == index)
                {
                    lst.RemoveAt(index);
                    ListFigure.Items.RemoveAt(index);
                }
            }

            int i = 0;
            while (i < lst.Count) 
            {
                if (lst[i].selected == true)
                {
                    lst.RemoveAt(i);
                    ListFigure.Items.RemoveAt(i);
                }
                i++;
            }            
            Pictures.Invalidate();
        }


    }
}
