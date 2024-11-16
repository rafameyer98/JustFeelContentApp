using JustFeelContentApp.Services;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using System;
using JustFeelContentApp.ViewModels;

namespace JustFeelContentApp.Views
{
    public partial class UploadContentPage : ContentPage
    {
        private string _selectedFilePath;
        public UploadContentPage()
        {
            InitializeComponent();
        }

        // Método para selecionar um arquivo
        private async void OnSelectFileClicked(object sender, EventArgs e)
        {
            try
            {
                // Usando o FilePicker para selecionar um arquivo
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Escolha o arquivo de conteúdo"
                });

                if (result != null)
                {
                    _selectedFilePath = result.FullPath;
                    StatusLabel.Text = $"Arquivo Selecionado: {result.FileName}";
                    UploadButton.IsEnabled = true;  // Habilitar o botão de upload
                }
                else
                {
                    StatusLabel.Text = "Nenhum arquivo selecionado.";
                    UploadButton.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                StatusLabel.Text = $"Erro: {ex.Message}";
            }
        }

        // Método para fazer o upload do arquivo
        private async void OnUploadButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedFilePath))
            {
                StatusLabel.Text = "Nenhum arquivo selecionado.";
                return;
            }

            var uploadService = new UploadService();

            bool uploadSuccessful = await uploadService.UploadFileAsync(_selectedFilePath);

            if (uploadSuccessful)
            {
                StatusLabel.Text = "Upload realizado com sucesso!";
            }
            else
            {
                StatusLabel.Text = "Falha no upload.";
            }
        }
    }
}
    
