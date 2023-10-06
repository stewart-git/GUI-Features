using System;

namespace GUI_Features
{
    internal class MotorBike : IComparable<MotorBike>
    {
        private string model;
        private string manufacturer;
        private string style;
        private int capacity;
        private string[] accessories;
        public string GetModel()
        {
            return model;
        }
        public void SetModel(string newModel)
        {
            if (string.IsNullOrEmpty(newModel))
                model = "Not Recorded";
            else
                model = newModel;
        }
        public string GetManufacturer()
        {
            return manufacturer;
        }
        public void SetManufacturer(string _Manufacturer)
        {
            manufacturer = _Manufacturer;
        }
        public string GetStyle()
        {
            return style;
        }
        public void SetStyle(string newStyle)
        {
            if (string.IsNullOrEmpty(newStyle))
                style = "No Style";
            else
                style = newStyle;
        }
        public int GetCapacity()
        {
            return capacity;
        }
        public void SetCapacity(int newCapacity)
        {
            capacity = newCapacity;
        }
        public string[] GetAccessories()
        {
            return accessories;
        }
        public void SetAccessories(string[] accessories)
        {
            this.accessories = accessories;
        }
        public int CompareTo(MotorBike compareModel)
        {
            return model.CompareTo(compareModel.model);
        }
    }
}