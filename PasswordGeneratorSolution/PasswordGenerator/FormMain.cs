namespace PasswordGenerator {
    /// <summary>Главная форма</summary>
    public partial class FormMain : Form {
        /// <summary>Текст доступной кнопки генерации пароля</summary>
        private const string BUTTON_GENERATE_TEXT_ENABLED = "Сгенерировать пароль и\nскопировать его в буфер обмена";

        /// <summary>Текст недоступной кнопки генерации пароля</summary>
        private const string BUTTON_GENERATE_TEXT_DISABLED = "Необходимо выбрать хотя бы одну галочку используемых символов";

        /// <summary>Список чекбоксов в панели используемых символов</summary>
        private readonly List<CheckBox> UsingSymbolsCheckboxes = new();

        /// <summary>Создаёт главную форму</summary>
        public FormMain() {
            this.InitializeComponent();

            // Заполнение списка чекбоксов
            foreach (Control control in this.GroupBox_UsingSymbols.Controls) {
                if (control is CheckBox control_as_checkbox) {
                    this.UsingSymbolsCheckboxes.Add(control_as_checkbox);
                }
            }

            // Добавление проверки при изменении состояния чекбоксов
            foreach (CheckBox checkBox in this.UsingSymbolsCheckboxes) {
                checkBox.CheckedChanged += this.UsingSymbolsCheckBox_CheckedChanged;
            }

            // Обновляем состояние кнопки генерации
            this.UsingSymbolsCheckBox_CheckedChanged(null, null);
        }

        /// <summary>Событие изменения состояния чекбокса в панели используемых символов</summary>
        private void UsingSymbolsCheckBox_CheckedChanged(object? sender, EventArgs? e) {
            // Кнопка генерации пароля будет недоступна, если не выбрана ни одна из галочек используемых символов
            bool is_button_enabled = false;
            foreach (CheckBox checkBox in this.UsingSymbolsCheckboxes) {
                if (checkBox.Checked) {
                    is_button_enabled = true;
                }
            }

            // Меняем доступность кнопки, а также её текст
            this.Button_Generate.Enabled = is_button_enabled;
            this.Button_Generate.Text = this.Button_Generate.Enabled ? BUTTON_GENERATE_TEXT_ENABLED : BUTTON_GENERATE_TEXT_DISABLED;
        }

        /// <summary>Событие нажатия на кнопку генерации нового пароля</summary>
        private void Button_Generate_Click(object sender, EventArgs e) {
            // Список символов, которые могут быть в пароле
            string alphabet = "";
            foreach (CheckBox checkBox in this.UsingSymbolsCheckboxes) {
                if (checkBox.Checked) {
                    alphabet += checkBox.Text;
                }
            }

            // Длина генерируемого пароля
            decimal password_length = this.NumericUpDown_PasswordLength.Value;

            // Генерация пароля
            string password = "";
            for (int i = 0; i < password_length; i++) {
                int symbol_id = Random.Shared.Next(0, alphabet.Length);
                password += alphabet[symbol_id];
            }

            // Сохраняем текст в буфер обмена
            Clipboard.SetText(password);
        }
    }
}