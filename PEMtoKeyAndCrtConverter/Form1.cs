namespace PEMtoKeyAndCrtConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load saved preferences from the registry
            LoadPreferences();
        }
        private void SavePreferences()
        {
            // Save paths to the registry
            RegistryHelper.Write("Paths", "PrivKeyPath", txtPrivKeyPath.Text);
            RegistryHelper.Write("Paths", "FullChainPath", txtFullChainPath.Text);
            RegistryHelper.Write("Paths", "KeyOutputPath", txtKeyFilename.Text);
            RegistryHelper.Write("Paths", "CrtOutputPath", txtCrtFilename.Text);
        }

        private void LoadPreferences()
        {
            // Load paths from the registry
            txtPrivKeyPath.Text = RegistryHelper.Read("Paths", "PrivKeyPath")?.ToString() ?? string.Empty;
            txtFullChainPath.Text = RegistryHelper.Read("Paths", "FullChainPath")?.ToString() ?? string.Empty;
            txtKeyFilename.Text = RegistryHelper.Read("Paths", "KeyOutputPath")?.ToString() ?? "private.key";
            txtCrtFilename.Text = RegistryHelper.Read("Paths", "CrtOutputPath")?.ToString() ?? "certificate.crt";
        }
        private void btnBrowsePrivKey_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Private Key Files (*.pem)|*.pem|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPrivKeyPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseFullChain_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Full Chain Files (*.pem)|*.pem|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFullChainPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseKeyOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Key Files (*.key) , (*.pem)|*.key;*.pem|All Files (*.*)|*.*";
                saveFileDialog.FileName = "private.key"; // Default filename
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtKeyFilename.Text = saveFileDialog.FileName;
                }
            }
        }

        private void btnBrowseCrtOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Certificate Files (*.crt) , (*.pem)|*.crt;*.pem|All Files (*.*)|*.*";
                saveFileDialog.FileName = "certificate.crt"; // Default filename
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCrtFilename.Text = saveFileDialog.FileName;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string privKeyPath = txtPrivKeyPath.Text;
            string fullChainPath = txtFullChainPath.Text;
            string keyOutputPath = txtKeyFilename.Text; // Full path for key
            string crtOutputPath = txtCrtFilename.Text; // Full path for certificate

            if (File.Exists(privKeyPath) && File.Exists(fullChainPath) &&
                !string.IsNullOrWhiteSpace(keyOutputPath) &&
                !string.IsNullOrWhiteSpace(crtOutputPath))
            {
                try
                {
                    // Copy and overwrite files at specified paths
                    File.Copy(privKeyPath, keyOutputPath, true);
                    File.Copy(fullChainPath, crtOutputPath, true);

                    lblStatus.Text = "Conversion successful!";
                    SavePreferences(); // Save paths after successful conversion
                }
                catch (Exception ex)
                {
                    lblStatus.Text = $"Error: {ex.Message}";
                }
            }
            else
            {
                lblStatus.Text = "Invalid file paths or output locations!";
            }
        }


    }
}
    
