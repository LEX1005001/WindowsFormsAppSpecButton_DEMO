using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpecialButton
{
    public partial class SpecialButton1 : Button
    {
        public SpecialButton1()
        {
            InitializeComponent();

            //Установите значения свойств по умолчанию для кнопки во время запуска
            SetNormalValues();
        }

        /// <summary>
        /// Чтобы установить свойства кнопки, когда она не активна, т. е. когда кнопка не в фокусе.
        /// </summary>

        private void SetNormalValues()
        {
            this.Font = new Font("Verdana", 18F, FontStyle.Bold);
            this.BackColor = Color.Gray;
            this.ForeColor = Color.White;
            this.Margin = new Padding(4, 1, 4, 1);
            this.Padding = new Padding(4);
            this.MinimumSize = new Size(150, 35);
            this.Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// Установите атрибуты для выделения кнопки, когда она находится в фокусе/активна.
        /// + Изменение курсора
        /// </summary>

        private void SetValuesOnFocus()
        {
            //Increase the font size and colors on focus
            this.Font = new Font("Verdana", 20F, FontStyle.Bold);

            this.BackColor = Color.Red;
            this.ForeColor = Color.White;

            //Set the cursor to Hand type
            this.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Обработчик по умолчанию.
        /// </summary>
        /// <param name="pe"></param>

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        /// <summary>
        /// Обработчик событий, который вызывает метод SetValuesOnFocus() для выдачи аппециала
        /// эффект на кнопку, пока она активна
        /// </summary>
        /// <param name="e"></param>

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            SetValuesOnFocus();
        }

        /// <summary>
        /// Обработчик событий, который вызывает метод SetNormalValues() для возврата кнопки
        /// в нормальное состояние
        /// </summary>
        /// <param name="e"></param>

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SetNormalValues();
        }
    }
}