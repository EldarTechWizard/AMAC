﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAC.Views.FormatManagement.FormatUpdateView.FormatUpdateAnimal
{
    public interface IFormatUpdateAnimalView
    {
        int Id { get; set; }
        string NameA { get; set; }
        int Age { get; set; }
        string AnimalType {  get; set; }
        string AnimalBreed { get; set; }
        string Status { get; set; }
        string Sex { get; set; }
        bool Sterilized { get; set; }
        string AdditionalInformation { get; set; }

        event EventHandler OnChangeAdopterIdTextBox;
        event EventHandler OnClickSearchAdopterPictureEdit;
        DataRow OpenSearchTableTab(DataTable data);
        void ClearAnimalFields();
    }
}
