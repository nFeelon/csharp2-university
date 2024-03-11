using System;

namespace lab4_5
{
    enum DeviceType
    {
        Phone, Tablet, Laptop, PC, Other
    }
    internal class Product
    {
        private string _name;
        private DeviceType _type;
        private string _typeString;
        private string _description;
        private int _price;
        private string _fotourl;
        private Guid _id;

        public string Name { get => _name; set => _name = value; }
        public DeviceType Type { get => _type; set => _type = value; }
        public string TypeString { get => _typeString; set => _typeString = value; }
        public string Description { get => _description; set => _description = value; }
        public int Price { get => _price; set => _price = value; }
        public string FotoUrl { get => _fotourl; set => _fotourl = value; }
        public Guid ID { get => _id; set => _id = value; }

        public Product(string name, DeviceType type, string description, int price, string fotourl)
        {
            Name = name;
            Type = type;

            switch (Type)
            {
                case DeviceType.Phone: TypeString = "Phone"; break;
                case DeviceType.Tablet: TypeString = "Tablet"; break;
                case DeviceType.Laptop: TypeString = "Laptop"; break;
                case DeviceType.PC: TypeString = "PC"; break;
                case DeviceType.Other: TypeString = "Other"; break;
            }

            Description = description;
            Price = price;
            FotoUrl = fotourl;
            ID = new Guid();
        }
    }
}
