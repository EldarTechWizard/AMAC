﻿using AMAC.Views.AdopterManagement;
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
            view.OnClickChoosePhotoButton += OnClickChoosePhotoButton;
            view.OnClickSelectRowGridControl += OnClickSelectRowGridControl;
            view.OnChangedAdopterIdTextBox += OnChangedAdopterIdTextBox;
            view.OnLoadForm += OnLoadForm;
        }

        private void OnChangedAdopterIdTextBox(object sender, EventArgs e)
        {
            try
            {
                DataTable data = view.DataSource;
                DataRow row = data.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAnimal") == (int)view.Id);

                if (row != null)
                {
                    view.NameA = (string)row["name"];
                    view.Age = (int)row["age"];
                    view.PicturePath = (string)row["photo"];
                    view.Age = (int)row["age"];
                    view.Sex = (string)row["sex"];
                    view.AnimalBreed = (string)row["breed"];
                    view.AnimalType = (string)row["animalType"];
                    view.Status = (string)row["status"];
                    view.AdditionalInformation = (string)row["additionalInformation"];
                    view.RescuedDate = (DateTime)row["rescueDate"];
                    view.TemporaryHome = (string)row["temporaryHome"];
                    view.Rescuer = (string)row["rescuer"];
                    view.Veterinarian = (string)row["veterinarian"];
                    view.Diagnostic = (string)row["diagnostic"];

                    view.ChangeEditMode(true);

                    return;
                }

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

        private void OnLoadForm(object sender, EventArgs e)
        {
            try
            {
                ReloadInformation();
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
                    AdditionalInformation = view.AdditionalInformation,
                    RescueDate = view.RescuedDate,
                    TempHome = view.TemporaryHome,
                    Rescuer = view.Rescuer,
                    Vet = view.Veterinarian,
                    Diagnostic = view.Diagnostic,
                };


                if (view.EditMode) UpdateRecord(record);
                else SaveRecord(record);


                ReloadInformation();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveRecord(PetReport record)
        {
            if (!repository.InsertRecord(record)) throw new Exception(repository.LastError);

            view.ClearFields();
        }

        private void UpdateRecord(PetReport record)
        {
            if (!repository.UpdateRecord(record)) throw new Exception(repository.LastError);
        }
    }
}
