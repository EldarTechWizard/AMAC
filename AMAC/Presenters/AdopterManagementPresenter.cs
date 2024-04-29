using AMAC.Views.AdopterManagement;
using AMAC.Views.Main;
using DbManagmentAMAC.Models;
using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace AMAC.Presenters
{
    public class AdopterManagementPresenter
    {
        private IAdopterManagementView view;
        private IRepository repository;
        public AdopterManagementPresenter(IAdopterManagementView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            AssociateAndRaisedEvents();
        }

        private void AssociateAndRaisedEvents()
        {
            view.OnClickSelectRowGridControl += OnClickSelectRowGridControl;
            view.OnClickDeleteButton += OnClickDeleteButton;
            view.OnClickSaveAndEditButton += OnClickSaveAndEditButton;
            view.OnChangedAdopterIdTextBox += OnChangedAdopterIdTextBox;
            view.OnLoadForm += OnLoadForm;
            view.OnClickGenerateInsertButton += OnClickGenerateInsertButton;
        }

        private void OnClickGenerateInsertButton(object sender, EventArgs e)
        {
            try
            {
                SetInsertMode();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void SetInsertMode()
        {
            int value = 0;

            if (!repository.GetIdentityNextValue(ref value, "adopter")) throw new Exception(repository.LastError);

            view.Id = value;
        }

        private void ReloadInformation()
        {
            DataTable data = new DataTable();
            if (!repository.SelectAdopter(data)) throw new Exception(repository.LastError);
            view.DataSource = data;
        }

        private void OnChangedAdopterIdTextBox(object sender, EventArgs e)
        {
            try
            {
                DataTable data = view.DataSource;
                DataRow row = data.AsEnumerable().FirstOrDefault(rowD => rowD.Field<int>("idAdopter") == (int)view.Id);
                
                if(row != null)
                {
                    view.NameA = (string)row["name"];
                    view.Age = (int)row["age"];
                    view.Email = (string)row["email"];
                    view.Address = (string)row["address"];
                    view.Number = (string)row["phone"];
                    view.AdoptionCount = (int)row["adoptionCount"];
                    
                    view.ChangeEditMode(true);

                    if(view.AdoptionCount > 0)
                    {
                        view.ChangeDeleteMode(false);
                    }

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

        private void OnClickSaveAndEditButton(object sender, EventArgs e)
        {
            try
            {

                Adopter adopter = new Adopter
                {
                    Id = view.Id,
                    Name = view.NameA,
                    Age = view.Age,
                    Email = view.Email,
                    Address = view.Address,
                    Number = view.Number
                };


                if (view.EditMode) UpdateAdopter(adopter);
                else SaveAdopter(adopter);
         

                ReloadInformation();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAdopter(Adopter adopter)
        {
            if (!repository.InsertAdopter(adopter)) throw new Exception(repository.LastError);
            
            view.ClearFields();

            SetInsertMode();
        }

        private void UpdateAdopter(Adopter adopter)
        {
            if (!repository.UpdateAdopter(adopter)) throw new Exception(repository.LastError);

            MessageBox.Show("Cambios guardados correctamente");
        }

        private void OnClickDeleteButton(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.No) return;              
                if (view.Id == -1) return;
                if (!repository.DeleteAdopter(view.Id)) throw new Exception(repository.LastError);

                ReloadInformation();

                SetInsertMode();

                MessageBox.Show("Eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

