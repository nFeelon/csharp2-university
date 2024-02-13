using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    [Serializable]
    public class Owner
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserFathername { get; set; }
        public string PassportNumber { get; set; }
        public string UserBirthday { get; set; }
    }

    [Serializable]
    public class Deposit
    {
        public int Number { get; set; }
        public string DepositType { get; set; }
        public int Balance { get; set; }
        public DateTime DateDeposit { get; set; }
        public bool Ads { get; set; }
        public bool Banking { get; set; }
        public bool SMS { get; set; }
        public string Info { get; set; }
        public Owner Owner { get; set; }
    }

    [Serializable]
    public class Account
    {
        public List<Deposit> DepositList { get; set; }
        public Owner Owner { get; set; }
        public Account()
        {
            Owner = new Owner();
            DepositList = new List<Deposit>();
        }
    }
}
