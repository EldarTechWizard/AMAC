using AMAC.Views.AdopterManagement;
using AMAC.Views.AnimalManagement;
using DbManagmentAMAC.Models;
using DevExpress.XtraLayout.Resizing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AMAC.Presenters
{
    public class AnimalManagementPresenter
    {
        private IAnimalManagementView view;
        private IRepository repository;

        public AnimalManagementPresenter(IAnimalManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickSaveAndEditAnimalButton += OnClickSaveAndEditAnimalButton;
            view.OnClickDeleteAnimalButton += OnClickDeleteAnimalButton;
            view.OnClickGenerateInsertButton += OnClickGenerateInsertButton;
            view.OnClickChoosePhotoButton += OnClickChoosePhotoButton;
            view.OnClickSelectRowGridControl += OnClickSelectRowGridControl;
            view.OnChangedAdopterIdTextBox += OnChangedAdopterIdTextBox;
            view.OnLoadForm += OnLoadForm;
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                ReloadInformation();
                SetInsertMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReloadInformation()
        {
            DataTable data = new DataTable();
            if (!repository.SelectRecord(data)) throw new Exception(repository.LastError);
            view.DataSource = data;
        }
        private void OnClickGenerateInsertButton(object sender, EventArgs e)
        {
            try
            {
                SetInsertMode();
            }            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetInsertMode()
        {
            int value = 0;

            if (!repository.GetIdentityNextValue(ref value, "animal")) throw new Exception(repository.LastError);

            view.Id = value;
        }

        private void OnChangedAdopterIdTextBox(object sender, EventArgs e)
        {
            try
            {
                DataTable data = view.DataSource;
                DataRow row = data.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("id") == (int)view.Id);

                if (row != null)
                {
                    view.NameA = (string)row["nombre"];
                    view.Age = (int)row["edad"];
                    view.PicturePath = (string)row["foto"];
                    view.Sex = (string)row["sexo"];
                    view.AnimalBreed = (string)row["raza"];
                    view.AnimalType = (string)row["tipo de animal"];
                    view.Status = (string)row["estado"];
                    view.AdditionalInformation = (string)row["informacion adicional"];
                    view.RescuedDate = (DateTime)row["fecha de rescate"];
                    view.TemporaryHome = (string)row["hogar temporal"];
                    view.Rescuer = (string)row["rescatista"];
                    view.Veterinarian = (string)row["veterinario"];
                    view.Diagnostic = (string)row["diagnostico"];
                    view.Sterilized = (bool)row["esterilizado"];

                    view.ChangeEditMode(true);

                    return;
                }


                view.ClearFields();
                view.ChangeEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickSelectRowGridControl(object sender, EventArgs e)
        {
            try
            {
                view.LoadInfoFromSelectedRow();
                view.ChangeEditMode(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void OnClickChoosePhotoButton(object sender, EventArgs e)
        {
            view.ChooseImage();
        }

        private void OnClickDeleteAnimalButton(object sender, EventArgs e)
        {
            try
            {
                if (view.Id == -1) return;
                if (!repository.DeleteRecord(view.Id)) throw new Exception(repository.LastError);

                ReloadInformation();
                view.ClearFields();

                MessageBox.Show("Correcto");
                view.ChangeEditMode(false );
                SetInsertMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnClickSaveAndEditAnimalButton(object sender, EventArgs e)
        {
            try
            {

                PetReport record = new PetReport()
                {
                    Id = view.Id,
                    PicturePath = view.PicturePath,
                    Name = view.NameA,
                    Age = view.Age,
                    Sex = view.Sex,
                    AnimalBreed = view.AnimalBreed,
                    AnimalType = view.AnimalType,
                    Status = view.Status,
                    Sterilized = view.Sterilized,
                    AdditionalInformation = view.AdditionalInformation,
                    RescueDate = view.RescuedDate,
                    TempHome = view.TemporaryHome,
                    Rescuer = view.Rescuer,
                    Vet = view.Veterinarian,
                    Diagnostic = view.Diagnostic,
                };


                if (view.EditMode) UpdateRecord(record);
                else SaveRecord(record);

                view.ChangeEditMode(false);
                SetInsertMode();
                ReloadInformation();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveRecord(PetReport record)
        {
            record.BirthDate = record.RescueDate.AddMonths(-record.Age);

            if (!repository.InsertRecord(record)) throw new Exception(repository.LastError);

            view.ClearFields();
        }

        private void UpdateRecord(PetReport record)
        {
            if (!repository.UpdateRecord(record)) throw new Exception(repository.LastError);
        }
    }
}
