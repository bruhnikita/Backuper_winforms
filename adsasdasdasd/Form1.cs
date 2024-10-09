namespace BackupUtil_Winfoms
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void CreateBackupButton_Click(object sender, EventArgs e)
        {
            string sourcePath = @sourcePathTextBox.Text;
            string destinationPath = @destinationPathTextBox.Text;

            if (string.IsNullOrWhiteSpace(sourcePath) || string.IsNullOrWhiteSpace(destinationPath))
            {
                MessageBox.Show("Заполните оба поля ввода.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Исходный путь не существует.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(destinationPath))
            {
                MessageBox.Show("Путь назначения не существует.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(sourcePath);

                string backupFolder = Path.Combine(destinationPath, "Backup");

                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string backupFile = Path.Combine(backupFolder, fileName);

                    File.Copy(file, backupFile, true);
                }

                MessageBox.Show("Резервная копия создана.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка резервного копирования: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RollBackButton_Click(object sender, EventArgs e)
        {
            string sourcePath = @sourcePathTextBox.Text;
            string destinationPath = @destinationPathTextBox.Text;

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Папка для восстановления не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(destinationPath))
            {
                MessageBox.Show("Папка с бекапом не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(sourcePath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationFile = Path.Combine(destinationPath, fileName);

                    File.Copy(file, destinationFile, true);
                }

                MessageBox.Show("Восстановление проведено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка восстановления: " + ex.Message);
            }
        }
    }
}
