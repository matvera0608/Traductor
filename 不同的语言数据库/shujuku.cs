using System;
using System.Windows.Forms;

namespace 不同的语言数据库
{
    public partial class shujuku : Form
    {
        fānyì word;
        public shujuku()
        {
            InitializeComponent();
        }
        public shujuku(string biāotí)
        {
            this.Text = biāotí;
            InitializeComponent();
            word = new fānyì();
        }
        //En este método contendrá las traducciones del idioma elegido por el usuario
        // por ejemplo pongo en el txBox y en el comboBox elijo riyu (japonés) me debe traducir
        private void cB_yǔyán_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cB_yǔyán.SelectedIndex;
            //Este if ayuda a controlar la lista de idiomas para que funcione correctamente, con el propósito de ir mejorando
            if (selectedIndex >= 0 && selectedIndex < cB_yǔyán.Items.Count)
            {
                //creé las variables necesarias para traducir la palabra
                string xuǎnzé_yǔyán = cB_yǔyán.Items[selectedIndex].ToString();
                //y acá lo actualizaré antes de guardar la variable de caja de texto
                //que tendrá la palabra solicitada en la variable tipo cadena
                word.Yǔyán = xuǎnzé_yǔyán;
                string cí = txBox_cí.Text;
                if (!string.IsNullOrEmpty(cí))
                {
                    //Tuve que anidar la condición de que la palabra sea igual Base de datos
                    //porque al poner else if se ejecutará la condición de que imprima el texto "翻译器只支持词语“数据库”" cuando está vacío
                    //para evitar que la ultima condicion no se cumpla, tuve que anidar
                    if (cí == "Base de datos")
                    {
                        string fānyì_cí = word.translate(cí);
                        lb_translation.Text = $"{cí} 在{xuǎnzé_yǔyán}中叫{fānyì_cí}";
                    }
                    else
                    {
                        lb_translation.Text = "翻译器只支持词语“数据库”";
                    }
                }
                 else
                {
                    lb_translation.Text = "写这个词";
                }
            }
        }
    }
}